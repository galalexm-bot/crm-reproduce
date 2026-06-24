using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class HarmonizatorSelectPopupModel
{
	public IUser User { get; set; }

	public string PopupId { get; set; }

	public string ScriptSelect { get; set; }

	public string ScriptParam { get; set; }
}
