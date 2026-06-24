using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.BPM.Web.Tasks;

public class RouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.BPM.Web.Tasks";

	public const string ContentFolder = "~/Modules/EleWise.ELMA.BPM.Web.Tasks/Content/";

	public const string ImagesFolder = "~/Modules/EleWise.ELMA.BPM.Web.Tasks/Content/Images/";

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
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		return new RouteDescriptor[2]
		{
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("Tasks/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Tasks" },
					{ "controller", "AllTasks" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Tasks" } }, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("Tasks/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Tasks" },
					{ "controller", "WorkLogItem" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Tasks" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
