using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Common.Audit;

[Component(Order = 2147483637)]
internal sealed class EntityPermissionPropertyHistoryProcessing : IEntityCollectionPropertyHistoryProcessing
{
	private IMetadataRuntimeService metadataRuntimeService;

	public EntityPermissionPropertyHistoryProcessing(IMetadataRuntimeService metadataRuntimeService)
	{
		this.metadataRuntimeService = metadataRuntimeService;
	}

	public bool CanProcessing(EntityMetadata ownerMetadata, PropertyMetadata propertyMetadata)
	{
		if (Guid.Empty.Equals(propertyMetadata.SubTypeUid))
		{
			return false;
		}
		try
		{
			Type typeByUid = metadataRuntimeService.GetTypeByUid(propertyMetadata.SubTypeUid);
			return typeof(IInstanceSettingsPermissionHolder).IsAssignableFrom(typeByUid);
		}
		catch (Exception message)
		{
			Logger.Log.Warn(message);
		}
		return false;
	}

	public bool NeedProcessing(EntityMetadata ownerMetadata, PropertyMetadata propertyMetadata)
	{
		return false;
	}
}
