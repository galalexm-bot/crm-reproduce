using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.KPI.Common.Web;

public class KpiCommonRouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.KPI.Common.Web";

	public const string ContentFolder = "~/Modules/EleWise.ELMA.KPI.Common.Web/Content/";

	public const string ImagesFolder = "~/Modules/EleWise.ELMA.KPI.Common.Web/Content/Images/";

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
				Route = new Route("EleWise.ELMA.KPI.Common.Web/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.KPI.Common.Web" },
					{ "controller", "Home" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.KPI.Common.Web" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
