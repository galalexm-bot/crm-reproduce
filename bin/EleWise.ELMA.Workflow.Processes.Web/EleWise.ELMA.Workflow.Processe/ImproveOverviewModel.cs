using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class ImproveOverviewModel
{
	public List<ProcessHeaderInfo> OwnerHeaderInfos { get; set; }

	public List<ProcessHeaderInfo> CuratorHeaderInfos { get; set; }

	public ImproveOverviewModel()
	{
		OwnerHeaderInfos = new List<ProcessHeaderInfo>();
		CuratorHeaderInfos = new List<ProcessHeaderInfo>();
	}
}
