using System.Security.Cryptography.X509Certificates;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class StoreComponentVerifiedSignature : StoreComponentSignatureInfo
{
	private readonly StoreComponentSignatureStatus _status;

	private readonly int _index;

	public StoreComponentSignatureStatus Status => _status;

	public int Index => _index;

	public StoreComponentVerifiedSignature(X509Certificate2 componentCertificate, X509Certificate2 storeCertificate, byte[] componentSignature, byte[] manifestSignature, StoreComponentSignatureStatus status, int index)
		: base(componentCertificate, storeCertificate, componentSignature, manifestSignature)
	{
		_status = status;
		_index = index;
	}
}
