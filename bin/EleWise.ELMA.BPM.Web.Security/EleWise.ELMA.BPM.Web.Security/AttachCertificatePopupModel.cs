using System;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class AttachCertificatePopupModel
{
	public string PopupId { get; set; }

	public string CbAttachToAllActionsId { get; set; }

	public string CbIsDefaultId { get; set; }

	public string AttachCertificateFunc { get; set; }

	public string SuccessCallback { get; set; }

	public IUser User { get; set; }

	public Guid CryptoActionUid { get; set; }

	public ICryptoProviderWebBase Provider { get; set; }
}
