using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.Feed;

[Component(Order = 500)]
public class WorkLogItemFeedCommentActionNameExtension : DefaultFeedCommentActionNameExtension
{
	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		if (MetadataLoader.IsBaseOrChildClass<IWorkLogItem>(objectTypeUid))
		{
			if (!(actionUid == WorkLogItemActions.RedirectGuid))
			{
				return actionUid == DefaultEntityActions.DeleteGuid;
			}
			return true;
		}
		return false;
	}

	public override string ActionName(FeedModel message)
	{
		if (message == null)
		{
			return base.ActionName(message);
		}
		if (message.ActionUid == WorkLogItemActions.RedirectGuid)
		{
			return SR.T("Назначен согласующий");
		}
		if (message.ActionUid == DefaultEntityActions.DeleteGuid)
		{
			return SR.T("Трудозатраты удалены");
		}
		return base.ActionName(message);
	}
}
