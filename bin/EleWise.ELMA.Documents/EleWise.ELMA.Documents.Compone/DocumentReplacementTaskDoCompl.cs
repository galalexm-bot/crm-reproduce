using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Components;

[Component]
internal class DocumentReplacementTaskDoCompletedAction : IReplacementTaskDoCompletedAction
{
	public DocumentManager DocumentManager { get; set; }

	public ISecurityService SecurityService { get; set; }

	public void DoCompleted(IReplacementTask task, EleWise.ELMA.Security.Models.IUser sourceUser, ICollection<EleWise.ELMA.Security.Models.IUser> targetUsers, IEntity entity)
	{
		if (task != null && task.Replacement is IReplacementTaskDocumentPermission replacement)
		{
			List<Permission> list = new List<Permission>();
			if (CanSetPermissionAction((IReplacementTaskDocumentPermission m) => m.TaskDocumentsPermissions, task, replacement, entity))
			{
				list.Add(PermissionProvider.DocumentViewPermission);
				list.Add(PermissionProvider.DocumentLoadPermission);
			}
			if (CanSetPermissionAction((IReplacementTaskDocumentPermission m) => m.TaskDocumentsManagePermissions, task, replacement, entity))
			{
				list.Add(PermissionProvider.DocumentManagerAccessPermission);
			}
			DocumentManager.ReplacementTaskSetPermissionAction(entity, sourceUser, targetUsers, list);
		}
	}

	private bool CanSetPermissionAction(Expression<Func<IReplacementTaskDocumentPermission, object>> expression, IReplacementTask task, IReplacementTaskDocumentPermission replacement, IEntity entity)
	{
		Guid uid = InterfaceActivator.LoadPropertyMetadata(expression).Uid;
		bool permission = (bool)replacement.GetPropertyValue(uid);
		if (!permission)
		{
			return false;
		}
		bool result = false;
		return bool.TryParse(task.GetAssignmentValue(new ReferenceOnEntity
		{
			Object = entity
		}, uid, (ReferenceOnEntity e, Guid p) => permission.ToString()), out result) && result;
	}
}
