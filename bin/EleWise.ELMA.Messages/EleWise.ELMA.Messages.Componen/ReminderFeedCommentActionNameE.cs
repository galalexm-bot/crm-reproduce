using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component(Order = 500)]
public class ReminderFeedCommentActionNameExtension : DefaultFeedCommentActionNameExtension
{
	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		return actionUid == ReminderActions.RemindGuid;
	}

	public override string ActionName(FeedModel message)
	{
		if (message != null && message.ActionUid == ReminderActions.RemindGuid)
		{
			return SR.T("Напоминание");
		}
		return base.ActionName(message);
	}
}
