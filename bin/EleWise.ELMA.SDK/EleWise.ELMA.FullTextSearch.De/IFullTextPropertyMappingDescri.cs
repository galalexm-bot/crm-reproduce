using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public interface IFullTextPropertyMappingDescriptor : IFullTextPropertyDescriptor
{
	FieldIndexList GetMappingField(IPropertyMetadata propMd);
}
