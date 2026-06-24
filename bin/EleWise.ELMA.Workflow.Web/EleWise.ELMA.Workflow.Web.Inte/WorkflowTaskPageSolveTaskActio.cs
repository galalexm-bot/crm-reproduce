using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Integration.Portlets;

[Component(Order = 50)]
public class WorkflowTaskPageSolveTaskAction : ISolveTaskAction
{
	public static Guid Uid = new Guid("{DC6D23B7-3006-4CBF-8D5D-435ACE3A3A4B}");

	public string ImageUrl => "#play.svg";

	public virtual string DisplayName => SR.T("Перейти к выполнению задачи");

	public virtual Guid ActionKey => Uid;

	public bool CheckType(ITaskBase task)
	{
		return task is IWorkflowTask;
	}

	public virtual bool IsVisible(ITaskBase task, bool debugMode)
	{
		return task.IsActive();
	}

	public virtual void RenderControls(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
	}

	public string RenderAction(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return helper.Url().Entity(task.CastAsRealType());
	}

	public bool IsScript(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return false;
	}

	public void RenderPopups(HtmlHelper helper, bool debugMode)
	{
	}
}
