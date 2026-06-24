using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
public class DocumentMetadataHeadListener : EntityEventsListener
{
	public override void OnPostInsert(PostInsertEvent @event)
	{
		ClearCreateableDocumentTypesCache(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		ClearCreateableDocumentTypesCache(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		ClearCreateableDocumentTypesCache(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
	}

	private void ClearCreateableDocumentTypesCache(object entity)
	{
		if (entity is IDocumentMetadataHead || entity is IDocumentMetadataProfile || entity is IUserGroup || entity is IOrganizationItem || entity is IDmsObjectDefaultPermissions || entity is GroupPermission || entity is EleWise.ELMA.Security.Models.IUser)
		{
			DocumentMetadataProfileManager.Instance.ClearCreateableDocumentTypesCache();
		}
	}
}
