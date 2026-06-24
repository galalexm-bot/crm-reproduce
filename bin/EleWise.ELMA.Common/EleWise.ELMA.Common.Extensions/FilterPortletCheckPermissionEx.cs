using System;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Extensions;

[Component(Order = 1000)]
public class FilterPortletCheckPermissionExtensions : IFilterPortletCheckPermission
{
	public bool AvailablePermissionType(Guid TypeUid)
	{
		IMetadata metadata = MetadataLoader.LoadMetadata(TypeUid);
		if (metadata is EntityMetadata)
		{
			return ((EntityMetadata)metadata).ShowInCatalogList;
		}
		return false;
	}

	public bool HasPermission(Guid TypeUid)
	{
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		IMetadata metadata = MetadataLoader.LoadMetadata(TypeUid);
		if (!(metadata is EntityMetadata))
		{
			return false;
		}
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(((EntityMetadata)metadata).ImplementationUid);
		if (catalogProfile == null)
		{
			return false;
		}
		if (serviceNotNull.HasPermission(PermissionProvider.CatalogsAccessPermission))
		{
			if (!serviceNotNull.HasPermission(PermissionProvider.CatalogEditPermission, catalogProfile))
			{
				return serviceNotNull.HasPermission(PermissionProvider.CatalogViewPermission, catalogProfile);
			}
			return true;
		}
		return false;
	}
}
