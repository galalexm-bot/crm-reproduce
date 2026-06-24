using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IFeedSetReadProvider
{
	void SetAsReadForObject(Guid objectUid, long objectId, long? recipientId = null);
}
