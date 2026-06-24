using System;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Async;

namespace EleWise.ELMA.Web.Orchard.Mvc;

[AttributeUsage(AttributeTargets.Class)]
internal sealed class WebRequestAsyncTimeoutAttribute : ActionFilterAttribute
{
	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		Contract.ArgumentNotNull(filterContext, "filterContext");
		ControllerBase controller = ((ControllerContext)filterContext).get_Controller();
		IAsyncManagerContainer val;
		if ((val = (IAsyncManagerContainer)(object)((controller is IAsyncManagerContainer) ? controller : null)) != null)
		{
			if (((ControllerContext)filterContext).get_HttpContext() != null)
			{
				val.get_AsyncManager().set_Timeout(((ControllerContext)filterContext).get_HttpContext().Server.ScriptTimeout * 1000);
			}
			else
			{
				HttpRuntimeSection httpRuntimeSection = (HttpRuntimeSection)WebConfigurationManager.OpenWebConfiguration(HostingEnvironment.ApplicationVirtualPath).GetSection("system.web/httpRuntime");
				val.get_AsyncManager().set_Timeout(httpRuntimeSection.ExecutionTimeout.Milliseconds);
			}
		}
		((ActionFilterAttribute)this).OnActionExecuting(filterContext);
	}
}
