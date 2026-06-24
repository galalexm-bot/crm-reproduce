using System;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class HelpFilterAttribute : ActionFilterAttribute
{
	public override void OnActionExecuted(ActionExecutedContext filterContext)
	{
		if (filterContext != null && ((ControllerContext)filterContext).get_Controller() is BaseController)
		{
			((ControllerContext)filterContext).get_Controller().get_ViewData().set_Item("HelpPageContentUrl", (object)((BaseController)(object)((ControllerContext)filterContext).get_Controller()).HelpUrl());
		}
		((ActionFilterAttribute)this).OnActionExecuted(filterContext);
	}
}
