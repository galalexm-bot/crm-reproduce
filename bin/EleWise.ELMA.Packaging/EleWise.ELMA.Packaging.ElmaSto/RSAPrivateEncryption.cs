using System;
using System.Numerics;
using System.Security.Cryptography;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

internal static class RSAPrivateEncryption
{
	public static byte[] PublicDecryption(this RSACryptoServiceProvider rsa, byte[] cipherData)
	{
		if (cipherData == null)
		{
			throw new ArgumentNullException("cipherData");
		}
		BigInteger value = new BigInteger(cipherData);
		RSAParameters rSAParameters = rsa.ExportParameters(includePrivateParameters: false);
		BigInteger big = GetBig(rSAParameters.Exponent);
		BigInteger big2 = GetBig(rSAParameters.Modulus);
		byte[] array = BigInteger.ModPow(value, big, big2).ToByteArray();
		byte[] array2 = new byte[array.Length - 1];
		Array.Copy(array, array2, array2.Length);
		array2 = RemovePadding(array2);
		Array.Reverse(array2);
		return array2;
	}

	private static BigInteger GetBig(byte[] data)
	{
		byte[] array = (byte[])data.Clone();
		Array.Reverse(array);
		byte[] array2 = new byte[array.Length + 1];
		Array.Copy(array, array2, array.Length);
		return new BigInteger(array2);
	}

	private static byte[] RemovePadding(byte[] data)
	{
		byte[] array = new byte[data.Length - 4];
		Array.Copy(data, array, array.Length);
		return array;
	}
}
