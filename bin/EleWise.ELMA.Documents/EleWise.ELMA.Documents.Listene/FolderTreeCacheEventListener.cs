using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
public class FolderTreeCacheEventListener : EntityEventsListener
{
	public override void OnPostInsert(PostInsertEvent @event)
	{
		ClearFolderTreeCache(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		ClearFolderTreeCache(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		ClearFolderTreeCache(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
	}

	private void ClearFolderTreeCache(object entity)
	{
		if (entity is IFolder || entity is IUserGroup || entity is IOrganizationItem || (entity is IDmsObjectPermission && ((IDmsObjectPermission)entity).DmsObject is IFolder) || entity is GroupPermission)
		{
			FolderManager.Instance.ClearFolderTreeCache();
		}
	}
}
