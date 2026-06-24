using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFeedAttachmentsExtension
{
	Guid TypeUid { get; }

	Dictionary<MessageAttachment, object> GetAttachments(List<MessageAttachment> messageAttachments);

	string SerializeAttachment(MessageAttachment messageAttachment);
}
