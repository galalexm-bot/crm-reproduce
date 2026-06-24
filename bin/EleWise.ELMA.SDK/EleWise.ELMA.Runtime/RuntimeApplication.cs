using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Impl;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.AspNet;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ComponentModel.Components;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Events;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime;

[ComponentOrder(-100)]
public class RuntimeApplication : IInitHandler, IDisposable, IRuntimeApplication, IConnectionStatusContainer
{
	private class DynamicPublicationService : IDynamicPublicationService
	{
		private readonly object dynamicPublicationSection;

		private static object FwwJ5tQ1aYFEef6mbyOI;

		public bool Enable => gf84oPQ1Axy2qcd37BTc(dynamicPublicationSection);

		public DynamicPublicationService(IRuntimeApplication runtimeApplication)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			V9Pd9DQ1wjiNmGbeeyIV();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				dynamicPublicationSection = ((IEnumerable)bZguuAQ1HdFr5VsV0RNY(KU6B52Q16Yuswk68Hg2D(DmvnUFQ14jFlCMg0adK1(runtimeApplication)))).OfType<DynamicPublicationSection>().SingleOrDefault() ?? new DynamicPublicationSection();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num = 0;
				}
			}
		}

		internal static void V9Pd9DQ1wjiNmGbeeyIV()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object DmvnUFQ14jFlCMg0adK1(object P_0)
		{
			return ((IRuntimeApplication)P_0).Configuration;
		}

		internal static object KU6B52Q16Yuswk68Hg2D(object P_0)
		{
			return ((RuntimeConfiguration)P_0).Config;
		}

		internal static object bZguuAQ1HdFr5VsV0RNY(object P_0)
		{
			return ((System.Configuration.Configuration)P_0).Sections;
		}

		internal static bool GUvpm1Q1DkG6n4QveEX1()
		{
			return FwwJ5tQ1aYFEef6mbyOI == null;
		}

		internal static DynamicPublicationService FqcNYIQ1tO94y4aOpQu2()
		{
			return (DynamicPublicationService)FwwJ5tQ1aYFEef6mbyOI;
		}

		internal static bool gf84oPQ1Axy2qcd37BTc(object P_0)
		{
			return ((DynamicPublicationSection)P_0).Enable;
		}
	}

	private class ServerStartEventHandler : IServerStartEventHandler, IEventHandler
	{
		private readonly object runtimeApplication;

		private readonly TaskCompletionSource<Version> waitVersion;

		internal static object gfuQbrQ17CCw1keCh0bk;

		public ServerStartEventHandler(RuntimeApplication runtimeApplication, TaskCompletionSource<Version> waitVersion)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.runtimeApplication = runtimeApplication;
			this.waitVersion = waitVersion;
		}

		public void StartServer(Version serverVersion)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					waitVersion.TrySetResult(serverVersion);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					((RuntimeApplication)runtimeApplication).status = DbConnectionStatus.Starting;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static bool uBhqTvQ1xyhRMrPXvufW()
		{
			return gfuQbrQ17CCw1keCh0bk == null;
		}

		internal static ServerStartEventHandler fWg3OHQ10mGD54b1pWUc()
		{
			return (ServerStartEventHandler)gfuQbrQ17CCw1keCh0bk;
		}
	}

	private ConfigurationInfo cachedConfigurationInfo;

	private readonly string _configurationFileName;

	private readonly Type sessionContainerProviderType;

	private List<IProvider> _providers;

	private IMainDatabaseProvider _mainProvider;

	private DbPreUpdater _dbPreUpdater;

	private BackupManager _backupManager;

	private IStartControl startControl;

	private ApplicationStartCache _applicationStartCache;

	private IActorModelRuntimeProvider _actorModelRuntimeProvider;

	private ITransformationProvider _transformationProvider;

	private Dictionary<string, object> _extenderParams;

	private ISessionProvider _sessionProvider;

	private bool _forLicenseCheck;

	private static readonly AsyncLocal<int?> contextTimeout;

	private Guid instanceUid;

	private bool? inCluster;

	private readonly string protectSettingsSection;

	private string protectSectionProvider;

	private DbConnectionStatus status;

	private static RuntimeApplication WB3sHGWoLny95P0BT2GX;

	public IMainDatabaseProvider MainProvider => _mainProvider;

	public IEnumerable<IProvider> Providers => _providers;

	public RuntimeConfiguration Configuration
	{
		[CompilerGenerated]
		get
		{
			return _003CConfiguration_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CConfiguration_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public Guid ConfigurationUid
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (_dbPreUpdater == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return _dbPreUpdater.ConfigurationUid;
				default:
					return Guid.Empty;
				}
			}
		}
	}

	public bool IsFirstServerInCluster
	{
		[CompilerGenerated]
		get
		{
			return _003CIsFirstServerInCluster_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CIsFirstServerInCluster_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public bool InCluster
	{
		get
		{
			//Discarded unreachable code: IL_00af
			int num = 5;
			int num2 = num;
			bool? flag = default(bool?);
			bool? flag2 = default(bool?);
			while (true)
			{
				switch (num2)
				{
				default:
					return flag.Value;
				case 1:
					return flag2.GetValueOrDefault();
				case 4:
					if (flag2.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 5:
					flag2 = inCluster;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					flag = flag;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				}
				flag = (inCluster = _providers.OfType<CacheServiceManager>().LastOrDefault(delegate(CacheServiceManager p)
				{
					//Discarded unreachable code: IL_003b, IL_004a
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 2:
							return _003C_003Ec.tQDCpBQ1lCAIf89yZ2rU(p.DefaultCacheService);
						default:
							return false;
						case 1:
							if (p.DefaultCacheService == null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
								{
									num4 = 0;
								}
								break;
							}
							goto case 2;
						}
					}
				}) != null);
				num2 = 3;
			}
		}
	}

	public ConfigurationInfo ConfigurationInfo
	{
		get
		{
			//Discarded unreachable code: IL_0069, IL_00d3, IL_00e2
			int num = 3;
			int num2 = num;
			int? num3 = default(int?);
			while (true)
			{
				switch (num2)
				{
				default:
					return null;
				case 2:
					if (cachedConfigurationInfo == null)
					{
						num2 = 5;
						break;
					}
					goto case 6;
				case 3:
					if (_sessionProvider != null)
					{
						num2 = 2;
						break;
					}
					goto default;
				case 6:
					return cachedConfigurationInfo;
				case 5:
					num3 = ((IQuery)y5UwskWbBiXcalVKPFo9(jJgfGbWozK3LChX13R2a(_sessionProvider, ""), OfkSqmWbFj0eQ1io9Wxy(-1767720453 ^ -1767691137))).CleanUpCache(cleanUpCache: false).UniqueResult<int?>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					return cachedConfigurationInfo;
				case 4:
				{
					ConfigurationInfo configurationInfo = new ConfigurationInfo();
					FdYg6vWbWKEBoniCCr1x(configurationInfo, num3.HasValue ? ((ConfigurationType)num3.Value) : ConfigurationType.Default);
					cachedConfigurationInfo = configurationInfo;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
				}
			}
		}
	}

	public DbPreUpdater DbPreUpdater => _dbPreUpdater;

	public ITransformationProvider TransformationProvider => _transformationProvider;

	public ApplicationStartCache ApplicationStartCache => _applicationStartCache;

	public Guid InstanceUid => instanceUid;

	public bool IsStarted => status.HasFlag(DbConnectionStatus.Started);

	public virtual Guid ConnectionUid => z01rW0Wb40JNIYcGJqPr(_actorModelRuntimeProvider);

	DbConnectionStatus IConnectionStatusContainer.Status => status;

	protected Dictionary<string, object> ExtenderParams => _extenderParams;

	public RuntimeApplication(string configurationFileName, Type sessionContainerProviderType, string[] assembliesPath, IStartControl startControl)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		UYGrcOWocu3J2IE5fNID();
		this._002Ector(configurationFileName, sessionContainerProviderType, assembliesPath, startControl, null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public RuntimeApplication(string configurationFileName, Type sessionContainerProviderType, string[] assembliesPath, Dictionary<string, object> extenderParams)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(configurationFileName, sessionContainerProviderType, assembliesPath, null, extenderParams);
	}

	public RuntimeApplication(string configurationFileName, Type sessionContainerProviderType, string[] assembliesPath, IStartControl startControl, Dictionary<string, object> extenderParams)
	{
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		SingletonReader.JJCZtPuTvSt();
		instanceUid = Guid.Empty;
		protectSettingsSection = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A80366E);
		protectSectionProvider = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC0D7BA);
		base._002Ector();
		Contract.ArgumentNotNull(configurationFileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE0EB4F));
		Contract.ArgumentNotNull(sessionContainerProviderType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29356789));
		_configurationFileName = configurationFileName;
		this.sessionContainerProviderType = sessionContainerProviderType;
		this.startControl = startControl ?? new DoNothingStartControl();
		_extenderParams = extenderParams;
		_forLicenseCheck = extenderParams?.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112674766)) ?? false;
		if (!File.Exists(_configurationFileName))
		{
			throw new FileNotFoundException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CAD68D), _configurationFileName)), _configurationFileName);
		}
		try
		{
			_providers = new List<IProvider>();
			Configuration = LoadConfiguration(_configurationFileName);
			if (Configuration.MainDB == null)
			{
				throw new ConfigurationInitializeException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218394436)));
			}
			if (SR.GetSetting(protectSettingsSection, defaultValue: false))
			{
				bool flag = false;
				string text = SR.GetSetting(protectSectionProvider, typeof(RsaProtectedConfigurationProvider).Name);
				if (text.IsNullOrWhiteSpace())
				{
					text = typeof(RsaProtectedConfigurationProvider).Name;
				}
				try
				{
					foreach (ConfigurationSection item in Configuration.Config.Sections.OfType<ConfigurationSection>())
					{
						if (!item.SectionInformation.IsProtected && SR.GetSetting(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3316200), protectSettingsSection, item.SectionInformation.Name), defaultValue: false))
						{
							try
							{
								item.SectionInformation.ProtectSection(text);
							}
							catch (InvalidOperationException exception)
							{
								Logger.Log.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70066250), item.SectionInformation.Name), exception);
							}
							flag = true;
						}
					}
					if (flag)
					{
						Configuration.Config.Save(ConfigurationSaveMode.Modified);
					}
				}
				catch (ConfigurationErrorsException ex)
				{
					Logger.Log.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281870678)), ex);
					throw ex;
				}
			}
			ContainerBuilder val = new ContainerBuilder();
			RegistrationExtensions.RegisterInstance<RuntimeApplication>(val, this).As<IRuntimeApplication>().As<IConnectionStatusContainer>()
				.SingleInstance();
			RegistrationExtensions.RegisterType<ServerPlacementPublishService>(val).As<IServerPlacementPublishService>().SingleInstance();
			RegistrationExtensions.RegisterType<ClasterInformationService>(val).As<IClasterInformationService>().SingleInstance();
			RegistrationExtensions.RegisterType<DynamicPublicationService>(val).As<IDynamicPublicationService>().SingleInstance();
			val.Update(Locator.GetServiceNotNull<IContainer>());
			_mainProvider = (IMainDatabaseProvider)ConfigureProvider(Configuration.MainDB as ProviderSettingsSection);
			_providers.Add(_mainProvider);
			_transformationProvider = _mainProvider.CreateTransformationProvider();
			CheckTransformationProviderPrerequisites();
			if (!_forLicenseCheck)
			{
				_backupManager = new BackupManager(Configuration, _transformationProvider, this.startControl);
				ILogger logger = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107941312));
				logger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A326C58));
				logger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488779397) + _mainProvider.Name);
				using (StartInformation.Operation(4.0, SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218393736))))
				{
					ActorModelRuntimeSettingsSection connectionSettings;
					try
					{
						connectionSettings = Configuration.Config.Sections.OfType<ActorModelRuntimeSettingsSection>().SingleOrDefault() ?? new ActorModelRuntimeSettingsSection
						{
							ProviderType = Type.GetType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4C62E1))
						};
					}
					catch (InvalidOperationException)
					{
						throw new ConfigurationInitializeException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675476967)));
					}
					_actorModelRuntimeProvider = (IActorModelRuntimeProvider)ConfigureProvider(connectionSettings);
					Locator.AddService((IActorModelRuntime)_actorModelRuntimeProvider);
					_providers.Add(_actorModelRuntimeProvider);
					InitProvider(_actorModelRuntimeProvider);
				}
				TaskCompletionSource<Version> taskCompletionSource = new TaskCompletionSource<Version>(TaskCreationOptions.RunContinuationsAsynchronously);
				using (Locator.GetServiceNotNull<IEventHandlerSubscribeService>().Subscribe(new ServerStartEventHandler(this, taskCompletionSource)))
				{
					using (StartInformation.Operation(5.0, SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35957265))))
					{
						_actorModelRuntimeProvider.GetActor<IStartingActor>(Guid.Empty).Start(ConnectionUid).Wait();
					}
					if (!taskCompletionSource.Task.IsCompleted)
					{
						using (StartInformation.Operation(6.0, SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146605131))))
						{
							taskCompletionSource.Task.Wait();
						}
					}
					Version result = taskCompletionSource.Task.Result;
					IsFirstServerInCluster = result == null;
					if (!IsFirstServerInCluster && result != VersionInfo.GetVersion<SR>())
					{
						_actorModelRuntimeProvider.Dispose();
						_actorModelRuntimeProvider = null;
						throw new OtherConnectionsException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146605095), result));
					}
				}
			}
			_dbPreUpdater = new DbPreUpdater(_transformationProvider, _backupManager, _forLicenseCheck, IsFirstServerInCluster);
			StartInformation.Root.Backup.IsVisible = _backupManager != null && (!_backupManager.BackupsEnabled || !_backupManager.FullAutoBackupSupport) && !_dbPreUpdater.IsFirstStart;
			string text2 = assembliesPath?.Select((string p) => (string)_003C_003Ec.gHeknoQ1diJn5OCLCgwE(p, _003C_003Ec.ynWHLwQ19VVn8Gb6xVbR(-541731959 ^ -542071769))).FirstOrDefault(File.Exists);
			if (text2 != null)
			{
				Assembly.LoadFrom(text2);
			}
			_applicationStartCache = _dbPreUpdater.GetApplicationStartCache();
		}
		catch (OtherConnectionsException ex3)
		{
			Logger.Log.Error(ex3.Message, ex3);
			DisposeActorModelRuntimeProvider();
			throw;
		}
		catch (ConfigurationInitializeException ex4)
		{
			Logger.Log.Error(ex4.Message, ex4);
			DisposeActorModelRuntimeProvider();
			throw;
		}
		catch (Exception ex5)
		{
			Logger.Log.Error(ex5.Message, ex5);
			DisposeActorModelRuntimeProvider();
			throw new ConfigurationInitializeException(ex5);
		}
	}

	public virtual void Init()
	{
		//Discarded unreachable code: IL_0064, IL_00e0, IL_041d, IL_042c, IL_043d, IL_044c, IL_0457, IL_051b, IL_0553, IL_0562, IL_0572, IL_0581, IL_0740, IL_0778, IL_0787, IL_07b4, IL_07e4, IL_08a7, IL_08df, IL_08ee, IL_08ff, IL_0909, IL_09ff, IL_0ac0, IL_0af8, IL_0b07, IL_0b38, IL_0b70, IL_0b7f, IL_0c9d, IL_0ccd, IL_0cdc, IL_0ce8, IL_0d8a, IL_0dce, IL_0ddd
		switch (1)
		{
		case 1:
			try
			{
				IStartInformation startInformation = (IStartInformation)BUdWPlWboAjl7eU5rWqd(1.0, SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138864098)));
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num = 0;
				}
				GenericProviderFeatureSection<CacheServiceManager> genericProviderFeatureSection3 = default(GenericProviderFeatureSection<CacheServiceManager>);
				GenericProviderFeatureSection<FilePreviewServiceProviderManager> genericProviderFeatureSection2 = default(GenericProviderFeatureSection<FilePreviewServiceProviderManager>);
				GenericProviderFeatureSection<LockServiceManager> genericProviderFeatureSection = default(GenericProviderFeatureSection<LockServiceManager>);
				ProviderSettingsSection current3 = default(ProviderSettingsSection);
				IEnumerator<IProvider> enumerator = default(IEnumerator<IProvider>);
				IProvider current = default(IProvider);
				IStartInformation startInformation2 = default(IStartInformation);
				int num4 = default(int);
				int num3 = default(int);
				IProvider current2 = default(IProvider);
				List<Type> list = default(List<Type>);
				while (true)
				{
					switch (num)
					{
					default:
						try
						{
							IEnumerator<ProviderSettingsSection> enumerator2 = ((IEnumerable)petvv7WbhaptlyoDPBRR(fx5sLZWbbrJLwksgUGkl(Configuration))).Cast<ConfigurationSection>().Except(new ConfigurationSection[1] { FN8pHgWbGnHDfdtoqRlp(Configuration) as ConfigurationSection }).OfType<ProviderSettingsSection>()
								.GetEnumerator();
							int num13 = 25;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num13 = 12;
							}
							while (true)
							{
								switch (num13)
								{
								case 14:
									if (_backupManager == null)
									{
										num13 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
										{
											num13 = 6;
										}
										continue;
									}
									goto case 1;
								case 24:
									genericProviderFeatureSection3 = new GenericProviderFeatureSection<CacheServiceManager>();
									num13 = 10;
									continue;
								case 7:
									RegistrationExtensions.PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType(ComponentManager.Builder, sessionContainerProviderType).As<ISessionsContainerProvider>(), (PropertyWiringOptions)1).SingleInstance();
									num13 = 20;
									continue;
								case 20:
									RegistrationExtensions.PropertiesAutowired<SessionProvider, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType<SessionProvider>((ContainerBuilder)QExJRPWbuI5EcowEfFmy()).As<ISessionProvider>(), (PropertyWiringOptions)1).SingleInstance();
									num13 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
									{
										num13 = 0;
									}
									continue;
								case 9:
									HtGUDKWb87mJO013RIf0(genericProviderFeatureSection2, OfkSqmWbFj0eQ1io9Wxy(0x34185E55 ^ 0x3419C81D));
									num13 = 17;
									continue;
								case 19:
									_providers.Add((IProvider)yIKSnrWbEprL4QC8Yycy(this, genericProviderFeatureSection));
									num13 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
									{
										num13 = 5;
									}
									continue;
								case 1:
									RegistrationExtensions.RegisterInstance<BackupManager>(ComponentManager.Builder, _backupManager).As<BackupManager>().SingleInstance();
									num13 = 4;
									continue;
								case 13:
									genericProviderFeatureSection = new GenericProviderFeatureSection<LockServiceManager>();
									num13 = 21;
									continue;
								case 2:
									_providers.Add((IProvider)yIKSnrWbEprL4QC8Yycy(this, genericProviderFeatureSection3));
									num13 = 18;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
									{
										num13 = 4;
									}
									continue;
								case 16:
								{
									object obj3 = MPfDBEWbZqjTyuRAsi7s(genericProviderFeatureSection2);
									ProviderSettings providerSettings4 = new ProviderSettings();
									XBjqVtWbfk2edhkbjy0c(providerSettings4, OfkSqmWbFj0eQ1io9Wxy(0x3630F361 ^ 0x36316529));
									D7bqAjWbC8f3HuG3Lh1p(providerSettings4, OfkSqmWbFj0eQ1io9Wxy(-1710575414 ^ -1710545238));
									e9FyAsWbvSeaqoybRqq1(obj3, providerSettings4);
									num13 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
									{
										num13 = 6;
									}
									continue;
								}
								case 10:
								{
									ProviderSettingsCollection providers = genericProviderFeatureSection3.Providers;
									ProviderSettings providerSettings3 = new ProviderSettings();
									XBjqVtWbfk2edhkbjy0c(providerSettings3, OfkSqmWbFj0eQ1io9Wxy(0x12441CA4 ^ 0x12458A9C));
									D7bqAjWbC8f3HuG3Lh1p(providerSettings3, GH3ggbWbQx1QtOj0ROkQ(typeof(AspNetCacheService).TypeHandle).AssemblyQualifiedName);
									e9FyAsWbvSeaqoybRqq1(providers, providerSettings3);
									num13 = 12;
									continue;
								}
								case 21:
								{
									object obj2 = MPfDBEWbZqjTyuRAsi7s(genericProviderFeatureSection);
									ProviderSettings providerSettings2 = new ProviderSettings();
									XBjqVtWbfk2edhkbjy0c(providerSettings2, OfkSqmWbFj0eQ1io9Wxy(0x1FFEF86A ^ 0x1FFF6F54));
									D7bqAjWbC8f3HuG3Lh1p(providerSettings2, typeof(DbDistributedLockService).AssemblyQualifiedName);
									e9FyAsWbvSeaqoybRqq1(obj2, providerSettings2);
									num13 = 11;
									continue;
								}
								case 11:
								{
									object obj = MPfDBEWbZqjTyuRAsi7s(genericProviderFeatureSection);
									ProviderSettings providerSettings = new ProviderSettings();
									XBjqVtWbfk2edhkbjy0c(providerSettings, OfkSqmWbFj0eQ1io9Wxy(-1633514411 ^ -1633477861));
									providerSettings.Type = GH3ggbWbQx1QtOj0ROkQ(typeof(MemoryLockService).TypeHandle).AssemblyQualifiedName;
									((ProviderSettingsCollection)obj).Add(providerSettings);
									num13 = 23;
									continue;
								}
								default:
									RegistrationExtensions.RegisterType<DynamicEntityManager>((ContainerBuilder)QExJRPWbuI5EcowEfFmy());
									num13 = 14;
									continue;
								case 3:
								case 5:
									RegistrationExtensions.PropertiesAutowired<NHUnitOfWorkManager, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType<NHUnitOfWorkManager>((ContainerBuilder)QExJRPWbuI5EcowEfFmy()).As<IUnitOfWorkManager>().As<IUnitOfWorkManagerAsync>(), (PropertyWiringOptions)1).SingleInstance();
									num13 = 7;
									continue;
								case 25:
									try
									{
										while (true)
										{
											IL_04cf:
											int num14;
											if (!enumerator2.MoveNext())
											{
												num14 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
												{
													num14 = 1;
												}
												goto IL_045b;
											}
											goto IL_0479;
											IL_0479:
											current3 = enumerator2.Current;
											num14 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
											{
												num14 = 3;
											}
											goto IL_045b;
											IL_045b:
											while (true)
											{
												switch (num14)
												{
												case 3:
													if (current3.AutoInitialize)
													{
														num14 = 4;
														continue;
													}
													goto IL_04cf;
												case 4:
													_providers.Add((IProvider)yIKSnrWbEprL4QC8Yycy(this, current3));
													num14 = 2;
													continue;
												case 2:
													goto IL_04cf;
												case 1:
													goto end_IL_04cf;
												}
												break;
											}
											goto IL_0479;
											continue;
											end_IL_04cf:
											break;
										}
									}
									finally
									{
										if (enumerator2 != null)
										{
											int num15 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
											{
												num15 = 0;
											}
											while (true)
											{
												switch (num15)
												{
												default:
													enumerator2.Dispose();
													num15 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
													{
														num15 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto case 8;
								case 6:
									break;
								case 17:
									_providers.Add((IProvider)yIKSnrWbEprL4QC8Yycy(this, genericProviderFeatureSection2));
									num13 = 15;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
									{
										num13 = 3;
									}
									continue;
								case 12:
									HtGUDKWb87mJO013RIf0(genericProviderFeatureSection3, OfkSqmWbFj0eQ1io9Wxy(-1123633026 ^ -1123602874));
									num13 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
									{
										num13 = 2;
									}
									continue;
								case 22:
									genericProviderFeatureSection2 = new GenericProviderFeatureSection<FilePreviewServiceProviderManager>();
									num13 = 16;
									continue;
								case 8:
									if (!_providers.Any((IProvider p) => p is CacheServiceManager))
									{
										num13 = 24;
										continue;
									}
									goto case 18;
								case 18:
									if (!_providers.Any((IProvider p) => p is FilePreviewServiceProviderManager))
									{
										num13 = 22;
										continue;
									}
									goto case 15;
								case 15:
									if (_providers.Any((IProvider p) => p is LockServiceManager))
									{
										num13 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
										{
											num13 = 3;
										}
										continue;
									}
									goto case 13;
								case 23:
									HtGUDKWb87mJO013RIf0(genericProviderFeatureSection, InCluster ? OfkSqmWbFj0eQ1io9Wxy(0x53CACA3 ^ 0x53D3B9D) : OfkSqmWbFj0eQ1io9Wxy(0x1ECE530A ^ 0x1ECFC444));
									num13 = 19;
									continue;
								case 4:
									break;
								}
								break;
							}
						}
						finally
						{
							if (startInformation != null)
							{
								int num16 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num16 = 0;
								}
								while (true)
								{
									switch (num16)
									{
									default:
										YQOW00WbIXGiuWsBGnjc(startInformation);
										num16 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
										{
											num16 = 0;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
						break;
					case 2:
						try
						{
							Dictionary<IProvider, int> dictionary = new Dictionary<IProvider, int>();
							int num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
							{
								num2 = 6;
							}
							while (true)
							{
								switch (num2)
								{
								case 4:
									try
									{
										while (true)
										{
											int num5;
											if (!enumerator.MoveNext())
											{
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
												{
													num5 = 1;
												}
												goto IL_07f2;
											}
											goto IL_0832;
											IL_0832:
											current = enumerator.Current;
											int num6 = 3;
											num5 = num6;
											goto IL_07f2;
											IL_07f2:
											while (true)
											{
												switch (num5)
												{
												case 2:
													goto IL_0832;
												case 3:
													dictionary[current] = ((current != _mainProvider) ? 1 : 10);
													num5 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
													{
														num5 = 0;
													}
													continue;
												case 1:
													goto end_IL_080c;
												}
												break;
											}
											continue;
											end_IL_080c:
											break;
										}
									}
									finally
									{
										if (enumerator != null)
										{
											int num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													YQOW00WbIXGiuWsBGnjc(enumerator);
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
													{
														num7 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto case 3;
								case 2:
									try
									{
										while (true)
										{
											int num8;
											if (!OgYbyTWbqcOJOAvIitN8(enumerator))
											{
												num8 = 2;
												goto IL_090d;
											}
											goto IL_09a1;
											IL_090d:
											while (true)
											{
												switch (num8)
												{
												case 3:
													startInformation2 = (IStartInformation)BUdWPlWboAjl7eU5rWqd((double)num4 * 100.0 / (double)num3, SR.M((string)OfkSqmWbFj0eQ1io9Wxy(-882126494 ^ -882227504), NZ0ZIwWbSGh9i1PCCQGI(current2.GetType())));
													num8 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
													{
														num8 = 1;
													}
													continue;
												case 5:
													goto IL_09a1;
												case 4:
													num4 += dictionary[current2];
													num8 = 3;
													continue;
												case 1:
													try
													{
														dSdYNWWbitfu5qbcNKIy(this, current2);
														int num9 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
														{
															num9 = 0;
														}
														while (true)
														{
															switch (num9)
															{
															default:
																RegistrationExtensions.RegisterInstance<IProvider>(ComponentManager.Builder, current2).As((Type[])x4emTVWbRhVcsWEHpX5C(list));
																num9 = 4;
																continue;
															case 1:
																list = new List<Type>();
																num9 = 3;
																continue;
															case 2:
																list.AddRange(current2.GetType().GetInterfaces());
																num9 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
																{
																	num9 = 0;
																}
																continue;
															case 3:
																list.Add(current2.GetType());
																num9 = 2;
																continue;
															case 4:
																break;
															}
															break;
														}
													}
													finally
													{
														if (startInformation2 != null)
														{
															int num10 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
															{
																num10 = 0;
															}
															while (true)
															{
																switch (num10)
																{
																default:
																	YQOW00WbIXGiuWsBGnjc(startInformation2);
																	num10 = 1;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
																	{
																		num10 = 0;
																	}
																	continue;
																case 1:
																	break;
																}
																break;
															}
														}
													}
													break;
												case 2:
													goto end_IL_098b;
												}
												break;
											}
											continue;
											IL_09a1:
											current2 = enumerator.Current;
											num8 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
											{
												num8 = 2;
											}
											goto IL_090d;
											continue;
											end_IL_098b:
											break;
										}
									}
									finally
									{
										if (enumerator != null)
										{
											int num11 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
											{
												num11 = 0;
											}
											while (true)
											{
												switch (num11)
												{
												default:
													YQOW00WbIXGiuWsBGnjc(enumerator);
													num11 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
													{
														num11 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									break;
								default:
									num4 = 0;
									num2 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
									{
										num2 = 1;
									}
									continue;
								case 6:
									enumerator = _providers.Where((IProvider p) => !(p is IActorModelRuntime)).GetEnumerator();
									num2 = 4;
									continue;
								case 3:
									num3 = dictionary.Values.Sum((int v) => v);
									num2 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
									{
										num2 = 0;
									}
									continue;
								case 1:
									enumerator = _providers.Where((IProvider p) => !(p is IActorModelRuntime)).GetEnumerator();
									num2 = 2;
									continue;
								case 5:
									break;
								}
								break;
							}
						}
						finally
						{
							int num12;
							if (startInformation == null)
							{
								num12 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num12 = 1;
								}
								goto IL_0ca1;
							}
							goto IL_0cb7;
							IL_0cb7:
							startInformation.Dispose();
							num12 = 2;
							goto IL_0ca1;
							IL_0ca1:
							switch (num12)
							{
							case 1:
								goto end_IL_0c7c;
							case 2:
								goto end_IL_0c7c;
							}
							goto IL_0cb7;
							end_IL_0c7c:;
						}
						goto case 3;
					case 3:
						RegistrationExtensions.WithParameter<MetadataComponent, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType<MetadataComponent>((ContainerBuilder)QExJRPWbuI5EcowEfFmy()), (string)OfkSqmWbFj0eQ1io9Wxy(-675505729 ^ -675475887), OfkSqmWbFj0eQ1io9Wxy(-1146510045 ^ -1146507449)).As<IMetadataEditorService>().As<IInitHandler>()
							.SingleInstance();
						num = 4;
						continue;
					case 1:
						break;
					case 4:
						return;
					}
					startInformation = (IStartInformation)BUdWPlWboAjl7eU5rWqd(47.0, Nf2U9vWbVtocPdgghJ5O(OfkSqmWbFj0eQ1io9Wxy(-1638402543 ^ -1638506127)));
					num = 2;
				}
			}
			catch (ConfigurationInitializeException)
			{
				int num17 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num17 = 0;
				}
				while (true)
				{
					switch (num17)
					{
					case 1:
						throw;
					}
					DisposeActorModelRuntimeProvider();
					num17 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num17 = 1;
					}
				}
			}
			catch (Exception innerException)
			{
				DisposeActorModelRuntimeProvider();
				throw new ConfigurationInitializeException(innerException);
			}
		case 0:
			break;
		}
	}

	public virtual void InitComplete()
	{
		//Discarded unreachable code: IL_004b, IL_0072, IL_0081, IL_00ce, IL_00dd, IL_00e8, IL_016a, IL_017d, IL_01a7, IL_01df, IL_01ee
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				int num;
				if (_providers == null)
				{
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num = 0;
					}
					goto IL_004f;
				}
				goto IL_008c;
				IL_008c:
				List<IProvider>.Enumerator enumerator = _providers.GetEnumerator();
				num = 3;
				goto IL_004f;
				IL_004f:
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
					case 4:
						_sessionProvider = Locator.GetServiceNotNull<ISessionProvider>();
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num = 1;
						}
						continue;
					case 3:
						try
						{
							while (true)
							{
								int num2;
								if (!enumerator.MoveNext())
								{
									num2 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
									{
										num2 = 1;
									}
									goto IL_00ec;
								}
								goto IL_0128;
								IL_0128:
								tKtp2iWbKl9l6cwNKoic(enumerator.Current);
								num2 = 2;
								goto IL_00ec;
								IL_00ec:
								switch (num2)
								{
								case 2:
									break;
								default:
									goto IL_0128;
								case 1:
									goto end_IL_0102;
								}
								continue;
								end_IL_0102:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num3 = 0;
							}
							switch (num3)
							{
							case 0:
								break;
							}
						}
						goto case 2;
					}
					break;
				}
				goto IL_008c;
			}
			catch
			{
				int num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						DisposeActorModelRuntimeProvider();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num4 = 0;
						}
						break;
					default:
						throw;
					}
				}
			}
		}
	}

	public void OnApplicationStarting()
	{
		//Discarded unreachable code: IL_00cd, IL_00dc, IL_0102
		int num = 7;
		int num2 = num;
		LicensedModuleAssembly licensedModuleAssembly = default(LicensedModuleAssembly);
		ILicenseInfo licenseInfo = default(ILicenseInfo);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 8:
				throw new OtherConnectionsException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867163663)));
			case 7:
				licensedModuleAssembly = (LicensedModuleAssembly)GlGJERWbTHrVKpMuIm89(G6vX50WbXKdoxDlFlycK(ComponentManager.Current), new Guid((string)OfkSqmWbFj0eQ1io9Wxy(0x8317432 ^ 0x830EC26)));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				if (licensedModuleAssembly == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				}
				obj = licensedModuleAssembly.GetLicenseInfo();
				goto IL_011f;
			case 3:
				if (yHn27QWbk0vvg85XBdB6(licenseInfo) != 0)
				{
					num2 = 4;
					break;
				}
				return;
			default:
				obj = null;
				goto IL_011f;
			case 1:
				if (licenseInfo == null)
				{
					num2 = 2;
					break;
				}
				goto case 3;
			case 5:
				return;
			case 2:
			case 4:
				{
					if (!Locator.GetService<IServerPlacementPublishService>().For<IServerInstanceActor>().Publish((IServerInstanceActor a) => a.GetStatus(), ignoreError: true)
						.Result.Values.Any((DbConnectionStatus s) => s.HasFlag(DbConnectionStatus.Started)))
					{
						return;
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 8;
					}
					break;
				}
				IL_011f:
				licenseInfo = (ILicenseInfo)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual void OnApplicationStarted()
	{
		//Discarded unreachable code: IL_01c1, IL_024e
		int num = 8;
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (wVU3HCWbaVeTnX6olkwF(text2))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 7;
						}
					}
					else
					{
						instanceUid = pKWl2FWbtNvDBY4of7S7();
						num2 = 4;
					}
					continue;
				case 14:
					if (!qe5xWuWbD1j4BkOjdY0M(text))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 7:
					if (!HW2lCOWbOehcs4TGBaT0(Locator.GetServiceNotNull<IMetadataRuntimeService>()))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 6;
				case 3:
				case 10:
				{
					ConfigurationDirectoryFileWatcher serviceNotNull = Locator.GetServiceNotNull<ConfigurationDirectoryFileWatcher>();
					serviceNotNull.FileChanged = (EventHandler<FileWatcherEventArgs>)ws4wihWbNqtoEZAZS14p(serviceNotNull.FileChanged, new EventHandler<FileWatcherEventArgs>(OnConfigChanged));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 16;
					}
					continue;
				}
				case 16:
					text2 = (string)AFuT2RWbp5P4ieKAVQsO(E5255pWb3mkYPNyiTKwJ(ComponentManager.Current), OfkSqmWbFj0eQ1io9Wxy(-2099751081 ^ -2099654725));
					num2 = 5;
					continue;
				case 4:
					wPZ80GWbwDOJ0PvmZIby(text2, new string[1] { instanceUid.ToString((string)OfkSqmWbFj0eQ1io9Wxy(-1334993905 ^ -1335098087)) });
					num2 = 2;
					continue;
				default:
					HnyyKYWb1cKAcAk8FJBT(l2b0XtWbPcX8FVH01u5e(_actorModelRuntimeProvider.GetActor<IStartingActor>(Guid.Empty), sJICVSWb2rqgSD15kQhA(this), VersionInfo.GetVersion<SR>()));
					num2 = 10;
					continue;
				case 1:
					Guid.TryParse(text, out instanceUid);
					num2 = 12;
					continue;
				case 12:
					return;
				case 6:
					status = DbConnectionStatus.Started | DbConnectionStatus.ConfigurationScriptsRecompileRequired;
					num2 = 15;
					continue;
				case 9:
					break;
				case 15:
					((Task)WBevtxWbeJxWGnxtKiGp(_actorModelRuntimeProvider.GetActor<IStartingActor>(Guid.Empty), sJICVSWb2rqgSD15kQhA(this))).Wait();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					return;
				case 8:
					fpvSGPWbnruIpHR4h4a7(_dbPreUpdater);
					num2 = 7;
					continue;
				case 11:
				case 13:
					status = DbConnectionStatus.Started;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			text = File.ReadLines(text2).FirstOrDefault();
			num = 14;
		}
	}

	public virtual bool IsConnectionAlive(Guid connectionUid)
	{
		return _actorModelRuntimeProvider.ActiveConnections.Contains(connectionUid);
	}

	public virtual IEnumerable<Guid> GetActiveConnectionUids()
	{
		return _actorModelRuntimeProvider.ActiveConnections;
	}

	public virtual int? GetCommandTimeout()
	{
		int? result = contextTimeout.Value;
		if (!result.HasValue)
		{
			if (!IsStarted)
			{
				int num = SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643759899), 600);
				if (num < 0)
				{
					num = 600;
				}
				result = num;
			}
			else
			{
				int? num2 = SR.GetSetting<int?>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A4BA0C));
				if (!num2.HasValue || num2 < 0)
				{
					IRuntimeApplication service = Locator.GetService<IRuntimeApplication>();
					if (service != null)
					{
						num2 = service.Configuration.MainDB.CommandTimeout;
					}
				}
				result = num2 ?? 30;
			}
		}
		return result;
	}

	public virtual int? SetCurrentContextTimeout(int? timeout)
	{
		int? value = contextTimeout.Value;
		contextTimeout.Value = timeout;
		return value;
	}

	protected virtual RuntimeConfiguration LoadConfiguration(string configFileName)
	{
		return (RuntimeConfiguration)CCdjRTWb6FcXRwCx72vw(configFileName);
	}

	protected virtual void InitProvider(IProvider provider)
	{
		//Discarded unreachable code: IL_004a, IL_007c, IL_00ab, IL_00db, IL_0119, IL_0128
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					EMgfkuWbA1KRnwqfvhJU(provider);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				catch (LicenseException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw;
					}
				}
				catch (ConfigurationInitializeException)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					default:
						throw;
					}
				}
				catch (Exception innerException)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					default:
						throw new ConfigurationInitializeException(SR.T((string)OfkSqmWbFj0eQ1io9Wxy(0x7EC153F ^ 0x7ED8C9D), provider.GetType()), innerException);
					}
				}
			case 2:
				nmO5NQWbHojwOlKBgvK0(provider, OfkSqmWbFj0eQ1io9Wxy(-1858887263 ^ -1858979793));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual IProvider ConfigureProvider(ProviderSettingsSection connectionSettings)
	{
		//Discarded unreachable code: IL_008d, IL_011e, IL_0167, IL_0176
		int num = 2;
		int num2 = num;
		IProvider provider = default(IProvider);
		while (true)
		{
			switch (num2)
			{
			default:
				return provider;
			case 2:
				nmO5NQWbHojwOlKBgvK0(connectionSettings, OfkSqmWbFj0eQ1io9Wxy(-70037984 ^ -70068260));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					int num3;
					if (connectionSettings.ProviderType == null)
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num3 = 0;
						}
					}
					else
					{
						IProvider obj = (IProvider)w6ptqDWb0F50sEFnr1SU(R7oYVHWbx4tIyCuSSJwp(connectionSettings));
						obj.Configure(connectionSettings, Configuration);
						provider = obj;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num3 = 0;
						}
					}
					return num3 switch
					{
						0 => provider, 
						1 => throw new InvalidOperationException((string)Os3GTdWb7wMwMiQD9Ju0(OfkSqmWbFj0eQ1io9Wxy(0x63ABA4E8 ^ 0x63AA3ECC))), 
						_ => provider, 
					};
				}
				catch (Exception innerException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new ConfigurationInitializeException(SR.T((string)OfkSqmWbFj0eQ1io9Wxy(-629844702 ^ -629878924), m8q0iOWbm9nunf0eYCoL(connectionSettings.SectionInformation)), innerException);
					}
				}
			}
		}
	}

	public void Dispose()
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				return;
			case 3:
				if (_transformationProvider == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				YQOW00WbIXGiuWsBGnjc(_transformationProvider);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				DisposeActorModelRuntimeProvider();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void OnConfigChanged(object sender, FileWatcherEventArgs e)
	{
		//Discarded unreachable code: IL_0067, IL_0157, IL_01ca, IL_01d9, IL_020f, IL_024f, IL_025e, IL_026a, IL_0279, IL_028a, IL_0299, IL_02a4, IL_02f8, IL_0307, IL_0377, IL_038a, IL_03c6, IL_0422, IL_0431
		int num = 1;
		int num2 = num;
		List<IProvider>.Enumerator enumerator = default(List<IProvider>.Enumerator);
		FileStream fileStream = default(FileStream);
		IUpdatableProviderManager updatableProviderManager = default(IUpdatableProviderManager);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				if (!Gw2cVQWbMQqs9BO6XnVR(SJ0wriWbyf5rjHPbddbU(e), _configurationFileName))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				RuntimeConfiguration runtimeConfiguration = null;
				int num3 = 3;
				while (true)
				{
					switch (num3)
					{
					case 6:
						return;
					case 2:
						enumerator = _providers.GetEnumerator();
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num3 = 1;
						}
						continue;
					case 3:
						fileStream = (FileStream)RC5xHXWbJkOELrCKRFui(_configurationFileName);
						num3 = 4;
						continue;
					case 5:
						Logger.GetLogger((string)OfkSqmWbFj0eQ1io9Wxy(-1837662597 ^ -1837752909)).InfoFormat((string)OfkSqmWbFj0eQ1io9Wxy(-643786247 ^ -643759321), SJ0wriWbyf5rjHPbddbU(e), DcGPkZWb9r025FgUVBCa(e));
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num3 = 2;
						}
						continue;
					case 4:
						try
						{
							int num6;
							if (!fileStream.CanRead)
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
								{
									num6 = 0;
								}
								goto IL_015b;
							}
							goto IL_01e4;
							IL_01e4:
							Locator.GetServiceNotNull<ConfigurationDirectoryFileWatcher>().ConfigurationDirectoryStopWatchingFiles();
							num6 = 4;
							goto IL_015b;
							IL_015b:
							while (true)
							{
								switch (num6)
								{
								default:
									goto end_IL_015b;
								case 3:
									Locator.GetServiceNotNull<ConfigurationDirectoryFileWatcher>().ConfigurationDirectoryStopWatchingFiles(watching: false);
									num6 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
									{
										num6 = 1;
									}
									continue;
								case 4:
									runtimeConfiguration = (RuntimeConfiguration)CCdjRTWb6FcXRwCx72vw(_configurationFileName);
									num6 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
									{
										num6 = 3;
									}
									continue;
								case 0:
									goto end_IL_015b;
								case 1:
									break;
								case 2:
									goto end_IL_015b;
								}
								goto IL_01e4;
								continue;
								end_IL_015b:
								break;
							}
						}
						finally
						{
							int num7;
							if (fileStream == null)
							{
								num7 = 2;
								goto IL_0213;
							}
							goto IL_0229;
							IL_0213:
							switch (num7)
							{
							default:
								goto end_IL_01fe;
							case 1:
								break;
							case 2:
								goto end_IL_01fe;
							case 0:
								goto end_IL_01fe;
							}
							goto IL_0229;
							IL_0229:
							YQOW00WbIXGiuWsBGnjc(fileStream);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
							{
								num7 = 0;
							}
							goto IL_0213;
							end_IL_01fe:;
						}
						break;
					case 1:
						try
						{
							while (true)
							{
								IL_0312:
								int num4;
								if (!enumerator.MoveNext())
								{
									num4 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
									{
										num4 = 5;
									}
									goto IL_02a8;
								}
								goto IL_02db;
								IL_02db:
								updatableProviderManager = enumerator.Current as IUpdatableProviderManager;
								num4 = 2;
								goto IL_02a8;
								IL_02a8:
								while (true)
								{
									switch (num4)
									{
									case 5:
										return;
									case 2:
										if (updatableProviderManager == null)
										{
											num4 = 3;
											continue;
										}
										goto default;
									case 1:
										break;
									case 3:
									case 4:
										goto IL_0312;
									default:
										x9qAI2Wbdfsu0LODEcC0(updatableProviderManager, runtimeConfiguration);
										num4 = 4;
										continue;
									}
									break;
								}
								goto IL_02db;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							case 0:
								break;
							}
						}
					}
					if (runtimeConfiguration == null)
					{
						break;
					}
					num3 = 5;
				}
				return;
			}
			catch (Exception ex)
			{
				int num8 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num8 = 0;
				}
				while (true)
				{
					switch (num8)
					{
					case 1:
						return;
					}
					RLnjKKWbrMZS1o7PRHAp(Logger.GetLogger((string)OfkSqmWbFj0eQ1io9Wxy(0x4EDCBA32 ^ 0x4EDDD9FA)), pWoGLRWblW6cTtDYOWrp(ex));
					num8 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num8 = 0;
					}
				}
			}
		}
	}

	private void CheckTransformationProviderPrerequisites()
	{
		//Discarded unreachable code: IL_005e, IL_00ba, IL_00d1
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					McUDLMWbgyecoUbvKtKH(_transformationProvider);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							flag = false;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				catch (CheckPrerequisitesException ex)
				{
					flag = true;
					text = (string)pWoGLRWblW6cTtDYOWrp(ex);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			default:
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				text = string.Empty;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (flag)
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 5:
				dw7OvuWb5JCDwkmKUqhZ(startControl, StartStatus.PrerequisitesCheckFault, text);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!flag)
				{
					num2 = 6;
					break;
				}
				goto default;
			case 6:
				return;
			}
		}
	}

	private void DisposeActorModelRuntimeProvider()
	{
		//Discarded unreachable code: IL_0056
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				_actorModelRuntimeProvider = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return;
			case 2:
				if (_actorModelRuntimeProvider == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 4:
				break;
			case 0:
				return;
			}
			YQOW00WbIXGiuWsBGnjc(_actorModelRuntimeProvider);
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
			{
				num2 = 3;
			}
		}
	}

	static RuntimeApplication()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				UYGrcOWocu3J2IE5fNID();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				contextTimeout = new AsyncLocal<int?>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void UYGrcOWocu3J2IE5fNID()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool y40blWWoU394sFGgWfut()
	{
		return WB3sHGWoLny95P0BT2GX == null;
	}

	internal static RuntimeApplication B5vkIEWosF6vcPa8tGNZ()
	{
		return WB3sHGWoLny95P0BT2GX;
	}

	internal static object jJgfGbWozK3LChX13R2a(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object OfkSqmWbFj0eQ1io9Wxy(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object y5UwskWbBiXcalVKPFo9(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static void FdYg6vWbWKEBoniCCr1x(object P_0, ConfigurationType value)
	{
		((ConfigurationInfo)P_0).Type = value;
	}

	internal static object BUdWPlWboAjl7eU5rWqd(double completePercent, object P_1)
	{
		return StartInformation.Operation(completePercent, (string)P_1);
	}

	internal static object fx5sLZWbbrJLwksgUGkl(object P_0)
	{
		return ((RuntimeConfiguration)P_0).Config;
	}

	internal static object petvv7WbhaptlyoDPBRR(object P_0)
	{
		return ((System.Configuration.Configuration)P_0).Sections;
	}

	internal static object FN8pHgWbGnHDfdtoqRlp(object P_0)
	{
		return ((RuntimeConfiguration)P_0).MainDB;
	}

	internal static object yIKSnrWbEprL4QC8Yycy(object P_0, object P_1)
	{
		return ((RuntimeApplication)P_0).ConfigureProvider((ProviderSettingsSection)P_1);
	}

	internal static void XBjqVtWbfk2edhkbjy0c(object P_0, object P_1)
	{
		((ProviderSettings)P_0).Name = (string)P_1;
	}

	internal static Type GH3ggbWbQx1QtOj0ROkQ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void D7bqAjWbC8f3HuG3Lh1p(object P_0, object P_1)
	{
		((ProviderSettings)P_0).Type = (string)P_1;
	}

	internal static void e9FyAsWbvSeaqoybRqq1(object P_0, object P_1)
	{
		((ProviderSettingsCollection)P_0).Add((ProviderSettings)P_1);
	}

	internal static void HtGUDKWb87mJO013RIf0(object P_0, object P_1)
	{
		((ProviderSettingsFeatureSection)P_0).DefaultProvider = (string)P_1;
	}

	internal static object MPfDBEWbZqjTyuRAsi7s(object P_0)
	{
		return ((ProviderSettingsFeatureSection)P_0).Providers;
	}

	internal static object QExJRPWbuI5EcowEfFmy()
	{
		return ComponentManager.Builder;
	}

	internal static void YQOW00WbIXGiuWsBGnjc(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object Nf2U9vWbVtocPdgghJ5O(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object NZ0ZIwWbSGh9i1PCCQGI(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static void dSdYNWWbitfu5qbcNKIy(object P_0, object P_1)
	{
		((RuntimeApplication)P_0).InitProvider((IProvider)P_1);
	}

	internal static object x4emTVWbRhVcsWEHpX5C(object P_0)
	{
		return ((List<Type>)P_0).ToArray();
	}

	internal static bool OgYbyTWbqcOJOAvIitN8(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void tKtp2iWbKl9l6cwNKoic(object P_0)
	{
		((IProvider)P_0).InitComplete();
	}

	internal static object G6vX50WbXKdoxDlFlycK(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object GlGJERWbTHrVKpMuIm89(object P_0, Guid uid)
	{
		return ((IModuleManager)P_0).FindUnitByUid(uid);
	}

	internal static LicenseStatus yHn27QWbk0vvg85XBdB6(object P_0)
	{
		return ((ILicenseInfo)P_0).Status;
	}

	internal static void fpvSGPWbnruIpHR4h4a7(object P_0)
	{
		((DbPreUpdater)P_0).EndUpdating();
	}

	internal static bool HW2lCOWbOehcs4TGBaT0(object P_0)
	{
		return ((IMetadataRuntimeService)P_0).ConfigurationScriptsRecompileRequired;
	}

	internal static Guid sJICVSWb2rqgSD15kQhA(object P_0)
	{
		return ((RuntimeApplication)P_0).ConnectionUid;
	}

	internal static object WBevtxWbeJxWGnxtKiGp(object P_0, Guid serverUid)
	{
		return ((IStartingActor)P_0).ConfigurationScriptsRecompileRequired(serverUid);
	}

	internal static object l2b0XtWbPcX8FVH01u5e(object P_0, Guid serverUid, object P_2)
	{
		return ((IStartingActor)P_0).Finish(serverUid, (Version)P_2);
	}

	internal static void HnyyKYWb1cKAcAk8FJBT(object P_0)
	{
		((Task)P_0).Wait();
	}

	internal static object ws4wihWbNqtoEZAZS14p(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static object E5255pWb3mkYPNyiTKwJ(object P_0)
	{
		return ((ComponentManager)P_0).WorkDirectory;
	}

	internal static object AFuT2RWbp5P4ieKAVQsO(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool wVU3HCWbaVeTnX6olkwF(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static bool qe5xWuWbD1j4BkOjdY0M(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static Guid pKWl2FWbtNvDBY4of7S7()
	{
		return Guid.NewGuid();
	}

	internal static void wPZ80GWbwDOJ0PvmZIby(object P_0, object P_1)
	{
		File.WriteAllLines((string)P_0, (string[])P_1);
	}

	internal static Guid z01rW0Wb40JNIYcGJqPr(object P_0)
	{
		return ((IActorModelRuntimeProvider)P_0).LocalConnection;
	}

	internal static object CCdjRTWb6FcXRwCx72vw(object P_0)
	{
		return RuntimeConfiguration.Load((string)P_0);
	}

	internal static void nmO5NQWbHojwOlKBgvK0(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void EMgfkuWbA1KRnwqfvhJU(object P_0)
	{
		((IProvider)P_0).Init();
	}

	internal static object Os3GTdWb7wMwMiQD9Ju0(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static Type R7oYVHWbx4tIyCuSSJwp(object P_0)
	{
		return ((ProviderSettingsSection)P_0).ProviderType;
	}

	internal static object w6ptqDWb0F50sEFnr1SU(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object m8q0iOWbm9nunf0eYCoL(object P_0)
	{
		return ((SectionInformation)P_0).Name;
	}

	internal static object SJ0wriWbyf5rjHPbddbU(object P_0)
	{
		return ((FileWatcherEventArgs)P_0).Path;
	}

	internal static bool Gw2cVQWbMQqs9BO6XnVR(object P_0, object P_1)
	{
		return string.Equals((string)P_0, (string)P_1);
	}

	internal static object RC5xHXWbJkOELrCKRFui(object P_0)
	{
		return File.OpenRead((string)P_0);
	}

	internal static FileWatcherChangeTypes DcGPkZWb9r025FgUVBCa(object P_0)
	{
		return ((FileWatcherEventArgs)P_0).ChangeType;
	}

	internal static void x9qAI2Wbdfsu0LODEcC0(object P_0, object P_1)
	{
		((IUpdatableProviderManager)P_0).UpdateConfiguration((RuntimeConfiguration)P_1);
	}

	internal static object pWoGLRWblW6cTtDYOWrp(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void RLnjKKWbrMZS1o7PRHAp(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static void McUDLMWbgyecoUbvKtKH(object P_0)
	{
		((ITransformationProvider)P_0).CheckPrerequisites();
	}

	internal static void dw7OvuWb5JCDwkmKUqhZ(object P_0, StartStatus suspendReason, object P_2)
	{
		((IStartControl)P_0).Suspend(suspendReason, (string)P_2);
	}
}
