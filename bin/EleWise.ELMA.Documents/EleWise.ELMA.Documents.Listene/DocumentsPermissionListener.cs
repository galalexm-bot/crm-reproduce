using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Security.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
internal class DocumentsPermissionListener : UserGroupListener
{
	public override void DeletePermissions(PreDeleteEvent @event)
	{
		DeletePermission(@event, (IDmsObjectPermission a) => a.Group);
		DeletePermission(@event, (IDmsObjectDefaultPermissions a) => a.Group);
	}
}
