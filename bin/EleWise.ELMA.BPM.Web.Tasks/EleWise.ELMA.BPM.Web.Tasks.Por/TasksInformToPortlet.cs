using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Component]
public class TasksInformToPortlet : Portlet<TasksInformToPortletPersonalization>
{
	public static string UID_S = "{6B2DF1BB-2266-48D0-BB48-96FACA2F2E36}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Задачи (я – соисполнитель)");

	public override string Description => SR.T("Портлет для отображения задач, в которых я являюсь соисполнителем");

	public override IPortletProfile Profile => _profile;

	public override bool GoodExternalSupported => true;

	public TasksInformToPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.ImageUrl = "#task.svg";
		_profile.Customizable = true;
	}

	public override MvcHtmlString Content(HtmlHelper html, TasksInformToPortletPersonalization data)
	{
		return RenderContentAction(html, "MyTasksInformToPortlet", "AllTasks", "EleWise.ELMA.BPM.Web.Tasks", data);
	}

	public override string GetNameUrl(UrlHelper urlHelper, TasksInformToPortletPersonalization data)
	{
		return urlHelper.Action("Incoming", "AllTasks", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			FilterId = 0,
			status = TaskCompleteStatus.Active,
			type = SearchTasksType.ForICoExecutorCurrent
		});
	}

	protected override Permission PortletPermission()
	{
		return EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission;
	}
}
