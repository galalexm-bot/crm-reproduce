using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Common.Listeners;

[Component]
internal class CommonPermissionListener : UserGroupListener
{
	public override void DeletePermissions(PreDeleteEvent @event)
	{
		DeletePermission(@event, (ICatalogAccess a) => a.Group);
		DeletePermission(@event, (IFilterPermission a) => a.Group);
	}
}
