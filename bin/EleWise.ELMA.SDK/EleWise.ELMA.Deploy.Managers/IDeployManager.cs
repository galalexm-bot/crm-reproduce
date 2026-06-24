using System;
using System.Collections.Generic;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;

namespace EleWise.ELMA.Deploy.Managers;

public interface IDeployManager : IConfigurationService
{
	Guid ExportConfiguration(ConfigExportSettings settings);

	Guid TestConfiguration(IConfigImportSettings settings, string activateKey = null);

	bool AddActivationKey(string activateKey, List<ElmaStoreComponentManifest> componentsToInstall, out List<ElmaStoreComponentManifest> notActivatedComponents);

	Guid ImportConfiguration(IConfigImportSettings settings);

	List<DeployLogMessage> GetImportLog(Guid importUid);

	List<DeployLogMessage> GetExportLog(Guid exportUid);

	List<TestImportMessages> GetTestLog(Guid testUid);

	List<DeploySystemMessage> GetImportSystemMessages(Guid importUid);

	List<DeploySystemMessage> GetTestSystemMessages(Guid testUid);

	List<PackageDescription> FindPackageDependencies(PackageDescription description);

	List<PackageDescription> FindAllPackages();

	List<PackageDescription> FindPackages(PackageFilter filter);

	void ExecutePackagesOperations(PackageInstallInfo installInfo);

	PackageOperationStatus GetUpdatePackagesOperationsStatus(Guid uid);

	ImportLicenseInfo GetServerLicenseInfo();

	byte[] GetComponentFileContent(string componentId, string version, string relativeFileName);

	bool IsImportAlreadyRun();

	IImportSettings GetImportSettings(Guid testUid);
}
