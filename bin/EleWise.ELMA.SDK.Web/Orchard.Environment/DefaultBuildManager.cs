using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Compilation;
using EleWise.ELMA.Logging;
using Orchard.Exceptions;
using Orchard.FileSystems.VirtualPath;
using Orchard.Logging;

namespace Orchard.Environment;

public class DefaultBuildManager : IBuildManager, IDependency
{
	private readonly IVirtualPathProvider _virtualPathProvider;

	private readonly IAssemblyLoader _assemblyLoader;

	public ILogger Logger { get; set; }

	public DefaultBuildManager(IVirtualPathProvider virtualPathProvider, IAssemblyLoader assemblyLoader)
	{
		_virtualPathProvider = virtualPathProvider;
		_assemblyLoader = assemblyLoader;
		Logger = NullLogger.Instance;
	}

	public IEnumerable<Assembly> GetReferencedAssemblies()
	{
		return BuildManager.GetReferencedAssemblies().OfType<Assembly>();
	}

	public bool HasReferencedAssembly(string name)
	{
		string virtualPath = _virtualPathProvider.Combine("~/bin", name + ".dll");
		return _virtualPathProvider.FileExists(virtualPath);
	}

	public Assembly GetReferencedAssembly(string name)
	{
		if (!HasReferencedAssembly(name))
		{
			return null;
		}
		return _assemblyLoader.Load(name);
	}

	public Assembly GetCompiledAssembly(string virtualPath)
	{
		try
		{
			return BuildManager.GetCompiledAssembly(virtualPath);
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			Logger.Warning(ex, "Error when compiling assembly under {0}.", virtualPath);
			return null;
		}
	}
}
