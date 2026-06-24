using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class DeviceTokenGridModel
{
	public GridData<TrustedDeviceModel> GridData { get; set; }

	public string CookieToken { get; set; }

	public bool Editable { get; set; }

	public bool IsCurrentUser { get; set; }

	public IUser User { get; set; }

	public TrustedDeviceTicketInfo TicketInfo { get; set; }
}
