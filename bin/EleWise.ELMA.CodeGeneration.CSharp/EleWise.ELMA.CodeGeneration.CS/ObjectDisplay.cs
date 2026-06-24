using System;
using System.Globalization;
using System.Reflection;
using System.Text;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;
using EleWise.ELMA.CodeGeneration.CSharp.Extensions;

namespace EleWise.ELMA.CodeGeneration.CSharp;

internal static class ObjectDisplay
{
	internal static string NullLiteral => "null";

	public static string FormatPrimitive(object obj, ObjectDisplayOptions options)
	{
		if (obj == null)
		{
			return NullLiteral;
		}
		Type type = obj.GetType();
		if (type.GetTypeInfo().IsEnum)
		{
			type = Enum.GetUnderlyingType(type);
		}
		if (type == typeof(int))
		{
			return FormatLiteral((int)obj, options);
		}
		if (type == typeof(string))
		{
			return FormatLiteral((string)obj, options);
		}
		if (type == typeof(bool))
		{
			return FormatLiteral((bool)obj);
		}
		if (type == typeof(char))
		{
			return FormatLiteral((char)obj, options);
		}
		if (type == typeof(byte))
		{
			return FormatLiteral((byte)obj, options);
		}
		if (type == typeof(short))
		{
			return FormatLiteral((short)obj, options);
		}
		if (type == typeof(long))
		{
			return FormatLiteral((long)obj, options);
		}
		if (type == typeof(double))
		{
			return FormatLiteral((double)obj, options);
		}
		if (type == typeof(ulong))
		{
			return FormatLiteral((ulong)obj, options);
		}
		if (type == typeof(uint))
		{
			return FormatLiteral((uint)obj, options);
		}
		if (type == typeof(ushort))
		{
			return FormatLiteral((ushort)obj, options);
		}
		if (type == typeof(sbyte))
		{
			return FormatLiteral((sbyte)obj, options);
		}
		if (type == typeof(float))
		{
			return FormatLiteral((float)obj, options);
		}
		if (type == typeof(decimal))
		{
			return FormatLiteral((decimal)obj, options);
		}
		return null;
	}

	internal static string FormatLiteral(bool value)
	{
		if (!value)
		{
			return "false";
		}
		return "true";
	}

	private static bool TryReplaceQuote(char c, char quote, out string replaceWith)
	{
		if (c == quote)
		{
			replaceWith = "\\" + c;
			return true;
		}
		replaceWith = null;
		return false;
	}

	private static bool TryReplaceChar(char c, out string replaceWith)
	{
		replaceWith = null;
		switch (c)
		{
		case '\\':
			replaceWith = "\\\\";
			break;
		case '\0':
			replaceWith = "\\0";
			break;
		case '\a':
			replaceWith = "\\a";
			break;
		case '\b':
			replaceWith = "\\b";
			break;
		case '\f':
			replaceWith = "\\f";
			break;
		case '\n':
			replaceWith = "\\n";
			break;
		case '\r':
			replaceWith = "\\r";
			break;
		case '\t':
			replaceWith = "\\t";
			break;
		case '\v':
			replaceWith = "\\v";
			break;
		}
		if (replaceWith != null)
		{
			return true;
		}
		UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
		if ((uint)(unicodeCategory - 12) <= 2u || unicodeCategory == UnicodeCategory.OtherNotAssigned)
		{
			int num = c;
			replaceWith = "\\u" + num.ToString("x4");
			return true;
		}
		return false;
	}

	public static string FormatLiteral(string value, ObjectDisplayOptions options)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = options.IncludesOption(ObjectDisplayOptions.UseQuotes);
		bool flag2 = options.IncludesOption(ObjectDisplayOptions.EscapeNonPrintableCharacters);
		bool flag3 = flag && !flag2 && ContainsNewLine(value);
		if (flag)
		{
			if (flag3)
			{
				stringBuilder.Append('@');
			}
			stringBuilder.Append('"');
		}
		foreach (char c in value)
		{
			if (flag2 && TryReplaceChar(c, out var replaceWith))
			{
				stringBuilder.Append(replaceWith);
			}
			else if (flag && c == '"')
			{
				if (flag3)
				{
					stringBuilder.Append('"');
					stringBuilder.Append('"');
				}
				else
				{
					stringBuilder.Append('\\');
					stringBuilder.Append('"');
				}
			}
			else
			{
				stringBuilder.Append(c);
			}
		}
		if (flag)
		{
			stringBuilder.Append('"');
		}
		return stringBuilder.ToString();
	}

	private static bool ContainsNewLine(string s)
	{
		foreach (char c in s)
		{
			if (c == '\r' || c == '\n' || c == '\u0085' || c == '\u2028' || c == '\u2029')
			{
				return true;
			}
		}
		return false;
	}

	internal static string FormatLiteral(char c, ObjectDisplayOptions options)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (options.IncludesOption(ObjectDisplayOptions.IncludeCodePoints))
		{
			string value;
			if (!options.IncludesOption(ObjectDisplayOptions.UseHexadecimalNumbers))
			{
				int num = c;
				value = num.ToString();
			}
			else
			{
				int num = c;
				value = "0x" + num.ToString("x4");
			}
			stringBuilder.Append(value);
			stringBuilder.Append(" ");
		}
		bool flag = options.IncludesOption(ObjectDisplayOptions.UseQuotes);
		bool flag2 = options.IncludesOption(ObjectDisplayOptions.EscapeNonPrintableCharacters);
		if (flag)
		{
			stringBuilder.Append('\'');
		}
		if (flag2 && TryReplaceChar(c, out var replaceWith))
		{
			stringBuilder.Append(replaceWith);
		}
		else if (flag && c == '\'')
		{
			stringBuilder.Append('\\');
			stringBuilder.Append('\'');
		}
		else
		{
			stringBuilder.Append(c);
		}
		if (flag)
		{
			stringBuilder.Append('\'');
		}
		return stringBuilder.ToString();
	}

	internal static string FormatLiteral(sbyte value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
	{
		if (options.IncludesOption(ObjectDisplayOptions.UseHexadecimalNumbers))
		{
			string text;
			if (value < 0)
			{
				int num = value;
				text = num.ToString("x8");
			}
			else
			{
				text = value.ToString("x2");
			}
			return "0x" + text;
		}
		return value.ToString(GetFormatCulture(cultureInfo));
	}

	internal static string FormatLiteral(byte value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
	{
		if (options.IncludesOption(ObjectDisplayOptions.UseHexadecimalNumbers))
		{
			return "0x" + value.ToString("x2");
		}
		return value.ToString(GetFormatCulture(cultureInfo));
	}

	internal static string FormatLiteral(short value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
	{
		if (options.IncludesOption(ObjectDisplayOptions.UseHexadecimalNumbers))
		{
			string text;
			if (value < 0)
			{
				int num = value;
				text = num.ToString("x8");
			}
			else
			{
				text = value.ToString("x4");
			}
			return "0x" + text;
		}
		return value.ToString(GetFormatCulture(cultureInfo));
	}

	internal static string FormatLiteral(ushort value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
	{
		if (options.IncludesOption(ObjectDisplayOptions.UseHexadecimalNumbers))
		{
			return "0x" + value.ToString("x4");
		}
		return value.ToString(GetFormatCulture(cultureInfo));
	}

	internal static string FormatLiteral(int value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
	{
		if (options.IncludesOption(ObjectDisplayOptions.UseHexadecimalNumbers))
		{
			return "0x" + value.ToString("x8");
		}
		return value.ToString(GetFormatCulture(cultureInfo));
	}

	internal static string FormatLiteral(uint value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (options.IncludesOption(ObjectDisplayOptions.UseHexadecimalNumbers))
		{
			stringBuilder.Append("0x");
			stringBuilder.Append(value.ToString("x8"));
		}
		else
		{
			stringBuilder.Append(value.ToString(GetFormatCulture(cultureInfo)));
		}
		if (options.IncludesOption(ObjectDisplayOptions.IncludeTypeSuffix))
		{
			stringBuilder.Append('U');
		}
		return stringBuilder.ToString();
	}

	internal static string FormatLiteral(long value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (options.IncludesOption(ObjectDisplayOptions.UseHexadecimalNumbers))
		{
			stringBuilder.Append("0x");
			stringBuilder.Append(value.ToString("x16"));
		}
		else
		{
			stringBuilder.Append(value.ToString(GetFormatCulture(cultureInfo)));
		}
		if (options.IncludesOption(ObjectDisplayOptions.IncludeTypeSuffix))
		{
			stringBuilder.Append('L');
		}
		return stringBuilder.ToString();
	}

	internal static string FormatLiteral(ulong value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (options.IncludesOption(ObjectDisplayOptions.UseHexadecimalNumbers))
		{
			stringBuilder.Append("0x");
			stringBuilder.Append(value.ToString("x16"));
		}
		else
		{
			stringBuilder.Append(value.ToString(GetFormatCulture(cultureInfo)));
		}
		if (options.IncludesOption(ObjectDisplayOptions.IncludeTypeSuffix))
		{
			stringBuilder.Append("UL");
		}
		return stringBuilder.ToString();
	}

	internal static string FormatLiteral(double value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
	{
		string text = value.ToString("R", GetFormatCulture(cultureInfo));
		if (!options.IncludesOption(ObjectDisplayOptions.IncludeTypeSuffix))
		{
			return text;
		}
		return text + "D";
	}

	internal static string FormatLiteral(float value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
	{
		string text = value.ToString("R", GetFormatCulture(cultureInfo));
		if (!options.IncludesOption(ObjectDisplayOptions.IncludeTypeSuffix))
		{
			return text;
		}
		return text + "F";
	}

	internal static string FormatLiteral(decimal value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
	{
		string text = value.ToString(GetFormatCulture(cultureInfo));
		if (!options.IncludesOption(ObjectDisplayOptions.IncludeTypeSuffix))
		{
			return text;
		}
		return text + "M";
	}

	private static CultureInfo GetFormatCulture(CultureInfo cultureInfo)
	{
		return cultureInfo ?? CultureInfo.InvariantCulture;
	}
}
