using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.MetaData.Builders;

public abstract class ContentPartFieldDefinitionBuilder
{
	protected readonly SettingsDictionary _settings;

	public ContentPartFieldDefinition Current { get; private set; }

	public abstract string Name { get; }

	public abstract string FieldType { get; }

	public abstract string PartName { get; }

	protected ContentPartFieldDefinitionBuilder(ContentPartFieldDefinition field)
	{
		Current = field;
		_settings = new SettingsDictionary(field.Settings.ToDictionary((KeyValuePair<string, string> kv) => kv.Key, (KeyValuePair<string, string> kv) => kv.Value));
	}

	public ContentPartFieldDefinitionBuilder WithSetting(string name, string value)
	{
		_settings[name] = value;
		return this;
	}

	public ContentPartFieldDefinitionBuilder WithDisplayName(string displayName)
	{
		_settings["DisplayName"] = displayName;
		return this;
	}

	public abstract ContentPartFieldDefinitionBuilder OfType(ContentFieldDefinition fieldDefinition);

	public abstract ContentPartFieldDefinitionBuilder OfType(string fieldType);

	public abstract ContentPartFieldDefinition Build();
}
