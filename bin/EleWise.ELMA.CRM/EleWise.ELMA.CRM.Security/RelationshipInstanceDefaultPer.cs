using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Security;

[Component]
internal class RelationshipInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<IRelationship>();

	public void CreatePermissions(IEntity entity)
	{
		IRelationship relationship = (IRelationship)entity;
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
		if (((ICollection<IRelationshipPersonPermission>)relationship.Permission).Count != 0)
		{
			return;
		}
		if (relationship.InheritPermissions)
		{
			RelationshipManager.Instance.AddPermissionsFromParent(relationship);
		}
		if (!((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).Any((IRelationshipPersonPermission p) => p.TypeRoleId == CommonRoleTypes.Author.Id))
		{
			ISet<IRelationshipPersonPermission> permission = relationship.Permission;
			InstanceOf<IRelationshipPersonPermission> instanceOf = new InstanceOf<IRelationshipPersonPermission>();
			instanceOf.New.Relationship = relationship;
			instanceOf.New.PermissionId = CRMPermissionProvider.ViewRelationshipPermission.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.Author.Id;
			instanceOf.New.User = relationship.CreationAuthor;
			permission.Add(instanceOf.New);
			ISet<IRelationshipPersonPermission> permission2 = relationship.Permission;
			InstanceOf<IRelationshipPersonPermission> instanceOf2 = new InstanceOf<IRelationshipPersonPermission>();
			instanceOf2.New.Relationship = relationship;
			instanceOf2.New.PermissionId = CRMPermissionProvider.EditRelationshipPermission.Id;
			instanceOf2.New.TypeRoleId = CommonRoleTypes.Author.Id;
			instanceOf2.New.User = relationship.CreationAuthor;
			permission2.Add(instanceOf2.New);
			ISet<IRelationshipPersonPermission> permission3 = relationship.Permission;
			InstanceOf<IRelationshipPersonPermission> instanceOf3 = new InstanceOf<IRelationshipPersonPermission>();
			instanceOf3.New.Relationship = relationship;
			instanceOf3.New.PermissionId = CRMPermissionProvider.CRMRelationshipCreateElementPermission.Id;
			instanceOf3.New.TypeRoleId = CommonRoleTypes.Author.Id;
			instanceOf3.New.User = relationship.CreationAuthor;
			permission3.Add(instanceOf3.New);
			ISet<IRelationshipPersonPermission> permission4 = relationship.Permission;
			InstanceOf<IRelationshipPersonPermission> instanceOf4 = new InstanceOf<IRelationshipPersonPermission>();
			instanceOf4.New.Relationship = relationship;
			instanceOf4.New.PermissionId = CRMPermissionProvider.CRMRelationshipFullAccessPermission.Id;
			instanceOf4.New.TypeRoleId = CommonRoleTypes.Author.Id;
			instanceOf4.New.User = relationship.CreationAuthor;
			permission4.Add(instanceOf4.New);
			ISet<IRelationshipPersonPermission> permission5 = relationship.Permission;
			InstanceOf<IRelationshipPersonPermission> instanceOf5 = new InstanceOf<IRelationshipPersonPermission>();
			instanceOf5.New.Relationship = relationship;
			instanceOf5.New.PermissionId = CRMPermissionProvider.CRMRelationshipIssuanceElementPermission.Id;
			instanceOf5.New.TypeRoleId = CommonRoleTypes.Author.Id;
			instanceOf5.New.User = relationship.CreationAuthor;
			permission5.Add(instanceOf5.New);
		}
		if (!((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).Any((IRelationshipPersonPermission p) => p.TypeRoleId == CommonRoleTypes.ParticipantWork.Id))
		{
			AddPartipicantPermission(relationship, user, CommonRoleTypes.ParticipantWork.Id);
			if (relationship.RelationshipUsers != null && ((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Any((IRelationshipUser a) => a.Status == RelationshipUserStatus.Participant))
			{
				foreach (IRelationshipUser item in ((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Where((IRelationshipUser a) => a.Status == RelationshipUserStatus.Participant))
				{
					AddPartipicantPermission(relationship, item.User, CommonRoleTypes.ParticipantWork.Id);
				}
			}
		}
		if (((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).Any((IRelationshipPersonPermission p) => p.TypeRoleId == CommonRoleTypes.Informs.Id))
		{
			return;
		}
		AddInformPermission(relationship, user);
		if (relationship.RelationshipUsers == null || !((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Any((IRelationshipUser a) => a.Status == RelationshipUserStatus.InfromTo))
		{
			return;
		}
		foreach (IRelationshipUser item2 in ((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Where((IRelationshipUser a) => a.Status == RelationshipUserStatus.InfromTo))
		{
			AddInformPermission(relationship, item2.User);
		}
	}

	private void AddInformPermission(IRelationship relationship, EleWise.ELMA.Security.Models.IUser user)
	{
		ISet<IRelationshipPersonPermission> permission = relationship.Permission;
		InstanceOf<IRelationshipPersonPermission> instanceOf = new InstanceOf<IRelationshipPersonPermission>();
		instanceOf.New.Relationship = relationship;
		instanceOf.New.PermissionId = CRMPermissionProvider.ViewRelationshipPermission.Id;
		instanceOf.New.TypeRoleId = CommonRoleTypes.Informs.Id;
		instanceOf.New.User = user;
		permission.Add(instanceOf.New);
	}

	private void AddPartipicantPermission(IRelationship relationship, EleWise.ELMA.Security.Models.IUser user, Guid typeRoleId)
	{
		ISet<IRelationshipPersonPermission> permission = relationship.Permission;
		InstanceOf<IRelationshipPersonPermission> instanceOf = new InstanceOf<IRelationshipPersonPermission>();
		instanceOf.New.Relationship = relationship;
		instanceOf.New.PermissionId = CRMPermissionProvider.ViewRelationshipPermission.Id;
		instanceOf.New.TypeRoleId = typeRoleId;
		instanceOf.New.User = user;
		permission.Add(instanceOf.New);
		ISet<IRelationshipPersonPermission> permission2 = relationship.Permission;
		InstanceOf<IRelationshipPersonPermission> instanceOf2 = new InstanceOf<IRelationshipPersonPermission>();
		instanceOf2.New.Relationship = relationship;
		instanceOf2.New.PermissionId = CRMPermissionProvider.EditRelationshipPermission.Id;
		instanceOf2.New.TypeRoleId = typeRoleId;
		instanceOf2.New.User = user;
		permission2.Add(instanceOf2.New);
		ISet<IRelationshipPersonPermission> permission3 = relationship.Permission;
		InstanceOf<IRelationshipPersonPermission> instanceOf3 = new InstanceOf<IRelationshipPersonPermission>();
		instanceOf3.New.Relationship = relationship;
		instanceOf3.New.PermissionId = CRMPermissionProvider.CRMRelationshipCreateElementPermission.Id;
		instanceOf3.New.TypeRoleId = typeRoleId;
		instanceOf3.New.User = user;
		permission3.Add(instanceOf3.New);
		ISet<IRelationshipPersonPermission> permission4 = relationship.Permission;
		InstanceOf<IRelationshipPersonPermission> instanceOf4 = new InstanceOf<IRelationshipPersonPermission>();
		instanceOf4.New.Relationship = relationship;
		instanceOf4.New.PermissionId = CRMPermissionProvider.CRMRelationshipFullAccessPermission.Id;
		instanceOf4.New.TypeRoleId = typeRoleId;
		instanceOf4.New.User = user;
		permission4.Add(instanceOf4.New);
		ISet<IRelationshipPersonPermission> permission5 = relationship.Permission;
		InstanceOf<IRelationshipPersonPermission> instanceOf5 = new InstanceOf<IRelationshipPersonPermission>();
		instanceOf5.New.Relationship = relationship;
		instanceOf5.New.PermissionId = CRMPermissionProvider.CRMRelationshipIssuanceElementPermission.Id;
		instanceOf5.New.TypeRoleId = typeRoleId;
		instanceOf5.New.User = user;
		permission5.Add(instanceOf5.New);
	}
}
