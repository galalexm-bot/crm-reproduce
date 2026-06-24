using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class TrustedDeviceTicketInfo
{
	public TrustedDeviceType Type { get; set; }

	public string Value { get; set; }

	public TrustedDeviceTicketInfo(TrustedDeviceType type, string value)
	{
		Type = type;
		Value = value;
	}
}
