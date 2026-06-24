using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Common.Security;

[Component]
internal sealed class CatalogAccessPermissionsDelegate : IPermissionsDelegate
{
	public bool CanCheckPermissions(Type type, Permission permission)
	{
		if (type.IsInheritOrSame<ICatalogProfile>())
		{
			return permission == PermissionProvider.CatalogViewPermission;
		}
		return false;
	}

	public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		if (target == null || permission == null)
		{
			return false;
		}
		if (!(target is ICatalogProfile catalogProfile) || catalogProfile.CatalogType == null)
		{
			return false;
		}
		if (MetadataLoader.LoadMetadata(catalogProfile.CatalogType.TypeUid) is EntityMetadata metadata)
		{
			return metadata.CanUsePermissions();
		}
		return false;
	}
}
