using System.Security;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Security;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ISecurityExceptionView
{
	bool CheckType(SecurityException exception);

	ActionResult Result(SecurityException securityException, ControllerBase controller, string url, string routeDataText);

	RouteValueDictionary ResultRoute(SecurityException securityException, ControllerBase controller, string url, string routeDataText);
}
