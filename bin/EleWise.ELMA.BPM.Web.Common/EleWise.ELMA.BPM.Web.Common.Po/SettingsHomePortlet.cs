using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Portlets;

[Component]
public class SettingsHomePortlet : Portlet<SettingsHomePortletPersonalization>
{
	public static string UID_S = "{AC6255B3-C106-4E38-8C8B-D83FA80C0D9F}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Настройки системы");

	public override string Description => SR.T("Быстрый доступ к странице настроек системы");

	public override IPortletProfile Profile => profile;

	public override bool AllowMultipleInstance => false;

	public SettingsHomePortlet()
	{
		profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		profile.ImageUrl = "#setting.svg";
		profile.Customizable = false;
	}

	public override MvcHtmlString Content(HtmlHelper html, SettingsHomePortletPersonalization data)
	{
		return RenderContentAction(html, "SettingsHomePortlet", "Settings", "EleWise.ELMA.BPM.Web.Common", data);
	}

	protected override Permission PortletPermission()
	{
		return CommonPermissions.AdminPermission;
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		SettingsHomePortletPersonalization settingsHomePortletPersonalization = base.CreateDefaultSettings(path) as SettingsHomePortletPersonalization;
		if (settingsHomePortletPersonalization != null)
		{
			settingsHomePortletPersonalization.HeaderColor = "#e1dede";
			settingsHomePortletPersonalization.Frame = PortletFrame.HeaderLine;
		}
		return settingsHomePortletPersonalization;
	}
}
