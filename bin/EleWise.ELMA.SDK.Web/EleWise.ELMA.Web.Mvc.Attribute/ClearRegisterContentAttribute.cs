using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
public class ClearRegisterContentAttribute : ActionFilterAttribute
{
	public string Zone { get; set; }

	public string Key { get; set; }

	public override void OnResultExecuting(ResultExecutingContext filterContext)
	{
		if (!string.IsNullOrEmpty(Key) && !string.IsNullOrEmpty(Zone) && ContextVars.TryGetValue<List<string>>("register-content-" + Zone, out var value))
		{
			value.Remove(Key);
		}
	}

	public override void OnResultExecuted(ResultExecutedContext filterContext)
	{
		if (!string.IsNullOrEmpty(Key))
		{
			((ControllerContext)filterContext).get_HttpContext().Response.Write($"\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function() {{\r\n        elma.removeRegisteredScript(\"{Key}\");\r\n    }})\r\n</script>\r\n");
		}
	}
}
