using EleWise.ELMA.FullTextSearch.Model;

namespace EleWise.ELMA.FullTextSearch.Services;

internal interface IFullTextTypeMappingServiceExt : IFullTextTypeMappingService
{
	IFullTextTypeMappingAvailability CheckAvailability();
}
