using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Managers;

public interface IEntityPermissionConfigurationManager : IConfigurationService
{
	[Obsolete("Use EntityMetadataExtensions.IsSystem or MetadataRuntimeService.IsSystem instead", true)]
	bool IsSystem(IMetadata metadata);

	TablePartMetadata GetActivePermissionMetadata(EntityMetadata metadata);

	void DisablePermissionMetadata(EntityMetadata metadata);

	void ActivatePermissionMetadata(EntityMetadata metadata, TablePartMetadata tablePartMetadata);

	TablePartMetadata InitNewPermissionMetadata(EntityMetadata metadata, string metadataName, string propertyName);
}
