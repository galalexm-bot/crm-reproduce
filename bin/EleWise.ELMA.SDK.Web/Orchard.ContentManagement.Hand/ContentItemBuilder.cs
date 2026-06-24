using System.Linq;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.Handlers;

public class ContentItemBuilder
{
	private readonly ContentTypeDefinition _definition;

	private readonly ContentItem _item;

	public ContentItemBuilder(ContentTypeDefinition definition)
	{
		_definition = definition;
		_item = new ContentItem
		{
			ContentType = definition.Name,
			TypeDefinition = definition
		};
	}

	public ContentItem Build()
	{
		return _item;
	}

	public ContentItemBuilder Weld<TPart>() where TPart : ContentPart, new()
	{
		if (_item.Parts.FirstOrDefault((ContentPart part) => part.GetType().Equals(typeof(TPart))) == null)
		{
			string partName = typeof(TPart).Name;
			ContentTypePartDefinition contentTypePartDefinition = _definition.Parts.FirstOrDefault((ContentTypePartDefinition p) => p.PartDefinition.Name == partName);
			if (contentTypePartDefinition == null)
			{
				contentTypePartDefinition = new ContentTypePartDefinition(new ContentPartDefinition(partName), new SettingsDictionary());
			}
			TPart part2 = new TPart
			{
				TypePartDefinition = contentTypePartDefinition
			};
			_item.Weld(part2);
		}
		return this;
	}

	public ContentItemBuilder Weld(ContentPart contentPart)
	{
		_item.Weld(contentPart);
		return this;
	}
}
