namespace Orchard.Localization.Models;

public class DateLocalizationOptions
{
	public string NullText { get; set; }

	public bool EnableTimeZoneConversion { get; set; }

	public bool EnableCalendarConversion { get; set; }

	public bool IgnoreDate { get; set; }

	public DateLocalizationOptions()
	{
		NullText = string.Empty;
		EnableTimeZoneConversion = true;
		EnableCalendarConversion = true;
		IgnoreDate = false;
	}
}
