using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using EleWise.ELMA.Extensions;
using Orchard.Localization;

namespace Orchard.Utility.Extensions;

public static class StringExtensions
{
	private static readonly char[] validSegmentChars = "/?#[]@\"^{}|`<>\t\r\n\f ".ToCharArray();

	public static string CamelFriendly(this string camel)
	{
		if (string.IsNullOrWhiteSpace(camel))
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder(camel);
		for (int num = camel.Length - 1; num > 0; num--)
		{
			if (char.IsUpper(stringBuilder[num]))
			{
				stringBuilder.Insert(num, ' ');
			}
		}
		return stringBuilder.ToString();
	}

	public static string Ellipsize(this string text, int characterCount)
	{
		return text.Ellipsize(characterCount, "\u00a0…");
	}

	public static string Ellipsize(this string text, int characterCount, string ellipsis, bool wordBoundary = false)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return "";
		}
		if (characterCount < 0 || text.Length <= characterCount)
		{
			return text;
		}
		int num = characterCount;
		while (characterCount > 0 && text[characterCount - 1].IsLetter())
		{
			characterCount--;
		}
		while (characterCount > 0 && text[characterCount - 1].IsSpace())
		{
			characterCount--;
		}
		if (characterCount == 0 && !wordBoundary)
		{
			characterCount = num;
		}
		return text.Substring(0, characterCount) + ellipsis;
	}

	public static string HtmlClassify(this string text)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return "";
		}
		string text2 = text.CamelFriendly();
		char[] array = new char[text2.Length];
		int num = 0;
		bool flag = false;
		for (int i = 0; i < text2.Length; i++)
		{
			char c = text2[i];
			if (c.IsLetter() || (char.IsDigit(c) && num > 0))
			{
				if (flag && i != 0 && num > 0)
				{
					array[num++] = '-';
				}
				array[num++] = char.ToLowerInvariant(c);
				flag = false;
			}
			else
			{
				flag = true;
			}
		}
		return new string(array, 0, num);
	}

	public static LocalizedString OrDefault(this string text, LocalizedString defaultValue)
	{
		if (!string.IsNullOrEmpty(text))
		{
			return new LocalizedString(text);
		}
		return defaultValue;
	}

	public static string RemoveTags(this string html, bool htmlDecode = false)
	{
		if (string.IsNullOrEmpty(html))
		{
			return string.Empty;
		}
		char[] array = new char[html.Length];
		int length = 0;
		bool flag = false;
		foreach (char c in html)
		{
			switch (c)
			{
			case '<':
				flag = true;
				continue;
			case '>':
				flag = false;
				continue;
			}
			if (!flag)
			{
				array[length++] = c;
			}
		}
		string text = new string(array, 0, length);
		if (htmlDecode)
		{
			text = HttpUtility.HtmlDecode(text);
		}
		return text;
	}

	public static string ReplaceNewLinesWith(this string text, string replacement)
	{
		if (!string.IsNullOrWhiteSpace(text))
		{
			return text.Replace("\r\n", "\r\r").Replace("\n", string.Format(replacement, "\r\n")).Replace("\r\r", string.Format(replacement, "\r\n"));
		}
		return string.Empty;
	}

	public static string ToHexString(this byte[] bytes)
	{
		return BitConverter.ToString(bytes).Replace("-", "");
	}

	public static byte[] ToByteArray(this string hex)
	{
		return (from x in Enumerable.Range(0, hex.Length)
			where x % 2 == 0
			select Convert.ToByte(hex.Substring(x, 2), 16)).ToArray();
	}

	public static bool IsValidUrlSegment(this string segment)
	{
		return !segment.Any(validSegmentChars);
	}

	public static string ToSafeName(this string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return string.Empty;
		}
		name = name.RemoveDiacritics();
		name = name.Strip((char c) => !c.IsLetter() && !char.IsDigit(c));
		name = name.Trim();
		while (name.Length > 0 && !name[0].IsLetter())
		{
			name = name.Substring(1);
		}
		if (name.Length > 128)
		{
			name = name.Substring(0, 128);
		}
		return name;
	}

	public static string ToHtmlName(this string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return string.Empty;
		}
		name = name.RemoveDiacritics();
		name = name.Strip((char c) => c != '-' && c != '_' && !c.IsLetter() && !char.IsDigit(c));
		name = name.Trim();
		while (name.Length > 0 && !name[0].IsLetter())
		{
			name = name.Substring(1);
		}
		return name;
	}

	public static bool IsLetter(this char c)
	{
		if ('A' > c || c > 'Z')
		{
			if ('a' <= c)
			{
				return c <= 'z';
			}
			return false;
		}
		return true;
	}

	public static bool IsSpace(this char c)
	{
		if (c != '\r' && c != '\n' && c != '\t' && c != '\f')
		{
			return c == ' ';
		}
		return true;
	}

	public static string RemoveDiacritics(this string name)
	{
		string text = name.Normalize(NormalizationForm.FormD);
		StringBuilder stringBuilder = new StringBuilder();
		string text2 = text;
		foreach (char c in text2)
		{
			if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
	}

	public static string Strip(this string subject, params char[] stripped)
	{
		if (stripped == null || stripped.Length == 0 || string.IsNullOrEmpty(subject))
		{
			return subject;
		}
		char[] array = new char[subject.Length];
		int length = 0;
		foreach (char c in subject)
		{
			if (Array.IndexOf(stripped, c) < 0)
			{
				array[length++] = c;
			}
		}
		return new string(array, 0, length);
	}

	public static string Strip(this string subject, Func<char, bool> predicate)
	{
		char[] array = new char[subject.Length];
		int length = 0;
		foreach (char c in subject)
		{
			if (!predicate(c))
			{
				array[length++] = c;
			}
		}
		return new string(array, 0, length);
	}

	public static bool Any(this string subject, params char[] chars)
	{
		if (string.IsNullOrEmpty(subject) || chars == null || chars.Length == 0)
		{
			return false;
		}
		foreach (char value in subject)
		{
			if (Array.IndexOf(chars, value) >= 0)
			{
				return true;
			}
		}
		return false;
	}

	public static bool All(this string subject, params char[] chars)
	{
		if (string.IsNullOrEmpty(subject))
		{
			return true;
		}
		if (chars == null || chars.Length == 0)
		{
			return false;
		}
		foreach (char value in subject)
		{
			if (Array.IndexOf(chars, value) < 0)
			{
				return false;
			}
		}
		return true;
	}

	public static string Translate(this string subject, char[] from, char[] to)
	{
		if (string.IsNullOrEmpty(subject))
		{
			return subject;
		}
		if (from == null || to == null)
		{
			throw new ArgumentNullException();
		}
		if (from.Length != to.Length)
		{
			throw new ArgumentNullException("from", "Parameters must have the same length");
		}
		Dictionary<char, char> dictionary = new Dictionary<char, char>(from.Length);
		for (int i = 0; i < from.Length; i++)
		{
			dictionary[from[i]] = to[i];
		}
		char[] array = new char[subject.Length];
		for (int j = 0; j < subject.Length; j++)
		{
			char c = subject[j];
			if (dictionary.ContainsKey(c))
			{
				array[j] = dictionary[c];
			}
			else
			{
				array[j] = c;
			}
		}
		return new string(array);
	}

	public static string ReplaceAll(this string original, IDictionary<string, string> replacements)
	{
		string pattern = string.Format("{0}", string.Join("|", replacements.Keys));
		return Regex.Replace(original, pattern, (Match match) => replacements[match.Value]);
	}

	public static string ToBase64(this string value)
	{
		return value.ToBase64String();
	}

	public static string FromBase64(this string value)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(value));
	}
}
