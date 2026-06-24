using System.Xml.Linq;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.MetaData;

public static class ContentDefinitionReaderExtensions
{
	public static ContentTypeDefinition Import(this IContentDefinitionReader reader, XElement source)
	{
		ContentTypeDefinitionBuilder contentTypeDefinitionBuilder = new ContentTypeDefinitionBuilder();
		reader.Merge(source, contentTypeDefinitionBuilder);
		return contentTypeDefinitionBuilder.Build();
	}
}
