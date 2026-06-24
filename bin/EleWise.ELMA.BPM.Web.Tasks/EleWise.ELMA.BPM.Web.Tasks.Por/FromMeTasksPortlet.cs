using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Component]
public class FromMeTasksPortlet : Portlet<FromMeTasksPortletPersonalization>
{
	public static string UID_S = "{165E3022-5A75-45F4-8D83-14D880CA1926}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Задачи от меня / Контроль");

	public override string Description => SR.T("Портлет для отображения исходящих задач");

	public FromMeTasksPortlet()
	{
		_profile = base.Profile as PortletProfile;
		if (_profile == null)
		{
			_profile = PortletProfile.Default;
			_profile.DefaultZone = "Right";
		}
		_profile.ImageUrl = "#task_start.svg";
		_profile.Customizable = true;
		_profile.CssClass = "from-me-tasks";
	}

	[Obsolete("Use GetNameUrl(UrlHelper, PortletPersonalization)", false)]
	public override string GetNameUrl(UrlHelper urlHelper)
	{
		return urlHelper.Action("Outgoing", "AllTasks", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			FilterId = 0
		});
	}

	public override MvcHtmlString Content(HtmlHelper html, FromMeTasksPortletPersonalization data)
	{
		return RenderContentAction(html, "FromMeTasksPortlet", "FromMeTasks", "EleWise.ELMA.BPM.Web.Tasks", data);
	}

	public override MvcHtmlString Settings(HtmlHelper html, FromMeTasksPortletPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "FromMeTasks/FromMeTasksPortletSetting", data);
	}

	protected override Permission PortletPermission()
	{
		return EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission;
	}
}
