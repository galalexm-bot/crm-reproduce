using System.Collections.Generic;
using EleWise.ELMA.Events;

namespace Orchard.Messaging.Services;

public interface IMessageService : IEventHandler
{
	void Send(string type, IDictionary<string, object> parameters);
}
