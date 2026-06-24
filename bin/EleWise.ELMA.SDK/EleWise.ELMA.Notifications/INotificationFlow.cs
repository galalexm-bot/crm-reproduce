using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Notifications;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface INotificationFlow
{
	Guid Uid { get; }

	string Name { get; }

	IEnumerable<INotificationFlowObject> FlowObjects { get; }
}
