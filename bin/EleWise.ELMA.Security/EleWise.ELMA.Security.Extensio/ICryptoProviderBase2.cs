using EleWise.ELMA.Files;

namespace EleWise.ELMA.Security.Extensions;

public interface ICryptoProviderBase2 : ICryptoProviderBase
{
	string GetFileHash(BinaryFile file, string algorithm);
}
