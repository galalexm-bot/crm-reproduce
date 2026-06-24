using System;
using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class LogOnSecurityActionsModel
{
	public IUser User { get; set; }

	public string CurrentToken { get; set; }

	public bool TrustedLogonEnabled { get; set; }

	public bool AllowLoginByCertificate { get; set; }

	public bool AllowLoginByToken { get; set; }

	public bool IsCurrentUser { get; set; }

	public IAuthCryptoProviderWeb CryptoProvider { get; set; }

	public IEnumerable<IAuthCryptoProviderWeb> CryptoProviders { get; set; }

	public Guid SelectedCryptoProviderUid { get; set; }

	public Guid DefaultCryptoProviderUid { get; set; }

	public IEnumerable<IDigitalSignatureType> DigitalSignatureTypes { get; set; }

	public Guid SelectedDigitalSignatureTypeUid { get; set; }

	public Guid DefaultDigitalSignatureTypeUid { get; set; }
}
