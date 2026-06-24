using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using NuGet;

namespace EleWise.ELMA.Packaging.Internal.NuGet;

internal class ReadOnlyZipPackage : ZipPackage
{
	private readonly string packagePhysicalPath;

	private static readonly string[] ExcludePaths = new string[2] { "_rels", "package" };

	public ReadOnlyZipPackage(string filePath)
		: base(filePath)
	{
		packagePhysicalPath = filePath;
	}

	protected override IEnumerable<IPackageFile> GetFilesBase()
	{
		using Package package = Package.Open(packagePhysicalPath, FileMode.Open, FileAccess.Read, FileShare.Read);
		string packageId = ZipPackage.GetPackageIdentifier(package);
		return (from part in package.GetParts()
			where IsPackageFile(part, packageId)
			select (IPackageFile)(object)new ReadOnlyZipPackageFile(packagePhysicalPath, GetRelativePath(part.Uri))).ToList();
	}

	protected override IEnumerable<IPackageAssemblyReference> GetAssemblyReferencesCore()
	{
		return (from file in ((LocalPackage)this).GetFiles()
			where LocalPackage.IsAssemblyReference(file.get_Path())
			select (IPackageAssemblyReference)(object)new ReadOnlyZipAssemblyReference(file)).ToList();
	}

	private static bool IsPackageFile(PackagePart part, string packageId)
	{
		string relativePath = GetRelativePath(part.Uri);
		string directory = Path.GetDirectoryName(relativePath);
		if (!ExcludePaths.Any((string p) => directory.StartsWith(p, StringComparison.OrdinalIgnoreCase)))
		{
			return !PackageHelper.IsPackageManifest(relativePath, packageId);
		}
		return false;
	}

	private static string GetRelativePath(Uri uri)
	{
		string text = uri.OriginalString;
		if (text.StartsWith("/", StringComparison.Ordinal))
		{
			text = text.Substring(1);
		}
		return Uri.UnescapeDataString(text.Replace('/', Path.DirectorySeparatorChar));
	}
}
