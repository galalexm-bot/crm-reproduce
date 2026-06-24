using System;
using System.Linq;
using System.Reflection;

namespace Orchard.Environment;

public class AppDomainAssemblyNameResolver : IAssemblyNameResolver
{
	public int Order => 10;

	public string Resolve(string shortName)
	{
		return (from a in AppDomain.CurrentDomain.GetAssemblies()
			where StringComparer.OrdinalIgnoreCase.Equals(shortName, AssemblyLoaderExtensions.ExtractAssemblyShortName(a.FullName))
			select a.FullName).SingleOrDefault();
	}
}
