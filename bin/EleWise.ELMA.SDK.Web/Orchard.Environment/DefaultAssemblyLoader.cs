using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Logging;
using Orchard.Exceptions;

namespace Orchard.Environment;

public class DefaultAssemblyLoader : IAssemblyLoader
{
	private readonly IEnumerable<IAssemblyNameResolver> _assemblyNameResolvers;

	private readonly ConcurrentDictionary<string, Assembly> _loadedAssemblies = new ConcurrentDictionary<string, Assembly>(StringComparer.OrdinalIgnoreCase);

	public ILogger Logger { get; set; }

	public DefaultAssemblyLoader(IEnumerable<IAssemblyNameResolver> assemblyNameResolvers)
	{
		_assemblyNameResolvers = assemblyNameResolvers.OrderBy((IAssemblyNameResolver l) => l.Order);
		Logger = NullLogger.Instance;
	}

	public Assembly Load(string assemblyName)
	{
		try
		{
			return _loadedAssemblies.GetOrAdd(this.ExtractAssemblyShortName(assemblyName), (string shortName) => LoadWorker(shortName, assemblyName));
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			Logger.Error(ex, "Error loading assembly '{0}'", assemblyName);
			return null;
		}
	}

	private Assembly LoadWorker(string shortName, string fullName)
	{
		Assembly assembly;
		if (fullName != shortName)
		{
			assembly = TryAssemblyLoad(fullName);
			if (assembly != null)
			{
				return assembly;
			}
		}
		assembly = TryAssemblyLoad(shortName);
		if (assembly != null)
		{
			return assembly;
		}
		string text = _assemblyNameResolvers.Select((IAssemblyNameResolver r) => r.Resolve(shortName)).FirstOrDefault((string f) => f != null);
		if (text != null)
		{
			return Assembly.Load(text);
		}
		return Assembly.Load(fullName);
	}

	private static Assembly TryAssemblyLoad(string name)
	{
		try
		{
			return Assembly.Load(name);
		}
		catch
		{
			return null;
		}
	}
}
