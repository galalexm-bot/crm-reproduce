using System;
using System.Web.Mvc;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public class InNewNHSessionAttribute : ActionFilterAttribute
{
	private const string prefix = "InNewNHSessionAttribute_";

	public string SessionName { get; set; }

	public bool OnlyGet { get; set; }

	public InNewNHSessionAttribute()
	{
		((FilterAttribute)this).set_Order(1);
		SessionName = "NewNHSession";
	}

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		if (!OnlyGet || ((ControllerContext)filterContext).get_HttpContext().Request.HttpMethod == null || !((ControllerContext)filterContext).get_HttpContext().Request.HttpMethod.Equals("POST", StringComparison.OrdinalIgnoreCase))
		{
			ISessionProvider serviceNotNull = Locator.GetServiceNotNull<ISessionProvider>();
			((ControllerContext)filterContext).get_HttpContext().Items["InNewNHSessionAttribute_" + SessionName] = serviceNotNull.GetSession("");
			ISession session = serviceNotNull.GetSession(SessionName);
			serviceNotNull.SetCurrentSession(session, "");
		}
	}

	public override void OnActionExecuted(ActionExecutedContext filterContext)
	{
	}

	public override void OnResultExecuting(ResultExecutingContext filterContext)
	{
	}

	public override void OnResultExecuted(ResultExecutedContext filterContext)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		if (!OnlyGet || ((ControllerContext)filterContext).get_HttpContext().Request.HttpMethod == null || !((ControllerContext)filterContext).get_HttpContext().Request.HttpMethod.Equals("POST", StringComparison.OrdinalIgnoreCase))
		{
			ISession val = (ISession)((ControllerContext)filterContext).get_HttpContext().Items["InNewNHSessionAttribute_" + SessionName];
			if (val != null)
			{
				Locator.GetServiceNotNull<ISessionProvider>().SetCurrentSession(val, "");
			}
		}
	}
}
