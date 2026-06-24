using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks.Managers;

namespace EleWise.ELMA.Tasks.Models;

public sealed class UserEditAccessRequestTaskHistoryModel : UserEditTaskHistoryModel
{
	private AccessRequestTaskManager accessRequestTaskManager;

	private AccessRequestTaskManager AccessRequestTaskManager => accessRequestTaskManager ?? (accessRequestTaskManager = AccessRequestTaskManager.Instance);

	public IEnumerable<Guid> AddedPermissions { get; internal set; }

	public IEnumerable<Guid> RemovedPermissions { get; internal set; }

	internal UserEditAccessRequestTaskHistoryModel(EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
		AddedPermissions = Enumerable.Empty<Guid>();
		RemovedPermissions = Enumerable.Empty<Guid>();
	}

	public string GetPermissionNames(IEnumerable<Guid> permissionUids)
	{
		IEnumerable<Permission> accessRequestPermissions = AccessRequestTaskManager.GetAccessRequestPermissions(permissionUids);
		return string.Join(", ", accessRequestPermissions.Select((Permission p) => p.Name));
	}
}
