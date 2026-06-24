using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.Feed;

[Component(Order = 500)]
public class QuestionFeedCommentActionNameExtension : DefaultFeedCommentActionNameExtension
{
	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		if (MetadataLoader.IsBaseOrChildClass<IAnswer>(objectTypeUid))
		{
			return actionUid == DefaultEntityActions.CreateGuid;
		}
		return false;
	}

	public override string ActionName(FeedModel message)
	{
		return SR.T("Ответ на вопрос");
	}
}
