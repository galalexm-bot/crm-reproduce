using System;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Extensions;

[Component]
public class CatalogFilterPermissionResolver : IFilterPermissionResolver
{
	public FilterType FilterType => FilterType.SharedFilter;

	public bool SupportedType(IFilterFolder filter)
	{
		return ((filter.ObjectsType.EntityType == null) ? null : (MetadataLoader.LoadMetadata(filter.ObjectsType.EntityType) as EntityMetadata))?.ShowInCatalogList ?? false;
	}

	public bool HasPermission(IFilterFolder filter)
	{
		if (!SupportedType(filter))
		{
			return false;
		}
		Guid uid = ((MetadataLoader.LoadMetadata(filter.ObjectsType.EntityType) is EntityMetadata entityMetadata && entityMetadata.Type == EntityMetadataType.InterfaceImplementation) ? entityMetadata.ImplementationUid : filter.ObjectsType.TypeUid);
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(uid);
		if (catalogProfile != null)
		{
			return Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.CatalogEditGlobalFiltersPermission, catalogProfile);
		}
		return false;
	}
}
