using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class MapElementsInfo
{
	public IWorkflowInstance Instance { get; set; }

	public List<ElementActiveTasks> ElementActiveTasks { get; set; }
}
