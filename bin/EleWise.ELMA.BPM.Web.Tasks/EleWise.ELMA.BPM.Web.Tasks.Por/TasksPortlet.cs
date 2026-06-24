using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Component]
public class TasksPortlet : Portlet<TasksPortletPersonalization>
{
	public static string UID_S = "{23F8C562-117D-4271-A537-9FBFB500A552}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Задачи");

	public override string Description => SR.T("Портлет для отображения задач назначенных на меня");

	public override IPortletProfile Profile => _profile;

	public override bool GoodExternalSupported => true;

	public TasksPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.ImageUrl = "#task.svg";
		_profile.Customizable = true;
	}

	public override MvcHtmlString Content(HtmlHelper html, TasksPortletPersonalization data)
	{
		return RenderContentAction(html, "MyTasksPortlet", "AllTasks", "EleWise.ELMA.BPM.Web.Tasks", data);
	}

	[Obsolete("Use GetNameUrl(UrlHelper, TasksPortletPersonalization)", false)]
	public override string GetNameUrl(UrlHelper urlHelper)
	{
		return urlHelper.Action("Incoming", "AllTasks", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			FilterId = 0
		});
	}

	protected override Permission PortletPermission()
	{
		return EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission;
	}
}
