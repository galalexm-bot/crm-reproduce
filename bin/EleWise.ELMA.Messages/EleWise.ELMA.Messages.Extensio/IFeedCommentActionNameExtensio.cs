using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFeedCommentActionNameExtension
{
	bool IsSupport(Guid objectTypeUid, Guid actionUid);

	string ActionName(FeedModel message);
}
