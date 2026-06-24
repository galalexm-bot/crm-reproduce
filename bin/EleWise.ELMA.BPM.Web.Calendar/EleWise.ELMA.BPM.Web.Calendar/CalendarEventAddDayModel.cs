using System;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class CalendarEventAddDayModel : FormViewModel
{
	public long EntityId { get; set; }

	public Guid EntityTypeUid { get; set; }

	public DateTime StartDate { get; set; }

	public DateTime EndDate { get; set; }

	public string Comment { get; set; }

	public string PopupId { get; set; }

	public bool UseDates { get; set; }
}
