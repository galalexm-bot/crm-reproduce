// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.RuntimeApplication
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime
{
  /// <summary>
  /// Компонент приложения, работающего с конфигурацией <see cref="T:EleWise.ELMA.Configuration.RuntimeConfiguration" />
  /// </summary>
  [ComponentOrder(-100)]
  public class RuntimeApplication : 
    IInitHandler,
    IDisposable,
    IRuntimeApplication,
    IConnectionStatusContainer
  {
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

    /// <summary>Конструктор</summary>
    /// <param name="configurationFileName">Имя файла конфигурации</param>
    /// <param name="sessionContainerProviderType">Тип провайдера контейнера сессий</param>
    /// <param name="assembliesPath">Пути сборок</param>
    /// <param name="startControl">Центра управления запуском сервера</param>
    public RuntimeApplication(
      string configurationFileName,
      Type sessionContainerProviderType,
      string[] assembliesPath,
      IStartControl startControl)
    {
      RuntimeApplication.UYGrcOWocu3J2IE5fNID();
      // ISSUE: explicit constructor call
      this.\u002Ector(configurationFileName, sessionContainerProviderType, assembliesPath, startControl, (Dictionary<string, object>) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Конструктор</summary>
    /// <param name="configurationFileName">Имя файла конфигурации</param>
    /// <param name="sessionContainerProviderType">Тип провайдера контейнера сессий</param>
    /// <param name="assembliesPath">Пути сборок</param>
    /// <param name="extenderParams">Дополнительные параметры</param>
    public RuntimeApplication(
      string configurationFileName,
      Type sessionContainerProviderType,
      string[] assembliesPath,
      Dictionary<string, object> extenderParams)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(configurationFileName, sessionContainerProviderType, assembliesPath, (IStartControl) null, extenderParams);
    }

    /// <summary>Конструктор</summary>
    /// <param name="configurationFileName">Имя файла конфигурации</param>
    /// <param name="sessionContainerProviderType">Тип провайдера контейнера сессий</param>
    /// <param name="assembliesPath">Пути сборок</param>
    /// <param name="startControl">Центра управления запуском сервера</param>
    /// <param name="extenderParams">Дополнительные параметры</param>
    public RuntimeApplication(
      string configurationFileName,
      Type sessionContainerProviderType,
      string[] assembliesPath,
      IStartControl startControl,
      Dictionary<string, object> extenderParams)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.instanceUid = Guid.Empty;
      this.protectSettingsSection = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786787438);
      this.protectSectionProvider = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841354682);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) configurationFileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021373263));
      Contract.ArgumentNotNull((object) sessionContainerProviderType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29356789));
      this._configurationFileName = configurationFileName;
      this.sessionContainerProviderType = sessionContainerProviderType;
      this.startControl = startControl ?? (IStartControl) new DoNothingStartControl();
      this._extenderParams = extenderParams;
      this._forLicenseCheck = extenderParams != null && extenderParams.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112674766));
      if (!File.Exists(this._configurationFileName))
        throw new FileNotFoundException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405802125), (object) this._configurationFileName)), this._configurationFileName);
      try
      {
        this._providers = new List<IProvider>();
        this.Configuration = this.LoadConfiguration(this._configurationFileName);
        if (this.Configuration.MainDB == null)
          throw new ConfigurationInitializeException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218394436)));
        if (EleWise.ELMA.SR.GetSetting<bool>(this.protectSettingsSection))
        {
          bool flag = false;
          string str = EleWise.ELMA.SR.GetSetting(this.protectSectionProvider, typeof (RsaProtectedConfigurationProvider).Name);
          if (str.IsNullOrWhiteSpace())
            str = typeof (RsaProtectedConfigurationProvider).Name;
          try
          {
            foreach (ConfigurationSection configurationSection in this.Configuration.Config.Sections.OfType<ConfigurationSection>())
            {
              if (!configurationSection.SectionInformation.IsProtected)
              {
                if (EleWise.ELMA.SR.GetSetting<bool>(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3316200), (object) this.protectSettingsSection, (object) configurationSection.SectionInformation.Name)))
                {
                  try
                  {
                    configurationSection.SectionInformation.ProtectSection(str);
                  }
                  catch (InvalidOperationException ex)
                  {
                    Logger.Log.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70066250), (object) configurationSection.SectionInformation.Name), (Exception) ex);
                  }
                  flag = true;
                }
              }
            }
            if (flag)
              this.Configuration.Config.Save(ConfigurationSaveMode.Modified);
          }
          catch (ConfigurationErrorsException ex)
          {
            Logger.Log.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281870678)), (Exception) ex);
            throw ex;
          }
        }
        ContainerBuilder builder = new ContainerBuilder();
        builder.RegisterInstance<RuntimeApplication>(this).As<IRuntimeApplication>().As<IConnectionStatusContainer>().SingleInstance();
        builder.RegisterType<ServerPlacementPublishService>().As<IServerPlacementPublishService>().SingleInstance();
        builder.RegisterType<ClasterInformationService>().As<IClasterInformationService>().SingleInstance();
        builder.RegisterType<RuntimeApplication.DynamicPublicationService>().As<IDynamicPublicationService>().SingleInstance();
        builder.Update(Locator.GetServiceNotNull<IContainer>());
        this._mainProvider = (IMainDatabaseProvider) this.ConfigureProvider(this.Configuration.MainDB as ProviderSettingsSection);
        this._providers.Add((IProvider) this._mainProvider);
        this._transformationProvider = this._mainProvider.CreateTransformationProvider();
        this.CheckTransformationProviderPrerequisites();
        if (!this._forLicenseCheck)
        {
          this._backupManager = new BackupManager(this.Configuration, this._transformationProvider, this.startControl);
          ILogger logger = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107941312));
          logger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439512152));
          logger.Info((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488779397) + this._mainProvider.Name));
          using (StartInformation.Operation(4.0, EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218393736))))
          {
            ActorModelRuntimeSettingsSection connectionSettings;
            try
            {
              ActorModelRuntimeSettingsSection runtimeSettingsSection1 = this.Configuration.Config.Sections.OfType<ActorModelRuntimeSettingsSection>().SingleOrDefault<ActorModelRuntimeSettingsSection>();
              if (runtimeSettingsSection1 == null)
              {
                ActorModelRuntimeSettingsSection runtimeSettingsSection2 = new ActorModelRuntimeSettingsSection();
                runtimeSettingsSection2.ProviderType = Type.GetType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867277025));
                runtimeSettingsSection1 = runtimeSettingsSection2;
              }
              connectionSettings = runtimeSettingsSection1;
            }
            catch (InvalidOperationException ex)
            {
              throw new ConfigurationInitializeException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675476967)));
            }
            this._actorModelRuntimeProvider = (IActorModelRuntimeProvider) this.ConfigureProvider((ProviderSettingsSection) connectionSettings);
            Locator.AddService<IActorModelRuntime>((IActorModelRuntime) this._actorModelRuntimeProvider);
            this._providers.Add((IProvider) this._actorModelRuntimeProvider);
            this.InitProvider((IProvider) this._actorModelRuntimeProvider);
          }
          TaskCompletionSource<Version> waitVersion = new TaskCompletionSource<Version>(TaskCreationOptions.RunContinuationsAsynchronously);
          using (Locator.GetServiceNotNull<IEventHandlerSubscribeService>().Subscribe((IEventHandler) new RuntimeApplication.ServerStartEventHandler(this, waitVersion)))
          {
            using (StartInformation.Operation(5.0, EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35957265))))
              this._actorModelRuntimeProvider.GetActor<IStartingActor>(Guid.Empty).Start(this.ConnectionUid).Wait();
            if (!waitVersion.Task.IsCompleted)
            {
              using (StartInformation.Operation(6.0, EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146605131))))
                waitVersion.Task.Wait();
            }
            Version result = waitVersion.Task.Result;
            this.IsFirstServerInCluster = result == (Version) null;
            if (!this.IsFirstServerInCluster)
            {
              if (result != VersionInfo.GetVersion<EleWise.ELMA.SR>())
              {
                this._actorModelRuntimeProvider.Dispose();
                this._actorModelRuntimeProvider = (IActorModelRuntimeProvider) null;
                throw new OtherConnectionsException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146605095), (object) result));
              }
            }
          }
        }
        this._dbPreUpdater = new DbPreUpdater(this._transformationProvider, this._backupManager, this._forLicenseCheck, this.IsFirstServerInCluster);
        StartInformation.Root.Backup.IsVisible = this._backupManager != null && (!this._backupManager.BackupsEnabled || !this._backupManager.FullAutoBackupSupport) && !this._dbPreUpdater.IsFirstStart;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        string assemblyFile = assembliesPath != null ? ((IEnumerable<string>) assembliesPath).Select<string, string>((Func<string, string>) (p => (string) RuntimeApplication.\u003C\u003Ec.gHeknoQ1diJn5OCLCgwE((object) p, RuntimeApplication.\u003C\u003Ec.ynWHLwQ19VVn8Gb6xVbR(~541731958 ^ -542071769)))).FirstOrDefault<string>(new Func<string, bool>(File.Exists)) : (string) null;
        if (assemblyFile != null)
          Assembly.LoadFrom(assemblyFile);
        this._applicationStartCache = this._dbPreUpdater.GetApplicationStartCache();
      }
      catch (OtherConnectionsException ex)
      {
        Logger.Log.Error((object) ex.Message, (Exception) ex);
        this.DisposeActorModelRuntimeProvider();
        throw;
      }
      catch (ConfigurationInitializeException ex)
      {
        Logger.Log.Error((object) ex.Message, (Exception) ex);
        this.DisposeActorModelRuntimeProvider();
        throw;
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) ex.Message, ex);
        this.DisposeActorModelRuntimeProvider();
        throw new ConfigurationInitializeException(ex);
      }
    }

    /// <summary>Основной провайдер</summary>
    public IMainDatabaseProvider MainProvider => this._mainProvider;

    /// <summary>Список провайдеров</summary>
    public IEnumerable<IProvider> Providers => (IEnumerable<IProvider>) this._providers;

    /// <summary>Текущая конфигурация приложения</summary>
    public RuntimeConfiguration Configuration
    {
      get => this.\u003CConfiguration\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CConfiguration\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Уникальный идентификатор конфигурации (хранится в БД)</summary>
    public Guid ConfigurationUid
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this._dbPreUpdater == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return Guid.Empty;
label_5:
        return this._dbPreUpdater.ConfigurationUid;
      }
    }

    /// <summary>
    /// Признак, является ли сервер первым запущенным в кластере
    /// </summary>
    public bool IsFirstServerInCluster
    {
      get => this.\u003CIsFirstServerInCluster\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CIsFirstServerInCluster\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Признак того, что нода в кластере</summary>
    public bool InCluster
    {
      get
      {
        int num1 = 5;
        bool? nullable;
        bool? inCluster;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_3;
            case 2:
              IEnumerable<CacheServiceManager> source = this._providers.OfType<CacheServiceManager>();
              this.inCluster = nullable = new bool?(source.LastOrDefault<CacheServiceManager>((Func<CacheServiceManager, bool>) (p =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      if (p.DefaultCacheService == null)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_2;
                    case 2:
                      goto label_2;
                    default:
                      goto label_3;
                  }
                }
label_2:
                return RuntimeApplication.\u003C\u003Ec.tQDCpBQ1lCAIf89yZ2rU((object) p.DefaultCacheService);
label_3:
                return false;
              })) != null);
              num1 = 3;
              continue;
            case 3:
              nullable = nullable;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            case 4:
              if (inCluster.HasValue)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
                continue;
              }
              goto case 2;
            case 5:
              inCluster = this.inCluster;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 4;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return nullable.Value;
label_3:
        return inCluster.GetValueOrDefault();
      }
    }

    /// <summary>Информация о конфигурации</summary>
    public ConfigurationInfo ConfigurationInfo
    {
      get
      {
        int num = 3;
        int? nullable;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_9;
            case 2:
              if (this.cachedConfigurationInfo == null)
              {
                num = 5;
                continue;
              }
              goto label_7;
            case 3:
              if (this._sessionProvider != null)
              {
                num = 2;
                continue;
              }
              goto label_2;
            case 4:
              ConfigurationInfo configurationInfo = new ConfigurationInfo();
              RuntimeApplication.FdYg6vWbWKEBoniCCr1x((object) configurationInfo, !nullable.HasValue ? ConfigurationType.Default : (ConfigurationType) nullable.Value);
              this.cachedConfigurationInfo = configurationInfo;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
              continue;
            case 5:
              nullable = ((IQuery) RuntimeApplication.y5UwskWbBiXcalVKPFo9(RuntimeApplication.jJgfGbWozK3LChX13R2a((object) this._sessionProvider, (object) ""), RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(~1767720452 ^ -1767691137))).CleanUpCache(false).UniqueResult<int?>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 4;
              continue;
            case 6:
              goto label_7;
            default:
              goto label_2;
          }
        }
label_2:
        return (ConfigurationInfo) null;
label_7:
        return this.cachedConfigurationInfo;
label_9:
        return this.cachedConfigurationInfo;
      }
    }

    /// <summary>
    /// Провайдер предварительного преобразования БД (до инициализации приложения)
    /// </summary>
    /// <returns></returns>
    public DbPreUpdater DbPreUpdater => this._dbPreUpdater;

    /// <summary>Провайдер преобразования БД</summary>
    /// <returns></returns>
    public ITransformationProvider TransformationProvider => this._transformationProvider;

    /// <summary>Кэш запуска приложения</summary>
    public ApplicationStartCache ApplicationStartCache => this._applicationStartCache;

    /// <summary>
    /// Уникальный идентификатор установленного экземпляра ELMA
    /// </summary>
    public Guid InstanceUid => this.instanceUid;

    /// <summary>Начало инициализации</summary>
    public virtual void Init()
    {
      switch (1)
      {
        case 1:
          try
          {
            IStartInformation startInformation1 = (IStartInformation) RuntimeApplication.BUdWPlWboAjl7eU5rWqd(1.0, (object) EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138864098)));
            int num1 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
              num1 = 0;
            while (true)
            {
              switch (num1)
              {
                case 1:
label_121:
                  startInformation1 = (IStartInformation) RuntimeApplication.BUdWPlWboAjl7eU5rWqd(47.0, RuntimeApplication.Nf2U9vWbVtocPdgghJ5O(RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-1638402543 ^ -1638506127)));
                  num1 = 2;
                  continue;
                case 2:
                  try
                  {
                    Dictionary<IProvider, int> dictionary = new Dictionary<IProvider, int>();
                    int num2 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
                      num2 = 6;
                    IEnumerator<IProvider> enumerator;
                    int num3;
                    int num4;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                          List<IProvider> providers = this._providers;
                          // ISSUE: reference to a compiler-generated field
                          Func<IProvider, bool> func1 = RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__30_5;
                          Func<IProvider, bool> predicate;
                          if (func1 == null)
                          {
                            // ISSUE: reference to a compiler-generated field
                            RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__30_5 = predicate = (Func<IProvider, bool>) (p => !(p is IActorModelRuntime));
                          }
                          else
                            goto label_130;
label_113:
                          enumerator = providers.Where<IProvider>(predicate).GetEnumerator();
                          num2 = 2;
                          continue;
label_130:
                          predicate = func1;
                          goto label_113;
                        case 2:
                          goto label_79;
                        case 3:
label_108:
                          Dictionary<IProvider, int>.ValueCollection values = dictionary.Values;
                          // ISSUE: reference to a compiler-generated field
                          Func<int, int> func2 = RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__30_3;
                          Func<int, int> selector;
                          if (func2 == null)
                          {
                            // ISSUE: reference to a compiler-generated field
                            RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__30_3 = selector = (Func<int, int>) (v => v);
                          }
                          else
                            goto label_131;
label_110:
                          num4 = values.Sum<int>(selector);
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                          continue;
label_131:
                          selector = func2;
                          goto label_110;
                        case 4:
                          try
                          {
label_69:
                            if (enumerator.MoveNext())
                              goto label_71;
                            else
                              goto label_70;
label_68:
                            IProvider current;
                            int num5;
                            while (true)
                            {
                              switch (num5)
                              {
                                case 1:
                                  goto label_108;
                                case 2:
                                  goto label_71;
                                case 3:
                                  dictionary[current] = current == this._mainProvider ? 10 : 1;
                                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                                  continue;
                                default:
                                  goto label_69;
                              }
                            }
label_70:
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                            goto label_68;
label_71:
                            current = enumerator.Current;
                            num5 = 3;
                            goto label_68;
                          }
                          finally
                          {
                            if (enumerator != null)
                            {
                              int num6 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                                num6 = 0;
                              while (true)
                              {
                                switch (num6)
                                {
                                  case 1:
                                    goto label_78;
                                  default:
                                    RuntimeApplication.YQOW00WbIXGiuWsBGnjc((object) enumerator);
                                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
                                    continue;
                                }
                              }
                            }
label_78:;
                          }
                        case 5:
                          goto label_120;
                        case 6:
                          enumerator = this._providers.Where<IProvider>((Func<IProvider, bool>) (p => !(p is IActorModelRuntime))).GetEnumerator();
                          num2 = 4;
                          continue;
                        default:
                          num3 = 0;
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
                          continue;
                      }
                    }
label_79:
                    try
                    {
label_82:
                      if (RuntimeApplication.OgYbyTWbqcOJOAvIitN8((object) enumerator))
                        goto label_84;
                      else
                        goto label_83;
label_80:
                      IProvider current;
                      IStartInformation startInformation2;
                      int num7;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 1:
                            goto label_87;
                          case 2:
                            goto label_120;
                          case 3:
                            startInformation2 = (IStartInformation) RuntimeApplication.BUdWPlWboAjl7eU5rWqd((double) num3 * 100.0 / (double) num4, (object) EleWise.ELMA.SR.M((string) RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-882126494 ^ -882227504), RuntimeApplication.NZ0ZIwWbSGh9i1PCCQGI((object) current.GetType())));
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
                            continue;
                          case 4:
                            num3 += dictionary[current];
                            num7 = 3;
                            continue;
                          case 5:
                            goto label_84;
                          default:
                            goto label_82;
                        }
                      }
label_87:
                      try
                      {
                        RuntimeApplication.dSdYNWWbitfu5qbcNKIy((object) this, (object) current);
                        int num8 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
                          num8 = 0;
                        List<Type> typeList;
                        while (true)
                        {
                          switch (num8)
                          {
                            case 1:
                              typeList = new List<Type>();
                              num8 = 3;
                              continue;
                            case 2:
                              typeList.AddRange((IEnumerable<Type>) current.GetType().GetInterfaces());
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
                              continue;
                            case 3:
                              typeList.Add(current.GetType());
                              num8 = 2;
                              continue;
                            case 4:
                              goto label_82;
                            default:
                              ComponentManager.Builder.RegisterInstance<IProvider>(current).As((Type[]) RuntimeApplication.x4emTVWbRhVcsWEHpX5C((object) typeList));
                              num8 = 4;
                              continue;
                          }
                        }
                      }
                      finally
                      {
                        if (startInformation2 != null)
                        {
                          int num9 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                            num9 = 0;
                          while (true)
                          {
                            switch (num9)
                            {
                              case 1:
                                goto label_99;
                              default:
                                RuntimeApplication.YQOW00WbIXGiuWsBGnjc((object) startInformation2);
                                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 0;
                                continue;
                            }
                          }
                        }
label_99:;
                      }
label_83:
                      num7 = 2;
                      goto label_80;
label_84:
                      current = enumerator.Current;
                      num7 = 4;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
                      {
                        num7 = 2;
                        goto label_80;
                      }
                      else
                        goto label_80;
                    }
                    finally
                    {
                      if (enumerator != null)
                      {
                        int num10 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
                          num10 = 0;
                        while (true)
                        {
                          switch (num10)
                          {
                            case 1:
                              goto label_105;
                            default:
                              RuntimeApplication.YQOW00WbIXGiuWsBGnjc((object) enumerator);
                              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
                              continue;
                          }
                        }
                      }
label_105:;
                    }
                  }
                  finally
                  {
                    int num11;
                    if (startInformation1 == null)
                      num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
                    else
                      goto label_117;
label_116:
                    switch (num11)
                    {
                      case 1:
                      case 2:
                    }
label_117:
                    startInformation1.Dispose();
                    num11 = 2;
                    goto label_116;
                  }
                case 3:
label_120:
                  ((ContainerBuilder) RuntimeApplication.QExJRPWbuI5EcowEfFmy()).RegisterType<MetadataComponent>().WithParameter<MetadataComponent, ConcreteReflectionActivatorData, SingleRegistrationStyle>((string) RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-675505729 ^ -675475887), RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-1146510045 ^ -1146507449)).As<IMetadataEditorService>().As<IInitHandler>().SingleInstance();
                  num1 = 4;
                  continue;
                case 4:
                  goto label_118;
                default:
                  try
                  {
                    IEnumerator<ProviderSettingsSection> enumerator = ((IEnumerable) RuntimeApplication.petvv7WbhaptlyoDPBRR(RuntimeApplication.fx5sLZWbbrJLwksgUGkl((object) this.Configuration))).Cast<ConfigurationSection>().Except<ConfigurationSection>((IEnumerable<ConfigurationSection>) new ConfigurationSection[1]
                    {
                      RuntimeApplication.FN8pHgWbGnHDfdtoqRlp((object) this.Configuration) as ConfigurationSection
                    }).OfType<ProviderSettingsSection>().GetEnumerator();
                    int num12 = 25;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
                      num12 = 12;
                    GenericProviderFeatureSection<CacheServiceManager> providerFeatureSection1;
                    GenericProviderFeatureSection<FilePreviewServiceProviderManager> providerFeatureSection2;
                    GenericProviderFeatureSection<LockServiceManager> providerFeatureSection3;
                    while (true)
                    {
                      switch (num12)
                      {
                        case 1:
                          ComponentManager.Builder.RegisterInstance<BackupManager>(this._backupManager).As<BackupManager>().SingleInstance();
                          num12 = 4;
                          continue;
                        case 2:
                          this._providers.Add((IProvider) RuntimeApplication.yIKSnrWbEprL4QC8Yycy((object) this, (object) providerFeatureSection1));
                          num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 18 : 4;
                          continue;
                        case 3:
                        case 5:
                          ((ContainerBuilder) RuntimeApplication.QExJRPWbuI5EcowEfFmy()).RegisterType<NHUnitOfWorkManager>().As<IUnitOfWorkManager>().As<IUnitOfWorkManagerAsync>().PropertiesAutowired<NHUnitOfWorkManager, ConcreteReflectionActivatorData, SingleRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies).SingleInstance();
                          num12 = 7;
                          continue;
                        case 4:
                        case 6:
                          goto label_121;
                        case 7:
                          ComponentManager.Builder.RegisterType(this.sessionContainerProviderType).As<ISessionsContainerProvider>().PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies).SingleInstance();
                          num12 = 20;
                          continue;
                        case 8:
label_45:
                          List<IProvider> providers1 = this._providers;
                          // ISSUE: reference to a compiler-generated field
                          Func<IProvider, bool> func3 = RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__30_0;
                          Func<IProvider, bool> predicate1;
                          if (func3 == null)
                          {
                            // ISSUE: reference to a compiler-generated field
                            RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__30_0 = predicate1 = (Func<IProvider, bool>) (p => p is CacheServiceManager);
                          }
                          else
                            goto label_24;
label_47:
                          if (!providers1.Any<IProvider>(predicate1))
                          {
                            num12 = 24;
                            continue;
                          }
                          goto case 18;
label_24:
                          predicate1 = func3;
                          goto label_47;
                        case 9:
                          RuntimeApplication.HtGUDKWb87mJO013RIf0((object) providerFeatureSection2, RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(874012245 ^ 874104861));
                          num12 = 17;
                          continue;
                        case 10:
                          ProviderSettingsCollection providers2 = providerFeatureSection1.Providers;
                          ProviderSettings providerSettings1 = new ProviderSettings();
                          RuntimeApplication.XBjqVtWbfk2edhkbjy0c((object) providerSettings1, RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(~-306453669 ^ 306547356));
                          // ISSUE: type reference
                          RuntimeApplication.D7bqAjWbC8f3HuG3Lh1p((object) providerSettings1, (object) RuntimeApplication.GH3ggbWbQx1QtOj0ROkQ(__typeref (AspNetCacheService)).AssemblyQualifiedName);
                          RuntimeApplication.e9FyAsWbvSeaqoybRqq1((object) providers2, (object) providerSettings1);
                          num12 = 12;
                          continue;
                        case 11:
                          object obj1 = RuntimeApplication.MPfDBEWbZqjTyuRAsi7s((object) providerFeatureSection3);
                          ProviderSettings provider = new ProviderSettings();
                          RuntimeApplication.XBjqVtWbfk2edhkbjy0c((object) provider, RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-342626196 - 1290888215 ^ -1633477861));
                          // ISSUE: type reference
                          provider.Type = RuntimeApplication.GH3ggbWbQx1QtOj0ROkQ(__typeref (MemoryLockService)).AssemblyQualifiedName;
                          ((ProviderSettingsCollection) obj1).Add(provider);
                          num12 = 23;
                          continue;
                        case 12:
                          RuntimeApplication.HtGUDKWb87mJO013RIf0((object) providerFeatureSection1, RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-688192331 - 435440695 ^ -1123602874));
                          num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 2 : 2;
                          continue;
                        case 13:
                          providerFeatureSection3 = new GenericProviderFeatureSection<LockServiceManager>();
                          num12 = 21;
                          continue;
                        case 14:
                          if (this._backupManager == null)
                          {
                            num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 4 : 6;
                            continue;
                          }
                          goto case 1;
                        case 15:
                          List<IProvider> providers3 = this._providers;
                          // ISSUE: reference to a compiler-generated field
                          Func<IProvider, bool> func4 = RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__30_2;
                          Func<IProvider, bool> predicate2;
                          if (func4 == null)
                          {
                            // ISSUE: reference to a compiler-generated field
                            RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__30_2 = predicate2 = (Func<IProvider, bool>) (p => p is LockServiceManager);
                          }
                          else
                            goto label_41;
label_55:
                          if (providers3.Any<IProvider>(predicate2))
                          {
                            num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 3;
                            continue;
                          }
                          goto case 13;
label_41:
                          predicate2 = func4;
                          goto label_55;
                        case 16:
                          object obj2 = RuntimeApplication.MPfDBEWbZqjTyuRAsi7s((object) providerFeatureSection2);
                          ProviderSettings providerSettings2 = new ProviderSettings();
                          RuntimeApplication.XBjqVtWbfk2edhkbjy0c((object) providerSettings2, RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(572119659 - -337058038 ^ 909206825));
                          RuntimeApplication.D7bqAjWbC8f3HuG3Lh1p((object) providerSettings2, RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-1710575414 ^ -1710545238));
                          RuntimeApplication.e9FyAsWbvSeaqoybRqq1(obj2, (object) providerSettings2);
                          num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 9 : 6;
                          continue;
                        case 17:
                          this._providers.Add((IProvider) RuntimeApplication.yIKSnrWbEprL4QC8Yycy((object) this, (object) providerFeatureSection2));
                          num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 15 : 3;
                          continue;
                        case 18:
                          List<IProvider> providers4 = this._providers;
                          // ISSUE: reference to a compiler-generated field
                          Func<IProvider, bool> func5 = RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__30_1;
                          Func<IProvider, bool> predicate3;
                          if (func5 == null)
                          {
                            // ISSUE: reference to a compiler-generated field
                            RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__30_1 = predicate3 = (Func<IProvider, bool>) (p => p is FilePreviewServiceProviderManager);
                          }
                          else
                            goto label_34;
label_51:
                          if (!providers4.Any<IProvider>(predicate3))
                          {
                            num12 = 22;
                            continue;
                          }
                          goto case 15;
label_34:
                          predicate3 = func5;
                          goto label_51;
                        case 19:
                          this._providers.Add((IProvider) RuntimeApplication.yIKSnrWbEprL4QC8Yycy((object) this, (object) providerFeatureSection3));
                          num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 5;
                          continue;
                        case 20:
                          ((ContainerBuilder) RuntimeApplication.QExJRPWbuI5EcowEfFmy()).RegisterType<SessionProvider>().As<ISessionProvider>().PropertiesAutowired<SessionProvider, ConcreteReflectionActivatorData, SingleRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies).SingleInstance();
                          num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
                          continue;
                        case 21:
                          object obj3 = RuntimeApplication.MPfDBEWbZqjTyuRAsi7s((object) providerFeatureSection3);
                          ProviderSettings providerSettings3 = new ProviderSettings();
                          RuntimeApplication.XBjqVtWbfk2edhkbjy0c((object) providerSettings3, RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(1142330761 ^ 1541959139 ^ 536833876));
                          RuntimeApplication.D7bqAjWbC8f3HuG3Lh1p((object) providerSettings3, (object) typeof (DbDistributedLockService).AssemblyQualifiedName);
                          RuntimeApplication.e9FyAsWbvSeaqoybRqq1(obj3, (object) providerSettings3);
                          num12 = 11;
                          continue;
                        case 22:
                          providerFeatureSection2 = new GenericProviderFeatureSection<FilePreviewServiceProviderManager>();
                          num12 = 16;
                          continue;
                        case 23:
                          RuntimeApplication.HtGUDKWb87mJO013RIf0((object) providerFeatureSection3, !this.InCluster ? RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(516838154 ^ 516932676) : RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(87862435 ^ 87899037));
                          num12 = 19;
                          continue;
                        case 24:
                          providerFeatureSection1 = new GenericProviderFeatureSection<CacheServiceManager>();
                          num12 = 10;
                          continue;
                        case 25:
                          try
                          {
label_32:
                            if (enumerator.MoveNext())
                              goto label_27;
                            else
                              goto label_33;
label_26:
                            ProviderSettingsSection current;
                            int num13;
                            while (true)
                            {
                              switch (num13)
                              {
                                case 1:
                                  goto label_45;
                                case 2:
                                  goto label_32;
                                case 3:
                                  if (current.AutoInitialize)
                                  {
                                    num13 = 4;
                                    continue;
                                  }
                                  goto label_32;
                                case 4:
                                  this._providers.Add((IProvider) RuntimeApplication.yIKSnrWbEprL4QC8Yycy((object) this, (object) current));
                                  num13 = 2;
                                  continue;
                                default:
                                  goto label_27;
                              }
                            }
label_27:
                            current = enumerator.Current;
                            num13 = 1;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
                            {
                              num13 = 3;
                              goto label_26;
                            }
                            else
                              goto label_26;
label_33:
                            num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
                            goto label_26;
                          }
                          finally
                          {
                            if (enumerator != null)
                            {
                              int num14 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                                num14 = 0;
                              while (true)
                              {
                                switch (num14)
                                {
                                  case 1:
                                    goto label_40;
                                  default:
                                    enumerator.Dispose();
                                    num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
                                    continue;
                                }
                              }
                            }
label_40:;
                          }
                        default:
                          ((ContainerBuilder) RuntimeApplication.QExJRPWbuI5EcowEfFmy()).RegisterType<DynamicEntityManager>();
                          num12 = 14;
                          continue;
                      }
                    }
                  }
                  finally
                  {
                    if (startInformation1 != null)
                    {
                      int num15 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
                        num15 = 0;
                      while (true)
                      {
                        switch (num15)
                        {
                          case 1:
                            goto label_63;
                          default:
                            RuntimeApplication.YQOW00WbIXGiuWsBGnjc((object) startInformation1);
                            num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
                            continue;
                        }
                      }
                    }
label_63:;
                  }
              }
            }
label_118:
            break;
          }
          catch (ConfigurationInitializeException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_128;
                default:
                  this.DisposeActorModelRuntimeProvider();
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
                  continue;
              }
            }
label_128:
            throw;
          }
          catch (Exception ex)
          {
            this.DisposeActorModelRuntimeProvider();
            throw new ConfigurationInitializeException(ex);
          }
      }
    }

    /// <summary>Завершение инициализации</summary>
    public virtual void InitComplete()
    {
      switch (1)
      {
        case 1:
          try
          {
            int num1;
            if (this._providers == null)
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 0;
            else
              goto label_4;
label_3:
            List<IProvider>.Enumerator enumerator;
            while (true)
            {
              switch (num1)
              {
                case 1:
                  goto label_14;
                case 2:
                case 4:
label_5:
                  this._sessionProvider = Locator.GetServiceNotNull<ISessionProvider>();
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
                  continue;
                case 3:
                  try
                  {
label_8:
                    if (enumerator.MoveNext())
                      goto label_10;
                    else
                      goto label_9;
label_7:
                    int num2;
                    switch (num2)
                    {
                      case 1:
                        goto label_5;
                      case 2:
                        goto label_8;
                      default:
                        goto label_10;
                    }
label_9:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 1;
                    goto label_7;
label_10:
                    RuntimeApplication.tKtp2iWbKl9l6cwNKoic((object) enumerator.Current);
                    num2 = 2;
                    goto label_7;
                  }
                  finally
                  {
                    enumerator.Dispose();
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                      num3 = 0;
                    switch (num3)
                    {
                      default:
                    }
                  }
                default:
                  goto label_4;
              }
            }
label_14:
            break;
label_4:
            enumerator = this._providers.GetEnumerator();
            num1 = 3;
            goto label_3;
          }
          catch
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  this.DisposeActorModelRuntimeProvider();
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_22;
              }
            }
label_22:
            throw;
          }
      }
    }

    /// <summary>Вызывается сразу после загрузки модулей</summary>
    public void OnApplicationStarting()
    {
      int num = 7;
      while (true)
      {
        LicensedModuleAssembly licensedModuleAssembly;
        ILicenseInfo licenseInfo1;
        ILicenseInfo licenseInfo2;
        switch (num)
        {
          case 1:
            if (licenseInfo1 == null)
            {
              num = 2;
              continue;
            }
            goto case 3;
          case 2:
          case 4:
            IEnumerable<DbConnectionStatus> values = Locator.GetService<IServerPlacementPublishService>().For<IServerInstanceActor>().Publish<DbConnectionStatus>((Func<IServerInstanceActor, Task<DbConnectionStatus>>) (a => a.GetStatus()), true).Result.Values;
            // ISSUE: reference to a compiler-generated field
            Func<DbConnectionStatus, bool> func = RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__32_1;
            Func<DbConnectionStatus, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              RuntimeApplication.\u003C\u003Ec.\u003C\u003E9__32_1 = predicate = (Func<DbConnectionStatus, bool>) (s => s.HasFlag((Enum) DbConnectionStatus.Started));
            }
            else
              goto label_20;
label_18:
            if (values.Any<DbConnectionStatus>(predicate))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 5 : 8;
              continue;
            }
            goto label_16;
label_20:
            predicate = func;
            goto label_18;
          case 3:
            if (RuntimeApplication.yHn27QWbk0vvg85XBdB6((object) licenseInfo1) != LicenseStatus.Activated)
            {
              num = 4;
              continue;
            }
            goto label_7;
          case 5:
            goto label_3;
          case 6:
            if (licensedModuleAssembly == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            }
            licenseInfo2 = licensedModuleAssembly.GetLicenseInfo();
            break;
          case 7:
            licensedModuleAssembly = (LicensedModuleAssembly) RuntimeApplication.GlGJERWbTHrVKpMuIm89(RuntimeApplication.G6vX50WbXKdoxDlFlycK((object) ComponentManager.Current), new Guid((string) RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-1204263869 ^ -1341583247 ^ 137423910)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 4 : 6;
            continue;
          case 8:
            goto label_2;
          default:
            licenseInfo2 = (ILicenseInfo) null;
            break;
        }
        licenseInfo1 = licenseInfo2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 1;
      }
label_3:
      return;
label_2:
      throw new OtherConnectionsException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867163663)));
label_7:
      return;
label_16:;
    }

    /// <summary>Вызывается при завершении запуска приложения</summary>
    public virtual void OnApplicationStarted()
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        string path;
        string input;
        while (true)
        {
          switch (num2)
          {
            case 1:
              Guid.TryParse(input, out this.instanceUid);
              num2 = 12;
              continue;
            case 2:
              goto label_15;
            case 3:
            case 10:
              ConfigurationDirectoryFileWatcher serviceNotNull = Locator.GetServiceNotNull<ConfigurationDirectoryFileWatcher>();
              serviceNotNull.FileChanged = (EventHandler<FileWatcherEventArgs>) RuntimeApplication.ws4wihWbNqtoEZAZS14p((object) serviceNotNull.FileChanged, (object) new EventHandler<FileWatcherEventArgs>(this.OnConfigChanged));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 15 : 16;
              continue;
            case 4:
              RuntimeApplication.wPZ80GWbwDOJ0PvmZIby((object) path, (object) new string[1]
              {
                this.instanceUid.ToString((string) RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-1334993905 ^ -1335098087))
              });
              num2 = 2;
              continue;
            case 5:
              if (RuntimeApplication.wVU3HCWbaVeTnX6olkwF((object) path))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 9 : 7;
                continue;
              }
              this.instanceUid = RuntimeApplication.pKWl2FWbtNvDBY4of7S7();
              num2 = 4;
              continue;
            case 6:
              this.status = DbConnectionStatus.Started | DbConnectionStatus.ConfigurationScriptsRecompileRequired;
              num2 = 15;
              continue;
            case 7:
              if (!RuntimeApplication.HW2lCOWbOehcs4TGBaT0((object) Locator.GetServiceNotNull<IMetadataRuntimeService>()))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 11;
                continue;
              }
              goto case 6;
            case 8:
              RuntimeApplication.fpvSGPWbnruIpHR4h4a7((object) this._dbPreUpdater);
              num2 = 7;
              continue;
            case 9:
              goto label_18;
            case 11:
            case 13:
              this.status = DbConnectionStatus.Started;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            case 12:
              goto label_20;
            case 14:
              if (!RuntimeApplication.qe5xWuWbD1j4BkOjdY0M((object) input))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
                continue;
              }
              goto label_14;
            case 15:
              ((Task) RuntimeApplication.WBevtxWbeJxWGnxtKiGp((object) this._actorModelRuntimeProvider.GetActor<IStartingActor>(Guid.Empty), RuntimeApplication.sJICVSWb2rqgSD15kQhA((object) this))).Wait();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 3;
              continue;
            case 16:
              path = (string) RuntimeApplication.AFuT2RWbp5P4ieKAVQsO(RuntimeApplication.E5255pWb3mkYPNyiTKwJ((object) ComponentManager.Current), RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-2099751081 ^ -2099654725));
              num2 = 5;
              continue;
            default:
              RuntimeApplication.HnyyKYWb1cKAcAk8FJBT(RuntimeApplication.l2b0XtWbPcX8FVH01u5e((object) this._actorModelRuntimeProvider.GetActor<IStartingActor>(Guid.Empty), RuntimeApplication.sJICVSWb2rqgSD15kQhA((object) this), (object) VersionInfo.GetVersion<EleWise.ELMA.SR>()));
              num2 = 10;
              continue;
          }
        }
label_18:
        input = File.ReadLines(path).FirstOrDefault<string>();
        num1 = 14;
      }
label_15:
      return;
label_20:
      return;
label_14:;
    }

    /// <summary>Признак, что приложение запущено</summary>
    public bool IsStarted => this.status.HasFlag((Enum) DbConnectionStatus.Started);

    /// <summary>Уникальный идентификатор текущего подключения к БД</summary>
    public virtual Guid ConnectionUid => RuntimeApplication.z01rW0Wb40JNIYcGJqPr((object) this._actorModelRuntimeProvider);

    /// <summary>Активно ли данное подключение к БД</summary>
    /// <param name="connectionUid">Уникальный идентификатор подключения</param>
    /// <returns>True, если активно</returns>
    public virtual bool IsConnectionAlive(Guid connectionUid) => this._actorModelRuntimeProvider.ActiveConnections.Contains<Guid>(connectionUid);

    /// <summary>
    /// Получить список идентификаторов активных подключений (включая текущее)
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable<Guid> GetActiveConnectionUids() => this._actorModelRuntimeProvider.ActiveConnections;

    /// <summary>Получить ограничение по времени выполнения команды</summary>
    /// <returns></returns>
    public virtual int? GetCommandTimeout()
    {
      int? commandTimeout = RuntimeApplication.contextTimeout.Value;
      if (!commandTimeout.HasValue)
      {
        if (!this.IsStarted)
        {
          int num = EleWise.ELMA.SR.GetSetting<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643759899), 600);
          if (num < 0)
            num = 600;
          commandTimeout = new int?(num);
        }
        else
        {
          int? nullable1 = EleWise.ELMA.SR.GetSetting<int?>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470413324));
          int? nullable2;
          if (nullable1.HasValue)
          {
            nullable2 = nullable1;
            int num = 0;
            if (!(nullable2.GetValueOrDefault() < num & nullable2.HasValue))
              goto label_9;
          }
          IRuntimeApplication service = Locator.GetService<IRuntimeApplication>();
          if (service != null)
            nullable1 = service.Configuration.MainDB.CommandTimeout;
label_9:
          ref int? local = ref commandTimeout;
          nullable2 = nullable1;
          int num1 = nullable2 ?? 30;
          local = new int?(num1);
        }
      }
      return commandTimeout;
    }

    /// <summary>
    /// Установить максимальное время выполнения запросов для текущего контекста
    /// </summary>
    /// <param name="timeout">Время в секундах</param>
    /// <returns>Предыдущее значение времени</returns>
    public virtual int? SetCurrentContextTimeout(int? timeout)
    {
      int? nullable = RuntimeApplication.contextTimeout.Value;
      RuntimeApplication.contextTimeout.Value = timeout;
      return nullable;
    }

    DbConnectionStatus IConnectionStatusContainer.Status => this.status;

    /// <summary>Дополлнительные параметры</summary>
    protected Dictionary<string, object> ExtenderParams => this._extenderParams;

    /// <summary>Загрузить конфигурацию</summary>
    /// <param name="configFileName">Полный путь до файла конфигурации</param>
    /// <returns>Конфигурация</returns>
    protected virtual RuntimeConfiguration LoadConfiguration(string configFileName) => (RuntimeConfiguration) RuntimeApplication.CCdjRTWb6FcXRwCx72vw((object) configFileName);

    /// <summary>Инициализировтаь провайдер</summary>
    /// <param name="provider">Провайдер</param>
    /// <returns>Провайдер</returns>
    /// <exception cref="T:EleWise.ELMA.Runtime.Exceptions.ConfigurationInitializeException">В случае ошибки инициализации</exception>
    protected virtual void InitProvider(IProvider provider)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_19;
          case 1:
            goto label_2;
          case 2:
            RuntimeApplication.nmO5NQWbHojwOlKBgvK0((object) provider, RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-1858887263 ^ -1858979793));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
          default:
            goto label_14;
        }
      }
label_19:
      return;
label_14:
      return;
label_2:
      try
      {
        RuntimeApplication.EMgfkuWbA1KRnwqfvhJU((object) provider);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (LicenseException ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw;
        }
      }
      catch (ConfigurationInitializeException ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
          num4 = 0;
        switch (num4)
        {
          default:
            throw;
        }
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
          num5 = 0;
        switch (num5)
        {
          default:
            throw new ConfigurationInitializeException(EleWise.ELMA.SR.T((string) RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(132912447 ^ 133008541), (object) provider.GetType()), ex);
        }
      }
    }

    /// <summary>Создать и сконфигурировать профайдер</summary>
    /// <param name="connectionSettings">Секция настроек провайдера</param>
    /// <returns>Провайдер</returns>
    /// <exception cref="T:EleWise.ELMA.Runtime.Exceptions.ConfigurationInitializeException">В случае ошибки конфигурирования</exception>
    protected virtual IProvider ConfigureProvider(ProviderSettingsSection connectionSettings)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            RuntimeApplication.nmO5NQWbHojwOlKBgvK0((object) connectionSettings, RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(1461825605 - 1531863589 ^ -70068260));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      IProvider provider1;
      return provider1;
label_4:
      try
      {
        int num2;
        if (connectionSettings.ProviderType == (Type) null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
        else
          goto label_8;
label_6:
        switch (num2)
        {
          case 1:
            throw new InvalidOperationException((string) RuntimeApplication.Os3GTdWb7wMwMiQD9Ju0(RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(1819636893 << 3 ^ 1672101580)));
          default:
            goto label_2;
        }
label_8:
        IProvider provider2 = (IProvider) RuntimeApplication.w6ptqDWb0F50sEFnr1SU(RuntimeApplication.R7oYVHWbx4tIyCuSSJwp((object) connectionSettings));
        provider2.Configure(connectionSettings, this.Configuration);
        provider1 = provider2;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        {
          num2 = 0;
          goto label_6;
        }
        else
          goto label_6;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new ConfigurationInitializeException(EleWise.ELMA.SR.T((string) RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-1598106783 - -968262081 ^ -629878924), RuntimeApplication.m8q0iOWbm9nunf0eYCoL((object) connectionSettings.SectionInformation)), ex);
        }
      }
    }

    public void Dispose()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_2;
          case 3:
            if (this._transformationProvider == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
              continue;
            }
            break;
          case 4:
            this.DisposeActorModelRuntimeProvider();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 3 : 1;
            continue;
        }
        RuntimeApplication.YQOW00WbIXGiuWsBGnjc((object) this._transformationProvider);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 0;
      }
label_5:
      return;
label_2:;
    }

    /// <summary>
    /// Вызов обработчиков изменения файла configuration.config (IUpdatableProvider)
    /// </summary>
    public void OnConfigChanged(object sender, FileWatcherEventArgs e)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (RuntimeApplication.Gw2cVQWbMQqs9BO6XnVR(RuntimeApplication.SJ0wriWbyf5rjHPbddbU((object) e), (object) this._configurationFileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
              continue;
            }
            goto label_43;
          case 2:
            goto label_45;
          default:
            goto label_4;
        }
      }
label_45:
      return;
label_43:
      return;
label_4:
      try
      {
        RuntimeConfiguration runtimeConfiguration = (RuntimeConfiguration) null;
        int num2 = 3;
        List<IProvider>.Enumerator enumerator;
        while (true)
        {
          FileStream fileStream;
          switch (num2)
          {
            case 1:
              goto label_22;
            case 2:
              enumerator = this._providers.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
              continue;
            case 3:
              fileStream = (FileStream) RuntimeApplication.RC5xHXWbJkOELrCKRFui((object) this._configurationFileName);
              num2 = 4;
              continue;
            case 4:
              try
              {
                int num3;
                if (!fileStream.CanRead)
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                else
                  goto label_15;
label_12:
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_15;
                    case 3:
                      Locator.GetServiceNotNull<ConfigurationDirectoryFileWatcher>().ConfigurationDirectoryStopWatchingFiles(false);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 1;
                      continue;
                    case 4:
                      runtimeConfiguration = (RuntimeConfiguration) RuntimeApplication.CCdjRTWb6FcXRwCx72vw((object) this._configurationFileName);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 3 : 3;
                      continue;
                    default:
                      goto label_37;
                  }
                }
label_15:
                Locator.GetServiceNotNull<ConfigurationDirectoryFileWatcher>().ConfigurationDirectoryStopWatchingFiles();
                num3 = 4;
                goto label_12;
              }
              finally
              {
                int num4;
                if (fileStream == null)
                  num4 = 2;
                else
                  goto label_19;
label_18:
                switch (num4)
                {
                  case 1:
                    break;
                  default:
                }
label_19:
                RuntimeApplication.YQOW00WbIXGiuWsBGnjc((object) fileStream);
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                {
                  num4 = 0;
                  goto label_18;
                }
                else
                  goto label_18;
              }
            case 5:
              Logger.GetLogger((string) RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-1837662597 ^ -1837752909)).InfoFormat((string) RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(-643786247 ^ -643759321), RuntimeApplication.SJ0wriWbyf5rjHPbddbU((object) e), (object) RuntimeApplication.DcGPkZWb9r025FgUVBCa((object) e));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 2;
              continue;
            case 6:
              goto label_39;
          }
label_37:
          if (runtimeConfiguration != null)
            num2 = 5;
          else
            goto label_35;
        }
label_39:
        return;
label_22:
        try
        {
label_28:
          if (enumerator.MoveNext())
            goto label_26;
          else
            goto label_29;
label_23:
          IUpdatableProviderManager current;
          int num5;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_26;
              case 2:
                if (current == null)
                {
                  num5 = 3;
                  continue;
                }
                break;
              case 3:
              case 4:
                goto label_28;
              case 5:
                goto label_31;
            }
            RuntimeApplication.x9qAI2Wbdfsu0LODEcC0((object) current, (object) runtimeConfiguration);
            num5 = 4;
          }
label_31:
          return;
label_26:
          current = enumerator.Current as IUpdatableProviderManager;
          num5 = 2;
          goto label_23;
label_29:
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 4 : 5;
          goto label_23;
        }
        finally
        {
          enumerator.Dispose();
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
            num6 = 0;
          switch (num6)
          {
            default:
          }
        }
label_35:;
      }
      catch (Exception ex)
      {
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
          num7 = 0;
        while (true)
        {
          switch (num7)
          {
            case 1:
              goto label_27;
            default:
              RuntimeApplication.RLnjKKWbrMZS1o7PRHAp((object) Logger.GetLogger((string) RuntimeApplication.OfkSqmWbFj0eQ1io9Wxy(1149433385 + 173655049 ^ 1323162106)), RuntimeApplication.pWoGLRWblW6cTtDYOWrp((object) ex));
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
              continue;
          }
        }
label_27:;
      }
    }

    private void CheckTransformationProviderPrerequisites()
    {
      int num1 = 1;
      while (true)
      {
        bool flag;
        string str;
        switch (num1)
        {
          case 1:
            str = string.Empty;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
              RuntimeApplication.McUDLMWbgyecoUbvKtKH((object) this._transformationProvider);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
                num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_12;
                  default:
                    flag = false;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
                    continue;
                }
              }
            }
            catch (CheckPrerequisitesException ex)
            {
              flag = true;
              str = (string) RuntimeApplication.pWoGLRWblW6cTtDYOWrp((object) ex);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  goto label_12;
              }
            }
          case 3:
            if (!flag)
            {
              num1 = 6;
              continue;
            }
            break;
          case 4:
label_12:
            if (flag)
            {
              num1 = 5;
              continue;
            }
            goto case 3;
          case 5:
            RuntimeApplication.dw7OvuWb5JCDwkmKUqhZ((object) this.startControl, StartStatus.PrerequisitesCheckFault, (object) str);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 0;
            continue;
          case 6:
            goto label_9;
        }
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 1;
      }
label_9:;
    }

    private void DisposeActorModelRuntimeProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            goto label_2;
          case 2:
            if (this._actorModelRuntimeProvider == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
              continue;
            }
            goto case 4;
          case 3:
            this._actorModelRuntimeProvider = (IActorModelRuntimeProvider) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 4:
            RuntimeApplication.YQOW00WbIXGiuWsBGnjc((object) this._actorModelRuntimeProvider);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 3;
            continue;
          default:
            goto label_8;
        }
      }
label_4:
      return;
label_2:
      return;
label_8:;
    }

    static RuntimeApplication()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RuntimeApplication.contextTimeout = new AsyncLocal<int?>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            RuntimeApplication.UYGrcOWocu3J2IE5fNID();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void UYGrcOWocu3J2IE5fNID() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool y40blWWoU394sFGgWfut() => RuntimeApplication.WB3sHGWoLny95P0BT2GX == null;

    internal static RuntimeApplication B5vkIEWosF6vcPa8tGNZ() => RuntimeApplication.WB3sHGWoLny95P0BT2GX;

    internal static object jJgfGbWozK3LChX13R2a([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object OfkSqmWbFj0eQ1io9Wxy(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object y5UwskWbBiXcalVKPFo9([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static void FdYg6vWbWKEBoniCCr1x([In] object obj0, ConfigurationType value) => ((ConfigurationInfo) obj0).Type = value;

    internal static object BUdWPlWboAjl7eU5rWqd(double completePercent, [In] object obj1) => (object) StartInformation.Operation(completePercent, (string) obj1);

    internal static object fx5sLZWbbrJLwksgUGkl([In] object obj0) => (object) ((RuntimeConfiguration) obj0).Config;

    internal static object petvv7WbhaptlyoDPBRR([In] object obj0) => (object) ((System.Configuration.Configuration) obj0).Sections;

    internal static object FN8pHgWbGnHDfdtoqRlp([In] object obj0) => (object) ((RuntimeConfiguration) obj0).MainDB;

    internal static object yIKSnrWbEprL4QC8Yycy([In] object obj0, [In] object obj1) => (object) ((RuntimeApplication) obj0).ConfigureProvider((ProviderSettingsSection) obj1);

    internal static void XBjqVtWbfk2edhkbjy0c([In] object obj0, [In] object obj1) => ((ProviderSettings) obj0).Name = (string) obj1;

    internal static Type GH3ggbWbQx1QtOj0ROkQ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void D7bqAjWbC8f3HuG3Lh1p([In] object obj0, [In] object obj1) => ((ProviderSettings) obj0).Type = (string) obj1;

    internal static void e9FyAsWbvSeaqoybRqq1([In] object obj0, [In] object obj1) => ((ProviderSettingsCollection) obj0).Add((ProviderSettings) obj1);

    internal static void HtGUDKWb87mJO013RIf0([In] object obj0, [In] object obj1) => ((ProviderSettingsFeatureSection) obj0).DefaultProvider = (string) obj1;

    internal static object MPfDBEWbZqjTyuRAsi7s([In] object obj0) => (object) ((ProviderSettingsFeatureSection) obj0).Providers;

    internal static object QExJRPWbuI5EcowEfFmy() => (object) ComponentManager.Builder;

    internal static void YQOW00WbIXGiuWsBGnjc([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object Nf2U9vWbVtocPdgghJ5O([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static object NZ0ZIwWbSGh9i1PCCQGI([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static void dSdYNWWbitfu5qbcNKIy([In] object obj0, [In] object obj1) => ((RuntimeApplication) obj0).InitProvider((IProvider) obj1);

    internal static object x4emTVWbRhVcsWEHpX5C([In] object obj0) => (object) ((List<Type>) obj0).ToArray();

    internal static bool OgYbyTWbqcOJOAvIitN8([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void tKtp2iWbKl9l6cwNKoic([In] object obj0) => ((IProvider) obj0).InitComplete();

    internal static object G6vX50WbXKdoxDlFlycK([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static object GlGJERWbTHrVKpMuIm89([In] object obj0, Guid uid) => (object) ((IModuleManager) obj0).FindUnitByUid(uid);

    internal static LicenseStatus yHn27QWbk0vvg85XBdB6([In] object obj0) => ((ILicenseInfo) obj0).Status;

    internal static void fpvSGPWbnruIpHR4h4a7([In] object obj0) => ((DbPreUpdater) obj0).EndUpdating();

    internal static bool HW2lCOWbOehcs4TGBaT0([In] object obj0) => ((IMetadataRuntimeService) obj0).ConfigurationScriptsRecompileRequired;

    internal static Guid sJICVSWb2rqgSD15kQhA([In] object obj0) => ((RuntimeApplication) obj0).ConnectionUid;

    internal static object WBevtxWbeJxWGnxtKiGp([In] object obj0, Guid serverUid) => (object) ((IStartingActor) obj0).ConfigurationScriptsRecompileRequired(serverUid);

    internal static object l2b0XtWbPcX8FVH01u5e([In] object obj0, Guid serverUid, [In] object obj2) => (object) ((IStartingActor) obj0).Finish(serverUid, (Version) obj2);

    internal static void HnyyKYWb1cKAcAk8FJBT([In] object obj0) => ((Task) obj0).Wait();

    internal static object ws4wihWbNqtoEZAZS14p([In] object obj0, [In] object obj1) => (object) Delegate.Combine((Delegate) obj0, (Delegate) obj1);

    internal static object E5255pWb3mkYPNyiTKwJ([In] object obj0) => (object) ((ComponentManager) obj0).WorkDirectory;

    internal static object AFuT2RWbp5P4ieKAVQsO([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool wVU3HCWbaVeTnX6olkwF([In] object obj0) => File.Exists((string) obj0);

    internal static bool qe5xWuWbD1j4BkOjdY0M([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static Guid pKWl2FWbtNvDBY4of7S7() => Guid.NewGuid();

    internal static void wPZ80GWbwDOJ0PvmZIby([In] object obj0, [In] object obj1) => File.WriteAllLines((string) obj0, (string[]) obj1);

    internal static Guid z01rW0Wb40JNIYcGJqPr([In] object obj0) => ((IActorModelRuntimeProvider) obj0).LocalConnection;

    internal static object CCdjRTWb6FcXRwCx72vw([In] object obj0) => (object) RuntimeConfiguration.Load((string) obj0);

    internal static void nmO5NQWbHojwOlKBgvK0([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void EMgfkuWbA1KRnwqfvhJU([In] object obj0) => ((IProvider) obj0).Init();

    internal static object Os3GTdWb7wMwMiQD9Ju0([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static Type R7oYVHWbx4tIyCuSSJwp([In] object obj0) => ((ProviderSettingsSection) obj0).ProviderType;

    internal static object w6ptqDWb0F50sEFnr1SU([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object m8q0iOWbm9nunf0eYCoL([In] object obj0) => (object) ((SectionInformation) obj0).Name;

    internal static object SJ0wriWbyf5rjHPbddbU([In] object obj0) => (object) ((FileWatcherEventArgs) obj0).Path;

    internal static bool Gw2cVQWbMQqs9BO6XnVR([In] object obj0, [In] object obj1) => string.Equals((string) obj0, (string) obj1);

    internal static object RC5xHXWbJkOELrCKRFui([In] object obj0) => (object) File.OpenRead((string) obj0);

    internal static FileWatcherChangeTypes DcGPkZWb9r025FgUVBCa([In] object obj0) => ((FileWatcherEventArgs) obj0).ChangeType;

    internal static void x9qAI2Wbdfsu0LODEcC0([In] object obj0, [In] object obj1) => ((IUpdatableProviderManager) obj0).UpdateConfiguration((RuntimeConfiguration) obj1);

    internal static object pWoGLRWblW6cTtDYOWrp([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void RLnjKKWbrMZS1o7PRHAp([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static void McUDLMWbgyecoUbvKtKH([In] object obj0) => ((ITransformationProvider) obj0).CheckPrerequisites();

    internal static void dw7OvuWb5JCDwkmKUqhZ([In] object obj0, StartStatus suspendReason, [In] object obj2) => ((IStartControl) obj0).Suspend(suspendReason, (string) obj2);

    private class DynamicPublicationService : IDynamicPublicationService
    {
      private readonly object dynamicPublicationSection;
      private static object FwwJ5tQ1aYFEef6mbyOI;

      public DynamicPublicationService(IRuntimeApplication runtimeApplication)
      {
        RuntimeApplication.DynamicPublicationService.V9Pd9DQ1wjiNmGbeeyIV();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.dynamicPublicationSection = (object) (((IEnumerable) RuntimeApplication.DynamicPublicationService.bZguuAQ1HdFr5VsV0RNY(RuntimeApplication.DynamicPublicationService.KU6B52Q16Yuswk68Hg2D(RuntimeApplication.DynamicPublicationService.DmvnUFQ14jFlCMg0adK1((object) runtimeApplication)))).OfType<DynamicPublicationSection>().SingleOrDefault<DynamicPublicationSection>() ?? new DynamicPublicationSection());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      public bool Enable => RuntimeApplication.DynamicPublicationService.gf84oPQ1Axy2qcd37BTc(this.dynamicPublicationSection);

      internal static void V9Pd9DQ1wjiNmGbeeyIV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object DmvnUFQ14jFlCMg0adK1([In] object obj0) => (object) ((IRuntimeApplication) obj0).Configuration;

      internal static object KU6B52Q16Yuswk68Hg2D([In] object obj0) => (object) ((RuntimeConfiguration) obj0).Config;

      internal static object bZguuAQ1HdFr5VsV0RNY([In] object obj0) => (object) ((System.Configuration.Configuration) obj0).Sections;

      internal static bool GUvpm1Q1DkG6n4QveEX1() => RuntimeApplication.DynamicPublicationService.FwwJ5tQ1aYFEef6mbyOI == null;

      internal static RuntimeApplication.DynamicPublicationService FqcNYIQ1tO94y4aOpQu2() => (RuntimeApplication.DynamicPublicationService) RuntimeApplication.DynamicPublicationService.FwwJ5tQ1aYFEef6mbyOI;

      internal static bool gf84oPQ1Axy2qcd37BTc([In] object obj0) => ((DynamicPublicationSection) obj0).Enable;
    }

    private class ServerStartEventHandler : IServerStartEventHandler, IEventHandler
    {
      private readonly object runtimeApplication;
      private readonly TaskCompletionSource<Version> waitVersion;
      internal static object gfuQbrQ17CCw1keCh0bk;

      public ServerStartEventHandler(
        RuntimeApplication runtimeApplication,
        TaskCompletionSource<Version> waitVersion)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.runtimeApplication = (object) runtimeApplication;
        this.waitVersion = waitVersion;
      }

      public void StartServer(Version serverVersion)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.waitVersion.TrySetResult(serverVersion);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            case 2:
              ((RuntimeApplication) this.runtimeApplication).status = DbConnectionStatus.Starting;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static bool uBhqTvQ1xyhRMrPXvufW() => RuntimeApplication.ServerStartEventHandler.gfuQbrQ17CCw1keCh0bk == null;

      internal static RuntimeApplication.ServerStartEventHandler fWg3OHQ10mGD54b1pWUc() => (RuntimeApplication.ServerStartEventHandler) RuntimeApplication.ServerStartEventHandler.gfuQbrQ17CCw1keCh0bk;
    }
  }
}
