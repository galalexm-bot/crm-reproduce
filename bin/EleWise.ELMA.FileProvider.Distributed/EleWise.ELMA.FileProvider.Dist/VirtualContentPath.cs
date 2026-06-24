using System;
using System.Linq;

namespace EleWise.ELMA.FileProvider.Distributed;

public static class VirtualContentPath
{
	public static string PersistentFolderName = "files";

	public static string TempFolderName = "temp";

	public static string PreviewFolderName = "previews";

	public static string GetNameFromVirtualPath(string virtualPath)
	{
		string[] array = virtualPath.Split(new char[1] { '/' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length <= 1)
		{
			throw new ArgumentException(SR.T("Переданная строка не является виртуальным путём контента."));
		}
		return array.Last();
	}

	public static bool IsPersistentPath(string path)
	{
		string[] array = path.Split(new char[1] { '/' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length > 1)
		{
			return array[0] == PersistentFolderName;
		}
		return false;
	}

	public static bool IsPersistentPath(Uri location)
	{
		return IsPersistentPath(location.LocalPath);
	}
}
