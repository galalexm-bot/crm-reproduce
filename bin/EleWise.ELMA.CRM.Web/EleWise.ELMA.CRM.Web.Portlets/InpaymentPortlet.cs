using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.CRM.Web.Portlets;

[Component]
public class InpaymentPortlet : Portlet<InpaymentPortletPersonalization>
{
	public static string UID_S = "{7593418A-71E2-41B4-B274-5433A0B002A1}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Category => SR.T("Работа с клиентами");

	public override string Name => SR.T("План поступлений");

	public override string Description => SR.T("Портлет отображения плана поступлений");

	public override bool AllowMultipleInstance => true;

	public InpaymentPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.Customizable = true;
		_profile.ImageUrl = "#portlet_inpayment.svg";
	}

	public override MvcHtmlString Content(HtmlHelper html, InpaymentPortletPersonalization data)
	{
		return RenderContentAction(html, "InpaymentPortlet", "Inpayment", "EleWise.ELMA.CRM.Web", data);
	}

	public override MvcHtmlString Settings(HtmlHelper html, InpaymentPortletPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "Inpayment/InpaymentPortletSettings", data);
	}

	public override void BeforeRender(HtmlHelper html, InpaymentPortletPersonalization data)
	{
		data.NameUrl = html.Url().Action("Index", "Inpayment", (object)new
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
