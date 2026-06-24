using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class SchedulerViewModel
{
	public Dictionary<string, List<SchedulerJobInfoViewModel>> Items { get; set; }

	public SchedulerViewModel()
	{
		Items = new Dictionary<string, List<SchedulerJobInfoViewModel>>();
	}
}
