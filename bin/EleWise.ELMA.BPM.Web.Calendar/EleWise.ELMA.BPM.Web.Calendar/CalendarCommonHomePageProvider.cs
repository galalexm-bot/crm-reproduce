using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component(Order = 10)]
public class CalendarCommonHomePageProvider : ICommonHomePageProvider, IModuleSettingsPageProvider
{
	public string ModuleUid => "EleWise.ELMA.Calendar";

	public string Image => "#calendar.svg";

	public string Text => SR.T("Календари");

	public string Description => SR.T("Раздел позволяет настроить общие календари системы для совместного использования при планировании");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("CalendarSettingsPage", "Admin", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Calendar"
		});
	}
}
