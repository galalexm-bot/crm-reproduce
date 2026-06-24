using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class TrustedDevicesScriptModel
{
	public IUser User { get; set; }

	public string PopupId { get; set; }

	public string AddTrustedDeviceSubmitCallback { get; set; }

	public string RefreshGridFunc { get; set; }

	public string DeleteDeviceCallback { get; set; }
}
