using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component(Order = 100000)]
public class DefaultFeedCommentActionNameExtension : IFeedCommentActionNameExtension
{
	public virtual bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		return true;
	}

	public virtual string ActionName(FeedModel message)
	{
		IAuditManager serviceNotNull = Locator.GetServiceNotNull<IAuditManager>();
		if (message != null && message.ParentObjectUid.HasValue)
		{
			IFeedCommentExtension feedCommentExtension = ComponentManager.Current.GetExtensionPoints<IFeedCommentExtension>().FirstOrDefault((IFeedCommentExtension p) => p.CommentIsSupported(message.ParentObjectUid.Value));
			if (feedCommentExtension != null && feedCommentExtension.IsCommentAction(message.ParentObjectUid.Value, message.ActionUid))
			{
				return string.Empty;
			}
		}
		if (message != null && message.ActionUid != Guid.Empty)
		{
			IAuditAction action = serviceNotNull.GetAction(message.ActionUid);
			if (action != null)
			{
				return action.DisplayName;
			}
		}
		return string.Empty;
	}
}
