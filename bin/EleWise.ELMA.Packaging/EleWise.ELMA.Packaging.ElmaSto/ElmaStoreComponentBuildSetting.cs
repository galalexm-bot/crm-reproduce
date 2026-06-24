using System.Collections.Generic;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class ElmaStoreComponentBuildSettings
{
	public List<SignatureCertificateReference> SignatureCertificates { get; private set; }

	public ElmaStoreComponentBuildSettings()
	{
		SignatureCertificates = new List<SignatureCertificateReference>();
	}
}
