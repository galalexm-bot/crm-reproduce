using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Content.Portlets;

[Component]
public class PortalHomePortlet : Portlet<PortalHomePortletPersonalization>
{
	public static string UID_S = "{379BEFA6-96AC-4FDB-B49E-6423294215B6}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Настройки портала");

	public override string Description => SR.T("Быстрый доступ к настройке портала");

	public override IPortletProfile Profile => profile;

	public override bool AllowMultipleInstance => false;

	public PortalHomePortlet()
	{
		profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		profile.ImageUrl = "~/Content/IconPack/setting.svg";
		profile.Customizable = false;
	}

	public override MvcHtmlString Content(HtmlHelper html, PortalHomePortletPersonalization data)
	{
		return RenderContentAction(html, "PortalHomePortlet", "Portal", "EleWise.ELMA.BPM.Web.Content", data);
	}

	protected override Permission PortletPermission()
	{
		return CommonPermissions.AdminPermission;
	}

	public override bool HasPermission()
	{
		if (base.HasPermission())
		{
			return base.SecurityService.HasPermission(EleWise.ELMA.Content.PermissionProvider.ContentAdminPermission);
		}
		return false;
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		PortalHomePortletPersonalization portalHomePortletPersonalization = base.CreateDefaultSettings(path) as PortalHomePortletPersonalization;
		if (portalHomePortletPersonalization != null)
		{
			portalHomePortletPersonalization.HeaderColor = "#D5D2D2";
			portalHomePortletPersonalization.Frame = PortletFrame.HeaderLine;
		}
		return portalHomePortletPersonalization;
	}
}
