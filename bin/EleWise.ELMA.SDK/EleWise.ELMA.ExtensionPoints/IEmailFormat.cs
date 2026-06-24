using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Notifications;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEmailFormat
{
	string Name { get; }

	string DisplayName { get; }

	string SubjectPrefix { get; }

	IEnumerable<Pair<INotificationFlow, IMessageChannel>> AllowPairs { get; }

	void Prepare(IMessage message);
}
