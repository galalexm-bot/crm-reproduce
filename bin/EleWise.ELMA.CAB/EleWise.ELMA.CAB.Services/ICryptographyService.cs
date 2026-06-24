namespace EleWise.ELMA.CAB.Services;

public interface ICryptographyService
{
	byte[] EncryptSymmetric(byte[] plainText);

	byte[] DecryptSymmetric(byte[] cipherText);
}
