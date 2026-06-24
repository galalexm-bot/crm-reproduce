using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IEntityLinkStringUrlResolver
{
	Type EntityLink { get; }

	bool CheckRoute(IEntityLink entityLink, RouteData routeData);
}
