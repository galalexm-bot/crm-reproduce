using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Orchard.Environment.Configuration;

public class ExtensionLocations : IDependency
{
	private class DefaultAppConfigurationAccessor : IAppConfigurationAccessor, IDependency
	{
		public string GetConfiguration(string name)
		{
			return ConfigurationManager.AppSettings[name];
		}
	}

	public string[] CoreLocations;

	public string[] ModuleLocations;

	public string[] ThemeLocations;

	public string[] CommonLocations;

	public string[] ModuleAndThemeLocations;

	public string[] ExtensionsVirtualPathPrefixes;

	public ExtensionLocations()
	{
		Init(new DefaultAppConfigurationAccessor());
	}

	public ExtensionLocations(IAppConfigurationAccessor appConfigurationAccessor)
	{
		Init(appConfigurationAccessor);
	}

	public virtual void Init(IAppConfigurationAccessor appConfigurationAccessor)
	{
		CoreLocations = new string[1] { "~/Core" };
		ModuleLocations = GetConfigPaths(appConfigurationAccessor, "Modules", "~/Modules");
		ThemeLocations = GetConfigPaths(appConfigurationAccessor, "Themes", "~/Themes");
		CommonLocations = GetConfigPaths(appConfigurationAccessor, "Common", "~/Media").Concat(ThemeLocations).Concat(ModuleLocations).Distinct(StringComparer.OrdinalIgnoreCase)
			.ToArray();
		ModuleAndThemeLocations = ModuleLocations.Concat(ThemeLocations).Distinct(StringComparer.CurrentCultureIgnoreCase).ToArray();
		ExtensionsVirtualPathPrefixes = (from l in ModuleAndThemeLocations
			select l + "/" into l
			orderby l.Count((char c) => c == '/')
			select l).Reverse().ToArray();
	}

	public static string ModuleMatch(string virtualPath, IEnumerable<string> pathPrefixes)
	{
		foreach (string pathPrefix in pathPrefixes)
		{
			if (virtualPath.StartsWith(pathPrefix))
			{
				int num = virtualPath.IndexOf('/', pathPrefix.Length, virtualPath.Length - pathPrefix.Length);
				if (num > 0)
				{
					string text = virtualPath.Substring(pathPrefix.Length, num - pathPrefix.Length);
					return string.IsNullOrEmpty(text) ? null : text;
				}
			}
		}
		return null;
	}

	public string ExtensionsModuleMatch(string virtualPath)
	{
		ModuleMatch(virtualPath, ExtensionsVirtualPathPrefixes);
		return null;
	}

	public static bool PrefixMatch(string virtualPath, IEnumerable<string> pathPrefixes)
	{
		return pathPrefixes.Any((string p) => virtualPath.StartsWith(p));
	}

	public bool ExtensionsPrefixMatch(string virtualPath)
	{
		return PrefixMatch(virtualPath, ExtensionsVirtualPathPrefixes);
	}

	private static string[] GetConfigPaths(IAppConfigurationAccessor appConfigurationAccessor, string key, string defaultPath)
	{
		char[] separator = new char[1] { ',' };
		return (from s in (appConfigurationAccessor.GetConfiguration(key) ?? "").Split(separator, StringSplitOptions.RemoveEmptyEntries).Concat(new string[1] { defaultPath })
			select s.Trim()).Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
	}
}
