using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;
using System.Web.Razor.Generator;
using System.Web.WebPages.Razor;
using EleWise.ELMA.Logging;
using Orchard.Environment;
using Orchard.Environment.Extensions.Loaders;
using Orchard.FileSystems.Dependencies;
using Orchard.FileSystems.VirtualPath;
using Orchard.Logging;

namespace Orchard.Mvc.ViewEngines.Razor;

public class DefaultRazorCompilationEvents : IRazorCompilationEvents
{
	private readonly IDependenciesFolder _dependenciesFolder;

	private readonly IExtensionDependenciesManager _extensionDependenciesManager;

	private readonly IBuildManager _buildManager;

	private readonly IEnumerable<IExtensionLoader> _loaders;

	private readonly IAssemblyLoader _assemblyLoader;

	private readonly IVirtualPathProvider _virtualPathProvider;

	public ILogger Logger { get; set; }

	public DefaultRazorCompilationEvents(IDependenciesFolder dependenciesFolder, IExtensionDependenciesManager extensionDependenciesManager, IBuildManager buildManager, IEnumerable<IExtensionLoader> loaders, IAssemblyLoader assemblyLoader, IVirtualPathProvider virtualPathProvider)
	{
		_dependenciesFolder = dependenciesFolder;
		_extensionDependenciesManager = extensionDependenciesManager;
		_buildManager = buildManager;
		_loaders = loaders;
		_assemblyLoader = assemblyLoader;
		_virtualPathProvider = virtualPathProvider;
		Logger = NullLogger.Instance;
	}

	public void CodeGenerationStarted(RazorBuildProvider provider)
	{
		List<Assembly> list = new List<Assembly>();
		GetModuleDependencyDescriptor(provider.get_VirtualPath());
		IEnumerable<DependencyDescriptor> source = _dependenciesFolder.LoadDescriptors();
		foreach (string item in source.SelectMany((DependencyDescriptor descriptor) => from loader in _loaders
			where descriptor.LoaderName == loader.Name
			select new
			{
				loader = loader,
				descriptor = descriptor,
				references = loader.GetCompilationReferences(descriptor),
				dependencies = _extensionDependenciesManager.GetVirtualPathDependencies(descriptor.Name)
			}).SelectMany(e => e.dependencies).Distinct(StringComparer.OrdinalIgnoreCase)
			.ToList())
		{
			provider.AddVirtualPathDependency(item);
		}
		foreach (string item2 in (from dep in source
			select dep.VirtualPath into vp
			where vp != null && vp.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) && !vp.StartsWith("~/bin/", StringComparison.OrdinalIgnoreCase)
			select vp).Distinct(StringComparer.OrdinalIgnoreCase))
		{
			Assembly assembly = Assembly.LoadFrom(_virtualPathProvider.MapPath(item2));
			if (assembly != null)
			{
				provider.get_AssemblyBuilder().AddAssemblyReference(assembly);
			}
		}
		if (!Logger.IsEnabled(LogLevel.Debug))
		{
			return;
		}
		if (list.Count == 0 && ((BuildProvider)(object)provider).VirtualPathDependencies == null)
		{
			Logger.Debug("CodeGenerationStarted(\"{0}\") - no dependencies.", provider.get_VirtualPath());
			return;
		}
		Logger.Debug("CodeGenerationStarted(\"{0}\") - Dependencies: ", provider.get_VirtualPath());
		if (((BuildProvider)(object)provider).VirtualPathDependencies != null)
		{
			foreach (object virtualPathDependency in ((BuildProvider)(object)provider).VirtualPathDependencies)
			{
				Logger.Debug("  VirtualPath: \"{0}\"", virtualPathDependency);
			}
		}
		foreach (Assembly item3 in list)
		{
			Logger.Debug("  Reference: \"{0}\"", item3);
		}
	}

	private DependencyDescriptor GetModuleDependencyDescriptor(string virtualPath)
	{
		string virtualPath2 = VirtualPathUtility.ToAppRelative(virtualPath);
		string text = PrefixMatch(virtualPath2, "~/Modules/", "~/Core/");
		if (text == null)
		{
			return null;
		}
		string text2 = ModuleMatch(virtualPath2, text);
		if (text2 == null)
		{
			return null;
		}
		return _dependenciesFolder.GetDescriptor(text2);
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

	public void CodeGenerationCompleted(RazorBuildProvider provider, CodeGenerationCompleteEventArgs e)
	{
	}
}
