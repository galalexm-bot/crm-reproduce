using System;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogTypeSettingsViewModel : FormViewModel
{
	public WorkLogExtensionSettings Settings { get; set; }

	public Guid Uid { get; set; }

	public string PopupId { get; set; }
}
