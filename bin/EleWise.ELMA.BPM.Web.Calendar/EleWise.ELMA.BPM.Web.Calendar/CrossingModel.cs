using System;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class CrossingModel
{
	public long? CurrentId { get; set; }

	public Guid? CurrentTypeUid { get; set; }

	public string StartDate { get; set; }

	public string EndDate { get; set; }

	public long[] UserIds { get; set; }

	public long[] ScheduleIds { get; set; }

	public string SubmitForm { get; set; }

	public string PopupId { get; set; }

	public string OnSubmitScript { get; set; }

	public string SubmitScript { get; set; }
}
