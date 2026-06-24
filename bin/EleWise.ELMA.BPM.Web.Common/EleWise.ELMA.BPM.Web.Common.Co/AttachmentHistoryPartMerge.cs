using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public abstract class AttachmentHistoryPartMerge : IHistoryPartMerge
{
	public HistoryPartMergedButton GetMergeButton(HtmlHelper html, IEntity entity)
	{
		if (CheckEntity(html, entity))
		{
			HistoryPartButton button = new HistoryPartButton
			{
				Index = int.MaxValue,
				Text = SR.T("Действия")
			};
			return new HistoryPartMergedButton
			{
				Button = button,
				HistoryPartTypes = new List<string> { "action", "attachment" }
			};
		}
		return null;
	}

	protected abstract bool CheckEntity(HtmlHelper html, IEntity entity);
}
