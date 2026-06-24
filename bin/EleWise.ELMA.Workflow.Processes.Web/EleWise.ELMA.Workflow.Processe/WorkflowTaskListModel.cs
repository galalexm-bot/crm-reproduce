using System.Collections.Generic;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class WorkflowTaskListModel
{
	public List<IWorkflowTaskBase> Tasks { get; set; }

	public IUser CurrentUser { get; set; }
}
