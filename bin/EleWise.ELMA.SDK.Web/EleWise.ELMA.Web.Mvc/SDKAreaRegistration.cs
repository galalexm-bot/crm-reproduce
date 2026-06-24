using System;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Web.Mvc;

public class SDKAreaRegistration : AreaRegistration
{
	public const string Area = "SDK.Action";

	public const string AREA_NAME = "EleWise.ELMA.SDK.Web";

	public const string RouteUrl = "SDK.Action/{controller}/{action}/{id}";

	public static readonly object DefaultRoutes = new
	{
		area = "EleWise.ELMA.SDK.Web",
		controller = "Default",
		action = "StatusCode",
		id = UrlParameter.Optional
	};

	public override string AreaName => "EleWise.ELMA.SDK.Web";

	public override void RegisterArea(AreaRegistrationContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		context.MapRoute("SDK_Action_Default", "SDK.Action/{controller}/{action}/{id}", DefaultRoutes, new string[1] { typeof(DefaultController).Namespace });
	}
}
