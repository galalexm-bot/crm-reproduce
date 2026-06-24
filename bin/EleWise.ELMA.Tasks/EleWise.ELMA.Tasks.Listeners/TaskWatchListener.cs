using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Event;

namespace EleWise.ELMA.Tasks.Listeners;

[Component]
internal class TaskWatchListener : EntityEventsListener
{
	private List<Guid> typeUids;

	public List<Guid> TypeUids
	{
		get
		{
			if (typeUids == null)
			{
				EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<ITaskBase>()) as EntityMetadata;
				List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(entityMetadata);
				childClasses.Add(entityMetadata);
				typeUids = childClasses.Select((ClassMetadata cc) => cc.Uid).ToList();
			}
			return typeUids;
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		IWatch watch = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWatch;
		if (watch != null && TypeUids.Contains(watch.TypeUid))
		{
			ITaskBasePermission taskviewpermission = InterfaceActivator.Create<ITaskBasePermission>();
			Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
			{
				taskviewpermission.Target = TaskBaseManager.Instance.Load(Convert.ToInt64(watch.EntityId));
			});
			taskviewpermission.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(watch.User.Id);
			taskviewpermission.AllowChief = false;
			taskviewpermission.TypeRole = "Watcher";
			taskviewpermission.Save();
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IWatch watch && TypeUids.Contains(watch.TypeUid))
		{
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			Type type = InterfaceActivator.TypeOf<ITaskBasePermission>();
			string tableName = ((EntityMetadata)MetadataLoader.LoadMetadata(type)).TableName;
			ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession(string.Empty);
			((IQuery)session.CreateSQLQuery(string.Format("DELETE FROM {0} WHERE {1}=? AND {2}=? AND {3}=?", serviceNotNull.Dialect.QuoteIfNeeded(tableName), serviceNotNull.Dialect.QuoteIfNeeded("Target"), serviceNotNull.Dialect.QuoteIfNeeded("TypeRole"), serviceNotNull.Dialect.QuoteIfNeeded("UserSecuritySetCacheId")))).SetParameter<long>(0, Convert.ToInt64(watch.EntityId)).SetParameter<string>(1, "Watcher").SetParameter<long>(2, UserSecuritySetHelper.GetUserMask(watch.User.Id))
				.ExecuteUpdate(cleanUpCache: false);
			session.CleanUpCache(type);
		}
	}
}
