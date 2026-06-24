using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
internal interface IEntityPermissionAccessRequestProvider
{
	bool CanUse(Guid typeUid);

	void GrantAccess(object entity, IEnumerable<Permission> grantedAccess, EleWise.ELMA.Security.Models.IUser user);

	string GetTaskSubject(object entity);

	string GetCreatingTaskHeader(object entity);

	string GetObjectTypeName(object entity);

	IEnumerable<EleWise.ELMA.Security.Models.IUser> GetAdmins(Guid entityTypeUid, long entityId);
}
