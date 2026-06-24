using System;
using System.Collections.Generic;
using System.Data.Services.Common;
using System.Linq;
using System.Runtime.Versioning;
using EleWise.ELMA.Packaging.Server.Infrastructure;
using NuGet;

namespace EleWise.ELMA.Packaging.Server.DataServices;

[DataServiceKey(new string[] { "Id", "Version" })]
[EntityPropertyMapping("Id", SyndicationItemProperty.Title, SyndicationTextContentKind.Plaintext, false)]
[EntityPropertyMapping("Authors", SyndicationItemProperty.AuthorName, SyndicationTextContentKind.Plaintext, false)]
[EntityPropertyMapping("LastUpdated", SyndicationItemProperty.Updated, SyndicationTextContentKind.Plaintext, false)]
[EntityPropertyMapping("Summary", SyndicationItemProperty.Summary, SyndicationTextContentKind.Plaintext, false)]
[HasStream]
public class Package
{
	internal string FullPath { get; set; }

	internal string Path { get; set; }

	public string Id { get; set; }

	public string Version { get; set; }

	public string Title { get; set; }

	public string Authors { get; set; }

	public string IconUrl { get; set; }

	public string LicenseUrl { get; set; }

	public string ProjectUrl { get; set; }

	public int DownloadCount { get; set; }

	public bool RequireLicenseAcceptance { get; set; }

	public string Description { get; set; }

	public string Summary { get; set; }

	public string ReleaseNotes { get; set; }

	public DateTime Published { get; set; }

	public DateTime LastUpdated { get; set; }

	public string Dependencies { get; set; }

	public string PackageHash { get; set; }

	public string PackageHashAlgorithm { get; set; }

	public long PackageSize { get; set; }

	public string Copyright { get; set; }

	public string Tags { get; set; }

	public bool IsAbsoluteLatestVersion { get; set; }

	public bool IsLatestVersion { get; set; }

	public bool Listed { get; set; }

	public int VersionDownloadCount { get; set; }

	public Package(IPackage package, DerivedPackageData derivedData)
	{
		Id = ((IPackageName)package).get_Id();
		Version = ((object)((IPackageName)package).get_Version()).ToString();
		Title = ((IPackageMetadata)package).get_Title();
		Authors = string.Join(",", ((IPackageMetadata)package).get_Authors());
		if (((IPackageMetadata)package).get_IconUrl() != null)
		{
			IconUrl = ((IPackageMetadata)package).get_IconUrl().GetComponents(UriComponents.HttpRequestUrl, UriFormat.Unescaped);
		}
		if (((IPackageMetadata)package).get_LicenseUrl() != null)
		{
			LicenseUrl = ((IPackageMetadata)package).get_LicenseUrl().GetComponents(UriComponents.HttpRequestUrl, UriFormat.Unescaped);
		}
		if (((IPackageMetadata)package).get_ProjectUrl() != null)
		{
			ProjectUrl = ((IPackageMetadata)package).get_ProjectUrl().GetComponents(UriComponents.HttpRequestUrl, UriFormat.Unescaped);
		}
		RequireLicenseAcceptance = ((IPackageMetadata)package).get_RequireLicenseAcceptance();
		Description = ((IPackageMetadata)package).get_Description();
		Summary = ((IPackageMetadata)package).get_Summary();
		ReleaseNotes = ((IPackageMetadata)package).get_ReleaseNotes();
		Tags = ((IPackageMetadata)package).get_Tags();
		Dependencies = string.Join("|", ((IPackageMetadata)package).get_DependencySets().SelectMany(ConvertDependencySetToStrings));
		PackageHash = derivedData.PackageHash;
		PackageHashAlgorithm = "SHA512";
		PackageSize = derivedData.PackageSize;
		LastUpdated = derivedData.LastUpdated.UtcDateTime;
		Published = derivedData.Created.UtcDateTime;
		IsAbsoluteLatestVersion = package.get_IsAbsoluteLatestVersion();
		IsLatestVersion = package.get_IsLatestVersion();
		Path = derivedData.Path;
		FullPath = derivedData.FullPath;
	}

	private IEnumerable<string> ConvertDependencySetToStrings(PackageDependencySet dependencySet)
	{
		if (dependencySet.get_Dependencies().Count == 0)
		{
			if (dependencySet.get_TargetFramework() != null)
			{
				return new string[1] { $"::{VersionUtility.GetShortFrameworkName(dependencySet.get_TargetFramework())}" };
			}
			return new string[0];
		}
		return from dependency in dependencySet.get_Dependencies()
			select ConvertDependency(dependency, dependencySet.get_TargetFramework());
	}

	private string ConvertDependency(PackageDependency packageDependency, FrameworkName targetFramework)
	{
		if (targetFramework == null)
		{
			if (packageDependency.get_VersionSpec() == null)
			{
				return packageDependency.get_Id();
			}
			return $"{packageDependency.get_Id()}:{packageDependency.get_VersionSpec()}";
		}
		return $"{packageDependency.get_Id()}:{packageDependency.get_VersionSpec()}:{VersionUtility.GetShortFrameworkName(targetFramework)}";
	}
}
