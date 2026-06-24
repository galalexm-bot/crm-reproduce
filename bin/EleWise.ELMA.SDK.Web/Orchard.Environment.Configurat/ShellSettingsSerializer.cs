using System;
using System.IO;
using System.Text;

namespace Orchard.Environment.Configuration;

public class ShellSettingsSerializer
{
	public const char Separator = ':';

	public const string EmptyValue = "null";

	public const char ThemesSeparator = ';';

	public static ShellSettings ParseSettings(string text)
	{
		ShellSettings shellSettings = new ShellSettings();
		if (string.IsNullOrEmpty(text))
		{
			return shellSettings;
		}
		StringReader stringReader = new StringReader(text);
		string text2;
		while ((text2 = stringReader.ReadLine()) != null)
		{
			if (string.IsNullOrWhiteSpace(text2))
			{
				continue;
			}
			int num = text2.IndexOf(':');
			if (num == -1)
			{
				continue;
			}
			string text3 = text2.Substring(0, num).Trim();
			string text4 = text2.Substring(num + 1).Trim();
			if (!text4.Equals("null", StringComparison.OrdinalIgnoreCase))
			{
				switch (text3)
				{
				case "Name":
					shellSettings.Name = text4;
					break;
				case "DataProvider":
					shellSettings.DataProvider = text4;
					break;
				case "State":
				{
					shellSettings.State = (Enum.TryParse<TenantState>(text4, ignoreCase: true, out var result) ? result : TenantState.Uninitialized);
					break;
				}
				case "DataConnectionString":
					shellSettings.DataConnectionString = text4;
					break;
				case "DataPrefix":
					shellSettings.DataTablePrefix = text4;
					break;
				case "RequestUrlHost":
					shellSettings.RequestUrlHost = text4;
					break;
				case "RequestUrlPrefix":
					shellSettings.RequestUrlPrefix = text4;
					break;
				case "EncryptionAlgorithm":
					shellSettings.EncryptionAlgorithm = text4;
					break;
				case "EncryptionKey":
					shellSettings.EncryptionKey = text4;
					break;
				case "HashAlgorithm":
					shellSettings.HashAlgorithm = text4;
					break;
				case "HashKey":
					shellSettings.HashKey = text4;
					break;
				case "Themes":
					shellSettings.Themes = text4.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
					break;
				case "Modules":
					shellSettings.Modules = text4.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
					break;
				default:
					shellSettings[text3] = text4;
					break;
				}
			}
		}
		return shellSettings;
	}

	public static string ComposeSettings(ShellSettings settings)
	{
		if (settings == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string key in settings.Keys)
		{
			stringBuilder.AppendLine(key + ": " + (settings[key] ?? "null"));
		}
		return stringBuilder.ToString();
	}
}
