using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Messages.Helpers;
using EleWise.ELMA.Messages.Impl.Actors;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Listeners;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Components;

[Component]
internal sealed class UserSecuritySetCacheUpdate : IUserSecuritySetCacheUpdateExtension, IEventHandler
{
	private readonly IActorEventPublisher actorEventPublisher;

	public UserSecuritySetCacheUpdate(IActorEventPublisher actorEventPublisher)
	{
		this.actorEventPublisher = actorEventPublisher;
	}

	public void OnUpdate(Dictionary<IUser, byte> users, Dictionary<IUserGroup, GroupUpdate> userGroups, Dictionary<IOrganizationItem, OrganizationItemUpdate> organizationItems)
	{
		if (SR.GetSetting("ELMAChat.Enabled", defaultValue: false))
		{
			if (userGroups != null)
			{
				PublishUserGroupEvents(userGroups);
			}
			if (organizationItems != null)
			{
				PublishOrgItemEvents(organizationItems);
			}
		}
	}

	private void PublishUserGroupEvents(Dictionary<IUserGroup, GroupUpdate> userGroups)
	{
		foreach (KeyValuePair<IUserGroup, GroupUpdate> userGroup in userGroups)
		{
			PublishEvents(userGroup.Value.AddUsers, ChatActorEvents.AddUserToGroupUidEvent, ChatActorEvents.UpdatedGroup, ChatActorEvents.AddedUser, userGroup.Key.Id);
			PublishEvents(userGroup.Value.RemoveUsers, ChatActorEvents.DeleteUserFromGroupUidEvent, ChatActorEvents.UpdatedGroup, ChatActorEvents.DeletedUser, userGroup.Key.Id);
			PublishEvents(userGroup.Value.AddGroups, ChatActorEvents.AddGroupToGroupUidEvent, ChatActorEvents.UpdatedGroup, ChatActorEvents.AddedGroup, userGroup.Key.Id);
			PublishEvents(userGroup.Value.RemoveGroups, ChatActorEvents.DeleteGroupFromGroupUidEvent, ChatActorEvents.UpdatedGroup, ChatActorEvents.DeletedGroup, userGroup.Key.Id);
			PublishEvents(userGroup.Value.AddOrganizationItems, ChatActorEvents.AddOrgItemToGroupUidEvent, ChatActorEvents.UpdatedGroup, ChatActorEvents.AddedOrgItem, userGroup.Key.Id);
			PublishEvents(userGroup.Value.RemoveOrganizationItems, ChatActorEvents.DeleteOrgItemFromGroupUidEvent, ChatActorEvents.UpdatedGroup, ChatActorEvents.DeletedOrgItem, userGroup.Key.Id);
		}
	}

	private void PublishOrgItemEvents(Dictionary<IOrganizationItem, OrganizationItemUpdate> organizationItems)
	{
		foreach (KeyValuePair<IOrganizationItem, OrganizationItemUpdate> organizationItem in organizationItems)
		{
			PublishEvents(organizationItem.Value.AddUsers, ChatActorEvents.AddUserToOrgItemUidEvent, ChatActorEvents.UpdatedOrgItem, ChatActorEvents.AddedUser, organizationItem.Key.Id);
			PublishEvents(organizationItem.Value.RemoveUsers, ChatActorEvents.DeleteUserFromOrgItemUidEvent, ChatActorEvents.UpdatedOrgItem, ChatActorEvents.DeletedUser, organizationItem.Key.Id);
		}
	}

	private void PublishEvents(long[] items, Guid eventId, string eventContainerNamespace, string eventItemNamespace, long containerId)
	{
		if (items != null && items.Any())
		{
			PublishActorEvent(eventId, $"{eventContainerNamespace}_{containerId}", items);
			foreach (long num in items)
			{
				PublishActorEvent(eventId, $"{eventItemNamespace}_{num}", containerId);
			}
		}
	}

	private void PublishActorEvent<T>(Guid eventId, string eventNamespace, T data)
	{
		actorEventPublisher.PublishActorEvent(eventId, eventNamespace, data);
	}
}
