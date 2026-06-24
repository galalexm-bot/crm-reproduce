using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;

namespace EleWise.ELMA.Workflow.Web.Models;

public class EmulationContextGridModel
{
	private Dictionary<IWorkflowInstance, List<IWorkflowTaskBase>> currentTasks;

	private Dictionary<IWorkflowInstance, List<WorkflowInstanceTimerInfo>> currentTimers;

	private Dictionary<IWorkflowInstance, List<WorkflowMessageBookmarkInfo>> currentBookmarks;

	private Dictionary<IWorkflowInstance, List<IWorkflowInstance>> currentSubInstances;

	public string GridId { get; set; }

	public bool IsFilterGridState { get; set; }

	public Type ContextType { get; set; }

	public bool ShowStartDateColumn { get; set; }

	public IWorkflowInstanceFilter Filter { get; set; }

	public IGridData GridData { get; set; }

	public IEnumerable<Guid> AvailablePropertyUids { get; set; }

	public Action<GridState> StateLoadedAction { get; set; }

	public string CallbackFunction { get; set; }

	[DefaultValue(false)]
	public bool IsPortletModel { get; set; }

	[DefaultValue(false)]
	public bool IsFilterPortletModel { get; set; }

	public bool DisableCustomize { get; set; }

	public EmulationContextGridModel()
	{
		ShowStartDateColumn = true;
	}

	public EmulationOperationsModel GetOperationsModel(long id)
	{
		IWorkflowInstance instance = WorkflowInstanceManager.Instance.LoadOrNull(id);
		return new EmulationOperationsModel(instance)
		{
			Tasks = GetCurrentTasks(instance),
			Timers = GetCurrentTimers(instance),
			SubInstances = GetCurrentSubInstances(instance),
			MessageBookmarkInfos = GetCurrentMessageBookmarks(instance)
		};
	}

	public IEnumerable<IWorkflowTaskBase> GetCurrentTasks(IWorkflowInstance instance)
	{
		if (currentTasks == null)
		{
			currentTasks = new Dictionary<IWorkflowInstance, List<IWorkflowTaskBase>>();
			foreach (IWorkflowTaskBase item in from t in Locator.GetServiceNotNull<WorkflowTaskBaseManager>().GetTasks(instance)
				where t.WorkflowBookmark != null && t.WorkflowBookmark.Instance != null
				select t)
			{
				IWorkflowInstance instance2 = item.WorkflowBookmark.Instance;
				if (!currentTasks.TryGetValue(instance2, out var value))
				{
					value = new List<IWorkflowTaskBase>();
					currentTasks.Add(instance2, value);
				}
				value.Add(item);
			}
		}
		if (currentTasks.TryGetValue(instance, out var value2))
		{
			return value2;
		}
		return new IWorkflowTaskBase[0];
	}

	public IEnumerable<WorkflowInstanceTimerInfo> GetCurrentTimers(IWorkflowInstance instance)
	{
		if (currentTimers == null)
		{
			currentTimers = new Dictionary<IWorkflowInstance, List<WorkflowInstanceTimerInfo>>();
			List<IWorkflowInstance> list = new List<IWorkflowInstance>();
			list.Add(instance);
			foreach (WorkflowInstanceTimerInfo activeTimerInfo in Locator.GetServiceNotNull<WorkflowInstanceManager>().GetActiveTimerInfos(list))
			{
				IWorkflowInstance instance2 = activeTimerInfo.Instance;
				if (!currentTimers.TryGetValue(instance2, out var value))
				{
					value = new List<WorkflowInstanceTimerInfo>();
					currentTimers.Add(instance2, value);
				}
				value.Add(activeTimerInfo);
			}
		}
		if (currentTimers.TryGetValue(instance, out var value2))
		{
			return value2;
		}
		return new WorkflowInstanceTimerInfo[0];
	}

	public IEnumerable<WorkflowMessageBookmarkInfo> GetCurrentMessageBookmarks(IWorkflowInstance instance)
	{
		if (currentBookmarks == null)
		{
			currentBookmarks = new Dictionary<IWorkflowInstance, List<WorkflowMessageBookmarkInfo>>();
			List<IWorkflowInstance> list = new List<IWorkflowInstance>();
			list.Add(instance);
			foreach (WorkflowMessageBookmarkInfo activeMessageBookmarkInfo in Locator.GetServiceNotNull<IWorkflowMessagingService>().GetActiveMessageBookmarkInfos(list))
			{
				IWorkflowInstance instance2 = activeMessageBookmarkInfo.Instance;
				if (!currentBookmarks.TryGetValue(instance2, out var value))
				{
					value = new List<WorkflowMessageBookmarkInfo>();
					currentBookmarks.Add(instance2, value);
				}
				value.Add(activeMessageBookmarkInfo);
			}
		}
		if (currentBookmarks.TryGetValue(instance, out var value2))
		{
			return value2;
		}
		return new WorkflowMessageBookmarkInfo[0];
	}

	public IEnumerable<IWorkflowInstance> GetCurrentSubInstances(IWorkflowInstance instance)
	{
		if (currentSubInstances == null)
		{
			currentSubInstances = new Dictionary<IWorkflowInstance, List<IWorkflowInstance>>();
			List<IWorkflowInstance> list = new List<IWorkflowInstance>();
			list.Add(instance);
			foreach (IWorkflowInstance item in from i in Locator.GetServiceNotNull<WorkflowInstanceManager>().GetActiveSubInstances(list)
				where i.ParentInstance != null
				select i)
			{
				IWorkflowInstance parentInstance = item.ParentInstance;
				if (!currentSubInstances.TryGetValue(parentInstance, out var value))
				{
					value = new List<IWorkflowInstance>();
					currentSubInstances.Add(parentInstance, value);
				}
				value.Add(item);
			}
		}
		if (currentSubInstances.TryGetValue(instance, out var value2))
		{
			return value2;
		}
		return new IWorkflowInstance[0];
	}
}
