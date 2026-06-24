using System;

namespace EleWise.ELMA.KPI.Models.Performance;

public class PerformanceDiscipline
{
	public int TotalTasks { get; set; }

	public int WellDoneTasks { get; set; }

	public int ProtractedTasks { get; set; }

	public double ProcentWellDone { get; private set; }

	public DateTime ChangeDate { get; set; }

	public PerformanceDiscipline()
	{
	}

	public PerformanceDiscipline(int wellDoneTaskCount, int protractedTaskCount)
	{
		WellDoneTasks = wellDoneTaskCount;
		ProtractedTasks = protractedTaskCount;
		TotalTasks = ProtractedTasks + WellDoneTasks;
		ProcentWellDone = ((TotalTasks != 0) ? (100 * WellDoneTasks / TotalTasks) : 0);
		ChangeDate = DateTime.Now;
	}
}
