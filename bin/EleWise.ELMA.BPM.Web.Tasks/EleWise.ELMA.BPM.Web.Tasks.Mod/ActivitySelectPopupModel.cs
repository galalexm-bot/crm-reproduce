using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class ActivitySelectPopupModel
{
	public IWorkLogActivity Activity { get; set; }

	public string PopupId { get; set; }

	public string ScriptSelect { get; set; }

	public string ScriptParam { get; set; }
}
