using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Portlets;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPortletsRestrictionProvider
{
	bool Match(string path);

	bool AllowedView(string path);

	bool AllowedAddPortlet(string path);

	bool AllowedAddPortlet(IPortlet portlet, string path);

	bool AllowedPersonalization(string path);

	bool AllowedChangeSharedSettings(string path);
}
