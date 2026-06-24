using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.Documents.Web.Extensions;

public static class FolderTreeExtensions
{
	public static bool HasPermissionsAggregate(this TreeModel model, Guid nodeTypeId, long id, Func<IEnumerable<Permission>, Func<Permission, bool>, bool> aggregateFunction, params Permission[] permissions)
	{
		return aggregateFunction(permissions, (Permission p) => model.HasPermission(p, nodeTypeId, id));
	}

	public static bool HasPermissionsAny(this TreeModel model, Guid nodeTypeId, long id, params Permission[] permissions)
	{
		return model.HasPermissionsAggregate(nodeTypeId, id, Enumerable.Any, permissions);
	}

	public static bool HasPermissionsAll(this TreeModel model, Guid nodeTypeId, long id, params Permission[] permissions)
	{
		return model.HasPermissionsAggregate(nodeTypeId, id, Enumerable.All, permissions);
	}

	public static bool HasPermission(this TreeModel model, FolderTreeNode node, Permission permission)
	{
		return model.HasPermission(permission, node.NodeTypeUid, node.Id);
	}
}
