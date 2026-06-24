using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using NuGet;
using NuGet.Resources;

namespace EleWise.ELMA.Packaging.Server.Infrastructure;

internal class ServerUnzippedPackage : LocalPackage
{
	private readonly IFileSystem repositoryFileSystem;

	private readonly string packageFileName;

	private readonly string packagePath;

	public ServerUnzippedPackage(IFileSystem repositoryFileSystem, string packageName)
	{
		if (repositoryFileSystem == null)
		{
			throw new ArgumentNullException("repositoryFileSystem");
		}
		if (string.IsNullOrEmpty(packageName))
		{
			throw new ArgumentException("packageName");
		}
		packageFileName = packageName + Constants.PackageExtension;
		packagePath = packageName;
		this.repositoryFileSystem = repositoryFileSystem;
		if (repositoryFileSystem.FileExists(packageFileName))
		{
			EnsureManifest(packageName + Constants.ManifestExtension);
			return;
		}
		string manifestFilePath = Path.Combine(packageName, packageName + Constants.ManifestExtension);
		EnsureManifest(manifestFilePath);
	}

	public override Stream GetStream()
	{
		if (repositoryFileSystem.FileExists(packageFileName))
		{
			return repositoryFileSystem.OpenFile(packageFileName);
		}
		string text = Path.Combine(packagePath, packageFileName);
		return repositoryFileSystem.OpenFile(text);
	}

	public override void ExtractContents(IFileSystem fileSystem, string extractPath)
	{
		foreach (PhysicalPackageFile item in ((LocalPackage)this).GetFilesBase().Cast<PhysicalPackageFile>())
		{
			string text = Path.Combine(extractPath, item.get_TargetPath());
			using Stream stream = item.GetStream();
			fileSystem.AddFile(text, stream);
		}
	}

	public override IEnumerable<FrameworkName> GetSupportedFrameworks()
	{
		string effectivePath = default(string);
		IEnumerable<FrameworkName> second = from file in GetPackageFilePaths().Select(GetPackageRelativePath)
			let targetFramework = VersionUtility.ParseFrameworkNameFromFilePath(file, ref effectivePath)
			where targetFramework != null
			select targetFramework;
		return ((LocalPackage)this).GetSupportedFrameworks().Concat(second).Distinct();
	}

	protected override IEnumerable<IPackageFile> GetFilesBase()
	{
		return (IEnumerable<IPackageFile>)GetPackageFilePaths().Select((Func<string, PhysicalPackageFile>)delegate(string p)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			PhysicalPackageFile val = new PhysicalPackageFile();
			val.set_SourcePath(repositoryFileSystem.GetFullPath(p));
			val.set_TargetPath(GetPackageRelativePath(p));
			return val;
		});
	}

	protected override IEnumerable<IPackageAssemblyReference> GetAssemblyReferencesCore()
	{
		string text = Path.Combine(packagePath, Constants.LibDirectory);
		return (IEnumerable<IPackageAssemblyReference>)(from p in repositoryFileSystem.GetFiles(text, "*.*", true)
			let targetPath = GetPackageRelativePath(p)
			where LocalPackage.IsAssemblyReference(targetPath)
			select _003C_003Eh__TransparentIdentifier0).Select(_003C_003Eh__TransparentIdentifier0 =>
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			PhysicalPackageAssemblyReference val = new PhysicalPackageAssemblyReference();
			((PhysicalPackageFile)val).set_SourcePath(repositoryFileSystem.GetFullPath(_003C_003Eh__TransparentIdentifier0.p));
			((PhysicalPackageFile)val).set_TargetPath(_003C_003Eh__TransparentIdentifier0.targetPath);
			return val;
		});
	}

	private IEnumerable<string> GetPackageFilePaths()
	{
		return from p in repositoryFileSystem.GetFiles(packagePath, "*.*", true)
			where !PackageHelper.IsUnzippedPackageManifest(p, ((LocalPackage)this).get_Id(), ((LocalPackage)this).get_Version()) && !PackageHelper.IsPackageManifest(p, ((LocalPackage)this).get_Id()) && !PackageHelper.IsPackageFile(p)
			select p;
	}

	private string GetPackageRelativePath(string path)
	{
		return path.Substring(packagePath.Length + 1);
	}

	private void EnsureManifest(string manifestFilePath)
	{
		if (!repositoryFileSystem.FileExists(manifestFilePath))
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, NuGetResources.get_Manifest_NotFound(), repositoryFileSystem.GetFullPath(manifestFilePath)));
		}
		using (Stream stream = repositoryFileSystem.OpenFile(manifestFilePath))
		{
			((LocalPackage)this).ReadManifest(stream);
		}
		string text = Path.Combine(packagePath, packageFileName + Constants.XManifestExtension);
		using (Stream stream2 = (File.Exists(text) ? repositoryFileSystem.OpenFile(text) : null))
		{
			((LocalPackage)this).ReadXManifest(stream2);
		}
		((LocalPackage)this).set_Published((DateTimeOffset?)repositoryFileSystem.GetLastModified(manifestFilePath));
	}
}
