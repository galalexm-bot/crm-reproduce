using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Portlets;

[Component]
public class SystemInfoPortlet : Portlet<SystemInfoPortletPersonalization>
{
	public static string UID_S = "{2DADFE6A-69A6-4353-A69F-B10C490316B1}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Информация о лицензиях");

	public override string Description => SR.T("Информация о системе");

	public override IPortletProfile Profile => profile;

	public override bool AllowMultipleInstance => false;

	public SystemInfoPortlet()
	{
		profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		profile.ImageUrl = "#licence.svg";
		profile.Customizable = false;
	}

	public override MvcHtmlString Content(HtmlHelper html, SystemInfoPortletPersonalization data)
	{
		return RenderContentAction(html, "SystemInfoPortlet", "Home", "EleWise.ELMA.BPM.Web.Common", data);
	}

	protected override Permission PortletPermission()
	{
		return CommonPermissions.AdminPermission;
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		SystemInfoPortletPersonalization systemInfoPortletPersonalization = base.CreateDefaultSettings(path) as SystemInfoPortletPersonalization;
		if (systemInfoPortletPersonalization != null)
		{
			systemInfoPortletPersonalization.HeaderColor = "#C4EA96";
			systemInfoPortletPersonalization.Frame = PortletFrame.HeaderLine;
		}
		return systemInfoPortletPersonalization;
	}
}
