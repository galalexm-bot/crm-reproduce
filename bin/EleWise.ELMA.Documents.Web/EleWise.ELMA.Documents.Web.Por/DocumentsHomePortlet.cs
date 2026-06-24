using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Portlets;

[Component]
public class DocumentsHomePortlet : Portlet<DocumentsHomePortletPersonalization>
{
	public static string UID_S = "{CB15E2C3-A931-45D2-83D2-96D45DDAF9E0}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Документы");

	public override string Description => SR.T("Домашний портлет со ссылками на разделы администрирования документооборота");

	public override IPortletProfile Profile => profile;

	public override bool AllowMultipleInstance => false;

	public DocumentsHomePortlet()
	{
		profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		profile.ImageUrl = "#moduledoc.svg";
		profile.Customizable = false;
	}

	public override MvcHtmlString Content(HtmlHelper html, DocumentsHomePortletPersonalization data)
	{
		return RenderContentAction(html, "HomePortlet", "Settings", "EleWise.ELMA.Documents.Web", data);
	}

	protected override Permission PortletPermission()
	{
		return PermissionProvider.DocumentsAdminAccessPermission;
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		DocumentsHomePortletPersonalization documentsHomePortletPersonalization = base.CreateDefaultSettings(path) as DocumentsHomePortletPersonalization;
		if (documentsHomePortletPersonalization != null)
		{
			documentsHomePortletPersonalization.HeaderColor = "#FFE9A5";
			documentsHomePortletPersonalization.Frame = PortletFrame.HeaderLine;
		}
		return documentsHomePortletPersonalization;
	}
}
