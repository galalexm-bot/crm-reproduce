using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Services;

public interface IMetadataUidChecker
{
	bool AddUidIfNeeded(IEnumerable<IMetadata> metadata);

	bool AddUidIfNeeded(IEnumerable<IMetadataItem> metadataItems);

	bool AddUidIfNeeded(IMetadata metadata);
}
