using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Util;

public class LocalizationUtility
{
	private class JSCache
	{
		private string id;

		private string locDir;

		private string baseLocDir;

		private FileSystemWatcher watcher;

		private object readLock = new object();

		public Dictionary<string, string> Values { get; private set; }

		public string ErrorMessage { get; private set; }

		public JSCache(string id)
		{
			this.id = id;
			string dir = SR.Dir;
			if (!Directory.Exists(dir))
			{
				ErrorMessage = SR.T("Не найдена папка с переводами: {0}", dir);
				return;
			}
			locDir = Path.Combine(dir, id);
			if (!Directory.Exists(locDir))
			{
				ErrorMessage = SR.T("Не найдена папка с переводами: {0}", locDir);
				return;
			}
			baseLocDir = Path.Combine(dir, "base");
			Read();
			watcher = new FileSystemWatcher
			{
				Path = locDir
			};
			watcher.Created += DirectoryChanged;
			watcher.Changed += DirectoryChanged;
			watcher.EnableRaisingEvents = true;
		}

		private void Read()
		{
			lock (readLock)
			{
				Dictionary<string, string> values = null;
				string errorMessage = null;
				try
				{
					List<string> baseFileNames = (Directory.Exists(baseLocDir) ? (from f in Directory.GetFiles(locDir, "*.po")
						orderby f.ToLower()
						select f).ToList() : new List<string>());
					List<string> localeFileNames = (from f in Directory.GetFiles(locDir, "*.po")
						orderby f.ToLower()
						select f).ToList();
					try
					{
						values = PoJsExtractor.Extract(localeFileNames, baseFileNames);
					}
					catch (Exception exception)
					{
						Logger.Log.Error($"Cannot load JS resources for locale {id}", exception);
						errorMessage = "Cannot load JS resources";
					}
				}
				finally
				{
					Values = values;
					ErrorMessage = errorMessage;
				}
			}
		}

		protected void DirectoryChanged(object sender, FileSystemEventArgs e)
		{
			Read();
		}
	}

	private static ConcurrentDictionary<string, JSCache> jsCaches = new ConcurrentDictionary<string, JSCache>();

	public static Dictionary<string, string> GetJSPoStrings(string id, out string msg)
	{
		JSCache orAdd = jsCaches.GetOrAdd(id, (string idParam) => new JSCache(idParam));
		msg = orAdd.ErrorMessage;
		return orAdd.Values;
	}

	public static Dictionary<string, string> GetJSPoStringsSource()
	{
		string msg;
		if (!TranslateService.Instance.IsTranslationModeEnabled())
		{
			return GetJSPoStrings(SR.GetCurrentCulture().Name, out msg);
		}
		return GetJSPoFromTranslateService(SR.GetCurrentCulture().Name);
	}

	public static Dictionary<string, string> GetJSPoStringsTarget()
	{
		if (!TranslateService.Instance.IsTranslationModeEnabled())
		{
			return new Dictionary<string, string>();
		}
		string translateLocalization = TranslateService.Instance.GetTranslateLocalization();
		if (translateLocalization == null)
		{
			return new Dictionary<string, string>();
		}
		return GetJSPoFromTranslateService(translateLocalization);
	}

	private static Dictionary<string, string> GetJSPoFromTranslateService(string id)
	{
		LocalizationHolder translation = TranslateService.Instance.GetTranslation(id);
		if (translation == null)
		{
			return new Dictionary<string, string>();
		}
		LocalizationHolder translation2 = TranslateService.Instance.GetTranslation(SR.KeyCultureInfo.Name);
		List<string> list = new List<string>();
		if (translation2 != null)
		{
			foreach (LocalizationFile file in translation2.Files)
			{
				if (file.Resources == null)
				{
					continue;
				}
				foreach (PoLineDescriptor resource in file.Resources)
				{
					if (resource.IsJsBlock && !list.Contains(resource.Key))
					{
						list.Add(resource.Key);
					}
				}
			}
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (LocalizationFile file2 in translation.Files)
		{
			if (file2.Resources == null)
			{
				continue;
			}
			foreach (PoLineDescriptor resource2 in file2.Resources)
			{
				if (resource2.IsJsBlock || list.Contains(resource2.Key))
				{
					dictionary[resource2.Key] = resource2.Value;
				}
			}
		}
		return dictionary;
	}
}
