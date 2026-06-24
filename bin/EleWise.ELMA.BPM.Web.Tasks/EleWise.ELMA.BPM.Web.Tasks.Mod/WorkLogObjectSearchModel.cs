using System;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogObjectSearchModel : FormViewModel
{
	public WorkLogObjectSearchTabActive ActiveTab { get; set; }

	public string ScriptParameters { get; set; }

	public string PopupId { get; set; }

	public string ScriptSelect { get; set; }

	public DateTime CurrentDate { get; set; }

	public DateTime DateTo { get; set; }

	public DateTime DateFrom { get; set; }

	public WorkLogObjectSearchType SearchType { get; set; }

	public bool CanCreateTask { get; set; }
}
