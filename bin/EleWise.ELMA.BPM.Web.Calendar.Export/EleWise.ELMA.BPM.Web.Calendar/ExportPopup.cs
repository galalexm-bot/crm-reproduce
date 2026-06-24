using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Calendar.Export.Extensions;

[Component(EnableInterceptiors = false, InjectProerties = false)]
public class ExportPopup : IExtensionZone
{
	private static readonly List<string> zones = new List<string> { "EleWise.ELMA.BPM.Web.Calendar.Scheduler.Index" };

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zones.Contains(zoneId);
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zones.Contains(zoneId))
		{
			html.get_ViewContext().get_Writer().Write(html.PopupWindow("ExportSchedulePopup", SR.T("Экспорт в формате iCalendar"), (object m) => PartialExtensions.Partial(html, "Export/ExportPopup"), 405));
			html.get_ViewContext().get_Writer().Write(html.PopupWindow("QuickInternetCalPopup", SR.T("Интернет-календарь"), (object m) => PartialExtensions.Partial(html, "InternetCalendar/QuickInternetCalPopup"), 800));
		}
	}
}
