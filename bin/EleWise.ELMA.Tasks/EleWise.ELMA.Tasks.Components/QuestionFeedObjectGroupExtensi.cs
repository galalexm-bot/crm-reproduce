using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.Feed;

[Component(Order = 500)]
public class QuestionFeedObjectGroupExtension : DefaultFeedObjectGroupExtension
{
	public override string MessageTypeCssClass => "FeedTypeQuestion";

	public override string CommentaryDescription => SR.T("Ответить на вопрос");

	public override bool IsSupport(Guid objectTypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IQuestion>(objectTypeUid);
	}
}
