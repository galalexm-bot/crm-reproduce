using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Messages.Security;

[Component]
public class ChannelInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<IInformationChannel>();

	public void CreatePermissions(IEntity entity)
	{
		IInformationChannel informationChannel = (IInformationChannel)entity;
		if (((ICollection<IInformationChannelPermission>)informationChannel.Permissions).Count != 0)
		{
			return;
		}
		if (informationChannel.CreationAuthor != null)
		{
			ISet<IInformationChannelPermission> permissions = informationChannel.Permissions;
			InstanceOf<IInformationChannelPermission> instanceOf = new InstanceOf<IInformationChannelPermission>();
			instanceOf.New.Channel = informationChannel;
			instanceOf.New.PermissionId = PermissionProvider.ChannelViewPermission.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.Author.Id;
			instanceOf.New.User = informationChannel.CreationAuthor;
			permissions.Add(instanceOf.New);
			ISet<IInformationChannelPermission> permissions2 = informationChannel.Permissions;
			InstanceOf<IInformationChannelPermission> instanceOf2 = new InstanceOf<IInformationChannelPermission>();
			instanceOf2.New.Channel = informationChannel;
			instanceOf2.New.PermissionId = PermissionProvider.ChannelEditPermission.Id;
			instanceOf2.New.TypeRoleId = CommonRoleTypes.Author.Id;
			instanceOf2.New.User = informationChannel.CreationAuthor;
			permissions2.Add(instanceOf2.New);
			ISet<IInformationChannelPermission> permissions3 = informationChannel.Permissions;
			InstanceOf<IInformationChannelPermission> instanceOf3 = new InstanceOf<IInformationChannelPermission>();
			instanceOf3.New.Channel = informationChannel;
			instanceOf3.New.PermissionId = PermissionProvider.ChannelFullAccessPermission.Id;
			instanceOf3.New.TypeRoleId = CommonRoleTypes.Author.Id;
			instanceOf3.New.User = informationChannel.CreationAuthor;
			permissions3.Add(instanceOf3.New);
		}
		if (informationChannel.ChannelType == InformationChannelType.Open)
		{
			IUserGroup userGroup = UserGroupManager.Instance.LoadOrNull(SecurityConstants.AllUsersGroupUid);
			if (userGroup != null)
			{
				ISet<IInformationChannelPermission> permissions4 = informationChannel.Permissions;
				InstanceOf<IInformationChannelPermission> instanceOf4 = new InstanceOf<IInformationChannelPermission>();
				instanceOf4.New.Channel = informationChannel;
				instanceOf4.New.PermissionId = PermissionProvider.ChannelViewPermission.Id;
				instanceOf4.New.TypeRoleId = CommonRoleTypes.Group.Id;
				instanceOf4.New.Group = userGroup;
				permissions4.Add(instanceOf4.New);
			}
		}
	}
}
