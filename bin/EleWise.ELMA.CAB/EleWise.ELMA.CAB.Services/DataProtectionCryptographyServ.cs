using System;
using System.Collections.Specialized;
using System.Security.Cryptography;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Services;

public class DataProtectionCryptographyService : ICryptographyService, IConfigurable
{
	private byte[] entropy;

	private DataProtectionScope scope = DataProtectionScope.CurrentUser;

	public void Configure(NameValueCollection settings)
	{
		Guard.ArgumentNotNull(settings, "settings");
		if (!string.IsNullOrEmpty(settings["Entropy"]))
		{
			entropy = Convert.FromBase64String(settings["Entropy"]);
		}
		if (!string.IsNullOrEmpty(settings["Scope"]))
		{
			scope = (DataProtectionScope)Enum.Parse(typeof(DataProtectionScope), settings["Scope"]);
		}
		settings.Clear();
	}

	public byte[] EncryptSymmetric(byte[] plainText)
	{
		return ProtectedData.Protect(plainText, entropy, scope);
	}

	public byte[] DecryptSymmetric(byte[] cipherText)
	{
		return ProtectedData.Unprotect(cipherText, entropy, scope);
	}
}
