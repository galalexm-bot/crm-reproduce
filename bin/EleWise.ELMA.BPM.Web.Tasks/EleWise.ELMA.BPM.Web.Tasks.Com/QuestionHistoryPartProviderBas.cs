using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

public abstract class QuestionHistoryPartProviderBase : IHistoryPartProvider
{
	public const string HistoryPartType = "question";

	public virtual IEnumerable<HistoryPartButton> GetButtons(HtmlHelper html, IEntity entity)
	{
		if (CheckEntity(html, entity))
		{
			yield return new HistoryPartButton
			{
				HistoryPartType = "question",
				ImageUrl = html.Url().Image("#question.svg"),
				Index = 50,
				Text = SR.T("Вопросы")
			};
		}
	}

	protected abstract bool CheckEntity(HtmlHelper html, IEntity entity);

	protected virtual MvcHtmlString RenderDelegate(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (eventData is IQuestionedHistoryModel && ((IQuestionedHistoryModel)eventData).Question != null)
		{
			return PartialExtensions.Partial(html, "HistoryParts/Question", (object)eventData);
		}
		return null;
	}

	public virtual IEnumerable<HistoryPartViewBlock> GetBlocks(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (CheckEventData(html, eventData))
		{
			yield return new HistoryPartViewBlock
			{
				HistoryPartType = "question",
				Index = 50,
				RenderDelegate = RenderDelegate
			};
		}
	}

	protected virtual bool CheckEventData(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (eventData is IQuestionedHistoryModel eventData2)
		{
			return CheckEventActionObject(html, eventData2);
		}
		return false;
	}

	protected abstract bool CheckEventActionObject(HtmlHelper html, IQuestionedHistoryModel eventData);
}
