using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public abstract class AttachmentHistoryPartProviderBase : IHistoryPartProvider
{
	public const string HistoryPartType = "attachment";

	public virtual IEnumerable<HistoryPartButton> GetButtons(HtmlHelper html, IEntity entity)
	{
		if (CheckEntity(html, entity))
		{
			yield return new HistoryPartButton
			{
				HistoryPartType = "attachment",
				ImageUrl = html.Url().Image("#attachment.svg"),
				Index = 100,
				Text = SR.T("Вложения")
			};
		}
	}

	protected abstract bool CheckEntity(HtmlHelper html, IEntity entity);

	protected virtual MvcHtmlString RenderDelegate(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (eventData is IAttachedHistoryModel && ((IAttachedHistoryModel)eventData).Attachments != null)
		{
			return PartialExtensions.Partial(html, "HistoryParts/Attachments", (object)eventData);
		}
		return null;
	}

	public virtual IEnumerable<HistoryPartViewBlock> GetBlocks(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (CheckEventData(html, eventData))
		{
			yield return new HistoryPartViewBlock
			{
				HistoryPartType = "attachment",
				Index = 100,
				RenderDelegate = RenderDelegate
			};
		}
	}

	protected virtual bool CheckEventData(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (eventData is IAttachedHistoryModel eventData2)
		{
			return CheckEventActionObject(html, eventData2);
		}
		return false;
	}

	protected abstract bool CheckEventActionObject(HtmlHelper html, IAttachedHistoryModel eventData);
}
