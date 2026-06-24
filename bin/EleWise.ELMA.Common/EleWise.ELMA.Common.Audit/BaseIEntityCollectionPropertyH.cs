using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.Audit;

[Component(Order = int.MaxValue)]
internal class BaseIEntityCollectionPropertyHistoryProcessing : IEntityCollectionPropertyHistoryProcessing
{
	public bool CanProcessing(EntityMetadata ownerMetadata, PropertyMetadata propertyMetadata)
	{
		if (propertyMetadata.TypeUid != EntityDescriptor.UID || Guid.Empty.Equals(propertyMetadata.SubTypeUid))
		{
			return false;
		}
		if (propertyMetadata.Settings is EntitySettings entitySettings)
		{
			return entitySettings.RelationType != RelationType.OneToOne;
		}
		return false;
	}

	public bool NeedProcessing(EntityMetadata ownerMetadata, PropertyMetadata propertyMetadata)
	{
		return !(MetadataLoader.LoadMetadata(propertyMetadata.SubTypeUid) is TablePartMetadata);
	}
}
