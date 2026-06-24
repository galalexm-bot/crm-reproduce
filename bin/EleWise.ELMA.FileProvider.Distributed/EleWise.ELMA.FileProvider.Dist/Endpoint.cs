using System.Security.Cryptography;
using EleWise.ELMA.FileProvider.Distributed.Configuration;
using EleWise.ELMA.Helpers;

namespace EleWise.ELMA.FileProvider.Distributed.Models;

internal class Endpoint
{
	private readonly string keyFilePath;

	public string Name { get; private set; }

	public string Url { get; private set; }

	public RSAParameters PublicKey { get; private set; }

	public bool IsDefault { get; private set; }

	public bool DisableSecurity { get; private set; }

	public Endpoint(DistributedStorageSettings.FileGatewayElement configElement)
	{
		Name = configElement.Name;
		Url = configElement.EndpointUrl;
		keyFilePath = configElement.PublicKeyFilePath;
		PublicKey = EncryptionHelper.LoadRsaKeyFromFile(keyFilePath);
		IsDefault = configElement.IsDefault;
		DisableSecurity = false;
	}
}
