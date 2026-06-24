using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.Security.Extensions;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class LogOnModel
{
	public bool LoginOnlyByDefaultCertificate { get; set; }

	public string DefaultThumbprint { get; set; }

	public IAuthCryptoProviderWeb AuthCryptoProvider { get; set; }

	public IDigitalSignatureType DigitalSignatureType { get; set; }
}
