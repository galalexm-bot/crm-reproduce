using System;
using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogsOfWeek
{
	public int WeekNumber { get; set; }

	public DateTime StartDate { get; set; }

	public DateTime EndDate { get; set; }

	public WorkTime? FactWorkTime { get; set; }
}
