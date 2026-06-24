// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ConfigurationImportInternalFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy
{
  /// <inheritdoc />
  [Service]
  internal sealed class ConfigurationImportInternalFactory : IConfigurationImportInternalFactory
  {
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
    private readonly IActorContextService actorContextService;
    private static ConfigurationImportInternalFactory U9lroREOysCY0k8v5mTN;

    /// <summary>Ctor</summary>
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
    /// <param name="actorContextService">Сервис контекста исполнения в акторе</param>
    public ConfigurationImportInternalFactory(
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
      IEnumerable<IPostEntityXmlSerializer> postEntityXmlSerializers,
      IActorContextService actorContextService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
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
      this.actorContextService = actorContextService;
    }

    /// <inheritdoc />
    public IConfigurationTesterInternal CreateTester(IImportSettings importSettings) => (IConfigurationTesterInternal) new ConfigurationImportExecutor(importSettings, this.securityService, this.authenticationService, this.modelManager, this.moduleManager, this.withFormDependenciesService, this.zipService, this.tagService, this.unitOfWorkManager, this.runtimeApplication, this.metadataItemManager, this.bpmAppManager, this.packageService, this.packetVersionService, this.runWithSoftDeletableService, this.sessionProvider, this.contextCacheService, this.exportImportFileManager, this.importExtensions, this.configImportActionExtensions, this.entityImportSaveActionExtensions, this.importantData, this.packetActions, this.metadataImport, this.skipEntityImportResolvers, this.ignoreIsUniqueMetadata, this.securityDeployHelperExtensions, this.privilegeModuleAccessGroups, this.postEntityXmlSerializers);

    /// <inheritdoc />
    public IConfigurationImporterInternal CreateImporter(IImportSettings importSettings) => (IConfigurationImporterInternal) new ConfigurationImportExecutor(importSettings, this.securityService, this.authenticationService, this.modelManager, this.moduleManager, this.withFormDependenciesService, this.zipService, this.tagService, this.unitOfWorkManager, this.runtimeApplication, this.metadataItemManager, this.bpmAppManager, this.packageService, this.packetVersionService, this.runWithSoftDeletableService, this.sessionProvider, this.contextCacheService, this.exportImportFileManager, this.importExtensions, this.configImportActionExtensions, this.entityImportSaveActionExtensions, this.importantData, this.packetActions, this.metadataImport, this.skipEntityImportResolvers, this.ignoreIsUniqueMetadata, this.securityDeployHelperExtensions, this.privilegeModuleAccessGroups, this.postEntityXmlSerializers);

    internal static bool p9yEIhEOM4K6Q70jEXb2() => ConfigurationImportInternalFactory.U9lroREOysCY0k8v5mTN == null;

    internal static ConfigurationImportInternalFactory RE3qaQEOJ8inkLfvbG0J() => ConfigurationImportInternalFactory.U9lroREOysCY0k8v5mTN;
  }
}
