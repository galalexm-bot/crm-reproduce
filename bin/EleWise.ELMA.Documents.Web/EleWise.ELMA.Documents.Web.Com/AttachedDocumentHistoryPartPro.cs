using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class AttachedDocumentHistoryPartProviderBase : IHistoryPartProvider
{
	public virtual IEnumerable<HistoryPartButton> GetButtons(HtmlHelper html, IEntity entity)
	{
		return new HistoryPartButton[0];
	}

	protected virtual MvcHtmlString RenderDelegate(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (eventData.EventData.DocumentAttachments is IEnumerable<IDocumentAttachment> enumerable)
		{
			return PartialExtensions.Partial(html, "HistoryParts/DocumentAttachments", (object)enumerable);
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
				Index = 105,
				RenderDelegate = RenderDelegate
			};
		}
	}

	protected virtual bool CheckEventData(HtmlHelper html, IHistoryBaseModel eventData)
	{
		IAttachedHistoryModel attachedHistoryModel = eventData as IAttachedHistoryModel;
		return attachedHistoryModel != null && eventData.EventData.DocumentAttachments != null;
	}
}
