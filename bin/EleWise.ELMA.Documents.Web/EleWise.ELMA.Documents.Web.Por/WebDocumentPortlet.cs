using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Portlets;

[Component]
public class WebDocumentPortlet : Portlet<WebDocumentPersonalization>
{
	public static string UID_S = "{1F9D4272-B127-4D58-8BE0-6CFB06BD42E0}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Веб-документ");

	public override bool AllowMultipleInstance => true;

	public override string Description => SR.T("Портлет отображения веб-документа");

	public WebDocumentPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.Customizable = true;
		_profile.ImageUrl = "#webdoc.svg";
	}

	public override MvcHtmlString Content(HtmlHelper html, WebDocumentPersonalization data)
	{
		return RenderContentAction(html, "WebDocumentPortlet", "Document", "EleWise.ELMA.Documents.Web", data);
	}

	public override MvcHtmlString Settings(HtmlHelper html, WebDocumentPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "Document/WebDocumentPortletSettings", data);
	}

	protected override Permission PortletPermission()
	{
		return PermissionProvider.DocumentsAccessPermission;
	}
}
