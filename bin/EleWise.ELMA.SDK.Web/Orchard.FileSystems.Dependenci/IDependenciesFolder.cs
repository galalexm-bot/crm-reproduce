using System.Collections.Generic;
using Orchard.Caching;

namespace Orchard.FileSystems.Dependencies;

public interface IDependenciesFolder : IVolatileProvider, ISingletonDependency, IDependency
{
	DependencyDescriptor GetDescriptor(string moduleName);

	IEnumerable<DependencyDescriptor> LoadDescriptors();

	void StoreDescriptors(IEnumerable<DependencyDescriptor> dependencyDescriptors);
}
