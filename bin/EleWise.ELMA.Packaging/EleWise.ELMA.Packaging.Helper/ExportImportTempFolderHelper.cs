using System;
using System.IO;

namespace EleWise.ELMA.Packaging.Helper;

public static class ExportImportTempFolderHelper
{
	private const string PackagingTempSubFolder = "Packaging";

	private const string ElmaTempSubFolder = "ELMA";

	public static string GetTempUniqueFolder(string prefix)
	{
		return GetTempUniqueFolder(null, prefix);
	}

	public static string GetTempUniqueFolder(string tempFolder, string prefix)
	{
		if (string.IsNullOrWhiteSpace(tempFolder))
		{
			tempFolder = GetDefaultExportImportTempFolder();
		}
		string text = Guid.NewGuid().ToString("n");
		string text2 = Path.Combine(tempFolder, string.IsNullOrWhiteSpace(prefix) ? text : (prefix + "_" + text));
		if (!Directory.Exists(text2))
		{
			Directory.CreateDirectory(text2);
		}
		return text2;
	}

	private static string GetDefaultExportImportTempFolder()
	{
		string text = Path.Combine(Path.GetTempPath(), "ELMA", "Packaging");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return text;
	}
}
