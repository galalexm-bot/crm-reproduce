using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class InpaymentQuestionsHistoryPartProvider : QuestionHistoryPartProviderBase
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is IInpayment;
	}

	protected override bool CheckEventActionObject(HtmlHelper html, IQuestionedHistoryModel eventData)
	{
		return eventData is IInpaymentHistoryBaseModel;
	}
}
