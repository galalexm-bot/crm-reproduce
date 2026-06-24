using System;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Web.Mvc;

public class LazyRedirectResult : ActionResult
{
	public bool Permanent { get; private set; }

	public Func<string> UrlFunc { get; private set; }

	public LazyRedirectResult(Func<string> urlFunc)
		: this(urlFunc, permanent: false)
	{
	}

	public LazyRedirectResult(Func<string> urlFunc, bool permanent)
	{
		if (urlFunc == null)
		{
			throw new ArgumentNullException("urlFunc");
		}
		Permanent = permanent;
		UrlFunc = urlFunc;
	}

	public override void ExecuteResult(ControllerContext context)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (context.get_IsChildAction())
		{
			throw new InvalidOperationException(SR.T("Перенаправление веб-запроса недоступно в дочерних действиях"));
		}
		string text = UrlFunc();
		if (string.IsNullOrEmpty(text))
		{
			throw new InvalidOperationException(SR.T("Адрес для перенаправления веб-запроса пустой"));
		}
		if (!new UrlHelper(context.get_RequestContext()).IsLocalUrl(text))
		{
			throw new InvalidOperationException(SR.T("Адрес для перенаправления веб-запроса не является локальным"));
		}
		string url = UrlHelper.GenerateContentUrl(text, context.get_HttpContext());
		if (AjaxRequestExtensions.IsAjaxRequest(context.get_HttpContext().Request))
		{
			HttpResponseBase response = context.get_HttpContext().Response;
			response.ContentType = "application/json";
			JsonSerializer jsonSerializer = new JsonSerializer();
			response.Write(jsonSerializer.Serialize(new { url }));
		}
		else
		{
			context.get_Controller().get_TempData().Keep();
			if (Permanent)
			{
				context.get_HttpContext().Response.RedirectPermanent(url, endResponse: false);
			}
			else
			{
				context.get_HttpContext().Response.Redirect(url, endResponse: false);
			}
		}
	}
}
