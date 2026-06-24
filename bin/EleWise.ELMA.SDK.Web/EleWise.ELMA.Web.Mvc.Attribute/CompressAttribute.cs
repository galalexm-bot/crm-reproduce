using System;
using System.IO.Compression;
using System.Web;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class CompressAttribute : ActionFilterAttribute
{
	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		if (((ControllerContext)filterContext).get_IsChildAction())
		{
			return;
		}
		string text = ((ControllerContext)filterContext).get_HttpContext().Request.Headers["Accept-Encoding"];
		HttpResponseBase response = ((ControllerContext)filterContext).get_HttpContext().Response;
		if (!string.IsNullOrEmpty(text) && response.Filter != null)
		{
			text = text.ToLowerInvariant();
			if (text.Contains("gzip"))
			{
				response.AppendHeader("Content-encoding", "gzip");
				response.Filter = new GZipStream(response.Filter, CompressionMode.Compress);
			}
			else if (text.Contains("deflate"))
			{
				response.AppendHeader("Content-encoding", "deflate");
				response.Filter = new DeflateStream(response.Filter, CompressionMode.Compress);
			}
		}
	}

	public override void OnActionExecuted(ActionExecutedContext filterContext)
	{
		((ActionFilterAttribute)this).OnActionExecuted(filterContext);
		if (filterContext.get_Exception() != null && !filterContext.get_ExceptionHandled())
		{
			HttpResponseBase response = ((ControllerContext)filterContext).get_HttpContext().Response;
			if (response.Filter != null)
			{
				response.Filter.Dispose();
				response.Filter = null;
			}
		}
	}
}
