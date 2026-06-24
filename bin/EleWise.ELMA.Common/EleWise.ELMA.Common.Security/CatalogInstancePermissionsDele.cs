using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Common.Security;

[Component]
internal sealed class CatalogInstancePermissionsDelegate : IPermissionsDelegate
{
	public ISecurityService SecurityService { get; set; }

	public bool CanCheckPermissions(Type type, Permission permission)
	{
		if (type != null && type.IsInheritOrSame<IEntity>() && permission == CommonPermissions.Delete)
		{
			if (MetadataLoader.LoadMetadata(type) is EntityMetadata metadata)
			{
				return metadata.CanUsePermissions();
			}
			return false;
		}
		return false;
	}

	public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		if (target == null || permission == null)
		{
			return false;
		}
		return SecurityService.HasPermission(user, PermissionProvider.CatalogInstancePowerPermission, target, skipAdmin);
	}
}
