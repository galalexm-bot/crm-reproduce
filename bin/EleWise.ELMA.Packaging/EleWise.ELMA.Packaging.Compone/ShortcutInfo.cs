using System;
using System.IO;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;
using EleWise.ELMA.Packaging.Shortcuts;

namespace EleWise.ELMA.Packaging.Components;

public class ShortcutInfo
{
	public string Name { get; set; }

	public string FileName { get; set; }

	public string Icon { get; set; }

	public void CreateShortcut(string directoryName, string targetFileName, string description)
	{
		if (string.IsNullOrEmpty(directoryName) || string.IsNullOrEmpty(Name))
		{
			return;
		}
		string fileName = Path.Combine(directoryName, Name + ".lnk");
		FS.CreateFile(fileName, delegate
		{
			try
			{
				Shortcut.Create(fileName, targetFileName, null, null, description, null, Icon);
			}
			catch (Exception ex)
			{
				Logger.Log.Error($"{ex.Message}({fileName}:{targetFileName})", ex);
			}
		});
	}

	public void DeleteShortcut(string directoryName, bool deleteDirectoryIfEmpty = false)
	{
		if (!string.IsNullOrEmpty(directoryName) && !string.IsNullOrEmpty(Name))
		{
			FS.DeleteFile(Path.Combine(directoryName, Name + ".lnk"), deleteDirectoryIfEmpty, directoryName);
		}
	}

	public void CreateInternetShortcut(string directoryName, string url)
	{
		if (!string.IsNullOrEmpty(directoryName) && !string.IsNullOrEmpty(Name))
		{
			if (!Directory.Exists(directoryName))
			{
				FS.CreateDirectory(directoryName);
			}
			string fileName = Path.Combine(directoryName, Name + ".url");
			FS.CreateFile(fileName, delegate
			{
				File.WriteAllLines(fileName, new string[2]
				{
					"[InternetShortcut]",
					"URL=" + url
				});
			});
		}
	}

	public void DeleteInternetShortcut(string directoryName, bool deleteDirectoryIfEmpty = false)
	{
		if (!string.IsNullOrEmpty(directoryName) && !string.IsNullOrEmpty(Name))
		{
			FS.DeleteFile(Path.Combine(directoryName, Name + ".url"), deleteDirectoryIfEmpty, directoryName);
		}
	}

	public static string GetInternetShortcutUrl(string fileName)
	{
		if (!File.Exists(fileName))
		{
			return null;
		}
		string[] array = File.ReadAllLines(fileName);
		if (array.Length < 2)
		{
			return null;
		}
		if (!array[0].Trim().Equals("[InternetShortcut]", StringComparison.CurrentCultureIgnoreCase))
		{
			return null;
		}
		if (!array[1].StartsWith("URL="))
		{
			return null;
		}
		return array[1].Substring(4).Trim();
	}
}
