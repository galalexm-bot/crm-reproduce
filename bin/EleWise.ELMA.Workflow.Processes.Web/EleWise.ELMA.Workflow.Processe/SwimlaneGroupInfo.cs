using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class SwimlaneGroupInfo
{
	public List<SwimlaneInfo> SwimlanesInfo { get; set; }

	public string UniquePostfix { get; set; }

	public string ApplyFunctionName { get; set; }

	public bool NoAjaxRefresh { get; set; }

	public IProcessHeader Header { get; set; }

	public long? FilterId { get; set; }

	public SwimlaneGroupInfo()
	{
		SwimlanesInfo = new List<SwimlaneInfo>();
	}
}
