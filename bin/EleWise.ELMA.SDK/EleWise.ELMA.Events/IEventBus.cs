using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Events;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEventBus
{
	IEnumerable Notify(string messageName, IDictionary<string, object> eventData);
}
