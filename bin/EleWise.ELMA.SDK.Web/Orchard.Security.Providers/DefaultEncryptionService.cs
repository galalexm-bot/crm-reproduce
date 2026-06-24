using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using EleWise.ELMA.Memory;
using Orchard.Environment.Configuration;
using Orchard.Utility.Extensions;

namespace Orchard.Security.Providers;

public class DefaultEncryptionService : IEncryptionService, ISingletonDependency, IDependency
{
	private readonly ShellSettings _shellSettings;

	public DefaultEncryptionService(ShellSettings shellSettings)
	{
		_shellSettings = shellSettings;
	}

	public byte[] Decode(byte[] encodedData)
	{
		using SymmetricAlgorithm symmetricAlgorithm = CreateSymmetricAlgorithm();
		using HMAC hMAC = CreateHashAlgorithm();
		byte[] array = new byte[symmetricAlgorithm.BlockSize / 8];
		byte[] array2 = new byte[hMAC.HashSize / 8];
		byte[] array3 = new byte[encodedData.Length - array.Length - array2.Length];
		Array.Copy(encodedData, 0, array, 0, array.Length);
		Array.Copy(encodedData, array.Length, array3, 0, array3.Length);
		Array.Copy(encodedData, array.Length + array3.Length, array2, 0, array2.Length);
		if (!hMAC.ComputeHash(array.Concat(array3).ToArray()).SequenceEqual(array2))
		{
			throw new ArgumentException();
		}
		symmetricAlgorithm.IV = array;
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream.AsNoClose(), symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(array3, 0, array3.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public byte[] Encode(byte[] data)
	{
		byte[] iV;
		byte[] second;
		using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream())
		{
			using SymmetricAlgorithm symmetricAlgorithm = CreateSymmetricAlgorithm();
			symmetricAlgorithm.GenerateIV();
			iV = symmetricAlgorithm.IV;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream.AsNoClose(), symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(data, 0, data.Length);
				cryptoStream.FlushFinalBlock();
			}
			second = memoryStream.ToArray();
		}
		byte[] second2;
		using (HMAC hMAC = CreateHashAlgorithm())
		{
			second2 = hMAC.ComputeHash(iV.Concat(second).ToArray());
		}
		return iV.Concat(second).Concat(second2).ToArray();
	}

	private SymmetricAlgorithm CreateSymmetricAlgorithm()
	{
		SymmetricAlgorithm symmetricAlgorithm = SymmetricAlgorithm.Create(_shellSettings.EncryptionAlgorithm);
		symmetricAlgorithm.Key = _shellSettings.EncryptionKey.ToByteArray();
		return symmetricAlgorithm;
	}

	private HMAC CreateHashAlgorithm()
	{
		HMAC hMAC = HMAC.Create(_shellSettings.HashAlgorithm);
		hMAC.Key = _shellSettings.HashKey.ToByteArray();
		return hMAC;
	}
}
