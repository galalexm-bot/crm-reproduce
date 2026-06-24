using System;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class PrepareLogOnCertificateModelExt : PrepareLogOnCertificateModel
{
	public Guid DigitalSignatureTypeUid { get; set; }
}
