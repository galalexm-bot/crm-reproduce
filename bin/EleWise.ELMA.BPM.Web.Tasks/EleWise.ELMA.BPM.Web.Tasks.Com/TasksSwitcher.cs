using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class TasksSwitcher : IActionItemProvider
{
	public const string BreadcrumbsId = "task-breadcrumbs";

	public TaskBaseManager TaskBaseManager { get; set; }

	public ISecurityService SecurityService { get; set; }

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (!htmlHelper.get_ViewData().TryGetValue("SearchTasksType", out SearchTasksType value))
		{
			return Enumerable.Empty<IActionItem>();
		}
		UrlHelper val = htmlHelper.Url();
		ActionButton actionButton = new ActionButton("tasks_switcher_menu");
		actionButton.AsSwitcher = true;
		actionButton.Items.Add(new ActionButton
		{
			Uid = "incomingThread",
			Text = SR.T("Входящие"),
			Url = val.Action("Incoming", "AllTasks", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			}),
			IsChecked = (value == SearchTasksType.Incoming)
		});
		actionButton.Items.Add(new ActionButton
		{
			Uid = "outgoingThread",
			Text = SR.T("Исходящие"),
			Url = val.Action("Outgoing", "AllTasks", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			}),
			IsChecked = (value == SearchTasksType.Outgoing)
		});
		if (SecurityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission))
		{
			EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			Guid taskUid = InterfaceActivator.UID<ITask>();
			if (CurrentControlIsAvalilable(taskUid, currentUser))
			{
				actionButton.Items.Add(new ActionButton
				{
					Uid = "currentControlThread",
					Text = SR.T("Текущий контроль"),
					Url = val.Action("CurrentControl", "AllTasks", (object)new
					{
						area = "EleWise.ELMA.BPM.Web.Tasks",
						FilterId = 0
					}),
					IsChecked = (value == SearchTasksType.CurrentControl)
				});
			}
			if (ExecutionControlIsAvalilable(taskUid, currentUser))
			{
				actionButton.Items.Add(new ActionButton
				{
					Uid = "executionControlThread",
					Text = SR.T("Контроль выполнения"),
					Url = val.Action("ExecutionControl", "AllTasks", (object)new
					{
						area = "EleWise.ELMA.BPM.Web.Tasks",
						FilterId = 0
					}),
					IsChecked = (value == SearchTasksType.ExecutionControl)
				});
			}
			if (CoExecutionIsAvalilable(taskUid))
			{
				actionButton.Items.Add(new ActionButton
				{
					Uid = "CoexecutionTread",
					Text = SR.T("Соисполнение"),
					Url = val.Action("Coexecution", "AllTasks", (object)new
					{
						area = "EleWise.ELMA.BPM.Web.Tasks",
						FilterId = 0
					}),
					IsChecked = (value == SearchTasksType.CoExecutorCurrent)
				});
			}
		}
		actionButton.Items.Add(new ActionButton
		{
			Uid = "searchThread",
			Text = SR.Search,
			Url = val.Action("Search", "AllTasks", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			}),
			IsChecked = (value == SearchTasksType.Search)
		});
		return new IActionItem[1] { actionButton };
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || !(rootItem.Uid == "task-breadcrumbs"))
		{
			return;
		}
		foreach (IActionItem item in GetItems(rootItem, htmlHelper))
		{
			rootItem.Items.Insert(0, item);
		}
	}

	private bool CoExecutionIsAvalilable(Guid taskUid)
	{
		ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
		taskFilter.NotShowInLists = false;
		taskFilter.TypeUid = taskUid;
		taskFilter.Query = "InformTo = CurrentUser()";
		taskFilter.CompleteStatus = TaskCompleteStatus.Active;
		return TaskBaseManager.Exists(taskFilter);
	}

	private bool ExecutionControlIsAvalilable(Guid taskUid, EleWise.ELMA.Security.Models.IUser user)
	{
		ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
		taskFilter.NotShowInLists = false;
		taskFilter.TypeUid = taskUid;
		taskFilter.UnderControl = true;
		taskFilter.ControlType = TaskControlType.Execution;
		taskFilter.Statuses = TaskBaseExtensions.ControlStatuses.ToList();
		taskFilter.ControlUser = user;
		return TaskBaseManager.Exists(taskFilter);
	}

	private bool CurrentControlIsAvalilable(Guid taskUid, EleWise.ELMA.Security.Models.IUser user)
	{
		ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
		taskFilter.NotShowInLists = false;
		taskFilter.TypeUid = taskUid;
		taskFilter.UnderControl = true;
		taskFilter.Statuses = TaskBaseExtensions.CurrentControlStatuses.ToList();
		taskFilter.CurrentControllers.Add(user);
		return TaskBaseManager.Exists(taskFilter);
	}
}
