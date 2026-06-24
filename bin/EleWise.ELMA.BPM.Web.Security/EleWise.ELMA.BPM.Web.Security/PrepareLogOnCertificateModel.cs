using System;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class PrepareLogOnCertificateModel
{
	public string RunLogOnFunc { get; set; }

	public string SuccessCallback { get; set; }

	public string ErrorCallback { get; set; }

	public Guid CryptoProviderUid { get; set; }
}
