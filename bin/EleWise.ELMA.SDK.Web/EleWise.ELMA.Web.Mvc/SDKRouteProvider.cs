using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.Web.Mvc;

public class SDKRouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.SDK.Web";

	public const string ImagesFolder = "~/Content/IconPack/";

	public void GetRoutes(ICollection<RouteDescriptor> routes)
	{
		foreach (RouteDescriptor route in GetRoutes())
		{
			routes.Add(route);
		}
	}

	public IEnumerable<RouteDescriptor> GetRoutes()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		return new RouteDescriptor[6]
		{
			new RouteDescriptor
			{
				Priority = 500,
				Route = new Route("Content/GetCss{id}", new RouteValueDictionary(new
				{
					area = "EleWise.ELMA.SDK.Web",
					controller = "CSS",
					action = "Get"
				}), null, new RouteValueDictionary { { "area", "EleWise.ELMA.SDK.Web" } }, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 500,
				Route = new Route("Content/GetPageAppCss{id}", new RouteValueDictionary(new
				{
					area = "EleWise.ELMA.SDK.Web",
					controller = "CSS",
					action = "GetPageAppCss"
				}), null, new RouteValueDictionary { { "area", "EleWise.ELMA.SDK.Web" } }, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 500,
				Route = new Route("Content/GetColorScheme", new RouteValueDictionary(new
				{
					area = "EleWise.ELMA.SDK.Web",
					controller = "CSS",
					action = "GetColorScheme"
				}), null, new RouteValueDictionary { { "area", "EleWise.ELMA.SDK.Web" } }, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 500,
				Route = new Route("Content/CssFile/{*fileNameWithHash}", new RouteValueDictionary(new
				{
					area = "EleWise.ELMA.SDK.Web",
					controller = "CSS",
					action = "File"
				}), null, new RouteValueDictionary { { "area", "EleWise.ELMA.SDK.Web" } }, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 500,
				Route = new Route("UI/Page/{pageName}/{pagePart}", new RouteValueDictionary(new
				{
					area = "EleWise.ELMA.SDK.Web",
					controller = "UI",
					action = "Page",
					pagePart = "Index"
				}), null, new RouteValueDictionary { { "area", "EleWise.ELMA.SDK.Web" } }, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 1000,
				Route = new Route("SDK.Action/{controller}/{action}/{id}", new RouteValueDictionary(SDKAreaRegistration.DefaultRoutes), null, new RouteValueDictionary { { "area", "EleWise.ELMA.SDK.Web" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
