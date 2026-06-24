using System;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.UI.Services;

public interface IComponentMetadataLoader
{
	ComponentMetadata GetComponentMetadata(Guid metadataUid);
}
