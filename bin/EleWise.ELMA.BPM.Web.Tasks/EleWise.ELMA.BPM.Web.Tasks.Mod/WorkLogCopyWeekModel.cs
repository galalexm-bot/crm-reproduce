using System;
using System.Collections.Generic;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogCopyWeekModel
{
	public string PopupId { get; set; }

	public DateTime DayForWeek { get; set; }

	public int WeekPrevious { get; set; }

	public Dictionary<int, List<IWorkLogItem>> Items { get; set; }

	public DateTime DateStart { get; set; }

	public string Ids { get; set; }

	public List<WorkLogsOfWeek> WorkLogWeeks { get; internal set; }
}
