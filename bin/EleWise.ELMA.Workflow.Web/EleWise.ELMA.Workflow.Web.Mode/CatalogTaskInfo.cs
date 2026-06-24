using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class CatalogTaskInfo : IWorkflowExecInfo
{
	public WorkflowTaskInfo WorkflowExecInfo { get; set; }

	public bool ReadOnly { get; set; }

	public bool IsActive { get; set; }

	public bool AllowComplete
	{
		get
		{
			if (WorkflowExecInfo == null || WorkflowExecInfo.Task == null)
			{
				return false;
			}
			return WorkflowExecInfo.Task.CanExecute();
		}
	}

	public long HeaderId
	{
		get
		{
			if (WorkflowExecInfo == null || WorkflowExecInfo.Instance == null)
			{
				return 0L;
			}
			return WorkflowExecInfo.Instance.Process.Header.Id;
		}
	}

	public long InstanceId
	{
		get
		{
			if (WorkflowExecInfo == null || WorkflowExecInfo.Instance == null)
			{
				return 0L;
			}
			return WorkflowExecInfo.Instance.Id;
		}
	}

	public long TaskId
	{
		get
		{
			if (WorkflowExecInfo == null || WorkflowExecInfo.Task == null)
			{
				return 0L;
			}
			return WorkflowExecInfo.Task.Id;
		}
	}

	public string ElmaFormId { get; set; }
}
