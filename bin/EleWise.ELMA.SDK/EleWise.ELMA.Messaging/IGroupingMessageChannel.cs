using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Messaging;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IGroupingMessageChannel : IMessageChannel
{
	void Send(IMessage message, IEnumerable<IUser> recipients);
}
