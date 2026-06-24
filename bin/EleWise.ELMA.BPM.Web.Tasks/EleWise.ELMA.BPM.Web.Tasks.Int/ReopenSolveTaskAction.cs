using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Portlets;

[Component(Order = 60)]
public class ReopenSolveTaskAction : ISolveTaskAction
{
	public static Guid Uid = new Guid("{8051DE71-A800-479A-A90D-E5B16B69BE6D}");

	public string ImageUrl => "#refresh.svg";

	public virtual string DisplayName => SR.T("Открыть заново");

	public virtual Guid ActionKey => Uid;

	public bool CheckType(ITaskBase task)
	{
		return task is ITask;
	}

	public virtual bool IsVisible(ITaskBase task, bool debugMode)
	{
		bool res = false;
		SolveTaskHelper.RunWithDebug("ReopenSolveTaskAction.IsVisible", debugMode, delegate
		{
			TaskWorkflowActions serviceNotNull = Locator.GetServiceNotNull<TaskWorkflowActions>();
			res = serviceNotNull.IsAvailableControlledAction(task, Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>());
		});
		return res;
	}

	public virtual void RenderControls(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
	}

	public string RenderAction(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return helper.Url().Action("ReOpen", "Task", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			id = task.Id
		});
	}

	public bool IsScript(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return false;
	}

	public void RenderPopups(HtmlHelper helper, bool debugMode)
	{
	}
}
