using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
public class GroupPermissionListener : EntityEventsListener
{
	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is GroupPermission groupPermission && groupPermission.PermissionId == PermissionProvider.DocumentsFullAccessToAllObjectsPermission.Id)
		{
			Clear();
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is GroupPermission groupPermission && groupPermission.PermissionId == PermissionProvider.DocumentsFullAccessToAllObjectsPermission.Id)
		{
			Clear();
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is GroupPermission groupPermission && groupPermission.PermissionId == PermissionProvider.DocumentsFullAccessToAllObjectsPermission.Id)
		{
			Clear();
		}
	}

	private void Clear()
	{
		Locator.GetServiceNotNull<ISystemFoldersService>().ClearAll();
	}
}
