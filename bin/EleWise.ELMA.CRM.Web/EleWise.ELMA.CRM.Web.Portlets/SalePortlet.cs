using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.CRM.Web.Portlets;

[Component]
public class SalePortlet : Portlet<SalePortletPersonalization>
{
	public static string UID_S = "{8325E479-2145-48EE-A2A3-D2334A233BE1}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Category => SR.T("Работа с клиентами");

	public override string Name => SR.T("Сделки");

	public override string Description => SR.T("Портлет отображения сделок");

	public override bool AllowMultipleInstance => true;

	public SalePortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.Customizable = true;
		_profile.ImageUrl = "#deal.svg";
	}

	public override MvcHtmlString Content(HtmlHelper html, SalePortletPersonalization data)
	{
		return RenderContentAction(html, "SalePortlet", "Sale", "EleWise.ELMA.CRM.Web", data);
	}

	public override MvcHtmlString Settings(HtmlHelper html, SalePortletPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "Sale/SalePortletSettings", data);
	}

	public override void BeforeRender(HtmlHelper html, SalePortletPersonalization data)
	{
		data.NameUrl = html.Url().Action("Index", "Sale", (object)new
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
