using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogApproveModel
{
	public List<WorkLogItemViewModel> Items { get; set; }

	public WorkLogApproveGroupType GroupType { get; set; }

	public bool IsConfirm { get; set; }

	public FilterModel DataFilter { get; set; }

	public WorkLogApproveModel()
	{
		Items = new List<WorkLogItemViewModel>();
		GroupType = WorkLogApproveGroupType.User;
	}
}
