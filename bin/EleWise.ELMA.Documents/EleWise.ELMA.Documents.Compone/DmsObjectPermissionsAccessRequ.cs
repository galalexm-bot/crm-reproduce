using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Components;

[Component]
internal sealed class DmsObjectPermissionsAccessRequestProvider : IEntityPermissionAccessRequestProvider
{
	private readonly string creatingTaskForDocument = SR.T("Запрос прав доступа к документу");

	private readonly string creatingTaskForFolder = SR.T("Запрос прав доступа к папке");

	private readonly string taskSubjectForDocument = SR.T("Предоставить доступ к документу");

	private readonly string taskSubjectForFolder = SR.T("Предоставить доступ к папке");

	private readonly string documentTypeName = SR.T("Документ");

	private readonly string folderTypeName = SR.T("Папка");

	private readonly List<Guid> adminPermissions = new List<Guid>
	{
		PermissionProvider.DocumentFullAccessPermission.Id,
		PermissionProvider.DocumentManagerAccessPermission.Id
	};

	public ISecurityService SecurityService { get; set; }

	public DmsObjectManager DmsObjectManager { get; set; }

	public bool CanUse(Guid typeUid)
	{
		return MetadataLoader.IsBaseOrChildClass(InterfaceActivator.UID<IDmsObject>(), typeUid);
	}

	public void GrantAccess(object entity, IEnumerable<Permission> grantedAccess, EleWise.ELMA.Security.Models.IUser user)
	{
		DmsObjectManager.AddPermissionsToUser(entity as IDmsObject, grantedAccess, user);
	}

	public string GetTaskSubject(object entity)
	{
		string arg = ((entity is IFolder) ? taskSubjectForFolder : taskSubjectForDocument);
		return $"{arg} \"{entity.ToString()}\"";
	}

	public string GetCreatingTaskHeader(object entity)
	{
		string arg = ((entity is IFolder) ? creatingTaskForFolder : creatingTaskForDocument);
		return $"{arg} \"{entity.ToString()}\"";
	}

	public string GetObjectTypeName(object entity)
	{
		if (!(entity is IFolder))
		{
			return documentTypeName;
		}
		return folderTypeName;
	}

	public IEnumerable<EleWise.ELMA.Security.Models.IUser> GetAdmins(Guid entityTypeUid, long entityId)
	{
		return from EleWise.ELMA.Security.Models.IUser usr in SecurityService.GetUsersByPermissions(entityTypeUid, entityId, adminPermissions)
			where usr.Status != UserStatus.Blocked
			select usr;
	}
}
