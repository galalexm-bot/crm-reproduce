using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.Services;

internal interface IMessageChannelSenderService
{
	void Send(IMessageBase message, IMessageChannel messageChannel);
}
