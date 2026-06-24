using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IFeedMessageUpdateProvider
{
	bool CanUpdateMessage(Guid actionType, Guid objectType, long objectId);

	IFeedMessageUpdater GetMessageUpdater(Guid actionType, Guid objectType, long objectId);
}
