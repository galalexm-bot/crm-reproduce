using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class EmulationMonitorModel
{
	public class EmulationInstance
	{
		private IEnumerable<IWorkflowTaskBase> allTasks;

		public IWorkflowInstance Instance;

		public static List<string> TaskProjections = new List<string>
		{
			LinqUtils.NameOf((Expression<Func<IWorkflowTaskBase, object>>)((IWorkflowTaskBase t) => t.Id)),
			LinqUtils.NameOf((Expression<Func<IWorkflowTaskBase, object>>)((IWorkflowTaskBase t) => t.TypeUid)),
			LinqUtils.NameOf((Expression<Func<IWorkflowTaskBase, object>>)((IWorkflowTaskBase t) => t.Subject)),
			LinqUtils.NameOf((Expression<Func<IWorkflowTaskBase, object>>)((IWorkflowTaskBase t) => t.WorkflowBookmark))
		};

		private Dictionary<IWorkflowInstance, List<IWorkflowInstance>> currentSubInstances;

		public IEnumerable<IWorkflowTaskBase> GetCurrentTasks()
		{
			if (allTasks == null)
			{
				allTasks = Locator.GetServiceNotNull<WorkflowTaskBaseManager>().GetTasks(Instance, allowSubInstances: true, TaskProjections);
				return allTasks;
			}
			return allTasks;
		}

		public IEnumerable<IWorkflowInstance> GetCurrentSubInstances()
		{
			if (currentSubInstances == null)
			{
				currentSubInstances = new Dictionary<IWorkflowInstance, List<IWorkflowInstance>>();
				foreach (IWorkflowInstance item in from i in Locator.GetServiceNotNull<WorkflowInstanceManager>().GetActiveSubInstances(new List<IWorkflowInstance> { Instance })
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
			if (currentSubInstances.TryGetValue(Instance, out var value2))
			{
				return value2;
			}
			return new IWorkflowInstance[0];
		}
	}

	public List<EmulationInstance> Instances;

	public EmulationMonitorModel()
	{
		Instances = new List<EmulationInstance>();
		IWorkflowInstanceFilter workflowInstanceFilter = InterfaceActivator.Create<IWorkflowInstanceFilter>();
		workflowInstanceFilter.IsEmulation = true;
		workflowInstanceFilter.Initiator = (IUser)Locator.GetService<IAuthenticationService>().GetCurrentUser();
		workflowInstanceFilter.Statuses = new List<WorkflowInstanceStatus>
		{
			WorkflowInstanceStatus.None,
			WorkflowInstanceStatus.Running
		};
		new EmulationInstance();
		foreach (IWorkflowInstance item2 in WorkflowInstanceManager.Instance.Find(workflowInstanceFilter, null))
		{
			EmulationInstance item = new EmulationInstance
			{
				Instance = item2
			};
			Instances.Add(item);
		}
	}
}
