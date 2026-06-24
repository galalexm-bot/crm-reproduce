using System.Collections.Generic;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class StatesInfo
{
	public List<StatusInfo> States { get; set; }

	public string UniquePostfix { get; set; }

	public string ApplyFunctionName { get; set; }

	public Filter Filter { get; set; }

	public bool NoAjaxRefresh { get; set; }

	public IProcessHeader Header { get; set; }

	public long? FilterId { get; set; }
}
