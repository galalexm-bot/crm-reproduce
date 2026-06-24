using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Documents;

[Component]
internal class DocumentVersionInstanceSettingsPermission : InstanceSettingsPermissionChildBase<IDocumentVersion, IDmsObject, IDmsObjectPermission>
{
	public override Permission AdminPermission => PermissionProvider.DocumentsFullAccessToAllObjectsPermission;

	public DocumentVersionInstanceSettingsPermission()
		: base((Expression<Func<IDmsObjectPermission, IDmsObject>>)((IDmsObjectPermission access) => access.DmsObject), (Expression<Func<IDocumentVersion, IDmsObject>>)((IDocumentVersion version) => version.Document))
	{
	}

	protected override ICollection<IDmsObjectPermission> GetPermissionHolderCollection(IDmsObject target)
	{
		return (ICollection<IDmsObjectPermission>)target.Permissions;
	}

	public override Guid GetParentPermissionId(Guid childPermissionId)
	{
		if (childPermissionId == PermissionProvider.DocumentVersionViewPermission.Id)
		{
			return PermissionProvider.DocumentViewPermission.Id;
		}
		if (childPermissionId == PermissionProvider.DocumentVersionLoadPermission.Id)
		{
			return PermissionProvider.DocumentLoadPermission.Id;
		}
		return childPermissionId;
	}
}
