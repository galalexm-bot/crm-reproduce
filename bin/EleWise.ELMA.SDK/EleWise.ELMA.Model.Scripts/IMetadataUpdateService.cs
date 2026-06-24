using System;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Scripts;

public interface IMetadataUpdateService
{
	IMetadataUpdateResult Update(IMetadata metadata);

	IMetadataUpdateResult Update(IMetadata metadata, Guid formUid);
}
