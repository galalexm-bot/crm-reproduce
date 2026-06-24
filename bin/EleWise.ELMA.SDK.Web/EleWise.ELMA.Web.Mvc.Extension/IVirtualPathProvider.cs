using System.Collections;
using System.Web.Hosting;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IVirtualPathProvider
{
	string Prefix { get; }

	bool FileExists(string virtualPath);

	VirtualFile GetFile(string virtualPath);

	string GetFileHash(string virtualPath, IEnumerable virtualPathDependencies);
}
