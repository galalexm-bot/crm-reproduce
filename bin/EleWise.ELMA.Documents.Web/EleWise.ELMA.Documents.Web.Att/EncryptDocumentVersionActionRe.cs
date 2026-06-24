using System;
using System.Collections.Specialized;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;

namespace EleWise.ELMA.Documents.Web.Attributes;

internal static class EncryptDocumentVersionActionResultImpl
{
	public static ActionResult EncryptedDocumentVersionResult([NotNull] EncryptDocumentVersionException encryptDocumentVersionException, ControllerBase controller)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		if (encryptDocumentVersionException == null)
		{
			throw new ArgumentNullException("encryptDocumentVersionException");
		}
		IDocumentVersion entity = DocumentVersionManager.Instance.Load(encryptDocumentVersionException.VersionId);
		string text = controller.get_ControllerContext().get_RequestContext().HttpContext.Request.Headers.Get("X-Requested-With");
		bool result;
		bool flag = bool.TryParse(controller.get_ControllerContext().get_RequestContext().HttpContext.Request.Headers.Get("Spa-Request"), out result) && result;
		if (controller.get_ControllerContext().get_IsChildAction() || (text == "XMLHttpRequest" && !flag))
		{
			ViewDataDictionary viewData = controller.get_ViewData();
			NameValueCollection @params = controller.get_ControllerContext().get_RequestContext().HttpContext.Request.Params;
			viewData.set_Model((object)new DocumentVersionCryptInfo
			{
				Entity = entity,
				AjaxPost = true,
				PopupContentUrl = controller.get_ControllerContext().get_RequestContext().HttpContext.Request.RawUrl,
				PopupId = @params.Get("popupId")
			});
			viewData.set_Item("RegisterCss", (object)true);
			PartialViewResult val = new PartialViewResult();
			((ViewResultBase)val).set_ViewName("~/Modules/EleWise.ELMA.Documents.Web/Views/Shared/DocumentVersion/EncryptLogOnFormSimple.cshtml");
			((ViewResultBase)val).set_ViewData(viewData);
			((ViewResultBase)val).set_TempData(controller.get_TempData());
			return (ActionResult)val;
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "action", "EncryptLogOn" },
			{ "controller", "DocumentVersion" },
			{ "area", "EleWise.ELMA.Documents.Web" },
			{ "id", encryptDocumentVersionException.VersionId },
			{
				"ReturnUrl",
				controller.get_ControllerContext().get_RequestContext().HttpContext.Request.RawUrl
			}
		};
		if (encryptDocumentVersionException.ActionUid == DocumentVersionActions.DownloadGuid)
		{
			routeValueDictionary["ReturnUrl"] = controller.get_ControllerContext().get_RequestContext().HttpContext.Request.UrlReferrer;
			routeValueDictionary["DownloadUrl"] = controller.get_ControllerContext().get_RequestContext().HttpContext.Request.RawUrl;
		}
		return (ActionResult)new RedirectToRouteResult(routeValueDictionary);
	}

	public static void RenderEncryptionLogOnFormSimple(HtmlHelper html, [NotNull] EncryptDocumentVersionException encryptDocumentVersionException)
	{
		DocumentVersionCryptInfo documentVersionCryptInfo = new DocumentVersionCryptInfo
		{
			Entity = DocumentVersionManager.Instance.Load(encryptDocumentVersionException.VersionId)
		};
		RenderPartialExtensions.RenderPartial(html, "DocumentVersion/EncryptLogOnFormSimple", (object)documentVersionCryptInfo);
	}
}
