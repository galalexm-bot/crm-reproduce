using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.Model;

internal interface IFullTextTypeMappingAvailability
{
	bool IsAvailable { get; }

	IReadOnlyCollection<string> Errors { get; }
}
