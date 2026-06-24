using System;

namespace EleWise.ELMA.Messages.Models.Chats;

internal interface IChatParticipant
{
	Guid Uid { get; set; }

	Guid UserUid { get; set; }

	long UnreadCount { get; set; }

	string LastReadHash { get; set; }

	bool IsFavorite { get; set; }

	bool IsMute { get; set; }
}
