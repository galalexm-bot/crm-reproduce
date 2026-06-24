using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.Extensions;

public static class StringExtensions
{
	private static readonly Dictionary<string, string> translitChars;

	public static bool IsNullOrEmpty(this string s)
	{
		return string.IsNullOrEmpty(s);
	}

	public static bool IsNullOrWhiteSpace(this string s)
	{
		return string.IsNullOrWhiteSpace(s);
	}

	public static string ToTranslitIdent(this string s, string prefix = null, int maxLength = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		char[] array = s.ToCharArray();
		bool flag = true;
		if (!string.IsNullOrEmpty(prefix))
		{
			val.Append(prefix);
			flag = false;
		}
		bool flag2 = true;
		char[] array2 = array;
		string text3 = default(string);
		for (int i = 0; i < array2.Length; i++)
		{
			char c = array2[i];
			string text = c.ToString().ToLower();
			string text2 = null;
			bool flag3 = c >= '0' && c <= '9';
			if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '_' || flag3)
			{
				text2 = ((flag && flag3) ? "_" : "") + c;
			}
			else if (translitChars.TryGetValue(text, ref text3))
			{
				text2 = text3;
				if (!flag2)
				{
					flag2 = text.ToUpper().Equals(c.ToString());
				}
			}
			else
			{
				flag2 = true;
			}
			if (text2 != null)
			{
				if (maxLength > 0 && val.get_Length() + text2.get_Length() > maxLength)
				{
					break;
				}
				if (flag2 && text2.get_Length() > 0)
				{
					text2 = text2.get_Chars(0).ToString().ToUpper() + ((text2.get_Length() > 1) ? text2.Substring(1) : "");
				}
				val.Append(text2);
				flag = false;
				flag2 = false;
			}
		}
		return ((object)val).ToString();
	}

	public static string ToLowerFirstChar(this string s)
	{
		if (s.IsNullOrEmpty())
		{
			return "";
		}
		return char.ToLower(s.get_Chars(0)) + s.Substring(1);
	}

	public static string ToTranslit(this string s)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (s.IsNullOrEmpty())
		{
			return s;
		}
		Enumerator<string, string> enumerator = translitChars.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, string> current = enumerator.get_Current();
				s = s.Replace(current.get_Key(), current.get_Value());
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (s.get_Chars(0) >= '0' && s.get_Chars(0) <= '9')
		{
			s = s.Insert(0, "_");
		}
		return s.Replace(" ", "");
	}

	public static bool IsValidIdentifier(this string s)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return new Regex("^[_A-Za-z][_A-Za-z0-9]*$").IsMatch(s);
	}

	public static string ToHexString(this byte[] bytes)
	{
		return BitConverter.ToString(bytes).Replace("-", "");
	}

	public static string ValueOrDefault(this string value, string defaultValue, string format = "{0}")
	{
		if (!value.IsNullOrEmpty())
		{
			return format.FormatWith(new object[1] { value });
		}
		return defaultValue;
	}

	public static string ValueOrDefaultWhiteSpace(this string value, string defaultValue, string format = "{0}")
	{
		if (!value.IsNullOrWhiteSpace())
		{
			return format.FormatWith(new object[1] { value });
		}
		return defaultValue;
	}

	public static string Trunk(this string s, int length, string suffix)
	{
		if (s == null)
		{
			return "";
		}
		if (s.get_Length() > length)
		{
			return s.Substring(0, length) + suffix;
		}
		return s;
	}

	public static string Base64StringToValidFileName(this string s)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		return s.Replace('/', '#');
	}

	public static string Base64StringFromValidFileName(this string s)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		return s.Replace('#', '/');
	}

	public static string FormatWith(this string format, params object[] args)
	{
		return string.Format(format, args);
	}

	public static string FormatWith(this string format, IFormatProvider provider, params object[] args)
	{
		return string.Format(provider, format, args);
	}

	public static bool IsNullOrEmpty(this string str, bool ignoreWhiteSpace)
	{
		return string.IsNullOrEmpty(ignoreWhiteSpace ? str.Trim() : str);
	}

	public static string Repeat(this string stringToRepeat, int repetitionsCount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		for (int i = 0; i < repetitionsCount; i++)
		{
			val.Append(stringToRepeat);
		}
		return ((object)val).ToString();
	}

	public static string Capitalized(this string s)
	{
		if (s.IsNullOrEmpty())
		{
			return "";
		}
		return char.ToUpper(s.get_Chars(0)) + s.Substring(1);
	}

	static StringExtensions()
	{
		translitChars = new Dictionary<string, string>();
		translitChars.set_Item("а", "a");
		translitChars.set_Item("б", "b");
		translitChars.set_Item("в", "v");
		translitChars.set_Item("г", "g");
		translitChars.set_Item("д", "d");
		translitChars.set_Item("е", "e");
		translitChars.set_Item("ё", "yo");
		translitChars.set_Item("ж", "zh");
		translitChars.set_Item("з", "z");
		translitChars.set_Item("и", "i");
		translitChars.set_Item("й", "y");
		translitChars.set_Item("к", "k");
		translitChars.set_Item("л", "l");
		translitChars.set_Item("м", "m");
		translitChars.set_Item("н", "n");
		translitChars.set_Item("о", "o");
		translitChars.set_Item("п", "p");
		translitChars.set_Item("р", "r");
		translitChars.set_Item("с", "s");
		translitChars.set_Item("т", "t");
		translitChars.set_Item("у", "u");
		translitChars.set_Item("ф", "f");
		translitChars.set_Item("х", "h");
		translitChars.set_Item("ц", "c");
		translitChars.set_Item("ч", "ch");
		translitChars.set_Item("ш", "sh");
		translitChars.set_Item("щ", "sch");
		translitChars.set_Item("ъ", "j");
		translitChars.set_Item("ы", "y");
		translitChars.set_Item("ь", "j");
		translitChars.set_Item("э", "e");
		translitChars.set_Item("ю", "yu");
		translitChars.set_Item("я", "ya");
		translitChars.set_Item("A", "A");
		translitChars.set_Item("Б", "B");
		translitChars.set_Item("В", "V");
		translitChars.set_Item("Г", "G");
		translitChars.set_Item("Д", "D");
		translitChars.set_Item("Е", "E");
		translitChars.set_Item("Ё", "Yo");
		translitChars.set_Item("Ж", "Zh");
		translitChars.set_Item("З", "Z");
		translitChars.set_Item("И", "I");
		translitChars.set_Item("Й", "Y");
		translitChars.set_Item("К", "K");
		translitChars.set_Item("Л", "L");
		translitChars.set_Item("М", "M");
		translitChars.set_Item("Н", "N");
		translitChars.set_Item("О", "O");
		translitChars.set_Item("П", "P");
		translitChars.set_Item("Р", "R");
		translitChars.set_Item("С", "S");
		translitChars.set_Item("Т", "T");
		translitChars.set_Item("У", "U");
		translitChars.set_Item("Ф", "F");
		translitChars.set_Item("Х", "H");
		translitChars.set_Item("Ц", "C");
		translitChars.set_Item("Ч", "Ch");
		translitChars.set_Item("Ш", "Sh");
		translitChars.set_Item("Щ", "Sch");
		translitChars.set_Item("Ъ", "J");
		translitChars.set_Item("Ы", "Y");
		translitChars.set_Item("Ь", "J");
		translitChars.set_Item("Э", "E");
		translitChars.set_Item("Ю", "Yu");
		translitChars.set_Item("Я", "Ya");
	}
}
