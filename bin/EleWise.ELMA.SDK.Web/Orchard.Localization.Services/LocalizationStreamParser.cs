using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Orchard.Localization.Services;

public class LocalizationStreamParser : ILocalizationStreamParser, IDependency
{
	private static readonly Dictionary<char, char> _escapeTranslations = new Dictionary<char, char>
	{
		{ 'n', '\n' },
		{ 'r', '\r' },
		{ 't', '\t' }
	};

	public void ParseLocalizationStream(string text, IDictionary<string, string> translations, bool merge)
	{
		StringReader stringReader = new StringReader(text);
		List<string> list = new List<string>();
		string text2 = string.Empty;
		string text3;
		while ((text3 = stringReader.ReadLine()) != null)
		{
			if (text3.StartsWith("#:"))
			{
				list.Add(ParseScope(text3));
			}
			else if (text3.StartsWith("msgctxt"))
			{
				list.Add(ParseContext(text3));
			}
			else if (text3.StartsWith("msgid"))
			{
				text2 = ParseId(text3);
			}
			else
			{
				if (!text3.StartsWith("msgstr"))
				{
					continue;
				}
				string value = ParseTranslation(text3);
				if (!string.IsNullOrWhiteSpace(text2) && !string.IsNullOrWhiteSpace(value))
				{
					if (list.Count == 0)
					{
						list.Add(string.Empty);
					}
					foreach (string item in list)
					{
						string key = (item + "|" + text2).ToLowerInvariant();
						if (!translations.ContainsKey(key))
						{
							translations.Add(key, value);
						}
						else if (merge)
						{
							translations[key] = value;
						}
					}
				}
				text2 = string.Empty;
				list = new List<string>();
			}
		}
	}

	private static string Unescape(string str)
	{
		StringBuilder stringBuilder = null;
		bool flag = false;
		for (int i = 0; i < str.Length; i++)
		{
			char c = str[i];
			if (flag)
			{
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(str.Length);
					if (i > 1)
					{
						stringBuilder.Append(str.Substring(0, i - 1));
					}
				}
				if (_escapeTranslations.TryGetValue(c, out var value))
				{
					stringBuilder.Append(value);
				}
				else
				{
					stringBuilder.Append(c);
				}
				flag = false;
			}
			else if (c == '\\')
			{
				flag = true;
			}
			else
			{
				stringBuilder?.Append(c);
			}
		}
		if (stringBuilder != null)
		{
			return stringBuilder.ToString();
		}
		return str;
	}

	private static string TrimQuote(string str)
	{
		if (str.StartsWith("\"") && str.EndsWith("\""))
		{
			return str.Substring(1, str.Length - 2);
		}
		return str;
	}

	private static string ParseTranslation(string poLine)
	{
		return Unescape(TrimQuote(poLine.Substring(6).Trim()));
	}

	private static string ParseId(string poLine)
	{
		return Unescape(TrimQuote(poLine.Substring(5).Trim()));
	}

	private static string ParseScope(string poLine)
	{
		return Unescape(TrimQuote(poLine.Substring(2).Trim()));
	}

	private static string ParseContext(string poLine)
	{
		return Unescape(TrimQuote(poLine.Substring(7).Trim()));
	}
}
