using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Portlets;

[Component(Order = 120)]
public class ChangeControlSolveTaskAction : ISolveTaskAction
{
	public static Guid Uid = new Guid("{8EF316C5-5D6C-4CB9-BC10-BB9F44D9B04F}");

	public string ImageUrl => "#task_watch.svg";

	public virtual string DisplayName => SR.T("Изменить контроль");

	public virtual Guid ActionKey => Uid;

	public bool CheckType(ITaskBase task)
	{
		return task is ITask;
	}

	public virtual bool IsVisible(ITaskBase task, bool debugMode)
	{
		bool res = false;
		SolveTaskHelper.RunWithDebug("ChangeControlSolveTaskAction.IsVisible", debugMode, delegate
		{
			TaskWorkflowActions serviceNotNull = Locator.GetServiceNotNull<TaskWorkflowActions>();
			res = serviceNotNull.IsAvailableChangeControl(task, Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>());
		});
		return res;
	}

	public virtual void RenderControls(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		SolveTaskBaseActionControlsModel model = new SolveTaskBaseActionControlsModel
		{
			Entity = task,
			Settings = settings
		};
		SolveTaskHelper.RunWithDebug("ChangeControlSolveTaskAction.RenderControls", settings.DebugMode, delegate
		{
			RenderPartialExtensions.RenderPartial(helper, "SolvePortlet/ChangeControlSolveTaskControls", (object)model);
		});
	}

	public string RenderAction(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Tasks" },
			{ "id", task.Id },
			{ "returnUrl", "~/" }
		};
		return string.Format("refreshPopup('{0}', '{1}')", SolveTaskBaseActionControlsModel.ChangeControlTaskBaseActionPopup, helper.Url().Action("ChangeControl", "Task", routeValueDictionary));
	}

	public bool IsScript(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return true;
	}

	public void RenderPopups(HtmlHelper helper, bool debugMode)
	{
		SolveTaskHelper.RunWithDebug("ChangeControlSolveTaskAction.RenderPopups", debugMode, delegate
		{
			RenderAllPopups(helper);
		});
	}

	public static void RenderAllPopups(HtmlHelper helper)
	{
		helper.RegisterContent(SolveTaskBaseActionControlsModel.ChangeControlTaskBaseActionPopup, (dynamic d) => helper.PopupWindow(SolveTaskBaseActionControlsModel.ChangeControlTaskBaseActionPopup, SR.T("Изменение контроля задачи"), ""));
	}
}
