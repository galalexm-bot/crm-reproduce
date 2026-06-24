using System.Collections.Generic;

namespace EleWise.ELMA.Security.Cryptography;

public interface IHmacService
{
	string GetNormalizedMessage(string verb, string resourceUri, string queryUri, Dictionary<string, string> headers, string contentType, byte[] requestBody);

	string Sign(string message, byte[] secret);

	byte[] Sign(byte[] message, byte[] secret);

	bool CheckSignature(string message, byte[] secret, string signature);
}
