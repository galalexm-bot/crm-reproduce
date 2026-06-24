using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class WorklogItemQuestionsHistoryPartProvider : QuestionHistoryPartProviderBase
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is IWorkLogItem;
	}

	protected override bool CheckEventActionObject(HtmlHelper html, IQuestionedHistoryModel eventData)
	{
		return eventData is IWorkLogItemHistoryBaseModel;
	}
}
