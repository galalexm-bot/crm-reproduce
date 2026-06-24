using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Common.Security;

[Component]
internal sealed class CatalogInstanceUnusedPermissions : IUnusedPermissions
{
	public IEnumerable<Permission> Permissions(object instance)
	{
		if (!(((instance is ICatalogProfile catalogProfile) ? MetadataLoader.LoadMetadata(catalogProfile.CatalogType.EntityType) : null) is EntityMetadata metadata) || !metadata.CanUsePermissions())
		{
			return Enumerable.Empty<Permission>();
		}
		return new List<Permission>
		{
			PermissionProvider.CatalogViewPermission,
			PermissionProvider.CatalogEditPermission,
			PermissionProvider.CatalogDeletePermission
		};
	}
}
