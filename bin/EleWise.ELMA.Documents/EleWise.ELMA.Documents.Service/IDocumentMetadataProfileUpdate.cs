using System.Collections.Generic;
using EleWise.ELMA.Documents.Metadata;

namespace EleWise.ELMA.Documents.Services;

public interface IDocumentMetadataProfileUpdaterService
{
	void CreateProfiles(IEnumerable<DocumentMetadata> newMetadataList);

	void UpdateProfiles();
}
