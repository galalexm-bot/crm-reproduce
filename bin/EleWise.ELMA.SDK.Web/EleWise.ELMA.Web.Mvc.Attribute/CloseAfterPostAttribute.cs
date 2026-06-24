using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Attributes;

public class CloseAfterPostAttribute : ActionFilterAttribute
{
	public override void OnActionExecuted(ActionExecutedContext filterContext)
	{
		((ActionFilterAttribute)this).OnActionExecuted(filterContext);
		if (AjaxRequestExtensions.IsAjaxRequest(((ControllerContext)filterContext).get_HttpContext().Request) || !((ControllerContext)filterContext).get_HttpContext().Request.HttpMethod.Equals("post", StringComparison.InvariantCultureIgnoreCase))
		{
			return;
		}
		string value = ((ControllerContext)filterContext).get_HttpContext().Request["CloseAfterPost"] ?? string.Empty;
		bool result = false;
		if (bool.TryParse(value, out result) && result)
		{
			try
			{
				value = ((ControllerContext)filterContext).get_HttpContext().Response.Headers["CloseAfterPost"] ?? string.Empty;
			}
			catch (PlatformNotSupportedException)
			{
				value = "";
			}
			if (!bool.TryParse(value, out result) || result)
			{
				((ControllerContext)filterContext).get_HttpContext().Response.Redirect("/Common/Home/CloseAfterPost?interface=lite&useDefaultScript=false");
			}
		}
	}
}
