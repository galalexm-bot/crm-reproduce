using System.Collections.Generic;
using System.Reflection;

namespace Orchard.Environment;

public interface IBuildManager : IDependency
{
	IEnumerable<Assembly> GetReferencedAssemblies();

	bool HasReferencedAssembly(string name);

	Assembly GetReferencedAssembly(string name);

	Assembly GetCompiledAssembly(string virtualPath);
}
