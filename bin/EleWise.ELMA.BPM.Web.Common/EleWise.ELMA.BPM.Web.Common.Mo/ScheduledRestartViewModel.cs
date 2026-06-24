using System;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ScheduledRestartViewModel
{
	public Guid Id { get; set; }

	public string Reason { get; set; }

	public DateTime RestartDate { get; set; }

	public DateTime CreationDate { get; set; }

	public IUser Author { get; set; }
}
