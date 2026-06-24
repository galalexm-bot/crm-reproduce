using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class SolveTaskGridModel : TaskGridModel
{
	public SolveTaskPortletPersonalization Settings { get; set; }

	public bool ForControl { get; set; }

	public string GridAction { get; set; }

	public string GridController { get; set; }

	public object GridRouteValues { get; set; }

	public MvcHtmlString GetView(HtmlHelper html, ITaskBase task)
	{
		ISolveTaskViewer solveTaskViewer = ComponentManager.Current.GetExtensionPoints<ISolveTaskViewer>().FirstOrDefault((ISolveTaskViewer p) => p.CheckType(task));
		if (solveTaskViewer == null)
		{
			return MvcHtmlString.Empty;
		}
		return solveTaskViewer.Render(html, task, Settings, ForControl);
	}

	public SolveTaskActionsModel GetActions(ITaskBase task)
	{
		return GetActions(task, Settings);
	}

	public static SolveTaskActionsModel GetActions(ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return new SolveTaskActionsModel
		{
			Task = task,
			Actions = ((!settings.HideActions) ? (from p in ComponentManager.Current.GetExtensionPoints<ISolveTaskAction>()
				where p.CheckType(task) && p.IsVisible(task, settings.DebugMode)
				group p by p.ActionKey into g
				select g.FirstOrDefault()).ToList() : new List<ISolveTaskAction>()),
			Settings = settings
		};
	}

	public SolveTaskGridModel()
	{
		GridAction = "SolveTaskPortletGrid";
		GridController = "AllTasks";
		GridRouteValues = new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		};
	}
}
