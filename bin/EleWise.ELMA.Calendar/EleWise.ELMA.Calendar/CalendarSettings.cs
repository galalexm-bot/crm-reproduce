using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.Calendar;

public class CalendarSettings : GlobalSettingsBase
{
	internal class __Resources_CalendarSettings
	{
		public static string PeriodCreated => SR.T("На сколько периодов вперед создавать события");

		public static string EnablePrivateMode => SR.T("Использовать режим конфиденциальности");

		public static string ShowWeekNumbers => SR.T("Отображать номера недель");
	}

	[DisplayName(typeof(__Resources_CalendarSettings), "PeriodCreated")]
	public int PeriodCreated { get; set; }

	[DisplayName(typeof(__Resources_CalendarSettings), "EnablePrivateMode")]
	public bool EnablePrivateMode { get; set; }

	[DisplayName(typeof(__Resources_CalendarSettings), "ShowWeekNumbers")]
	public bool ShowWeekNumbers { get; set; }

	public CalendarSettings()
	{
		PeriodCreated = 20;
		EnablePrivateMode = false;
		ShowWeekNumbers = false;
	}
}
