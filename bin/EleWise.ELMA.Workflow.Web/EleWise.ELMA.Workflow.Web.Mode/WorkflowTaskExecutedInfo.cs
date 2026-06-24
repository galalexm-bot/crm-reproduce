using System;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class WorkflowTaskExecutedInfo : WorkflowInstanceExecuteInfo
{
	public IWorkflowTaskBase Task { get; set; }

	public WorkflowTaskExecutedInfo(IWorkflowTaskBase task)
		: this(task, null)
	{
	}

	public WorkflowTaskExecutedInfo(IWorkflowTaskBase task, bool? redirectOnComplete)
		: base(task.WorkflowBookmark.Instance, redirectOnComplete)
	{
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		Task = task;
	}
}
