using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Security.Portlets;

[Component]
public class UsersHomePortlet : Portlet<UsersHomePortletPersonalization>
{
	public static string UID_S = "{1276B87B-8609-47B3-89F0-25BC05BE3321}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Пользователи");

	public override string Description => SR.T("Домашний портлет со ссылками на разделы администрирования пользователей");

	public override IPortletProfile Profile => profile;

	public override bool AllowMultipleInstance => false;

	public UsersHomePortlet()
	{
		profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		profile.ImageUrl = "#user.svg";
		profile.Customizable = false;
	}

	public override MvcHtmlString Content(HtmlHelper html, UsersHomePortletPersonalization data)
	{
		return RenderContentAction(html, "UsersHomePortlet", "User", "EleWise.ELMA.BPM.Web.Security", data);
	}

	protected override Permission PortletPermission()
	{
		return PermissionProvider.UserManagmentPermission;
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		UsersHomePortletPersonalization usersHomePortletPersonalization = base.CreateDefaultSettings(path) as UsersHomePortletPersonalization;
		if (usersHomePortletPersonalization != null)
		{
			usersHomePortletPersonalization.HeaderColor = "#A8DAFA";
			usersHomePortletPersonalization.Frame = PortletFrame.HeaderLine;
		}
		return usersHomePortletPersonalization;
	}
}
