using System;
using System.Collections.Generic;
using Orchard.Caching;

namespace Orchard.FileSystems.Dependencies;

public interface IExtensionDependenciesManager : IVolatileProvider, ISingletonDependency, IDependency
{
	void StoreDependencies(IEnumerable<DependencyDescriptor> dependencyDescriptors, Func<DependencyDescriptor, string> fileHashProvider);

	IEnumerable<string> GetVirtualPathDependencies(string extensionId);

	ActivatedExtensionDescriptor GetDescriptor(string extensionId);
}
