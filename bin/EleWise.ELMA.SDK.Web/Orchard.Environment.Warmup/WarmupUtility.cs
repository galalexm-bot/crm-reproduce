using System;
using System.Text;

namespace Orchard.Environment.Warmup;

public static class WarmupUtility
{
	public static string EncodeUrl(string url)
	{
		if (string.IsNullOrWhiteSpace(url))
		{
			throw new ArgumentException("url can't be empty");
		}
		StringBuilder stringBuilder = new StringBuilder();
		string text = url.ToLowerInvariant();
		foreach (char c in text)
		{
			if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
			{
				stringBuilder.Append(c);
				continue;
			}
			stringBuilder.Append("_");
			byte[] bytes = Encoding.UTF8.GetBytes(new char[1] { c });
			foreach (byte b in bytes)
			{
				stringBuilder.Append(b.ToString("X"));
			}
		}
		return stringBuilder.ToString();
	}
}
