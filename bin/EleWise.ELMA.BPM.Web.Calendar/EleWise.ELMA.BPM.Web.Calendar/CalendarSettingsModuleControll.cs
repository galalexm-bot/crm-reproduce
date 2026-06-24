using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component(Order = 220)]
public class CalendarSettingsModuleController : GlobalSettingsModuleControllerBase<CalendarSettings, CalendarSettingsModule>
{
	public CalendarSettingsModuleController(CalendarSettingsModule module)
		: base(module)
	{
	}
}
