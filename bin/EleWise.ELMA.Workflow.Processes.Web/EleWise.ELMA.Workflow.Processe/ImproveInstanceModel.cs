using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class ImproveInstanceModel
{
	public IWorkflowInstance Instance { get; set; }

	public IProcessHeader ImprovedProcessHeader { get; set; }

	public OperationsModel Operations { get; set; }
}
