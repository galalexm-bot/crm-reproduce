using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Engine;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
internal class DmsObjectListener : EntityEventsListener
{
	private readonly string nameOfSortTypeId = LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject o) => o.SortTypeId));

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IDmsObject dmsObject)
		{
			long? num = dmsObject.SortTypeId;
			if (!num.HasValue)
			{
				int num2 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameOfSortTypeId);
				object[] state = @event.get_State();
				num = (dmsObject.SortTypeId = ((!(dmsObject is IFolder) && !(dmsObject is IFolderReference)) ? 1 : 0));
				state[num2] = num;
			}
		}
		return false;
	}

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		if (@event != null && ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IDmsObject dmsObject && ((ISessionImplementor)((AbstractEvent)@event).get_Session()).get_PersistenceContext().GetCollectionEntry(((AbstractCollectionEvent)@event).get_Collection()).get_Snapshot() is IEnumerable source)
		{
			List<IDmsObjectPermission> list = source.OfType<IDmsObjectPermission>().ToList();
			List<IDmsObjectPermission> list2 = ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).ToList();
			if (list.Count > 0 && !ComparePermissions(list, list2))
			{
				DmsObjectManager.Instance.SendChangeAccess(dmsObject, list, list2);
			}
		}
	}

	private bool ComparePermissions(List<IDmsObjectPermission> left, List<IDmsObjectPermission> right)
	{
		if (left.Where((IDmsObjectPermission e) => !right.Any((IDmsObjectPermission re) => re.DmsObject == e.DmsObject && re.Group == e.Group && re.OrganizationItemEmployee == e.OrganizationItemEmployee && re.OrganizationItemPosition == e.OrganizationItemPosition && re.PermissionId == e.PermissionId && re.PermissionRole == e.PermissionRole && re.User == e.User)).ToList().Count > 0)
		{
			return false;
		}
		if (right.Where((IDmsObjectPermission e) => !left.Any((IDmsObjectPermission re) => re.DmsObject == e.DmsObject && re.Group == e.Group && re.OrganizationItemEmployee == e.OrganizationItemEmployee && re.OrganizationItemPosition == e.OrganizationItemPosition && re.PermissionId == e.PermissionId && re.PermissionRole == e.PermissionRole && re.User == e.User)).ToList().Count > 0)
		{
			return false;
		}
		return true;
	}
}
