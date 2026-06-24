using Orchard.Caching;

namespace Orchard.FileSystems.VirtualPath;

public interface IVirtualPathMonitor : IVolatileProvider, ISingletonDependency, IDependency
{
	IVolatileToken WhenPathChanges(string virtualPath);
}
