using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents;

[Component]
public class MyDocumentsInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<IMyDocumentFolder>();

	public void CreatePermissions(IEntity entity)
	{
		IMyDocumentFolder myDocumentFolder = (IMyDocumentFolder)entity;
		if (myDocumentFolder != null)
		{
			ISet<IDmsObjectPermission> permissions = myDocumentFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
			instanceOf.New.DmsObject = myDocumentFolder;
			instanceOf.New.PermissionId = PermissionProvider.DocumentViewPermission.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf.New.User = myDocumentFolder.Owner;
			permissions.Add(instanceOf.New);
			ISet<IDmsObjectPermission> permissions2 = myDocumentFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf2 = new InstanceOf<IDmsObjectPermission>();
			instanceOf2.New.DmsObject = myDocumentFolder;
			instanceOf2.New.PermissionId = PermissionProvider.DocumentLoadPermission.Id;
			instanceOf2.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf2.New.User = myDocumentFolder.Owner;
			permissions2.Add(instanceOf2.New);
			ISet<IDmsObjectPermission> permissions3 = myDocumentFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf3 = new InstanceOf<IDmsObjectPermission>();
			instanceOf3.New.DmsObject = myDocumentFolder;
			instanceOf3.New.PermissionId = PermissionProvider.DocumentEditPermission.Id;
			instanceOf3.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf3.New.User = myDocumentFolder.Owner;
			permissions3.Add(instanceOf3.New);
			ISet<IDmsObjectPermission> permissions4 = myDocumentFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf4 = new InstanceOf<IDmsObjectPermission>();
			instanceOf4.New.DmsObject = myDocumentFolder;
			instanceOf4.New.PermissionId = PermissionProvider.DocumentManagerAccessPermission.Id;
			instanceOf4.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf4.New.User = myDocumentFolder.Owner;
			permissions4.Add(instanceOf4.New);
			ISet<IDmsObjectPermission> permissions5 = myDocumentFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf5 = new InstanceOf<IDmsObjectPermission>();
			instanceOf5.New.DmsObject = myDocumentFolder;
			instanceOf5.New.PermissionId = PermissionProvider.DocumentCreatePermission.Id;
			instanceOf5.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf5.New.User = myDocumentFolder.Owner;
			permissions5.Add(instanceOf5.New);
			ISet<IDmsObjectPermission> permissions6 = myDocumentFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf6 = new InstanceOf<IDmsObjectPermission>();
			instanceOf6.New.DmsObject = myDocumentFolder;
			instanceOf6.New.PermissionId = PermissionProvider.DocumentFullAccessPermission.Id;
			instanceOf6.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf6.New.User = myDocumentFolder.Owner;
			permissions6.Add(instanceOf6.New);
		}
	}
}
