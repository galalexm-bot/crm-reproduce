using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDynamicAssemblyIgnore
{
	bool ShouldIgnore(string virtualPath);
}
