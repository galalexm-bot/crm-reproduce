using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.Feed;

[Component(Order = 500)]
public class ClosedQuestionFeedMessageGetDataExtension : IFeedMessageGetData
{
	public static string EventName = "CloseQuestionEvent";

	public string Name => EventName;

	public bool IsSupport(Guid objectUid, Guid actionUid)
	{
		if (MetadataLoader.IsBaseOrChildClass<IQuestion>(objectUid))
		{
			return actionUid == QuestionActions.CloseGuid;
		}
		return false;
	}

	public List<long> GetRecipients(IEntity entity, Guid actionUid)
	{
		if (!(entity is IQuestion question) || question.Executor == null)
		{
			return null;
		}
		return new List<long> { question.Executor.Id };
	}

	public List<Pair<long, List<WebDataItem>>> GetData(FeedMessageInfoParameters info, List<long> recipients)
	{
		if (!IsSupport(info.ObjectUid, info.ActionUid))
		{
			return null;
		}
		return QuestionManager.Instance.GetQuestionFeedInfo(info.ObjectUid, info.ObjectId);
	}
}
