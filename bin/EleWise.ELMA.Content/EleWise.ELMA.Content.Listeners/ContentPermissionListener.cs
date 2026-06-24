using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Security.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Content.Listeners;

[Component]
internal class ContentPermissionListener : UserGroupListener
{
	public override void DeletePermissions(PreDeleteEvent @event)
	{
		DeletePermission(@event, (IMenuItemPermission a) => a.Group);
		DeletePermission(@event, (IPortalObjectPermission a) => a.Group);
	}
}
