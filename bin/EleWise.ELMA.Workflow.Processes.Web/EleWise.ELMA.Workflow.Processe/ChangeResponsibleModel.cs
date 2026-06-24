using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class ChangeResponsibleModel
{
	public IUser Responsible { get; set; }

	public IWorkflowInstance Instance { get; set; }

	public string GridId { get; set; }

	public string PopupId { get; set; }
}
