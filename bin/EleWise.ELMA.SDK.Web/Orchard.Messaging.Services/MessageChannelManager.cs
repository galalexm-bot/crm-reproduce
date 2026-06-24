using System.Collections.Generic;
using System.Linq;

namespace Orchard.Messaging.Services;

public class MessageChannelManager : IMessageChannelManager, IDependency
{
	private readonly IEnumerable<IMessageChannelSelector> _messageChannelSelectors;

	public MessageChannelManager(IEnumerable<IMessageChannelSelector> messageChannelSelectors)
	{
		_messageChannelSelectors = messageChannelSelectors;
	}

	public IMessageChannel GetMessageChannel(string type, IDictionary<string, object> parameters)
	{
		return (from x in _messageChannelSelectors
			select x.GetChannel(type, parameters) into x
			where x != null
			orderby x.Priority descending
			select x).FirstOrDefault()?.MessageChannel();
	}
}
