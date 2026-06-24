using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.Services;

public interface IPropertyInstanceService
{
	IEnumerable<IAbstractPropertyProfile> GetPropertyProfiles(IPropertyOwnerProfile owner);

	IPropertyMetadata GetPropertyMetadata(IAbstractPropertyProfile profile);

	[Obsolete("Рекомендуется использовать GetClassMetadata()")]
	IEntityMetadata GetMetadata(IAbstractPropertyProfile profile);

	IEnumerable<IPropertyMetadata> GetPropertyMetadataList(IPropertyOwnerProfile owner);

	IAbstractPropertyProfile CreateProfile(IPropertyOwnerProfile owner, Guid propertyUid);

	void SaveProfiles(IPropertyOwnerProfile owner, IEnumerable<IAbstractPropertyProfile> profiles);

	bool IsTitleProperty(IAbstractPropertyProfile profile);

	Guid GetTitlePropertyGuid(IPropertyOwnerProfile owner);

	Guid GetHidePermissionId(IPropertyOwnerProfile owner);

	Guid GetViewPermissionId(IPropertyOwnerProfile owner);

	Guid GetEditPermissionId(IPropertyOwnerProfile owner);

	ClassMetadata GetClassMetadata(IAbstractPropertyProfile profile);

	ClassMetadata GetClassMetadata(IPropertyOwnerProfile owner);
}
