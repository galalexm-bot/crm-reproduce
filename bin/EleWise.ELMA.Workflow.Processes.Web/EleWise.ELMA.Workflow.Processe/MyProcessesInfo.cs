using System.Collections.Generic;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class MyProcessesInfo
{
	public enum ViewMode
	{
		Folders,
		List,
		Filter
	}

	public List<ProcessHeaderInfo> Headers { get; set; }

	public IWorkflowInstanceFilter InstanceFilter { get; set; }

	public ViewMode Mode { get; set; }

	public bool ShowStartDateColumn { get; set; }

	public string InstanceGridPrefix { get; set; }

	public IFilter Filter { get; set; }

	public string GridId { get; set; }

	public bool IsPortlet { get; set; }

	public MyProcessesInfo()
	{
		Headers = new List<ProcessHeaderInfo>();
		ShowStartDateColumn = true;
	}
}
