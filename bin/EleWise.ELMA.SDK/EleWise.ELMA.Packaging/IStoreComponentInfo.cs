using System.Collections.Generic;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using NuGet;

namespace EleWise.ELMA.Packaging;

public interface IStoreComponentInfo
{
	string Id { get; }

	string Title { get; }

	string ImagePath { get; }

	string Description { get; }

	string Author { get; }

	string Site { get; }

	ManifestComponentType Type { get; }

	ModuleStatus Status { get; }

	ModuleDisabledReason DisabledReason { get; }

	IEnumerable<PackageDescription> AllPackages { get; }

	IEnumerable<IModule> AllModules { get; }

	ILicensedUnit LicensedUnit { get; }

	bool IsInstalled { get; }

	SemanticVersion InstalledVersion { get; }

	bool IsLatestVersionInstalled { get; }

	SemanticVersion LastVersion { get; }

	bool DoesInstallOrUpdateRequireRestart { get; }
}
