// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ConfigurationImportExecutor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.BPMApps.Managers;
using EleWise.ELMA.BPMApps.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.Enums;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Import.UserActions;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Deploy.Serialization;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using ICSharpCode.SharpZipLib.Zip;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Xml;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Класс импорта конфигурации</summary>
  internal sealed class ConfigurationImportExecutor : 
    IConfigurationTesterInternal,
    IConfigurationTester,
    IConfigurationImporterInternal,
    IConfigurationImporter
  {
    /// <summary>
    /// Названия групп свойств при распарсе xml-файла импортируемой конфигурации, чьи значения будут получены через TypeDescriptor
    /// </summary>
    internal static string RegularProperty;
    /// <summary>
    /// Названия групп свойств при распарсе xml-файла импортируемой конфигурации, чьи значения будут получены путем стандартной xml-сериализации
    /// </summary>
    internal static string XmlProperty;
    private ImportStep step;
    private int testStep;
    private Dictionary<string, string> serviceData;
    private readonly IImportSettings importSettings;
    /// <summary>
    /// Идентификатор дерева (если есть), для которого выполняется импорт
    /// </summary>
    private readonly string treeUid;
    /// <summary>
    /// Список Uid'ов метаданных, которые помечены как неучаствующие в экспорте-импорте (!IsUnique)
    /// </summary>
    private ISet<Guid> metadataNotIsUnique;
    private readonly LinksDictionary linksDictionary;
    /// <summary>Импортируемые пакеты</summary>
    private readonly List<PackageOperationInfo> packagesOperations;
    /// <summary>Список ошибок импорта пакетов отчетов</summary>
    private List<string> packetError;
    /// <summary>Сущности сохраненные во время импорта в рамках пакета</summary>
    private List<IEntity> savedPacketEntities;
    private readonly MergeReplace mergeReplace;
    private readonly MergeUidReplace mergeUidReplace;
    private static readonly EleWise.ELMA.Logging.ILogger ImportLog;
    private long signUserId;
    private readonly Dictionary<Type, List<IPropertyMetadata>> entitiesMetadata;
    private readonly List<long> headers;
    private readonly ISecurityService securityService;
    private readonly IAuthenticationService authenticationService;
    private readonly IModelManager modelManager;
    private readonly IModuleManager moduleManager;
    private readonly IWorkWithFormDependeciesService withFormDependenciesService;
    private readonly IZipService zipService;
    private readonly ITagService tagService;
    private readonly IUnitOfWorkManager unitOfWorkManager;
    private readonly IRuntimeApplication runtimeApplication;
    private readonly MetadataItemManager metadataItemManager;
    private readonly BPMAppManager bpmAppManager;
    private readonly PackageService packageService;
    private readonly PacketVersionService packetVersionService;
    private readonly ISessionProvider sessionProvider;
    private readonly IContextBoundVariableService contextCacheService;
    private readonly RunWithSoftDeletableService runWithSoftDeletableService;
    private readonly IEnumerable<IPacketActions> packetActions;
    private readonly IEnumerable<IMetadataImport> metadataImport;
    private readonly IEnumerable<ISkipEntityImportResolver> skipEntityImportResolvers;
    private readonly IExportImportFileManager exportImportFileManager;
    private readonly IEnumerable<IConfigImportExtension> importExtensions;
    private readonly IEnumerable<IIgnoreIsUniqueMetadata> ignoreIsUniqueMetadata;
    private readonly IEnumerable<ISecurityDeployHelperExtension> securityDeployHelperExtensions;
    private readonly IEnumerable<IPrivilegeModuleAccessGroup> privilegeModuleAccessGroups;
    private readonly IEnumerable<IPostEntityXmlSerializer> postEntityXmlSerializers;
    private readonly IEnumerable<IConfigImportActionExtension> configImportActionExtensions;
    private readonly IEnumerable<IEntityImportSaveActions> entityImportSaveActionExtensions;
    private readonly IEnumerable<IImportantData> importantData;
    private List<DeployLogMessage> messages;
    /// <summary>
    /// Список сообщений, являющихся результатом проверки импортируемого файла конфигурации. Для вывода в дизайнере.
    /// </summary>
    private readonly List<TestImportMessages> testMessages;
    /// <summary>Системные сообщения</summary>
    private List<DeploySystemMessage> systemMessages;
    /// <summary>Системные сообщения с этапа теста</summary>
    private readonly List<DeploySystemMessage> testSystemMessages;
    /// <summary>
    /// Манифест для чтения метаданных. Не использовать напрямую.
    /// </summary>
    private BPMAppManifest manifestExecuteMetadata;
    /// <summary>В случае если устанавливается компонент</summary>
    private ElmaStoreComponentManifest manifest;
    private static ConfigurationImportExecutor hMiB5FE1uQm4WfVepvcS;

    /// <summary>
    /// Событие, которые вызывается перед добавление сообщений о прохождении этапа теста в лог
    /// </summary>
    public event Action<TestImportMessages> BeforeAddTestMessage;

    private void TestMessagesAdd(TestImportMessages message)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (message == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
              continue;
            }
            break;
          case 3:
            goto label_2;
        }
        this.TestMessageInternalAdd(message);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 3 : 1;
      }
label_3:
      return;
label_2:;
    }

    /// <summary>Добавление тестовых сообщений без проверок</summary>
    /// <param name="message">Сообщение</param>
    private void TestMessageInternalAdd(TestImportMessages message)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 2:
              Action<TestImportMessages> beforeAddTestMessage = this.BeforeAddTestMessage;
              if (beforeAddTestMessage == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
                continue;
              }
              beforeAddTestMessage(message);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_6;
            default:
              goto label_3;
          }
        }
label_3:
        this.testMessages.Add(message);
        num1 = 3;
      }
label_6:;
    }

    /// <summary>Получить список системных сообщений с этапа теста</summary>
    public List<DeploySystemMessage> GetTestSystemMessages() => this.testSystemMessages;

    /// <summary>Манифест для чтения метаданных</summary>
    private BPMAppManifest ManifestExecuteMetadata
    {
      get
      {
        int num1 = 4;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_7;
            case 4:
              if (this.manifestExecuteMetadata != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 3 : 0;
                continue;
              }
              goto case 6;
            case 5:
              if (!string.IsNullOrEmpty(this.manifest.BPMAppManifest))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            case 6:
              if (this.manifest == null)
              {
                num1 = 2;
                continue;
              }
              goto case 5;
            default:
              goto label_2;
          }
        }
label_2:
        return this.manifestExecuteMetadata;
label_7:
        try
        {
          this.manifestExecuteMetadata = ClassSerializationHelper.DeserializeObjectByXml<BPMAppManifest>((string) ConfigurationImportExecutor.U5UHMaE1S4JqtTam5itl((object) this.manifest));
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
            num2 = 0;
          switch (num2)
          {
            default:
              goto label_2;
          }
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
            num3 = 0;
          switch (num3)
          {
            default:
              goto label_2;
          }
        }
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <param name="securityService">Сервис безопасности</param>
    /// <param name="authenticationService">Сервис аутентификации</param>
    /// <param name="modelManager">Менеджер модели данных</param>
    /// <param name="moduleManager">Менеджер модулей</param>
    /// <param name="withFormDependenciesService">Сервис работы с зависимостями форм</param>
    /// <param name="zipService">Сервис сжатия</param>
    /// <param name="tagService">Сервис обработки ограничений по тегам</param>
    /// <param name="unitOfWorkManager">Сервис Unit of Work</param>
    /// <param name="runtimeApplication">Сервис среды исполнения</param>
    /// <param name="metadataItemManager">Менеджер объектов хранения метаданных</param>
    /// <param name="bpmAppManager">Менеджер BPMApp</param>
    /// <param name="packageService">Сервис для работы с пакетной системой</param>
    /// <param name="packetVersionService">Сервис версий пакетов</param>
    /// <param name="runWithSoftDeletableService">Сервис контекста мягкого удаления</param>
    /// <param name="sessionProvider">Провайдер сессии</param>
    /// <param name="contextCacheService">Сервис для доступа к контексту текущего запроса</param>
    /// <param name="exportImportFileManager">Файловый менеджер экспорта/импорта</param>
    /// <param name="importExtensions">Проверка и импорт</param>
    /// <param name="configImportActionExtensions">Проверка файлов конфигурации перед импортом</param>
    /// <param name="entityImportSaveActionExtensions">Действия при импорте и сохранении сущности</param>
    /// <param name="importantData">Информация о важных данных для импорта</param>
    /// <param name="packetActions">Точка расширения для выполнения действия над пакетом сущностей</param>
    /// <param name="metadataImport">Обработчики импорта метаданных</param>
    /// <param name="skipEntityImportResolvers">Точка для принятия решения о пропуске сохранения сущности</param>
    /// <param name="ignoreIsUniqueMetadata">Игнорирование метаданных без Uid</param>
    /// <param name="securityDeployHelperExtensions">Что-то для загрузки пользователя</param>
    /// <param name="privilegeModuleAccessGroups">Точка расширения для определения привилегированных пользователей</param>
    /// <param name="postEntityXmlSerializers">Изменения логики сериализации</param>
    public ConfigurationImportExecutor(
      IImportSettings settings,
      ISecurityService securityService,
      IAuthenticationService authenticationService,
      IModelManager modelManager,
      IModuleManager moduleManager,
      IWorkWithFormDependeciesService withFormDependenciesService,
      IZipService zipService,
      ITagService tagService,
      IUnitOfWorkManager unitOfWorkManager,
      IRuntimeApplication runtimeApplication,
      MetadataItemManager metadataItemManager,
      BPMAppManager bpmAppManager,
      PackageService packageService,
      PacketVersionService packetVersionService,
      RunWithSoftDeletableService runWithSoftDeletableService,
      ISessionProvider sessionProvider,
      IContextBoundVariableService contextCacheService,
      IExportImportFileManager exportImportFileManager,
      IEnumerable<IConfigImportExtension> importExtensions,
      IEnumerable<IConfigImportActionExtension> configImportActionExtensions,
      IEnumerable<IEntityImportSaveActions> entityImportSaveActionExtensions,
      IEnumerable<IImportantData> importantData,
      IEnumerable<IPacketActions> packetActions,
      IEnumerable<IMetadataImport> metadataImport,
      IEnumerable<ISkipEntityImportResolver> skipEntityImportResolvers,
      IEnumerable<IIgnoreIsUniqueMetadata> ignoreIsUniqueMetadata,
      IEnumerable<ISecurityDeployHelperExtension> securityDeployHelperExtensions,
      IEnumerable<IPrivilegeModuleAccessGroup> privilegeModuleAccessGroups,
      IEnumerable<IPostEntityXmlSerializer> postEntityXmlSerializers)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.linksDictionary = new LinksDictionary();
      this.packagesOperations = new List<PackageOperationInfo>();
      this.packetError = new List<string>();
      this.savedPacketEntities = new List<IEntity>();
      this.mergeReplace = new MergeReplace();
      this.mergeUidReplace = new MergeUidReplace();
      this.entitiesMetadata = new Dictionary<Type, List<IPropertyMetadata>>();
      this.headers = new List<long>();
      this.messages = new List<DeployLogMessage>();
      this.testMessages = new List<TestImportMessages>();
      this.systemMessages = new List<DeploySystemMessage>();
      this.testSystemMessages = new List<DeploySystemMessage>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.importSettings = settings;
      this.securityService = securityService;
      this.authenticationService = authenticationService;
      this.modelManager = modelManager;
      this.moduleManager = moduleManager;
      this.withFormDependenciesService = withFormDependenciesService;
      this.zipService = zipService;
      this.tagService = tagService;
      this.unitOfWorkManager = unitOfWorkManager;
      this.runtimeApplication = runtimeApplication;
      this.metadataItemManager = metadataItemManager;
      this.bpmAppManager = bpmAppManager;
      this.packageService = packageService;
      this.packetVersionService = packetVersionService;
      this.runWithSoftDeletableService = runWithSoftDeletableService;
      this.sessionProvider = sessionProvider;
      this.contextCacheService = contextCacheService;
      this.exportImportFileManager = exportImportFileManager;
      this.importExtensions = importExtensions;
      this.configImportActionExtensions = configImportActionExtensions;
      this.entityImportSaveActionExtensions = entityImportSaveActionExtensions;
      this.importantData = importantData;
      this.packetActions = packetActions;
      this.metadataImport = metadataImport;
      this.skipEntityImportResolvers = skipEntityImportResolvers;
      this.ignoreIsUniqueMetadata = ignoreIsUniqueMetadata;
      this.securityDeployHelperExtensions = securityDeployHelperExtensions;
      this.privilegeModuleAccessGroups = privilegeModuleAccessGroups;
      this.postEntityXmlSerializers = postEntityXmlSerializers;
      this.treeUid = settings is IConfigImportSettings configImportSettings ? configImportSettings.FakeManifest?.TreeUid ?? configImportSettings.FileName : (string) null;
    }

    /// <summary>Идентификатор приложения</summary>
    public string AppId
    {
      get
      {
        int num = 1;
        ElmaStoreComponentManifest manifest;
        while (true)
        {
          switch (num)
          {
            case 1:
              manifest = this.manifest;
              if (manifest == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return (string) null;
label_5:
        return (string) ConfigurationImportExecutor.GvRGdQE1iuAiuxD2PxRf((object) manifest);
      }
    }

    /// <summary>Событие завершения стадии импорта</summary>
    public event EventHandler<EventArgs> OnImportFinished;

    /// <summary>Проверка файла импорта</summary>
    /// <param name="parameters">Параметры запуска проверки</param>
    public void RunTest(IRunTestParameters parameters)
    {
      int num1 = 6;
      ConfigurationImportExecutor configurationImportExecutor;
      IRunTestParameters parameters1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_33;
          case 1:
            parameters1 = parameters;
            num1 = 2;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) parameters1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477122732));
            num1 = 4;
            continue;
          case 3:
label_4:
            TestImportMessages message1 = new TestImportMessages();
            ConfigurationImportExecutor.wt62WtE1k42GRNSw2qm3((object) message1, TestImportMessagesType.Finish);
            this.TestMessageInternalAdd(message1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          case 4:
            try
            {
              CallContextSessionOwner contextSessionOwner = (CallContextSessionOwner) ConfigurationImportExecutor.mnstkKE1RmbkZ8XHtSpt();
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
                num2 = 0;
              switch (num2)
              {
                case 1:
                  goto label_4;
                default:
                  try
                  {
                    int num3;
                    if (this.authenticationService.GetCurrentUser<IUser>() != null)
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 2 : 1;
                    else
                      goto label_15;
label_13:
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                        case 3:
                          goto label_4;
                        case 2:
                          this.RunTest(parameters1.ActivationKey, parameters1.CancellationToken);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
                          continue;
                        default:
                          goto label_15;
                      }
                    }
label_15:
                    ConfigurationImportExecutor.xqZoL9E1ql5fDD155gNy((object) this.securityService, (object) (System.Action) (() =>
                    {
                      int num4 = 1;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            configurationImportExecutor.RunTest((string) ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass66_0.Fkbn1q8kLeZfdROwKjNR((object) parameters1), ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass66_0.ns5XyB8kUAaFiLx1A2ij((object) parameters1));
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    }));
                    num3 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
                    {
                      num3 = 3;
                      goto label_13;
                    }
                    else
                      goto label_13;
                  }
                  finally
                  {
                    if (contextSessionOwner != null)
                    {
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                        num5 = 0;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            goto label_22;
                          default:
                            ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) contextSessionOwner);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
                            continue;
                        }
                      }
                    }
label_22:;
                  }
              }
            }
            catch (OperationCanceledException ex)
            {
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
                num6 = 0;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    goto label_4;
                  default:
                    TestImportMessages message2 = new TestImportMessages();
                    ConfigurationImportExecutor.jUdVKCE1TQNJBY9uYmb9((object) message2, ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 221875978)));
                    ConfigurationImportExecutor.wt62WtE1k42GRNSw2qm3((object) message2, TestImportMessagesType.Error);
                    this.TestMessageInternalAdd(message2);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 1;
                    continue;
                }
              }
            }
            catch (Exception ex)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
                num7 = 1;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    ConfigurationImportExecutor.mpPoVWE1OsoeCdWeb6OT((object) EleWise.ELMA.Logging.Logger.Log, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(~541731958 ^ -542002371), (object) ex);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_4;
                  default:
                    TestImportMessages message3 = new TestImportMessages();
                    ConfigurationImportExecutor.jUdVKCE1TQNJBY9uYmb9((object) message3, (object) EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(~-122002947 ^ 121765592), ConfigurationImportExecutor.Ye6XkoE12l2wWmACTc0I((object) ex)));
                    message3.Type = TestImportMessagesType.Error;
                    this.TestMessageInternalAdd(message3);
                    num7 = 2;
                    continue;
                }
              }
            }
          case 5:
            configurationImportExecutor = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
            continue;
          case 6:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 5 : 5;
            continue;
          default:
            goto label_30;
        }
      }
label_33:
      return;
label_30:;
    }

    /// <summary>Запуск импорта конфигурации</summary>
    /// <param name="parameters">Параметры запуска импорта</param>
    public void RunImport(IRunImportParameters parameters)
    {
      int num1 = 2;
      IEnumerator<TestImportMessages> enumerator;
      bool flag;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (ConfigurationImportExecutor.h9ykD5E1Px7Gft1hHX4m((object) this.importSettings) == 1)
            {
              num1 = 7;
              continue;
            }
            goto case 6;
          case 2:
            ConfigurationImportExecutor.LHf4VrE1ediZPOJHUfPP((object) parameters, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-630932142 - 1120244082 ^ -1751127698));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_383;
          case 4:
            goto label_4;
          case 5:
            if (!ConfigurationImportExecutor.NWvLyhE1D9UIVRmgX9sH())
            {
              num1 = 12;
              continue;
            }
            goto case 11;
          case 6:
label_348:
            this.messages = parameters.LogMessages;
            num1 = 10;
            continue;
          case 7:
            if (this.importSettings.TestResult != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 8:
            try
            {
label_358:
              if (ConfigurationImportExecutor.fagugcE1aZARwy0aBgiG((object) enumerator))
                goto label_360;
              else
                goto label_359;
label_352:
              TestImportMessages current;
              TestImportMessagesType importMessagesType;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
label_366:
                    ConfigurationImportExecutor.Y2royjE1plb4gjxp3MMP((object) ConfigurationImportExecutor.ImportLog, ConfigurationImportExecutor.Ylt4G6E13n0iSBWhEp4K((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868063904), ConfigurationImportExecutor.Od4VdXE1NZR6dcJmVHKO((object) current)));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 4 : 0;
                    continue;
                  case 2:
label_362:
                    ConfigurationImportExecutor.Y2royjE1plb4gjxp3MMP((object) ConfigurationImportExecutor.ImportLog, ConfigurationImportExecutor.Ylt4G6E13n0iSBWhEp4K((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289460430), ConfigurationImportExecutor.Od4VdXE1NZR6dcJmVHKO((object) current)));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 5 : 10;
                    continue;
                  case 3:
                  case 4:
                  case 7:
                  case 10:
                    goto label_358;
                  case 5:
                    switch (importMessagesType)
                    {
                      case TestImportMessagesType.InfoCommon:
                      case TestImportMessagesType.InfoMetadata:
                      case TestImportMessagesType.InfoLose:
                        goto label_366;
                      case TestImportMessagesType.Warning:
                        goto label_362;
                      case TestImportMessagesType.Error:
                        goto label_354;
                      default:
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 6 : 7;
                        continue;
                    }
                  case 6:
                    if (current != null)
                    {
                      num2 = 9;
                      continue;
                    }
                    goto label_358;
                  case 8:
                    goto label_360;
                  case 9:
                    importMessagesType = ConfigurationImportExecutor.yWhCiTE11R9j23tRJZIM((object) current);
                    num2 = 5;
                    continue;
                  case 11:
label_354:
                    ConfigurationImportExecutor.Y2royjE1plb4gjxp3MMP((object) ConfigurationImportExecutor.ImportLog, (object) string.Format((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-740338220 ^ -740608944), ConfigurationImportExecutor.Od4VdXE1NZR6dcJmVHKO((object) current)));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 3;
                    continue;
                  default:
                    goto label_348;
                }
              }
label_359:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
              goto label_352;
label_360:
              current = enumerator.Current;
              num2 = 6;
              goto label_352;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
              else
                goto label_374;
label_371:
              switch (num3)
              {
                case 1:
                case 2:
              }
label_374:
              ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) enumerator);
              num3 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
              {
                num3 = 2;
                goto label_371;
              }
              else
                goto label_371;
            }
          case 9:
            goto label_349;
          case 10:
            this.systemMessages = parameters.SystemMessages;
            num1 = 5;
            continue;
          case 11:
            this.AddMessage(new DeployLogMessage(DeployLogMessageType.Error, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1350312861 << 3 ^ 2082112168)), true));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 3 : 3;
            continue;
          case 12:
            flag = ConfigurationImportExecutor.xeCFBvE1tQFZShmibxRV((object) this.runWithSoftDeletableService);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 4 : 3;
            continue;
          default:
            enumerator = this.importSettings.TestResult.GetEnumerator();
            num1 = 8;
            continue;
        }
      }
label_383:
      return;
label_349:
      return;
label_4:
      try
      {
        ConfigurationImportExecutor.CI84eLE1w15ESyMY8UaR((object) this.runWithSoftDeletableService, true);
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
          num4 = 0;
        CallContextSessionOwner contextSessionOwner;
        while (true)
        {
          switch (num4)
          {
            case 1:
              contextSessionOwner = (CallContextSessionOwner) ConfigurationImportExecutor.mnstkKE1RmbkZ8XHtSpt();
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_336;
            default:
              goto label_8;
          }
        }
label_336:
        return;
label_8:
        try
        {
          int num5 = 74;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
            num5 = 84;
          System.Action action;
          CancellationToken cancellationToken;
          XmlReader xmlReader;
          string serverFolderName;
          ConfigurationImportExecutor configurationImportExecutor;
          while (true)
          {
            int num6;
            string componentPath;
            StoreComponentUnpackStatus componentUnpackStatus;
            string str;
            string unpackedPackagesFolder;
            List<PackageInstallOperationInfo> list;
            string url;
            XmlTextReader reader;
            object obj;
            IEnumerable<StoreComponentVerifiedSignature> signatures;
            string zipFileName;
            Image manifestImage;
            IElmaComponent packagingComponent;
            switch (num5)
            {
              case 1:
              case 13:
                if (this.manifest != null)
                {
                  num6 = 46;
                  break;
                }
                goto case 69;
              case 2:
                if (this.manifest == null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 58 : 90;
                  continue;
                }
                goto case 97;
              case 3:
              case 67:
              case 101:
label_13:
                action = (System.Action) (() =>
                {
                  int num8 = 3;
                  while (true)
                  {
                    int num9 = num8;
                    IBPMApp bpmApp1;
                    byte[] additionalFilesContent;
                    byte[] helpFileContent;
                    BPMAppManifest bpmAppManifest;
                    IBPMApp bpmApp2;
                    PostCompleteImportParameters postCompleteParams;
                    while (true)
                    {
                      switch (num9)
                      {
                        case 1:
                          configurationImportExecutor.importExtensions.Each<IConfigImportExtension>((Action<IConfigImportExtension>) (e =>
                          {
                            int num10 = 1;
                            while (true)
                            {
                              switch (num10)
                              {
                                case 0:
                                  goto label_2;
                                case 1:
                                  // ISSUE: reference to a compiler-generated method
                                  ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_2.oiV3Qs8nk07E0VhCWC9b((object) e, (object) postCompleteParams);
                                  num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                                  continue;
                                default:
                                  goto label_4;
                              }
                            }
label_2:
                            return;
label_4:;
                          }));
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 13 : 3;
                          continue;
                        case 2:
                          // ISSUE: reference to a compiler-generated method
                          postCompleteParams = new PostCompleteImportParameters(configurationImportExecutor.messages, configurationImportExecutor.systemMessages, serverFolderName, configurationImportExecutor.serviceData, configurationImportExecutor.manifest, ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.I77IhD8nFaFq7a40GkPp((object) configurationImportExecutor.importSettings), configurationImportExecutor.treeUid);
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
                          continue;
                        case 3:
                          goto label_34;
                        case 4:
                          configurationImportExecutor.moduleManager.SaveStoreComponent(configurationImportExecutor.manifest, (IEnumerable<StoreComponentSignatureInfo>) signatures, zipFileName, StoreComponentStatus.Active);
                          num9 = 14;
                          continue;
                        case 5:
                          try
                          {
                            // ISSUE: reference to a compiler-generated method
                            bpmAppManifest = ClassSerializationHelper.DeserializeObjectByXml<BPMAppManifest>((string) ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.fRKROO8nBQKYEIvhXDKp((object) configurationImportExecutor.manifest));
                            int num11 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
                              num11 = 0;
                            switch (num11)
                            {
                              default:
                                goto label_24;
                            }
                          }
                          catch (Exception ex)
                          {
                            int num12 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                              num12 = 0;
                            while (true)
                            {
                              switch (num12)
                              {
                                case 1:
                                  goto label_16;
                                default:
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.jrlrLZ8nb3DmhMThZGV5((object) ConfigurationImportExecutor.ImportLog, ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.IQlNDR8noPf7FvvNIMxd(381945751 ^ 1158627804 ^ 1406088285), (object) ex);
                                  num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
                                  continue;
                              }
                            }
label_16:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            throw new InvalidOperationException((string) ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.J6vO988nhknDyY5U5RRs(ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.IQlNDR8noPf7FvvNIMxd(1178210108 ^ 1178500444)));
                          }
                        case 6:
                          bpmApp1.Installed = true;
                          num9 = 18;
                          continue;
                        case 7:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          bpmApp1 = (IBPMApp) ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.tHoa5F8nQ3YvEJkFwUJM((object) configurationImportExecutor.bpmAppManager, ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.LhZadN8nEoyrmwTy3iaH((object) configurationImportExecutor.manifest));
                          num9 = 10;
                          continue;
                        case 8:
                          // ISSUE: reference to a compiler-generated method
                          configurationImportExecutor.AddAdditionalFilesInBpmApp(configurationImportExecutor.serviceData, serverFolderName, (string) ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.RATqDy8nGeFFJbZAGpmg((object) configurationImportExecutor.manifest), out additionalFilesContent, out helpFileContent);
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 6 : 16;
                          continue;
                        case 9:
                          goto label_32;
                        case 10:
                          // ISSUE: reference to a compiler-generated method
                          ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.b7mmjx8nC1QJcp4HLSee((object) bpmApp1, (object) configurationImportExecutor.manifest);
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 19 : 17;
                          continue;
                        case 11:
                          // ISSUE: reference to a compiler-generated method
                          ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.GOe0ug8n8kGOmWJGpdlY((object) bpmApp1, (object) manifestImage);
                          num9 = 17;
                          continue;
                        case 12:
                          goto label_35;
                        case 13:
                          if (configurationImportExecutor.manifest != null)
                          {
                            num9 = 4;
                            continue;
                          }
                          goto label_14;
                        case 14:
                          bpmAppManifest = (BPMAppManifest) null;
                          num9 = 15;
                          continue;
                        case 15:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (!ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.kygQql8nWdGwTCEGAh2y(ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.fRKROO8nBQKYEIvhXDKp((object) configurationImportExecutor.manifest)))
                          {
                            num9 = 5;
                            continue;
                          }
                          goto case 20;
                        case 16:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          bpmApp2 = (IBPMApp) ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.RAMlmg8nfBQIHtGC5SK3((object) configurationImportExecutor.bpmAppManager, ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.LhZadN8nEoyrmwTy3iaH((object) configurationImportExecutor.manifest));
                          num9 = 21;
                          continue;
                        case 17:
                          // ISSUE: reference to a compiler-generated method
                          ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.m1OLe88nZWPoO6Ecuo8m((object) bpmApp1, (object) additionalFilesContent, (object) helpFileContent);
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 6;
                          continue;
                        case 18:
                          configurationImportExecutor.bpmAppManager.Save(bpmApp1);
                          num9 = 9;
                          continue;
                        case 19:
                          // ISSUE: reference to a compiler-generated method
                          ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.NN0VZ88nvvrkUq6FW7aA((object) bpmApp1, (object) bpmAppManifest);
                          num9 = 11;
                          continue;
                        case 20:
label_24:
                          if (bpmAppManifest != null)
                          {
                            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 3 : 8;
                            continue;
                          }
                          goto label_10;
                        case 21:
                          if (bpmApp2 == null)
                          {
                            num9 = 7;
                            continue;
                          }
                          goto default;
                        default:
                          if (!bpmApp2.Installed)
                          {
                            num9 = 12;
                            continue;
                          }
                          goto case 7;
                      }
                    }
label_34:
                    num8 = 2;
                  }
label_32:
                  return;
label_14:
                  return;
label_10:
                  return;
label_35:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  throw new InvalidOperationException((string) ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.J6vO988nhknDyY5U5RRs(ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.IQlNDR8noPf7FvvNIMxd(1012087039 ^ 1012353617)));
                });
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 10 : 5;
                continue;
              case 4:
                if (!this.manifest.Packages.Any<PackageManifest>())
                {
                  num5 = 21;
                  continue;
                }
                goto default;
              case 5:
                if (ConfigurationImportExecutor.jgeG7iE1AJJVuAtTxp9u((object) url))
                {
                  num5 = 61;
                  continue;
                }
                goto case 3;
              case 6:
                if (this.manifest != null)
                {
                  num6 = 80;
                  break;
                }
                goto label_303;
              case 7:
              case 27:
                zipFileName = (string) null;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 43 : 3;
                continue;
              case 8:
                this.importExtensions.ForEach<IConfigImportExtension>((Action<IConfigImportExtension>) (ext =>
                {
                  int num13 = 1;
                  while (true)
                  {
                    switch (num13)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        ConfigurationImportExecutor.nKImFUEpo4E81h5qigGH((object) ext, (object) new ImportSuccessfullParameters(this.messages, this.systemMessages, this.importSettings));
                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 57 : 60;
                continue;
              case 9:
                this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-87337865 ^ -87083373)), false));
                num5 = 7;
                continue;
              case 10:
                cancellationToken = parameters.CancellationToken;
                num5 = 44;
                continue;
              case 11:
                manifestImage = (Image) null;
                num5 = 59;
                continue;
              case 12:
                if (zipFileName != null)
                {
                  num6 = 47;
                  break;
                }
                goto case 86;
              case 14:
                goto label_355;
              case 15:
                num5 = 2;
                continue;
              case 16:
                if (this.step == ImportStep.Prepare)
                {
                  num5 = 42;
                  continue;
                }
                goto case 77;
              case 17:
                goto label_254;
              case 18:
                if (componentUnpackStatus != StoreComponentUnpackStatus.WrongSignatures)
                {
                  ((EleWise.ELMA.Logging.ILogger) ConfigurationImportExecutor.MlNMGBE1y8ECm86WgVkD()).Error(ConfigurationImportExecutor.CJiYGKE1M9HgOO5j0vIa(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1461825605 - 1531863589 ^ -69784938), (object) componentUnpackStatus));
                  num5 = 17;
                  continue;
                }
                num6 = 58;
                break;
              case 19:
                url = (string) ConfigurationImportExecutor.LDpLgeE1J1pKeCQ2WwM1((object) this.exportImportFileManager, (object) importSettings.FileName, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(993438473 ^ 993195261), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418710664));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
                continue;
              case 20:
              case 21:
              case 90:
              case 99:
                ConfigurationImportExecutor.Djk57qE1lBxyJ81fVK0Z((object) this.packageService);
                num5 = 68;
                continue;
              case 22:
              case 73:
                action();
                num5 = 8;
                continue;
              case 23:
                goto label_353;
              case 24:
                if (url == null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 101 : 59;
                  continue;
                }
                goto case 5;
              case 25:
                componentUnpackStatus = this.UnpackIfSigned("", new Func<DateTime?>(ComponentManager.Current.ModuleManager.GetMainLicensedUnitExpiration), componentPath, serverFolderName, out signatures);
                num5 = 50;
                continue;
              case 26:
              case 79:
                ConfigurationImportExecutor.LDpLgeE1J1pKeCQ2WwM1((object) this.exportImportFileManager, (object) importSettings.FileName, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1319452732 ^ 1319430020), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1867198571 ^ -1867468905));
                num5 = 19;
                continue;
              case 28:
                goto label_342;
              case 29:
                if (packagingComponent == null)
                {
                  num5 = 93;
                  continue;
                }
                if (ConfigurationImportExecutor.u1lVu1E1rkXXYmfryECy((object) serverFolderName))
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 30 : 51;
                  continue;
                }
                obj = ConfigurationImportExecutor.Qv8oHUE1ge6GYP1mkdeN((object) serverFolderName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883079150));
                goto label_309;
              case 30:
                goto label_339;
              case 31:
                object t1 = ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-643786247 ^ -643498029);
                object[] objArray = new object[1];
                object separator = ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(236071375 ^ 236070349);
                List<PackageInstallOperationInfo> source1 = list;
                // ISSUE: reference to a compiler-generated field
                Func<PackageInstallOperationInfo, string> func1 = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__67_8;
                Func<PackageInstallOperationInfo, string> selector1;
                if (func1 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__67_8 = selector1 = (Func<PackageInstallOperationInfo, string>) (p => (string) ConfigurationImportExecutor.\u003C\u003Ec.AHyCwq8nAZCDsRlAcNoC((object) new string[5]
                  {
                    z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487381192),
                    (string) ConfigurationImportExecutor.\u003C\u003Ec.Ef3V7e8n4O6N39Xym68c((object) p),
                    z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70021585),
                    (string) ConfigurationImportExecutor.\u003C\u003Ec.unBkTP8n6eikPopIbMVT((object) p),
                    (string) ConfigurationImportExecutor.\u003C\u003Ec.kAx2j18nHeh7IC2RH0GP(-1824388195 ^ -1824385341)
                  }));
                }
                else
                  goto label_386;
label_321:
                IEnumerable<string> values = source1.Select<PackageInstallOperationInfo, string>(selector1);
                objArray[0] = (object) string.Join((string) separator, values);
                DeployLogMessage message = new DeployLogMessage(DeployLogMessageType.Warn, EleWise.ELMA.SR.T((string) t1, objArray), true, true, true);
                ConfigurationImportExecutor.ay0gPXE1YTK4wbO5QyYJ((object) message, (object) new PackageInstallInfo()
                {
                  Operations = list,
                  UpdatingUid = ConfigurationImportExecutor.dXVsmmE1jF2iJ9LaQlCe()
                });
                this.AddMessage(message);
                num5 = 23;
                continue;
label_386:
                selector1 = func1;
                goto label_321;
              case 32:
                this.importExtensions.Each<IConfigImportExtension>((Action<IConfigImportExtension>) (e =>
                {
                  int num14 = 1;
                  while (true)
                  {
                    switch (num14)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        ConfigurationImportExecutor.tIfLGbEpFRVa2bFp3Zij((object) e, (object) new PreStartImportParameters(this.messages, this.systemMessages, this.importSettings));
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                num6 = 11;
                break;
              case 33:
                serverFolderName = "";
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 20 : 32;
                continue;
              case 34:
                if (this.step != ImportStep.Prepare)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 22 : 27;
                  continue;
                }
                goto case 95;
              case 35:
              case 40:
                this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146240179)), true, true));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 4 : 14;
                continue;
              case 36:
                goto label_36;
              case 37:
                serverFolderName = this.exportImportFileManager.CreateFolderName((string) ConfigurationImportExecutor.O2oXytE162AAMiZL2QmT((object) importSettings));
                num5 = 56;
                continue;
              case 38:
              case 71:
                str = (string) ConfigurationImportExecutor.dYeXvrE19eZSUKAbx1sd((object) this.exportImportFileManager, (object) importSettings.FileName);
                num5 = 91;
                continue;
              case 39:
                IEnumerable<PackageManifest> source2 = this.manifest.Packages.Where<PackageManifest>((Func<PackageManifest, bool>) (p =>
                {
                  int num15 = 1;
                  ElmaPackageMetadata metadata;
                  while (true)
                  {
                    switch (num15)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        metadata = new ElmaPackageMetadata((string) ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_1.UkHEf58nR9v6Buenud9P((object) p));
                        num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_3;
                    }
                  }
label_3:
                  return packagingComponent.IsCompatible(metadata);
                }));
                // ISSUE: reference to a compiler-generated field
                Func<PackageManifest, PackageInstallOperationInfo> func2 = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__67_7;
                Func<PackageManifest, PackageInstallOperationInfo> selector2;
                if (func2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__67_7 = selector2 = (Func<PackageManifest, PackageInstallOperationInfo>) (p =>
                  {
                    PackageInstallOperationInfo installOperationInfo = new PackageInstallOperationInfo();
                    // ISSUE: reference to a compiler-generated method
                    ConfigurationImportExecutor.\u003C\u003Ec.gAx15A8naZqvMwxrcCFc((object) installOperationInfo, (object) p.Id);
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ConfigurationImportExecutor.\u003C\u003Ec.QXkgLp8ntvfbbD7sVkTZ((object) installOperationInfo, ConfigurationImportExecutor.\u003C\u003Ec.g5fpXx8nDQNtmllOA4mv((object) p));
                    // ISSUE: reference to a compiler-generated method
                    ConfigurationImportExecutor.\u003C\u003Ec.zUlkSP8nwdncnhwL5yBb((object) installOperationInfo, PackageOperationType.Install);
                    return installOperationInfo;
                  });
                }
                else
                  goto label_387;
label_317:
                list = source2.Select<PackageManifest, PackageInstallOperationInfo>(selector2).ToList<PackageInstallOperationInfo>();
                num5 = 52;
                continue;
label_387:
                selector2 = func2;
                goto label_317;
              case 41:
                ICollection<TestImportMessages> testResult = this.importSettings.TestResult;
                // ISSUE: reference to a compiler-generated field
                Func<TestImportMessages, bool> func3 = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__67_5;
                Func<TestImportMessages, bool> predicate;
                if (func3 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__67_5 = predicate = (Func<TestImportMessages, bool>) (t => ConfigurationImportExecutor.\u003C\u003Ec.mJ2Ky68npRyYQ6FnBQOg((object) t));
                }
                else
                  goto label_388;
label_312:
                if (!testResult.Any<TestImportMessages>(predicate))
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 35 : 13;
                  continue;
                }
                goto case 39;
label_388:
                predicate = func3;
                goto label_312;
              case 42:
                this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1917256330 ^ 1917018602), ConfigurationImportExecutor.IqRtZhE17pn25i9D9fqG((object) this.manifest), ConfigurationImportExecutor.i9i9roE1xW3lOWfH6muS((object) this.manifest)), false));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 12 : 77;
                continue;
              case 43:
                signatures = (IEnumerable<StoreComponentVerifiedSignature>) null;
                num5 = 33;
                continue;
              case 44:
                cancellationToken.ThrowIfCancellationRequested();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 53 : 6;
                continue;
              case 45:
                cancellationToken.ThrowIfCancellationRequested();
                num5 = 98;
                continue;
              case 46:
                if (this.step == ImportStep.Prepare)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 88 : 21;
                  continue;
                }
                goto case 69;
              case 47:
              case 85:
                if (this.manifest != null)
                {
                  num5 = 15;
                  continue;
                }
                goto case 35;
              case 48:
                this.manifest.Packages.ForEach((Action<PackageManifest>) (p =>
                {
                  int num16 = 1;
                  while (true)
                  {
                    switch (num16)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        this.AddMessage(new DeployLogMessage(BPMAppItemImportStatus.InProgress, (string) ConfigurationImportExecutor.sScEJBEpBDW6U2w2MX2Z((object) p), this.treeUid));
                        num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                num5 = 20;
                continue;
              case 49:
                this.moduleManager.SaveStoreComponent(this.manifest, (IEnumerable<StoreComponentSignatureInfo>) signatures, zipFileName, StoreComponentStatus.Allowed, unpackedPackagesFolder);
                num5 = 65;
                continue;
              case 50:
                this.manifest = ElmaStoreComponentsBuilder.Read(zipFileName, out manifestImage);
                num5 = 75;
                continue;
              case 51:
                obj = (object) null;
                goto label_309;
              case 52:
                if (list.Count > 0)
                {
                  num5 = 87;
                  continue;
                }
                goto case 35;
              case 53:
                if (!this.XmlDataExists(this.importSettings))
                {
                  num5 = 22;
                  continue;
                }
                goto case 81;
              case 54:
                ConfigurationImportExecutor.wvWV5EE1m0sGgDNVcSf3((object) this.zipService, (object) componentPath, (object) serverFolderName);
                num5 = 26;
                continue;
              case 55:
                if (!(this.importSettings is IConfigImportSettings importSettings))
                {
                  num6 = 3;
                  break;
                }
                goto case 70;
              case 56:
                zipFileName = (string) ConfigurationImportExecutor.Y12gHtE1HlUGeXH6LxZY((object) this.exportImportFileManager, ConfigurationImportExecutor.O2oXytE162AAMiZL2QmT((object) importSettings));
                num5 = 92;
                continue;
              case 57:
                goto label_31;
              case 58:
                ((EleWise.ELMA.Logging.ILogger) ConfigurationImportExecutor.MlNMGBE1y8ECm86WgVkD()).Error((object) (ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1253244298 - 1829393894 ^ -575880430).ToString() + (object) componentUnpackStatus));
                num5 = 36;
                continue;
              case 59:
                cancellationToken = parameters.CancellationToken;
                num5 = 66;
                continue;
              case 60:
                ConfigurationImportExecutor.Y2royjE1plb4gjxp3MMP((object) ConfigurationImportExecutor.ImportLog, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(589593376 ^ -1977315327 ^ -1459321419));
                num5 = 63;
                continue;
              case 61:
                reader = new XmlTextReader(url);
                num5 = 103;
                continue;
              case 62:
label_35:
                this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1925118608 << 2 ^ -889222766)), false));
                num5 = 79;
                continue;
              case 63:
                this.messages.Add(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-606654180 ^ -606904326)), true));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 100 : 47;
                continue;
              case 64:
                goto label_302;
              case 65:
                if (this.importSettings.TestResult != null)
                {
                  num5 = 41;
                  continue;
                }
                goto case 35;
              case 66:
                cancellationToken.ThrowIfCancellationRequested();
                num5 = 55;
                continue;
              case 68:
                packagingComponent = this.packageService.GetComponent();
                num5 = 29;
                continue;
              case 69:
              case 78:
                cancellationToken = ConfigurationImportExecutor.hb8IciE1dPjQVL0HJ6Vx((object) parameters);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 37 : 45;
                continue;
              case 70:
                url = (string) null;
                num5 = 37;
                continue;
              case 72:
              case 102:
                if (componentUnpackStatus != StoreComponentUnpackStatus.Unsigned)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 89 : 66;
                  continue;
                }
                goto case 6;
              case 74:
                componentPath = (string) ConfigurationImportExecutor.Y12gHtE1HlUGeXH6LxZY((object) this.exportImportFileManager, ConfigurationImportExecutor.O2oXytE162AAMiZL2QmT((object) importSettings));
                num5 = 94;
                continue;
              case 75:
                if (this.manifest != null)
                {
                  num5 = 16;
                  continue;
                }
                goto case 77;
              case 76:
                this.metadataNotIsUnique = (ISet<Guid>) new HashSet<Guid>();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 34 : 18;
                continue;
              case 77:
                switch (componentUnpackStatus)
                {
                  case StoreComponentUnpackStatus.Success:
                    goto label_35;
                  case StoreComponentUnpackStatus.ActivationError:
                    num5 = 57;
                    continue;
                  default:
                    num5 = 72;
                    continue;
                }
              case 80:
                if (ConfigurationImportExecutor.CFAxwhE10s00iyrA5l0u((object) this.manifest) == ElmaStoreComponentActivationType.Paid)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 64 : 56;
                  continue;
                }
                goto label_303;
              case 81:
                xmlReader = this.GetXmlReader(this.importSettings);
                num5 = 96;
                continue;
              case 82:
                this.signUserId = ConfigurationImportExecutor.NCSjPOE14LFcERlhbSPn((object) parameters);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 83 : 41;
                continue;
              case 83:
                this.FillImportData();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 76 : 58;
                continue;
              case 84:
                configurationImportExecutor = this;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 33 : 82;
                continue;
              case 86:
                this.AddMessage(new DeployLogMessage(DeployLogMessageType.Empty, string.Format(""), true, true));
                num6 = 30;
                break;
              case 87:
                ConfigurationImportExecutor.Y2royjE1plb4gjxp3MMP((object) ConfigurationImportExecutor.ImportLog, ConfigurationImportExecutor.UODdpwE15Qf06297AiTd(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1021410165 ^ 1021648519), (object) string.Join<PackageOperationInfo>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852834298), (IEnumerable<PackageOperationInfo>) this.packagesOperations)));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 31 : 12;
                continue;
              case 88:
                List<TestImportMessages> tagMessages;
                int num17 = this.CheckManifestTag(out tagMessages) ? 1 : 0;
                tagMessages?.ForEach((Action<TestImportMessages>) (m =>
                {
                  int num18 = 1;
                  while (true)
                  {
                    switch (num18)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigurationImportExecutor.Od4VdXE1NZR6dcJmVHKO((object) m), true));
                        num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                if (num17 != 0)
                {
                  num5 = 69;
                  continue;
                }
                goto label_346;
              case 89:
                if (componentUnpackStatus == StoreComponentUnpackStatus.FreeSigned)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 6 : 1;
                  continue;
                }
                goto case 18;
              case 91:
                ConfigurationImportExecutor.jgeG7iE1AJJVuAtTxp9u((object) str);
                num5 = 13;
                continue;
              case 92:
                if (!ConfigurationImportExecutor.jgeG7iE1AJJVuAtTxp9u((object) zipFileName))
                {
                  num5 = 38;
                  continue;
                }
                goto case 74;
              case 93:
                goto label_245;
              case 94:
                this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(381945751 ^ 1158627804 ^ 1406084439)), false));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 14 : 25;
                continue;
              case 95:
                ConfigurationImportExecutor.ImportLog.Info(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1867198571 ^ -1867469519));
                num5 = 9;
                continue;
              case 96:
                goto label_44;
              case 97:
                if (this.manifest != null)
                {
                  num5 = 4;
                  continue;
                }
                goto case 20;
              case 98:
                if (this.step == ImportStep.Prepare)
                {
                  num6 = 12;
                  break;
                }
                goto case 24;
              case 100:
                goto label_334;
              case 103:
                try
                {
                  int num19;
                  if (reader == null)
                    num19 = 4;
                  else
                    goto label_220;
label_217:
                  while (true)
                  {
                    switch (num19)
                    {
                      case 1:
                        goto label_222;
                      case 2:
                        goto label_226;
                      case 5:
                        goto label_220;
                      case 7:
                        int num20 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) reader);
                        num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 2;
                        continue;
                      case 8:
                        reader.Read();
                        num19 = 7;
                        continue;
                      case 9:
                        goto label_218;
                      default:
                        goto label_13;
                    }
                  }
label_226:
                  try
                  {
label_231:
                    if (ConfigurationImportExecutor.u8mPV3ENBOqyjN9FPD2H((object) reader) != XmlNodeType.EndElement)
                      goto label_235;
                    else
                      goto label_232;
label_227:
                    int num21;
                    while (true)
                    {
                      switch (num21)
                      {
                        case 1:
                          goto label_235;
                        case 2:
                          goto label_13;
                        case 3:
                          if (!ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow((object) reader.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811788184)))
                          {
                            num21 = 8;
                            continue;
                          }
                          goto case 5;
                        case 4:
                          goto label_231;
                        case 5:
                          this.ReadFilesSection((XmlReader) reader);
                          num21 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                          continue;
                        case 6:
                        case 8:
                          goto label_228;
                        default:
                          int content = (int) reader.MoveToContent();
                          num21 = 4;
                          continue;
                      }
                    }
label_228:
                    ConfigurationImportExecutor.qPNZx7ENFAG8vQyPD8WG((object) reader);
                    num21 = 7;
                    goto label_227;
label_232:
                    num21 = 2;
                    goto label_227;
label_235:
                    if (reader.IsStartElement())
                    {
                      num21 = 3;
                      goto label_227;
                    }
                    else
                      goto label_228;
                  }
                  catch (Exception ex)
                  {
                    int num22 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                      num22 = 0;
                    switch (num22)
                    {
                      default:
                        goto label_13;
                    }
                  }
label_218:
                  if (!ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) reader))
                  {
                    num19 = 8;
                    goto label_217;
                  }
                  else
                    goto case 3;
label_220:
                  if (!ConfigurationImportExecutor.aHWlqJE1LYQIoxkGNkvB((object) reader))
                  {
                    num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
                    goto label_217;
                  }
label_222:
                  if (!ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) reader), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1322834494)))
                  {
                    num19 = 3;
                    goto label_217;
                  }
                  else
                    goto label_218;
                }
                finally
                {
                  int num23;
                  if (reader == null)
                    num23 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
                  else
                    goto label_243;
label_242:
                  switch (num23)
                  {
                    case 1:
                    case 2:
                  }
label_243:
                  ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) reader);
                  num23 = 2;
                  goto label_242;
                }
              default:
                if (importSettings.FakeManifest == null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 93 : 99;
                  continue;
                }
                goto case 48;
            }
label_11:
            num5 = num6;
            continue;
label_303:
            this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, componentUnpackStatus == StoreComponentUnpackStatus.Unsigned ? (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1598106783 - -968262081 ^ -630116010)) : (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1978478350 ^ -1978223840)), false));
            num6 = 54;
            goto label_11;
label_309:
            unpackedPackagesFolder = (string) obj;
            num5 = 49;
          }
label_355:
          return;
label_353:
          return;
label_342:
          return;
label_339:
          return;
label_334:
          return;
label_31:
          throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(--1360331293 ^ 1360093571)));
label_36:
          throw new InvalidOperationException((string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(236071375 ^ 236342579)));
label_44:
          try
          {
            int num24 = 44;
            while (true)
            {
              int num25;
              string contentType;
              string attribute;
              bool needRestart;
              string str1;
              string str2;
              List<ConfigurationImportExecutor.ReadPacketResult> source3;
              MetadataServiceContext metadataServiceContext;
              PreReadPacketsParameters preReadPacketsParams;
              PostReadPacketsParameters postReadPacketsParams;
              switch (num24)
              {
                case 1:
                case 48:
                case 72:
                  if (this.step == ImportStep.Prepare)
                  {
                    num24 = 46;
                    continue;
                  }
                  goto case 42;
                case 2:
                case 61:
                  ConfigurationImportExecutor.qPNZx7ENFAG8vQyPD8WG((object) xmlReader);
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 21 : 13;
                  continue;
                case 3:
                  try
                  {
                    // ISSUE: reference to a compiler-generated method
                    source3.ForEach((Action<ConfigurationImportExecutor.ReadPacketResult>) (r => ConfigurationImportExecutor.\u003C\u003Ec.xggMeu8n7D0AUJd2hH2t((object) r)));
                    int num26 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
                      num26 = 0;
                    switch (num26)
                    {
                      default:
                        goto label_67;
                    }
                  }
                  finally
                  {
                    int num27;
                    if (metadataServiceContext == null)
                      num27 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
                    else
                      goto label_141;
label_140:
                    switch (num27)
                    {
                      case 2:
                        break;
                      default:
                    }
label_141:
                    ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) metadataServiceContext);
                    num27 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
                    {
                      num27 = 0;
                      goto label_140;
                    }
                    else
                      goto label_140;
                  }
                case 4:
                  ConfigurationImportExecutor.ImportLog.Info((object) string.Format((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(2008901894 << 3 ^ -1108402018), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1819636893 << 3 ^ 1672477208)));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 20 : 34;
                  continue;
                case 5:
                  goto label_373;
                case 6:
                case 101:
                  int num28 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader);
                  num24 = 12;
                  continue;
                case 7:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Error, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751432894)), true));
                  num25 = 99;
                  break;
                case 8:
                  ConfigurationImportExecutor.ImportLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979487579));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 10 : 0;
                  continue;
                case 9:
                  if (this.step == ImportStep.ImportMetadata)
                  {
                    num24 = 35;
                    continue;
                  }
                  goto case 77;
                case 10:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(993438473 ^ 993183215)), true));
                  num25 = 110;
                  break;
                case 11:
                  int num29 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader);
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 49 : 57;
                  continue;
                case 12:
                case 45:
                  if (ConfigurationImportExecutor.u8mPV3ENBOqyjN9FPD2H((object) xmlReader) == XmlNodeType.EndElement)
                  {
                    num24 = 27;
                    continue;
                  }
                  goto case 79;
                case 13:
                  this.messages.Add(new DeployLogMessage(DeployLogMessageType.Error, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372485991)), true));
                  num24 = 83;
                  continue;
                case 14:
                  needRestart = true;
                  num24 = 81;
                  continue;
                case 15:
                  List<ConfigurationImportExecutor.ReadPacketResult> source4 = source3;
                  // ISSUE: reference to a compiler-generated field
                  Func<ConfigurationImportExecutor.ReadPacketResult, IEnumerable<IMetadata>> func = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__67_14;
                  Func<ConfigurationImportExecutor.ReadPacketResult, IEnumerable<IMetadata>> selector;
                  if (func == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__67_14 = selector = (Func<ConfigurationImportExecutor.ReadPacketResult, IEnumerable<IMetadata>>) (r => r.Metadatas);
                  }
                  else
                    goto label_389;
label_188:
                  metadataServiceContext = MetadataServiceContext.Extend(source4.SelectMany<ConfigurationImportExecutor.ReadPacketResult, IMetadata>(selector));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 3;
                  continue;
label_389:
                  selector = func;
                  goto label_188;
                case 16:
                case 37:
                  ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader);
                  num24 = 107;
                  continue;
                case 17:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082115432)), true, true));
                  num24 = 59;
                  continue;
                case 18:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-16752921 ^ -16501151), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(92412609 - 1050237057 ^ -957571920), (object) ExportImportVersion.VersionDescription), false));
                  num24 = 4;
                  continue;
                case 19:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1178210108 ^ 1178493772)), false));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 14 : 4;
                  continue;
                case 20:
                  if (ConfigurationImportExecutor.xfWXwXENbk9MHTq6ErLw((object) attribute, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35741917)))
                  {
                    num24 = 36;
                    continue;
                  }
                  goto case 1;
                case 21:
                case 53:
                  int num30 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader);
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 35 : 66;
                  continue;
                case 22:
                  if (source3.Any<ConfigurationImportExecutor.ReadPacketResult>((Func<ConfigurationImportExecutor.ReadPacketResult, bool>) (r => r.Metadatas.Any<IMetadata>())))
                  {
                    num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 15 : 6;
                    continue;
                  }
                  goto case 80;
                case 23:
                  this.ReadServiceData(xmlReader);
                  num24 = 33;
                  continue;
                case 24:
                  if (!this.MoveToConfigurationData(xmlReader))
                  {
                    num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 7 : 1;
                    continue;
                  }
                  goto case 99;
                case 25:
                  ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader);
                  num24 = 11;
                  continue;
                case 26:
label_56:
                  ConfigurationImportExecutor.Y2royjE1plb4gjxp3MMP((object) ConfigurationImportExecutor.ImportLog, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1597012150 ^ 1597249172));
                  num24 = 89;
                  continue;
                case 27:
                case 87:
                  if (this.step == ImportStep.ImportMetadata)
                  {
                    num24 = 22;
                    continue;
                  }
                  goto case 80;
                case 28:
                  ConfigurationImportExecutor.dyhjy5EN8VoqkehOYLQ1((object) action);
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 94 : 29;
                  continue;
                case 29:
                  goto label_368;
                case 30:
                case 97:
                  ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader);
                  num24 = 95;
                  continue;
                case 31:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Summary, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-882126494 ^ -881869242), (object) ConfigurationImportExecutor.pKSQRRENZbYQwtPx8LrK((object) this.packetError)), false));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 65 : 69;
                  continue;
                case 32:
                  cancellationToken.ThrowIfCancellationRequested();
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 30 : 56;
                  continue;
                case 33:
                  if (this.step != ImportStep.Prepare)
                  {
                    num24 = 9;
                    continue;
                  }
                  goto case 63;
                case 34:
                  if (!ConfigurationImportExecutor.xfWXwXENbk9MHTq6ErLw((object) attribute, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(~-122002947 ^ 121749732)))
                  {
                    num24 = 72;
                    continue;
                  }
                  goto case 20;
                case 35:
                  ConfigurationImportExecutor.dTs50nENEjlYgpFBoeKx((object) xmlReader, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-867826612 ^ -868061290));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 59 : 100;
                  continue;
                case 36:
                  if (this.step != ImportStep.Prepare)
                  {
                    num24 = 48;
                    continue;
                  }
                  goto case 88;
                case 38:
                  goto label_367;
                case 39:
                  ConfigurationImportExecutor.ImportLog.Warn((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333484396), (object) attribute, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(333888594 ^ 1075625116 ^ 1409179198)));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
                  continue;
                case 40:
                  ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader);
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 4 : 6;
                  continue;
                case 41:
                  this.importExtensions.Each<IConfigImportExtension>((Action<IConfigImportExtension>) (e =>
                  {
                    int num31 = 1;
                    while (true)
                    {
                      switch (num31)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          e.OnPostReadPackets(postReadPacketsParams);
                          num31 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  }));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                  continue;
                case 42:
                case 52:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Empty, "", false));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 106 : 99;
                  continue;
                case 43:
                case 93:
                  ConfigurationImportExecutor.qPNZx7ENFAG8vQyPD8WG((object) xmlReader);
                  num24 = 101;
                  continue;
                case 44:
                  if (!this.CheckImportFileVersion(xmlReader))
                  {
                    num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 55 : 22;
                    continue;
                  }
                  goto case 62;
                case 46:
                  if (!xmlReader.MoveToAttribute((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1514961705 ^ 1514672857)))
                  {
                    num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 42 : 21;
                    continue;
                  }
                  goto case 82;
                case 47:
                  ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader);
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 69 : 71;
                  continue;
                case 49:
                  attribute = xmlReader.GetAttribute((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-630932142 - 1120244082 ^ -1751432302));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 42 : 65;
                  continue;
                case 50:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1573992878), (object) str1), false));
                  num24 = 68;
                  continue;
                case 51:
                  if (ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) xmlReader))
                  {
                    num24 = 16;
                    continue;
                  }
                  goto case 25;
                case 54:
                  if (!ConfigurationImportExecutor.xZ06MUENQJVAH6dS5LZK(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-87337865 ^ -87082967)))
                  {
                    num24 = 43;
                    continue;
                  }
                  goto case 78;
                case 55:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Error, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886885081)), true));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 27 : 104;
                  continue;
                case 56:
                  if (this.step == ImportStep.ImportMetadata)
                  {
                    num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 60 : 37;
                    continue;
                  }
                  goto case 28;
                case 57:
                case 66:
                  if (ConfigurationImportExecutor.u8mPV3ENBOqyjN9FPD2H((object) xmlReader) == XmlNodeType.EndElement)
                  {
                    num24 = 37;
                    continue;
                  }
                  goto case 67;
                case 58:
                  if (!ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow((object) xmlReader.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 221884690)))
                  {
                    num24 = 108;
                    continue;
                  }
                  goto case 30;
                case 59:
                  goto label_363;
                case 60:
                  if (this.headers.Any<long>())
                  {
                    num24 = 19;
                    continue;
                  }
                  goto case 17;
                case 62:
                  if (ConfigurationImportExecutor.hKO1JNENoXjLkkOJaRkc((object) xmlReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521505742)))
                  {
                    num24 = 49;
                    continue;
                  }
                  goto case 1;
                case 63:
                case 70:
                  preReadPacketsParams = new PreReadPacketsParameters(this.messages, this.systemMessages, serverFolderName, this.serviceData, this.manifest, ConfigurationImportExecutor.h9ykD5E1Px7Gft1hHX4m((object) this.importSettings));
                  num25 = 64;
                  break;
                case 64:
                  this.importExtensions.Each<IConfigImportExtension>((Action<IConfigImportExtension>) (e =>
                  {
                    int num32 = 1;
                    while (true)
                    {
                      switch (num32)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_3.e0l4Wo8nekjwFjnE1d4F((object) e, (object) preReadPacketsParams);
                          num32 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  }));
                  num24 = 75;
                  continue;
                case 65:
                  if (this.step == ImportStep.Prepare)
                  {
                    num24 = 18;
                    continue;
                  }
                  goto case 34;
                case 67:
                  str2 = (string) ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader);
                  num24 = 73;
                  continue;
                case 68:
                  ConfigurationImportExecutor.ImportLog.Info(ConfigurationImportExecutor.Ylt4G6E13n0iSBWhEp4K(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1994213607 >> 4 ^ 124370650), (object) str1));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 52 : 39;
                  continue;
                case 69:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(813604817 ^ 813363445), (object) ConfigurationImportExecutor.pKSQRRENZbYQwtPx8LrK((object) this.packetError)), true));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 67 : 96;
                  continue;
                case 71:
                  int num33 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader);
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 17 : 45;
                  continue;
                case 73:
                  if (!(str2 == (string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(964881585 - -1459193222 ^ -1871172277)))
                  {
                    num25 = 61;
                    break;
                  }
                  goto case 109;
                case 74:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Empty, (string) ConfigurationImportExecutor.XMrkgmENfovAAtbNS0Bw((object) "", (object) Array.Empty<object>()), false));
                  num24 = 70;
                  continue;
                case 75:
                  source3 = new List<ConfigurationImportExecutor.ReadPacketResult>();
                  num24 = 103;
                  continue;
                case 76:
                case 85:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-542721635 ^ -542976133)), false));
                  num24 = 31;
                  continue;
                case 77:
                  ConfigurationImportExecutor.dTs50nENEjlYgpFBoeKx((object) xmlReader, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1051276242 - 990076387 ^ 61176167));
                  num24 = 84;
                  continue;
                case 78:
                  if (ConfigurationImportExecutor.X15jF8ENCq9JFFU7mBYM((object) this.packetVersionService, ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader), (object) contentType))
                  {
                    num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 30 : 13;
                    continue;
                  }
                  goto case 43;
                case 79:
                  contentType = (string) ConfigurationImportExecutor.bvLSv2ENhtbgyyFsrZvn((object) xmlReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334848397));
                  num24 = 98;
                  continue;
                case 80:
label_67:
                  postReadPacketsParams = new PostReadPacketsParameters(this.messages, this.systemMessages, serverFolderName, this.serviceData, this.manifest, this.importSettings.ImportStep, this.headers, this.treeUid);
                  num24 = 41;
                  continue;
                case 81:
                  try
                  {
                    ConfigurationImportExecutor.ImportLog.Info((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306212886) + string.Join<long>((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1445902765 ^ -1980277732 ^ 539366989), (IEnumerable<long>) this.headers)));
                    int num34 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
                      num34 = 0;
                    while (true)
                    {
                      switch (num34)
                      {
                        case 1:
                          this.configImportActionExtensions.ForEach<IConfigImportActionExtension>((Action<IConfigImportActionExtension>) (ext =>
                          {
                            int num35 = 1;
                            while (true)
                            {
                              switch (num35)
                              {
                                case 0:
                                  goto label_2;
                                case 1:
                                  ConfigurationImportExecutor.popfIhEpWM61FuX4KaTF((object) ext, (object) new PrePublishParameters(this.messages, this.systemMessages, this.serviceData, this.importSettings));
                                  num35 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                                  continue;
                                default:
                                  goto label_4;
                              }
                            }
label_2:
                            return;
label_4:;
                          }));
                          num34 = 3;
                          continue;
                        case 2:
                          this.AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-787452571 ^ -787218039)), false));
                          num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
                          continue;
                        case 3:
                          needRestart = this.modelManager.Publish("", (long[]) ConfigurationImportExecutor.AQbKojENvtPqGhFGxYCO((object) this.headers)).NeedRestart;
                          num34 = 5;
                          continue;
                        case 4:
                          goto label_56;
                        case 5:
                          this.configImportActionExtensions.ForEach<IConfigImportActionExtension>((Action<IConfigImportActionExtension>) (ext =>
                          {
                            int num36 = 1;
                            while (true)
                            {
                              switch (num36)
                              {
                                case 0:
                                  goto label_2;
                                case 1:
                                  // ISSUE: reference to a compiler-generated method
                                  ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass67_0.lnQdZv8nujbBarKQn6rQ((object) ext, (object) new PostPublishParameters(configurationImportExecutor.messages, configurationImportExecutor.systemMessages, serverFolderName, configurationImportExecutor.serviceData, configurationImportExecutor.importSettings));
                                  num36 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                                  continue;
                                default:
                                  goto label_4;
                              }
                            }
label_2:
                            return;
label_4:;
                          }));
                          num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 4 : 3;
                          continue;
                        default:
                          this.AddMessage(new DeployLogMessage(DeployLogMessageType.Empty, string.Empty, false));
                          num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 1;
                          continue;
                      }
                    }
                  }
                  catch (Exception ex)
                  {
                    int num37 = 2;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
                      num37 = 1;
                    while (true)
                    {
                      switch (num37)
                      {
                        case 1:
                          goto label_372;
                        case 2:
                          ConfigurationImportExecutor.mpPoVWE1OsoeCdWeb6OT((object) ConfigurationImportExecutor.ImportLog, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(87862435 ^ 87605559), (object) ex);
                          num37 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
                          continue;
                        default:
                          this.AddMessage(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420504932)), true));
                          num37 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
                          continue;
                      }
                    }
label_372:
                    return;
                  }
                case 82:
                  str1 = (string) ConfigurationImportExecutor.bvLSv2ENhtbgyyFsrZvn((object) xmlReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757404366));
                  num24 = 50;
                  continue;
                case 83:
                  goto label_330;
                case 84:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979720596)), false));
                  num24 = 74;
                  continue;
                case 86:
                  if (ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow((object) xmlReader.Name, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(~-306453669 ^ 306201288)))
                  {
                    num24 = 97;
                    continue;
                  }
                  goto case 54;
                case 88:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(~-306453669 ^ 306213954), (object) attribute, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-630932142 - 1120244082 ^ -1751419632)), false));
                  num24 = 39;
                  continue;
                case 89:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409183386)), true, true, needRestart));
                  num24 = 5;
                  continue;
                case 90:
                  ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader);
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 24 : 14;
                  continue;
                case 91:
                  if (ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(712480695 ^ 712244383)))
                  {
                    num24 = 51;
                    continue;
                  }
                  goto case 23;
                case 92:
                  this.importExtensions.ForEach<IConfigImportExtension>((Action<IConfigImportExtension>) (ext =>
                  {
                    int num38 = 1;
                    while (true)
                    {
                      switch (num38)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          ConfigurationImportExecutor.nKImFUEpo4E81h5qigGH((object) ext, (object) new ImportSuccessfullParameters(this.messages, this.systemMessages, this.importSettings));
                          num38 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  }));
                  num24 = 8;
                  continue;
                case 94:
                  if (ConfigurationImportExecutor.pKSQRRENZbYQwtPx8LrK((object) this.packetError) != 0)
                  {
                    num24 = 85;
                    continue;
                  }
                  goto case 92;
                case 95:
                  source3.Add(this.ReadPacket(xmlReader, contentType, serverFolderName));
                  num24 = 40;
                  continue;
                case 96:
                  ConfigurationImportExecutor.ImportLog.Warn(ConfigurationImportExecutor.Ylt4G6E13n0iSBWhEp4K(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1505778440 - 1981636111 ^ -475622521), (object) ConfigurationImportExecutor.pKSQRRENZbYQwtPx8LrK((object) this.packetError)));
                  num24 = 38;
                  continue;
                case 98:
                  if (this.step != ImportStep.ImportData)
                  {
                    num24 = 58;
                    continue;
                  }
                  goto case 108;
                case 99:
                  xmlReader.Read();
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 32 : 105;
                  continue;
                case 100:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(~541731958 ^ -542001049)), false));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 102 : 19;
                  continue;
                case 102:
                  this.AddMessage(new DeployLogMessage(DeployLogMessageType.Empty, (string) ConfigurationImportExecutor.XMrkgmENfovAAtbNS0Bw((object) "", (object) Array.Empty<object>()), false));
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 63 : 8;
                  continue;
                case 103:
                  if (ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) xmlReader))
                  {
                    num24 = 87;
                    continue;
                  }
                  goto case 47;
                case 104:
                  ConfigurationImportExecutor.xQ7nFOENWZ1yyIBkqRi4((object) ConfigurationImportExecutor.ImportLog, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957569560), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 60918549)));
                  num24 = 29;
                  continue;
                case 105:
                  int num39 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader);
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 91 : 72;
                  continue;
                case 106:
                  xmlReader.MoveToElement();
                  num24 = 90;
                  continue;
                case 107:
                  int content = (int) xmlReader.MoveToContent();
                  num25 = 23;
                  break;
                case 108:
                  if (this.step == ImportStep.ImportData)
                  {
                    num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 63 : 86;
                    continue;
                  }
                  goto case 43;
                case 109:
                  if (this.ReadImportants(xmlReader))
                  {
                    num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 25 : 53;
                    continue;
                  }
                  goto case 13;
                case 110:
                  goto label_327;
                default:
                  cancellationToken = parameters.CancellationToken;
                  num25 = 32;
                  break;
              }
              num24 = num25;
            }
label_373:
            return;
label_368:
            return;
label_367:
            return;
label_363:
            return;
label_330:
            return;
label_327:
            return;
          }
          finally
          {
            int num40;
            if (xmlReader == null)
              num40 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 1;
            else
              goto label_192;
label_191:
            switch (num40)
            {
              case 2:
                break;
              default:
            }
label_192:
            xmlReader.Dispose();
            num40 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
            {
              num40 = 0;
              goto label_191;
            }
            else
              goto label_191;
          }
label_245:
          throw new InvalidOperationException((string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281605844)));
label_254:
          throw new InvalidOperationException((string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218209130)));
label_302:
          throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(864270449 << 6 ^ -521504696)));
label_346:;
        }
        finally
        {
          if (contextSessionOwner != null)
          {
            int num41 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
              num41 = 0;
            while (true)
            {
              switch (num41)
              {
                case 1:
                  goto label_329;
                default:
                  ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) contextSessionOwner);
                  num41 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 0;
                  continue;
              }
            }
          }
label_329:;
        }
      }
      catch (OperationCanceledException ex)
      {
        int num42 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
          num42 = 0;
        while (true)
        {
          switch (num42)
          {
            case 0:
              goto label_322;
            case 1:
              this.AddMessage(new DeployLogMessage(DeployLogMessageType.Error, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1317790512 ^ -1318030546)), true));
              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            default:
              goto label_319;
          }
        }
label_322:
        return;
label_319:;
      }
      catch (Exception ex)
      {
        int num43 = 2;
        while (true)
        {
          switch (num43)
          {
            case 1:
              goto label_315;
            case 2:
              ConfigurationImportExecutor.mpPoVWE1OsoeCdWeb6OT((object) ConfigurationImportExecutor.ImportLog, (object) string.Format((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(2008901894 << 3 ^ -1108395986), ConfigurationImportExecutor.Ye6XkoE12l2wWmACTc0I((object) ex)), (object) ex);
              num43 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
              continue;
            default:
              this.AddMessage(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1573986408), (object) ex.Message), true));
              num43 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
              continue;
          }
        }
label_315:;
      }
      finally
      {
        ConfigurationImportExecutor.CI84eLE1w15ESyMY8UaR((object) this.runWithSoftDeletableService, flag);
        int num44 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
          num44 = 0;
        switch (num44)
        {
          default:
        }
      }
    }

    /// <summary>Проверка файла импорта</summary>
    /// <param name="key">Ключ активации</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Возвращает список предупреждений</returns>
    private void RunTest(string key, CancellationToken cancellationToken)
    {
      int num1 = 41;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass68_0 cDisplayClass680;
        string serverFolderName;
        while (true)
        {
          string str1;
          BPMAppManifest bpmAppManifest;
          ImportLicenseInfo info;
          // ISSUE: variable of a compiler-generated type
          ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass68_2 cDisplayClass682;
          List<PackageInfo> list1;
          // ISSUE: variable of a compiler-generated type
          ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass68_1 cDisplayClass681;
          string configFile;
          AppDomain domain;
          ImportLicenseInfo importLicenseInfo;
          IEnumerable<string> activationKeys1;
          Func<DateTime?> getMainUnitExpiration;
          ComponentManager current1;
          XmlReader xmlReader1;
          string fileName;
          StoreComponentUnpackStatus componentUnpackStatus;
          IBPMApp bpmApp;
          ElmaStoreComponentManifest componentManifest;
          PackagesBAChapter packagesBaChapter;
          XmlReader xmlReader2;
          IMetadata[] metadataList;
          IMetadata[] metadataArray;
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              configFile = (string) ConfigurationImportExecutor.LDpLgeE1J1pKeCQ2WwM1((object) this.exportImportFileManager, ConfigurationImportExecutor.O2oXytE162AAMiZL2QmT((object) cDisplayClass680.configImportSettings), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-680446928 - -370807692 ^ -309665788), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654027611));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 29 : 27;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              if (!this.CheckHash(configFile, (string) ConfigurationImportExecutor.LDpLgeE1J1pKeCQ2WwM1((object) this.exportImportFileManager, ConfigurationImportExecutor.O2oXytE162AAMiZL2QmT((object) cDisplayClass680.configImportSettings), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309665788), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-2138958856 ^ -2138682308))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 9 : 52;
                continue;
              }
              goto case 55;
            case 3:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass680.configImportSettings.FileName != null)
              {
                num2 = 23;
                continue;
              }
              goto label_457;
            case 4:
              goto label_108;
            case 5:
              if (domain == null)
                break;
              goto label_65;
            case 6:
              goto label_481;
            case 7:
              if (ConfigurationImportExecutor.u1lVu1E1rkXXYmfryECy((object) key))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 111 : 35;
                continue;
              }
              goto case 56;
            case 8:
              getMainUnitExpiration = (Func<DateTime?>) null;
              num2 = 113;
              continue;
            case 9:
              ConfigurationImportExecutor.InitImportLicenseInfo(info);
              num2 = 16;
              continue;
            case 10:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass682.packagingComponent == null)
              {
                num2 = 6;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              IEnumerable<PackageManifest> source1 = this.manifest.Packages.Where<PackageManifest>(new Func<PackageManifest, bool>(cDisplayClass682.\u003CRunTest\u003Eb__9));
              // ISSUE: reference to a compiler-generated field
              Func<PackageManifest, PackageInfo> func1 = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_10;
              Func<PackageManifest, PackageInfo> selector1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_10 = selector1 = (Func<PackageManifest, PackageInfo>) (p => new PackageInfo((string) ConfigurationImportExecutor.\u003C\u003Ec.sl6Svs8nUD5bCfWyrVGX((object) p), (SemanticVersion) ConfigurationImportExecutor.\u003C\u003Ec.bo5wLP8nslCursAtGuO7((object) p)));
              }
              else
                goto label_350;
label_485:
              list1 = source1.Select<PackageManifest, PackageInfo>(selector1).ToList<PackageInfo>();
              num2 = 37;
              continue;
label_350:
              selector1 = func1;
              goto label_485;
            case 11:
            case 110:
              if (bpmAppManifest == null)
              {
                num2 = 65;
                continue;
              }
              goto case 107;
            case 12:
              // ISSUE: reference to a compiler-generated field
              componentUnpackStatus = this.UnpackIfSigned(key, new Func<DateTime?>(((IModuleManager) ConfigurationImportExecutor.wCVyoYENSJwxquCkdonA(ConfigurationImportExecutor.amDNUqENT4CF9WJPsTDh())).GetMainLicensedUnitExpiration), str1, cDisplayClass680.serverFolderName, out IEnumerable<StoreComponentVerifiedSignature> _);
              num2 = 34;
              continue;
            case 14:
              activationKeys1 = (IEnumerable<string>) null;
              num2 = 8;
              continue;
            case 15:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass680.configImportSettings.Manifest != null)
              {
                num2 = 106;
                continue;
              }
              goto case 18;
            case 16:
              if (this.manifest != null)
              {
                num2 = 75;
                continue;
              }
              goto case 35;
            case 17:
              this.testStep = 2;
              num2 = 104;
              continue;
            case 18:
            case 61:
            case 65:
            case 67:
            case 90:
              ElmaStoreComponentManifest manifest = this.manifest;
              if (manifest != null)
              {
                IEnumerable<EntityMetadata> first = manifest.Packages.SelectMany<PackageManifest, EntityManifest>((Func<PackageManifest, IEnumerable<EntityManifest>>) (p => (IEnumerable<EntityManifest>) p.Entities)).Concat<EntityManifest>((IEnumerable<EntityManifest>) this.manifest.Entities).Select<EntityManifest, EntityMetadata>((Func<EntityManifest, EntityMetadata>) (e =>
                {
                  EntityMetadata entityMetadata = new EntityMetadata();
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  ConfigurationImportExecutor.\u003C\u003Ec.Pc8ikw8nmKxtAYDlJtvj((object) entityMetadata, ConfigurationImportExecutor.\u003C\u003Ec.QOGqEy8n0x7G08Jor3MN((object) e));
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  ConfigurationImportExecutor.\u003C\u003Ec.eG3IL88nMe65lGvbNvyp((object) entityMetadata, ConfigurationImportExecutor.\u003C\u003Ec.WNLoOX8nySG4hFjPNasV((object) e));
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  ConfigurationImportExecutor.\u003C\u003Ec.dlZ3fF8n9xQ4oIgbHPyq((object) entityMetadata, ConfigurationImportExecutor.\u003C\u003Ec.UEQNiF8nJOH9UT8lL0iT((object) e));
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  ConfigurationImportExecutor.\u003C\u003Ec.knEHlW8nlWm2yb0WZbxG((object) entityMetadata, ConfigurationImportExecutor.\u003C\u003Ec.b60YKN8ndc9MC6kUGR5U((object) e));
                  // ISSUE: reference to a compiler-generated method
                  ConfigurationImportExecutor.\u003C\u003Ec.Tp2hT28nroEHEWoODHko((object) entityMetadata, (object) e.DisplayName);
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  ConfigurationImportExecutor.\u003C\u003Ec.GOQDYL8n5iPOGxRvBKo8((object) entityMetadata, (EntityMetadataType) ConfigurationImportExecutor.\u003C\u003Ec.hsaT1U8ngRR9Ri28T2eH((object) e));
                  return entityMetadata;
                }));
                IEnumerable<EnumManifest> source2 = this.manifest.Packages.SelectMany<PackageManifest, EnumManifest>((Func<PackageManifest, IEnumerable<EnumManifest>>) (p => (IEnumerable<EnumManifest>) p.Enums));
                // ISSUE: reference to a compiler-generated field
                Func<EnumManifest, EnumMetadata> func2 = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_4;
                Func<EnumManifest, EnumMetadata> selector2;
                if (func2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_4 = selector2 = (Func<EnumManifest, EnumMetadata>) (e =>
                  {
                    EnumMetadata enumMetadata = new EnumMetadata();
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ConfigurationImportExecutor.\u003C\u003Ec.Pc8ikw8nmKxtAYDlJtvj((object) enumMetadata, ConfigurationImportExecutor.\u003C\u003Ec.KuAC7N8njKububY8ARxP((object) e));
                    // ISSUE: reference to a compiler-generated method
                    enumMetadata.Namespace = (string) ConfigurationImportExecutor.\u003C\u003Ec.UBTTxC8nYeT7fR9QqDHu((object) e);
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ConfigurationImportExecutor.\u003C\u003Ec.knEHlW8nlWm2yb0WZbxG((object) enumMetadata, ConfigurationImportExecutor.\u003C\u003Ec.AnK8JO8nLb5cHv4GP9Ye((object) e));
                    // ISSUE: reference to a compiler-generated method
                    ConfigurationImportExecutor.\u003C\u003Ec.Tp2hT28nroEHEWoODHko((object) enumMetadata, (object) e.DisplayName);
                    return enumMetadata;
                  });
                }
                else
                  goto label_308;
label_474:
                IEnumerable<EnumMetadata> second = source2.Select<EnumManifest, EnumMetadata>(selector2);
                metadataArray = ((IEnumerable<IMetadata>) first).Concat<IMetadata>((IEnumerable<IMetadata>) second).ToArray<IMetadata>();
                goto label_475;
label_308:
                selector2 = func2;
                goto label_474;
              }
              else
                goto label_469;
            case 19:
            case 93:
            case 111:
              if (this.manifest == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 74 : 64;
                continue;
              }
              goto case 28;
            case 20:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass680.configImportSettings != null)
              {
                num2 = 119;
                continue;
              }
              goto case 27;
            case 21:
            case 74:
label_490:
              // ISSUE: reference to a compiler-generated field
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1142330761 ^ 1541959139 ^ 536513972), this.manifest == null ? ConfigurationImportExecutor.O2oXytE162AAMiZL2QmT((object) cDisplayClass680.configImportSettings) : (object) this.manifest.Title)));
              num2 = 97;
              continue;
            case 22:
              metadataArray = Array.Empty<IMetadata>();
              goto label_478;
            case 23:
              goto label_51;
            case 24:
            case 36:
label_118:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass680.postCompleteMessages = new List<TestImportMessages>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 68 : 7;
              continue;
            case 25:
              if (this.CheckImportFiles(fileName, serverFolderName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                continue;
              }
              goto case 95;
            case 26:
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(~-306453669 ^ 306212362))));
              num2 = 53;
              continue;
            case 27:
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088046400))));
              num2 = 81;
              continue;
            case 28:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass682 = new ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass68_2();
              num2 = 60;
              continue;
            case 29:
              // ISSUE: reference to a compiler-generated field
              fileName = this.exportImportFileManager.CreateFileName((string) ConfigurationImportExecutor.O2oXytE162AAMiZL2QmT((object) cDisplayClass680.configImportSettings), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312583475), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138430854));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 2;
              continue;
            case 30:
              if (this.serviceData == null)
              {
                num2 = 89;
                continue;
              }
              goto case 42;
            case 31:
              List<BPMAppManifestChapter> chapters = bpmAppManifest.Chapters;
              // ISSUE: reference to a compiler-generated field
              Func<BPMAppManifestChapter, bool> func3 = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_7;
              Func<BPMAppManifestChapter, bool> predicate;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_7 = predicate = (Func<BPMAppManifestChapter, bool>) (c => ConfigurationImportExecutor.\u003C\u003Ec.fDX8iv8nxqLWdLt7oMUH((object) c.Uid, (object) PackageExportConsts.ExportExtensionUid));
              }
              else
                goto label_187;
label_466:
              packagesBaChapter = chapters.FirstOrDefault<BPMAppManifestChapter>(predicate) as PackagesBAChapter;
              num2 = 44;
              continue;
label_187:
              predicate = func3;
              goto label_466;
            case 32:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass682.packagingComponent = this.packageService.GetComponent();
              num2 = 10;
              continue;
            case 33:
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1217523399 ^ -1217760731))));
              num2 = 12;
              continue;
            case 34:
              if (componentUnpackStatus == StoreComponentUnpackStatus.ActivationError)
              {
                num2 = 69;
                continue;
              }
              if (componentUnpackStatus == StoreComponentUnpackStatus.Success)
              {
                num2 = 96;
                continue;
              }
              goto case 100;
            case 35:
              TestImportMessages message1 = new TestImportMessages(TestImportMessagesType.UserAction, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1204263869 ^ -1341583247 ^ 137693092)));
              ConfigurationImportExecutor.q5iAW0ENPtJmnbMGvfd7((object) message1, LicenseImportTestUserAction.UID);
              ConfigurationImportExecutor.IFB9vrEN1cmMT8UtGtog((object) message1, (object) info);
              this.TestMessagesAdd(message1);
              num2 = 38;
              continue;
            case 37:
              if (!(this.importSettings is TestModuleImportSettings))
              {
                num2 = 84;
                continue;
              }
              goto label_435;
            case 38:
              goto label_439;
            case 39:
              // ISSUE: reference to a compiler-generated method
              componentManifest = this.moduleManager.GetInstalledComponentManifests().FirstOrDefault<ElmaStoreComponentManifest>(new Func<ElmaStoreComponentManifest, bool>(cDisplayClass680.\u003CRunTest\u003Eb__6));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 76 : 5;
              continue;
            case 40:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass680.\u003C\u003E4__this = this;
              num2 = 99;
              continue;
            case 41:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass680 = new ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass68_0();
              num2 = 40;
              continue;
            case 42:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass680.serverFolderName = (string) ConfigurationImportExecutor.N88uShENuPBCoL2TD8ZG((object) this.exportImportFileManager, ConfigurationImportExecutor.O2oXytE162AAMiZL2QmT((object) cDisplayClass680.configImportSettings));
              num2 = 3;
              continue;
            case 43:
            case 49:
              if (this.manifest == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 61 : 22;
                continue;
              }
              goto case 85;
            case 44:
              if (packagesBaChapter != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 61 : 101;
                continue;
              }
              goto case 18;
            case 45:
              TestImportMessages message2 = new TestImportMessages(TestImportMessagesType.UserAction, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-477139494 ^ -477422004)));
              ConfigurationImportExecutor.q5iAW0ENPtJmnbMGvfd7((object) message2, LicenseImportTestUserAction.UID);
              ConfigurationImportExecutor.IFB9vrEN1cmMT8UtGtog((object) message2, (object) importLicenseInfo);
              this.TestMessagesAdd(message2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 38 : 79;
              continue;
            case 46:
label_112:
              cancellationToken.ThrowIfCancellationRequested();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 4 : 17;
              continue;
            case 47:
              try
              {
                bpmAppManifest = ClassSerializationHelper.DeserializeObjectByXml<BPMAppManifest>((string) ConfigurationImportExecutor.U5UHMaE1S4JqtTam5itl((object) this.manifest));
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_62;
                }
              }
              catch (Exception ex)
              {
                int num4 = 2;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_483;
                    case 2:
                      ConfigurationImportExecutor.ImportLog.Error(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1317790512 ^ -1318031674), ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                      continue;
                    default:
                      this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654031161))));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
                      continue;
                  }
                }
label_483:
                return;
              }
            case 48:
              if (this.manifest != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 48 : 51;
                continue;
              }
              goto label_480;
            case 50:
              goto label_415;
            case 51:
              if (ConfigurationImportExecutor.CFAxwhE10s00iyrA5l0u((object) this.manifest) == ElmaStoreComponentActivationType.Paid)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 62 : 5;
                continue;
              }
              goto label_480;
            case 52:
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoLose, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(2045296739 + 1688595713 ^ -561325256))));
              num2 = 55;
              continue;
            case 53:
              goto label_85;
            case 54:
              if (componentUnpackStatus == StoreComponentUnpackStatus.WrongSignatures)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 80 : 37;
                continue;
              }
              ConfigurationImportExecutor.xQ7nFOENWZ1yyIBkqRi4(ConfigurationImportExecutor.MlNMGBE1y8ECm86WgVkD(), ConfigurationImportExecutor.CJiYGKE1M9HgOO5j0vIa(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1426456882 ^ 2009939514 ^ -584014782), (object) componentUnpackStatus));
              num2 = 71;
              continue;
            case 55:
              // ISSUE: reference to a compiler-generated field
              if (!this.XmlDataExists((IImportSettings) cDisplayClass680.configImportSettings))
              {
                num2 = 24;
                continue;
              }
              goto case 25;
            case 56:
              ConfigurationImportExecutor.ob5fH5ENNFxkORnDxB5L((object) ((ComponentManager) ConfigurationImportExecutor.amDNUqENT4CF9WJPsTDh()).LicenseManager, (object) key);
              num2 = 19;
              continue;
            case 57:
              goto label_271;
            case 58:
              metadataArray = (IMetadata[]) null;
              goto label_475;
            case 59:
              try
              {
                ConfigurationImportExecutor.Kdm5EqENAXdSMui2cTaL((object) xmlReader2, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1350312861 << 3 ^ 2082113730));
                int num5 = 7;
                List<IReadMetadataResult> readMetadataResultList1;
                MetadataServiceContext metadataServiceContext1;
                while (true)
                {
                  MetadataServiceContext metadataServiceContext2;
                  MetadataServiceContext metadataServiceContext3;
                  switch (num5)
                  {
                    case 1:
                      goto label_184;
                    case 2:
                      metadataServiceContext3 = (MetadataServiceContext) null;
                      goto label_183;
                    case 3:
                      if (ConfigurationImportExecutor.r9oW4AEN7HSk5JJgMoq0((object) readMetadataResultList1) > 0)
                      {
                        num5 = 9;
                        continue;
                      }
                      goto case 2;
                    case 4:
                      ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader2);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 5 : 2;
                      continue;
                    case 5:
                      int num6 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader2);
                      num5 = 10;
                      continue;
                    case 6:
label_177:
                      cancellationToken.ThrowIfCancellationRequested();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 3;
                      continue;
                    case 7:
                      readMetadataResultList1 = new List<IReadMetadataResult>();
                      num5 = 11;
                      continue;
                    case 8:
                      try
                      {
label_139:
                        if (xmlReader2.NodeType != XmlNodeType.EndElement)
                          goto label_147;
                        else
                          goto label_140;
label_134:
                        int num7;
                        while (true)
                        {
                          switch (num7)
                          {
                            case 1:
                              if (!ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader2), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -584008946)))
                              {
                                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 16 : 6;
                                continue;
                              }
                              goto case 32;
                            case 2:
                              goto label_177;
                            case 3:
                            case 24:
                              int num8 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader2);
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 18 : 29;
                              continue;
                            case 4:
                              xmlReader2.Read();
                              num7 = 10;
                              continue;
                            case 5:
                            case 18:
                            case 23:
                              xmlReader2.Skip();
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 20 : 19;
                              continue;
                            case 6:
                            case 11:
                            case 20:
                              int num9 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader2);
                              num7 = 12;
                              continue;
                            case 7:
                              ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader2);
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
                              continue;
                            case 8:
                              ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader2);
                              num7 = 19;
                              continue;
                            case 9:
                            case 22:
                            case 33:
                              goto label_141;
                            case 10:
                              int num10 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader2);
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 7 : 26;
                              continue;
                            case 12:
                            case 28:
                              if (ConfigurationImportExecutor.u8mPV3ENBOqyjN9FPD2H((object) xmlReader2) == XmlNodeType.EndElement)
                              {
                                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 34 : 19;
                                continue;
                              }
                              goto case 31;
                            case 13:
                              // ISSUE: reference to a compiler-generated field
                              readMetadataResultList1.AddRange(this.ReadMetadataBlock(xmlReader2, false, cDisplayClass680.serverFolderName, true));
                              num7 = 11;
                              continue;
                            case 14:
                              goto label_147;
                            case 15:
                            case 16:
                            case 30:
                              if (ConfigurationImportExecutor.aHWlqJE1LYQIoxkGNkvB((object) xmlReader2))
                              {
                                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 21 : 20;
                                continue;
                              }
                              goto case 5;
                            case 17:
                              goto label_136;
                            case 19:
                              int num11 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader2);
                              num7 = 13;
                              continue;
                            case 21:
                              if (!ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader2), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1253244298 - 1829393894 ^ -575874126)))
                              {
                                num7 = 18;
                                continue;
                              }
                              goto case 27;
                            case 25:
                              goto label_144;
                            case 26:
                              // ISSUE: reference to a compiler-generated field
                              this.ReadMetadataBlock(xmlReader2, true, cDisplayClass680.serverFolderName, true);
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 4 : 6;
                              continue;
                            case 27:
                              if (ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) xmlReader2))
                              {
                                num7 = 5;
                                continue;
                              }
                              goto case 4;
                            case 29:
                              goto label_139;
                            case 31:
                              if (!ConfigurationImportExecutor.aHWlqJE1LYQIoxkGNkvB((object) xmlReader2))
                              {
                                num7 = 15;
                                continue;
                              }
                              goto case 1;
                            case 32:
                              if (!xmlReader2.IsEmptyElement)
                              {
                                num7 = 8;
                                continue;
                              }
                              goto case 15;
                            case 34:
                              xmlReader2.Read();
                              num7 = 3;
                              continue;
                            default:
                              int num12 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader2);
                              num7 = 28;
                              continue;
                          }
                        }
label_136:
                        if (!ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader2), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1581325282 << 3 ^ -234061444)))
                        {
                          num7 = 22;
                          goto label_134;
                        }
                        else
                          goto label_144;
label_140:
                        num7 = 2;
                        goto label_134;
label_141:
                        xmlReader2.Skip();
                        num7 = 24;
                        goto label_134;
label_144:
                        if (!ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) xmlReader2))
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 7 : 2;
                          goto label_134;
                        }
                        else
                          goto label_141;
label_147:
                        if (!ConfigurationImportExecutor.aHWlqJE1LYQIoxkGNkvB((object) xmlReader2))
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 9 : 6;
                          goto label_134;
                        }
                        else
                          goto label_136;
                      }
                      finally
                      {
                        int num13;
                        if (metadataServiceContext1 == null)
                          num13 = 2;
                        else
                          goto label_173;
label_172:
                        switch (num13)
                        {
                          case 1:
                          case 2:
                        }
label_173:
                        metadataServiceContext1.Dispose();
                        num13 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                        {
                          num13 = 1;
                          goto label_172;
                        }
                        else
                          goto label_172;
                      }
                    case 9:
                      List<IReadMetadataResult> source3 = readMetadataResultList1;
                      // ISSUE: reference to a compiler-generated field
                      Func<IReadMetadataResult, IMetadata> func4 = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_15;
                      Func<IReadMetadataResult, IMetadata> selector3;
                      if (func4 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_15 = selector3 = (Func<IReadMetadataResult, IMetadata>) (r => (IMetadata) ConfigurationImportExecutor.\u003C\u003Ec.U03Dh68OFFXjpnOgwTHw((object) r));
                      }
                      else
                        goto label_493;
label_182:
                      metadataServiceContext3 = MetadataServiceContext.Extend(source3.Select<IReadMetadataResult, IMetadata>(selector3));
                      goto label_183;
label_493:
                      selector3 = func4;
                      goto label_182;
                    case 10:
                      if (metadataList.Length == 0)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                        continue;
                      }
                      metadataServiceContext2 = MetadataServiceContext.Extend((IEnumerable<IMetadata>) metadataList);
                      break;
                    case 11:
                      if (!ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) xmlReader2))
                      {
                        num5 = 4;
                        continue;
                      }
                      goto case 6;
                    default:
                      metadataServiceContext2 = (MetadataServiceContext) null;
                      break;
                  }
                  metadataServiceContext1 = metadataServiceContext2;
                  num5 = 8;
                  continue;
label_183:
                  metadataServiceContext1 = metadataServiceContext3;
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
                }
label_184:
                try
                {
                  int num14;
                  if (ConfigurationImportExecutor.r9oW4AEN7HSk5JJgMoq0((object) readMetadataResultList1) <= 0)
                    num14 = 13;
                  else
                    goto label_247;
label_186:
                  XNodeWrapper xnodeWrapper;
                  string contentType;
                  while (true)
                  {
                    switch (num14)
                    {
                      case 1:
                        if (!ConfigurationImportExecutor.xZ06MUENQJVAH6dS5LZK(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader2), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1581325282 << 3 ^ -234048690)))
                        {
                          num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 12 : 7;
                          continue;
                        }
                        goto case 33;
                      case 2:
                        int num15 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader2);
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 23 : 8;
                        continue;
                      case 3:
                        xnodeWrapper = new XNodeWrapper(xmlReader2);
                        num14 = 36;
                        continue;
                      case 4:
                      case 13:
                        ConfigurationImportExecutor.Kdm5EqENAXdSMui2cTaL((object) xmlReader2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654272465));
                        num14 = 19;
                        continue;
                      case 5:
                      case 37:
                        if (ConfigurationImportExecutor.u8mPV3ENBOqyjN9FPD2H((object) xmlReader2) == XmlNodeType.EndElement)
                        {
                          num14 = 20;
                          continue;
                        }
                        goto case 22;
                      case 6:
                      case 32:
                      case 34:
                        int num16 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader2);
                        num14 = 37;
                        continue;
                      case 7:
                        if (!ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) xmlReader2))
                        {
                          num14 = 3;
                          continue;
                        }
                        goto case 8;
                      case 8:
                      case 35:
                        xmlReader2.Skip();
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 2 : 9;
                        continue;
                      case 9:
label_233:
                        ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader2);
                        num14 = 24;
                        continue;
                      case 10:
                        ConfigurationImportExecutor.qPNZx7ENFAG8vQyPD8WG((object) xmlReader2);
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 6 : 5;
                        continue;
                      case 11:
                      case 12:
                      case 25:
                      case 29:
                        ConfigurationImportExecutor.qPNZx7ENFAG8vQyPD8WG((object) xmlReader2);
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 15 : 34;
                        continue;
                      case 14:
                        if (!ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader2), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -542012027)))
                        {
                          num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 35 : 8;
                          continue;
                        }
                        goto case 7;
                      case 15:
                        if (ConfigurationImportExecutor.aHWlqJE1LYQIoxkGNkvB((object) xmlReader2))
                        {
                          num14 = 14;
                          continue;
                        }
                        goto case 8;
                      case 16:
                      case 18:
                        ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader2);
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 2;
                        continue;
                      case 17:
                        int num17 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader2);
                        num14 = 5;
                        continue;
                      case 19:
                        xmlReader2.Read();
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 17;
                        continue;
                      case 20:
                        goto label_118;
                      case 21:
                        if (!((string) ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader2) == (string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1317790512 ^ -1318042948)))
                        {
                          num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
                          continue;
                        }
                        goto case 33;
                      case 22:
                        if (!ConfigurationImportExecutor.aHWlqJE1LYQIoxkGNkvB((object) xmlReader2))
                        {
                          num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 23 : 29;
                          continue;
                        }
                        goto case 21;
                      case 23:
                      case 24:
                        if (xmlReader2.NodeType == XmlNodeType.EndElement)
                        {
                          num14 = 27;
                          continue;
                        }
                        goto case 15;
                      case 26:
                        goto label_247;
                      case 27:
                        xmlReader2.Read();
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 32 : 22;
                        continue;
                      case 28:
                        if (this.packetVersionService.Check((string) ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader2), contentType))
                        {
                          num14 = 16;
                          continue;
                        }
                        goto case 30;
                      case 30:
                        object t = ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(993438473 ^ 993187359);
                        object[] objArray = new object[2]
                        {
                          ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader2),
                          null
                        };
                        string str2 = contentType;
                        objArray[1] = (object) (str2 == null ? "" : str2);
                        this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoLose, EleWise.ELMA.SR.T((string) t, objArray)));
                        num14 = 10;
                        continue;
                      case 31:
                        contentType = (string) ConfigurationImportExecutor.bvLSv2ENhtbgyyFsrZvn((object) xmlReader2, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(381945751 ^ 1158627804 ^ 1405685303));
                        num14 = 28;
                        continue;
                      case 33:
                        if (xmlReader2.IsEmptyElement)
                        {
                          num14 = 25;
                          continue;
                        }
                        goto case 31;
                      case 36:
                        try
                        {
                          // ISSUE: object of a compiler-generated type is created
                          // ISSUE: variable of a compiler-generated type
                          ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass68_4 cDisplayClass684 = new ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass68_4();
                          int num18 = 3;
                          List<IEntityImportSaveActions> list2;
                          List<IEntityImportSaveActions>.Enumerator enumerator;
                          while (true)
                          {
                            switch (num18)
                            {
                              case 1:
                                // ISSUE: reference to a compiler-generated method
                                list2 = this.entityImportSaveActionExtensions.Where<IEntityImportSaveActions>(new Func<IEntityImportSaveActions, bool>(cDisplayClass684.\u003CRunTest\u003Eb__17)).ToList<IEntityImportSaveActions>();
                                num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 3 : 4;
                                continue;
                              case 2:
                                goto label_233;
                              case 3:
                                // ISSUE: reference to a compiler-generated field
                                cDisplayClass684.typeUid = ConfigurationImportExecutor.GcF7yXENxNLhroPmfDBc((object) xnodeWrapper);
                                num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
                                continue;
                              case 4:
                                if (ConfigurationImportExecutor.cjH4cTEN0fYhlHDoay6K((object) list2) > 0)
                                {
                                  num18 = 5;
                                  continue;
                                }
                                goto label_233;
                              case 5:
                                enumerator = list2.GetEnumerator();
                                num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_209;
                            }
                          }
label_209:
                          try
                          {
label_214:
                            if (enumerator.MoveNext())
                              goto label_212;
                            else
                              goto label_215;
label_211:
                            List<TestImportMessages> testImportMessagesList;
                            int num19;
                            while (true)
                            {
                              switch (num19)
                              {
                                case 1:
                                  goto label_233;
                                case 2:
                                  goto label_214;
                                case 3:
                                  goto label_212;
                                default:
                                  testImportMessagesList.Each<TestImportMessages>(new Action<TestImportMessages>(this.TestMessagesAdd));
                                  num19 = 2;
                                  continue;
                              }
                            }
label_212:
                            IEntityImportSaveActions current2 = enumerator.Current;
                            XmlReader reader = (XmlReader) ConfigurationImportExecutor.Sdl6aMENmVGGrvXFIkq6((object) xnodeWrapper);
                            testImportMessagesList = new List<TestImportMessages>();
                            // ISSUE: reference to a compiler-generated field
                            ImportTestReadData data = new ImportTestReadData(reader, this.mergeReplace, this.serviceData, cDisplayClass680.configImportSettings);
                            ImportTestReadResult result = new ImportTestReadResult(testImportMessagesList, this.testSystemMessages);
                            current2.TestRead(data, result);
                            num19 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
                            {
                              num19 = 0;
                              goto label_211;
                            }
                            else
                              goto label_211;
label_215:
                            num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
                            goto label_211;
                          }
                          finally
                          {
                            enumerator.Dispose();
                            int num20 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                              num20 = 0;
                            switch (num20)
                            {
                              default:
                            }
                          }
                        }
                        finally
                        {
                          int num21;
                          if (xnodeWrapper == null)
                            num21 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                          else
                            goto label_224;
label_223:
                          switch (num21)
                          {
                            case 1:
                            case 2:
                          }
label_224:
                          xnodeWrapper.Dispose();
                          num21 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
                          {
                            num21 = 2;
                            goto label_223;
                          }
                          else
                            goto label_223;
                        }
                      default:
                        this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoReboote, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(--1333735954 ^ 1333480996))));
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 4;
                        continue;
                    }
                  }
label_247:
                  List<IReadMetadataResult> readMetadataResultList2 = readMetadataResultList1;
                  // ISSUE: reference to a compiler-generated field
                  Action<IReadMetadataResult> action1 = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_16;
                  Action<IReadMetadataResult> action2;
                  if (action1 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_16 = action2 = (Action<IReadMetadataResult>) (r =>
                    {
                      int num22 = 1;
                      while (true)
                      {
                        switch (num22)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            ConfigurationImportExecutor.\u003C\u003Ec.lsI2W08OBWxuRaGyHYfV((object) r);
                            num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    });
                  }
                  else
                    goto label_492;
label_249:
                  readMetadataResultList2.ForEach(action2);
                  num14 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                  {
                    num14 = 0;
                    goto label_186;
                  }
                  else
                    goto label_186;
label_492:
                  action2 = action1;
                  goto label_249;
                }
                finally
                {
                  int num23;
                  if (metadataServiceContext1 == null)
                    num23 = 2;
                  else
                    goto label_255;
label_254:
                  switch (num23)
                  {
                    case 1:
                    case 2:
                  }
label_255:
                  ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) metadataServiceContext1);
                  num23 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
                  {
                    num23 = 1;
                    goto label_254;
                  }
                  else
                    goto label_254;
                }
              }
              finally
              {
                int num24;
                if (xmlReader2 == null)
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
                else
                  goto label_261;
label_260:
                switch (num24)
                {
                  case 2:
                    break;
                  default:
                }
label_261:
                xmlReader2.Dispose();
                num24 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
                {
                  num24 = 0;
                  goto label_260;
                }
                else
                  goto label_260;
              }
            case 60:
              ConfigurationImportExecutor.Djk57qE1lBxyJ81fVK0Z((object) this.packageService);
              num2 = 32;
              continue;
            case 62:
              goto label_479;
            case 63:
              goto label_434;
            case 64:
              try
              {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass68_3 cDisplayClass683 = new ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass68_3();
                int num25 = 62;
                HashSet<Guid>.Enumerator enumerator1;
                while (true)
                {
                  int num26;
                  bool flag1;
                  bool flag2;
                  HashSet<Guid> guidSet;
                  Guid result1;
                  string attribute;
                  string str3;
                  Dictionary<string, string>.Enumerator enumerator2;
                  switch (num25)
                  {
                    case 1:
                      attribute = xmlReader1.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867470873));
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 45 : 43;
                      continue;
                    case 2:
                      int num27 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader1);
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 51 : 19;
                      continue;
                    case 3:
                      if (!Guid.TryParse((string) ConfigurationImportExecutor.bvLSv2ENhtbgyyFsrZvn((object) xmlReader1, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1051276242 - 990076387 ^ 61183885)), out result1))
                      {
                        num25 = 36;
                        continue;
                      }
                      goto case 83;
                    case 4:
                      this.ReadServiceData(xmlReader1);
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 17 : 75;
                      continue;
                    case 5:
                    case 16:
                      if (xmlReader1.NodeType == XmlNodeType.EndElement)
                      {
                        num25 = 35;
                        continue;
                      }
                      goto case 48;
                    case 6:
                      if (!ConfigurationImportExecutor.xfWXwXENbk9MHTq6ErLw((object) attribute, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1487388570 ^ -1487135082)))
                      {
                        num26 = 21;
                        break;
                      }
                      goto case 15;
                    case 7:
                      flag2 |= !this.ReadImportants(xmlReader1);
                      num25 = 92;
                      continue;
                    case 8:
                      goto label_468;
                    case 9:
                    case 61:
                      int num28 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader1);
                      num26 = 23;
                      break;
                    case 10:
                      ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader1);
                      num25 = 2;
                      continue;
                    case 11:
                      if (!xmlReader1.ReadToNextSibling((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-281842504 ^ -281606302)))
                      {
                        num26 = 57;
                        break;
                      }
                      goto case 54;
                    case 12:
                    case 21:
                    case 41:
                    case 73:
                      ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader1);
                      num26 = 82;
                      break;
                    case 13:
                      this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1598106783 - -968262081 ^ -630116542))));
                      num25 = 25;
                      continue;
                    case 14:
                    case 56:
                    case 81:
                      ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader1);
                      num25 = 85;
                      continue;
                    case 15:
                      this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-2107978722 ^ -2107726600), (object) attribute, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082127336))));
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 41;
                      continue;
                    case 17:
                      xmlReader1.Read();
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 36 : 39;
                      continue;
                    case 18:
                      int num29 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader1);
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 11 : 32;
                      continue;
                    case 19:
                      goto label_460;
                    case 20:
                    case 71:
                    case 78:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass683.preStartMessages = new List<TestImportMessages>();
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 20 : 64;
                      continue;
                    case 22:
                      if (!xmlReader1.IsEmptyElement)
                      {
                        num25 = 28;
                        continue;
                      }
                      goto label_112;
                    case 23:
                    case 32:
                      if (ConfigurationImportExecutor.u8mPV3ENBOqyjN9FPD2H((object) xmlReader1) == XmlNodeType.EndElement)
                      {
                        num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 90 : 91;
                        continue;
                      }
                      goto case 47;
                    case 24:
                      ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader1);
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 24 : 37;
                      continue;
                    case 26:
                      if (ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow((object) str3, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1253244298 - 1829393894 ^ -575866664)))
                      {
                        num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 7 : 3;
                        continue;
                      }
                      goto case 67;
                    case 27:
                    case 31:
                      if (ConfigurationImportExecutor.u8mPV3ENBOqyjN9FPD2H((object) xmlReader1) == XmlNodeType.EndElement)
                      {
                        num25 = 30;
                        continue;
                      }
                      goto case 49;
                    case 28:
                      guidSet = new HashSet<Guid>();
                      num25 = 70;
                      continue;
                    case 29:
                    case 65:
                      ConfigurationImportExecutor.qPNZx7ENFAG8vQyPD8WG((object) xmlReader1);
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 61 : 44;
                      continue;
                    case 30:
                      xmlReader1.Read();
                      num26 = 9;
                      break;
                    case 33:
                    case 50:
                      goto label_112;
                    case 34:
                    case 36:
                    case 38:
                    case 55:
                      ConfigurationImportExecutor.qPNZx7ENFAG8vQyPD8WG((object) xmlReader1);
                      num25 = 88;
                      continue;
                    case 35:
                      if (!flag2)
                      {
                        num25 = 14;
                        continue;
                      }
                      goto label_464;
                    case 37:
                      int num30 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader1);
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 5;
                      continue;
                    case 39:
                      int content1 = (int) xmlReader1.MoveToContent();
                      num25 = 31;
                      continue;
                    case 40:
                      ISet<Guid> metadataNotIsUnique = this.metadataNotIsUnique;
                      IEnumerable<IIgnoreIsUniqueMetadata> isUniqueMetadata = this.ignoreIsUniqueMetadata;
                      // ISSUE: reference to a compiler-generated field
                      Func<IIgnoreIsUniqueMetadata, IEnumerable<Guid>> func5 = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_14;
                      Func<IIgnoreIsUniqueMetadata, IEnumerable<Guid>> selector4;
                      if (func5 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_14 = selector4 = (Func<IIgnoreIsUniqueMetadata, IEnumerable<Guid>>) (i => (IEnumerable<Guid>) i.GetIgnoredUids());
                      }
                      else
                        goto label_495;
label_407:
                      IEnumerable<Guid> other = isUniqueMetadata.SelectMany<IIgnoreIsUniqueMetadata, Guid>(selector4);
                      metadataNotIsUnique.ExceptWith(other);
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 80 : 63;
                      continue;
label_495:
                      selector4 = func5;
                      goto label_407;
                    case 42:
                      guidSet.Add(result1);
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 34 : 34;
                      continue;
                    case 43:
                      this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1445902765 ^ -1980277732 ^ 539124229))));
                      num25 = 19;
                      continue;
                    case 44:
                      if (ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) xmlReader1))
                      {
                        num25 = 55;
                        continue;
                      }
                      goto case 86;
                    case 45:
                      if (!(attribute != (string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1822890472 ^ -1822639874)))
                      {
                        num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 12 : 4;
                        continue;
                      }
                      goto case 6;
                    case 46:
                      if (ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader1), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1470998129 - 231418599 ^ 1239819750)))
                      {
                        num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 53 : 27;
                        continue;
                      }
                      goto case 29;
                    case 47:
                      if (!ConfigurationImportExecutor.aHWlqJE1LYQIoxkGNkvB((object) xmlReader1))
                      {
                        num25 = 29;
                        continue;
                      }
                      goto case 46;
                    case 48:
                      str3 = (string) ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader1);
                      num25 = 26;
                      continue;
                    case 49:
                      if (!xmlReader1.IsStartElement())
                      {
                        num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 36 : 38;
                        continue;
                      }
                      goto case 52;
                    case 51:
                      if (ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader1), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(~210725948 ^ -210437909)))
                      {
                        num25 = 66;
                        continue;
                      }
                      goto case 77;
                    case 52:
                      if (ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader1), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(~-122002947 ^ 121749518)))
                      {
                        num25 = 44;
                        continue;
                      }
                      goto case 34;
                    case 53:
                      if (!ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) xmlReader1))
                      {
                        num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 12 : 17;
                        continue;
                      }
                      goto case 29;
                    case 54:
                      // ISSUE: reference to a compiler-generated method
                      IEnumerable<EntityMetadata> source4 = ((IMetadataService) ConfigurationImportExecutor.rvE8WJEN4mZfQBu0yf1P()).GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (md => !ConfigurationImportExecutor.\u003C\u003Ec.EcUdVg8ncLSYjCNAtRoy((object) md)));
                      // ISSUE: reference to a compiler-generated field
                      Func<EntityMetadata, Guid> func6 = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_13;
                      Func<EntityMetadata, Guid> selector5;
                      if (func6 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_13 = selector5 = (Func<EntityMetadata, Guid>) (md => ConfigurationImportExecutor.\u003C\u003Ec.h1xSJq8nzriTrYakFL1T((object) md));
                      }
                      else
                        goto label_494;
label_404:
                      this.metadataNotIsUnique = (ISet<Guid>) source4.Select<EntityMetadata, Guid>(selector5).ToHashSet<Guid>();
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 32 : 40;
                      continue;
label_494:
                      selector5 = func6;
                      goto label_404;
                    case 57:
                      this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -542004527))));
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 14 : 69;
                      continue;
                    case 58:
label_298:
                      if (!flag1)
                      {
                        num25 = 78;
                        continue;
                      }
                      goto label_440;
                    case 59:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass683.preStartMessages.Each<TestImportMessages>(new Action<TestImportMessages>(this.TestMessagesAdd));
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 5 : 11;
                      continue;
                    case 60:
                      this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-2106517564 ^ -2106233218))));
                      num26 = 33;
                      break;
                    case 62:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass683.CS\u0024\u003C\u003E8__locals1 = cDisplayClass680;
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 89 : 44;
                      continue;
                    case 63:
                      this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-35995181 ^ -35735877))));
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 94 : 56;
                      continue;
                    case 64:
                      // ISSUE: reference to a compiler-generated method
                      this.configImportActionExtensions.Each<IConfigImportActionExtension>(new Action<IConfigImportActionExtension>(cDisplayClass683.\u003CRunTest\u003Eb__11));
                      num25 = 59;
                      continue;
                    case 66:
                      if (ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) xmlReader1))
                      {
                        num25 = 81;
                        continue;
                      }
                      goto case 72;
                    case 67:
                      xmlReader1.Skip();
                      num25 = 87;
                      continue;
                    case 68:
                      if (!ConfigurationImportExecutor.hKO1JNENoXjLkkOJaRkc((object) xmlReader1, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1461825605 - 1531863589 ^ -69786030)))
                      {
                        num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 45 : 73;
                        continue;
                      }
                      goto case 1;
                    case 69:
                      goto label_445;
                    case 70:
                      ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader1);
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 9 : 18;
                      continue;
                    case 72:
                      flag2 = false;
                      num25 = 24;
                      continue;
                    case 74:
                    case 79:
                      ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlReader1);
                      num25 = 22;
                      continue;
                    case 75:
                      flag1 = false;
                      num25 = 76;
                      continue;
                    case 76:
                      enumerator2 = this.serviceData.GetEnumerator();
                      num25 = 93;
                      continue;
                    case 77:
                      if (!ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlReader1), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1917998801 >> 2 ^ 479250974)))
                      {
                        num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 71 : 50;
                        continue;
                      }
                      goto case 4;
                    case 80:
                      if (ConfigurationImportExecutor.dTs50nENEjlYgpFBoeKx((object) xmlReader1, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1505778440 - 1981636111 ^ -475901839)))
                      {
                        num25 = 74;
                        continue;
                      }
                      goto case 60;
                    case 82:
                      if (!this.MoveToConfigurationData(xmlReader1))
                      {
                        num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 10 : 43;
                        continue;
                      }
                      goto case 10;
                    case 83:
                      if (!ConfigurationImportExecutor.G6IvObENHaDGXd3JNhNm(result1, ConfigurationImportExecutor.O2TnhEEN6x3KU9P2j2aS(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(964881585 - -1459193222 ^ -1871181789))))
                      {
                        num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 13;
                    case 84:
                      goto label_324;
                    case 85:
                      int content2 = (int) xmlReader1.MoveToContent();
                      num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 77 : 57;
                      continue;
                    case 86:
                      ConfigurationImportExecutor.hKO1JNENoXjLkkOJaRkc((object) xmlReader1, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1319452732 ^ 1319436894));
                      num25 = 3;
                      continue;
                    case 87:
                    case 92:
                      int num31 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlReader1);
                      num25 = 16;
                      continue;
                    case 88:
                      int content3 = (int) xmlReader1.MoveToContent();
                      num26 = 27;
                      break;
                    case 89:
                      if (!this.CheckImportFileVersion(xmlReader1))
                      {
                        num25 = 63;
                        continue;
                      }
                      goto case 68;
                    case 90:
                      goto label_425;
                    case 91:
                      enumerator1 = guidSet.GetEnumerator();
                      num25 = 84;
                      continue;
                    case 93:
                      try
                      {
label_368:
                        if (enumerator2.MoveNext())
                          goto label_363;
                        else
                          goto label_369;
label_360:
                        string[] strArray;
                        Guid result2;
                        KeyValuePair<string, string> current3;
                        int num32;
                        while (true)
                        {
                          switch (num32)
                          {
                            case 1:
                              goto label_363;
                            case 2:
                              flag1 = true;
                              num32 = 5;
                              continue;
                            case 3:
                              if (!Guid.TryParse(strArray[0], out result2))
                              {
                                num32 = 8;
                                continue;
                              }
                              goto case 4;
                            case 4:
                              if (((AbstractNHEntityManager<IGlobalScriptModuleHeader, long>) ConfigurationImportExecutor.vYexWXENwcwtw6XarFq3()).LoadOrNull(result2) == null)
                              {
                                num32 = 2;
                                continue;
                              }
                              goto label_368;
                            case 5:
                              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675749513), (object) strArray[1], (object) result2)));
                              num32 = 10;
                              continue;
                            case 6:
                              strArray = (string[]) ConfigurationImportExecutor.VWELw0ENtJ0y07IMwnop((object) current3.Value, (object) new string[1]
                              {
                                (string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1113862659 ^ 1113606845)
                              }, StringSplitOptions.None);
                              num32 = 3;
                              continue;
                            case 7:
                              goto label_298;
                            case 8:
                            case 9:
                            case 10:
                              goto label_368;
                            default:
                              if (!current3.Key.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883169132)))
                              {
                                num32 = 9;
                                continue;
                              }
                              goto case 6;
                          }
                        }
label_363:
                        current3 = enumerator2.Current;
                        num32 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                        {
                          num32 = 0;
                          goto label_360;
                        }
                        else
                          goto label_360;
label_369:
                        num32 = 7;
                        goto label_360;
                      }
                      finally
                      {
                        enumerator2.Dispose();
                        int num33 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                          num33 = 0;
                        switch (num33)
                        {
                          default:
                        }
                      }
                    case 94:
                      goto label_424;
                    default:
                      if (this.metadataNotIsUnique.Contains(result1))
                      {
                        num25 = 42;
                        continue;
                      }
                      goto case 34;
                  }
                  num25 = num26;
                }
label_468:
                return;
label_460:
                return;
label_445:
                return;
label_425:
                return;
label_424:
                return;
label_464:
                return;
label_440:
                return;
label_324:
                try
                {
label_329:
                  if (enumerator1.MoveNext())
                    goto label_326;
                  else
                    goto label_330;
label_325:
                  Guid current4;
                  int num34;
                  while (true)
                  {
                    switch (num34)
                    {
                      case 1:
                        goto label_112;
                      case 2:
                        goto label_329;
                      case 3:
                        this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(--1333735954 ^ 1333479774), (object) current4)));
                        num34 = 2;
                        continue;
                      default:
                        goto label_326;
                    }
                  }
label_326:
                  current4 = enumerator1.Current;
                  num34 = 3;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                  {
                    num34 = 3;
                    goto label_325;
                  }
                  else
                    goto label_325;
label_330:
                  num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
                  goto label_325;
                }
                finally
                {
                  enumerator1.Dispose();
                  int num35 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
                    num35 = 0;
                  switch (num35)
                  {
                    default:
                  }
                }
              }
              finally
              {
                int num36;
                if (xmlReader1 == null)
                  num36 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                else
                  goto label_411;
label_410:
                switch (num36)
                {
                  case 1:
                    break;
                  default:
                }
label_411:
                ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) xmlReader1);
                num36 = 2;
                goto label_410;
              }
            case 66:
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(322893104 - -1992822529 ^ -1979484761), (object) componentManifest.Version)));
              num2 = 83;
              continue;
            case 68:
              // ISSUE: reference to a compiler-generated method
              this.importExtensions.Each<IConfigImportExtension>(new Action<IConfigImportExtension>(cDisplayClass680.\u003CRunTest\u003Eb__5));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 7 : 78;
              continue;
            case 69:
              info = new ImportLicenseInfo();
              num2 = 9;
              continue;
            case 70:
              if (!ConfigurationImportExecutor.NWvLyhE1D9UIVRmgX9sH())
              {
                num2 = 30;
                continue;
              }
              goto case 114;
            case 71:
              goto label_81;
            case 72:
              // ISSUE: reference to a compiler-generated field
              this.zipService.ExtractZipFolder(str1, cDisplayClass680.serverFolderName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 45 : 93;
              continue;
            case 73:
              // ISSUE: reference to a compiler-generated field
              if (ConfigurationImportExecutor.uv1b8RENXhA4k0buxlZA((object) cDisplayClass680.configImportSettings) == null)
              {
                num2 = 67;
                continue;
              }
              goto case 31;
            case 75:
              List<ModuleDTO> modules = info.Modules;
              ModuleDTO moduleDto = new ModuleDTO();
              moduleDto.Id = (string) ConfigurationImportExecutor.aJKWvhENiAaPdhKQ1Tw8((object) this.manifest);
              ConfigurationImportExecutor.ihtwXOENktR85X0E4iHC((object) moduleDto, ConfigurationImportExecutor.IqRtZhE17pn25i9D9fqG((object) this.manifest));
              ConfigurationImportExecutor.uANHrPENnIE3IMkMuXml((object) moduleDto, ConfigurationImportExecutor.i9i9roE1xW3lOWfH6muS((object) this.manifest));
              moduleDto.Description = (string) ConfigurationImportExecutor.e59JbAENOXg0vVwqR4kb((object) this.manifest);
              ConfigurationImportExecutor.QMlTFpENeSh5rkwGxD0U((object) moduleDto, ConfigurationImportExecutor.bAL107EN2FfD6UDXUcIG((object) this.manifest));
              modules.Add(moduleDto);
              num2 = 35;
              continue;
            case 76:
              if (componentManifest != null)
              {
                num2 = 66;
                continue;
              }
              goto label_109;
            case 77:
              if (ConfigurationImportExecutor.cO4itPEND26uBMYY4Xs3((object) importLicenseInfo.Modules) > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 45;
                continue;
              }
              break;
            case 78:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass680.postCompleteMessages.Each<TestImportMessages>(new Action<TestImportMessages>(this.TestMessagesAdd));
              num2 = 63;
              continue;
            case 79:
              goto label_491;
            case 80:
              ConfigurationImportExecutor.xQ7nFOENWZ1yyIBkqRi4((object) EleWise.ELMA.Logging.Logger.Log, (object) (ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1350312861 << 3 ^ 2082113454).ToString() + (object) componentUnpackStatus));
              num2 = 57;
              continue;
            case 81:
              goto label_52;
            case 82:
              // ISSUE: reference to a compiler-generated method
              packagesBaChapter.Packages.ForEach(new Action<PackageBAItem>(cDisplayClass681.\u003CRunTest\u003Eb__8));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 18 : 17;
              continue;
            case 83:
              goto label_89;
            case 84:
              List<TestImportMessages> tagMessages;
              int num37 = this.CheckManifestTag(out tagMessages) ? 1 : 0;
              tagMessages?.ForEach(new Action<TestImportMessages>(this.TestMessagesAdd));
              if (num37 == 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 40 : 50;
                continue;
              }
              goto label_435;
            case 85:
              if (!(this.importSettings is TestModuleImportSettings))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 39 : 11;
                continue;
              }
              goto label_109;
            case 86:
            case 118:
              this.manifest = ElmaStoreComponentsBuilder.Read(str1, activationKeys1, getMainUnitExpiration, false, (string) null, false, out List<string> _, out Image _);
              num2 = 116;
              continue;
            case 87:
              bpmApp = (IBPMApp) ConfigurationImportExecutor.CYvTT4ENRegxpcoT0NOp((object) this.bpmAppManager, ConfigurationImportExecutor.aJKWvhENiAaPdhKQ1Tw8((object) this.manifest));
              num2 = 88;
              continue;
            case 88:
              if (bpmApp == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 66 : 110;
                continue;
              }
              goto case 117;
            case 89:
              this.serviceData = new Dictionary<string, string>();
              num2 = 42;
              continue;
            case 91:
              Dictionary<Guid, string> activationKeys2 = ((ILicenseManager) ConfigurationImportExecutor.pNvvJOENVWNs5ykXnIr8((object) current1)).GetActivationKeys();
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<Guid, string>, string> func7 = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_0;
              Func<KeyValuePair<Guid, string>, string> selector6;
              if (func7 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__68_0 = selector6 = (Func<KeyValuePair<Guid, string>, string>) (a => a.Value);
              }
              else
                goto label_496;
label_462:
              activationKeys1 = (IEnumerable<string>) activationKeys2.Select<KeyValuePair<Guid, string>, string>(selector6).ToList<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 109 : 74;
              continue;
label_496:
              selector6 = func7;
              goto label_462;
            case 92:
              if (componentUnpackStatus == StoreComponentUnpackStatus.FreeSigned)
              {
                num2 = 48;
                continue;
              }
              goto case 54;
            case 94:
              xmlReader1 = this.GetXmlReader(this.importSettings);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 27 : 64;
              continue;
            case 95:
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Warning, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-35995181 ^ -35735735))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 13 : 2;
              continue;
            case 96:
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-342626196 - 1290888215 ^ -1633226873))));
              num2 = 7;
              continue;
            case 97:
              // ISSUE: reference to a compiler-generated field
              importLicenseInfo = this.CheckOrActivateModules(cDisplayClass680.serverFolderName, key, out domain);
              num2 = 108;
              continue;
            case 98:
              this.AddMessage(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1505778440 - 1981636111 ^ -475619431), ConfigurationImportExecutor.IqRtZhE17pn25i9D9fqG((object) this.manifest), ConfigurationImportExecutor.i9i9roE1xW3lOWfH6muS((object) this.manifest)), false));
              num2 = 43;
              continue;
            case 99:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass680.configImportSettings = this.importSettings as IConfigImportSettings;
              num2 = 20;
              continue;
            case 100:
              if (componentUnpackStatus != StoreComponentUnpackStatus.Unsigned)
              {
                num2 = 92;
                continue;
              }
              goto case 48;
            case 101:
              if (!packagesBaChapter.Packages.Any<PackageBAItem>())
                goto case 18;
              else
                goto label_414;
            case 102:
              if (!ConfigurationImportExecutor.u1lVu1E1rkXXYmfryECy(ConfigurationImportExecutor.U5UHMaE1S4JqtTam5itl((object) this.manifest)))
              {
                num2 = 47;
                continue;
              }
              goto case 120;
            case 103:
              try
              {
                IFSTransaction fsTransaction = (IFSTransaction) ConfigurationImportExecutor.sQhYdaENpjrxWDDtmkLv((object) ((PackagingSettings) ConfigurationImportExecutor.w3Hq0YEN31mFVeXGtS6c((object) this.packageService)).Root);
                int num38 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
                  num38 = 0;
                switch (num38)
                {
                  case 1:
                    goto label_490;
                  default:
                    try
                    {
                      this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-87337865 ^ -87087209))));
                      int num39 = 4;
                      string unpackedPackagesFolder;
                      while (true)
                      {
                        switch (num39)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated field
                            if (cDisplayClass682.packagingComponent.PrepareInstallPackages((IEnumerable<PackageInfo>) list1, false) != null)
                            {
                              num39 = 2;
                              continue;
                            }
                            goto label_490;
                          case 2:
                            TestImportMessages message3 = new TestImportMessages(TestImportMessagesType.InfoReboote, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(964881585 - -1459193222 ^ -1871182179)));
                            ConfigurationImportExecutor.R23cfsENaQGrCoLhCNwv((object) message3, true);
                            this.TestMessagesAdd(message3);
                            num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                            continue;
                          case 3:
                            this.packageService.SaveStoreComponentFileToConfiguration(this.manifest, str1, unpackedPackagesFolder);
                            num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
                            continue;
                          case 4:
                            // ISSUE: reference to a compiler-generated field
                            unpackedPackagesFolder = (string) ConfigurationImportExecutor.Qv8oHUE1ge6GYP1mkdeN((object) cDisplayClass680.serverFolderName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841635950));
                            num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 3;
                            continue;
                          default:
                            goto label_490;
                        }
                      }
                    }
                    finally
                    {
                      if (fsTransaction != null)
                      {
                        int num40 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                          num40 = 0;
                        while (true)
                        {
                          switch (num40)
                          {
                            case 1:
                              goto label_34;
                            default:
                              ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) fsTransaction);
                              num40 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
                              continue;
                          }
                        }
                      }
label_34:;
                    }
                }
              }
              catch (Exception ex)
              {
                int num41 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
                  num41 = 1;
                while (true)
                {
                  switch (num41)
                  {
                    case 1:
                      this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-2092274397 << 4 ^ 883074908), (object) ex.Message)));
                      num41 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_472;
                    default:
                      ConfigurationImportExecutor.mpPoVWE1OsoeCdWeb6OT((object) ConfigurationImportExecutor.ImportLog, (object) ex.Message, (object) ex);
                      num41 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 2;
                      continue;
                  }
                }
label_472:
                return;
              }
            case 104:
              xmlReader2 = this.GetXmlReader(this.importSettings);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 14 : 59;
              continue;
            case 105:
              current1 = ComponentManager.Current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 12 : 14;
              continue;
            case 106:
              // ISSUE: reference to a compiler-generated field
              if (((ElmaStoreComponentManifest) ConfigurationImportExecutor.CxSgSmENKwdloll3Eqod((object) cDisplayClass680.configImportSettings)).Packages.Any<PackageManifest>())
              {
                num2 = 73;
                continue;
              }
              goto case 18;
            case 107:
              if (!bpmAppManifest.Chapters.Any<BPMAppManifestChapter>())
              {
                num2 = 90;
                continue;
              }
              goto case 15;
            case 108:
              if (importLicenseInfo != null)
              {
                num2 = 5;
                continue;
              }
              break;
            case 109:
              getMainUnitExpiration = new Func<DateTime?>(((IModuleManager) ConfigurationImportExecutor.wCVyoYENSJwxquCkdonA((object) current1)).GetMainLicensedUnitExpiration);
              num2 = 118;
              continue;
            case 112:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass681.chapter = ((BPMAppFakeManifest) ConfigurationImportExecutor.uv1b8RENXhA4k0buxlZA((object) cDisplayClass680.configImportSettings)).GetOrCreateChapterByUid(PackageExportConsts.ExportExtensionUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 50 : 82;
              continue;
            case 113:
              if (current1 == null)
              {
                num2 = 86;
                continue;
              }
              goto case 91;
            case 114:
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1669371371 ^ 1669657691))));
              num2 = 4;
              continue;
            case 115:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass681 = new ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass68_1();
              num2 = 112;
              continue;
            case 116:
              if (this.manifest == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 49 : 32;
                continue;
              }
              goto case 98;
            case 117:
              if (!ConfigurationImportExecutor.rWCV4XENqkuvYHfu1rRG((object) bpmApp))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 16 : 26;
                continue;
              }
              goto case 11;
            case 119:
              this.metadataNotIsUnique = (ISet<Guid>) new HashSet<Guid>();
              num2 = 70;
              continue;
            case 120:
label_62:
              if (bpmAppManifest == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 7 : 11;
                continue;
              }
              goto case 87;
            case 121:
              // ISSUE: reference to a compiler-generated field
              str1 = (string) ConfigurationImportExecutor.Y12gHtE1HlUGeXH6LxZY((object) this.exportImportFileManager, ConfigurationImportExecutor.O2oXytE162AAMiZL2QmT((object) cDisplayClass680.configImportSettings));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 105 : 25;
              continue;
            default:
              this.testStep = 1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 94;
              continue;
          }
          this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710307610))));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 0;
          continue;
label_109:
          bpmAppManifest = (BPMAppManifest) null;
          num2 = 102;
          continue;
label_435:
          if (list1.Count > 0)
          {
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 62 : 103;
            continue;
          }
          goto label_490;
label_475:
          if (metadataArray == null)
          {
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 22 : 7;
            continue;
          }
label_478:
          metadataList = metadataArray;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 2 : 33;
          continue;
label_480:
          this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, componentUnpackStatus == StoreComponentUnpackStatus.Unsigned ? (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647642046)) : (string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1304605005 ^ 1304875679))));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 72 : 32;
        }
label_51:
        // ISSUE: reference to a compiler-generated field
        object obj = ConfigurationImportExecutor.Jax2EbENI7Y1CXYVG1TO((object) this.exportImportFileManager, ConfigurationImportExecutor.O2oXytE162AAMiZL2QmT((object) cDisplayClass680.configImportSettings));
        goto label_458;
label_65:
        num1 = 77;
        continue;
label_414:
        num1 = 115;
        continue;
label_457:
        obj = (object) "";
label_458:
        serverFolderName = (string) obj;
        num1 = 121;
        continue;
label_469:
        num1 = 58;
      }
label_108:
      return;
label_439:
      return;
label_415:
      return;
label_85:
      return;
label_434:
      return;
label_491:
      return;
label_52:
      return;
label_89:
      return;
label_81:
      throw new InvalidOperationException((string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1318028824)));
label_271:
      throw new InvalidOperationException((string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(322893104 - -1992822529 ^ -1979490099)));
label_479:
      throw new InvalidOperationException((string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-787452571 ^ -787216019)));
label_481:
      throw new InvalidOperationException((string) ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-882126494 ^ -881871626)));
    }

    /// <summary>Проверка хэша файла конфигурации</summary>
    private bool CheckHash(string configFile, string hashFile)
    {
      int num1 = 2;
      bool flag;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_45:
            ConfigurationImportExecutor.ImportLog.Info(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1574260816 ^ 1573989958));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
              int num2;
              if (!File.Exists(configFile))
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 8 : 2;
              else
                goto label_5;
label_4:
              FileStream inputStream;
              string str1;
              string str2;
              TextReader textReader;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    inputStream = File.OpenRead(configFile);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 11 : 11;
                    continue;
                  case 2:
                    goto label_44;
                  case 4:
label_27:
                    if (string.IsNullOrWhiteSpace(str2))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 1;
                  case 5:
                    try
                    {
                      str2 = (string) ConfigurationImportExecutor.Xywa7SENyRkpFZJniOQK((object) textReader);
                      int num3 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
                        num3 = 0;
                      switch (num3)
                      {
                        default:
                          goto label_27;
                      }
                    }
                    finally
                    {
                      int num4;
                      if (textReader == null)
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 2;
                      else
                        goto label_35;
label_34:
                      switch (num4)
                      {
                        case 1:
                          break;
                        default:
                      }
label_35:
                      ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) textReader);
                      num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
                      {
                        num4 = 0;
                        goto label_34;
                      }
                      else
                        goto label_34;
                    }
                  case 7:
                    goto label_5;
                  case 9:
label_25:
                    flag = ConfigurationImportExecutor.gDL7WbEN9nUHcnxq7pGd((object) str2, (object) str1);
                    num2 = 2;
                    continue;
                  case 10:
                    goto label_38;
                  case 11:
                    try
                    {
                      SHA1CryptoServiceProvider cryptoServiceProvider = new SHA1CryptoServiceProvider();
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
                        num5 = 1;
                      switch (num5)
                      {
                        case 1:
                          try
                          {
                            str1 = (string) ConfigurationImportExecutor.DwYPyeENJMBlG19Nl9wm(ConfigurationImportExecutor.jIhUSpENMwCI2UuJor2X((object) cryptoServiceProvider.ComputeHash((Stream) inputStream)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642857172), (object) string.Empty);
                            int num6 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                              num6 = 0;
                            switch (num6)
                            {
                              default:
                                goto label_25;
                            }
                          }
                          finally
                          {
                            int num7;
                            if (cryptoServiceProvider == null)
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                            else
                              goto label_16;
label_15:
                            switch (num7)
                            {
                              case 2:
                                break;
                              default:
                            }
label_16:
                            cryptoServiceProvider.Dispose();
                            num7 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                            {
                              num7 = 1;
                              goto label_15;
                            }
                            else
                              goto label_15;
                          }
                        default:
                          goto label_25;
                      }
                    }
                    finally
                    {
                      int num8;
                      if (inputStream == null)
                        num8 = 2;
                      else
                        goto label_22;
label_21:
                      switch (num8)
                      {
                        case 1:
                        case 2:
                      }
label_22:
                      ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) inputStream);
                      num8 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
                      {
                        num8 = 1;
                        goto label_21;
                      }
                      else
                        goto label_21;
                    }
                  default:
                    goto label_45;
                }
              }
label_5:
              if (!File.Exists(hashFile))
              {
                num2 = 6;
                goto label_4;
              }
label_38:
              textReader = (TextReader) new StreamReader(hashFile);
              num2 = 5;
              goto label_4;
            }
            catch (Exception ex)
            {
              int num9 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
                num9 = 0;
              while (true)
              {
                switch (num9)
                {
                  case 1:
                    goto label_45;
                  default:
                    ConfigurationImportExecutor.VEOkEdENdZIh7FNhP5g6((object) ConfigurationImportExecutor.ImportLog, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-218496594 ^ -218203046), (object) ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
                    continue;
                }
              }
            }
          default:
            goto label_43;
        }
      }
label_43:
      return true;
label_44:
      return flag;
    }

    private bool CheckManifestTag(out List<TestImportMessages> tagMessages)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            tagMessages = new List<TestImportMessages>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            if (this.manifest != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 0;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return this.tagService.ValidateTags(this.manifest, out tagMessages);
label_5:
      return true;
    }

    /// <summary>
    /// Получение дополнительных данных для объекта BpmApp из распакованного пакета
    /// </summary>
    /// <param name="serviceData">Словарь служебных данных из файла конфигурации</param>
    /// <param name="serverFolderName">Временная папка с распакованным пакетом на сервере</param>
    /// <param name="additionalFilesContent">Содержимое всей папки ComponentFiles (за исключением файла инструкции) в виде zip-архива</param>
    /// <param name="helpFileContent">Содержимое файла с инструкцией из папки ComponentFiles</param>
    private void AddAdditionalFilesInBpmApp(
      Dictionary<string, string> serviceData,
      string serverFolderName,
      string helpFileName,
      out byte[] additionalFilesContent,
      out byte[] helpFileContent)
    {
      additionalFilesContent = (byte[]) null;
      helpFileContent = (byte[]) null;
      string path1 = Path.Combine(serverFolderName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345164918));
      string str1;
      serviceData.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218682148), out str1);
      bool flag = str1 == z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333480590);
      string fileFilter = (string) null;
      if (helpFileName != null)
      {
        string path = Path.Combine(path1, helpFileName);
        if (File.Exists(path))
        {
          helpFileContent = File.ReadAllBytes(path);
          fileFilter = flag ? (string) null : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939374880) + helpFileName;
        }
      }
      if (path1 == null)
        return;
      string str2 = flag ? Path.Combine(path1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333678554)) : path1;
      if (!Directory.Exists(str2))
        return;
      additionalFilesContent = ZipHelper.CreateZipByteArrayFromFolder(str2, fileFilter);
    }

    private void AddMessage(DeployLogMessage message)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_11;
            case 1:
            case 4:
              EventHandler<EventArgs> onImportFinished = this.OnImportFinished;
              if (onImportFinished == null)
              {
                num2 = 2;
                continue;
              }
              onImportFinished((object) this, EventArgs.Empty);
              num2 = 7;
              continue;
            case 2:
            case 3:
            case 7:
              this.messages.Add(message);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            case 5:
              if (!ConfigurationImportExecutor.Lhmt1VENl6iH7SZeC8q6((object) message))
                goto case 6;
              else
                goto label_4;
            case 6:
              if (ConfigurationImportExecutor.LjGLl0ENrhWxVqQkuvB3((object) message))
                goto case 1;
              else
                goto label_7;
            default:
              goto label_8;
          }
        }
label_4:
        num1 = 4;
        continue;
label_7:
        num1 = 3;
      }
label_11:
      return;
label_8:;
    }

    private void ReadFilesSection(XmlReader reader)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str1;
          string input;
          Dictionary<string, string> dictionary;
          string str2;
          Guid result;
          long num3;
          int num4;
          switch (num2)
          {
            case 1:
label_13:
              if (input == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 11 : 27;
                continue;
              }
              goto case 11;
            case 2:
              object s = ConfigurationImportExecutor.bvLSv2ENhtbgyyFsrZvn((object) reader, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1669371371 ^ 1669658073));
              num3 = 0L;
              ref long local = ref num3;
              long.TryParse((string) s, out local);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 21 : 22;
              continue;
            case 3:
            case 15:
            case 27:
              reader.Skip();
              num2 = 16;
              continue;
            case 4:
              result = Guid.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 2;
              continue;
            case 5:
              goto label_41;
            case 6:
              if (ConfigurationImportExecutor.jgeG7iE1AJJVuAtTxp9u(ConfigurationImportExecutor.Qv8oHUE1ge6GYP1mkdeN((object) str1, (object) input)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 24 : 11;
                continue;
              }
              goto case 3;
            case 7:
              if (result != Guid.Empty)
                goto case 6;
              else
                goto label_21;
            case 8:
              if (!reader.IsEmptyElement)
              {
                num2 = 23;
                continue;
              }
              goto case 19;
            case 9:
              goto label_18;
            case 10:
              if (!(this.importSettings is ConfigImportSettings importSettings))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 2 : 9;
                continue;
              }
              goto case 26;
            case 11:
              if (Guid.TryParse(input, out result))
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            case 12:
              int content = (int) reader.MoveToContent();
              num2 = 29;
              continue;
            case 13:
              if (!dictionary.ContainsKey(reader.Name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 8 : 5;
                continue;
              }
              goto case 19;
            case 14:
              int num5 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) reader);
              num2 = 20;
              continue;
            case 16:
              goto label_30;
            case 17:
              ConfigurationImportExecutor.mfQ9rOENjCvUksk7HY2H((object) this.exportImportFileManager, (object) dictionary[(string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1886646897 ^ -1886618033)], ConfigurationImportExecutor.Qv8oHUE1ge6GYP1mkdeN((object) str1, (object) input), result);
              num2 = 28;
              continue;
            case 18:
              num4 = num3 == (long) this.step ? 1 : 0;
              break;
            case 19:
              ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) reader);
              num2 = 12;
              continue;
            case 20:
            case 29:
              if (ConfigurationImportExecutor.u8mPV3ENBOqyjN9FPD2H((object) reader) == XmlNodeType.EndElement)
              {
                num2 = 17;
                continue;
              }
              goto case 13;
            case 21:
              dictionary.Add((string) ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) reader), str2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 7 : 19;
              continue;
            case 22:
              if (num3 != 1L)
              {
                num2 = 25;
                continue;
              }
              goto case 18;
            case 23:
              str2 = (string) ConfigurationImportExecutor.WnElerEN52wUNLnne5ls((object) reader);
              num2 = 21;
              continue;
            case 24:
              dictionary = new Dictionary<string, string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            case 25:
              if (num3 == 2L)
              {
                num2 = 18;
                continue;
              }
              num4 = 1;
              break;
            case 26:
              input = (string) ConfigurationImportExecutor.bvLSv2ENhtbgyyFsrZvn((object) reader, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-53329496 >> 4 ^ -3323000));
              num2 = 4;
              continue;
            case 28:
              ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) reader);
              num2 = 5;
              continue;
            default:
              ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) reader);
              num2 = 14;
              continue;
          }
          str1 = Path.Combine(ConfigurationImportExecutor.YUlnlPENgwog33tJmm77((object) importSettings) != null ? (string) ConfigurationImportExecutor.Jax2EbENI7Y1CXYVG1TO((object) this.exportImportFileManager, ConfigurationImportExecutor.YUlnlPENgwog33tJmm77((object) importSettings)) : "", (string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(572119659 - -337058038 ^ 909217961));
          if (num4 == 0)
            num2 = 15;
          else
            goto label_13;
        }
label_21:
        num1 = 3;
      }
label_41:
      return;
label_18:
      return;
label_30:;
    }

    private bool XmlDataExists(IImportSettings settings)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_4;
          case 3:
            if (!(settings is ISystemImportSettings systemImportSettings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 4:
            if (!(settings is IConfigImportSettings configImportSettings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 2 : 3;
              continue;
            }
            goto label_4;
          default:
            goto label_2;
        }
      }
label_2:
      return !ConfigurationImportExecutor.YJcXStENYHAJ5JquIdba((object) systemImportSettings.FileText);
label_3:
      return false;
label_4:
      return ConfigurationImportExecutor.jgeG7iE1AJJVuAtTxp9u(ConfigurationImportExecutor.LDpLgeE1J1pKeCQ2WwM1((object) this.exportImportFileManager, (object) configImportSettings.FileName, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-87337865 ^ -87362609), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(647913418 ^ 647643080)));
    }

    /// <summary>Получение ридера xml-данных</summary>
    /// <returns></returns>
    private XmlReader GetXmlReader(IImportSettings settings)
    {
      int num = 5;
      string url;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            goto label_6;
          case 3:
            if (!ConfigurationImportExecutor.jgeG7iE1AJJVuAtTxp9u((object) url))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 1;
              continue;
            }
            goto label_7;
          case 4:
            if (settings is ISystemImportSettings systemImportSettings)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
              continue;
            }
            goto label_12;
          case 5:
            if (!(settings is IConfigImportSettings configImportSettings))
            {
              num = 4;
              continue;
            }
            break;
        }
        url = (string) ConfigurationImportExecutor.LDpLgeE1J1pKeCQ2WwM1((object) this.exportImportFileManager, ConfigurationImportExecutor.O2oXytE162AAMiZL2QmT((object) configImportSettings), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418332466), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-218496594 ^ -218209876));
        num = 3;
      }
label_6:
      return (XmlReader) new XmlTextReader((TextReader) new StringReader(string.Empty));
label_7:
      return (XmlReader) new XmlTextReader(url);
label_11:
      return (XmlReader) new XmlTextReader((TextReader) new StringReader((string) ConfigurationImportExecutor.D4A8O3ENLH2xyKgfYmjC((object) systemImportSettings)));
label_12:
      throw new NotSupportedException((string) ConfigurationImportExecutor.MpC2ypENUEqLFvj8TIo2((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178497438), (object) settings.GetType().FullName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088047770)));
    }

    /// <summary>
    /// Провека импортируемого файла на наличие корневого раздела ConfigExport и сравнение версий экспорта-импорта принимающего и исходного серверов
    /// </summary>
    /// <param name="reader"></param>
    /// <returns>true - проверка пройдена удачно, false - проверка провалена</returns>
    private bool CheckImportFileVersion(XmlReader reader)
    {
      int num1 = 3;
      XmlReader reader1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            reader1 = reader;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 2;
            continue;
          default:
            goto label_19;
        }
      }
label_4:
      bool flag;
      try
      {
        int num2;
        if (reader1 == null)
          num2 = 3;
        else
          goto label_7;
label_6:
        while (true)
        {
          int num3;
          switch (num2)
          {
            case 1:
            case 3:
              goto label_10;
            case 2:
            case 7:
              goto label_19;
            case 4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              num3 = ((IEnumerable<string>) ExportImportVersion.SupportedVersion).Any<string>((Func<string, bool>) (version => ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass76_0.RY9S5H8Oyn2K2KIwjxMX(ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass76_0.XwKSUX8OxCAmhKnKsS6A((object) reader1), ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass76_0.UfvlTu8OmnCx5dTWHnAP(ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass76_0.BARJa68O0JHy25wZuH39(-1638402543 ^ -1638791613), (object) version)))) ? 1 : 0;
              break;
            case 5:
            case 6:
              if (!ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) reader1), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1217523399 ^ -1217761333)))
              {
                num2 = 4;
                continue;
              }
              num3 = 1;
              break;
            default:
              goto label_7;
          }
          flag = num3 != 0;
          num2 = 2;
        }
label_7:
        if (reader1.IsStartElement())
        {
          num2 = 5;
          goto label_6;
        }
label_10:
        flag = false;
        num2 = 7;
        goto label_6;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_19;
            default:
              flag = false;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
              continue;
          }
        }
      }
label_19:
      return flag;
    }

    /// <summary>Проверяем файл конфигурации импортируемых файлов</summary>
    /// <param name="serverFilesFileName"></param>
    /// <param name="serverFolderName"></param>
    /// <returns></returns>
    private bool CheckImportFiles(string serverFilesFileName, string serverFolderName)
    {
      int num1 = 5;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (ConfigurationImportExecutor.WfRkM4ENsNuDGjKyu6us((object) serverFolderName))
            {
              num1 = 3;
              continue;
            }
            goto case 2;
          case 2:
            this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Warning, (string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1232639661 >> 3 ^ 153841089)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 4:
            if (ConfigurationImportExecutor.YUlnlPENgwog33tJmm77((object) importSettings) != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 8 : 6;
              continue;
            }
            goto label_5;
          case 5:
            if (this.importSettings is ConfigImportSettings importSettings)
            {
              num1 = 4;
              continue;
            }
            goto label_5;
          case 6:
            goto label_11;
          case 7:
            goto label_5;
          case 8:
            if (ConfigurationImportExecutor.jgeG7iE1AJJVuAtTxp9u((object) serverFilesFileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          default:
            num1 = 6;
            continue;
        }
      }
label_5:
      return true;
label_11:
      bool flag;
      try
      {
        XmlTextReader xmlTextReader = new XmlTextReader(serverFilesFileName);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
          num2 = 1;
        switch (num2)
        {
          case 1:
            try
            {
              int num3;
              if (xmlTextReader != null)
                num3 = 15;
              else
                goto label_28;
label_16:
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    if (!ConfigurationImportExecutor.aHWlqJE1LYQIoxkGNkvB((object) xmlTextReader))
                    {
                      num3 = 17;
                      continue;
                    }
                    goto case 12;
                  case 2:
                    if (!ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlTextReader), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-710283084 ^ -537863435 ^ 173886029)))
                    {
                      num3 = 16;
                      continue;
                    }
                    goto case 5;
                  case 3:
                  case 14:
                    goto label_6;
                  case 4:
                  case 19:
                    if (xmlTextReader.NodeType == XmlNodeType.EndElement)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                      continue;
                    }
                    goto case 1;
                  case 5:
                    ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) xmlTextReader);
                    num3 = 11;
                    continue;
                  case 6:
                  case 7:
                  case 16:
                    goto label_28;
                  case 8:
                  case 13:
                    int num4 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) xmlTextReader);
                    num3 = 4;
                    continue;
                  case 10:
                  case 17:
                    flag = false;
                    num3 = 14;
                    continue;
                  case 11:
                    int content = (int) xmlTextReader.MoveToContent();
                    num3 = 19;
                    continue;
                  case 12:
                    if (ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) xmlTextReader), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1146510045 ^ -1146239739)))
                    {
                      num3 = 18;
                      continue;
                    }
                    goto case 10;
                  case 15:
                    if (!ConfigurationImportExecutor.aHWlqJE1LYQIoxkGNkvB((object) xmlTextReader))
                    {
                      num3 = 7;
                      continue;
                    }
                    goto case 2;
                  case 18:
                    ConfigurationImportExecutor.qPNZx7ENFAG8vQyPD8WG((object) xmlTextReader);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 8 : 13;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_28:
              flag = false;
              num3 = 3;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
              {
                num3 = 2;
                goto label_16;
              }
              else
                goto label_16;
            }
            finally
            {
              if (xmlTextReader != null)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) xmlTextReader);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_39;
                  }
                }
              }
label_39:;
            }
          default:
            goto label_5;
        }
      }
      catch (Exception ex)
      {
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
          num6 = 0;
        while (true)
        {
          switch (num6)
          {
            case 1:
              goto label_6;
            case 2:
              flag = false;
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 1;
              continue;
            default:
              ConfigurationImportExecutor.ImportLog.Warn(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1319452732 ^ 1319190452), ex);
              num6 = 2;
              continue;
          }
        }
      }
label_6:
      return flag;
    }

    /// <summary>переход к разделу с импортируемыми данными</summary>
    /// <param name="reader"></param>
    /// <returns></returns>
    private bool MoveToConfigurationData(XmlReader reader) => ConfigurationImportExecutor.dTs50nENEjlYgpFBoeKx((object) reader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787213607));

    /// <summary>Чтение и выполнение пакета</summary>
    /// <param name="reader">XML reader</param>
    /// <param name="contentType">Тип пакета</param>
    /// <param name="serverFolderName">Временная папка с распакованным пакетом на сервере</param>
    private ConfigurationImportExecutor.ReadPacketResult ReadPacket(
      XmlReader reader,
      string contentType,
      string serverFolderName)
    {
      return new ConfigurationImportExecutor.ReadPacketResult(this, reader, contentType, serverFolderName);
    }

    private void ReadModulePackage(string serverFolderName)
    {
      int num1 = 29;
      while (true)
      {
        string id;
        string version;
        string[] strArray1;
        int index1;
        string str1;
        string[] strArray2;
        int num2;
        string[] strArray3;
        int index2;
        string path;
        string str2;
        string str3;
        string withoutExtension;
        object obj1;
        object obj2;
        switch (num1)
        {
          case 1:
            if (withoutExtension == null)
            {
              num1 = 23;
              continue;
            }
            goto case 9;
          case 2:
          case 15:
            if (index2 < strArray3.Length)
            {
              num1 = 20;
              continue;
            }
            goto label_32;
          case 3:
            goto label_5;
          case 4:
            goto label_46;
          case 5:
            version = string.Empty;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 10 : 7;
            continue;
          case 6:
            obj2 = ConfigurationImportExecutor.DSkm0rE3WOOlQmiPGhdr(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(2008901894 << 3 ^ -1108669902), (object) id, (object) strArray1[index1]);
            break;
          case 7:
            ++num2;
            num1 = 8;
            continue;
          case 8:
            ++index1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 6 : 17;
            continue;
          case 9:
            strArray1 = (string[]) ConfigurationImportExecutor.VWELw0ENtJ0y07IMwnop((object) withoutExtension, (object) new string[1]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521271676)
            }, StringSplitOptions.RemoveEmptyEntries);
            num1 = 34;
            continue;
          case 10:
            num2 = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 11:
          case 30:
            if (index1 < strArray1.Length)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 12 : 9;
              continue;
            }
            goto case 5;
          case 12:
            if (!int.TryParse(strArray1[index1], out int _))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 13 : 7;
              continue;
            }
            goto case 5;
          case 13:
          case 37:
            if (index1 != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 6;
              continue;
            }
            obj2 = (object) strArray1[index1];
            break;
          case 14:
            if (num2 != 0)
            {
              num1 = 22;
              continue;
            }
            obj1 = (object) strArray1[index1];
            goto label_51;
          case 16:
            List<PackageOperationInfo> packagesOperations = this.packagesOperations;
            PackageOperationInfo packageOperationInfo = new PackageOperationInfo();
            packageOperationInfo.Package = new PackageInfo(id);
            ConfigurationImportExecutor.ffg59cE3oNxWKmNKvRZW((object) packageOperationInfo, PackageOperationType.Install);
            ConfigurationImportExecutor.vDZinIE3bBM72FviGJOu((object) packageOperationInfo, (object) new SemanticVersion(version));
            packagesOperations.Add(packageOperationInfo);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 6 : 27;
            continue;
          case 18:
            ++index1;
            num1 = 11;
            continue;
          case 19:
          case 23:
          case 27:
            ++index2;
            num1 = 2;
            continue;
          case 20:
          case 24:
            path = strArray3[index2];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 5 : 25;
            continue;
          case 21:
            if (ConfigurationImportExecutor.jgeG7iE1AJJVuAtTxp9u((object) str2))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 19 : 12;
              continue;
            }
            goto case 31;
          case 22:
            obj1 = ConfigurationImportExecutor.DSkm0rE3WOOlQmiPGhdr(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-342626196 - 1290888215 ^ -1633497513), (object) version, (object) strArray1[index1]);
            goto label_51;
          case 25:
            str3 = (string) ConfigurationImportExecutor.QWrRChENzCMMs9wwEEqI((object) path);
            num1 = 36;
            continue;
          case 26:
            index2 = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 15 : 3;
            continue;
          case 28:
            if (ConfigurationImportExecutor.WfRkM4ENsNuDGjKyu6us((object) str1))
            {
              strArray2 = (string[]) ConfigurationImportExecutor.ySXa4YENcYfIMRLeSA9k((object) str1, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1350312861 << 3 ^ 2082459760));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 39 : 17;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 24 : 32;
            continue;
          case 29:
            str1 = (string) ConfigurationImportExecutor.Qv8oHUE1ge6GYP1mkdeN((object) serverFolderName, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-138018305 ^ -138255327));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 28 : 4;
            continue;
          case 31:
            ConfigurationImportExecutor.nMEpdpE3BJjvSArRdtHY((object) path, (object) str2, true);
            num1 = 35;
            continue;
          case 32:
            goto label_3;
          case 33:
            id = string.Empty;
            num1 = 30;
            continue;
          case 34:
            index1 = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 33 : 31;
            continue;
          case 35:
            withoutExtension = Path.GetFileNameWithoutExtension(path);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
            continue;
          case 36:
            str2 = (string) ConfigurationImportExecutor.Qv8oHUE1ge6GYP1mkdeN(ConfigurationImportExecutor.ynrRI4E3FQTH8nXqOERZ((object) this.packageService), (object) str3);
            num1 = 21;
            continue;
          case 38:
            strArray3 = strArray2;
            num1 = 26;
            continue;
          case 39:
            if (strArray2.Length != 0)
            {
              num1 = 38;
              continue;
            }
            goto label_27;
          default:
            if (index1 >= strArray1.Length)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 16 : 4;
              continue;
            }
            goto case 14;
        }
        id = (string) obj2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 3 : 18;
        continue;
label_51:
        version = (string) obj1;
        num1 = 7;
      }
label_5:
      return;
label_46:
      return;
label_3:
      return;
label_32:
      return;
label_27:;
    }

    public static void InitImportLicenseInfo(ImportLicenseInfo info)
    {
      int num1 = 13;
      while (true)
      {
        int num2 = num1;
        IPrivilegeModuleAccessGroup moduleAccessGroup;
        while (true)
        {
          IModuleManager moduleManager;
          uint? nullable;
          StringBuilder stringBuilder;
          ILicensedUnit licensedUnit;
          ILicenseInfo licenseInfo;
          IWorkplaceLicenseInfo workplaceLicenseInfo;
          IConcurrentLicenseInfo concurrentLicenseInfo;
          uint num3;
          string str1;
          string str2;
          IModule licModule;
          switch (num2)
          {
            case 1:
            case 44:
            case 47:
              str1 = ((ILicenseManager) ConfigurationImportExecutor.pNvvJOENVWNs5ykXnIr8(ConfigurationImportExecutor.amDNUqENT4CF9WJPsTDh())).GetActivationToken();
              num2 = 5;
              continue;
            case 2:
              goto label_24;
            case 3:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              moduleAccessGroup = ComponentManager.Current.GetExtensionPoints<IPrivilegeModuleAccessGroup>().FirstOrDefault<IPrivilegeModuleAccessGroup>((Func<IPrivilegeModuleAccessGroup, bool>) (g => ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass82_0.XW6JLT8Olhtt62jrpPeR((object) g) == ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass82_0.wZ77YU8Orb4jqJpayaNQ((object) licModule)));
              num2 = 4;
              continue;
            case 4:
              if (moduleAccessGroup == null)
              {
                num2 = 11;
                continue;
              }
              goto label_24;
            case 5:
              stringBuilder = new StringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 42 : 38;
              continue;
            case 6:
              if (ConfigurationImportExecutor.u1VlwfE3Vvv6XXFy4qS1((object) concurrentLicenseInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 16 : 18;
                continue;
              }
              goto case 11;
            case 7:
              ImportLicenseInfo importLicenseInfo1 = info;
              nullable = workplaceLicenseInfo.WorkplaceCount;
              object obj;
              if (!nullable.HasValue)
              {
                obj = ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669378065));
              }
              else
              {
                nullable = workplaceLicenseInfo.WorkplaceCount;
                num3 = nullable.Value;
                obj = (object) num3.ToString();
              }
              ConfigurationImportExecutor.R4vjBiE3RKMMkkWchZj5((object) importLicenseInfo1, obj);
              num2 = 8;
              continue;
            case 8:
              ImportLicenseInfo importLicenseInfo2 = info;
              num3 = workplaceLicenseInfo.UsedLicenseCount;
              string str3 = num3.ToString();
              ConfigurationImportExecutor.RVA8ZXE3q5etZY4wu2Ic((object) importLicenseInfo2, (object) str3);
              num2 = 34;
              continue;
            case 9:
              if (workplaceLicenseInfo != null)
              {
                num2 = 7;
                continue;
              }
              goto case 34;
            case 10:
              licenseInfo = (ILicenseInfo) ConfigurationImportExecutor.pr84xXE3vuSplVKaukch((object) licensedUnit);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
              continue;
            case 11:
            case 23:
            case 24:
              ConfigurationImportExecutor.cZTH1AE3if7RDq5QyRyr((object) info, (object) EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1251470110 >> 2 ^ 312575269)));
              num2 = 9;
              continue;
            case 12:
              ConfigurationImportExecutor.hWGvmDE3Gn4BXgHlN8qf((object) info, ConfigurationImportExecutor.DSkm0rE3WOOlQmiPGhdr(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-398663332 ^ -398647540), (object) VersionInfo.GetVersion<EleWise.ELMA.SR>(), ConfigurationImportExecutor.zkdhuIE3hEJ98JPK6N2i()));
              num2 = 38;
              continue;
            case 13:
              num2 = 12;
              continue;
            case 14:
              ConfigurationImportExecutor.cZTH1AE3if7RDq5QyRyr((object) info, ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(44884861 ^ 44589937)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 17 : 32;
              continue;
            case 15:
            case 33:
              ConfigurationImportExecutor.EVt4lWE3Z4jgF3siVdxl((object) stringBuilder, str1.Length <= 40 ? (object) str1 : ConfigurationImportExecutor.s37kPhE38cDpKS0QOlgh((object) str1, 0, 40));
              num2 = 41;
              continue;
            case 16:
              str2 = "";
              break;
            case 17:
              licensedUnit = (ILicensedUnit) ConfigurationImportExecutor.rYnyfnE3fUT39boDCsoh((object) moduleManager);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 31 : 0;
              continue;
            case 18:
              if (licModule != null)
              {
                num2 = 3;
                continue;
              }
              goto case 11;
            case 19:
              if (nullable.HasValue)
              {
                num2 = 35;
                continue;
              }
              goto label_17;
            case 20:
              ConfigurationImportExecutor.yrJLSXE3Tq7N8OjOjMaQ((object) info, ConfigurationImportExecutor.U31rekE1XTLRckvqfYJR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360101927)));
              num2 = 25;
              continue;
            case 21:
              goto label_58;
            case 22:
              ConfigurationImportExecutor.l4EUDBE3CDYQuLHm1YDb((object) info, ConfigurationImportExecutor.lMV2FKE3Qkd7fiCHkdG5((object) ((ComponentManager) ConfigurationImportExecutor.amDNUqENT4CF9WJPsTDh()).LicenseManager, (object) licensedUnit));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 10 : 7;
              continue;
            case 25:
              ImportLicenseInfo importLicenseInfo3 = info;
              nullable = concurrentLicenseInfo.PrivilegeCount;
              num3 = nullable.Value;
              string str4 = num3.ToString();
              ConfigurationImportExecutor.egd75hE3kwOaGVV31E1g((object) importLicenseInfo3, (object) str4);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
              continue;
            case 26:
              concurrentLicenseInfo = licenseInfo as IConcurrentLicenseInfo;
              num2 = 36;
              continue;
            case 27:
              if (ConfigurationImportExecutor.WDeirNE3XThVD53aYsxc((object) info))
              {
                num2 = 14;
                continue;
              }
              goto label_49;
            case 28:
              if (moduleManager.MainApplication == null)
              {
                num2 = 47;
                continue;
              }
              goto case 17;
            case 29:
              moduleManager = (IModuleManager) ConfigurationImportExecutor.wCVyoYENSJwxquCkdonA(ConfigurationImportExecutor.amDNUqENT4CF9WJPsTDh());
              num2 = 28;
              continue;
            case 30:
            case 42:
              if (str1 != null)
              {
                num2 = 39;
                continue;
              }
              goto case 46;
            case 31:
              if (licensedUnit == null)
              {
                num2 = 44;
                continue;
              }
              goto case 22;
            case 32:
              nullable = concurrentLicenseInfo.PrivilegeCount;
              num2 = 19;
              continue;
            case 34:
              ConfigurationImportExecutor.u2JQ8TE3KuLB5woTtuJt((object) info, concurrentLicenseInfo != null && ConfigurationImportExecutor.u1VlwfE3Vvv6XXFy4qS1((object) concurrentLicenseInfo));
              num2 = 27;
              continue;
            case 35:
              nullable = concurrentLicenseInfo.PrivilegeCount;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 34 : 40;
              continue;
            case 36:
              workplaceLicenseInfo = licenseInfo as IWorkplaceLicenseInfo;
              num2 = 37;
              continue;
            case 37:
              licModule = ConfigurationImportExecutor.rYnyfnE3fUT39boDCsoh((object) moduleManager) as IModule;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 43 : 43;
              continue;
            case 38:
              ConfigurationImportExecutor.XdBoeSE3EI4WaVJcU2WF((object) info, ConfigurationImportExecutor.pNvvJOENVWNs5ykXnIr8(ConfigurationImportExecutor.amDNUqENT4CF9WJPsTDh()) != null && ((ComponentManager) ConfigurationImportExecutor.amDNUqENT4CF9WJPsTDh()).LicenseManager.CanAddActivationKey());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 45 : 30;
              continue;
            case 39:
              if (ConfigurationImportExecutor.l2HdSBE3uOQkOJJrUlJc((object) str1) > 0)
              {
                num2 = 15;
                continue;
              }
              goto case 46;
            case 40:
              if (nullable.Value > 0U)
              {
                num2 = 20;
                continue;
              }
              goto label_56;
            case 41:
              if (ConfigurationImportExecutor.l2HdSBE3uOQkOJJrUlJc((object) str1) <= 40)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 13 : 16;
                continue;
              }
              str2 = str1.Substring(40);
              break;
            case 43:
              if (concurrentLicenseInfo == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 14 : 23;
                continue;
              }
              goto case 6;
            case 45:
              licenseInfo = (ILicenseInfo) null;
              num2 = 29;
              continue;
            case 46:
              ConfigurationImportExecutor.zr3ISrE3IwRcJKpkincc((object) info, (object) stringBuilder.ToString());
              num2 = 26;
              continue;
            default:
              ImportLicenseInfo importLicenseInfo4 = info;
              num3 = concurrentLicenseInfo.UsedPrivilegeCount;
              string str5 = num3.ToString();
              importLicenseInfo4.UsedPrivilegeLicenseCount = str5;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 21 : 0;
              continue;
          }
          str1 = str2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 6 : 30;
        }
label_24:
        ConfigurationImportExecutor.StI3d3E3SWdqBuG1CPIC((object) info, moduleAccessGroup.UserGroupUid);
        num1 = 24;
      }
label_58:
      return;
label_56:
      return;
label_49:
      return;
label_17:;
    }

    private ImportLicenseInfo CheckOrActivateModules(
      string serverFolderName,
      string key,
      out AppDomain domain)
    {
      int num1 = 27;
      string str1;
      ImportLicenseInfo licenseInfo;
      while (true)
      {
        int num2 = num1;
        string str2;
        string path;
        string path2;
        string str3;
        while (true)
        {
          AppDomainSetup appDomainSetup1;
          string str4;
          Func<bool> func;
          IEnumerator<string> enumerator1;
          ZipFile zipFile;
          string str5;
          string[] strArray1;
          string[] strArray2;
          int index;
          object obj1;
          List<string> assembliesToCheck;
          ImportAssemblyLoader assemblyLoader;
          switch (num2)
          {
            case 1:
              goto label_67;
            case 2:
              int num3 = func() ? 1 : 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 36 : 35;
              continue;
            case 3:
              goto label_98;
            case 4:
              goto label_71;
            case 5:
              strArray2 = strArray1;
              num2 = 39;
              continue;
            case 6:
              if (!ConfigurationImportExecutor.WfRkM4ENsNuDGjKyu6us((object) str1))
                goto case 22;
              else
                goto label_93;
            case 7:
              obj1 = ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1088304168 ^ -1088160970);
              break;
            case 8:
              try
              {
label_9:
                if (ConfigurationImportExecutor.fagugcE1aZARwy0aBgiG((object) enumerator1))
                  goto label_11;
                else
                  goto label_10;
label_8:
                int num4;
                switch (num4)
                {
                  case 1:
                    goto label_9;
                  case 2:
                    goto label_11;
                  default:
                    goto label_87;
                }
label_10:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                goto label_8;
label_11:
                string current = enumerator1.Current;
                string str6 = (string) ConfigurationImportExecutor.QWrRChENzCMMs9wwEEqI((object) current);
                ConfigurationImportExecutor.YfBbJ6E3aI5nH4HXCxZr((object) current, (object) (string) ConfigurationImportExecutor.Qv8oHUE1ge6GYP1mkdeN((object) str1, (object) str6));
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                {
                  num4 = 1;
                  goto label_8;
                }
                else
                  goto label_8;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
                    num5 = 0;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_18;
                      default:
                        ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) enumerator1);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_18:;
              }
            case 9:
              goto label_73;
            case 10:
              assembliesToCheck = new List<string>();
              num2 = 5;
              continue;
            case 11:
              if (!ConfigurationImportExecutor.WfRkM4ENsNuDGjKyu6us((object) str4))
              {
                num2 = 43;
                continue;
              }
              goto case 28;
            case 12:
              obj1 = ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1824388195 ^ -1824093437);
              break;
            case 13:
            case 37:
              if (index < strArray2.Length)
              {
                num2 = 40;
                continue;
              }
              goto label_71;
            case 14:
              str4 = (string) ConfigurationImportExecutor.Qv8oHUE1ge6GYP1mkdeN((object) path, (object) path2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 36 : 41;
              continue;
            case 15:
              int num6 = func() ? 1 : 0;
              num2 = 23;
              continue;
            case 16:
              domain = (AppDomain) ConfigurationImportExecutor.lAe3WQE33xfUgRiWYcWJ(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1978478350 ^ -1978249088), (object) ((AppDomain) ConfigurationImportExecutor.gwQA1rE3Nndgi8YrEZwR()).Evidence, (object) appDomainSetup1);
              num2 = 9;
              continue;
            case 17:
              if (ConfigurationImportExecutor.WfRkM4ENsNuDGjKyu6us((object) str5))
              {
                num2 = 19;
                continue;
              }
              goto label_62;
            case 18:
            case 46:
              AppDomainSetup appDomainSetup2 = new AppDomainSetup();
              ConfigurationImportExecutor.DaxF0tE3OVCDogElUtYY((object) appDomainSetup2, (object) str1);
              ConfigurationImportExecutor.RD6G2IE32tZ6WWHB8i0j((object) appDomainSetup2, (object) str1);
              ConfigurationImportExecutor.HECWolE31lnxxLyYETPX((object) appDomainSetup2, ConfigurationImportExecutor.au5T1vE3PTKkl3bxBXUX(ConfigurationImportExecutor.iU4RPvE3eAKMa1rA7U2n((object) AppDomain.CurrentDomain)));
              appDomainSetup1 = appDomainSetup2;
              num2 = 16;
              continue;
            case 19:
              strArray1 = (string[]) ConfigurationImportExecutor.ySXa4YENcYfIMRLeSA9k((object) str5, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-740338220 ^ -740399428));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 47 : 18;
              continue;
            case 20:
              ConfigurationImportExecutor.ISNyWuE3dTLeOKZTw7bt((object) assemblyLoader, (object) str3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 25 : 10;
              continue;
            case 21:
              ConfigurationImportExecutor.InitImportLicenseInfo(licenseInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 15 : 30;
              continue;
            case 22:
              Directory.CreateDirectory(str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 46 : 40;
              continue;
            case 23:
              if (ConfigurationImportExecutor.u1lVu1E1rkXXYmfryECy((object) key))
              {
                num2 = 44;
                continue;
              }
              goto case 31;
            case 24:
              try
              {
                int num7;
                if (this.IsWebPackage(zipFile))
                  num7 = 2;
                else
                  goto label_26;
label_25:
                IEnumerator enumerator2;
                switch (num7)
                {
                  case 1:
                    break;
                  case 2:
                    goto label_94;
                  default:
                    try
                    {
label_46:
                      if (enumerator2.MoveNext())
                        goto label_48;
                      else
                        goto label_47;
label_31:
                      ZipEntry entry;
                      int num8;
                      while (true)
                      {
                        int num9;
                        string extension;
                        Stream inputStream;
                        string str7;
                        switch (num8)
                        {
                          case 1:
                            if (ConfigurationImportExecutor.geSxO0E30misVx4Vt1O4((object) extension, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1290212282 ^ -644262414 ^ 1787115804)))
                            {
                              num8 = 8;
                              continue;
                            }
                            goto label_46;
                          case 2:
                            goto label_94;
                          case 4:
                            object obj2 = ConfigurationImportExecutor.Qv8oHUE1ge6GYP1mkdeN((object) str1, ConfigurationImportExecutor.QWrRChENzCMMs9wwEEqI(ConfigurationImportExecutor.MF5xjiE3xPNOhdufWexb((object) entry)));
                            ConfigurationImportExecutor.MBc4XVE3yDTVXnZtSs9B(obj2, ConfigurationImportExecutor.u5VA1xE3mog8Xu1wLQiS((object) inputStream));
                            str7 = (string) ConfigurationImportExecutor.mNa1uSE3Mt801gueBUO4(obj2);
                            num9 = 10;
                            break;
                          case 6:
                            if (!string.IsNullOrEmpty(extension))
                            {
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 4 : 12;
                              continue;
                            }
                            goto label_46;
                          case 7:
                            if (!ConfigurationImportExecutor.qGCeklE37t6LGeQZCmEi((object) entry))
                            {
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
                              continue;
                            }
                            goto case 9;
                          case 8:
                            inputStream = zipFile.GetInputStream(entry);
                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 4 : 0;
                            continue;
                          case 9:
                            extension = Path.GetExtension((string) ConfigurationImportExecutor.MF5xjiE3xPNOhdufWexb((object) entry));
                            num8 = 6;
                            continue;
                          case 10:
                            if (assembliesToCheck.Contains(str7))
                            {
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 5 : 3;
                              continue;
                            }
                            goto case 11;
                          case 11:
                            assembliesToCheck.Add(str7);
                            num9 = 3;
                            break;
                          case 12:
                            if (!ConfigurationImportExecutor.geSxO0E30misVx4Vt1O4((object) extension, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-477139494 ^ -477222560)))
                            {
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
                              continue;
                            }
                            goto case 8;
                          case 13:
                            goto label_48;
                          default:
                            goto label_46;
                        }
                        num8 = num9;
                      }
label_47:
                      num8 = 2;
                      goto label_31;
label_48:
                      entry = (ZipEntry) ConfigurationImportExecutor.cfnLh1E3Af4PkqaALQgI((object) enumerator2);
                      num8 = 7;
                      goto label_31;
                    }
                    finally
                    {
                      IDisposable disposable = enumerator2 as IDisposable;
                      int num10 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
                        num10 = 0;
                      while (true)
                      {
                        switch (num10)
                        {
                          case 1:
                            if (disposable == null)
                            {
                              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                              continue;
                            }
                            goto case 3;
                          case 3:
                            ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) disposable);
                            num10 = 2;
                            continue;
                          default:
                            goto label_55;
                        }
                      }
label_55:;
                    }
                }
label_26:
                enumerator2 = (IEnumerator) ConfigurationImportExecutor.LuuQQsE3H65RBk43bu5R((object) zipFile);
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                {
                  num7 = 0;
                  goto label_25;
                }
                else
                  goto label_25;
              }
              finally
              {
                ConfigurationImportExecutor.YcQHh2E3JrCY30spO8BU((object) zipFile);
                int num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
                  num11 = 0;
                switch (num11)
                {
                  default:
                }
              }
            case 25:
              func = (Func<bool>) (() =>
              {
                int num12 = 3;
                List<string>.Enumerator enumerator3;
                while (true)
                {
                  switch (num12)
                  {
                    case 1:
                      goto label_4;
                    case 2:
                      enumerator3 = assembliesToCheck.GetEnumerator();
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
                      continue;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass83_0.Cs6t2p8OYP6v6IDKv4Ts((object) licenseInfo.Modules);
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 2 : 2;
                      continue;
                    default:
                      goto label_17;
                  }
                }
label_4:
                try
                {
label_8:
                  if (enumerator3.MoveNext())
                    goto label_6;
                  else
                    goto label_9;
label_5:
                  string current;
                  ModuleDTO dto;
                  int num13;
                  while (true)
                  {
                    switch (num13)
                    {
                      case 1:
                        goto label_8;
                      case 2:
                        goto label_17;
                      case 3:
                        if (!assemblyLoader.CheckModuleLicense(current, out dto))
                        {
                          num13 = 4;
                          continue;
                        }
                        goto label_8;
                      case 4:
                        licenseInfo.Modules.Add(dto);
                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
                        continue;
                      default:
                        goto label_6;
                    }
                  }
label_6:
                  current = enumerator3.Current;
                  num13 = 3;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
                  {
                    num13 = 3;
                    goto label_5;
                  }
                  else
                    goto label_5;
label_9:
                  num13 = 2;
                  goto label_5;
                }
                finally
                {
                  enumerator3.Dispose();
                  int num14 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                    num14 = 0;
                  switch (num14)
                  {
                    default:
                  }
                }
label_17:
                return true;
              });
              num2 = 15;
              continue;
            case 26:
              domain = (AppDomain) null;
              num2 = 34;
              continue;
            case 27:
              num2 = 26;
              continue;
            case 28:
              ConfigurationImportExecutor.ykVT3tE3tC790lhiga1q((object) str4, (object) str2);
              num2 = 35;
              continue;
            case 29:
label_94:
              ++index;
              num2 = 37;
              continue;
            case 30:
              goto label_83;
            case 31:
              assemblyLoader.ActivateNewModules(licenseInfo.Modules, key);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 0;
              continue;
            case 32:
            case 40:
              zipFile = new ZipFile(strArray2[index]);
              num2 = 24;
              continue;
            case 33:
label_87:
              if (ConfigurationImportExecutor.uGbiumE3DIEDV0IQ2XG6())
              {
                num2 = 7;
                continue;
              }
              goto case 12;
            case 34:
              str5 = (string) ConfigurationImportExecutor.Qv8oHUE1ge6GYP1mkdeN((object) serverFolderName, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1033719030 - 2012070891 ^ -978588459));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 12 : 17;
              continue;
            case 35:
            case 43:
              // ISSUE: type reference
              // ISSUE: type reference
              assemblyLoader = (ImportAssemblyLoader) ConfigurationImportExecutor.GhuDecE36Ef9966UwSEM((object) domain, ConfigurationImportExecutor.VCxQFAE34XEFFvJrSBnh((object) ConfigurationImportExecutor.LgMvBTE3wmR5Qgx3LDlf(__typeref (ImportAssemblyLoader)).Assembly), (object) ConfigurationImportExecutor.LgMvBTE3wmR5Qgx3LDlf(__typeref (ImportAssemblyLoader)).FullName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 10 : 0;
              continue;
            case 36:
            case 44:
              ConfigurationImportExecutor.w21D29E3lpbE9qfnZWe5((object) domain);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 3;
              continue;
            case 38:
              licenseInfo = new ImportLicenseInfo();
              num2 = 21;
              continue;
            case 39:
              index = 0;
              num2 = 13;
              continue;
            case 41:
              goto label_80;
            case 42:
              goto label_6;
            case 45:
              enumerator1 = ((IEnumerable<string>) ConfigurationImportExecutor.ySXa4YENcYfIMRLeSA9k((object) path, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(277947046 - -1479185048 ^ 1757082104))).Union<string>((IEnumerable<string>) Directory.GetFiles(path, (string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1218962250 ^ 1218744148))).GetEnumerator();
              num2 = 8;
              continue;
            case 47:
              if (strArray1.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 22 : 38;
                continue;
              }
              goto label_67;
            default:
              goto label_62;
          }
          path2 = (string) obj1;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 5 : 14;
        }
label_71:
        str3 = (string) ConfigurationImportExecutor.nHIVMlE39gmKKIKiBkve((object) this.runtimeApplication.Configuration.Config);
        num1 = 20;
        continue;
label_73:
        path = (string) ConfigurationImportExecutor.Qv8oHUE1ge6GYP1mkdeN(ConfigurationImportExecutor.elHtqlE3pQ6pj78tTVYN(ConfigurationImportExecutor.gwQA1rE3Nndgi8YrEZwR()), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1242972401 >> 4 ^ 77617213));
        num1 = 45;
        continue;
label_80:
        str2 = Path.Combine(str1, path2);
        num1 = 11;
        continue;
label_83:
        str1 = (string) ConfigurationImportExecutor.h76qnTE3n6upSqpSRemL();
        num1 = 6;
        continue;
label_93:
        num1 = 18;
      }
label_6:
      return licenseInfo;
label_62:
      return (ImportLicenseInfo) null;
label_67:
      return (ImportLicenseInfo) null;
label_98:
      try
      {
        ConfigurationImportExecutor.I1XIjTE3rnu3hFXIYVS5((object) str1, true);
        int num15 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
          num15 = 0;
        switch (num15)
        {
          default:
            goto label_6;
        }
      }
      catch (Exception ex)
      {
        int num16 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
          num16 = 0;
        while (true)
        {
          switch (num16)
          {
            case 1:
              goto label_6;
            default:
              ((EleWise.ELMA.Logging.ILogger) ConfigurationImportExecutor.MlNMGBE1y8ECm86WgVkD()).Error((object) ex.Message, ex);
              num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
              continue;
          }
        }
      }
    }

    private bool IsWebPackage(ZipFile zipFile) => zipFile.Cast<ZipEntry>().Any<ZipEntry>((Func<ZipEntry, bool>) (zipEntry => ConfigurationImportExecutor.\u003C\u003Ec.r1FIcc8ObhgiTIAlgmvL(ConfigurationImportExecutor.\u003C\u003Ec.sXLimj8Oo6v8qLnAGHaH(ConfigurationImportExecutor.\u003C\u003Ec.oXVCk48OWoL4AgNdr4EU((object) zipEntry)), ConfigurationImportExecutor.\u003C\u003Ec.kAx2j18nHeh7IC2RH0GP(589593376 ^ -1977315327 ^ -1459283169))));

    /// <summary>Инициализация используемых списков</summary>
    private void FillImportData()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.step = (ImportStep) ConfigurationImportExecutor.h9ykD5E1Px7Gft1hHX4m((object) this.importSettings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.savedPacketEntities = new List<IEntity>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
            continue;
          case 4:
            this.packetError = new List<string>();
            num = 3;
            continue;
          default:
            this.serviceData = new Dictionary<string, string>();
            num = 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Инициализация используемых сервисов и точек расширений
    /// </summary>
    private void FillServices()
    {
    }

    private void ReadDictionary(XmlReader reader, IDictionary<string, string> dictionary)
    {
      if (reader.IsEmptyElement)
        return;
      reader.Read();
      int content1 = (int) reader.MoveToContent();
      while (reader.NodeType != XmlNodeType.EndElement)
      {
        dictionary.Add(reader.Name, reader.ReadElementString());
        int content2 = (int) reader.MoveToContent();
      }
    }

    private bool ReadImportants(XmlReader reader)
    {
      int num1 = 17;
      List<ConfigurationImportExecutor.ImportantDataClass> importantDataClassList;
      ConfigurationImportExecutor.ImportantDataClass importantDataClass;
      HashSet<Guid> hashSet;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_31;
          case 2:
            if (!ConfigurationImportExecutor.aHWlqJE1LYQIoxkGNkvB((object) reader))
            {
              num1 = 9;
              continue;
            }
            goto case 23;
          case 3:
            importantDataClassList = new List<ConfigurationImportExecutor.ImportantDataClass>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 4;
            continue;
          case 4:
            ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) reader);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 21 : 0;
            continue;
          case 5:
            goto label_3;
          case 6:
          case 7:
            if (ConfigurationImportExecutor.u8mPV3ENBOqyjN9FPD2H((object) reader) == XmlNodeType.EndElement)
            {
              num1 = 12;
              continue;
            }
            goto case 2;
          case 8:
            if (importantDataClass != null)
            {
              num1 = 13;
              continue;
            }
            goto case 11;
          case 9:
          case 22:
            ConfigurationImportExecutor.qPNZx7ENFAG8vQyPD8WG((object) reader);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 11 : 8;
            continue;
          case 10:
            if (!ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) reader))
            {
              num1 = 3;
              continue;
            }
            goto label_4;
          case 11:
          case 18:
            int num2 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) reader);
            num1 = 7;
            continue;
          case 12:
            ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) reader);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 19 : 20;
            continue;
          case 13:
            importantDataClassList.Add(importantDataClass);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 18 : 2;
            continue;
          case 14:
            // ISSUE: reference to a compiler-generated method
            hashSet = this.importantData.Select<IImportantData, Guid>((Func<IImportantData, Guid>) (d => ConfigurationImportExecutor.\u003C\u003Ec.D5121P8Oh3vARnG4gDIv((object) d))).ToHashSet<Guid>();
            num1 = 6;
            continue;
          case 15:
            List<ConfigurationImportExecutor.ImportantDataClass> source = importantDataClassList;
            // ISSUE: reference to a compiler-generated field
            Func<ConfigurationImportExecutor.ImportantDataClass, string> func = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__88_1;
            Func<ConfigurationImportExecutor.ImportantDataClass, string> keySelector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__88_1 = keySelector = (Func<ConfigurationImportExecutor.ImportantDataClass, string>) (d => d.Module);
            }
            else
              goto label_35;
label_34:
            source.GroupBy<ConfigurationImportExecutor.ImportantDataClass, string>(keySelector).ForEach<IGrouping<string, ConfigurationImportExecutor.ImportantDataClass>>((Action<IGrouping<string, ConfigurationImportExecutor.ImportantDataClass>>) (g =>
            {
              string text;
              if (g.Key != null)
              {
                // ISSUE: reference to a compiler-generated method
                text = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97676384), (object) g.Key, (object) g.Select<ConfigurationImportExecutor.ImportantDataClass, Version>((Func<ConfigurationImportExecutor.ImportantDataClass, Version>) (d => (Version) ConfigurationImportExecutor.\u003C\u003Ec.gt9AgC8OGZMbsEaLY5Jv((object) d))).Max<Version>());
              }
              else
              {
                // ISSUE: reference to a compiler-generated method
                text = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902087381), (object) g.Select<ConfigurationImportExecutor.ImportantDataClass, Version>((Func<ConfigurationImportExecutor.ImportantDataClass, Version>) (d => (Version) ConfigurationImportExecutor.\u003C\u003Ec.gt9AgC8OGZMbsEaLY5Jv((object) d))).Max<Version>());
              }
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, text));
            }));
            num1 = 5;
            continue;
label_35:
            keySelector = func;
            goto label_34;
          case 16:
            goto label_12;
          case 17:
            if (ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) reader))
            {
              num1 = 16;
              continue;
            }
            ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) reader);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 3 : 10;
            continue;
          case 19:
            importantDataClass = ConfigurationImportExecutor.ImportantDataClass.Read((object) reader, (ISet<Guid>) hashSet);
            num1 = 8;
            continue;
          case 20:
            if (ConfigurationImportExecutor.xs3IY4E3gagKtaDBRDsN((object) importantDataClassList) != 0)
            {
              num1 = 15;
              continue;
            }
            goto label_31;
          case 21:
            int num3 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) reader);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 12 : 14;
            continue;
          case 23:
            if (ConfigurationImportExecutor.RmoLaAE1sJvsY73orXow(ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) reader), ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1858887263 ^ -1858601419)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            }
            goto case 9;
          default:
            if (!ConfigurationImportExecutor.WaSmnAE1cpYU3LOfjiR7((object) reader))
            {
              num1 = 19;
              continue;
            }
            goto case 9;
        }
      }
label_3:
      return false;
label_4:
      return true;
label_12:
      return true;
label_31:
      return true;
    }

    private void ReadServiceData(XmlReader reader)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ReadDictionary(reader, (IDictionary<string, string>) this.serviceData);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private StoreComponentUnpackStatus UnpackIfSigned(
      string key,
      Func<DateTime?> getMainUnitExpiration,
      string componentPath,
      string serverFolderName,
      out IEnumerable<StoreComponentVerifiedSignature> signatures)
    {
      signatures = (IEnumerable<StoreComponentVerifiedSignature>) null;
      List<string> list = ComponentManager.Current.LicenseManager.GetActivationKeys().Select<KeyValuePair<Guid, string>, string>((Func<KeyValuePair<Guid, string>, string>) (a => a.Value)).ToList<string>();
      if (!string.IsNullOrEmpty(key))
        list.Add(key);
      StoreComponentUnpackStatus componentUnpackStatus;
      try
      {
        componentUnpackStatus = ElmaStoreComponentsBuilder.UnpackIfSigned(componentPath, serverFolderName, (IEnumerable<string>) list, getMainUnitExpiration, out signatures);
      }
      catch (Exception ex)
      {
        EleWise.ELMA.Logging.Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360102057), ex);
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012382195)));
      }
      if (componentUnpackStatus == StoreComponentUnpackStatus.WrongSignatures)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        EleWise.ELMA.Logging.Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917027166) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883351090), signatures.Where<StoreComponentVerifiedSignature>((Func<StoreComponentVerifiedSignature, bool>) (s => ConfigurationImportExecutor.\u003C\u003Ec.bwBcww8OE4mSsowjXpM6((object) s) != 0)).Select<StoreComponentVerifiedSignature, string>((Func<StoreComponentVerifiedSignature, string>) (s => (string) ConfigurationImportExecutor.\u003C\u003Ec.noSPbx8OQ3y6Kmpkv8kr((object) new object[4]
        {
          ConfigurationImportExecutor.\u003C\u003Ec.kAx2j18nHeh7IC2RH0GP(--1867379187 ^ 1867319057),
          (object) ConfigurationImportExecutor.\u003C\u003Ec.Vdmxcl8OfbMtYaUFYclc((object) s),
          (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173867729),
          (object) ConfigurationImportExecutor.\u003C\u003Ec.bwBcww8OE4mSsowjXpM6((object) s)
        }))))));
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647683638)));
      }
      return componentUnpackStatus;
    }

    /// <summary>Чтение блока с метаданными</summary>
    /// <param name="reader"></param>
    /// <param name="isSystemMd">блок с системными метаданными - true, с пользовательскими - false</param>
    /// <param name="serverFolderName">Временная папка с распакованным пакетом на сервере</param>
    /// <param name="isTestRead">чтение при тесте - true, чтение при импорте - false</param>
    private IEnumerable<IReadMetadataResult> ReadMetadataBlock(
      XmlReader reader,
      bool isSystemMd,
      string serverFolderName,
      bool isTestRead = false)
    {
      List<IReadMetadataResult> readMetadataResultList = new List<IReadMetadataResult>();
      while (reader.NodeType != XmlNodeType.EndElement)
      {
        if (reader.IsStartElement())
        {
          if (reader.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939356594) && !reader.IsEmptyElement)
          {
            IReadMetadataResult readMetadataResult = this.ReadMetadata(reader, isSystemMd, serverFolderName, isTestRead);
            if (readMetadataResult != null)
              readMetadataResultList.Add(readMetadataResult);
            reader.Read();
          }
          else
            reader.Skip();
        }
        int content = (int) reader.MoveToContent();
      }
      reader.Read();
      return (IEnumerable<IReadMetadataResult>) readMetadataResultList;
    }

    /// <summary>Чтение метаданных при импорте файла конфигурации</summary>
    private IReadMetadataResult ReadMetadata(
      XmlReader reader,
      bool isSystemMd,
      string serverFolderName,
      bool isTestRead = false)
    {
      int num1 = 16;
      IReadMetadataResult readMetadataResult;
      ReadMetadataParameters parameters;
      bool isTestRead1;
      while (true)
      {
        int num2 = num1;
        string str1;
        string str2;
        while (true)
        {
          Type tp;
          string xml;
          IMetadata metadata;
          Dictionary<string, ICollection<string>> attributes;
          ICollection<string> strings;
          IEnumerator<IPostEntityXmlSerializer> enumerator;
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              metadata = (IMetadata) ClassSerializationHelper.DeserializeObjectByXml(tp, xml);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 22 : 11;
              continue;
            case 3:
              if (reader.MoveToFirstAttribute())
              {
                num2 = 5;
                continue;
              }
              goto case 9;
            case 4:
              attributes = new Dictionary<string, ICollection<string>>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 3 : 3;
              continue;
            case 5:
              if (!attributes.TryGetValue(reader.Name, out strings))
                goto case 12;
              else
                goto label_17;
            case 6:
              goto label_51;
            case 7:
            case 18:
              strings.Add((string) ConfigurationImportExecutor.gbAjsZE35XTpSPuhb4Ji((object) reader));
              num2 = 17;
              continue;
            case 8:
              goto label_19;
            case 9:
              ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 14 : 25;
              continue;
            case 10:
              str1 = reader.Value;
              num2 = 8;
              continue;
            case 11:
label_7:
              if (tp == (Type) null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                continue;
              }
              break;
            case 12:
              attributes[(string) ConfigurationImportExecutor.zmwHRHE1UslqZB4OAIKq((object) reader)] = strings = (ICollection<string>) new List<string>();
              num2 = 7;
              continue;
            case 13:
              reader.Read();
              num2 = 6;
              continue;
            case 14:
              goto label_56;
            case 15:
              isTestRead1 = isTestRead;
              num2 = 4;
              continue;
            case 16:
              num2 = 15;
              continue;
            case 17:
              if (!ConfigurationImportExecutor.pG0aarE3jtcrZQvAaRpl((object) reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 9 : 9;
                continue;
              }
              goto case 5;
            case 19:
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(~-306453669 ^ 306225024)));
              num2 = 27;
              continue;
            case 20:
              this.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(1199946765 ^ 1199652515)));
              num2 = 13;
              continue;
            case 21:
              if (!ConfigurationImportExecutor.YJcXStENYHAJ5JquIdba((object) str1))
              {
                StringBuilder stringBuilder = new StringBuilder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671960029));
                ConfigurationImportExecutor.EVt4lWE3Z4jgF3siVdxl((object) stringBuilder, (object) str1);
                xml = stringBuilder.ToString();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 11 : 23;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 19 : 5;
              continue;
            case 22:
              parameters = new ReadMetadataParameters(this.messages, this.systemMessages, this.importSettings, metadata, isSystemMd, (IDictionary<string, ICollection<string>>) attributes, this.treeUid, this.mergeReplace, (IDictionary<string, string>) this.serviceData, (ICollection<long>) this.headers, this.metadataNotIsUnique, this.manifestExecuteMetadata, serverFolderName, new Action<TestImportMessages>(this.TestMessagesAdd));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 6 : 14;
              continue;
            case 23:
              enumerator = this.postEntityXmlSerializers.GetEnumerator();
              num2 = 26;
              continue;
            case 24:
              try
              {
                tp = ConfigurationImportExecutor.p3aaDkE3LJCUmSmwFnp4((object) str2);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_7;
                }
              }
              catch
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      readMetadataResult = (IReadMetadataResult) null;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 2;
                      continue;
                    case 2:
                      goto label_59;
                    default:
                      ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) reader);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
            case 25:
              int num5 = (int) ConfigurationImportExecutor.WFMAx6E1zDIJWZIkcCR2((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 10 : 1;
              continue;
            case 26:
              try
              {
label_25:
                if (ConfigurationImportExecutor.fagugcE1aZARwy0aBgiG((object) enumerator))
                  goto label_27;
                else
                  goto label_26;
label_24:
                int num6;
                switch (num6)
                {
                  case 1:
                    goto label_25;
                  case 2:
                    goto label_27;
                  default:
                    goto label_20;
                }
label_26:
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                goto label_24;
label_27:
                xml = (string) ConfigurationImportExecutor.mH9gipE3sSBJNLUNY90m((object) enumerator.Current, (object) xml);
                num6 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                {
                  num6 = 1;
                  goto label_24;
                }
                else
                  goto label_24;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                    num7 = 0;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_34;
                      default:
                        ConfigurationImportExecutor.GH8iJvE1KjBtdq7Mib6q((object) enumerator);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_34:;
              }
            case 27:
              ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
              continue;
            case 28:
label_20:
              ConfigurationImportExecutor.qlGUxwENGSOyZXd6OKWI((object) reader);
              num2 = 2;
              continue;
            default:
              if (isTestRead1)
                break;
              goto label_4;
          }
          str1 = (string) ConfigurationImportExecutor.QppVMhE3U3kqyr85inJF((object) str1, 0, ConfigurationImportExecutor.LWLaFGE3YKC3tacalwLC((object) str1, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1822890472 ^ -1822905890)));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 5 : 21;
        }
label_4:
        num1 = 20;
        continue;
label_17:
        num1 = 18;
        continue;
label_19:
        str2 = (string) ConfigurationImportExecutor.s37kPhE38cDpKS0QOlgh((object) str1, 0, ConfigurationImportExecutor.LWLaFGE3YKC3tacalwLC((object) str1, ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(993438473 ^ 993453263)));
        num1 = 24;
      }
label_10:
      return (IReadMetadataResult) null;
label_51:
      return (IReadMetadataResult) null;
label_56:
      // ISSUE: reference to a compiler-generated method
      IEnumerable<IReadMetadataResult> source = this.configImportActionExtensions.Select<IConfigImportActionExtension, IReadMetadataResult>((Func<IConfigImportActionExtension, IReadMetadataResult>) (e => (IReadMetadataResult) ConfigurationImportExecutor.\u003C\u003Ec__DisplayClass93_0.TNpcsg8OzMXKQ9TGyNen((object) e, (object) parameters, isTestRead1)));
      // ISSUE: reference to a compiler-generated field
      Func<IReadMetadataResult, bool> func = ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__93_1;
      Func<IReadMetadataResult, bool> predicate;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        ConfigurationImportExecutor.\u003C\u003Ec.\u003C\u003E9__93_1 = predicate = (Func<IReadMetadataResult, bool>) (r => r != null);
      }
      else
        goto label_60;
label_58:
      return source.FirstOrDefault<IReadMetadataResult>(predicate);
label_60:
      predicate = func;
      goto label_58;
label_59:
      return readMetadataResult;
    }

    static ConfigurationImportExecutor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ConfigurationImportExecutor.RegularProperty = (string) ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-2138160520 ^ -2138390054);
            num = 3;
            continue;
          case 2:
            ConfigurationImportExecutor.hD9alfE3cxTo6Tnfy69c();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
            continue;
          case 3:
            ConfigurationImportExecutor.XmlProperty = z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521494652);
            num = 4;
            continue;
          case 4:
            ConfigurationImportExecutor.ImportLog = (EleWise.ELMA.Logging.ILogger) ConfigurationImportExecutor.pGiZqqE3z2nY8LZD6YWD(ConfigurationImportExecutor.NUn1HRE1nboQISCQgj1B(-1487388570 ^ -1487092808));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    internal static bool FANZfME1I8C8VZ6YVovO() => ConfigurationImportExecutor.hMiB5FE1uQm4WfVepvcS == null;

    internal static ConfigurationImportExecutor nbPBStE1Va2j339T5FtE() => ConfigurationImportExecutor.hMiB5FE1uQm4WfVepvcS;

    internal static object U5UHMaE1S4JqtTam5itl([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).BPMAppManifest;

    internal static object GvRGdQE1iuAiuxD2PxRf([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

    internal static object mnstkKE1RmbkZ8XHtSpt() => (object) CallContextSessionOwner.Create();

    internal static void xqZoL9E1ql5fDD155gNy([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunBySystemUser((System.Action) obj1);

    internal static void GH8iJvE1KjBtdq7Mib6q([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object U31rekE1XTLRckvqfYJR([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void jUdVKCE1TQNJBY9uYmb9([In] object obj0, [In] object obj1) => ((TestImportMessages) obj0).Text = (string) obj1;

    internal static void wt62WtE1k42GRNSw2qm3([In] object obj0, TestImportMessagesType value) => ((TestImportMessages) obj0).Type = value;

    internal static object NUn1HRE1nboQISCQgj1B(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void mpPoVWE1OsoeCdWeb6OT([In] object obj0, [In] object obj1, [In] object obj2) => ((EleWise.ELMA.Logging.ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object Ye6XkoE12l2wWmACTc0I([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void LHf4VrE1ediZPOJHUfPP([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static int h9ykD5E1Px7Gft1hHX4m([In] object obj0) => ((IImportSettings) obj0).ImportStep;

    internal static TestImportMessagesType yWhCiTE11R9j23tRJZIM([In] object obj0) => ((TestImportMessages) obj0).Type;

    internal static object Od4VdXE1NZR6dcJmVHKO([In] object obj0) => (object) ((TestImportMessages) obj0).Text;

    internal static object Ylt4G6E13n0iSBWhEp4K([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void Y2royjE1plb4gjxp3MMP([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Logging.ILogger) obj0).Info(obj1);

    internal static bool fagugcE1aZARwy0aBgiG([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool NWvLyhE1D9UIVRmgX9sH() => MetadataImportHelper.IsRestartNeeded();

    internal static bool xeCFBvE1tQFZShmibxRV([In] object obj0) => ((RunWithSoftDeletableService) obj0).Turned;

    internal static void CI84eLE1w15ESyMY8UaR([In] object obj0, bool value) => ((RunWithSoftDeletableService) obj0).Turned = value;

    internal static long NCSjPOE14LFcERlhbSPn([In] object obj0) => ((IRunImportParameters) obj0).SignedUserId;

    internal static object O2oXytE162AAMiZL2QmT([In] object obj0) => (object) ((IConfigImportSettings) obj0).FileName;

    internal static object Y12gHtE1HlUGeXH6LxZY([In] object obj0, [In] object obj1) => (object) ((IExportImportFileManager) obj0).CreateZipFileName((string) obj1);

    internal static bool jgeG7iE1AJJVuAtTxp9u([In] object obj0) => File.Exists((string) obj0);

    internal static object IqRtZhE17pn25i9D9fqG([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Title;

    internal static object i9i9roE1xW3lOWfH6muS([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Version;

    internal static ElmaStoreComponentActivationType CFAxwhE10s00iyrA5l0u([In] object obj0) => ((ElmaStoreComponentManifest) obj0).ActivationType;

    internal static object wvWV5EE1m0sGgDNVcSf3([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IZipService) obj0).ExtractZipFolder((string) obj1, (string) obj2);

    internal static object MlNMGBE1y8ECm86WgVkD() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static object CJiYGKE1M9HgOO5j0vIa([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object LDpLgeE1J1pKeCQ2WwM1(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((IExportImportFileManager) obj0).CreateFileName((string) obj1, (string) obj2, (string) obj3);
    }

    internal static object dYeXvrE19eZSUKAbx1sd([In] object obj0, [In] object obj1) => (object) ((IExportImportFileManager) obj0).CreateFileName((string) obj1);

    internal static CancellationToken hb8IciE1dPjQVL0HJ6Vx([In] object obj0) => ((IRunImportParameters) obj0).CancellationToken;

    internal static void Djk57qE1lBxyJ81fVK0Z([In] object obj0) => ((PackageService) obj0).CheckInitialized();

    internal static bool u1lVu1E1rkXXYmfryECy([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object Qv8oHUE1ge6GYP1mkdeN([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object UODdpwE15Qf06297AiTd([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Guid dXVsmmE1jF2iJ9LaQlCe() => Guid.NewGuid();

    internal static void ay0gPXE1YTK4wbO5QyYJ([In] object obj0, [In] object obj1) => ((DeployLogMessage) obj0).InstallInfo = (PackageInstallInfo) obj1;

    internal static bool aHWlqJE1LYQIoxkGNkvB([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object zmwHRHE1UslqZB4OAIKq([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static bool RmoLaAE1sJvsY73orXow([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool WaSmnAE1cpYU3LOfjiR7([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static XmlNodeType WFMAx6E1zDIJWZIkcCR2([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    internal static void qPNZx7ENFAG8vQyPD8WG([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static XmlNodeType u8mPV3ENBOqyjN9FPD2H([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static void xQ7nFOENWZ1yyIBkqRi4([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Logging.ILogger) obj0).Error(obj1);

    internal static bool hKO1JNENoXjLkkOJaRkc([In] object obj0, [In] object obj1) => ((XmlReader) obj0).MoveToAttribute((string) obj1);

    internal static bool xfWXwXENbk9MHTq6ErLw([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object bvLSv2ENhtbgyyFsrZvn([In] object obj0, [In] object obj1) => (object) ((XmlReader) obj0).GetAttribute((string) obj1);

    internal static bool qlGUxwENGSOyZXd6OKWI([In] object obj0) => ((XmlReader) obj0).Read();

    internal static bool dTs50nENEjlYgpFBoeKx([In] object obj0, [In] object obj1) => ((XmlReader) obj0).ReadToNextSibling((string) obj1);

    internal static object XMrkgmENfovAAtbNS0Bw([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static bool xZ06MUENQJVAH6dS5LZK([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static bool X15jF8ENCq9JFFU7mBYM([In] object obj0, [In] object obj1, [In] object obj2) => ((PacketVersionService) obj0).Check((string) obj1, (string) obj2);

    internal static object AQbKojENvtPqGhFGxYCO([In] object obj0) => (object) ((List<long>) obj0).ToArray();

    internal static void dyhjy5EN8VoqkehOYLQ1([In] object obj0) => ((System.Action) obj0)();

    internal static int pKSQRRENZbYQwtPx8LrK([In] object obj0) => ((List<string>) obj0).Count;

    internal static object N88uShENuPBCoL2TD8ZG([In] object obj0, [In] object obj1) => (object) ((IExportImportFileManager) obj0).CreateFolderName((string) obj1);

    internal static object Jax2EbENI7Y1CXYVG1TO([In] object obj0, [In] object obj1) => (object) ((IExportImportFileManager) obj0).CreateDeployFolderName((string) obj1);

    internal static object pNvvJOENVWNs5ykXnIr8([In] object obj0) => (object) ((ComponentManager) obj0).LicenseManager;

    internal static object wCVyoYENSJwxquCkdonA([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static object aJKWvhENiAaPdhKQ1Tw8([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

    internal static object CYvTT4ENRegxpcoT0NOp([In] object obj0, [In] object obj1) => (object) ((BPMAppManager) obj0).LoadOrNull((string) obj1);

    internal static bool rWCV4XENqkuvYHfu1rRG([In] object obj0) => ((IBPMApp) obj0).Installed;

    internal static object CxSgSmENKwdloll3Eqod([In] object obj0) => (object) ((IConfigImportSettings) obj0).Manifest;

    internal static object uv1b8RENXhA4k0buxlZA([In] object obj0) => (object) ((IConfigImportSettings) obj0).FakeManifest;

    internal static object amDNUqENT4CF9WJPsTDh() => (object) ComponentManager.Current;

    internal static void ihtwXOENktR85X0E4iHC([In] object obj0, [In] object obj1) => ((ModuleDTO) obj0).Title = (string) obj1;

    internal static void uANHrPENnIE3IMkMuXml([In] object obj0, [In] object obj1) => ((ModuleDTO) obj0).Version = (string) obj1;

    internal static object e59JbAENOXg0vVwqR4kb([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Description;

    internal static object bAL107EN2FfD6UDXUcIG([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Author;

    internal static void QMlTFpENeSh5rkwGxD0U([In] object obj0, [In] object obj1) => ((ModuleDTO) obj0).Author = (string) obj1;

    internal static void q5iAW0ENPtJmnbMGvfd7([In] object obj0, Guid value) => ((TestImportMessages) obj0).UserActionType = value;

    internal static void IFB9vrEN1cmMT8UtGtog([In] object obj0, [In] object obj1) => ((TestImportMessages) obj0).AditionalData = obj1;

    internal static Guid ob5fH5ENNFxkORnDxB5L([In] object obj0, [In] object obj1) => ((ILicenseManager) obj0).AddActivationKey((string) obj1);

    internal static object w3Hq0YEN31mFVeXGtS6c([In] object obj0) => (object) ((PackageService) obj0).Settings;

    internal static object sQhYdaENpjrxWDDtmkLv([In] object obj0) => (object) FSTransaction.Create((string) obj0);

    internal static void R23cfsENaQGrCoLhCNwv([In] object obj0, bool value) => ((TestImportMessages) obj0).NeedInstallPackages = value;

    internal static int cO4itPEND26uBMYY4Xs3([In] object obj0) => ((List<ModuleDTO>) obj0).Count;

    internal static object VWELw0ENtJ0y07IMwnop([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static object vYexWXENwcwtw6XarFq3() => (object) GlobalScriptModuleHeaderManager.Instance;

    internal static object rvE8WJEN4mZfQBu0yf1P() => (object) MetadataServiceContext.Service;

    internal static Guid O2TnhEEN6x3KU9P2j2aS([In] object obj0) => Guid.Parse((string) obj0);

    internal static bool G6IvObENHaDGXd3JNhNm([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool Kdm5EqENAXdSMui2cTaL([In] object obj0, [In] object obj1) => ((XmlReader) obj0).ReadToFollowing((string) obj1);

    internal static int r9oW4AEN7HSk5JJgMoq0([In] object obj0) => ((List<IReadMetadataResult>) obj0).Count;

    internal static Guid GcF7yXENxNLhroPmfDBc([In] object obj0) => ((XNodeWrapper) obj0).GetTypeUid();

    internal static int cjH4cTEN0fYhlHDoay6K([In] object obj0) => ((List<IEntityImportSaveActions>) obj0).Count;

    internal static object Sdl6aMENmVGGrvXFIkq6([In] object obj0) => (object) ((XNodeWrapper) obj0).GetXmlReader();

    internal static object Xywa7SENyRkpFZJniOQK([In] object obj0) => (object) ((TextReader) obj0).ReadLine();

    internal static object jIhUSpENMwCI2UuJor2X([In] object obj0) => (object) BitConverter.ToString((byte[]) obj0);

    internal static object DwYPyeENJMBlG19Nl9wm([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool gDL7WbEN9nUHcnxq7pGd([In] object obj0, [In] object obj1) => string.Equals((string) obj0, (string) obj1);

    internal static void VEOkEdENdZIh7FNhP5g6([In] object obj0, [In] object obj1, [In] object obj2) => ((EleWise.ELMA.Logging.ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static bool Lhmt1VENl6iH7SZeC8q6([In] object obj0) => ((DeployLogMessage) obj0).EndStage;

    internal static bool LjGLl0ENrhWxVqQkuvB3([In] object obj0) => ((DeployLogMessage) obj0).EndProcess;

    internal static object YUlnlPENgwog33tJmm77([In] object obj0) => (object) ((ConfigImportSettings) obj0).FileName;

    internal static object WnElerEN52wUNLnne5ls([In] object obj0) => (object) ((XmlReader) obj0).ReadString();

    internal static void mfQ9rOENjCvUksk7HY2H([In] object obj0, [In] object obj1, [In] object obj2, Guid uid) => ((IExportImportFileManager) obj0).LoadFileToCache((string) obj1, (string) obj2, uid);

    internal static bool YJcXStENYHAJ5JquIdba([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object D4A8O3ENLH2xyKgfYmjC([In] object obj0) => (object) ((ISystemImportSettings) obj0).FileText;

    internal static object MpC2ypENUEqLFvj8TIo2([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool WfRkM4ENsNuDGjKyu6us([In] object obj0) => Directory.Exists((string) obj0);

    internal static object ySXa4YENcYfIMRLeSA9k([In] object obj0, [In] object obj1) => (object) Directory.GetFiles((string) obj0, (string) obj1);

    internal static object QWrRChENzCMMs9wwEEqI([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static object ynrRI4E3FQTH8nXqOERZ([In] object obj0) => (object) ((PackageService) obj0).LocalRepositoryPath;

    internal static void nMEpdpE3BJjvSArRdtHY([In] object obj0, [In] object obj1, [In] bool obj2) => File.Copy((string) obj0, (string) obj1, obj2);

    internal static object DSkm0rE3WOOlQmiPGhdr([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void ffg59cE3oNxWKmNKvRZW([In] object obj0, [In] PackageOperationType obj1) => ((PackageOperationInfo) obj0).Type = obj1;

    internal static void vDZinIE3bBM72FviGJOu([In] object obj0, [In] object obj1) => ((PackageOperationInfo) obj0).InstalledVersion = (SemanticVersion) obj1;

    internal static object zkdhuIE3hEJ98JPK6N2i() => (object) VersionInfo.GetEdition();

    internal static void hWGvmDE3Gn4BXgHlN8qf([In] object obj0, [In] object obj1) => ((ImportLicenseInfo) obj0).Version = (string) obj1;

    internal static void XdBoeSE3EI4WaVJcU2WF([In] object obj0, bool value) => ((ImportLicenseInfo) obj0).CanAddActivationKey = value;

    internal static object rYnyfnE3fUT39boDCsoh([In] object obj0) => (object) ((IModuleManager) obj0).MainLicensedUnit;

    internal static object lMV2FKE3Qkd7fiCHkdG5([In] object obj0, [In] object obj1) => (object) ((ILicenseManager) obj0).GetRegistrationKey((ILicensedUnit) obj1);

    internal static void l4EUDBE3CDYQuLHm1YDb([In] object obj0, [In] object obj1) => ((ImportLicenseInfo) obj0).RegistrationKey = (string) obj1;

    internal static object pr84xXE3vuSplVKaukch([In] object obj0) => (object) ((ILicensedUnit) obj0).GetLicenseInfo();

    internal static object s37kPhE38cDpKS0QOlgh([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object EVt4lWE3Z4jgF3siVdxl([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static int l2HdSBE3uOQkOJJrUlJc([In] object obj0) => ((string) obj0).Length;

    internal static void zr3ISrE3IwRcJKpkincc([In] object obj0, [In] object obj1) => ((ImportLicenseInfo) obj0).ActivationToken = (string) obj1;

    internal static bool u1VlwfE3Vvv6XXFy4qS1([In] object obj0) => ((IConcurrentLicenseInfo) obj0).IsConcurrent;

    internal static void StI3d3E3SWdqBuG1CPIC([In] object obj0, Guid value) => ((ImportLicenseInfo) obj0).PrivilegeAccessGroupUid = value;

    internal static void cZTH1AE3if7RDq5QyRyr([In] object obj0, [In] object obj1) => ((ImportLicenseInfo) obj0).LicenseCountTitle = (string) obj1;

    internal static void R4vjBiE3RKMMkkWchZj5([In] object obj0, [In] object obj1) => ((ImportLicenseInfo) obj0).LicenseCount = (string) obj1;

    internal static void RVA8ZXE3q5etZY4wu2Ic([In] object obj0, [In] object obj1) => ((ImportLicenseInfo) obj0).UsedLicenseCount = (string) obj1;

    internal static void u2JQ8TE3KuLB5woTtuJt([In] object obj0, bool value) => ((ImportLicenseInfo) obj0).IsConcurrent = value;

    internal static bool WDeirNE3XThVD53aYsxc([In] object obj0) => ((ImportLicenseInfo) obj0).IsConcurrent;

    internal static void yrJLSXE3Tq7N8OjOjMaQ([In] object obj0, [In] object obj1) => ((ImportLicenseInfo) obj0).PrivilegeLicenseCountTitle = (string) obj1;

    internal static void egd75hE3kwOaGVV31E1g([In] object obj0, [In] object obj1) => ((ImportLicenseInfo) obj0).PrivilegeLicenseCount = (string) obj1;

    internal static object h76qnTE3n6upSqpSRemL() => (object) IOExtensions.GetTempFileNameWithoutExtension();

    internal static void DaxF0tE3OVCDogElUtYY([In] object obj0, [In] object obj1) => ((AppDomainSetup) obj0).ApplicationBase = (string) obj1;

    internal static void RD6G2IE32tZ6WWHB8i0j([In] object obj0, [In] object obj1) => ((AppDomainSetup) obj0).PrivateBinPath = (string) obj1;

    internal static object iU4RPvE3eAKMa1rA7U2n([In] object obj0) => (object) ((AppDomain) obj0).SetupInformation;

    internal static object au5T1vE3PTKkl3bxBXUX([In] object obj0) => (object) ((AppDomainSetup) obj0).ConfigurationFile;

    internal static void HECWolE31lnxxLyYETPX([In] object obj0, [In] object obj1) => ((AppDomainSetup) obj0).ConfigurationFile = (string) obj1;

    internal static object gwQA1rE3Nndgi8YrEZwR() => (object) AppDomain.CurrentDomain;

    internal static object lAe3WQE33xfUgRiWYcWJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) AppDomain.CreateDomain((string) obj0, (Evidence) obj1, (AppDomainSetup) obj2);

    internal static object elHtqlE3pQ6pj78tTVYN([In] object obj0) => (object) ((AppDomain) obj0).BaseDirectory;

    internal static void YfBbJ6E3aI5nH4HXCxZr([In] object obj0, [In] object obj1) => File.Copy((string) obj0, (string) obj1);

    internal static bool uGbiumE3DIEDV0IQ2XG6() => Environment.Is64BitProcess;

    internal static void ykVT3tE3tC790lhiga1q([In] object obj0, [In] object obj1) => FileUtils.CopyDirectory((string) obj0, (string) obj1);

    internal static Type LgMvBTE3wmR5Qgx3LDlf([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object VCxQFAE34XEFFvJrSBnh([In] object obj0) => (object) ((Assembly) obj0).FullName;

    internal static object GhuDecE36Ef9966UwSEM([In] object obj0, [In] object obj1, [In] object obj2) => ((AppDomain) obj0).CreateInstanceAndUnwrap((string) obj1, (string) obj2);

    internal static object LuuQQsE3H65RBk43bu5R([In] object obj0) => (object) ((ZipFile) obj0).GetEnumerator();

    internal static object cfnLh1E3Af4PkqaALQgI([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static bool qGCeklE37t6LGeQZCmEi([In] object obj0) => ((ZipEntry) obj0).IsFile;

    internal static object MF5xjiE3xPNOhdufWexb([In] object obj0) => (object) ((ZipEntry) obj0).Name;

    internal static bool geSxO0E30misVx4Vt1O4([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static object u5VA1xE3mog8Xu1wLQiS([In] object obj0) => (object) EleWise.ELMA.Extensions.StreamExtensions.ReadAllBytes((Stream) obj0);

    internal static void MBc4XVE3yDTVXnZtSs9B([In] object obj0, [In] object obj1) => File.WriteAllBytes((string) obj0, (byte[]) obj1);

    internal static object mNa1uSE3Mt801gueBUO4([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static void YcQHh2E3JrCY30spO8BU([In] object obj0) => ((ZipFile) obj0).Close();

    internal static object nHIVMlE39gmKKIKiBkve([In] object obj0) => (object) ((System.Configuration.Configuration) obj0).FilePath;

    internal static void ISNyWuE3dTLeOKZTw7bt([In] object obj0, [In] object obj1) => ((ImportAssemblyLoader) obj0).InitComponentManager((string) obj1);

    internal static void w21D29E3lpbE9qfnZWe5([In] object obj0) => AppDomain.Unload((AppDomain) obj0);

    internal static void I1XIjTE3rnu3hFXIYVS5([In] object obj0, [In] bool obj1) => Directory.Delete((string) obj0, obj1);

    internal static int xs3IY4E3gagKtaDBRDsN([In] object obj0) => ((List<ConfigurationImportExecutor.ImportantDataClass>) obj0).Count;

    internal static object gbAjsZE35XTpSPuhb4Ji([In] object obj0) => (object) ((XmlReader) obj0).Value;

    internal static bool pG0aarE3jtcrZQvAaRpl([In] object obj0) => ((XmlReader) obj0).MoveToNextAttribute();

    internal static int LWLaFGE3YKC3tacalwLC([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static Type p3aaDkE3LJCUmSmwFnp4([In] object obj0) => Type.GetType((string) obj0);

    internal static object QppVMhE3U3kqyr85inJF([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static object mH9gipE3sSBJNLUNY90m([In] object obj0, [In] object obj1) => (object) ((IPostEntityXmlSerializer) obj0).UndoReplace((string) obj1);

    internal static void hD9alfE3cxTo6Tnfy69c() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object pGiZqqE3z2nY8LZD6YWD([In] object obj0) => (object) EleWise.ELMA.Logging.Logger.GetLogger((string) obj0);

    internal static void tIfLGbEpFRVa2bFp3Zij([In] object obj0, [In] object obj1) => ((IConfigImportExtension) obj0).OnPreStartImport((PreStartImportParameters) obj1);

    internal static object sScEJBEpBDW6U2w2MX2Z([In] object obj0) => (object) ((PackageManifest) obj0).Id;

    internal static void popfIhEpWM61FuX4KaTF([In] object obj0, [In] object obj1) => ((IConfigImportActionExtension) obj0).OnPrePublish((PrePublishParameters) obj1);

    internal static void nKImFUEpo4E81h5qigGH([In] object obj0, [In] object obj1) => ((IConfigImportExtension) obj0).OnImportSuccessfull((ImportSuccessfullParameters) obj1);

    private class ReadPacketResult
    {
      private readonly object executor;
      private readonly object contentType;
      private readonly ICollection<(Dictionary<string, Dictionary<string, object>>, EntityMetadata, Type)> entitiesValues;
      private readonly ICollection<(IReadMetadataResult ReadMetadataResult, bool IsSystemMd)> readMetadataResults;
      private readonly IDictionary<string, string> packetData;
      internal static object vpNLbH8kNNLaKk3aej4i;

      public ReadPacketResult(
        ConfigurationImportExecutor executor,
        XmlReader reader,
        string contentType,
        string serverFolderName)
      {
        ConfigurationImportExecutor.ReadPacketResult.koay8P8kaNpH0fCKvclM();
        this.entitiesValues = (ICollection<(Dictionary<string, Dictionary<string, object>>, EntityMetadata, Type)>) new List<(Dictionary<string, Dictionary<string, object>>, EntityMetadata, Type)>();
        this.readMetadataResults = (ICollection<(IReadMetadataResult, bool)>) new List<(IReadMetadataResult, bool)>();
        this.packetData = (IDictionary<string, string>) new Dictionary<string, string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num1 = 18;
        while (true)
        {
          int num2 = num1;
          string str;
          (Dictionary<string, Dictionary<string, object>> propValues, EntityMetadata metadata, Type type) tuple;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 19:
                tuple = this.ReadEntity(reader);
                num2 = 24;
                continue;
              case 2:
              case 8:
              case 29:
              case 32:
              case 36:
                ConfigurationImportExecutor.ReadPacketResult.fYKtSr8kAwmGvuSqSdP4((object) reader);
                num2 = 16;
                continue;
              case 3:
                if (!ConfigurationImportExecutor.ReadPacketResult.Ndpqrk8k6SkM17rgk43X((object) reader))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                  continue;
                }
                goto case 2;
              case 4:
                if (ConfigurationImportExecutor.ReadPacketResult.fBhsQb8k4qIxjcqlogVN((object) str, ConfigurationImportExecutor.ReadPacketResult.PRH1KZ8kwRVnUxUgYDZ5(-606654180 ^ -606900464)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
                  continue;
                }
                goto case 5;
              case 5:
                if (!(str == (string) ConfigurationImportExecutor.ReadPacketResult.PRH1KZ8kwRVnUxUgYDZ5(-542721635 ^ -542980725)))
                {
                  num2 = 37;
                  continue;
                }
                goto case 30;
              case 6:
              case 7:
                if (ConfigurationImportExecutor.ReadPacketResult.bdYSFW8k7VwgXRwG3PMP((object) reader) == XmlNodeType.EndElement)
                {
                  num2 = 13;
                  continue;
                }
                goto case 33;
              case 9:
              case 14:
              case 15:
              case 16:
              case 27:
              case 35:
                int content = (int) reader.MoveToContent();
                num2 = 6;
                continue;
              case 10:
                ICollection<(IReadMetadataResult, bool)> readMetadataResults = this.readMetadataResults;
                IEnumerable<IReadMetadataResult> source = executor.ReadMetadataBlock(reader, false, serverFolderName);
                // ISSUE: reference to a compiler-generated field
                Func<IReadMetadataResult, (IReadMetadataResult, bool)> func = ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec.\u003C\u003E9__5_1;
                Func<IReadMetadataResult, (IReadMetadataResult, bool)> selector;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec.\u003C\u003E9__5_1 = selector = (Func<IReadMetadataResult, (IReadMetadataResult, bool)>) (r => (r, false));
                }
                else
                  goto label_45;
label_44:
                IEnumerable<(IReadMetadataResult, bool)> items = source.Select<IReadMetadataResult, (IReadMetadataResult, bool)>(selector);
                readMetadataResults.AddRange<(IReadMetadataResult, bool)>(items);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 3 : 9;
                continue;
label_45:
                selector = func;
                goto label_44;
              case 11:
                goto label_10;
              case 12:
                this.readMetadataResults.AddRange<(IReadMetadataResult, bool)>(executor.ReadMetadataBlock(reader, true, serverFolderName).Select<IReadMetadataResult, (IReadMetadataResult, bool)>((Func<IReadMetadataResult, (IReadMetadataResult, bool)>) (r => (r, true))));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 12 : 27;
                continue;
              case 13:
                if (executor.step != ImportStep.ImportMetadata)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 21 : 12;
                  continue;
                }
                goto label_39;
              case 17:
                this.entitiesValues.Add(tuple);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 35 : 12;
                continue;
              case 18:
                this.executor = (object) executor;
                num2 = 25;
                continue;
              case 20:
                if (!ConfigurationImportExecutor.ReadPacketResult.fBhsQb8k4qIxjcqlogVN((object) str, ConfigurationImportExecutor.ReadPacketResult.PRH1KZ8kwRVnUxUgYDZ5(993438473 ^ 993214921)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 29 : 9;
                  continue;
                }
                goto label_16;
              case 21:
                this.Process();
                num2 = 31;
                continue;
              case 22:
                goto label_16;
              case 23:
                ConfigurationImportExecutor.ReadPacketResult.caj3358kHcYY8aMQT5rh((object) reader);
                num2 = 15;
                continue;
              case 24:
                if (tuple.propValues != null)
                {
                  num2 = 17;
                  continue;
                }
                goto case 9;
              case 25:
                this.contentType = (object) contentType;
                num2 = 7;
                continue;
              case 26:
                str = (string) ConfigurationImportExecutor.ReadPacketResult.LaQt8C8ktxSUdw89ibM3((object) reader);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 25 : 28;
                continue;
              case 28:
                if (str != null)
                  goto case 4;
                else
                  goto label_32;
              case 30:
                if (ConfigurationImportExecutor.ReadPacketResult.Ndpqrk8k6SkM17rgk43X((object) reader))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 2;
                  continue;
                }
                goto case 34;
              case 31:
                goto label_42;
              case 33:
                if (!ConfigurationImportExecutor.ReadPacketResult.BtCUdd8kDDmeGtyL8Gev((object) reader))
                {
                  num2 = 14;
                  continue;
                }
                goto case 26;
              case 34:
                ConfigurationImportExecutor.ReadPacketResult.caj3358kHcYY8aMQT5rh((object) reader);
                num2 = 12;
                continue;
              case 37:
                if (!(str == (string) ConfigurationImportExecutor.ReadPacketResult.PRH1KZ8kwRVnUxUgYDZ5(-680446928 - -370807692 ^ -309380026)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 4 : 20;
                  continue;
                }
                goto case 3;
              default:
                ConfigurationImportExecutor.ReadPacketResult.caj3358kHcYY8aMQT5rh((object) reader);
                num2 = 10;
                continue;
            }
          }
label_10:
          executor.ReadDictionary(reader, this.packetData);
          num1 = 23;
          continue;
label_16:
          if (ConfigurationImportExecutor.ReadPacketResult.Ndpqrk8k6SkM17rgk43X((object) reader))
          {
            num1 = 32;
            continue;
          }
          goto label_10;
label_32:
          num1 = 8;
        }
label_42:
        return;
label_39:;
      }

      public IEnumerable<IMetadata> Metadatas => this.readMetadataResults.Where<(IReadMetadataResult, bool)>((Func<(IReadMetadataResult, bool), bool>) (r => !r.IsSystemMd)).Select<(IReadMetadataResult, bool), IMetadata>((Func<(IReadMetadataResult, bool), IMetadata>) (r => r.ReadMetadataResult.Metadata));

      /// <summary>Проверить и сохранить метаданные</summary>
      public void Process()
      {
        int num1 = 6;
        while (true)
        {
          int num2 = num1;
          IUser user;
          ConfigurationImportExecutor.ReadPacketResult readPacketResult;
          bool isBadRule;
          bool needInterrupt;
          string isException;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_3;
              case 2:
                System.Action action;
                ConfigurationImportExecutor.ReadPacketResult.KGbyRg8k0peOJ190OOkv((object) ((ConfigurationImportExecutor) this.executor).securityService, (object) user, (object) (System.Action) (() =>
                {
                  int num31 = 1;
                  while (true)
                  {
                    switch (num31)
                    {
                      case 0:
                        goto label_4;
                      case 1:
                        ISecurityService securityService = ((ConfigurationImportExecutor) readPacketResult.executor).securityService;
                        System.Action action1 = action;
                        System.Action action2 = action1 == null ? (action = (System.Action) (() =>
                        {
                          int num32 = 5;
                          IEnumerator<IPacketActions> enumerator6;
                          IUnitOfWork unitOfWork3;
                          IUnitOfWork unitOfWork4;
                          bool flag;
                          List<Exception> exceptionList;
                          Dictionary<IEntity, Exception> packet;
                          ISession session;
                          while (true)
                          {
                            switch (num32)
                            {
                              case 1:
                                unitOfWork3 = ((ConfigurationImportExecutor) readPacketResult.executor).unitOfWorkManager.Create(string.Empty, true);
                                num32 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 5 : 9;
                                continue;
                              case 2:
                                exceptionList = new List<Exception>();
                                num32 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                                continue;
                              case 3:
                                try
                                {
                                  try
                                  {
                                    ConfigurationImportExecutor.ImportLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853236184));
                                    int num33 = 26;
                                    IEnumerator<(IReadMetadataResult, bool)> enumerator7;
                                    List<Exception>.Enumerator enumerator8;
                                    Dictionary<IEntity, Exception>.Enumerator enumerator9;
                                    IEnumerator<(Dictionary<string, Dictionary<string, object>>, EntityMetadata, Type)> enumerator10;
                                    while (true)
                                    {
                                      switch (num33)
                                      {
                                        case 1:
                                          enumerator9 = packet.GetEnumerator();
                                          num33 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 9 : 0;
                                          continue;
                                        case 2:
                                          ICollection<(IReadMetadataResult, bool)> readMetadataResults3 = readPacketResult.readMetadataResults;
                                          // ISSUE: reference to a compiler-generated field
                                          Func<(IReadMetadataResult, bool), bool> func3 = ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec.\u003C\u003E9__8_3;
                                          Func<(IReadMetadataResult, bool), bool> predicate3;
                                          if (func3 == null)
                                          {
                                            // ISSUE: reference to a compiler-generated field
                                            ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec.\u003C\u003E9__8_3 = predicate3 = (Func<(IReadMetadataResult, bool), bool>) (r => r.IsSystemMd);
                                          }
                                          else
                                            goto label_75;
label_191:
                                          enumerator7 = readMetadataResults3.Where<(IReadMetadataResult, bool)>(predicate3).GetEnumerator();
                                          num33 = 5;
                                          continue;
label_75:
                                          predicate3 = func3;
                                          goto label_191;
                                        case 3:
                                          goto label_120;
                                        case 4:
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.uy8BRjZ2W58EQ7FXe97e((object) unitOfWork4);
                                          num33 = 24;
                                          continue;
                                        case 5:
                                          try
                                          {
label_64:
                                            // ISSUE: reference to a compiler-generated method
                                            if (ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.J5VEhUZOj0XwGxNPFl4Y((object) enumerator7))
                                              goto label_76;
                                            else
                                              goto label_65;
label_63:
                                            (IReadMetadataResult, bool) current;
                                            int num34;
                                            switch (num34)
                                            {
                                              case 1:
                                                goto label_76;
                                              case 2:
                                                try
                                                {
                                                  if (current.Item1.TestMetadata())
                                                  {
                                                    int num35 = 0;
                                                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
                                                      num35 = 0;
                                                    while (true)
                                                    {
                                                      switch (num35)
                                                      {
                                                        case 1:
                                                          goto label_64;
                                                        default:
                                                          // ISSUE: reference to a compiler-generated method
                                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.f0oiOHZO5Z6NEbBAU28w((object) current.Item1);
                                                          num35 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
                                                          continue;
                                                      }
                                                    }
                                                  }
                                                  else
                                                    goto label_64;
                                                }
                                                catch (Exception ex)
                                                {
                                                  int num36 = 1;
                                                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
                                                    num36 = 1;
                                                  while (true)
                                                  {
                                                    switch (num36)
                                                    {
                                                      case 1:
                                                        exceptionList.Add(ex);
                                                        num36 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
                                                        continue;
                                                      default:
                                                        goto label_64;
                                                    }
                                                  }
                                                }
                                              case 3:
                                                goto label_64;
                                              default:
                                                goto label_86;
                                            }
label_65:
                                            num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                                            goto label_63;
label_76:
                                            current = enumerator7.Current;
                                            num34 = 2;
                                            goto label_63;
                                          }
                                          finally
                                          {
                                            if (enumerator7 != null)
                                            {
                                              int num37 = 0;
                                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                                                num37 = 0;
                                              while (true)
                                              {
                                                switch (num37)
                                                {
                                                  case 1:
                                                    goto label_82;
                                                  default:
                                                    enumerator7.Dispose();
                                                    num37 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
                                                    continue;
                                                }
                                              }
                                            }
label_82:;
                                          }
                                        case 6:
                                          goto label_207;
                                        case 7:
                                          try
                                          {
label_91:
                                            if (enumerator8.MoveNext())
                                              goto label_97;
                                            else
                                              goto label_92;
label_90:
                                            Exception current;
                                            int num38;
                                            while (true)
                                            {
                                              string text;
                                              object obj;
                                              switch (num38)
                                              {
                                                case 1:
                                                  goto label_57;
                                                case 2:
                                                  goto label_91;
                                                case 3:
                                                  goto label_97;
                                                case 4:
                                                  ((ConfigurationImportExecutor) readPacketResult.executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, text, false));
                                                  num38 = 2;
                                                  continue;
                                                case 5:
                                                  // ISSUE: reference to a compiler-generated method
                                                  obj = ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.GNJT1lZOr8Ruw9jOdHCq((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217904735));
                                                  break;
                                                case 6:
                                                  if (current == null)
                                                  {
                                                    num38 = 5;
                                                    continue;
                                                  }
                                                  goto default;
                                                default:
                                                  // ISSUE: reference to a compiler-generated method
                                                  obj = ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.mCT63QZOsscorb5oXdiJ((object) current);
                                                  break;
                                              }
                                              text = (string) obj;
                                              num38 = 4;
                                            }
label_92:
                                            num38 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
                                            goto label_90;
label_97:
                                            current = enumerator8.Current;
                                            num38 = 6;
                                            goto label_90;
                                          }
                                          finally
                                          {
                                            enumerator8.Dispose();
                                            int num39 = 0;
                                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
                                              num39 = 0;
                                            switch (num39)
                                            {
                                              default:
                                            }
                                          }
                                        case 8:
                                        case 23:
label_124:
                                          if (flag)
                                          {
                                            num33 = 28;
                                            continue;
                                          }
                                          goto case 16;
                                        case 9:
                                          try
                                          {
label_131:
                                            if (enumerator9.MoveNext())
                                              goto label_137;
                                            else
                                              goto label_132;
label_128:
                                            KeyValuePair<IEntity, Exception> current;
                                            int num40;
                                            while (true)
                                            {
                                              string text;
                                              int num41;
                                              string str;
                                              switch (num40)
                                              {
                                                case 1:
                                                  num41 = current.Value == null ? 1 : 0;
                                                  break;
                                                case 2:
                                                  if (current.Value == null)
                                                  {
                                                    num40 = 8;
                                                    continue;
                                                  }
                                                  goto case 7;
                                                case 3:
                                                  ((ConfigurationImportExecutor) readPacketResult.executor).savedPacketEntities.Add(current.Key);
                                                  num40 = 4;
                                                  continue;
                                                case 4:
                                                  if (flag)
                                                  {
                                                    num40 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
                                                    continue;
                                                  }
                                                  num41 = 0;
                                                  break;
                                                case 5:
                                                  goto label_137;
                                                case 6:
                                                  // ISSUE: reference to a compiler-generated method
                                                  ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.a7B4RDZOgQyEKoxPpVvj(readPacketResult.executor, (object) new DeployLogMessage(DeployLogMessageType.Warn, text, false));
                                                  num40 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                                                  continue;
                                                case 7:
                                                  str = current.Value.Message;
                                                  goto label_146;
                                                case 8:
                                                  // ISSUE: reference to a compiler-generated method
                                                  str = EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.TMGZSvZOlrbJincoJej9(813604817 ^ 813216021));
                                                  goto label_146;
                                                case 9:
                                                  if (current.Value == null)
                                                  {
                                                    num40 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 11 : 5;
                                                    continue;
                                                  }
                                                  goto case 2;
                                                case 10:
                                                  goto label_124;
                                                default:
                                                  goto label_131;
                                              }
                                              flag = num41 != 0;
                                              num40 = 9;
                                              continue;
label_146:
                                              text = str;
                                              num40 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 5 : 6;
                                            }
label_132:
                                            num40 = 10;
                                            goto label_128;
label_137:
                                            current = enumerator9.Current;
                                            num40 = 0;
                                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                                            {
                                              num40 = 3;
                                              goto label_128;
                                            }
                                            else
                                              goto label_128;
                                          }
                                          finally
                                          {
                                            enumerator9.Dispose();
                                            int num42 = 0;
                                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
                                              num42 = 0;
                                            switch (num42)
                                            {
                                              default:
                                            }
                                          }
                                        case 10:
                                          try
                                          {
label_153:
                                            // ISSUE: reference to a compiler-generated method
                                            if (ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.J5VEhUZOj0XwGxNPFl4Y((object) enumerator10))
                                              goto label_158;
                                            else
                                              goto label_154;
label_152:
                                            (Dictionary<string, Dictionary<string, object>>, EntityMetadata, Type) current;
                                            int num43;
                                            while (true)
                                            {
                                              int num44;
                                              switch (num43)
                                              {
                                                case 1:
                                                  if (flag)
                                                  {
                                                    num43 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 4 : 0;
                                                    continue;
                                                  }
                                                  num44 = 0;
                                                  break;
                                                case 2:
                                                  goto label_158;
                                                case 3:
                                                  goto label_153;
                                                case 4:
                                                  num44 = readPacketResult.SaveEntity(current, (IDictionary<IEntity, Exception>) packet) ? 1 : 0;
                                                  break;
                                                default:
                                                  goto label_192;
                                              }
                                              flag = num44 != 0;
                                              num43 = 3;
                                            }
label_154:
                                            num43 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
                                            goto label_152;
label_158:
                                            current = enumerator10.Current;
                                            num43 = 0;
                                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                                            {
                                              num43 = 1;
                                              goto label_152;
                                            }
                                            else
                                              goto label_152;
                                          }
                                          finally
                                          {
                                            if (enumerator10 != null)
                                            {
                                              int num45 = 0;
                                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                                                num45 = 0;
                                              while (true)
                                              {
                                                switch (num45)
                                                {
                                                  case 1:
                                                    goto label_167;
                                                  default:
                                                    // ISSUE: reference to a compiler-generated method
                                                    ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.dxT2bRZOLjMMhAFcmETQ((object) enumerator10);
                                                    num45 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                                                    continue;
                                                }
                                              }
                                            }
label_167:;
                                          }
                                        case 11:
label_188:
                                          // ISSUE: reference to a compiler-generated method
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.LOStBOZ2BcK3NJaLyCYA((object) ConfigurationImportExecutor.ImportLog, ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.TMGZSvZOlrbJincoJej9(1461625753 ^ 1461228171));
                                          num33 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 4 : 2;
                                          continue;
                                        case 12:
                                          enumerator8 = exceptionList.GetEnumerator();
                                          num33 = 7;
                                          continue;
                                        case 13:
                                        case 15:
                                          flag = false;
                                          num33 = 12;
                                          continue;
                                        case 14:
                                          isBadRule = true;
                                          num33 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 2 : 3;
                                          continue;
                                        case 16:
                                          // ISSUE: reference to a compiler-generated method
                                          // ISSUE: reference to a compiler-generated method
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.a7B4RDZOgQyEKoxPpVvj(readPacketResult.executor, (object) new DeployLogMessage(DeployLogMessageType.Warn, (string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.GNJT1lZOr8Ruw9jOdHCq(ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.TMGZSvZOlrbJincoJej9(-1822890472 ^ -1822504694)), false));
                                          num33 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                                          continue;
                                        case 17:
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.a7B4RDZOgQyEKoxPpVvj(readPacketResult.executor, (object) new DeployLogMessage(DeployLogMessageType.Empty, "", false));
                                          num33 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 12 : 22;
                                          continue;
                                        case 18:
label_86:
                                          // ISSUE: reference to a compiler-generated method
                                          if (ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.K81buwZOY6YUaVi53I0s((object) exceptionList) != 0)
                                          {
                                            num33 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 15 : 0;
                                            continue;
                                          }
                                          goto case 25;
                                        case 19:
label_57:
                                          if (!flag)
                                          {
                                            num33 = 8;
                                            continue;
                                          }
                                          goto case 1;
                                        case 20:
label_192:
                                          ICollection<(IReadMetadataResult, bool)> readMetadataResults4 = readPacketResult.readMetadataResults;
                                          // ISSUE: reference to a compiler-generated field
                                          Func<(IReadMetadataResult, bool), bool> func4 = ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec.\u003C\u003E9__8_4;
                                          Func<(IReadMetadataResult, bool), bool> predicate4;
                                          if (func4 == null)
                                          {
                                            // ISSUE: reference to a compiler-generated field
                                            ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec.\u003C\u003E9__8_4 = predicate4 = (Func<(IReadMetadataResult, bool), bool>) (r => !r.IsSystemMd);
                                          }
                                          else
                                            goto label_222;
label_194:
                                          enumerator7 = readMetadataResults4.Where<(IReadMetadataResult, bool)>(predicate4).GetEnumerator();
                                          num33 = 27;
                                          continue;
label_222:
                                          predicate4 = func4;
                                          goto label_194;
                                        case 21:
                                          try
                                          {
label_170:
                                            // ISSUE: reference to a compiler-generated method
                                            if (ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.J5VEhUZOj0XwGxNPFl4Y((object) enumerator6))
                                              goto label_175;
                                            else
                                              goto label_171;
label_169:
                                            PacketActionArgs packetActionArgs;
                                            IPacketActions current;
                                            int num46;
                                            while (true)
                                            {
                                              switch (num46)
                                              {
                                                case 1:
                                                  // ISSUE: reference to a compiler-generated method
                                                  if (!ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.M9Gc6hZOc3XC6IcewrbQ((object) current, (object) packetActionArgs))
                                                  {
                                                    num46 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 4 : 7;
                                                    continue;
                                                  }
                                                  goto case 5;
                                                case 2:
                                                  goto label_175;
                                                case 3:
                                                  packetActionArgs = new PacketActionArgs(((ConfigurationImportExecutor) readPacketResult.executor).importSettings, (ICollection<IEntity>) ((ConfigurationImportExecutor) readPacketResult.executor).savedPacketEntities, (ICollection<DeployLogMessage>) ((ConfigurationImportExecutor) readPacketResult.executor).messages, (string) readPacketResult.contentType, readPacketResult.packetData, (IDictionary<string, string>) ((ConfigurationImportExecutor) readPacketResult.executor).serviceData);
                                                  num46 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
                                                  continue;
                                                case 4:
                                                  if (!needInterrupt)
                                                  {
                                                    num46 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 5 : 3;
                                                    continue;
                                                  }
                                                  goto label_179;
                                                case 5:
                                                  // ISSUE: reference to a compiler-generated method
                                                  ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.ihPSKHZ2FXyQcI1sgVi1((object) session);
                                                  num46 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 5 : 6;
                                                  continue;
                                                case 6:
                                                  goto label_170;
                                                case 7:
                                                  // ISSUE: reference to a compiler-generated method
                                                  needInterrupt = ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.tnP9DsZOzUp2Jyx9nLCu((object) current, (object) packetActionArgs, true);
                                                  num46 = 4;
                                                  continue;
                                                case 8:
                                                  goto label_188;
                                                default:
                                                  goto label_179;
                                              }
                                            }
label_179:
                                            throw new ConfigImportException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921320969), (object) current.GetType().FullName));
label_171:
                                            num46 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 8;
                                            goto label_169;
label_175:
                                            current = enumerator6.Current;
                                            num46 = 3;
                                            goto label_169;
                                          }
                                          finally
                                          {
                                            if (enumerator6 != null)
                                            {
                                              int num47 = 1;
                                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                                                num47 = 1;
                                              while (true)
                                              {
                                                switch (num47)
                                                {
                                                  case 1:
                                                    // ISSUE: reference to a compiler-generated method
                                                    ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.dxT2bRZOLjMMhAFcmETQ((object) enumerator6);
                                                    num47 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                                                    continue;
                                                  default:
                                                    goto label_186;
                                                }
                                              }
                                            }
label_186:;
                                          }
                                        case 22:
                                          enumerator6 = ((ConfigurationImportExecutor) readPacketResult.executor).packetActions.GetEnumerator();
                                          num33 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 7 : 21;
                                          continue;
                                        case 24:
                                          ((ConfigurationImportExecutor) readPacketResult.executor).AddMessage(new DeployLogMessage(BPMAppItemImportStatus.InProgress, Guid.Empty, ((ConfigurationImportExecutor) readPacketResult.executor).treeUid));
                                          num33 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 6 : 5;
                                          continue;
                                        case 25:
                                          enumerator10 = readPacketResult.entitiesValues.GetEnumerator();
                                          num33 = 10;
                                          continue;
                                        case 26:
                                          // ISSUE: reference to a compiler-generated method
                                          // ISSUE: reference to a compiler-generated method
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.a7B4RDZOgQyEKoxPpVvj(readPacketResult.executor, (object) new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.GNJT1lZOr8Ruw9jOdHCq(ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.TMGZSvZOlrbJincoJej9(-1921202237 ^ -1921324627)), false));
                                          num33 = 2;
                                          continue;
                                        case 27:
                                          try
                                          {
label_109:
                                            if (enumerator7.MoveNext())
                                              goto label_106;
                                            else
                                              goto label_110;
label_105:
                                            (IReadMetadataResult, bool) current;
                                            int num48;
                                            while (true)
                                            {
                                              switch (num48)
                                              {
                                                case 1:
                                                  goto label_57;
                                                case 2:
                                                  goto label_106;
                                                case 3:
                                                  // ISSUE: reference to a compiler-generated method
                                                  ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.f0oiOHZO5Z6NEbBAU28w((object) current.Item1);
                                                  num48 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                                                  continue;
                                                case 4:
                                                  // ISSUE: reference to a compiler-generated method
                                                  if (ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.Sx2xinZOU6YGUiainwO9((object) current.Item1))
                                                  {
                                                    num48 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 3 : 3;
                                                    continue;
                                                  }
                                                  goto label_109;
                                                default:
                                                  goto label_109;
                                              }
                                            }
label_106:
                                            current = enumerator7.Current;
                                            num48 = 3;
                                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
                                            {
                                              num48 = 4;
                                              goto label_105;
                                            }
                                            else
                                              goto label_105;
label_110:
                                            num48 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
                                            goto label_105;
                                          }
                                          finally
                                          {
                                            if (enumerator7 != null)
                                            {
                                              int num49 = 1;
                                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
                                                num49 = 1;
                                              while (true)
                                              {
                                                switch (num49)
                                                {
                                                  case 1:
                                                    // ISSUE: reference to a compiler-generated method
                                                    ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.dxT2bRZOLjMMhAFcmETQ((object) enumerator7);
                                                    num49 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
                                                    continue;
                                                  default:
                                                    goto label_118;
                                                }
                                              }
                                            }
label_118:;
                                          }
                                        case 28:
                                          // ISSUE: reference to a compiler-generated method
                                          // ISSUE: reference to a compiler-generated method
                                          ((ConfigurationImportExecutor) readPacketResult.executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.GNJT1lZOr8Ruw9jOdHCq(ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.TMGZSvZOlrbJincoJej9(-1872275253 >> 6 ^ -28856985)), false));
                                          num33 = 17;
                                          continue;
                                        default:
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.a7B4RDZOgQyEKoxPpVvj(readPacketResult.executor, (object) new DeployLogMessage(DeployLogMessageType.Empty, "", false));
                                          num33 = 14;
                                          continue;
                                      }
                                    }
label_120:
                                    // ISSUE: reference to a compiler-generated method
                                    // ISSUE: reference to a compiler-generated method
                                    throw new ConfigImportException((string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.GNJT1lZOr8Ruw9jOdHCq(ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.TMGZSvZOlrbJincoJej9(-2092274397 << 4 ^ 882965906)));
                                  }
                                  catch (Exception ex)
                                  {
                                    int num50 = 2;
                                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                                      num50 = 3;
                                    DeployLogMessage deployLogMessage3;
                                    while (true)
                                    {
                                      switch (num50)
                                      {
                                        case 1:
                                          goto label_207;
                                        case 2:
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.G3N1b7Z2bDidqlD1aHHg((object) unitOfWork4);
                                          num50 = 4;
                                          continue;
                                        case 3:
                                          // ISSUE: reference to a compiler-generated method
                                          ((ConfigurationImportExecutor) readPacketResult.executor).packetError.Add((string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.mCT63QZOsscorb5oXdiJ((object) ex));
                                          num50 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                                          continue;
                                        case 4:
                                          DeployLogMessage deployLogMessage4 = new DeployLogMessage(BPMAppItemImportStatus.Error, Guid.Empty, ((ConfigurationImportExecutor) readPacketResult.executor).treeUid);
                                          // ISSUE: reference to a compiler-generated method
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.hJ4oVXZ2hKji0nM4Vl6N((object) deployLogMessage4, ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.mCT63QZOsscorb5oXdiJ((object) ex));
                                          deployLogMessage3 = deployLogMessage4;
                                          num50 = 6;
                                          continue;
                                        case 5:
                                          // ISSUE: reference to a compiler-generated method
                                          // ISSUE: reference to a compiler-generated method
                                          // ISSUE: reference to a compiler-generated method
                                          isException = !ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.VcZG2bZ2Gmc65WxPr4ye(ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.mCT63QZOsscorb5oXdiJ((object) ex)) ? ex.Message : (string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.TMGZSvZOlrbJincoJej9(-1710575414 ^ -1710456504);
                                          num50 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
                                          continue;
                                        case 6:
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.a7B4RDZOgQyEKoxPpVvj(readPacketResult.executor, (object) deployLogMessage3);
                                          num50 = 7;
                                          continue;
                                        case 7:
                                          if (!isBadRule & needInterrupt)
                                          {
                                            num50 = 5;
                                            continue;
                                          }
                                          goto label_207;
                                        default:
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.LQYPZkZ2oPMMIylXGHNp((object) ConfigurationImportExecutor.ImportLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281715216), (object) ex);
                                          num50 = 2;
                                          continue;
                                      }
                                    }
                                  }
label_207:
                                  ClearSession();
                                  int num51 = 0;
                                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
                                    goto label_208;
label_206:
                                  switch (num51)
                                  {
                                    case 1:
                                      goto label_216;
                                    default:
                                      goto label_207;
                                  }
label_208:
                                  num51 = 1;
                                  goto label_206;
                                }
                                finally
                                {
                                  if (unitOfWork4 != null)
                                  {
                                    int num52 = 0;
                                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                                      num52 = 1;
                                    while (true)
                                    {
                                      switch (num52)
                                      {
                                        case 1:
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.dxT2bRZOLjMMhAFcmETQ((object) unitOfWork4);
                                          num52 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
                                          continue;
                                        default:
                                          goto label_215;
                                      }
                                    }
                                  }
label_215:;
                                }
                              case 4:
                                packet = new Dictionary<IEntity, Exception>();
                                num32 = 2;
                                continue;
                              case 5:
                                session = ((ConfigurationImportExecutor) readPacketResult.executor).sessionProvider.GetSession(string.Empty);
                                num32 = 4;
                                continue;
                              case 6:
                                unitOfWork4 = ((ConfigurationImportExecutor) readPacketResult.executor).unitOfWorkManager.Create(string.Empty, true);
                                num32 = 3;
                                continue;
                              case 7:
                                goto label_53;
                              case 8:
label_216:
                                // ISSUE: reference to a compiler-generated method
                                if (ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.VcZG2bZ2Gmc65WxPr4ye((object) isException))
                                {
                                  num32 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
                                  continue;
                                }
                                goto label_219;
                              case 9:
                                try
                                {
                                  try
                                  {
                                    enumerator6 = ((ConfigurationImportExecutor) readPacketResult.executor).packetActions.GetEnumerator();
                                    int num53 = 0;
                                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                                      num53 = 0;
                                    while (true)
                                    {
                                      switch (num53)
                                      {
                                        case 1:
                                          goto label_41;
                                        case 2:
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.a7B4RDZOgQyEKoxPpVvj(readPacketResult.executor, (object) new DeployLogMessage(BPMAppItemImportStatus.Complete, Guid.Empty, ((ConfigurationImportExecutor) readPacketResult.executor).treeUid));
                                          num53 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
                                          continue;
                                        case 3:
label_6:
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ImportLog.Info(ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.TMGZSvZOlrbJincoJej9(1597012150 ^ 1597393316));
                                          num53 = 4;
                                          continue;
                                        case 4:
                                          // ISSUE: reference to a compiler-generated method
                                          ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.uy8BRjZ2W58EQ7FXe97e((object) unitOfWork3);
                                          num53 = 2;
                                          continue;
                                        default:
                                          try
                                          {
label_16:
                                            // ISSUE: reference to a compiler-generated method
                                            if (ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.J5VEhUZOj0XwGxNPFl4Y((object) enumerator6))
                                              goto label_13;
                                            else
                                              goto label_17;
label_10:
                                            IPacketActions current;
                                            int num54;
                                            while (true)
                                            {
                                              PacketActionArgs args;
                                              switch (num54)
                                              {
                                                case 1:
                                                  if (!current.AfterCommitAction(args))
                                                  {
                                                    num54 = 3;
                                                    continue;
                                                  }
                                                  break;
                                                case 2:
                                                  goto label_16;
                                                case 3:
                                                  // ISSUE: reference to a compiler-generated method
                                                  needInterrupt = ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.tnP9DsZOzUp2Jyx9nLCu((object) current, (object) args, false);
                                                  num54 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 8 : 3;
                                                  continue;
                                                case 4:
                                                  goto label_18;
                                                case 5:
                                                  args = new PacketActionArgs(((ConfigurationImportExecutor) readPacketResult.executor).importSettings, (ICollection<IEntity>) ((ConfigurationImportExecutor) readPacketResult.executor).savedPacketEntities, (ICollection<DeployLogMessage>) ((ConfigurationImportExecutor) readPacketResult.executor).messages, (string) readPacketResult.contentType, readPacketResult.packetData, (IDictionary<string, string>) ((ConfigurationImportExecutor) readPacketResult.executor).serviceData);
                                                  num54 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
                                                  continue;
                                                case 6:
                                                  goto label_6;
                                                case 7:
                                                  goto label_13;
                                                case 8:
                                                  if (!needInterrupt)
                                                  {
                                                    num54 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                                                    continue;
                                                  }
                                                  goto label_18;
                                              }
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.ihPSKHZ2FXyQcI1sgVi1((object) session);
                                              num54 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 2;
                                            }
label_18:
                                            // ISSUE: reference to a compiler-generated method
                                            throw new ConfigImportException(EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.TMGZSvZOlrbJincoJej9(1033719030 - 2012070891 ^ -978732865), (object) current.GetType().FullName));
label_13:
                                            current = enumerator6.Current;
                                            num54 = 3;
                                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                                            {
                                              num54 = 5;
                                              goto label_10;
                                            }
                                            else
                                              goto label_10;
label_17:
                                            num54 = 6;
                                            goto label_10;
                                          }
                                          finally
                                          {
                                            if (enumerator6 != null)
                                            {
                                              int num55 = 0;
                                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                                                num55 = 0;
                                              while (true)
                                              {
                                                switch (num55)
                                                {
                                                  case 1:
                                                    goto label_28;
                                                  default:
                                                    enumerator6.Dispose();
                                                    num55 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
                                                    continue;
                                                }
                                              }
                                            }
label_28:;
                                          }
                                      }
                                    }
                                  }
                                  catch (Exception ex)
                                  {
                                    int num56 = 6;
                                    while (true)
                                    {
                                      int num57 = num56;
                                      DeployLogMessage message;
                                      while (true)
                                      {
                                        switch (num57)
                                        {
                                          case 1:
                                            if (!needInterrupt)
                                            {
                                              num57 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 7 : 1;
                                              continue;
                                            }
                                            goto label_39;
                                          case 2:
                                            // ISSUE: reference to a compiler-generated method
                                            ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.G3N1b7Z2bDidqlD1aHHg((object) unitOfWork3);
                                            num57 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                                            continue;
                                          case 3:
                                          case 7:
                                            goto label_41;
                                          case 4:
                                            // ISSUE: reference to a compiler-generated method
                                            // ISSUE: reference to a compiler-generated method
                                            ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.LQYPZkZ2oPMMIylXGHNp((object) ConfigurationImportExecutor.ImportLog, ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.TMGZSvZOlrbJincoJej9(1218962250 ^ 1218564610), (object) ex);
                                            num57 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 2 : 1;
                                            continue;
                                          case 5:
                                            ((ConfigurationImportExecutor) readPacketResult.executor).AddMessage(message);
                                            num57 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
                                            continue;
                                          case 6:
                                            // ISSUE: reference to a compiler-generated method
                                            ((ConfigurationImportExecutor) readPacketResult.executor).packetError.Add((string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.mCT63QZOsscorb5oXdiJ((object) ex));
                                            num57 = 4;
                                            continue;
                                          case 8:
                                            goto label_39;
                                          default:
                                            DeployLogMessage deployLogMessage = new DeployLogMessage(BPMAppItemImportStatus.Error, Guid.Empty, ((ConfigurationImportExecutor) readPacketResult.executor).treeUid);
                                            // ISSUE: reference to a compiler-generated method
                                            // ISSUE: reference to a compiler-generated method
                                            ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.hJ4oVXZ2hKji0nM4Vl6N((object) deployLogMessage, ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.mCT63QZOsscorb5oXdiJ((object) ex));
                                            message = deployLogMessage;
                                            num57 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 5 : 2;
                                            continue;
                                        }
                                      }
label_39:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      isException = ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.VcZG2bZ2Gmc65WxPr4ye(ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.mCT63QZOsscorb5oXdiJ((object) ex)) ? (string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.TMGZSvZOlrbJincoJej9(1925118608 << 2 ^ -889332798) : (string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.mCT63QZOsscorb5oXdiJ((object) ex);
                                      num56 = 3;
                                    }
                                  }
label_41:
                                  ClearSession();
                                  int num58 = 0;
                                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
                                    goto label_42;
label_40:
                                  switch (num58)
                                  {
                                    case 1:
                                      goto label_41;
                                    default:
                                      goto label_51;
                                  }
label_42:
                                  num58 = 0;
                                  goto label_40;
                                }
                                finally
                                {
                                  int num59;
                                  if (unitOfWork3 == null)
                                    num59 = 2;
                                  else
                                    goto label_46;
label_45:
                                  switch (num59)
                                  {
                                    case 1:
                                      break;
                                    default:
                                  }
label_46:
                                  unitOfWork3.Dispose();
                                  num59 = 0;
                                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                                  {
                                    num59 = 0;
                                    goto label_45;
                                  }
                                  else
                                    goto label_45;
                                }
                              case 10:
label_51:
                                // ISSUE: reference to a compiler-generated method
                                if (ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.VcZG2bZ2Gmc65WxPr4ye((object) isException))
                                {
                                  num32 = 12;
                                  continue;
                                }
                                goto label_53;
                              case 11:
                                goto label_219;
                              case 12:
                                goto label_213;
                              default:
                                flag = true;
                                num32 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 4 : 6;
                                continue;
                            }
                          }
label_213:
                          return;
label_53:
                          throw new ConfigImportException(isException);
label_219:
                          throw new ConfigImportException(isException);

                          void ClearSession()
                          {
                            switch (1)
                            {
                              case 1:
                                try
                                {
                                  // ISSUE: reference to a compiler-generated method
                                  ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.fLfwqMZ2EgnJd6EwernR((object) session);
                                  int num = 0;
                                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                                    num = 0;
                                  while (true)
                                  {
                                    switch (num)
                                    {
                                      case 1:
                                        goto label_7;
                                      default:
                                        // ISSUE: reference to a compiler-generated method
                                        ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.XXyiH6Z2fniCTtliQn67((object) ((ConfigurationImportExecutor) readPacketResult.executor).contextCacheService);
                                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
                                        continue;
                                    }
                                  }
label_7:
                                  break;
                                }
                                catch (Exception ex)
                                {
                                  int num = 1;
                                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
                                    num = 0;
                                  while (true)
                                  {
                                    switch (num)
                                    {
                                      case 0:
                                        goto label_5;
                                      case 1:
                                        // ISSUE: reference to a compiler-generated method
                                        ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.LQYPZkZ2oPMMIylXGHNp((object) ConfigurationImportExecutor.ImportLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16356233), (object) ex);
                                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                                        continue;
                                      default:
                                        goto label_1;
                                    }
                                  }
label_5:
                                  break;
label_1:
                                  break;
                                }
                            }
                          }
                        })) : action1;
                        // ISSUE: reference to a compiler-generated method
                        ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass8_0.ChUU7KZOdicWdqXVrG08((object) securityService, (object) action2);
                        num31 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_2;
                    }
                  }
label_4:
                  return;
label_2:;
                }));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 2 : 7;
                continue;
              case 3:
                goto label_6;
              case 4:
                needInterrupt = false;
                num2 = 9;
                continue;
              case 5:
                readPacketResult = this;
                num2 = 8;
                continue;
              case 6:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 5;
                continue;
              case 7:
                goto label_5;
              case 8:
                isException = "";
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                continue;
              case 9:
                if (((ConfigurationImportExecutor) this.executor).signUserId == 0L)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 3 : 3;
                  continue;
                }
                goto label_16;
              case 10:
                ConfigurationImportExecutor.ReadPacketResult.HG1h2k8kyHOrtY9RcQ0V((object) this.readMetadataResults);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 3 : 11;
                continue;
              case 11:
                ConfigurationImportExecutor.ReadPacketResult.E7D1aN8kM4f5eqqqhAMw((object) this.packetData);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
                continue;
              default:
                isBadRule = false;
                num2 = 4;
                continue;
            }
          }
label_5:
          ConfigurationImportExecutor.ReadPacketResult.lyG6Nt8kmZgQVf2qrHDS((object) this.entitiesValues);
          num1 = 10;
          continue;
label_6:
          object obj1 = (object) null;
          goto label_17;
label_16:
          obj1 = ConfigurationImportExecutor.ReadPacketResult.QJG3Ut8kxgHNwW4YdUhL((object) ((ConfigurationImportExecutor) this.executor).securityDeployHelperExtensions.First<ISecurityDeployHelperExtension>(), ((ConfigurationImportExecutor) this.executor).signUserId);
label_17:
          user = (IUser) obj1;
          num1 = 2;
        }
label_3:;
      }

      private (Dictionary<string, Dictionary<string, object>> propValues, EntityMetadata metadata, Type type) ReadEntity(
        XmlReader reader)
      {
        reader.MoveToAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672210058));
        Guid guid = Guid.Parse(reader.Value);
        Guid result = Guid.Empty;
        if (reader.MoveToAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561271288)))
          Guid.TryParse(reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107650190)), out result);
        Type typeByUidOrNull = MetadataServiceContext.MetadataRuntimeService.GetTypeByUidOrNull(guid);
        if (typeByUidOrNull == (Type) null)
        {
          reader.Skip();
          int content = (int) reader.MoveToContent();
          ((ConfigurationImportExecutor) this.executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099397777), (object) guid), false));
          return ((Dictionary<string, Dictionary<string, object>>) null, (EntityMetadata) null, (Type) null);
        }
        Dictionary<string, Dictionary<string, object>> propValues = new Dictionary<string, Dictionary<string, object>>();
        propValues.Add(ConfigurationImportExecutor.RegularProperty, new Dictionary<string, object>());
        propValues.Add(ConfigurationImportExecutor.XmlProperty, new Dictionary<string, object>());
        EntityMetadata entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(typeByUidOrNull);
        if (entityMetadata == null)
        {
          reader.Skip();
          int content = (int) reader.MoveToContent();
          ((ConfigurationImportExecutor) this.executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867439105), (object) typeByUidOrNull.Name), false));
          return ((Dictionary<string, Dictionary<string, object>>) null, (EntityMetadata) null, (Type) null);
        }
        reader.Read();
        int content1 = (int) reader.MoveToContent();
        Dictionary<string, Dictionary<string, object>> dictionary = new EntityXmlSerializer().XmlEntityRead(reader, propValues, ((ConfigurationImportExecutor) this.executor).mergeUidReplace, ((ConfigurationImportExecutor) this.executor).mergeReplace, guid);
        reader.Read();
        if (result != Guid.Empty)
          dictionary[ConfigurationImportExecutor.RegularProperty][z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105207696)] = (object) result.ToString();
        return (dictionary, entityMetadata, typeByUidOrNull);
      }

      private bool SaveEntity(
        (Dictionary<string, Dictionary<string, object>> propValues, EntityMetadata metadata, Type type) _,
        IDictionary<IEntity, Exception> packet)
      {
        Dictionary<string, Dictionary<string, object>> propValues = _.propValues;
        EntityMetadata metadata = _.metadata;
        Type type = _.type;
        Dictionary<string, object> propValuesR = propValues[ConfigurationImportExecutor.RegularProperty];
        Dictionary<string, object> dictionary1 = propValues[ConfigurationImportExecutor.XmlProperty];
        object input;
        ((ConfigurationImportExecutor) this.executor).AddMessage(new DeployLogMessage(BPMAppItemImportStatus.InProgress, propValuesR.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108662366), out input) ? Guid.Parse((string) input) : Guid.Empty, ((ConfigurationImportExecutor) this.executor).treeUid));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        List<IEntityImportSaveActions> supportedImportEntitySaveActionsExtensions = ((ConfigurationImportExecutor) this.executor).entityImportSaveActionExtensions.Where<IEntityImportSaveActions>((Func<IEntityImportSaveActions, bool>) (ex => ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_0.LNt6FGZ2VIvWiCCVCWnM((object) ex, ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_0.vnkbrFZ2IlPBD5J2rqs4((object) metadata)))).ToList<IEntityImportSaveActions>();
        bool flag1 = true;
        ImportEntityCanBeSavedData data1 = new ImportEntityCanBeSavedData(((ConfigurationImportExecutor) this.executor).serviceData, new List<DeployLogMessage>());
        if (supportedImportEntitySaveActionsExtensions.Count > 0)
        {
          foreach (IEntityImportSaveActions importSaveActions in supportedImportEntitySaveActionsExtensions)
          {
            bool flag2 = importSaveActions.CanBeSaved(propValuesR, data1);
            foreach (DeployLogMessage deployMessage in data1.DeployMessages)
            {
              ((ConfigurationImportExecutor) this.executor).AddMessage(deployMessage);
              ConfigurationImportExecutor.ImportLog.Error((object) deployMessage.MessageText);
            }
            flag1 &= flag2;
          }
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (!((ConfigurationImportExecutor) this.executor).skipEntityImportResolvers.Where<ISkipEntityImportResolver>((Func<ISkipEntityImportResolver, bool>) (r => ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_0.atJguQZ2SKLT1NI1e8ie((object) r, ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_0.vnkbrFZ2IlPBD5J2rqs4((object) metadata)))).ToList<ISkipEntityImportResolver>().Any<ISkipEntityImportResolver>((Func<ISkipEntityImportResolver, bool>) (r => r.IsSkip(propValuesR, ((ConfigurationImportExecutor) this.executor).serviceData))))
        {
          object obj1;
          string objUidStr;
          if (propValuesR.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740345274), out obj1) && obj1 != null && ((ConfigurationImportExecutor) this.executor).serviceData.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410910947) + obj1.ToString().ToLower(), out objUidStr))
            ((ConfigurationImportExecutor) this.executor).AddMessage(new DeployLogMessage(BPMAppItemImportStatus.InProgress, objUidStr, ((ConfigurationImportExecutor) this.executor).treeUid));
          IEntityManager entityManager = ModelHelper.GetEntityManager(type);
          IEntity entity = (IEntity) null;
          Guid uidFrom = propValuesR.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222134508), out input) ? Guid.Parse((string) input) : Guid.Empty;
          if (uidFrom != new Guid())
            entity = (IEntity) entityManager.LoadOrNull(((ConfigurationImportExecutor) this.executor).mergeUidReplace.GetUidReplace(uidFrom));
          else
            ((ConfigurationImportExecutor) this.executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97715036), (object) metadata.Name), false));
          if (entity == null)
            entity = (IEntity) InterfaceActivator.Create(type);
          List<IPropertyMetadata> propertyMetadataList;
          if (!((ConfigurationImportExecutor) this.executor).entitiesMetadata.TryGetValue(type, out propertyMetadataList))
          {
            propertyMetadataList = metadata.Properties.ConvertAll<IPropertyMetadata>((Converter<PropertyMetadata, IPropertyMetadata>) (a => (IPropertyMetadata) a));
            propertyMetadataList.AddRange((IEnumerable<IPropertyMetadata>) metadata.TableParts.ConvertAll<IPropertyMetadata>((Converter<TablePartMetadata, IPropertyMetadata>) (a => (IPropertyMetadata) a)));
            ((ConfigurationImportExecutor) this.executor).entitiesMetadata.Add(type, propertyMetadataList);
          }
          ((ConfigurationImportExecutor) this.executor).linksDictionary.AddRange((IEnumerable<ILinksDictionaryItem>) new EntityXmlSerializer().Deserialize((object) entity, propValuesR));
          foreach (KeyValuePair<string, object> keyValuePair in dictionary1)
          {
            KeyValuePair<string, object> val = keyValuePair;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (propertyMetadataList.FindIndex((Predicate<IPropertyMetadata>) (p => ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_2.h62pbeZ2aTiLtYhs9HXn(ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_2.AdFQ0CZ2pAfVGa9li69t((object) p), (object) val.Key))) != -1)
            {
              PropertyInfo propertyCached = entity.GetType().GetPropertyCached(val.Key);
              if (!(propertyCached == (PropertyInfo) null) && propertyCached.CanWrite)
                propertyCached.SetValue((object) entity, val.Value, (object[]) null);
            }
          }
          if (supportedImportEntitySaveActionsExtensions.Count > 0)
          {
            ImportEntityPreSaveData data2 = new ImportEntityPreSaveData(((ConfigurationImportExecutor) this.executor).serviceData, ((ConfigurationImportExecutor) this.executor).systemMessages, ((ConfigurationImportExecutor) this.executor).mergeReplace, ((ConfigurationImportExecutor) this.executor).linksDictionary);
            foreach (IEntityImportSaveActions importSaveActions in supportedImportEntitySaveActionsExtensions)
            {
              List<TestImportMessages> source = importSaveActions.ExecPreSaveActions(entity, data2);
              bool flag3 = false;
              if (source != null)
              {
                // ISSUE: reference to a compiler-generated method
                flag3 = source.Any<TestImportMessages>((Func<TestImportMessages, bool>) (m => ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec.SiKGTtZOy6OHHHJAQh4n((object) m) == TestImportMessagesType.Error));
                foreach (TestImportMessages testImportMessages in source)
                {
                  switch (testImportMessages.Type)
                  {
                    case TestImportMessagesType.Warning:
                      ConfigurationImportExecutor.ImportLog.Warn((object) testImportMessages.Text);
                      ((ConfigurationImportExecutor) this.executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, testImportMessages.Text, false));
                      continue;
                    case TestImportMessagesType.Error:
                      ConfigurationImportExecutor.ImportLog.Error((object) testImportMessages.Text);
                      ((ConfigurationImportExecutor) this.executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Error, testImportMessages.Text, false));
                      continue;
                    default:
                      ConfigurationImportExecutor.ImportLog.Info((object) testImportMessages.Text);
                      ((ConfigurationImportExecutor) this.executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Info, testImportMessages.Text, false));
                      continue;
                  }
                }
              }
              flag1 = flag1 && !flag3;
            }
          }
          object uid = propValuesR.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397255498), out input) ? input : (object) Guid.Empty;
          ConfigurationImportExecutor.ImportLog.Info((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234016022), (object) type.Name, uid));
          ((ConfigurationImportExecutor) this.executor).withFormDependenciesService.Run((System.Action) (() =>
          {
            int num1 = 6;
            List<IEntityImportSaveActions>.Enumerator enumerator;
            while (true)
            {
              switch (num1)
              {
                case 1:
                  goto label_20;
                case 2:
label_7:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_1.JaSDVtZ228HZDpL7Axvp((object) ConfigurationImportExecutor.ImportLog, ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_1.NG7fUrZ2ORPNcGyKn5Mp((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675632275), ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_1.dyMrxoZ2nx0lScHnSGxu((object) type), uid));
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 3 : 9;
                  continue;
                case 3:
                  goto label_33;
                case 4:
                  enumerator = supportedImportEntitySaveActionsExtensions.GetEnumerator();
                  num1 = 10;
                  continue;
                case 5:
                case 8:
                  // ISSUE: reference to a compiler-generated method
                  object obj2 = ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_1.xL38OgZ2XWN6ZXSHSDIu((object) ((ConfigurationImportExecutor) this.executor).sessionProvider, (object) "");
                  // ISSUE: reference to a compiler-generated method
                  ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_1.DRtldlZ2TxLPS95j4AO3(obj2, (object) entity);
                  // ISSUE: reference to a compiler-generated method
                  ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_1.wfCd48Z2kdH8U54h4S5A(obj2);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 2;
                  continue;
                case 6:
                  if (!supportedImportEntitySaveActionsExtensions.Any<IEntityImportSaveActions>())
                  {
                    num1 = 5;
                    continue;
                  }
                  goto case 4;
                case 7:
                  goto label_30;
                case 9:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  ((ConfigurationImportExecutor) this.executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_1.VKrodPZ2eWoRSVIEixxi(-812025778 ^ -811644066), ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_1.sd92TbZ2PdBXgOd6FAjR((object) metadata), uid, (object) metadata.Name), false));
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
                  continue;
                case 10:
                  try
                  {
label_13:
                    if (enumerator.MoveNext())
                      goto label_11;
                    else
                      goto label_14;
label_10:
                    int num2;
                    switch (num2)
                    {
                      case 1:
                        goto label_13;
                      case 2:
                        break;
                      default:
                        goto label_7;
                    }
label_11:
                    enumerator.Current.ExecSaveActions(entity, ((ConfigurationImportExecutor) this.executor).serviceData);
                    num2 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
                    {
                      num2 = 1;
                      goto label_10;
                    }
                    else
                      goto label_10;
label_14:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                    goto label_10;
                  }
                  finally
                  {
                    enumerator.Dispose();
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
                      num3 = 0;
                    switch (num3)
                    {
                      default:
                    }
                  }
                case 11:
                  enumerator = supportedImportEntitySaveActionsExtensions.GetEnumerator();
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
                  continue;
                default:
                  if (!supportedImportEntitySaveActionsExtensions.Any<IEntityImportSaveActions>())
                  {
                    num1 = 7;
                    continue;
                  }
                  goto case 11;
              }
            }
label_33:
            return;
label_30:
            return;
label_20:
            try
            {
label_24:
              if (enumerator.MoveNext())
                goto label_23;
              else
                goto label_25;
label_21:
              int num4;
              switch (num4)
              {
                case 0:
                  return;
                case 1:
                  break;
                case 2:
                  goto label_24;
                default:
                  return;
              }
label_23:
              enumerator.Current.ExecPostSaveActions(entity, type, propValuesR, ((ConfigurationImportExecutor) this.executor).serviceData, ((ConfigurationImportExecutor) this.executor).linksDictionary);
              num4 = 2;
              goto label_21;
label_25:
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              goto label_21;
            }
            finally
            {
              enumerator.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
          }));
          if (flag1)
          {
            try
            {
              Guid eUid;
              Guid.TryParse(uid.ToString(), out eUid);
              List<ILinksDictionaryItem> linksDictionaryItemList = new List<ILinksDictionaryItem>();
              // ISSUE: reference to a compiler-generated method
              foreach (LinksDictionaryItem linksDictionaryItem in ((ConfigurationImportExecutor) this.executor).linksDictionary.OfType<LinksDictionaryItem>().Where<LinksDictionaryItem>((Func<LinksDictionaryItem, bool>) (i => ConfigurationImportExecutor.ReadPacketResult.\u003C\u003Ec__DisplayClass10_3.pEe2CcZ26QZlT14o1EUF((object) i, eUid))))
              {
                try
                {
                  if (linksDictionaryItem.SetLinkValue(entity, eUid))
                    linksDictionaryItemList.Add((ILinksDictionaryItem) linksDictionaryItem);
                }
                catch (Exception ex)
                {
                  ConfigurationImportExecutor.ImportLog.Info((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575845992), (object) type.Name, uid, (object) linksDictionaryItem.EntityUid, (object) linksDictionaryItem.EntityPropertyName, (object) linksDictionaryItem.LinkPropertyUid, (object) ex.Message));
                }
              }
              foreach (IEntityImportSaveActions saveActionExtension in ((ConfigurationImportExecutor) this.executor).entityImportSaveActionExtensions)
              {
                try
                {
                  IEnumerable<ILinksDictionaryItem> collection = saveActionExtension.RecoveryLinks(entity, eUid, ((ConfigurationImportExecutor) this.executor).linksDictionary);
                  if (collection != null)
                    linksDictionaryItemList.AddRange(collection);
                }
                catch (Exception ex)
                {
                  ConfigurationImportExecutor.ImportLog.Info((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1322865908), (object) type.Name, uid, (object) saveActionExtension.GetType().Name, (object) ex.Message));
                }
              }
              foreach (ILinksDictionaryItem linksDictionaryItem in linksDictionaryItemList)
                ((ConfigurationImportExecutor) this.executor).linksDictionary.Remove(linksDictionaryItem);
            }
            catch
            {
            }
          }
          IDictionary<IEntity, Exception> dictionary2 = packet;
          IEntity key = entity;
          Exception exception;
          if (!flag1)
            exception = new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319153508), (object) metadata.DisplayName));
          else
            exception = (Exception) null;
          dictionary2[key] = exception;
        }
        else
        {
          ConfigurationImportExecutor.ImportLog.Info((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671753599), (object) type.Name, (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712481717), propValuesR.Select<KeyValuePair<string, object>, string>((Func<KeyValuePair<string, object>, string>) (p => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306328254), (object) p.Key, p.Value))))));
          ((ConfigurationImportExecutor) this.executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107687910), (object) metadata.DisplayName, (object) metadata.Name), false));
        }
        return true;
      }

      internal static void koay8P8kaNpH0fCKvclM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool BtCUdd8kDDmeGtyL8Gev([In] object obj0) => ((XmlReader) obj0).IsStartElement();

      internal static object LaQt8C8ktxSUdw89ibM3([In] object obj0) => (object) ((XmlReader) obj0).Name;

      internal static object PRH1KZ8kwRVnUxUgYDZ5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool fBhsQb8k4qIxjcqlogVN([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

      internal static bool Ndpqrk8k6SkM17rgk43X([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

      internal static bool caj3358kHcYY8aMQT5rh([In] object obj0) => ((XmlReader) obj0).Read();

      internal static void fYKtSr8kAwmGvuSqSdP4([In] object obj0) => ((XmlReader) obj0).Skip();

      internal static XmlNodeType bdYSFW8k7VwgXRwG3PMP([In] object obj0) => ((XmlReader) obj0).NodeType;

      internal static bool dP2IK38k3ZrNYFoPy3Rt() => ConfigurationImportExecutor.ReadPacketResult.vpNLbH8kNNLaKk3aej4i == null;

      internal static ConfigurationImportExecutor.ReadPacketResult pFswJM8kp07UnjN6Hqu8() => (ConfigurationImportExecutor.ReadPacketResult) ConfigurationImportExecutor.ReadPacketResult.vpNLbH8kNNLaKk3aej4i;

      internal static object QJG3Ut8kxgHNwW4YdUhL([In] object obj0, long userId) => (object) ((ISecurityDeployHelperExtension) obj0).LoadUserOrNull(userId);

      internal static void KGbyRg8k0peOJ190OOkv([In] object obj0, [In] object obj1, [In] object obj2) => ((ISecurityService) obj0).RunByUser((IUser) obj1, (System.Action) obj2);

      internal static void lyG6Nt8kmZgQVf2qrHDS([In] object obj0) => ((ICollection<(Dictionary<string, Dictionary<string, object>>, EntityMetadata, Type)>) obj0).Clear();

      internal static void HG1h2k8kyHOrtY9RcQ0V([In] object obj0) => ((ICollection<(IReadMetadataResult, bool)>) obj0).Clear();

      internal static void E7D1aN8kM4f5eqqqhAMw([In] object obj0) => ((ICollection<KeyValuePair<string, string>>) obj0).Clear();
    }

    private sealed class ImportantDataClass
    {
      private static object currentVersion;
      private static object maxVersion;
      private static object xorJkJ8kJmU3hRHks3nv;

      static ImportantDataClass()
      {
        int num = 4;
        Version version;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              ConfigurationImportExecutor.ImportantDataClass.maxVersion = (object) new Version(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 1;
              continue;
            case 3:
              version = VersionInfo.GetVersion<EleWise.ELMA.SR>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            case 4:
              ConfigurationImportExecutor.ImportantDataClass.XCIodT8klSe7nNvdd68E();
              num = 3;
              continue;
            default:
              ConfigurationImportExecutor.ImportantDataClass.currentVersion = (object) new Version(ConfigurationImportExecutor.ImportantDataClass.I5cASK8kry1b07Chw4YT((object) version), ConfigurationImportExecutor.ImportantDataClass.dEGr7s8kg3yubHMmhHtG((object) version));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 2 : 0;
              continue;
          }
        }
label_2:;
      }

      public static ConfigurationImportExecutor.ImportantDataClass Read(
        object reader,
        ISet<Guid> importantData)
      {
        Guid result1;
        if (!((XmlReader) reader).MoveToAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312752401)) || !Guid.TryParse(((XmlReader) reader).Value, out result1) || importantData.Contains(result1))
        {
          ((XmlReader) reader).Skip();
          return (ConfigurationImportExecutor.ImportantDataClass) null;
        }
        string module = !((XmlReader) reader).MoveToAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082460608)) || string.IsNullOrWhiteSpace(((XmlReader) reader).Value) ? (string) null : ((XmlReader) reader).Value;
        Version version = (Version) ConfigurationImportExecutor.ImportantDataClass.maxVersion;
        int content1 = (int) ((XmlReader) reader).MoveToContent();
        if (!((XmlReader) reader).IsEmptyElement)
        {
          ((XmlReader) reader).Read();
          int content2 = (int) ((XmlReader) reader).MoveToContent();
          while (((XmlReader) reader).NodeType != XmlNodeType.EndElement)
          {
            Version result2;
            if (((XmlReader) reader).IsStartElement() && ((XmlReader) reader).Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281809460) && !((XmlReader) reader).IsEmptyElement && Version.TryParse(((XmlReader) reader).ReadElementString(), out result2) && (module != null || result2 >= (Version) ConfigurationImportExecutor.ImportantDataClass.currentVersion) && result2 < version)
              version = result2;
            ((XmlReader) reader).Skip();
            int content3 = (int) ((XmlReader) reader).MoveToContent();
          }
          ((XmlReader) reader).Read();
        }
        return !(version == (Version) ConfigurationImportExecutor.ImportantDataClass.maxVersion) ? new ConfigurationImportExecutor.ImportantDataClass(result1, version, module) : (ConfigurationImportExecutor.ImportantDataClass) null;
      }

      private ImportantDataClass(Guid uid, Version version, string module)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.Uid = uid;
              num = 3;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.Version = version;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
              continue;
            default:
              this.Module = module;
              num = 2;
              continue;
          }
        }
label_3:;
      }

      public Guid Uid { get; }

      public Version Version { get; }

      public string Module { get; }

      internal static void XCIodT8klSe7nNvdd68E() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static int I5cASK8kry1b07Chw4YT([In] object obj0) => ((Version) obj0).Major;

      internal static int dEGr7s8kg3yubHMmhHtG([In] object obj0) => ((Version) obj0).Minor;

      internal static bool tvDjtK8k9Nrg8NAKn1f1() => ConfigurationImportExecutor.ImportantDataClass.xorJkJ8kJmU3hRHks3nv == null;

      internal static ConfigurationImportExecutor.ImportantDataClass AZLZOL8kdnMxF7bd0RPJ() => (ConfigurationImportExecutor.ImportantDataClass) ConfigurationImportExecutor.ImportantDataClass.xorJkJ8kJmU3hRHks3nv;
    }
  }
}
