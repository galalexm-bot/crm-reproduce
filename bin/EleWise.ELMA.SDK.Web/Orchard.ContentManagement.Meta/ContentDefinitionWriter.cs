using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Orchard.ContentManagement.MetaData.Models;
using Orchard.Validation;

namespace Orchard.ContentManagement.MetaData.Services;

public class ContentDefinitionWriter : IContentDefinitionWriter, IDependency
{
	private readonly ISettingsFormatter _settingsFormatter;

	public ContentDefinitionWriter(ISettingsFormatter settingsFormatter)
	{
		Argument.ThrowIfNull(settingsFormatter, "settingsFormatter");
		_settingsFormatter = settingsFormatter;
	}

	public XElement Export(ContentTypeDefinition contentTypeDefinition)
	{
		Argument.ThrowIfNull(contentTypeDefinition, "typeDefinition");
		XElement xElement = NewElement(contentTypeDefinition.Name, contentTypeDefinition.Settings);
		if (xElement.Attribute("DisplayName") == null && contentTypeDefinition.DisplayName != null)
		{
			xElement.Add(new XAttribute("DisplayName", contentTypeDefinition.DisplayName));
		}
		foreach (ContentTypePartDefinition item in contentTypeDefinition.Parts.OrderBy((ContentTypePartDefinition x) => x.PartDefinition.Name))
		{
			xElement.Add(NewElement(item.PartDefinition.Name, item.Settings));
		}
		return xElement;
	}

	public XElement Export(ContentPartDefinition contentPartDefinition)
	{
		Argument.ThrowIfNull(contentPartDefinition, "contentPartDefinition");
		XElement xElement = NewElement(contentPartDefinition.Name, contentPartDefinition.Settings);
		foreach (ContentPartFieldDefinition item in contentPartDefinition.Fields.OrderBy((ContentPartFieldDefinition x) => x.Name))
		{
			string name = $"{item.Name}.{item.FieldDefinition.Name}";
			XElement content = NewElement(name, item.Settings);
			xElement.Add(content);
		}
		return xElement;
	}

	private XElement NewElement(string name, SettingsDictionary settings)
	{
		XElement xElement = _settingsFormatter.Map(settings);
		xElement.Name = XmlConvert.EncodeLocalName(name);
		return xElement;
	}
}
