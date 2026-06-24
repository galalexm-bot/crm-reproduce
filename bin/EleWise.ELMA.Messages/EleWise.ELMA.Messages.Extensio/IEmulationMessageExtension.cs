using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IEmulationMessageExtension
{
	bool SendMessage(IMessageBase message, IEnumerable<IMessageChannel> messageChannel);
}
