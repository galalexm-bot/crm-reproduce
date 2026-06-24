using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Hosting;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.Events;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Orleans.Features;
using EleWise.ELMA.Orleans.Logging;
using EleWise.ELMA.Orleans.Placements;
using EleWise.ELMA.Orleans.Providers;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Orleans;
using Orleans.ApplicationParts;
using Orleans.Configuration;
using Orleans.Configuration.Internal;
using Orleans.Hosting;
using Orleans.Runtime;
using Orleans.Runtime.Placement;
using Orleans.Streams;

namespace EleWise.ELMA.Orleans.Runtime;

internal class OrleansHostWrapper
{
	private class OrleansGracefulShutdownRegisteredObject : IRegisteredObject
	{
		private readonly ILogger logger;

		private readonly OrleansHostWrapper orleansHostWrapper;

		public OrleansGracefulShutdownRegisteredObject(ILogger logger, OrleansHostWrapper orleansHostWrapper)
		{
			this.logger = logger;
			this.orleansHostWrapper = orleansHostWrapper;
		}

		public void Stop(bool immediate)
		{
			logger.Warn($"The application is being stopped (immediate={immediate}).");
			orleansHostWrapper.StopAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter()
				.GetResult();
		}
	}

	internal static readonly TimeSpan DefaultCollectionAge = TimeSpan.FromMinutes(10.0);

	private ISiloHost siloHost;

	private readonly IRegisteredObject registeredObject;

	private readonly ILogger logger;

	private readonly string clusterId;

	private readonly string serviceId;

	private readonly int siloPort;

	private readonly int gatewayPort;

	private readonly TimeSpan responseTimeout;

	private readonly Assembly grainsAssembly;

	private readonly IClusteringProvider clusteringProvider;

	private readonly IReminderServiceProvider reminderServiceProvider;

	private readonly Func<IAuthenticationService> authenticationService;

	public OrleansHostWrapper(string clusterId, string serviceId, int siloPort, int gatewayPort, TimeSpan responseTimeout, Assembly grainsAssembly, IClusteringProvider clusteringProvider, IReminderServiceProvider reminderServiceProvider, Func<IAuthenticationService> authenticationService)
	{
		this.clusterId = clusterId;
		this.serviceId = serviceId;
		this.siloPort = siloPort;
		this.gatewayPort = gatewayPort;
		this.responseTimeout = responseTimeout;
		this.grainsAssembly = grainsAssembly;
		this.clusteringProvider = clusteringProvider;
		this.reminderServiceProvider = reminderServiceProvider;
		this.authenticationService = authenticationService;
		logger = Logger.GetLogger(typeof(OrleansHostWrapper));
		registeredObject = new OrleansGracefulShutdownRegisteredObject(logger, this);
	}

	public async Task Run()
	{
		logger.Info("Initializing Orleans Silo host.");
		try
		{
			siloHost = BuildSilo();
			await siloHost.StartAsync(default(CancellationToken));
			HostingEnvironment.RegisterObject(registeredObject);
			logger.Info("Successfully started Orleans Silo host.");
		}
		catch (Exception exception)
		{
			logger.Fatal("An error has occurred while initializing or starting Orleans Silo host.", exception);
			throw;
		}
	}

	public async Task StopAsync()
	{
		logger.Info($"Shutting down Orleans Silo host from thread ID: '{Thread.CurrentThread.ManagedThreadId}' name: '{Thread.CurrentThread.Name}'");
		try
		{
			if (siloHost != null)
			{
				await siloHost.StopAsync(default(CancellationToken));
				HostingEnvironment.UnregisterObject(registeredObject);
			}
			logger.Warn("Orleans Silo host was stopped successfully.");
		}
		catch (Exception exception)
		{
			logger.Fatal("An error occurred while attempting to stop Orleans Silo host.", exception);
		}
	}

	internal T GetService<T>()
	{
		return ServiceProviderServiceExtensions.GetService<T>(siloHost.get_Services());
	}

	internal IStreamProvider GetStreamProvider()
	{
		return KeyedServiceCollectionExtensions.GetRequiredServiceByName<IStreamProvider>(siloHost.get_Services(), "SimpleMessageStream");
	}

	internal IGrainFactory GetGrainFactory()
	{
		return ServiceProviderServiceExtensions.GetService<IGrainFactory>(siloHost.get_Services());
	}

	private ISiloHost BuildSilo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		SiloHostBuilder val = new SiloHostBuilder();
		SiloHostBuilderExtensions.ConfigureServices((ISiloHostBuilder)(object)val, (Action<IServiceCollection>)delegate(IServiceCollection services)
		{
			OptionsServiceCollectionExtensions.Configure<ClusterMembershipOptions>(services, (Action<ClusterMembershipOptions>)delegate(ClusterMembershipOptions options)
			{
				options.set_ValidateInitialConnectivity(false);
			});
			ServiceCollectionDescriptorExtensions.Replace(services, ServiceDescriptor.Singleton<PlacementStrategy, RandomPlacement>());
			KeyedServiceExtensions.AddSingletonNamedService<PlacementStrategy, RandomPlacement>(services, typeof(RandomPlacement).Name);
			KeyedServiceExtensions.AddSingletonKeyedService<Type, IPlacementDirector, RandomPlacement.PlacementDirector>(services, typeof(RandomPlacement));
			KeyedServiceExtensions.AddSingletonNamedService<PlacementStrategy, SiloPlacement>(services, typeof(SiloPlacement).Name);
			KeyedServiceExtensions.AddSingletonKeyedService<Type, IPlacementDirector, SiloPlacement.PlacementDirector>(services, typeof(SiloPlacement));
			KeyedServiceExtensions.AddSingletonNamedService<PlacementStrategy, FeatureFlagManagedPlacement>(services, typeof(FeatureFlagManagedPlacement).Name);
			KeyedServiceExtensions.AddSingletonKeyedService<Type, IPlacementDirector, FeatureFlagManagedPlacement.PlacementDirector>(services, typeof(FeatureFlagManagedPlacement));
			ServiceCollectionServiceExtensions.AddSingleton<ILazy<IDistributedFeatureFlagService>>(ServiceCollectionServiceExtensions.AddSingleton<IRuntimeApplication>(ServiceCollectionServiceExtensions.AddSingleton<IEventHandlerSubscribeService>(ServiceCollectionServiceExtensions.AddSingleton<IServerStatusEventHandler>(ServiceCollectionServiceExtensions.AddSingleton<IClasterInformationService>(services, Locator.GetServiceNotNull<IClasterInformationService>()), Locator.GetServiceNotNull<IServerStatusEventHandler>()), Locator.GetServiceNotNull<IEventHandlerSubscribeService>()), Locator.GetServiceNotNull<IRuntimeApplication>()), Locator.GetServiceNotNull<ILazy<IDistributedFeatureFlagService>>());
			services.RegisterActorModelTypes();
			ServiceCollectionServiceExtensions.AddSingleton<SiloFilterService>(services);
			ServiceCollectionExtensions.AddFromExisting<ILifecycleParticipant<ISiloLifecycle>, SiloFilterService>(services);
		});
		clusteringProvider?.ConfigureClustering((ISiloHostBuilder)(object)val);
		reminderServiceProvider?.ConfigureReminderService((ISiloHostBuilder)(object)val);
		SiloHostBuilderExtensions.Configure<GrainCollectionOptions>(SiloHostBuilderExtensions.Configure<SiloMessagingOptions>(SiloHostBuilderExtensions.Configure<ClusterOptions>(SiloHostBuilderExtensions.Configure<SchedulingOptions>((ISiloHostBuilder)(object)val, (Action<SchedulingOptions>)delegate(SchedulingOptions options)
		{
			options.set_AllowCallChainReentrancy(true);
			options.set_PerformDeadlockDetection(true);
		}), (Action<ClusterOptions>)delegate(ClusterOptions options)
		{
			options.set_ClusterId(clusterId);
			options.set_ServiceId(serviceId);
		}), (Action<SiloMessagingOptions>)delegate(SiloMessagingOptions options)
		{
			((MessagingOptions)options).set_ResponseTimeout(responseTimeout);
		}), (Action<GrainCollectionOptions>)delegate(GrainCollectionOptions options)
		{
			options.set_CollectionAge(DefaultCollectionAge);
		});
		if (IPAddress.TryParse(SR.GetSetting("Orleans.AdvertisedIP"), out var address))
		{
			EndpointOptionsExtensions.ConfigureEndpoints((ISiloHostBuilder)(object)val, address, siloPort, gatewayPort, false);
		}
		else
		{
			EndpointOptionsExtensions.ConfigureEndpoints((ISiloHostBuilder)(object)val, siloPort, gatewayPort, AddressFamily.InterNetwork, true);
		}
		SiloHostBuilderExtensions.ConfigureApplicationParts(SiloHostBuilderGrainCallFilterExtensions.AddOutgoingGrainCallFilter(SiloHostBuilderExtensions.ConfigureLogging(MemoryGrainStorageSiloBuilderExtensions.AddMemoryGrainStorage(StreamHostingExtensions.AddSimpleMessageStreamProvider((ISiloHostBuilder)(object)val, "SimpleMessageStream", (Action<OptionsBuilder<SimpleMessageStreamProviderOptions>>)null), "PubSubStore", (Action<OptionsBuilder<MemoryGrainStorageOptions>>)null), (Action<ILoggingBuilder>)delegate(ILoggingBuilder loggingBuilder)
		{
			MicrosoftLoggerFactoryAdapter microsoftLoggerFactoryAdapter = new MicrosoftLoggerFactoryAdapter(Locator.GetService<ILoggerFactory>());
			ServiceCollectionServiceExtensions.AddSingleton<ILoggerFactory>(loggingBuilder.get_Services(), (ILoggerFactory)(object)microsoftLoggerFactoryAdapter);
		}), (OutgoingGrainCallFilterDelegate)delegate(IOutgoingGrainCallContext context)
		{
			using (ELMAContext.Create())
			{
				object obj = authenticationService()?.GetCurrentUserId();
				if (obj != null)
				{
					RequestContext.Set("UserId", obj);
				}
				string text = SR.GetCurrentCulture()?.Name;
				if (!string.IsNullOrEmpty(text) || !string.IsNullOrWhiteSpace(text))
				{
					RequestContext.Set("UICultureName", (object)text);
					RequestContext.Set("CultureName", (object)text);
				}
				IActorContextManagementService service = Locator.GetService<IActorContextManagementService>();
				if (service != null)
				{
					IDictionary<string, object> dictionary = service.Get();
					if (dictionary != null)
					{
						RequestContext.Set("PassContextKey", (object)dictionary);
					}
				}
			}
			return ((IGrainCallContext)context).Invoke();
		}), (Action<IApplicationPartManager>)delegate(IApplicationPartManager parts)
		{
			if (grainsAssembly != null)
			{
				ApplicationPartManagerCodeGenExtensions.WithCodeGeneration(ApplicationPartManagerExtensions.AddApplicationPart(parts, grainsAssembly), (ILoggerFactory)null);
			}
			parts.AddFeatureProvider((IApplicationFeatureProvider)(object)new MemoryStreamSerializerFeatureProvider());
		});
		return val.Build();
	}
}
