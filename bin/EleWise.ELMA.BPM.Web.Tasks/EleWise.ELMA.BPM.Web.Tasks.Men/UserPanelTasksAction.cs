using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Templates.Content.IconPack;

namespace EleWise.ELMA.BPM.Web.Tasks.Menu;

[Component(Order = 200)]
public class UserPanelTasksAction : CurrentUserPanelAction, ICurrentUserPanelActionDisable, ICurrentUserPanelAction
{
	public override string Id => "UserPanelAction_Tasks";

	public string PropertyName => "UserPanelTasks";

	public override string GetIconUrl(HtmlHelper html)
	{
		return html.Url().GetIcon("#task.svg");
	}

	public override string GetActionUrl(HtmlHelper html)
	{
		return "/Tasks/AllTasks/Incoming?FilterId=0";
	}

	public override MenuItemCount GetCount()
	{
		return TasksMenuItemCountEvaluator.Evaluate(useClientUpdateFunction: false);
	}

	public override bool IsVisible()
	{
		if (!Locator.GetServiceNotNull<ISecurityService>().HasPermission(EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission))
		{
			return false;
		}
		return IsEnabled(WorkPlaceExtensions.GetCurrentWorkPlace(loadDefaultWorkPlace: true));
	}

	public bool IsEnabled(IWorkPlace workPlace)
	{
		return ((IWorkPlaceTasks)workPlace).UserPanelTasks ?? true;
	}
}
