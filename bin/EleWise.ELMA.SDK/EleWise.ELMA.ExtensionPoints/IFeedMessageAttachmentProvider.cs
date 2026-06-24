using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IFeedMessageAttachmentProvider
{
	IEnumerable<MessageAttachment> GetMessageAtachments(IEntity target);
}
