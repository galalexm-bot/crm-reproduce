using System.Collections.Generic;
using System.Collections.ObjectModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.ExtensionPoints;
using EleWise.ELMA.Workflow.Security;
using EleWise.ELMA.Workflow.Services;
using EleWise.ELMA.Workflow.Web.Integration.ExecutedTaskInfos;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class OperationsModel
{
	private IEnumerable<IWorkflowOperationsExtension> workflowOperationsExtensions;

	public IWorkflowInstance Instance { get; set; }

	public IEnumerable<IWorkflowTaskBase> Tasks { get; set; }

	public IEnumerable<WorkflowInstanceTimerInfo> Timers { get; set; }

	public IEnumerable<IWorkflowInstance> SubInstances { get; set; }

	public IEnumerable<WorkflowMessageBookmarkInfo> MessageBookmarkInfos { get; set; }

	public IEnumerable<IWorkflowQueueItem> QueueItems { get; set; }

	public IEnumerable<IWorkflowOperationsExtension> WorkflowOperationsExtensions => workflowOperationsExtensions ?? (workflowOperationsExtensions = Locator.GetService<IEnumerable<IWorkflowOperationsExtension>>());

	public OperationsModel()
	{
	}

	public OperationsModel(IWorkflowInstance instance)
	{
		Instance = instance;
	}

	public OperationsModel(IWorkflowInstance instance, bool init, bool initTasks)
	{
		Instance = instance;
		if (init)
		{
			Init(initTasks);
		}
	}

	public void Init(bool initTasks)
	{
		if (Instance == null)
		{
			return;
		}
		if (initTasks)
		{
			WorkflowTaskBaseManager serviceNotNull = Locator.GetServiceNotNull<WorkflowTaskBaseManager>();
			Tasks = serviceNotNull.GetTasks(Instance, allowSubInstances: false, ActiveTasksInfoProvider.Projections);
		}
		WorkflowInstanceManager serviceNotNull2 = Locator.GetServiceNotNull<WorkflowInstanceManager>();
		Timers = serviceNotNull2.GetActiveTimerInfos(new Collection<IWorkflowInstance> { Instance });
		SubInstances = serviceNotNull2.GetActiveSubInstances(new Collection<IWorkflowInstance> { Instance });
		IWorkflowMessagingService serviceNotNull3 = Locator.GetServiceNotNull<IWorkflowMessagingService>();
		MessageBookmarkInfos = serviceNotNull3.GetActiveMessageBookmarkInfos(new Collection<IWorkflowInstance> { Instance });
		if (Locator.GetServiceNotNull<ISecurityService>().HasPermission(WorkflowProcessesPermissionProvider.WorkflowQueueManagementPermission))
		{
			WorkflowQueueItemManager serviceNotNull4 = Locator.GetServiceNotNull<WorkflowQueueItemManager>();
			QueueItems = serviceNotNull4.Find((IWorkflowQueueItem qi) => qi.Instance == Instance);
		}
	}
}
