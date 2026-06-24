using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.CRM.Web;

public class RouteProvider : IRouteProvider, IDependency
{
	public const string AreaName = "EleWise.ELMA.CRM.Web";

	public const string ContentFolder = "~/Modules/EleWise.ELMA.CRM.Web/Content/";

	public const string ImagesFolder = "~/Modules/EleWise.ELMA.CRM.Web/Content/Images/";

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
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		return new RouteDescriptor[4]
		{
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("CRM/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.CRM.Web" },
					{ "controller", "Contractor" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.CRM.Web" } }, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("CRM/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.CRM.Web" },
					{ "controller", "Sale" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.CRM.Web" } }, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("CRM/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.CRM.Web" },
					{ "controller", "SaleStage" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.CRM.Web" } }, (IRouteHandler)new MvcRouteHandler())
			},
			new RouteDescriptor
			{
				Priority = 20,
				Route = new Route("CRM/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.CRM.Web" },
					{ "controller", "SalesPlan" },
					{ "action", "Index" },
					{
						"id",
						UrlParameter.Optional
					}
				}, null, new RouteValueDictionary { { "area", "EleWise.ELMA.CRM.Web" } }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}
}
