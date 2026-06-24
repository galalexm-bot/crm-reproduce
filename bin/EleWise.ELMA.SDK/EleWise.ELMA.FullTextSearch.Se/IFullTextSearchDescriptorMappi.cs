using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.FullTextSearch.Services;

public interface IFullTextSearchDescriptorMappingService : IFullTextSearchDescriptorService
{
	FieldIndexList GetMappingField(IPropertyMetadata propMd);
}
