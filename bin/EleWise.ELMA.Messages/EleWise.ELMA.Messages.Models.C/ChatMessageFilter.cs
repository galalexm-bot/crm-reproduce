using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Messages.Models.Chats;

public sealed class ChatMessageFilter
{
	public ICollection<Guid> ChatUids { get; set; }

	public ICollection<Guid> ChannelUids { get; set; }

	public ICollection<long> UserIds { get; set; }

	public DateTime? After { get; set; }

	public DateTime? Before { get; set; }
}
