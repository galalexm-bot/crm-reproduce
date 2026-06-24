using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Html;

public class InvalidOperationActionResultImpl
{
	public static ActionResult InvalidOperationResult([NotNull] Exception invalidOperationException, ControllerBase controller)
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		if (invalidOperationException == null)
		{
			throw new ArgumentNullException("invalidOperationException");
		}
		string message = (((invalidOperationException is ElmaInvalidOperationException) ? invalidOperationException.InnerException : null) ?? invalidOperationException).Message;
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
				{ "action", "InvalidOperation" },
				{ "controller", "Entity" },
				{ "area", "EleWise.ELMA.BPM.Web.Common" },
				{ "Reason", message },
				{ "Url", text },
				{ "RouteDataText", text2 }
			});
		}
		ViewDataDictionary viewData = controller.get_ViewData();
		viewData.set_Model((object)new InvalidOperationModel
		{
			Reason = message,
			Url = text,
			RouteDataText = text2
		});
		PartialViewResult val = new PartialViewResult();
		((ViewResultBase)val).set_ViewName("~/Modules/EleWise.ELMA.BPM.Web.Common/Views/Shared/Entity/InvalidOperation.cshtml");
		((ViewResultBase)val).set_ViewData(viewData);
		((ViewResultBase)val).set_TempData(controller.get_TempData());
		return (ActionResult)val;
	}
}
