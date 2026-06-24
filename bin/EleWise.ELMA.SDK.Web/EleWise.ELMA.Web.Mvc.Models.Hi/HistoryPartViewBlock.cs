using System;
using System.Web.Mvc;
using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Web.Mvc.Models.History;

public class HistoryPartViewBlock
{
	public int Index { get; set; }

	public string HistoryPartType { get; set; }

	public Func<HtmlHelper, IHistoryBaseModel, object> RenderDelegate { get; set; }

	public virtual MvcHtmlString Render(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (RenderDelegate != null)
		{
			object obj = RenderDelegate(html, eventData);
			if (obj != null)
			{
				return MvcHtmlString.Create(obj.ToString());
			}
		}
		return MvcHtmlString.Empty;
	}
}
