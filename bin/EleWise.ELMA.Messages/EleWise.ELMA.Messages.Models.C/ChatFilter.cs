using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Messages.Models.Chats;

public sealed class ChatFilter
{
	public string Subject { get; set; }

	public ICollection<Guid> ChannelUids { get; set; }

	public DateTime? After { get; set; }

	public DateTime? Before { get; set; }
}
