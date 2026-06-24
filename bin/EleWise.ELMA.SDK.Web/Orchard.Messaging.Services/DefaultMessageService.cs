using System.Collections.Generic;
using EleWise.ELMA.Events;
using Orchard.Logging;

namespace Orchard.Messaging.Services;

public class DefaultMessageService : Component, IMessageService, IEventHandler
{
	private readonly IMessageChannelManager _messageChannelManager;

	public DefaultMessageService(IMessageChannelManager messageChannelManager)
	{
		_messageChannelManager = messageChannelManager;
	}

	public void Send(string type, IDictionary<string, object> parameters)
	{
		IMessageChannel messageChannel = _messageChannelManager.GetMessageChannel(type, parameters);
		if (messageChannel == null)
		{
			base.Logger.Information("No channels where found to process a message of type {0}", type);
		}
		else
		{
			messageChannel.Process(parameters);
		}
	}
}
