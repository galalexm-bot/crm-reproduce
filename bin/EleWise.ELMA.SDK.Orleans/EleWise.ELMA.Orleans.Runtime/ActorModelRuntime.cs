using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Orleans.CodeGeneration;
using EleWise.ELMA.Orleans.Configuration;
using EleWise.ELMA.Orleans.Extensions;
using EleWise.ELMA.Orleans.Providers;
using EleWise.ELMA.Orleans.Providers.Implementations;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.Extensions;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Microsoft.Extensions.Options;
using Orleans;
using Orleans.Configuration;
using Orleans.Runtime;
using Orleans.Streams;

namespace EleWise.ELMA.Orleans.Runtime;

public class ActorModelRuntime : AbstractProvider, IActorModelRuntimeProvider, IActorModelRuntime, IProvider, IConfigurableProvider, IDisposable
{
	private class SiloStatusListener : ISiloStatusListener
	{
		private TaskCompletionSource<bool> waiting;

		public Task Waiting => waiting.Task ?? Task.CompletedTask;

		public SiloStatusListener()
		{
			ResetWaiting();
		}

		void ISiloStatusListener.SiloStatusChangeNotification(SiloAddress updatedSilo, SiloStatus status)
		{
			waiting.TrySetResult(result: true);
		}

		public void ResetWaiting()
		{
			waiting = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
		}
	}

	private const string clusterId = "ELMA";

	private const string serviceId = "ELMA";

	private const int defaultSiloPort = 11111;

	private const int defaultGatewayPort = 30000;

	private readonly ILogger logger;

	private OrleansHostWrapper hostWrapper;

	private ISiloStatusOracle siloStatusOracle;

	private IGrainFactory grainFactory;

	private IStreamProvider streamProvider;

	private IClusteringProvider clusteringProvider;

	private IReminderServiceProvider reminderServiceProvider;

	private int siloPort;

	private int gatewayPort;

	private TimeSpan responseTimeout;

	private IAuthenticationService authService;

	private IAuthenticationService AuthService
	{
		get
		{
			if (authService == null)
			{
				authService = Locator.GetService<IAuthenticationService>();
			}
			return authService;
		}
	}

	public override Guid Uid => new Guid("6c0e6d2b-e1e9-4af2-95e3-2952bb352900");

	public override string Name => "ActorModelRuntime";

	public Guid LocalConnection => SiloStatusOracle.get_SiloAddress().ToGuid();

	public IEnumerable<Guid> ActiveConnections => SiloStatusOracle.GetApproximateSiloStatuses(true).Keys.Select(SiloAddressExtension.ToGuid);

	private ISiloStatusOracle SiloStatusOracle => siloStatusOracle ?? (siloStatusOracle = hostWrapper.GetService<ISiloStatusOracle>());

	private IGrainFactory GrainFactory => grainFactory ?? (grainFactory = hostWrapper.GetGrainFactory());

	private IStreamProvider StreamProvider => streamProvider ?? (streamProvider = hostWrapper.GetStreamProvider());

	public ActorModelRuntime()
	{
		logger = Logger.GetLogger(typeof(ActorModelRuntime));
	}

	public override ProviderSettingsSection CreateSettings()
	{
		return new ActorModelRuntimeSettingsSection();
	}

	public override void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration)
	{
		base.Configure(settings, configuration);
		List<int> list = (from listener in IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners()
			select listener.Port).ToList();
		siloPort = SelectPort("Orleans.SiloPort", 11111, list);
		gatewayPort = SelectPort("Orleans.GatewayPort", 30000, list.Union(new int[1] { siloPort }));
		responseTimeout = ((ActorModelRuntimeSettingsSection)settings).ResponseTimeout;
		List<int> list2 = list.Where((int p) => p == siloPort || p == gatewayPort).ToList();
		if (list2.Count > 0)
		{
			using (StartInformation.Operation(StartInformation.Current.Percent, SR.M("Ожидание освобождения портов для запуска Orleans Silo")))
			{
				for (int i = 0; i < 30; i++)
				{
					if (list2.Count <= 0)
					{
						break;
					}
					Thread.Sleep(1000);
					list2 = (from ep in IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners()
						select ep.Port into p
						where p == siloPort || p == gatewayPort
						select p).ToList();
				}
			}
			if (list2.Count > 0)
			{
				throw new ConfigurationInitializeException(SR.T("Сконфигурированные порты для запуска Orleans Silo заняты: {0}", string.Join(", ", list2)));
			}
		}
		ClusteringSettingsSection connectionSettings;
		try
		{
			connectionSettings = configuration.Config.Sections.OfType<ClusteringSettingsSection>().SingleOrDefault() ?? new ClusteringSettingsSection
			{
				ProviderType = typeof(DefaultClusteringProvider)
			};
		}
		catch (InvalidOperationException)
		{
			throw new ConfigurationInitializeException(SR.T("Более одной секции для конфигурирования типа провайдера для Orleans Clustering"));
		}
		clusteringProvider = ConfigureProvider<IClusteringProvider>(connectionSettings, configuration);
		ReminderServiceSettingsSection connectionSettings2;
		try
		{
			connectionSettings2 = configuration.Config.Sections.OfType<ReminderServiceSettingsSection>().SingleOrDefault() ?? new ReminderServiceSettingsSection
			{
				ProviderType = typeof(DefaultReminderServiceProvider)
			};
		}
		catch (InvalidOperationException)
		{
			throw new ConfigurationInitializeException(SR.T("Более одной секции для конфигурирования типа провайдера для службы напоминаний Orleans"));
		}
		reminderServiceProvider = ConfigureProvider<IReminderServiceProvider>(connectionSettings2, configuration);
	}

	public override void Init()
	{
		logger.Info("Building an assembly with native Orleans Grains.");
		Assembly assembly;
		try
		{
			assembly = GrainsAssemblyBuilder.Build();
			logger.Info($"The assembly was built successfully, # of types: {((assembly != null) ? assembly.ExportedTypes.Count() : 0)}.");
		}
		catch (Exception ex)
		{
			logger.Fatal("An error occurred while attempting to build the assembly: " + ex.Message, ex);
			throw;
		}
		if (assembly != null)
		{
			GrainFactoryExtensions.Init(assembly);
		}
		try
		{
			hostWrapper = new OrleansHostWrapper("ELMA", "ELMA", siloPort, gatewayPort, responseTimeout, assembly, clusteringProvider, reminderServiceProvider, () => AuthService);
			hostWrapper.Run().Wait();
		}
		catch (AggregateException ex2)
		{
			ExceptionDispatchInfo.Capture(ex2.InnerException).Throw();
		}
		CheckCluster().Wait();
	}

	public override void InitComplete()
	{
	}

	public override void Dispose()
	{
		if (hostWrapper != null)
		{
			hostWrapper.StopAsync().Wait();
		}
	}

	public TActorInterface GetActor<TActorInterface>(long primaryKey) where TActorInterface : IActorWithIntegerKey
	{
		return GrainFactory.GetActor<TActorInterface>(primaryKey);
	}

	public TActorInterface GetActor<TActorInterface>(string primaryKey) where TActorInterface : IActorWithStringKey
	{
		return GrainFactory.GetActor<TActorInterface>(primaryKey);
	}

	public TActorInterface GetActor<TActorInterface>(Guid primaryKey) where TActorInterface : IActorWithGuidKey
	{
		return GrainFactory.GetActor<TActorInterface>(primaryKey);
	}

	public TActorInterface GetActor<TActorInterface>(Guid primaryKey, string keyExtension) where TActorInterface : IActorWithGuidCompoundKey
	{
		return GrainFactory.GetActor<TActorInterface>(primaryKey, keyExtension);
	}

	public async Task<ISubscription> Subscribe<T>(Guid eventId, string eventNamespace, Func<T, Task> onPublish)
	{
		return new StreamSubscriptionHandleAdapter<T>(await AsyncObservableExtensions.SubscribeAsync<T>((IAsyncObservable<T>)(object)GetStream<T>(eventId, eventNamespace), (Func<T, StreamSequenceToken, Task>)((T i, StreamSequenceToken t) => onPublish(i))));
	}

	public Task Publish<T>(Guid eventId, string eventNamespace, T data)
	{
		return ((IAsyncObserver<T>)(object)GetStream<T>(eventId, eventNamespace)).OnNextAsync(data, (StreamSequenceToken)null);
	}

	internal T GetService<T>()
	{
		return hostWrapper.GetService<T>();
	}

	private IAsyncStream<T> GetStream<T>(Guid streamId, string streamNamespace)
	{
		return StreamProvider.GetStream<T>(streamId, streamNamespace);
	}

	private T ConfigureProvider<T>(ProviderSettingsSection connectionSettings, RuntimeConfiguration configuration)
	{
		Contract.ArgumentNotNull(connectionSettings, "connectionSettings");
		try
		{
			if (connectionSettings.ProviderType == null)
			{
				throw new InvalidOperationException(SR.T("Не задан тип провайдера"));
			}
			T obj = (T)Activator.CreateInstance(connectionSettings.ProviderType);
			if ((object)obj is IConfigurableProvider configurableProvider)
			{
				configurableProvider.Configure(connectionSettings, configuration);
			}
			return obj;
		}
		catch (Exception innerException)
		{
			throw new ConfigurationInitializeException(SR.T("Не удалось сконфигурировать провайдер по секции в конфигурации {0}", connectionSettings.SectionInformation.Name), innerException);
		}
	}

	private async Task CheckCluster()
	{
		IClasterInformationService clasterInformationService = Locator.GetServiceNotNull<IClasterInformationService>();
		Task checkCluster = Task.Run(async delegate
		{
			SiloStatusListener siloStatusListener = new SiloStatusListener();
			SiloStatusOracle.SubscribeToSiloStatusEvents((ISiloStatusListener)(object)siloStatusListener);
			try
			{
				Task<bool[]> checkTask = null;
				bool firstWait = true;
				do
				{
					if (checkTask != null)
					{
						if (firstWait)
						{
							StartInformation.Current.SetInfo(SR.T("Обновление данных о серверах"));
							firstWait = false;
						}
						await Task.WhenAny(siloStatusListener.Waiting, Task.Delay(5000));
						siloStatusListener.ResetWaiting();
					}
					checkTask = Task.WhenAll(from u in ActiveConnections
						where u != LocalConnection
						select u into uid
						select clasterInformationService.GetStatus(uid).ContinueWith((Task<DbConnectionStatus> t) => !t.IsFaulted));
				}
				while (await Task.WhenAny(checkTask, Task.Delay(1000)) != checkTask || checkTask.Result.Any((bool res) => !res));
			}
			finally
			{
				SiloStatusOracle.UnSubscribeFromSiloStatusEvents((ISiloStatusListener)(object)siloStatusListener);
			}
		});
		ClusterMembershipOptions value = hostWrapper.GetService<IOptions<ClusterMembershipOptions>>().get_Value();
		if (await Task.WhenAny(checkCluster, Task.Delay((int)value.get_TableRefreshTimeout().TotalMilliseconds * value.get_NumMissedProbesLimit())) != checkCluster)
		{
			await Task.WhenAll(from u in ActiveConnections
				where u != LocalConnection
				select u into uid
				select clasterInformationService.GetStatus(uid));
		}
	}

	private int SelectPort(string settings, int defaultPort, IEnumerable<int> forbiddenPorts)
	{
		int? setting = SR.GetSetting<int?>(settings);
		if (setting.HasValue)
		{
			return setting.Value;
		}
		int num = defaultPort;
		do
		{
			if (!forbiddenPorts.Contains(num))
			{
				return num;
			}
			num++;
		}
		while (num <= 65535);
		num = defaultPort - 1;
		do
		{
			if (!forbiddenPorts.Contains(num))
			{
				return num;
			}
			num--;
		}
		while (num >= 1000);
		return defaultPort;
	}
}
