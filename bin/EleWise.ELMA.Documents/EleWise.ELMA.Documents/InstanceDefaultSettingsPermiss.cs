using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Documents;

[Component]
public class InstanceDefaultSettingsPermission : InstanceSettingsPermissionBase<IDocumentMetadataProfile, IDmsObjectDefaultPermissions>
{
	public override Permission AdminPermission => PermissionProvider.DocumentsFullAccessToAllObjectsPermission;

	public override bool Filtering => false;

	public InstanceDefaultSettingsPermission()
		: base((Expression<Func<IDmsObjectDefaultPermissions, IDocumentMetadataProfile>>)((IDmsObjectDefaultPermissions access) => access.DocumentMetadataProfile))
	{
	}

	protected override ICollection<IDmsObjectDefaultPermissions> GetPermissionHolderCollection(IDocumentMetadataProfile target)
	{
		return (ICollection<IDmsObjectDefaultPermissions>)target.Permissions;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		if (!base.SecurityService.HasPermission(user, PermissionProvider.DocumentsAdminAccessPermission))
		{
			return base.SecurityService.HasPermission(user, PermissionProvider.DocumentsFullAccessToAllObjectsPermission);
		}
		return true;
	}
}
