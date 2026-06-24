using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Events;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEventBusAsync : IEventBus
{
	Task<IEnumerable> NotifyAsync(string messageName, IDictionary<string, object> eventData, CancellationToken cancellationToken = default(CancellationToken));
}
