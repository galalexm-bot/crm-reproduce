using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Helpers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Security;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using NHibernate.Event;

namespace EleWise.ELMA.CRM.Listeners;

[Component]
internal class MarketingObjectPermissionChangeListener : EntityEventsListener
{
	public override void OnPostDelete(PostDeleteEvent @event)
	{
		if (@event != null && ((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IMarketingPersonPermission marketingPermission)
		{
			RemovePermissionsInheritedFrom(marketingPermission);
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (@event != null && ((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IMarketingPersonPermission marketingPermission)
		{
			ApplyPermissionToMarketingObjectTree(marketingPermission);
		}
	}

	private void ApplyPermissionToMarketingObjectTree(IMarketingPersonPermission marketingPermission)
	{
		foreach (IMarketingBase item in MarketingObjectsWalker.GetDescendantsWithEnabledInheritance(marketingPermission.MarketingObject))
		{
			MarketingObjectPermissionsCreator.CreateInheritedPermission(marketingPermission, item).Save();
		}
	}

	private void RemovePermissionsInheritedFrom(IMarketingPersonPermission marketingPermission)
	{
		IMarketingPersonPermissionFilter marketingPersonPermissionFilter = InterfaceActivator.Create<IMarketingPersonPermissionFilter>();
		marketingPersonPermissionFilter.PermissionSource = marketingPermission.MarketingObject;
		marketingPersonPermissionFilter.PermissionId = marketingPermission.PermissionId;
		marketingPersonPermissionFilter.PermissionRole = marketingPermission.PermissionRole;
		foreach (IMarketingPersonPermission item in EntityManager<IMarketingPersonPermission>.Instance.Find(marketingPersonPermissionFilter, null))
		{
			if (item.TypeRoleId == CommonRoleTypes.Author.Id || (item.UserSecuritySetCacheId == marketingPermission.UserSecuritySetCacheId && object.Equals(item.Assigned, marketingPermission.Assigned)))
			{
				item.Delete();
			}
		}
	}
}
