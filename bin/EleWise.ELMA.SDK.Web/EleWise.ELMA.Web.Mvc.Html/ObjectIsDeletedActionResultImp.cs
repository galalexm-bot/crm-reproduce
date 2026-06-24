using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Html;

internal class ObjectIsDeletedActionResultImpl
{
	public static ActionResult RiseErrorResult([NotNull] Exception objectIsDeletedException, ControllerBase controller)
	{
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		if (objectIsDeletedException == null)
		{
			throw new ArgumentNullException("objectIsDeletedException");
		}
		string message = objectIsDeletedException.Message;
		string text = "";
		string text2 = string.Join(", ", controller.get_ControllerContext().get_RouteData().Values.Select((KeyValuePair<string, object> p) => p.Key + "=" + p.Value).ToArray());
		if (controller.get_ControllerContext().get_IsChildAction())
		{
			text = "";
		}
		else
		{
			HttpContextBase httpContext = controller.get_ControllerContext().get_HttpContext();
			if (httpContext != null && httpContext.Request != null && httpContext.Request.Url != null)
			{
				text = httpContext.Request.Url.ToString();
			}
		}
		string text3 = controller.get_ControllerContext().get_RequestContext().HttpContext.Request.Headers.Get("X-Requested-With");
		bool result;
		bool flag = bool.TryParse(controller.get_ControllerContext().get_RequestContext().HttpContext.Request.Headers.Get("Spa-Request"), out result) && result;
		if (!controller.get_ControllerContext().get_IsChildAction() && (!(text3 == "XMLHttpRequest") || flag))
		{
			return (ActionResult)new RedirectToRouteResult(new RouteValueDictionary
			{
				{ "action", "ObjectIsDeleted" },
				{ "controller", "Entity" },
				{ "area", "EleWise.ELMA.BPM.Web.Common" },
				{ "Reason", message },
				{ "Url", text },
				{ "RouteDataText", text2 }
			});
		}
		ViewDataDictionary viewData = controller.get_ViewData();
		viewData.set_Model((object)new ObjectIsDeletedModel
		{
			Reason = message,
			Url = text,
			RouteDataText = text2
		});
		PartialViewResult val = new PartialViewResult();
		((ViewResultBase)val).set_ViewName("~/Modules/EleWise.ELMA.BPM.Web.Common/Views/Shared/Entity/ObjectIsDeleted.cshtml");
		((ViewResultBase)val).set_ViewData(viewData);
		((ViewResultBase)val).set_TempData(controller.get_TempData());
		return (ActionResult)val;
	}
}
