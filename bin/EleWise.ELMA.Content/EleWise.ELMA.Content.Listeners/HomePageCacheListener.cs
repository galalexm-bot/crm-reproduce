using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using NHibernate.Event;

namespace EleWise.ELMA.Content.Listeners;

[Component]
internal class HomePageCacheListener : EntityEventsListener
{
	public HomePageSettingManager HomePageSettingManager { get; set; }

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		if (@event != null)
		{
			ResetHomePageTabCache(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
		}
		return false;
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		if (@event != null)
		{
			if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IUserWorkPlace userWorkPlace && @event.get_OldState() != null && HomePageSettingManager != null)
			{
				int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), "WorkPlace");
				if (num >= 0 && ((@event.get_OldState()[num] != null) ? ((IWorkPlace)@event.get_OldState()[num]) : null) != userWorkPlace.WorkPlace)
				{
					HomePageSettingManager.ResetTabsCache(userWorkPlace);
				}
				return false;
			}
			if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IWorkPlace workPlace && @event.get_OldState() != null && HomePageSettingManager != null)
			{
				int num2 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), "WorkplacePages");
				if (num2 >= 0 && ((@event.get_OldState()[num2] != null) ? ((IWorkplacePages)@event.get_OldState()[num2]) : null) != workPlace.WorkplacePages)
				{
					HomePageSettingManager.ResetTabsCache();
				}
				return false;
			}
			ResetHomePageTabCache(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
		}
		return false;
	}

	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		if (@event != null)
		{
			ResetHomePageTabCache(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
		}
		return false;
	}

	private void ResetHomePageTabCache(object entity)
	{
		if (HomePageSettingManager != null && (entity is EleWise.ELMA.Security.Models.IUser || entity is IUserGroup || entity is IOrganizationItem || entity is GroupPermission || entity is IHomePageSetting || entity is IPortalObject || entity is IPortalObjectPermission))
		{
			HomePageSettingManager.ResetTabsCache();
		}
	}
}
