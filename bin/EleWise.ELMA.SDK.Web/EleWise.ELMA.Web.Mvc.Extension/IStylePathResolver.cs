using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IStylePathResolver
{
	string Resolve(string url);

	bool ShouldResolve(string url);
}
