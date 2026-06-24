using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
internal class DmsObjectInheritPermissionsListener : PostFlushEventListener
{
	public DmsObjectManager DmsObjectManager { get; set; }

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		IDmsObject dmsObject = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IDmsObject;
		if (dmsObject == null)
		{
			return;
		}
		if (ContextVars.TryGetValue<bool>("EleWise.ELMA.Documents.Listeners.DmsObjectPermissionChangeListener.ApplyInheritPermissions" + dmsObject.Id, out var value))
		{
			DmsObjectManager.EnableInheritPermissions(dmsObject, value);
		}
		if (ContextVars.TryGetValue<bool>("EleWise.ELMA.Documents.Listeners.DmsObjectPermissionChangeListener.ChangePermissionsWhenChangeFolder" + dmsObject.Id, out value))
		{
			int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject o) => o.Folder)));
			((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).Where((IDmsObjectPermission p) => p.InheritedFromFolder != null).ToArray().ForEach(delegate(IDmsObjectPermission p)
			{
				p.Delete();
				((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(p);
			});
			if (value)
			{
				DmsObjectManager.AddPermissionsFromParent(dmsObject, (IFolder)@event.get_State()[num]);
			}
			dmsObject.Save();
		}
	}
}
