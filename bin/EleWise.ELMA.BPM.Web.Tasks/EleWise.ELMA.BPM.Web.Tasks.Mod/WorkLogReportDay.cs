using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogReportDay
{
	public int DayOfWeek { get; set; }

	public List<WorkLogReportItem> Items { get; set; }

	public WorkLogReportDay()
	{
		Items = new List<WorkLogReportItem>();
	}
}
