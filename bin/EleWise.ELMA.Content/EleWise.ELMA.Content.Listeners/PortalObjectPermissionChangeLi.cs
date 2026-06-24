using System;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate;
using NHibernate.Event;

namespace EleWise.ELMA.Content.Listeners;

[Component]
internal class PortalObjectPermissionChangeListener : EntityEventsListener
{
	private readonly string nameOfinheritPermissions;

	private readonly string nameOfFolder;

	private readonly string nameOfPermissions;

	private bool _updateInheritedPermissions = true;

	public PostFlushActionRunner PostFlushActionRunner { get; set; }

	public new ISessionProvider SessionProvider { get; set; }

	public bool UpdateInheritedPermissions
	{
		get
		{
			return _updateInheritedPermissions;
		}
		set
		{
			_updateInheritedPermissions = value;
		}
	}

	public PortalObjectPermissionChangeListener()
	{
		nameOfinheritPermissions = LinqUtils.NameOf((Expression<Func<IPortalObject, object>>)((IPortalObject d) => d.InheritPermissions));
		nameOfFolder = LinqUtils.NameOf((Expression<Func<IPortalObject, object>>)((IPortalObject d) => d.Folder));
		nameOfPermissions = LinqUtils.NameOf((Expression<Func<IPortalObject, object>>)((IPortalObject d) => d.Permissions));
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (@event != null)
		{
			CheckPortalObjectPermission(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		if (@event != null)
		{
			CheckPortalObjectPermission(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (@event == null)
		{
			return;
		}
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IPortalObject portalObject)
		{
			int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameOfinheritPermissions);
			int num2 = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameOfFolder);
			if (!object.Equals(@event.get_OldState()[num], @event.get_State()[num]) || !object.Equals(@event.get_OldState()[num2], @event.get_State()[num2]))
			{
				UpdatePermissions(portalObject);
			}
		}
		else
		{
			CheckPortalObjectPermission(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
		}
	}

	public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
	{
		if (@event != null && ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IPortalObject portalObject && ((AbstractCollectionEvent)@event).get_Collection().get_Role() != null && ((AbstractCollectionEvent)@event).get_Collection().get_Role().EndsWith("." + nameOfPermissions))
		{
			UpdatePermissions(portalObject);
		}
	}

	private void CheckPortalObjectPermission(object entity)
	{
		if (entity is IPortalObjectPermission portalObjectPermission && portalObjectPermission.PortalObject != null)
		{
			UpdatePermissions(portalObjectPermission.PortalObject);
		}
	}

	private void UpdatePermissions(IPortalObject portalObject)
	{
		if (UpdateInheritedPermissions)
		{
			long id = portalObject.Id;
			bool onlyChildren = !portalObject.InheritPermissions;
			PostFlushActionRunner.Add("portalObject" + portalObject.Id, delegate
			{
				ISession session = SessionProvider.GetSession(string.Empty);
				IQuery namedQuery = session.GetNamedQuery("ExecUpdateInheritPortalObjectPermissions");
				namedQuery.SetParameter<long>("objId", id);
				namedQuery.SetParameter<bool>("onlyChildren", onlyChildren);
				namedQuery.ExecuteUpdate(cleanUpCache: false);
				session.CleanUpCache(typeof(IPortalObjectPermission));
			});
		}
	}
}
