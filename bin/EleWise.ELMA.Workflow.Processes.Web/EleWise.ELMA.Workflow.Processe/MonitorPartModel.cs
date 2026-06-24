using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class MonitorPartModel
{
	public string PartId { get; set; }

	public string Title { get; set; }

	public List<ProcessHeaderInfo> Headers { get; set; }
}
