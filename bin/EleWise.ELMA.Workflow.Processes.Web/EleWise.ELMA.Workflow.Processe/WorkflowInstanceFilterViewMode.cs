using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class WorkflowInstanceFilterViewModel
{
	public FilterModel Filter { get; set; }

	public int SelectedTab { get; set; }

	public long InstanceCount { get; set; }

	public long TasksCount { get; set; }

	public CurrentInstancesInfo InstancesInfo { get; set; }

	public bool ExpandAdvacedSearch { get; set; }

	public bool HasProcessHeaderPermission { get; set; }

	public IProcessHeader GetProcessHeader()
	{
		if (Filter == null || Filter.Filter == null || !(Filter.Filter is IWorkflowInstanceFilter))
		{
			return null;
		}
		return ((IWorkflowInstanceFilter)Filter.Filter).ProcessHeader;
	}
}
