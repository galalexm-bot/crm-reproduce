using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.CRM.Web.Portlets;

[Component]
public class LeadPortlet : Portlet<LeadPortletPersonalization>
{
	public static string UID_S = "{B4B77927-7767-422C-B80E-61FEA7E51A78}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Category => SR.T("Работа с клиентами");

	public override string Name => SR.T("Возможности");

	public override string Description => SR.T("Портлет отображения возможностей");

	public override bool AllowMultipleInstance => true;

	public LeadPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.Customizable = true;
		_profile.ImageUrl = "#user.svg";
	}

	public override MvcHtmlString Content(HtmlHelper html, LeadPortletPersonalization data)
	{
		return RenderContentAction(html, "LeadPortlet", "Lead", "EleWise.ELMA.CRM.Web", data);
	}

	public override MvcHtmlString Settings(HtmlHelper html, LeadPortletPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "Lead/LeadPortletSettings", data);
	}

	public override void BeforeRender(HtmlHelper html, LeadPortletPersonalization data)
	{
		data.NameUrl = html.Url().Action("Index", "Lead", (object)new
		{
			area = "EleWise.ELMA.CRM.Web",
			FilterId = data.FilterId
		});
	}

	protected override Permission PortletPermission()
	{
		return CRMPermissionProvider.CRMAccessPermission;
	}
}
