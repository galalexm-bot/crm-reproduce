using Orchard.Utility.Extensions;

namespace Orchard.ContentManagement.MetaData.Models;

public class ContentPartFieldDefinition
{
	public const string DisplayNameKey = "DisplayName";

	public string Name { get; private set; }

	public string DisplayName
	{
		get
		{
			if (!Settings.ContainsKey("DisplayName"))
			{
				return Name.CamelFriendly();
			}
			return Settings["DisplayName"];
		}
		set
		{
			Settings["DisplayName"] = value;
		}
	}

	public ContentFieldDefinition FieldDefinition { get; private set; }

	public SettingsDictionary Settings { get; private set; }

	public ContentPartFieldDefinition(string name)
	{
		Name = name;
		FieldDefinition = new ContentFieldDefinition(null);
		Settings = new SettingsDictionary();
	}

	public ContentPartFieldDefinition(ContentFieldDefinition contentFieldDefinition, string name, SettingsDictionary settings)
	{
		Name = name;
		FieldDefinition = contentFieldDefinition;
		Settings = settings;
	}
}
