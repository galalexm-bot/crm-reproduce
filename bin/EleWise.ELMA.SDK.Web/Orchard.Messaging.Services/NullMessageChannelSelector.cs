namespace Orchard.Messaging.Services;

public class NullMessageChannelSelector : IMessageChannelSelector, IDependency
{
	public MessageChannelSelectorResult GetChannel(string messageType, object payload)
	{
		return null;
	}
}
