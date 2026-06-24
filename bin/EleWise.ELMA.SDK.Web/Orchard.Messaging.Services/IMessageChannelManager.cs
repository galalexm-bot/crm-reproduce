using System.Collections.Generic;

namespace Orchard.Messaging.Services;

public interface IMessageChannelManager : IDependency
{
	IMessageChannel GetMessageChannel(string type, IDictionary<string, object> parameters);
}
