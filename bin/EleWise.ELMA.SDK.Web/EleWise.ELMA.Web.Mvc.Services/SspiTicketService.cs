using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Text;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Web.Mvc.Services;

public static class SspiTicketService
{
	public static string CreateSspiTicket(TicketRequest ticketRequest)
	{
		string text = ticketRequest.IdentityName.Substring(ticketRequest.IdentityName.IndexOf('\\') + 1);
		string text2 = ticketRequest.CreateTime.ToString("dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
		string text3 = $"{Guid.NewGuid().ToString()};{text};{ticketRequest.UserAgent};{ticketRequest.RemoteAddress};{text2};{ticketRequest.IdentityName}";
		byte[] key = Convert.FromBase64String(WindowsAuthenticationSettings.GetSecurityKey());
		byte[] iv = Convert.FromBase64String(WindowsAuthenticationSettings.GetSecurityVector());
		return EncryptTextAes256(text3, key, iv);
	}

	private static string EncryptTextAes256(string text, byte[] key, byte[] iv)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged
		{
			KeySize = 256,
			BlockSize = 256
		};
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream.AsNoClose(), rijndaelManaged.CreateEncryptor(key, iv), CryptoStreamMode.Write))
		{
			MemoryHelper.ActionWithMemoryBuffer<byte, (CryptoStream, string)>(EncodingCache.UTF8WithoutEmitIdentifier.GetByteCount(text), (cryptoStream, text), EncryptTextAes256WriteStreamAction);
			cryptoStream.FlushFinalBlock();
		}
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int)memoryStream.Length, memoryStream, EncryptTextAes256MemoryStreamToStringAction);
	}

	private static string EncryptTextAes256MemoryStreamToStringAction(byte[] buffer, int offset, int length, MemoryStream memoryStream)
	{
		memoryStream.Read(buffer, offset, length);
		return BitConverter.ToString(buffer, offset, length).Replace("-", string.Empty);
	}

	private static void EncryptTextAes256WriteStreamAction(byte[] buffer, int offset, int length, (CryptoStream, string) param)
	{
		var (cryptoStream, text) = param;
		EncodingCache.UTF8WithoutEmitIdentifier.GetBytes(text, 0, text.Length, buffer, offset);
		cryptoStream.Write(buffer, offset, length);
	}
}
