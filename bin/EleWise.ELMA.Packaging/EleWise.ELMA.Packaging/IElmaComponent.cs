using System;
using System.Collections.Generic;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using NuGet;

namespace EleWise.ELMA.Packaging;

public interface IElmaComponent
{
	string Id { get; }

	string Name { get; }

	string ComponentRoot { get; }

	string RootPackageId { get; }

	bool StartAfterInstall { get; }

	bool IsInstalled();

	void Install(IEnumerable<string> packages);

	void Uninstall();

	void Configure(ElmaComponentSettings settings);

	void Unconfigure();

	bool IsStarted();

	void Start();

	void Stop();

	void Pause();

	IEnumerable<PackageInfo> GetInstalledPackagesInfo();

	IEnumerable<PackageInfo> GetAvailablePackagesInfo();

	IEnumerable<PackageInfo> GetPackagesInfo();

	IEnumerable<PackageInfo> GetPackagesUpdates();

	bool IsCompatible(IPackage package);

	bool IsCompatible(ElmaPackageMetadata metadata);

	void CheckCompatible(IPackage package);

	void CheckCompatible(IPackage package, ElmaPackageMetadata metadata);

	IPreparedOperation PrepareInstallPackages(IEnumerable<PackageInfo> packageInfos, bool updateDependencies);

	void InstallPackages(IEnumerable<PackageInfo> packageInfos, bool updateDependencies);

	IPreparedOperation PrepareUninstallPackages(IEnumerable<string> packageIds, bool removeDependencies = false, bool forceRemove = true);

	void UninstallPackages(IEnumerable<string> packageIds, bool removeDependencies = false, bool forceRemove = true);

	void BeforePrepareUpdate();

	void BeforeUpdate();

	void AfterUpdate(bool success);

	ElmaStoreComponentRepository GetConfigurationStoreComponentsRepository();

	LocalPackageRepository GetConfigurationPackageRepository();

	string GetConfigurationPackagesDirectory();

	void UnpackPackagesFromComponents(IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration);
}
