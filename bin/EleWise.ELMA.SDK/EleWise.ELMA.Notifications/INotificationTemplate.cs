using System.Collections.Generic;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Notifications;

public interface INotificationTemplate
{
	IEnumerable<IMessageBase> Generate(INotification notification);
}
