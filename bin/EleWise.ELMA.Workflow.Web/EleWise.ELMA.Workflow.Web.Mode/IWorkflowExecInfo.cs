namespace EleWise.ELMA.Workflow.Web.Models;

public interface IWorkflowExecInfo
{
	long HeaderId { get; }

	long InstanceId { get; }

	long TaskId { get; }
}
