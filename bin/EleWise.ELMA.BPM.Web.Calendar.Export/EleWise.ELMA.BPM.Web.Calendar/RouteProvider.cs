using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.BPM.Web.Calendar.Export;

public class RouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.BPM.Web.Calendar.Export";

	public const string ImagesFolder = "~/Modules/EleWise.ELMA.BPM.Web.Calendar.Export/Content/Images/";

	public void GetRoutes(ICollection<RouteDescriptor> routes)
	{
		foreach (RouteDescriptor route in GetRoutes())
		{
			routes.Add(route);
		}
	}

	public IEnumerable<RouteDescriptor> GetRoutes()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		return new RouteDescriptor[1]
		{
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("Export/{controller}/{action}/{id}/{fileName}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Calendar.Export" },
					{ "controller", "Export" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					},
					{
						"fileName",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Calendar.Export" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
