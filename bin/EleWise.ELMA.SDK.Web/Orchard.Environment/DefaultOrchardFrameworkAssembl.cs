using System.Collections.Generic;
using System.Reflection;

namespace Orchard.Environment;

public class DefaultOrchardFrameworkAssemblies : IOrchardFrameworkAssemblies, IDependency
{
	public IEnumerable<AssemblyName> GetFrameworkAssemblies()
	{
		return typeof(IDependency).Assembly.GetReferencedAssemblies();
	}
}
