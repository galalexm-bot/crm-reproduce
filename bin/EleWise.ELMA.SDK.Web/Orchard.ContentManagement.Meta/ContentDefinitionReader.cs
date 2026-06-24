using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Validation;

namespace Orchard.ContentManagement.MetaData.Services;

public class ContentDefinitionReader : IContentDefinitionReader, IDependency
{
	private readonly ISettingsFormatter _settingsFormatter;

	public ContentDefinitionReader(ISettingsFormatter settingsFormatter)
	{
		Argument.ThrowIfNull(settingsFormatter, "settingsFormatter");
		_settingsFormatter = settingsFormatter;
	}

	public void Merge(XElement element, ContentTypeDefinitionBuilder contentTypeDefinitionBuilder)
	{
		Argument.ThrowIfNull(element, "element");
		Argument.ThrowIfNull(contentTypeDefinitionBuilder, "contentTypeDefinitionBuilder");
		contentTypeDefinitionBuilder.Named(XmlConvert.DecodeName(element.Name.LocalName));
		if (element.Attribute("DisplayName") != null)
		{
			contentTypeDefinitionBuilder.DisplayedAs(element.Attribute("DisplayName").Value);
		}
		foreach (KeyValuePair<string, string> item in _settingsFormatter.Map(element))
		{
			contentTypeDefinitionBuilder.WithSetting(item.Key, item.Value);
		}
		foreach (XElement item2 in element.Elements())
		{
			XElement partElement = item2;
			string text = XmlConvert.DecodeName(partElement.Name.LocalName);
			if (text == "remove")
			{
				XAttribute xAttribute = partElement.Attribute("name");
				if (xAttribute != null)
				{
					contentTypeDefinitionBuilder.RemovePart(xAttribute.Value);
				}
				continue;
			}
			contentTypeDefinitionBuilder.WithPart(text, delegate(ContentTypePartDefinitionBuilder partBuilder)
			{
				foreach (KeyValuePair<string, string> item3 in _settingsFormatter.Map(partElement))
				{
					partBuilder.WithSetting(item3.Key, item3.Value);
				}
			});
		}
	}

	public void Merge(XElement element, ContentPartDefinitionBuilder contentPartDefinitionBuilder)
	{
		Argument.ThrowIfNull(element, "element");
		Argument.ThrowIfNull(contentPartDefinitionBuilder, "contentPartDefinitionBuilder");
		contentPartDefinitionBuilder.Named(XmlConvert.DecodeName(element.Name.LocalName));
		foreach (KeyValuePair<string, string> item in _settingsFormatter.Map(element))
		{
			contentPartDefinitionBuilder.WithSetting(item.Key, item.Value);
		}
		foreach (XElement item2 in element.Elements())
		{
			XElement fieldElement = item2;
			string[] source = XmlConvert.DecodeName(fieldElement.Name.LocalName).Split(new char[1] { '.' }, 2);
			string text = source.FirstOrDefault();
			string fieldType = source.Skip(1).FirstOrDefault();
			if (text == "remove")
			{
				XAttribute xAttribute = fieldElement.Attribute("name");
				if (xAttribute != null)
				{
					contentPartDefinitionBuilder.RemoveField(xAttribute.Value);
				}
				continue;
			}
			contentPartDefinitionBuilder.WithField(text, delegate(ContentPartFieldDefinitionBuilder fieldBuilder)
			{
				fieldBuilder.OfType(fieldType);
				foreach (KeyValuePair<string, string> item3 in _settingsFormatter.Map(fieldElement))
				{
					fieldBuilder.WithSetting(item3.Key, item3.Value);
				}
			});
		}
	}
}
