using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.Services;

[ExtensionPoint(ComponentType.Server)]
public interface IPropertyPermissionAdapter
{
	event EventHandler<PropertyPermissionsChangedEventArgs> PermissionsChanged;

	bool IsSupportedOwnerType(Type ownerType);

	bool IsSupportedProfileType(Type profileType);

	bool IsSupportedModelType(Type modelType);

	IEnumerable<IAbstractPropertyProfile> GetPropertyProfiles(IPropertyOwnerProfile owner);

	IEntityMetadata GetMetadata(IPropertyOwnerProfile owner);

	IEntityMetadata GetMetadata(IAbstractPropertyProfile profile);

	IEnumerable<IPropertyMetadata> GetPropertyMetadataList(IPropertyOwnerProfile owner);

	IAbstractPropertyProfile CreateProfile(IPropertyOwnerProfile owner, Guid propertyUid);

	void SaveProfiles(IPropertyOwnerProfile owner, IEnumerable<IAbstractPropertyProfile> profiles);

	IEnumerable<IAbstractPropertyAccess> GetAccesses(Type modelType);

	IEntityMetadata GetMetadata(Type modelType, bool includeInheritedProperties);

	IEnumerable<Type> GetChildTypes(Type modelType);

	Guid GetHidePermissionId();

	Guid GetViewPermissionId();

	Guid GetEditPermissionId();
}
