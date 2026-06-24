using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFeedMessageObjectsExtension
{
	bool IsSupport(Guid objectTypeUid);

	Dictionary<MessageObject, object> GetMessageObjects(List<MessageObject> messageObjects);
}
