using System;
using System.Linq;
using System.Reflection;
using Orchard.Caching;

namespace Orchard.Environment;

public class OrchardFrameworkAssemblyNameResolver : IAssemblyNameResolver
{
	private readonly ICacheManager _cacheManager;

	public int Order => 20;

	public OrchardFrameworkAssemblyNameResolver(ICacheManager cacheManager)
	{
		_cacheManager = cacheManager;
	}

	public string Resolve(string shortName)
	{
		if (_cacheManager.Get(typeof(IAssemblyLoader), preventConcurrentCalls: true, (AcquireContext<Type> ctx) => ctx.Key.Assembly.GetReferencedAssemblies().GroupBy((AssemblyName n) => AssemblyLoaderExtensions.ExtractAssemblyShortName(n.FullName), StringComparer.OrdinalIgnoreCase).ToDictionary((IGrouping<string, AssemblyName> n) => n.Key, (IGrouping<string, AssemblyName> g) => g.OrderBy((AssemblyName n) => n.Version).Last(), StringComparer.OrdinalIgnoreCase)).TryGetValue(shortName, out var value))
		{
			return value.FullName;
		}
		return null;
	}
}
