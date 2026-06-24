using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Common.Components;

[Component]
internal sealed class CatalogsPermissionsTypeExtensionPoint : BasePermissionsTypeExtensionPoint
{
	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public override void UpdatePermissions(Type type, long id, bool needDropOldData)
	{
		base.UpdatePermissions(type, id, needDropOldData);
		EntityMetadata metadata = ((EntityHelper.GetEntityManager(type).Load(id) is ICatalogProfile catalogProfile) ? MetadataRuntimeService.GetMetadata(catalogProfile.CatalogType.TypeUid, loadImplementation: false) : null) as EntityMetadata;
		UpdatePermissions(metadata, needDropOldData);
	}
}
