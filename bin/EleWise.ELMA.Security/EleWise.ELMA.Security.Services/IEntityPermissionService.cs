using System;
using System.Collections.Generic;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Html.EditableList;

namespace EleWise.ELMA.Security.Services;

public interface IEntityPermissionService
{
	bool CheckIfPermissionNeededForEntity(long[] objectsIds, Type type, long[] usersIds, string[] prefixedUsersIds, Guid permission, bool needReplacement = false);

	IEnumerable<string> CheckGrantablePermissions(Type type, string permissionGuids, string permissionData);

	AddPermissionModel EntityAddPermission(long[] id, Type type, long[] usersIds, string[] prefixedUsersIds, Guid permission, Guid[] defaultPermissions = null, bool needReplacement = false);

	bool EntityAddPermissionSave(long[] id, Type type, EditableListModel accessBindList);
}
