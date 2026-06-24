using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Web.Orchard.Mvc.Routes;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.BPM.Web.Common;

public class RouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.BPM.Web.Common";

	public const string ContentFolder = "~/Modules/EleWise.ELMA.BPM.Web.Common/Content/";

	public const string ImagesFolder = "~/Modules/EleWise.ELMA.BPM.Web.Common/Content/Images/";

	public void GetRoutes(ICollection<RouteDescriptor> routes)
	{
		foreach (RouteDescriptor route in GetRoutes())
		{
			routes.Add(route);
		}
	}

	public IEnumerable<RouteDescriptor> GetRoutes()
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		return new RouteDescriptor[2]
		{
			new RouteDescriptor
			{
				Priority = 30,
				Route = new Route("Common/DeployImport/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Common" },
					{ "controller", "DeployImport" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Common" } }, (IRouteHandler)(object)new AsyncRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("Common/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Common" },
					{ "controller", "Home" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Common" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
