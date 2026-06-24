using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Common.Components;

[Component(Order = 1000)]
internal sealed class CatalogInstancePermissionManagmentServiceExtension : IPermissionManagmentServiceExtension
{
	private bool Can(ClassMetadata metadata)
	{
		if (metadata is EntityMetadata metadata2)
		{
			return metadata2.CanUsePermissions();
		}
		return false;
	}

	public Permission GetPermissionForBase(Permission permission, ClassMetadata metadata)
	{
		if (Can(metadata))
		{
			if (permission.Id == CommonPermissions.View.Id)
			{
				return PermissionProvider.CatalogInstanceViewPermission;
			}
			if (permission.Id == CommonPermissions.Edit.Id)
			{
				return PermissionProvider.CatalogInstancePowerPermission;
			}
			if (permission.Id == CommonPermissions.GrantAccess.Id)
			{
				return PermissionProvider.CatalogInstanceGrantAccessPermission;
			}
		}
		return null;
	}
}
