using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Portlets;

[Component]
public class CommonHomePortlet : Portlet<CommonHomePortletPersonalization>
{
	public static string UID_S = "{01AC2B5F-233D-4023-9FBD-4EA1EB9B2C19}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Базовые приложения");

	public override string Description => SR.T("Быстрый доступ к страницам администрирования базовых приложений системы");

	public override IPortletProfile Profile => profile;

	public override bool AllowMultipleInstance => false;

	public CommonHomePortlet()
	{
		profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		profile.ImageUrl = "#calendar.svg";
		profile.Customizable = false;
	}

	public override MvcHtmlString Content(HtmlHelper html, CommonHomePortletPersonalization data)
	{
		return RenderContentAction(html, "CommonHomePortlet", "Home", "EleWise.ELMA.BPM.Web.Common", data);
	}

	protected override Permission PortletPermission()
	{
		return CommonPermissions.AdminPermission;
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		CommonHomePortletPersonalization commonHomePortletPersonalization = base.CreateDefaultSettings(path) as CommonHomePortletPersonalization;
		if (commonHomePortletPersonalization != null)
		{
			commonHomePortletPersonalization.HeaderColor = "#A8DAFA";
			commonHomePortletPersonalization.Frame = PortletFrame.HeaderLine;
		}
		return commonHomePortletPersonalization;
	}
}
