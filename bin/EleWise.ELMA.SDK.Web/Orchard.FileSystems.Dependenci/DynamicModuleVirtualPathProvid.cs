using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using EleWise.ELMA.Logging;
using Orchard.Environment.Configuration;
using Orchard.FileSystems.VirtualPath;
using Orchard.Logging;

namespace Orchard.FileSystems.Dependencies;

public class DynamicModuleVirtualPathProvider : VirtualPathProvider, ICustomVirtualPathProvider
{
	private readonly IExtensionDependenciesManager _extensionDependenciesManager;

	private string[] _extensionsVirtualPathPrefixes;

	public ILogger Logger { get; set; }

	VirtualPathProvider ICustomVirtualPathProvider.Instance => this;

	public DynamicModuleVirtualPathProvider(IExtensionDependenciesManager extensionDependenciesManager, ExtensionLocations extensionLocations)
	{
		_extensionDependenciesManager = extensionDependenciesManager;
		Logger = NullLogger.Instance;
		_extensionsVirtualPathPrefixes = extensionLocations.ExtensionsVirtualPathPrefixes;
	}

	public override string GetFileHash(string virtualPath, IEnumerable virtualPathDependencies)
	{
		string fileHashWorker = GetFileHashWorker(virtualPath, virtualPathDependencies);
		Logger.Debug("GetFileHash(\"{0}\"): {1}", virtualPath, fileHashWorker);
		return fileHashWorker;
	}

	private string GetFileHashWorker(string virtualPath, IEnumerable virtualPathDependencies)
	{
		virtualPath = VirtualPathUtility.ToAppRelative(virtualPath);
		ActivatedExtensionDescriptor extensionDescriptor = GetExtensionDescriptor(virtualPath);
		if (extensionDescriptor != null && extensionDescriptor.VirtualPath.Equals(virtualPath, StringComparison.OrdinalIgnoreCase))
		{
			return extensionDescriptor.Hash;
		}
		return base.GetFileHash(virtualPath, virtualPathDependencies);
	}

	private ActivatedExtensionDescriptor GetExtensionDescriptor(string virtualPath)
	{
		string text = PrefixMatch(virtualPath, _extensionsVirtualPathPrefixes);
		if (text == null)
		{
			return null;
		}
		string text2 = ModuleMatch(virtualPath, text);
		if (text2 == null)
		{
			return null;
		}
		return _extensionDependenciesManager.GetDescriptor(text2);
	}

	private static string ModuleMatch(string virtualPath, string prefix)
	{
		int num = virtualPath.IndexOf('/', prefix.Length, virtualPath.Length - prefix.Length);
		if (num < 0)
		{
			return null;
		}
		string text = virtualPath.Substring(prefix.Length, num - prefix.Length);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return null;
	}

	private static string PrefixMatch(string virtualPath, params string[] prefixes)
	{
		return prefixes.FirstOrDefault((string p) => virtualPath.StartsWith(p, StringComparison.OrdinalIgnoreCase));
	}
}
