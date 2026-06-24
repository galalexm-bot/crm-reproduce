using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public abstract class CommentHistoryPartMerge : IHistoryPartMerge
{
	public HistoryPartMergedButton GetMergeButton(HtmlHelper html, IEntity entity)
	{
		if (CheckEntity(html, entity))
		{
			HistoryPartButton button = new HistoryPartButton
			{
				Index = 10,
				Text = SR.T("Комментарии и вопросы")
			};
			return new HistoryPartMergedButton
			{
				Button = button,
				HistoryPartTypes = new List<string> { "comment", "question", "attachment" }
			};
		}
		return null;
	}

	protected abstract bool CheckEntity(HtmlHelper html, IEntity entity);
}
