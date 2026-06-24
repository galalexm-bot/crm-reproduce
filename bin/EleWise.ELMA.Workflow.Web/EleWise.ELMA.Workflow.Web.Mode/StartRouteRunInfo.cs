using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class StartRouteRunInfo
{
	public string UrlRedirect { get; set; }

	public IWorkflowInstance Instance { get; set; }
}
