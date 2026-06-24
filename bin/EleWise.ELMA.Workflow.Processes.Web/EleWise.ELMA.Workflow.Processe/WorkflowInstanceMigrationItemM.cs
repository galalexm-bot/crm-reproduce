using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class WorkflowInstanceMigrationItemModel
{
	public IWorkflowInstance WorkflowInstance { get; set; }

	public WorkflowInstanceMigrationItemStatus? Status { get; set; }

	public bool NeedLinkToSingleMigration { get; set; }

	public long Id { get; set; }
}
