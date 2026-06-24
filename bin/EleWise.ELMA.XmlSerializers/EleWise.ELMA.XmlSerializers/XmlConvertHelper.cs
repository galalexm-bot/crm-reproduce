using System;

namespace EleWise.ELMA.XmlSerializers;

internal static class XmlConvertHelper
{
	internal static readonly char[] WhitespaceChars = new char[4] { ' ', '\t', '\n', '\r' };

	internal static Uri ToUri(string s)
	{
		if (s != null && s.Length > 0)
		{
			s = TrimString(s);
			if (s.Length == 0 || s.IndexOf("##", StringComparison.Ordinal) != -1)
			{
				throw new FormatException(Res.GetString("XmlConvert_BadFormat", s, "Uri"));
			}
		}
		if (!Uri.TryCreate(s, UriKind.RelativeOrAbsolute, out var result))
		{
			throw new FormatException(Res.GetString("XmlConvert_BadFormat", s, "Uri"));
		}
		return result;
	}

	internal static string TrimString(string value)
	{
		return value.Trim(WhitespaceChars);
	}

	internal static string[] SplitString(string value)
	{
		return value.Split(WhitespaceChars, StringSplitOptions.RemoveEmptyEntries);
	}

	internal static string[] SplitString(string value, StringSplitOptions splitStringOptions)
	{
		return value.Split(WhitespaceChars, splitStringOptions);
	}
}
