using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Models.Crypto;

namespace EleWise.ELMA.Security.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ICryptoProviderBase
{
	Guid ProviderUid { get; }

	string DisplayName { get; }

	CryptoProviderSettingsBase Settings { get; }

	IVerifyResult Verify(byte[] originalData, byte[] signedData, bool verifySignatureOnly);

	string GetFileHash(BinaryFile file);
}
