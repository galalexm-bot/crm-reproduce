using System.Collections.Generic;
using Orchard.ContentManagement.Drivers;

namespace Orchard.ContentManagement.MetaData.Builders;

public static class ContentPartDefinitionBuilderExtensions
{
	public static IEnumerable<KeyValuePair<string, string>> GetSettingEntries(IDictionary<string, ContentLocation> locationSettings)
	{
		int entryIndex = 0;
		foreach (KeyValuePair<string, ContentLocation> locationSetting in locationSettings)
		{
			string zone = (string.IsNullOrEmpty(locationSetting.Value.Zone) ? null : locationSetting.Value.Zone);
			string position2 = (string.IsNullOrEmpty(locationSetting.Value.Position) ? null : locationSetting.Value.Position);
			string text = ((zone == null && position2 == null) ? null : locationSetting.Key);
			if (text != null)
			{
				string prefix = $"LocationSettings[{entryIndex}]";
				yield return new KeyValuePair<string, string>($"{prefix}.Key", text);
				yield return new KeyValuePair<string, string>($"{prefix}.Value.Zone", zone);
				yield return new KeyValuePair<string, string>($"{prefix}.Value.Position", position2);
				entryIndex++;
			}
		}
		for (int i = entryIndex; i < locationSettings.Count; i++)
		{
			string position2 = $"LocationSettings[{i}]";
			yield return new KeyValuePair<string, string>($"{position2}.Key", null);
			yield return new KeyValuePair<string, string>($"{position2}.Value.Zone", null);
			yield return new KeyValuePair<string, string>($"{position2}.Value.Position", null);
		}
	}

	public static ContentPartDefinitionBuilder WithLocation(this ContentPartDefinitionBuilder obj, IDictionary<string, ContentLocation> settings)
	{
		foreach (KeyValuePair<string, string> settingEntry in GetSettingEntries(settings))
		{
			obj = obj.WithSetting(settingEntry.Key, settingEntry.Value);
		}
		return obj;
	}

	public static ContentTypePartDefinitionBuilder WithLocation(this ContentTypePartDefinitionBuilder obj, IDictionary<string, ContentLocation> settings)
	{
		foreach (KeyValuePair<string, string> settingEntry in GetSettingEntries(settings))
		{
			obj = obj.WithSetting(settingEntry.Key, settingEntry.Value);
		}
		return obj;
	}

	public static ContentPartFieldDefinitionBuilder WithLocation(this ContentPartFieldDefinitionBuilder obj, IDictionary<string, ContentLocation> settings)
	{
		foreach (KeyValuePair<string, string> settingEntry in GetSettingEntries(settings))
		{
			obj = obj.WithSetting(settingEntry.Key, settingEntry.Value);
		}
		return obj;
	}
}
