using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IEntityLink
{
	Type EntityType { get; }

	Guid TypeUid { get; }

	string IdParam { get; }

	bool LoadEntityIfNull { get; }

	string Area(IEntity entity);

	string Action(IEntity entity);

	string Controller(IEntity entity);

	RouteValueDictionary GetParams(IEntity entity);

	string Href(RequestContext html, IEntity entity);
}
