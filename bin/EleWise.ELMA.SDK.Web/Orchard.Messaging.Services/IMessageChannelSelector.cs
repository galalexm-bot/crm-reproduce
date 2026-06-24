namespace Orchard.Messaging.Services;

public interface IMessageChannelSelector : IDependency
{
	MessageChannelSelectorResult GetChannel(string messageType, object payload);
}
