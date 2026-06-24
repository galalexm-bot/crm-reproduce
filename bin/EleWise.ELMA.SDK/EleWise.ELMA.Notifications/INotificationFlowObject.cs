using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Notifications;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface INotificationFlowObject
{
	bool Can(Guid flowUid);

	IDictionary<Guid, Guid[]> Get();
}
