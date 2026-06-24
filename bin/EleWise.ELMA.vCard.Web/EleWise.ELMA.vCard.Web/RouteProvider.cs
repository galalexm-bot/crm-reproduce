using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.vCard.Web;

public class RouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.vCard.Web";

	public const string ImagesFolder = "~/Modules/EleWise.ELMA.vCard.Web/Content/Images/";

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
				Route = new Route("vCard/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.vCard.Web" },
					{ "controller", "Vcard" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.vCard.Web" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
