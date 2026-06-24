using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[Permission("76EC51E5-E826-4876-8B8A-BFED9D2CF6CF")]
public class FromMeTasksController : BPMController<ITaskBase, long>
{
	public PortletManager PortletManager { get; set; }

	public TaskBaseManager TaskBaseManager { get; set; }

	private IEntityFilter CreateFilter(DateTime dateTime, bool showComplited = false)
	{
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.NotShowInLists = false;
		taskBaseFilter.Statuses = new List<TaskBaseStatus>
		{
			TaskBaseStatus.NewOrder,
			TaskBaseStatus.InProgress,
			TaskBaseStatus.Read,
			TaskBaseStatus.OnApproval
		};
		if (showComplited && (dateTime.IsToday() || dateTime > DateTime.Now))
		{
			taskBaseFilter.Statuses.AddRange(new List<TaskBaseStatus>
			{
				TaskBaseStatus.CompleteControlled,
				TaskBaseStatus.IncompleteControlled
			});
		}
		taskBaseFilter.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
		taskBaseFilter.EndDate = new RelativeDateTime(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0), new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 23, 59, 59));
		return taskBaseFilter;
	}

	private GridData<ITaskBase> CreateGridData(GridCommand command, DateTime dateTime, bool showComplited = false)
	{
		GridData<ITaskBase, IEntityFilter> gridData = CreateGridData(command, CreateFilter(dateTime, showComplited));
		gridData.AddCountExecuted(delegate(GridData<ITaskBase, IEntityFilter> d)
		{
			d.IsPageable = d.Count > 10;
		});
		return gridData;
	}

	private ITaskControlFilter CreateUnderControlFilter(TaskControlType controlType = TaskControlType.Execution)
	{
		ITaskControlFilter taskControlFilter = InterfaceActivator.Create<ITaskControlFilter>();
		taskControlFilter.NotShowInLists = false;
		if (controlType == TaskControlType.Execution)
		{
			taskControlFilter.ControlUser = base.AuthenticationService.GetCurrentUser<IUser>();
			taskControlFilter.ControlType = controlType;
			taskControlFilter.ControlStatus = TaskControlStatus.ExecutionActive;
		}
		else
		{
			taskControlFilter.CurrentControllers.Add(base.AuthenticationService.GetCurrentUser<IUser>());
			taskControlFilter.ControlStatus = TaskControlStatus.Current;
		}
		return taskControlFilter;
	}

	private GridData<ITaskBase> CreateUnderControlTasksGridData(GridCommand command, TaskControlType controlType = TaskControlType.Execution)
	{
		GridData<ITaskBase, ITaskControlFilter> gridData = TaskBaseManager.CreateGridData<ITaskBase, ITaskControlFilter, ITaskBase>(command, CreateUnderControlFilter(controlType));
		gridData.AddCountExecuted(delegate(GridData<ITaskBase, ITaskControlFilter> d)
		{
			d.IsPageable = d.Count > 10;
		});
		return gridData;
	}

	[HttpGet]
	public ActionResult FromMeTasksPortlet(FromMeTasksPortletPersonalization settings)
	{
		FromMeTasksModel fromMeTasksModel = new FromMeTasksModel
		{
			ShowCompleted = settings.ShowCompleted,
			Current = ((TaskBaseManager)base.Manager).GetCurrentCountFrom(base.AuthenticationService.GetCurrentUser<IUser>()),
			Expired = ((TaskBaseManager)base.Manager).GetExpiredCount(base.AuthenticationService.GetCurrentUser<IUser>()),
			PortletId = settings.InstanceId.ToStringId()
		};
		DateTime dateTime = DateTime.Now.AddDays(-settings.DaysAgo);
		DateTime dateTime2 = DateTime.Now.AddDays(settings.DaysAhead);
		while (dateTime <= dateTime2)
		{
			long num = base.Manager.Count(CreateFilter(dateTime, settings.ShowCompleted));
			if (num > 0 || dateTime.IsToday())
			{
				fromMeTasksModel.TasksGrids.Add(dateTime, num);
			}
			dateTime = dateTime.AddDays(1.0);
		}
		fromMeTasksModel.UnderControlTasks = TaskBaseManager.Count(CreateUnderControlFilter());
		fromMeTasksModel.ControlCurrentTasks = TaskBaseManager.Count(CreateUnderControlFilter(TaskControlType.Current));
		return (ActionResult)(object)((Controller)this).PartialView((object)fromMeTasksModel);
	}

	[CustomGridAction]
	public ActionResult FromMeTasksGrid(GridCommand command, string gridId, string clientDateTimeS, bool? underControl, TaskControlType? controlType, bool? showCompleted, bool? portlet)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		DateTime? dateTime = null;
		if (!string.IsNullOrEmpty(clientDateTimeS))
		{
			dateTime = DateTime.Parse(clientDateTimeS).ToRuntimeDateTimeFromClient();
		}
		if (command != null && string.IsNullOrEmpty(command.get_SortExpressionString()))
		{
			IList<SortDescriptor> sortDescriptors = command.get_SortDescriptors();
			SortDescriptor val = new SortDescriptor();
			val.set_Member("CreationDate");
			val.set_SortDirection(ListSortDirection.Descending);
			sortDescriptors.Add(val);
		}
		((ControllerBase)this).get_ViewData().set_Item("gridId", (object)gridId);
		((ControllerBase)this).get_ViewData().set_Item("Portlet", (object)portlet);
		GridData<ITaskBase> gridData = ((underControl.HasValue && underControl.Value) ? CreateUnderControlTasksGridData(command, controlType ?? TaskControlType.Execution) : CreateGridData(command, dateTime ?? DateTime.Now, showCompleted.HasValue && showCompleted.Value));
		return GridView(gridData);
	}
}
