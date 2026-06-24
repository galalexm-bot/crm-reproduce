using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
internal class MultipleHistoryPartProvider : IHistoryPartProvider
{
	private const string HistoryPartType = "multipleEvent";

	private const int ProviderIndex = 100;

	public IEnumerable<HistoryPartViewBlock> GetBlocks(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (CheckEventData(eventData))
		{
			yield return new HistoryPartViewBlock
			{
				HistoryPartType = "multipleEvent",
				Index = 100,
				RenderDelegate = RenderDelegate
			};
		}
	}

	public IEnumerable<HistoryPartButton> GetButtons(HtmlHelper html, IEntity entity)
	{
		return Enumerable.Empty<HistoryPartButton>();
	}

	private bool CheckEventData(IHistoryBaseModel eventData)
	{
		return eventData.OriginalEvent.Multiple;
	}

	private MvcHtmlString RenderDelegate(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (CheckEventData(eventData))
		{
			return PartialExtensions.Partial(html, "HistoryParts/MultipleEvent", (object)eventData);
		}
		return MvcHtmlString.Empty;
	}
}
