namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public enum StoreComponentSignatureStatus
{
	Success,
	WrongCertificates,
	WrongManifestSignature,
	WrongContentSignature
}
