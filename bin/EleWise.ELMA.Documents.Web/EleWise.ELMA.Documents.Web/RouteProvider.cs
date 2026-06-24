using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.Documents.Web;

public class RouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.Documents.Web";

	public const string ContentFolder = "~/Modules/EleWise.ELMA.Documents.Web/Content/";

	public const string ImagesFolder = "~/Modules/EleWise.ELMA.Documents.Web/Content/Images/";

	public const string ScriptFolder = "~/Modules/EleWise.ELMA.Documents.Web/Scripts/";

	public void GetRoutes(ICollection<RouteDescriptor> routes)
	{
		foreach (RouteDescriptor route in GetRoutes())
		{
			routes.Add(route);
		}
	}

	public IEnumerable<RouteDescriptor> GetRoutes()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		return new RouteDescriptor[1]
		{
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("Documents/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.Documents.Web" },
					{ "controller", "Home" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.Documents.Web" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
