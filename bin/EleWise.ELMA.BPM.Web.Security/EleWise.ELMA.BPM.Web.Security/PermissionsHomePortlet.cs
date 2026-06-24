using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Security.Portlets;

[Component]
public class PermissionsHomePortlet : Portlet<PermissionsHomePortletPersonalization>
{
	public static string UID_S = "{5FBBB18E-CA23-41D1-8BC1-FA53C803FCE2}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Доступ приложений");

	public override string Description => SR.T("Домашний портлет со ссылками на разделы администрирования пользователей");

	public override IPortletProfile Profile => profile;

	public override bool AllowMultipleInstance => false;

	public PermissionsHomePortlet()
	{
		profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		profile.ImageUrl = "#access_vertical.svg";
		profile.Customizable = false;
	}

	public override MvcHtmlString Content(HtmlHelper html, PermissionsHomePortletPersonalization data)
	{
		return RenderContentAction(html, "PermissionsHomePortlet", "Permission", "EleWise.ELMA.BPM.Web.Security", data);
	}

	protected override Permission PortletPermission()
	{
		return CommonPermissions.AdminPermission;
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		PermissionsHomePortletPersonalization permissionsHomePortletPersonalization = base.CreateDefaultSettings(path) as PermissionsHomePortletPersonalization;
		if (permissionsHomePortletPersonalization != null)
		{
			permissionsHomePortletPersonalization.HeaderColor = "#EDC3BC";
			permissionsHomePortletPersonalization.Frame = PortletFrame.HeaderLine;
		}
		return permissionsHomePortletPersonalization;
	}
}
