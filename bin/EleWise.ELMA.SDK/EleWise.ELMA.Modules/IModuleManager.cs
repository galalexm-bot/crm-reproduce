using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;

namespace EleWise.ELMA.Modules;

public interface IModuleManager
{
	IApplication MainApplication { get; }

	ILicensedUnit MainLicensedUnit { get; }

	DateTime? GetMainLicensedUnitExpiration();

	IApplicationUnit FindUnitById(string id);

	IApplicationUnit FindUnitByUid(Guid uid);

	IModule FindModuleById(string id);

	bool IsAssemblyAvailable(Assembly assembly);

	IModule FindModuleByAssembly(Assembly assembly);

	void SaveModuleStatus(Guid uid, ModuleStatus status);

	void SaveStoreComponent(ElmaStoreComponentManifest manifest, IEnumerable<StoreComponentSignatureInfo> signatures, string fileName, StoreComponentStatus status, string unpackedPackagesFolder = null);

	void SaveStoreComponentInfo(IStoreComponentInfo info, StoreComponentStatus status);

	IEnumerable<ElmaStoreComponentManifest> GetInstalledComponentManifests();

	IEnumerable<PackageManifest> GetComponentPackages(string componentId);

	void SaveStartedModuleInfos();
}
