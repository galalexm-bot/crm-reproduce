using System;
using System.Collections.Generic;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Impl.Actors.ActorStates;

internal sealed class UserChatListActorState
{
	public IUser User { get; set; }

	public ICollection<ChatState> Chats { get; set; }

	public long UnreadMessagesCount { get; set; }

	public Dictionary<Guid, ISubscription> ChatSubscriptions { get; set; } = new Dictionary<Guid, ISubscription>();


	public Dictionary<long, ICollection<ISubscription>> UserGroupSubscriptions { get; set; } = new Dictionary<long, ICollection<ISubscription>>();


	public Dictionary<long, ICollection<ISubscription>> OrgItemsSubscriptions { get; set; } = new Dictionary<long, ICollection<ISubscription>>();


	public Dictionary<Guid, ICollection<ISubscription>> ChannelsSubscriptions { get; set; } = new Dictionary<Guid, ICollection<ISubscription>>();

}
