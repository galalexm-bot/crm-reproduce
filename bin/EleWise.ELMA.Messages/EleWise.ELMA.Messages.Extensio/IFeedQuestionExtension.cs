using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFeedQuestionExtension
{
	bool QuestionIsSupported(Guid objectUid);

	void CanCreateQuestion(Guid objectUid, Dictionary<long, bool> items);

	Guid CreateQuestion(Guid objectUid, long objectId, string text, IUser executor, MessageAttachment[] messageAttachments, bool showAll);
}
