using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public sealed class ContentTypeAttribute : ActionFilterAttribute
{
	public string ContentType { get; private set; }

	public ContentTypeAttribute(string contentType)
	{
		if (string.IsNullOrEmpty(contentType))
		{
			throw new ArgumentException("Common_NullOrEmpty", "contentType");
		}
		ContentType = contentType;
	}

	public override void OnResultExecuting(ResultExecutingContext filterContext)
	{
		((ControllerContext)filterContext).get_HttpContext().Response.ContentType = ContentType;
	}

	public override void OnResultExecuted(ResultExecutedContext filterContext)
	{
		((ControllerContext)filterContext).get_HttpContext().Response.ContentType = ContentType;
	}
}
