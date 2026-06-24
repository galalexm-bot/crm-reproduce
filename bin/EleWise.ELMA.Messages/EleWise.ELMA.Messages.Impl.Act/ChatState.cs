using System;

namespace EleWise.ELMA.Messages.Impl.Actors.ActorStates;

internal sealed class ChatState
{
	public Guid Uid { get; set; }

	public long UnreadCount { get; set; }

	public string LastReadHash { get; set; }

	public bool IsFavorite { get; set; }

	public bool IsMute { get; set; }
}
