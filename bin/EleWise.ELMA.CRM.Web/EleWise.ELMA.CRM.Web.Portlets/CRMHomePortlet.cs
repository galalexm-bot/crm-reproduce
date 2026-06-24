using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.CRM.Web.Portlets;

[Component]
public class CRMHomePortlet : Portlet<CRMHomePortletPersonalization>
{
	public static string UID_S = "{1C2D3237-D272-45CA-B7BD-B60034A72B8A}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Работа с клиентами");

	public override string Description => SR.T("Домашний портлет со ссылками на разделы администрирования модуля Работа с клиентами");

	public override IPortletProfile Profile => profile;

	public override bool AllowMultipleInstance => false;

	public CRMHomePortlet()
	{
		profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		profile.ImageUrl = "#user.svg";
		profile.Customizable = false;
	}

	public override MvcHtmlString Content(HtmlHelper html, CRMHomePortletPersonalization data)
	{
		return RenderContentAction(html, "HomePortlet", "Admin", "EleWise.ELMA.CRM.Web", data);
	}

	protected override Permission PortletPermission()
	{
		return PermissionProvider.AccessManagmentPermission;
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		CRMHomePortletPersonalization cRMHomePortletPersonalization = base.CreateDefaultSettings(path) as CRMHomePortletPersonalization;
		if (cRMHomePortletPersonalization != null)
		{
			cRMHomePortletPersonalization.HeaderColor = "#A8DAFA";
			cRMHomePortletPersonalization.Frame = PortletFrame.HeaderLine;
		}
		return cRMHomePortletPersonalization;
	}
}
