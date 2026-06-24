using System;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class CertificateAuthenticationData
{
	public string ClientRandomText { get; set; }

	public string Signature { get; set; }

	public Guid CryptoProviderUid { get; set; }
}
