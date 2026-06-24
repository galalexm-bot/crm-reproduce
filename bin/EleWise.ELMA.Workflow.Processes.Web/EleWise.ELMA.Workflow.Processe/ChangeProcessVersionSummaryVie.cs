using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class ChangeProcessVersionSummaryViewModel
{
	public IWorkflowProcess CurrentProcess { get; set; }

	public IWorkflowProcess NewProcess { get; set; }

	public ChangedPropertyViewModel[] AddedProperties { get; set; }

	public ChangedPropertyViewModel[] RemovedProperties { get; set; }
}
