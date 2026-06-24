using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class RegisterContentAtStartAttribute : ActionFilterAttribute
{
	public override void OnResultExecuting(ResultExecutingContext filterContext)
	{
		((ActionFilterAttribute)this).OnResultExecuting(filterContext);
		((ControllerContext)filterContext).get_HttpContext().Items["RegisterContentAtStart"] = true;
	}
}
