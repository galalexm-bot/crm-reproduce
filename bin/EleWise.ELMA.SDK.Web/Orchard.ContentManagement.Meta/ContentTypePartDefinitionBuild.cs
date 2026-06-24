using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.MetaData.Builders;

public abstract class ContentTypePartDefinitionBuilder
{
	protected readonly SettingsDictionary _settings;

	public string Name { get; private set; }

	public string TypeName { get; private set; }

	protected ContentTypePartDefinitionBuilder(ContentTypePartDefinition part)
	{
		Name = part.PartDefinition.Name;
		TypeName = ((part.ContentTypeDefinition != null) ? part.ContentTypeDefinition.Name : null);
		_settings = new SettingsDictionary(part.Settings.ToDictionary((KeyValuePair<string, string> kv) => kv.Key, (KeyValuePair<string, string> kv) => kv.Value));
	}

	public ContentTypePartDefinitionBuilder WithSetting(string name, string value)
	{
		_settings[name] = value;
		return this;
	}

	public abstract ContentTypePartDefinition Build();
}
