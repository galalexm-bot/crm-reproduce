using System.Collections.Generic;
using System.Reflection;

namespace Orchard.Environment;

public interface IOrchardFrameworkAssemblies : IDependency
{
	IEnumerable<AssemblyName> GetFrameworkAssemblies();
}
