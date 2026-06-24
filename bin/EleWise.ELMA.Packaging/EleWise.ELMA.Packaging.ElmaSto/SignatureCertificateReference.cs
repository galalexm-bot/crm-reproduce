using System.Security.Cryptography.X509Certificates;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class SignatureCertificateReference
{
	public X509Certificate2 ComponentCertificate { get; set; }

	public X509Certificate2 StoreCertificate { get; set; }
}
