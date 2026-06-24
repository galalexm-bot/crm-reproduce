using System;
using System.IO;
using System.Security.Cryptography;

namespace EleWise.ELMA.Packaging;

public static class CryptographyExtensions
{
	private static readonly byte[] PubKey = new byte[16]
	{
		9, 7, 3, 13, 5, 2, 10, 12, 15, 8,
		1, 6, 4, 16, 11, 14
	};

	private static readonly byte[] Iv = new byte[16]
	{
		3, 16, 4, 11, 8, 12, 2, 6, 15, 1,
		10, 7, 13, 5, 9, 14
	};

	public static string EncryptPassword(this string pwd)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(PubKey, Iv), CryptoStreamMode.Write);
		StreamWriter streamWriter = new StreamWriter(cryptoStream);
		streamWriter.WriteLine(pwd);
		streamWriter.Close();
		cryptoStream.Close();
		byte[] inArray = memoryStream.ToArray();
		memoryStream.Close();
		return Convert.ToBase64String(inArray);
	}

	public static string DecryptPassword(this string pwd)
	{
		byte[] buffer = Convert.FromBase64String(pwd);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MemoryStream memoryStream = new MemoryStream(buffer);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(PubKey, Iv), CryptoStreamMode.Read);
		StreamReader streamReader = new StreamReader(cryptoStream);
		string result = streamReader.ReadLine();
		streamReader.Close();
		cryptoStream.Close();
		memoryStream.Close();
		return result;
	}
}
