using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class TaskQuestionsHistoryPartProvider : QuestionHistoryPartProviderBase
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is ITaskBase;
	}

	protected override bool CheckEventActionObject(HtmlHelper html, IQuestionedHistoryModel eventData)
	{
		return eventData is ITaskHistoryBaseModel;
	}
}
