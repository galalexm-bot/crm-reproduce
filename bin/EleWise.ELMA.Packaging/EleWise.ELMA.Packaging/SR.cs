using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Threading;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.Logging;
using Gettext.Cs;
using ICSharpCode.SharpZipLib.Zip;

namespace EleWise.ELMA.Packaging;

internal class SR
{
	private static readonly List<ResourceManager> managers;

	private const string SDKResourceName = "EleWise.ELMA.SDK";

	private static string resourcesDir;

	private static string fileFormat;

	public static bool DesignMode;

	private static LanguageHolder _languageHolder;

	private static object _languageHolderSinch;

	private const string TemplateInCodeRes = "{{#={0}}}";

	public static CultureInfo KeyCultureInfo => new CultureInfo("ru-RU");

	public static string ResourcesDirectory
	{
		get
		{
			return resourcesDir;
		}
		set
		{
			resourcesDir = value;
		}
	}

	public static string FileFormat
	{
		get
		{
			return fileFormat;
		}
		set
		{
			fileFormat = value;
		}
	}

	static SR()
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		resourcesDir = GetSetting("ResourcesDir", "Resources");
		fileFormat = GetSetting("ResourcesFileFormat", "{{culture}}/{{resource}}.po");
		DesignMode = true;
		_languageHolderSinch = new object();
		ZipConstants.set_DefaultCodePage(850);
		string text = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile), resourcesDir);
		List<string> resourceNames = new List<string> { "EleWise.ELMA.SDK" };
		List<string> cultureNames = new List<string>();
		if (Directory.Exists(text))
		{
			new DirectoryInfo(text).GetDirectories().ToList().ForEach(delegate(DirectoryInfo p)
			{
				if (p != null)
				{
					if (!cultureNames.Contains(p.Name))
					{
						cultureNames.Add(p.Name);
					}
					p.GetFiles("*.po").ToList().ForEach(delegate(FileInfo f)
					{
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(f.Name);
						if (f != null && !resourceNames.Contains(fileNameWithoutExtension))
						{
							resourceNames.Add(fileNameWithoutExtension);
						}
					});
				}
			});
		}
		managers = new List<ResourceManager>();
		foreach (string item2 in resourceNames)
		{
			GettextResourceManager item = new GettextResourceManager(item2, text, fileFormat);
			managers.Add((ResourceManager)(object)item);
		}
	}

	public static List<CultureInfo> GetCultureNames()
	{
		List<DirectoryInfo> source = (from d in new DirectoryInfo(Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile), resourcesDir)).GetDirectories()
			where !d.Name.Equals("base", StringComparison.OrdinalIgnoreCase)
			select d).ToList();
		List<CultureInfo> list = (from c in source.Select(delegate(DirectoryInfo c)
			{
				try
				{
					return new CultureInfo(c.Name);
				}
				catch (Exception ex)
				{
					Logger.Log.Error(ex.Message, ex);
					return null;
				}
			})
			where c != null
			select c).ToList();
		if (!source.Any((DirectoryInfo c) => c.Name.StartsWith(KeyCultureInfo.Name)))
		{
			list.Add(KeyCultureInfo);
		}
		return list;
	}

	public static CultureInfo GetDefaultCulture()
	{
		CultureInfo defaultCulture = GetCultureFromSettings();
		List<CultureInfo> cultureNames = GetCultureNames();
		if (defaultCulture == null)
		{
			return cultureNames.FirstOrDefault((CultureInfo c) => c.Name.Equals(Thread.CurrentThread.CurrentCulture.Name, StringComparison.OrdinalIgnoreCase)) ?? KeyCultureInfo;
		}
		return cultureNames.FirstOrDefault((CultureInfo c) => c.Name.Equals(defaultCulture.Name, StringComparison.OrdinalIgnoreCase)) ?? KeyCultureInfo;
	}

	public static string GetSetting(string setting, string defaultValue = null)
	{
		NameValueCollection appSettings = ConfigurationManager.AppSettings;
		string text;
		if (appSettings != null)
		{
			text = appSettings[setting];
			if (text == null)
			{
				return defaultValue;
			}
		}
		else
		{
			text = defaultValue;
		}
		return text;
	}

	private static string GetString(string s, CultureInfo cultureInfo)
	{
		string text = null;
		foreach (ResourceManager manager in managers)
		{
			text = manager.GetString(s.Replace("\r", ""), cultureInfo);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return text;
	}

	public static string ExtractKeyFromString(string str)
	{
		if (string.IsNullOrEmpty(str))
		{
			return str;
		}
		if (str.StartsWith("SR.M('", StringComparison.OrdinalIgnoreCase) || str.StartsWith("SR.T('", StringComparison.OrdinalIgnoreCase))
		{
			int length = str.Length - 8;
			str = str.Substring(6, length);
		}
		return str.Replace("\r", "");
	}

	public static string T(string t)
	{
		return T(null, t);
	}

	public static string T(CultureInfo info, string t)
	{
		t = ExtractKeyFromString(t);
		if (!DesignMode)
		{
			if (string.IsNullOrEmpty(t))
			{
				return t;
			}
			string @string = GetString(t, info);
			if (!string.IsNullOrEmpty(@string))
			{
				return @string;
			}
			return t;
		}
		return $"{{#={t}}}";
	}

	public static string T(string t, params object[] parameters)
	{
		return T(null, t, parameters);
	}

	public static string T(CultureInfo info, string t, params object[] parameters)
	{
		t = ExtractKeyFromString(t);
		if (string.IsNullOrEmpty(t))
		{
			return t;
		}
		if (DesignMode)
		{
			return $"{{#={t}}}";
		}
		return string.Format(T(info, t), parameters);
	}

	public static string M(string t)
	{
		return t;
	}

	public static IEnumerable<ResourceSet> GetResourceSet(CultureInfo culture)
	{
		return from m in managers
			where m != null
			select m.GetResourceSet(culture, createIfNotExists: true, tryParents: true);
	}

	public static CultureInfo GetCultureFromSettings()
	{
		if (_languageHolder == null)
		{
			InitLanguageHolder();
		}
		if (_languageHolder != null)
		{
			return _languageHolder.GetCulture();
		}
		return null;
	}

	private static void InitLanguageHolder()
	{
		string directoryName = Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
		if (!Directory.Exists(directoryName))
		{
			return;
		}
		string text = Path.Combine(directoryName, "Language.xml");
		if (!File.Exists(text))
		{
			return;
		}
		lock (_languageHolderSinch)
		{
			try
			{
				_languageHolder = ManifestBuilder.DeserializeByXmlFromFile<LanguageHolder>(text);
			}
			catch (Exception ex)
			{
				Logger.Log.Error(ex.Message, ex);
			}
		}
	}
}
