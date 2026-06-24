using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class HarmonizatorInfoModel
{
	public string ScriptCallBack { get; set; }

	public string PrefixId { get; set; }

	public IUser User { get; set; }
}
