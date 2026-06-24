using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class InstanceGridInfo
{
	public string GridPrefix { get; set; }

	public IWorkflowInstanceFilter Filter { get; set; }
}
