using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Services;

public interface ICatalogProfileUpdaterService
{
	void CreateProfiles(IEnumerable<ClassMetadata> newMetadataList);

	void UpdateProfiles();
}
