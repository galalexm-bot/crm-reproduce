using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 10)]
public abstract class CommentAttachmentHistoryPartMerge : IHistoryPartMerge
{
	public HistoryPartMergedButton GetMergeButton(HtmlHelper html, IEntity entity)
	{
		if (CheckEntity(html, entity))
		{
			HistoryPartButton button = new HistoryPartButton
			{
				Index = 10,
				Text = SR.T("Комментарии и вложения")
			};
			return new HistoryPartMergedButton
			{
				Button = button,
				HistoryPartTypes = new List<string> { "comment", "attachment" }
			};
		}
		return null;
	}

	protected abstract bool CheckEntity(HtmlHelper html, IEntity entity);
}
