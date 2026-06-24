using System;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

[Serializable]
public class ScheduleState
{
	public string Id { get; set; }

	public ScheduleMode Mode { get; set; }

	public DateTime ViewDate { get; set; }

	public bool ListView { get; set; }

	public void SetDelta(int delta)
	{
		switch (Mode)
		{
		case ScheduleMode.WorkWeek:
		case ScheduleMode.Week:
			ViewDate = ViewDate.AddDays(delta * 7);
			break;
		case ScheduleMode.Month:
			ViewDate = ViewDate.AddMonths(delta);
			break;
		case ScheduleMode.ThreeDays:
			ViewDate = ViewDate.AddDays(delta * 3);
			break;
		default:
			ViewDate = ViewDate.AddDays(delta);
			break;
		}
	}

	public void SetMode(string mode)
	{
		switch (mode)
		{
		case "workWeek":
			Mode = ScheduleMode.WorkWeek;
			break;
		case "timeGridWeek":
			Mode = ScheduleMode.Week;
			break;
		case "dayGridMonth":
			Mode = ScheduleMode.Month;
			break;
		case "timeGridThreeDay":
			Mode = ScheduleMode.ThreeDays;
			break;
		default:
			Mode = ScheduleMode.Day;
			break;
		}
	}

	public string GetMode()
	{
		return Mode switch
		{
			ScheduleMode.WorkWeek => "workWeek", 
			ScheduleMode.Week => "timeGridWeek", 
			ScheduleMode.Month => "dayGridMonth", 
			ScheduleMode.ThreeDays => "timeGridThreeDay", 
			_ => "timeGridDay", 
		};
	}
}
