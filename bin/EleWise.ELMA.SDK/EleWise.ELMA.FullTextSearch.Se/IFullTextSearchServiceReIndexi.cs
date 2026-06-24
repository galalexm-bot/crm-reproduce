using EleWise.ELMA.FullTextSearch.Model;

namespace EleWise.ELMA.FullTextSearch.Services;

public interface IFullTextSearchServiceReIndexingTypeExtension : IFullTextSearchService
{
	IndexResult ReIndexingByType(IIndexQueue item);
}
