using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogApproveItemModel
{
	public List<long> Id { get; set; }

	public List<long> WorkTime { get; set; }

	public List<int> PartialApproveIndex { get; set; }

	public FilterModel DataFilter { get; set; }

	public bool IsConfirm { get; set; }

	public WorkLogApproveItemModel()
	{
		Id = new List<long>();
		WorkTime = new List<long>();
		PartialApproveIndex = new List<int>();
	}
}
