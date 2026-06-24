using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Calendar;

[Component]
public class ScheduleInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<ISchedule>();

	public void CreatePermissions(IEntity entity)
	{
		ISchedule schedule = (ISchedule)entity;
		if (schedule != null)
		{
			if (schedule.Owner != null)
			{
				ISet<ISchedulePermission> permissions = schedule.Permissions;
				InstanceOf<ISchedulePermission> instanceOf = new InstanceOf<ISchedulePermission>();
				instanceOf.New.Schedule = schedule;
				instanceOf.New.PermissionId = PermissionProvider.ScheduleViewPermission.Id;
				instanceOf.New.TypeRoleId = CommonRoleTypes.User.Id;
				instanceOf.New.User = schedule.Owner;
				permissions.Add(instanceOf.New);
				ISet<ISchedulePermission> permissions2 = schedule.Permissions;
				InstanceOf<ISchedulePermission> instanceOf2 = new InstanceOf<ISchedulePermission>();
				instanceOf2.New.Schedule = schedule;
				instanceOf2.New.PermissionId = PermissionProvider.ScheduleEditPermission.Id;
				instanceOf2.New.TypeRoleId = CommonRoleTypes.User.Id;
				instanceOf2.New.User = schedule.Owner;
				permissions2.Add(instanceOf2.New);
				ISet<ISchedulePermission> permissions3 = schedule.Permissions;
				InstanceOf<ISchedulePermission> instanceOf3 = new InstanceOf<ISchedulePermission>();
				instanceOf3.New.Schedule = schedule;
				instanceOf3.New.PermissionId = PermissionProvider.ScheduleFullPermission.Id;
				instanceOf3.New.TypeRoleId = CommonRoleTypes.User.Id;
				instanceOf3.New.User = schedule.Owner;
				permissions3.Add(instanceOf3.New);
				return;
			}
			ISet<ISchedulePermission> permissions4 = schedule.Permissions;
			InstanceOf<ISchedulePermission> instanceOf4 = new InstanceOf<ISchedulePermission>();
			instanceOf4.New.Schedule = schedule;
			instanceOf4.New.PermissionId = PermissionProvider.ScheduleViewPermission.Id;
			instanceOf4.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf4.New.User = schedule.CreationAuthor;
			permissions4.Add(instanceOf4.New);
			ISet<ISchedulePermission> permissions5 = schedule.Permissions;
			InstanceOf<ISchedulePermission> instanceOf5 = new InstanceOf<ISchedulePermission>();
			instanceOf5.New.Schedule = schedule;
			instanceOf5.New.PermissionId = PermissionProvider.ScheduleEditPermission.Id;
			instanceOf5.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf5.New.User = schedule.CreationAuthor;
			permissions5.Add(instanceOf5.New);
			ISet<ISchedulePermission> permissions6 = schedule.Permissions;
			InstanceOf<ISchedulePermission> instanceOf6 = new InstanceOf<ISchedulePermission>();
			instanceOf6.New.Schedule = schedule;
			instanceOf6.New.PermissionId = PermissionProvider.ScheduleFullPermission.Id;
			instanceOf6.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf6.New.User = schedule.CreationAuthor;
			permissions6.Add(instanceOf6.New);
			ISet<ISchedulePermission> permissions7 = schedule.Permissions;
			InstanceOf<ISchedulePermission> instanceOf7 = new InstanceOf<ISchedulePermission>();
			instanceOf7.New.Schedule = schedule;
			instanceOf7.New.PermissionId = PermissionProvider.ScheduleViewPermission.Id;
			instanceOf7.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf7.New.Group = UserGroupManager.Instance.Load(SecurityConstants.AdminGroupUid);
			permissions7.Add(instanceOf7.New);
			ISet<ISchedulePermission> permissions8 = schedule.Permissions;
			InstanceOf<ISchedulePermission> instanceOf8 = new InstanceOf<ISchedulePermission>();
			instanceOf8.New.Schedule = schedule;
			instanceOf8.New.PermissionId = PermissionProvider.ScheduleEditPermission.Id;
			instanceOf8.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf8.New.Group = UserGroupManager.Instance.Load(SecurityConstants.AdminGroupUid);
			permissions8.Add(instanceOf8.New);
			ISet<ISchedulePermission> permissions9 = schedule.Permissions;
			InstanceOf<ISchedulePermission> instanceOf9 = new InstanceOf<ISchedulePermission>();
			instanceOf9.New.Schedule = schedule;
			instanceOf9.New.PermissionId = PermissionProvider.ScheduleFullPermission.Id;
			instanceOf9.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf9.New.Group = UserGroupManager.Instance.Load(SecurityConstants.AdminGroupUid);
			permissions9.Add(instanceOf9.New);
		}
	}
}
