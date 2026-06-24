using System;
using System.Reflection;
using Orchard.Caching;

namespace Orchard.FileSystems.Dependencies;

public interface IAssemblyProbingFolder : IVolatileProvider, ISingletonDependency, IDependency
{
	bool AssemblyExists(string moduleName);

	DateTime GetAssemblyDateTimeUtc(string moduleName);

	string GetAssemblyVirtualPath(string moduleName);

	Assembly LoadAssembly(string moduleName);

	void DeleteAssembly(string moduleName);

	void StoreAssembly(string moduleName, string fileName);
}
