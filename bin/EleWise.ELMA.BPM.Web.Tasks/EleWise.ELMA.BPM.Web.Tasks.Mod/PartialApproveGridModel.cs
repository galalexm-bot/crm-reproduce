using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class PartialApproveGridModel
{
	public GridDataFilter<IWorkLogItem> GridData { get; set; }

	public bool ShowDisplayName { get; set; }

	public string[] Ids { get; set; }

	public string[] WorkTime { get; set; }

	public string PartialIds { get; set; }

	public string PopupId { get; set; }

	public string GridId { get; set; }
}
