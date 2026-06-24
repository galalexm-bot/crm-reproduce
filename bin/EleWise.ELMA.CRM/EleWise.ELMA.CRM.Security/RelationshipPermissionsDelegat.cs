using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Security;

[Component(Order = 50)]
public class RelationshipPermissionsDelegate : IPermissionsDelegate
{
	public UserManager UserManager { get; set; }

	public bool CanCheckPermissions(Type type, Permission permission)
	{
		if (type != null && typeof(IRelationship).IsAssignableFrom(type))
		{
			return permission == CRMPermissionProvider.ExecuteRelationshipPermission;
		}
		return false;
	}

	public bool HasPermission(EleWise.ELMA.Security.IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		if (target is IRelationship relationship && permission == CRMPermissionProvider.ExecuteRelationshipPermission)
		{
			EleWise.ELMA.Security.Models.IUser checkUser = (EleWise.ELMA.Security.Models.IUser)user;
			return ((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Any((IRelationshipUser r) => r.Status == RelationshipUserStatus.Participant && (r.User == checkUser || UserManager.IsSubordinateUser(checkUser, r.User)));
		}
		return false;
	}
}
