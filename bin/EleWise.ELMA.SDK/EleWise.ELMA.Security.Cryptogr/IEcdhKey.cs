namespace EleWise.ELMA.Security.Cryptography;

public interface IEcdhKey
{
	byte[] PublicKey { get; }

	byte[] SharedSecret { get; }
}
