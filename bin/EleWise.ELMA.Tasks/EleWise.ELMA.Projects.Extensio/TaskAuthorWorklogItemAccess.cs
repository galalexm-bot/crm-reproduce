using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints.WorkLog;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Projects.Extensions;

[Component]
internal class TaskAuthorWorklogItemAccess : IWorklogItemAccess
{
	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public ISecurityService SecurityService { get; set; }

	public bool HasPermission(Guid typeUid, long id)
	{
		if (!MetadataRuntimeService.GetTypeByUid(typeUid).IsInheritOrSame<ITaskBase>())
		{
			return false;
		}
		if (!(WorkLogExtensionHelper.LoadObject(id, typeUid) is ITaskBase taskBase))
		{
			return false;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (taskBase.CreationAuthor != currentUser)
		{
			return SecurityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.AdminWorklogPermission);
		}
		return true;
	}
}
