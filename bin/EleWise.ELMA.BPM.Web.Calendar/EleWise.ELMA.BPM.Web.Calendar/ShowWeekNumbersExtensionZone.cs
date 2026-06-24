using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component]
public class ShowWeekNumbersExtensionZone : IExtensionZone
{
	public const string ZoneId = "BeforeContentZone";

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		if ("BeforeContentZone" != zoneId)
		{
			return false;
		}
		CalendarSettingsModule serviceNotNull = Locator.GetServiceNotNull<CalendarSettingsModule>();
		if (serviceNotNull.Settings != null)
		{
			return serviceNotNull.Settings.ShowWeekNumbers;
		}
		return false;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		RenderPartialExtensions.RenderPartial(html, "Shared/ShowWeekNumbersExtensionZone");
	}
}
