using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IChannelMessageObjectsExtension
{
	bool IsSupport(Guid objectTypeUid);

	List<MessageObject> UpdateMessageObjectsNames(List<MessageObject> messageObjects);
}
