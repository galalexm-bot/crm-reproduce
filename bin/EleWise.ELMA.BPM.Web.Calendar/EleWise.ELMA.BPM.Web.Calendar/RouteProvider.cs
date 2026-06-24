using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.BPM.Web.Calendar;

public class RouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.BPM.Web.Calendar";

	public const string ContentFolder = "~/Modules/EleWise.ELMA.BPM.Web.Calendar/Content/";

	public const string ImagesFolder = "~/Modules/EleWise.ELMA.BPM.Web.Calendar/Content/Images/";

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
				Route = new Route("Calendar/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Calendar" },
					{ "controller", "Scheduler" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Calendar" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
