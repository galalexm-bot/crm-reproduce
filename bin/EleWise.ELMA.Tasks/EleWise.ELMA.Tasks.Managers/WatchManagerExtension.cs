using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Managers;

public class WatchManagerExtension : EntityExtensionManager<IWatch, IWatchExt, long, WatchManager>
{
	public TaskBaseManager TaskManager { get; set; }

	public UserManager UserManager { get; set; }

	public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	protected bool OnCanDeleteWatchesByUser(EleWise.ELMA.Security.Models.IUser user, object entityId, Guid typeUid, object result)
	{
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(InterfaceActivator.LoadMetadata<ITaskBase>() as EntityMetadata);
		if ((bool)result && childClasses.Any((ClassMetadata item) => item.Uid == typeUid))
		{
			long id = Convert.ToInt64(entityId);
			ITaskBase taskBase = TaskManager.LoadOrNull(id);
			EleWise.ELMA.Security.Models.IUser currentUser = UserManager.GetCurrentUser();
			if (taskBase.CreationAuthor.Id != currentUser.Id && taskBase.Executor.Id != currentUser.Id && !SecurityService.HasPermission(PermissionProvider.AccessToAllTasks) && user.Id != currentUser.Id && !UserManager.IsSubordinateUser(currentUser, user) && !UserManager.IsSubordinateUser(currentUser, taskBase.CreationAuthor))
			{
				return UserManager.IsSubordinateUser(currentUser, taskBase.Executor);
			}
			return true;
		}
		return (bool)result;
	}
}
