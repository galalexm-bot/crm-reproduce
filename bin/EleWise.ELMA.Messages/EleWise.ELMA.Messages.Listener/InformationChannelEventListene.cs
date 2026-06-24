using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Messages.Listeners;

[Component]
public class InformationChannelEventListener : PostFlushEventListener
{
	public IEnumerable<IInformationChannelGroupExtension> InformationChannelGroupExtensions { get; set; }

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (@event != null && ((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IInformationChannel informationChannel)
		{
			RefreshPermissionsCache(informationChannel);
			SetChannelGroup(informationChannel);
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (@event != null && ((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IInformationChannel channelGroup)
		{
			SetChannelGroup(channelGroup);
		}
	}

	public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
	{
		if (@event == null)
		{
			return;
		}
		if (((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IInformationChannel channel)
		{
			RefreshPermissionsCache(channel);
		}
		else
		{
			if (!(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IEntity) || ((AbstractCollectionEvent)@event).get_Collection() == null)
			{
				return;
			}
			Type type = ((object)((AbstractCollectionEvent)@event).get_Collection()).GetType();
			if (!type.IsGenericType || !type.GetGenericArguments().Any() || type.GetGenericTypeDefinition().FullName != "NHibernate.Collection.Generic.PersistentGenericSet`1" || type.GetGenericArguments()[0] != InterfaceActivator.TypeOf<IInformationChannel>() || ((AbstractCollectionEvent)@event).get_Collection().get_Owner().GetType() != InterfaceActivator.TypeOf<IChannelMessage>())
			{
				return;
			}
			foreach (IInformationChannel item in (IEnumerable<IInformationChannel>)((IChannelMessage)((AbstractCollectionEvent)@event).get_Collection().get_Owner()).Channels)
			{
				RefreshPermissionsCache(item);
			}
		}
	}

	private void RefreshPermissionsCache(IInformationChannel channel)
	{
		InformationChannelManager.Instance.RefreshPermissionsCache(channel);
	}

	private void SetChannelGroup(IInformationChannel channel)
	{
		IInformationChannelGroupExtension informationChannelGroupExtension = InformationChannelGroupExtensions.FirstOrDefault((IInformationChannelGroupExtension p) => p.IsSupport(channel));
		channel.GroupUid = (channel.IsArchive ? MessagesConstants.ArchiveInformationChannelGroup : (informationChannelGroupExtension?.GroupGuid(channel) ?? Guid.Empty));
		channel.Save();
	}
}
