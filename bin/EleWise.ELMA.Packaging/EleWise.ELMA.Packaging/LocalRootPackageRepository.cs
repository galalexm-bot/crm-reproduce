using System;
using System.IO;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal class LocalRootPackageRepository : LocalPackageRepository
{
	public LocalRootPackageRepository(IPackagePathResolver pathResolver, IFileSystem fileSystem)
		: base(pathResolver, fileSystem, true)
	{
	}

	public override void AddPackage(IPackage package)
	{
		string text = Path.Combine(Path.GetDirectoryName(((LocalPackageRepository)this).get_PathResolver().GetPackageDirectory(package)), ((LocalPackageRepository)this).get_PathResolver().GetPackageFileName(package));
		((LocalPackageRepository)this).get_FileSystem().get_Logger().Log((MessageLevel)2, SR.T("Проверка файла '{0}'", text), Array.Empty<object>());
		if (((LocalPackageRepository)this).get_FileSystem().FileExists(text))
		{
			((LocalPackageRepository)this).get_FileSystem().get_Logger().Log((MessageLevel)1, SR.T("Файл '{0}' уже существует", text), Array.Empty<object>());
			return;
		}
		((LocalPackageRepository)this).get_FileSystem().get_Logger().Log((MessageLevel)2, SR.T("Загружаем файл '{0}'", text), Array.Empty<object>());
		using Stream stream = package.GetStream();
		((LocalPackageRepository)this).get_FileSystem().AddFile(text, stream);
	}
}
