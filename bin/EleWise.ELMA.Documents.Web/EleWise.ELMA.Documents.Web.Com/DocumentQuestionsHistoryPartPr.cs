using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentQuestionsHistoryPartProvider : QuestionHistoryPartProviderBase
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is IDocument;
	}

	protected override bool CheckEventActionObject(HtmlHelper html, IQuestionedHistoryModel eventData)
	{
		return eventData is IDocumentHistoryBaseModel;
	}
}
