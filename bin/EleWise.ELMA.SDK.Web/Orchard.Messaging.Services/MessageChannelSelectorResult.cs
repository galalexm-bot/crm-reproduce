using System;

namespace Orchard.Messaging.Services;

public class MessageChannelSelectorResult
{
	public int Priority { get; set; }

	public Func<IMessageChannel> MessageChannel { get; set; }
}
