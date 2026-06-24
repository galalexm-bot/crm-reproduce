using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class WorkflowTasksInfoViewModel
{
	private Lazy<List<IWorkflowTaskBase>> tasks;

	public IWorkflowInstance Instance { get; set; }

	public List<IWorkflowTaskBase> Tasks
	{
		get
		{
			if (Instance == null)
			{
				return new List<IWorkflowTaskBase>();
			}
			if (tasks == null)
			{
				tasks = new Lazy<List<IWorkflowTaskBase>>(delegate
				{
					WorkflowTaskBaseManager instance = WorkflowTaskBaseManager.Instance;
					InstanceOf<IWorkflowTaskBaseFilter> instanceOf = new InstanceOf<IWorkflowTaskBaseFilter>();
					instanceOf.New.InstanceId = Instance.Id;
					instanceOf.New.DisableSecurity = true;
					return (from t in instance.Find(instanceOf.New, FetchOptions.All)
						orderby t.CreationDate
						select t).ToList();
				});
			}
			return tasks.Value;
		}
	}
}
