using System.Xml.Linq;
using Orchard.ContentManagement.MetaData.Builders;

namespace Orchard.ContentManagement.MetaData;

public interface IContentDefinitionReader : IDependency
{
	void Merge(XElement source, ContentTypeDefinitionBuilder builder);

	void Merge(XElement source, ContentPartDefinitionBuilder builder);
}
