using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ScheduledRestartHistoryEntryViewModel
{
	public Guid Id { get; set; }

	public string Reason { get; set; }

	public DateTime RestartDate { get; set; }

	public DateTime CreationDate { get; set; }

	public IUser Author { get; set; }

	public ScheduledRestartResult Result { get; set; }

	public string Information { get; set; }
}
