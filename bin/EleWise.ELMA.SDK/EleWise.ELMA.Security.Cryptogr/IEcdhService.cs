namespace EleWise.ELMA.Security.Cryptography;

public interface IEcdhService
{
	IEcdhKey DeriveKeyMaterial(byte[] externalPublicKey);

	byte[] DotNetToUncompressed(byte[] publicKey);

	bool CheckFixPublicKey(byte[] publicKey, out byte[] normalizedPublicKey);
}
