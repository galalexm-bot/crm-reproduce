using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Packaging.ElmaStoreManifest;

namespace EleWise.ELMA.Modules;

public interface IModuleDTOManager : IConfigurationService
{
	IEnumerable<ElmaStoreComponentManifest> GetInstalledComponentManifests();

	IEnumerable<PackageManifest> GetComponentPackages(string componentId);

	ElmaStoreComponentManifest GetManifest(string id, out bool installed);
}
