using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.BPM.Web.Security;

public class RouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.BPM.Web.Security";

	public const string ContentFolder = "~/Modules/EleWise.ELMA.BPM.Web.Security/Content/";

	public const string ImagesFolder = "~/Modules/EleWise.ELMA.BPM.Web.Security/Content/Images/";

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
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		return new RouteDescriptor[3]
		{
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("Security/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Security" },
					{ "controller", "User" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Security" } }, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 30,
				Route = new Route("Security/User/Photo/{id}/{uid}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Security" },
					{ "controller", "User" },
					{ "action", "Photo" }
				}, null, new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Security" },
					{ "controller", "User" },
					{ "action", "Photo" }
				}, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 40,
				Route = new Route("Auth/IWA/LogOn", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Security" },
					{ "controller", "IWA" },
					{ "action", "LogOn" }
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Security" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
