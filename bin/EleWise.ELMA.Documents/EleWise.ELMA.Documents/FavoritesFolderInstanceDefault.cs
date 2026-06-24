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
public class FavoritesFolderInstanceDefaultPermissions : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<IFavoritesFolder>();

	public void CreatePermissions(IEntity entity)
	{
		IFavoritesFolder favoritesFolder = (IFavoritesFolder)entity;
		if (favoritesFolder != null)
		{
			ISet<IDmsObjectPermission> permissions = favoritesFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
			instanceOf.New.DmsObject = favoritesFolder;
			instanceOf.New.PermissionId = PermissionProvider.DocumentViewPermission.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf.New.User = favoritesFolder.Owner;
			permissions.Add(instanceOf.New);
			ISet<IDmsObjectPermission> permissions2 = favoritesFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf2 = new InstanceOf<IDmsObjectPermission>();
			instanceOf2.New.DmsObject = favoritesFolder;
			instanceOf2.New.PermissionId = PermissionProvider.DocumentLoadPermission.Id;
			instanceOf2.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf2.New.User = favoritesFolder.Owner;
			permissions2.Add(instanceOf2.New);
			ISet<IDmsObjectPermission> permissions3 = favoritesFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf3 = new InstanceOf<IDmsObjectPermission>();
			instanceOf3.New.DmsObject = favoritesFolder;
			instanceOf3.New.PermissionId = PermissionProvider.DocumentEditPermission.Id;
			instanceOf3.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf3.New.User = favoritesFolder.Owner;
			permissions3.Add(instanceOf3.New);
			ISet<IDmsObjectPermission> permissions4 = favoritesFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf4 = new InstanceOf<IDmsObjectPermission>();
			instanceOf4.New.DmsObject = favoritesFolder;
			instanceOf4.New.PermissionId = PermissionProvider.DocumentManagerAccessPermission.Id;
			instanceOf4.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf4.New.User = favoritesFolder.Owner;
			permissions4.Add(instanceOf4.New);
			ISet<IDmsObjectPermission> permissions5 = favoritesFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf5 = new InstanceOf<IDmsObjectPermission>();
			instanceOf5.New.DmsObject = favoritesFolder;
			instanceOf5.New.PermissionId = PermissionProvider.DocumentCreatePermission.Id;
			instanceOf5.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf5.New.User = favoritesFolder.Owner;
			permissions5.Add(instanceOf5.New);
			ISet<IDmsObjectPermission> permissions6 = favoritesFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf6 = new InstanceOf<IDmsObjectPermission>();
			instanceOf6.New.DmsObject = favoritesFolder;
			instanceOf6.New.PermissionId = PermissionProvider.DocumentFullAccessPermission.Id;
			instanceOf6.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf6.New.User = favoritesFolder.Owner;
			permissions6.Add(instanceOf6.New);
		}
	}
}
