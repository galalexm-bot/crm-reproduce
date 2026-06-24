using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Helpers;
using EleWise.ELMA.Messages.Impl.Actors;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Messages.Listeners;

[Component]
internal class InformationChannelPermissionListener : UserGroupListener
{
	public IActorEventPublisher ActorEventPublisher { get; set; }

	public override void DeletePermissions(PreDeleteEvent @event)
	{
		DeletePermission(@event, (IInformationChannelPermission a) => a.Group);
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		IInformationChannelPermission informationChannelPermissionFromEvent = GetInformationChannelPermissionFromEvent((AbstractPostDatabaseOperationEvent)(object)@event);
		if (informationChannelPermissionFromEvent != null && SR.GetSetting("ELMAChat.Enabled", defaultValue: false))
		{
			PublishActorEventsOnInsert(informationChannelPermissionFromEvent);
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		IInformationChannelPermission informationChannelPermissionFromEvent = GetInformationChannelPermissionFromEvent((AbstractPostDatabaseOperationEvent)(object)@event);
		if (informationChannelPermissionFromEvent != null && SR.GetSetting("ELMAChat.Enabled", defaultValue: false))
		{
			PublishActorEventsOnDelete(informationChannelPermissionFromEvent);
		}
	}

	private IInformationChannelPermission GetInformationChannelPermissionFromEvent(AbstractPostDatabaseOperationEvent @event)
	{
		if (@event == null)
		{
			return null;
		}
		return @event.get_Entity() as IInformationChannelPermission;
	}

	private void PublishActorEventsOnInsert(IInformationChannelPermission channelPermission)
	{
		if (channelPermission.User != null)
		{
			PublishChannelEvents(ChatActorEvents.AddUserToChannelUidEvent, ChatActorEvents.AddedUser, channelPermission.User.Id, channelPermission.Channel);
		}
		if (channelPermission.Group != null)
		{
			PublishChannelEvents(ChatActorEvents.AddGroupToChannelUidEvent, ChatActorEvents.AddedGroup, channelPermission.Group.Id, channelPermission.Channel);
		}
		if (channelPermission.OrganizationItem != null)
		{
			PublishChannelEvents(ChatActorEvents.AddOrgItemToChannelUidEvent, ChatActorEvents.AddedOrgItem, channelPermission.OrganizationItem.Id, channelPermission.Channel);
		}
		if (channelPermission.OrganizationItemPosition != null)
		{
			PublishChannelEvents(ChatActorEvents.AddOrgItemToChannelUidEvent, ChatActorEvents.AddedOrgItem, channelPermission.OrganizationItemPosition.Id, channelPermission.Channel);
		}
	}

	private void PublishActorEventsOnDelete(IInformationChannelPermission channelPermission)
	{
		if (channelPermission.User != null)
		{
			PublishChannelEvents(ChatActorEvents.DeleteUserFromChannelUidEvent, ChatActorEvents.DeletedUser, channelPermission.User.Id, channelPermission.Channel);
		}
		if (channelPermission.Group != null)
		{
			PublishChannelEvents(ChatActorEvents.DeleteGroupFromChannelUidEvent, ChatActorEvents.DeletedGroup, channelPermission.Group.Id, channelPermission.Channel);
		}
		if (channelPermission.OrganizationItem != null)
		{
			PublishChannelEvents(ChatActorEvents.DeleteOrgItemFromChannelUidEvent, ChatActorEvents.DeletedOrgItem, channelPermission.OrganizationItem.Id, channelPermission.Channel);
		}
		if (channelPermission.OrganizationItemPosition != null)
		{
			PublishChannelEvents(ChatActorEvents.DeleteOrgItemFromChannelUidEvent, ChatActorEvents.DeletedOrgItem, channelPermission.OrganizationItemPosition.Id, channelPermission.Channel);
		}
	}

	private void PublishChannelEvents(Guid eventId, string eventNamespace, long itemId, IInformationChannel channel)
	{
		PublishActorEvent(eventId, eventNamespace, itemId, channel.Id);
		PublishActorEvent(eventId, ChatActorEvents.UpdatedChannel, channel.Uid, channel.Id);
	}

	private void PublishActorEvent(Guid eventId, string eventNamespace, object itemId, long data)
	{
		ActorEventPublisher.PublishActorEvent(eventId, $"{eventNamespace}_{itemId.ToString()}", data).ConfigureAwait(continueOnCapturedContext: false);
	}
}
