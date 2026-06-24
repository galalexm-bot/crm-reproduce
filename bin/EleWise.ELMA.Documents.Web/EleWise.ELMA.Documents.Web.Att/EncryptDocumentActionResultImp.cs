using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Web.Models;

namespace EleWise.ELMA.Documents.Web.Attributes;

internal static class EncryptDocumentActionResultImpl
{
	public static ActionResult EncryptedDocumentResult([NotNull] EncryptDocumentException encryptDocumentException, ControllerBase controller)
	{
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		if (encryptDocumentException == null)
		{
			throw new ArgumentNullException("encryptDocumentException");
		}
		_ = encryptDocumentException.Message;
		string.Join(", ", controller.get_ControllerContext().get_RouteData().Values.Select((KeyValuePair<string, object> p) => p.Key + "=" + p.Value).ToArray());
		if (!controller.get_ControllerContext().get_IsChildAction())
		{
			HttpContextBase httpContext = controller.get_ControllerContext().get_HttpContext();
			if (httpContext != null && httpContext.Request != null && httpContext.Request.Url != null)
			{
				httpContext.Request.Url.ToString();
			}
		}
		string text = controller.get_ControllerContext().get_RequestContext().HttpContext.Request.Headers.Get("X-Requested-With");
		bool result;
		bool flag = bool.TryParse(controller.get_ControllerContext().get_RequestContext().HttpContext.Request.Headers.Get("Spa-Request"), out result) && result;
		if (!controller.get_ControllerContext().get_IsChildAction() && (!(text == "XMLHttpRequest") || flag))
		{
			return (ActionResult)new RedirectToRouteResult(new RouteValueDictionary
			{
				{ "action", "EncryptLogOn" },
				{ "controller", "Document" },
				{ "area", "EleWise.ELMA.Documents.Web" },
				{ "id", encryptDocumentException.DocumentId },
				{
					"ReturnUrl",
					controller.get_ControllerContext().get_RequestContext().HttpContext.Request.RawUrl
				}
			});
		}
		ViewDataDictionary viewData = controller.get_ViewData();
		viewData.set_Model((object)new DocumentCryptInfo
		{
			Entity = DocumentManager.Instance.Load(encryptDocumentException.DocumentId)
		});
		viewData.set_Item("RegisterCss", (object)true);
		PartialViewResult val = new PartialViewResult();
		((ViewResultBase)val).set_ViewName("~/Modules/EleWise.ELMA.Documents.Web/Views/Shared/Document/EncryptLogOnFormSimple.cshtml");
		((ViewResultBase)val).set_ViewData(viewData);
		((ViewResultBase)val).set_TempData(controller.get_TempData());
		return (ActionResult)val;
	}

	public static void RenderEncryptionLogOnFormSimple(HtmlHelper html, [NotNull] EncryptDocumentException encryptDocumentException)
	{
		DocumentCryptInfo documentCryptInfo = new DocumentCryptInfo
		{
			Entity = DocumentManager.Instance.Load(encryptDocumentException.DocumentId)
		};
		RenderPartialExtensions.RenderPartial(html, "Document/EncryptLogOnFormSimple", (object)documentCryptInfo);
	}
}
