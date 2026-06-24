using System.Collections.Generic;
using EleWise.ELMA.Common.Components;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ServerRestartSettingsViewModel
{
	public ServerRestartSettings Settings { get; set; }

	public IEnumerable<ScheduledRestartViewModel> Restarts { get; set; }

	public IEnumerable<ScheduledRestartHistoryEntryViewModel> History { get; set; }

	public bool IsOwnPage { get; set; }
}
