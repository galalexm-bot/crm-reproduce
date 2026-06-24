using System;
using System.ComponentModel.Composition;
using System.Web.Routing;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[InheritedExport]
public interface IControllerHandlerMap
{
	string Route { get; }

	Type ControllerType { get; }

	RouteValueDictionary Defaults { get; }

	RouteValueDictionary Constraints { get; }

	RouteValueDictionary DataTokens { get; }
}
