using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Notifications;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface INotificationMessageHandler : IEventHandler
{
	void ProcessNotificationToMessage(INotification notification, IMessage message);
}
