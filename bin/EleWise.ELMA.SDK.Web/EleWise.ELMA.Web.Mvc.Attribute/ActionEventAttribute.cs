using System;
using System.Web.Mvc;
using EleWise.ELMA.CAB.Utility;
using EleWise.ELMA.Web.Mvc.Events;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class ActionEventAttribute : ActionFilterAttribute
{
	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		MvcEventDispatcher.Instance.OnActionExecuting(new DataEventArgs<ActionExecutingContext>(filterContext));
		((ActionFilterAttribute)this).OnActionExecuting(filterContext);
	}

	public override void OnActionExecuted(ActionExecutedContext filterContext)
	{
		MvcEventDispatcher.Instance.OnActionExecuted(new DataEventArgs<ActionExecutedContext>(filterContext));
		((ActionFilterAttribute)this).OnActionExecuted(filterContext);
	}

	public override void OnResultExecuting(ResultExecutingContext filterContext)
	{
		MvcEventDispatcher.Instance.OnResultExecuting(new DataEventArgs<ResultExecutingContext>(filterContext));
		((ActionFilterAttribute)this).OnResultExecuting(filterContext);
	}

	public override void OnResultExecuted(ResultExecutedContext filterContext)
	{
		MvcEventDispatcher.Instance.OnResultExecuted(new DataEventArgs<ResultExecutedContext>(filterContext));
		((ActionFilterAttribute)this).OnResultExecuted(filterContext);
	}
}
