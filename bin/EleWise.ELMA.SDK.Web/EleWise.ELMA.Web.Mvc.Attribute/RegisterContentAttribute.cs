using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class RegisterContentAttribute : ActionFilterAttribute
{
	private class BufferWriter : StringWriter
	{
		public TextWriter BaseWriter { get; private set; }

		public BufferWriter(TextWriter baseWriter)
		{
			BaseWriter = baseWriter;
		}
	}

	public override void OnResultExecuting(ResultExecutingContext filterContext)
	{
		if (filterContext == null || ((ControllerContext)filterContext).get_IsChildAction() || !(filterContext.get_Result() is PartialViewResult))
		{
			return;
		}
		ActionResultType actionResultType = ActionResultTypeResolver.Resolve(filterContext.get_Result());
		switch (actionResultType)
		{
		case ActionResultType.Html:
			if (((ControllerContext)filterContext).get_HttpContext().Items.Contains("RegisterContentAtStart") && (bool)((ControllerContext)filterContext).get_HttpContext().Items["RegisterContentAtStart"])
			{
				((ControllerContext)filterContext).get_HttpContext().Response.Output = new BufferWriter(((ControllerContext)filterContext).get_HttpContext().Response.Output);
			}
			if (((ControllerContext)filterContext).get_HttpContext().Request.Headers["Elma-PopupWindow"] == "1")
			{
				((ControllerContext)filterContext).get_HttpContext().Response.Write("<div class='elma-window-toolbar'></div><div class='elma-window-content'>");
			}
			break;
		case ActionResultType.Json:
			RenderRegisteredContent((ControllerContext)(object)filterContext, actionResultType);
			break;
		}
	}

	public override void OnResultExecuted(ResultExecutedContext filterContext)
	{
		if (filterContext == null || filterContext.get_Canceled() || ((ControllerContext)filterContext).get_IsChildAction() || (filterContext.get_Exception() != null && !filterContext.get_ExceptionHandled()) || !(filterContext.get_Result() is PartialViewResult))
		{
			return;
		}
		ActionResultType actionResultType = ActionResultTypeResolver.Resolve(filterContext.get_Result());
		switch (actionResultType)
		{
		case ActionResultType.Html:
		{
			if (((ControllerContext)filterContext).get_HttpContext().Request.Headers["Elma-PopupWindow"] == "1")
			{
				((ControllerContext)filterContext).get_HttpContext().Response.Write("</div>");
			}
			BufferWriter bufferWriter = ((ControllerContext)filterContext).get_HttpContext().Response.Output as BufferWriter;
			if (bufferWriter != null)
			{
				((ControllerContext)filterContext).get_HttpContext().Response.Output = bufferWriter.BaseWriter;
			}
			RenderRegisteredContent((ControllerContext)(object)filterContext, actionResultType);
			if (bufferWriter != null)
			{
				((ControllerContext)filterContext).get_HttpContext().Response.Write(bufferWriter.ToString());
			}
			break;
		}
		case ActionResultType.Json:
			RenderRegisteredContent((ControllerContext)(object)filterContext, actionResultType, needRegisterScripts: true);
			break;
		}
	}

	private static void RenderRegisteredContent(ControllerContext filterContext, ActionResultType resultType, bool needRegisterScripts = false)
	{
		if (resultType != 0 && resultType != ActionResultType.Json)
		{
			return;
		}
		MvcHtmlString val = MvcHtmlString.Empty;
		Logger.Log.Info("Try Render for DefaultContentZone");
		if (filterContext.get_RouteData() != null)
		{
			val = filterContext.get_HttpContext().RenderForZone("DefaultContentZone");
		}
		string text = ((HtmlString)(object)val).ToHtmlString();
		Logger.Log.Info("Rendered for DefaultContentZone: " + text);
		val = MvcHtmlString.Empty;
		Logger.Log.Info("Try Render for Scripts");
		if (filterContext.get_RouteData() != null)
		{
			val = filterContext.get_HttpContext().RenderForZone("Scripts");
		}
		string text2 = ((HtmlString)(object)val).ToHtmlString();
		Logger.Log.Info("Rendered for Scripts: " + text2);
		if (resultType == ActionResultType.Html)
		{
			if (!text.IsNullOrEmpty())
			{
				filterContext.get_HttpContext().Response.Write(text);
			}
			if (!text2.IsNullOrEmpty())
			{
				filterContext.get_HttpContext().Response.Write(text2);
			}
		}
		else if (needRegisterScripts)
		{
			filterContext.get_HttpContext().Response.Write(";})(jQuery), script:(function($){");
			if (!text.IsNullOrEmpty())
			{
				filterContext.get_HttpContext().Response.Write(string.Concat("\r\n                        var zone = $(", text.ToJson(), ");\r\n                        $(document.body).append(zone);\r\n                        eval($(zone).find('script').text());\r\n                        "));
			}
			if (!text2.IsNullOrEmpty())
			{
				filterContext.get_HttpContext().Response.Write(string.Concat("\r\n                            var zone1 = $(", text2.ToJson(), ");\r\n                            $(document.body).append(zone1);\r\n                            eval($(zone1).find('script').text());\r\n                            "));
			}
			filterContext.get_HttpContext().Response.Write("})(jQuery)}");
		}
		else
		{
			filterContext.get_HttpContext().Response.Write("{data:(function($){return ");
		}
	}
}
