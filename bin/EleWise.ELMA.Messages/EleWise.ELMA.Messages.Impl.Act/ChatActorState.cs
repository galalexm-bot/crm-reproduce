using System;
using System.Collections.Generic;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Messages.Models.Chats;

namespace EleWise.ELMA.Messages.Impl.Actors.ActorStates;

internal sealed class ChatActorState
{
	public Guid Uid { get; set; }

	public string Subject { get; set; }

	public DateTime CreationDate { get; set; }

	public Guid Avatar { get; set; }

	public ChatTypeEnum Type { get; set; }

	public ICollection<UserDTO> Recipients { get; set; }

	public ParticipantsDTO Participants { get; set; }

	public ICollection<MessageActorState> Messages { get; set; }

	public ICollection<InformationChannelDTO> Channels { get; set; }

	public DateTime LastActivity { get; set; }

	public string LastHash { get; set; }

	public Dictionary<long, ICollection<ISubscription>> UserGroupSubscriptions { get; set; } = new Dictionary<long, ICollection<ISubscription>>();


	public Dictionary<long, ICollection<ISubscription>> OrgItemsSubscriptions { get; set; } = new Dictionary<long, ICollection<ISubscription>>();


	public Dictionary<Guid, ICollection<ISubscription>> ChannelsSubscriptions { get; set; } = new Dictionary<Guid, ICollection<ISubscription>>();

}
