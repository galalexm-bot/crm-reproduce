using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents;

[Component]
public class DocumentMetadataProfileInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<IDocumentMetadataProfile>();

	public void CreatePermissions(IEntity entity)
	{
		IDocumentMetadataProfile documentMetadataProfile = (IDocumentMetadataProfile)entity;
		if (documentMetadataProfile.IsNew())
		{
			IUserGroup group = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
			ISet<IDmsObjectDefaultPermissions> permissions = documentMetadataProfile.Permissions;
			InstanceOf<IDmsObjectDefaultPermissions> instanceOf = new InstanceOf<IDmsObjectDefaultPermissions>();
			instanceOf.New.DocumentMetadataProfile = documentMetadataProfile;
			instanceOf.New.PermissionId = PermissionProvider.DocumentMetadataCreateInstance.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf.New.Group = group;
			permissions.Add(instanceOf.New);
		}
	}
}
