using System.Collections.Generic;
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

namespace EleWise.ELMA.Deploy;

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

	public ConfigurationImportInternalFactory(ISecurityService securityService, IAuthenticationService authenticationService, IModelManager modelManager, IModuleManager moduleManager, IWorkWithFormDependeciesService withFormDependenciesService, IZipService zipService, ITagService tagService, IUnitOfWorkManager unitOfWorkManager, IRuntimeApplication runtimeApplication, MetadataItemManager metadataItemManager, BPMAppManager bpmAppManager, PackageService packageService, PacketVersionService packetVersionService, RunWithSoftDeletableService runWithSoftDeletableService, ISessionProvider sessionProvider, IContextBoundVariableService contextCacheService, IExportImportFileManager exportImportFileManager, IEnumerable<IConfigImportExtension> importExtensions, IEnumerable<IConfigImportActionExtension> configImportActionExtensions, IEnumerable<IEntityImportSaveActions> entityImportSaveActionExtensions, IEnumerable<IImportantData> importantData, IEnumerable<IPacketActions> packetActions, IEnumerable<IMetadataImport> metadataImport, IEnumerable<ISkipEntityImportResolver> skipEntityImportResolvers, IEnumerable<IIgnoreIsUniqueMetadata> ignoreIsUniqueMetadata, IEnumerable<ISecurityDeployHelperExtension> securityDeployHelperExtensions, IEnumerable<IPrivilegeModuleAccessGroup> privilegeModuleAccessGroups, IEnumerable<IPostEntityXmlSerializer> postEntityXmlSerializers, IActorContextService actorContextService)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
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

	public IConfigurationTesterInternal CreateTester(IImportSettings importSettings)
	{
		return new ConfigurationImportExecutor(importSettings, securityService, authenticationService, modelManager, moduleManager, withFormDependenciesService, zipService, tagService, unitOfWorkManager, runtimeApplication, metadataItemManager, bpmAppManager, packageService, packetVersionService, runWithSoftDeletableService, sessionProvider, contextCacheService, exportImportFileManager, importExtensions, configImportActionExtensions, entityImportSaveActionExtensions, importantData, packetActions, metadataImport, skipEntityImportResolvers, ignoreIsUniqueMetadata, securityDeployHelperExtensions, privilegeModuleAccessGroups, postEntityXmlSerializers);
	}

	public IConfigurationImporterInternal CreateImporter(IImportSettings importSettings)
	{
		return new ConfigurationImportExecutor(importSettings, securityService, authenticationService, modelManager, moduleManager, withFormDependenciesService, zipService, tagService, unitOfWorkManager, runtimeApplication, metadataItemManager, bpmAppManager, packageService, packetVersionService, runWithSoftDeletableService, sessionProvider, contextCacheService, exportImportFileManager, importExtensions, configImportActionExtensions, entityImportSaveActionExtensions, importantData, packetActions, metadataImport, skipEntityImportResolvers, ignoreIsUniqueMetadata, securityDeployHelperExtensions, privilegeModuleAccessGroups, postEntityXmlSerializers);
	}

	internal static bool p9yEIhEOM4K6Q70jEXb2()
	{
		return U9lroREOysCY0k8v5mTN == null;
	}

	internal static ConfigurationImportInternalFactory RE3qaQEOJ8inkLfvbG0J()
	{
		return U9lroREOysCY0k8v5mTN;
	}
}
