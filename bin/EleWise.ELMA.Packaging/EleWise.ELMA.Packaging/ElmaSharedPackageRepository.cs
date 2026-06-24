using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal class ElmaSharedPackageRepository : SharedPackageRepository
{
	public ElmaSharedPackageRepository(string path)
		: base(path)
	{
	}

	public ElmaSharedPackageRepository(IPackagePathResolver resolver, IFileSystem fileSystem, IFileSystem configSettingsFileSystem)
		: base(resolver, fileSystem, configSettingsFileSystem)
	{
	}

	public ElmaSharedPackageRepository(IPackagePathResolver resolver, IFileSystem fileSystem, IFileSystem storeFileSystem, IFileSystem configSettingsFileSystem)
		: base(resolver, fileSystem, storeFileSystem, configSettingsFileSystem)
	{
	}

	public ElmaSharedPackageRepository(IPackagePathResolver resolver, IFileSystem fileSystem, IFileSystem storeFileSystem, IFileSystem configSettingsFileSystem, bool enableCaching, bool enablePackageCaching)
		: base(resolver, fileSystem, storeFileSystem, configSettingsFileSystem)
	{
	}

	public override void RemovePackage(IPackage package)
	{
		Logger.Log.Info(SR.T("Удаление пакета '{0}' из локального репозитория...", PackageExtensions.GetFullName((IPackageName)(object)package)));
		string packageDirectory = ((LocalPackageRepository)this).get_PathResolver().GetPackageDirectory(((IPackageName)package).get_Id(), ((IPackageName)package).get_Version());
		string text = packageDirectory + Constants.PackageExtension;
		if (((LocalPackageRepository)this).get_FileSystem().FileExists(text))
		{
			FS.DeleteFile(((LocalPackageRepository)this).get_FileSystem().GetFullPath(text));
		}
		string text2 = packageDirectory + Constants.ManifestExtension;
		if (((LocalPackageRepository)this).get_FileSystem().FileExists(text2))
		{
			FS.DeleteFile(((LocalPackageRepository)this).get_FileSystem().GetFullPath(text2));
		}
		Logger.Log.Debug(SR.T("Пакет '{0}' удален.", PackageExtensions.GetFullName((IPackageName)(object)package)));
	}
}
