using System;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class SchedulerHistoryViewModel
{
	public string Title { get; set; }

	public Guid? TriggerId { get; set; }

	public Guid? JobId { get; set; }
}
