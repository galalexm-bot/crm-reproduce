using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using EleWise.ELMA.Services;
using EleWise.ELMA.WebCompiler;

namespace EleWise.ELMA.Web.Mvc;

public class ConfigDirectoryMapVirtualPathProvider : DirectoryMapVirtualPathProvider
{
	private class ConfigVirtialFile : MapPathVirtualFile
	{
		public ConfigVirtialFile(string virtualPath, string physicalPath)
			: base(virtualPath, physicalPath)
		{
		}
	}

	public const string ConfigWebApplication = "WebApplication";

	private static IDictionary<string, string> GetMap(string[] virtualPaths)
	{
		string configurationDir = Path.Combine(Locator.GetServiceNotNull<EleWise.ELMA.Services.ConfigurationDirectoryFileWatcher>().WatchRoot, "WebApplication");
		return virtualPaths.ToDictionary((string p) => p, (string p) => p.Replace("~", configurationDir).Replace('/', '\\'));
	}

	public ConfigDirectoryMapVirtualPathProvider(params string[] virtualPaths)
		: base(GetMap(virtualPaths), Locator.GetServiceNotNull<EleWise.ELMA.Services.ConfigurationDirectoryFileWatcher>())
	{
	}

	public static bool IsConfigFile(string virtualPath)
	{
		return HostingEnvironment.VirtualPathProvider.GetFile(virtualPath) is ConfigVirtialFile;
	}
}
