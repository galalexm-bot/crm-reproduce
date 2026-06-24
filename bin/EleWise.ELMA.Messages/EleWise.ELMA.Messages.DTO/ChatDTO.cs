using System;
using System.Collections.Generic;
using EleWise.ELMA.Messages.Models.Chats;

namespace EleWise.ELMA.Messages.DTO;

public sealed class ChatDTO
{
	public Guid Uid { get; set; }

	public string Subject { get; set; }

	public Guid Avatar { get; set; }

	public ChatTypeEnum Type { get; set; }

	public long UnreadCount { get; set; }

	public string LastReadMessageHash { get; set; }

	public DateTime LastActivity { get; set; }

	public string LastMessageHash { get; set; }

	public bool IsFavorite { get; set; }

	public bool IsMute { get; set; }

	public bool IsMember { get; set; }

	public ICollection<InformationChannelDTO> Channels { get; set; }

	public ParticipantsDTO Participants { get; set; }
}
