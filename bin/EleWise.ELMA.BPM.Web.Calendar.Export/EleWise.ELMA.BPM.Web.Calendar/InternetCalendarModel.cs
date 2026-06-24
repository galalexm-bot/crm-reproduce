using System.Collections.Generic;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Calendar.Export.Models;

public class InternetCalendarModel : EntityModel<IInternetCalendar>
{
	public List<InternetCalPeriodModel> Periods { get; set; }

	public List<ISchedule> Schedules { get; set; }

	public long ScheduleId { get; set; }

	public InternetCalendarModel()
	{
		Periods = new List<InternetCalPeriodModel>();
		Schedules = new List<ISchedule>();
	}
}
