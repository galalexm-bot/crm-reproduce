using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Audit;

[ExtensionPoint(ComponentType.All)]
public interface IEntityCollectionPropertyHistoryProcessing
{
	bool CanProcessing(EntityMetadata ownerMetadata, PropertyMetadata propertyMetadata);

	bool NeedProcessing(EntityMetadata ownerMetadata, PropertyMetadata propertyMetadata);
}
