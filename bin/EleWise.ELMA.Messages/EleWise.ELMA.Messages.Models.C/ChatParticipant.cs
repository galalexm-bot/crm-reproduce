using System;

namespace EleWise.ELMA.Messages.Models.Chats;

internal sealed class ChatParticipant : IChatParticipant
{
	public Guid Uid { get; set; }

	public Guid UserUid { get; set; }

	public long UnreadCount { get; set; }

	public string LastReadHash { get; set; }

	public bool IsFavorite { get; set; }

	public bool IsMute { get; set; }
}
