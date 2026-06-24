using System;
using EleWise.ELMA.Security.Managers;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class CertificateSelectorModel
{
	private string thumbprint;

	public string Name { get; set; }

	public string DefaultThumbprint
	{
		get
		{
			if (thumbprint != null || CryptoActionUid == Guid.Empty)
			{
				return thumbprint;
			}
			thumbprint = UserCertificateManager.Instance.GetCurrentUserDefaultCertificateThumbpint(CryptoActionUid);
			return thumbprint;
		}
		set
		{
			thumbprint = value;
		}
	}

	public string RunFillingFunc { get; set; }

	public string SuccessCallback { get; set; }

	public string ErrorCallback { get; set; }

	public string GetSelectedData { get; set; }

	public Guid CryptoActionUid { get; set; }

	public string GetHashAlgorithmFunc { get; set; }
}
