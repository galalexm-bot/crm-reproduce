using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Services;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IEntityPermissionsTypeExtensionPoint
{
	void UpdatePermissions(EntityMetadata metadata, bool needDropOldData);

	void UpdatePermissions(Type type, long id, bool needDropOldData);

	IEnumerable<PropertyMetadata> GetDefaultPermissionMetadataProperties(EntityMetadata metadata);

	IEnumerable<string> GetImplementedInterfaces(EntityMetadata metadata);

	string CustomCode(EntityMetadata metadata, EntityMetadata permissionMetadata, bool enabled);

	bool IsInstancePermissionMode(object instance);
}
