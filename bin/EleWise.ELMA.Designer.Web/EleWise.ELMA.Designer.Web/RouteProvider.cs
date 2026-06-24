using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.Designer.Web;

public class RouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.Designer.Web";

	public const string ImagesFolder = "~/Modules/EleWise.ELMA.Designer.Web/Content/Images/";

	public const string ContentFolder = "~/Modules/EleWise.ELMA.Designer.Web/Content/";

	private const string ModulePath = "~/Modules/EleWise.ELMA.Designer.Web";

	public void GetRoutes(ICollection<RouteDescriptor> routes)
	{
		foreach (RouteDescriptor route in GetRoutes())
		{
			routes.Add(route);
		}
	}

	public IEnumerable<RouteDescriptor> GetRoutes()
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		return new RouteDescriptor[1]
		{
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("WebDesigner/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.Designer.Web" },
					{ "controller", "Home" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.Designer.Web" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
