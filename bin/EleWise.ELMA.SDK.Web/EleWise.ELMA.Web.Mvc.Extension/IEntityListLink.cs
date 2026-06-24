using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityListLink
{
	bool CheckType(Type type);

	string Url(RequestContext context);
}
