namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public enum StoreComponentUnpackStatus
{
	Unsigned = -1,
	Success,
	WrongSignatures,
	ActivationError,
	FreeSigned
}
