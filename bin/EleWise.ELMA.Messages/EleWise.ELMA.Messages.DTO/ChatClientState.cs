using System;

namespace EleWise.ELMA.Messages.DTO;

public sealed class ChatClientState
{
	public UserDTO CurrentUser { get; set; }

	public long UnreadCount { get; set; }

	public DateTime Date { get; set; }
}
