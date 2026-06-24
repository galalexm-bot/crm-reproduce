using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class SelfInitializedAttribute : FilterAttribute, IResultFilter
{
	private object oldValue;

	public void OnResultExecuting(ResultExecutingContext filterContext)
	{
		oldValue = ((ControllerContext)filterContext).get_HttpContext().Items["$SelfInitialize$"];
		((ControllerContext)filterContext).get_HttpContext().Items["$SelfInitialize$"] = true;
	}

	public void OnResultExecuted(ResultExecutedContext filterContext)
	{
		((ControllerContext)filterContext).get_HttpContext().Items["$SelfInitialize$"] = oldValue;
	}
}
