using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFeedCommentExtension
{
	bool CommentIsSupported(Guid objectUid);

	bool IsCommentAction(Guid objectUid, Guid actionUid);

	void CanCreateComment(Guid objectUid, Dictionary<long, bool> items);

	void CanCreateComment(List<CanCreateCommentItemMessage> objects);

	Guid CreateComment(Guid objectUid, long objectId, string text, MessageAttachment[] messageAttachments);
}
