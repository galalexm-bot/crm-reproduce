using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.BPM.Web.Content;

public class RouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.BPM.Web.Content";

	public const string ContentFolder = "~/Modules/EleWise.ELMA.BPM.Web.Content/Content/";

	public const string ImagesFolder = "~/Modules/EleWise.ELMA.BPM.Web.Content/Content/Images/";

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
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		return new RouteDescriptor[2]
		{
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("ContentArea/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Content" },
					{ "controller", "Home" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Content" } }, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Content" },
					{ "controller", "Page" },
					{ "action", "Home" }
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Content" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
