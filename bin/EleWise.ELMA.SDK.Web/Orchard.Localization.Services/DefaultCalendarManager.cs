using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Orchard.Localization.Services;

public class DefaultCalendarManager : ICalendarManager, IDependency
{
	private readonly IEnumerable<ICalendarSelector> _calendarSelectors;

	public DefaultCalendarManager(IEnumerable<ICalendarSelector> calendarSelectors)
	{
		_calendarSelectors = calendarSelectors;
	}

	public IEnumerable<string> ListCalendars()
	{
		return new string[14]
		{
			"ChineseLunisolarCalendar", "GregorianCalendar", "HebrewCalendar", "HijriCalendar", "JapaneseCalendar", "JapaneseLunisolarCalendar", "JulianCalendar", "KoreanCalendar", "KoreanLunisolarCalendar", "PersianCalendar",
			"TaiwanCalendar", "TaiwanLunisolarCalendar", "ThaiBuddhistCalendar", "UmAlQuraCalendar"
		};
	}

	public string GetCurrentCalendar(HttpContextBase requestContext)
	{
		IOrderedEnumerable<CalendarSelectorResult> orderedEnumerable = from x in _calendarSelectors
			select x.GetCalendar(requestContext) into x
			where x != null
			orderby x.Priority descending
			select x;
		if (!orderedEnumerable.Any())
		{
			return string.Empty;
		}
		foreach (CalendarSelectorResult item in orderedEnumerable)
		{
			if (!string.IsNullOrEmpty(item.CalendarName))
			{
				return item.CalendarName;
			}
		}
		return string.Empty;
	}

	public Calendar GetCalendarByName(string calendarName)
	{
		return calendarName switch
		{
			"ChineseLunisolarCalendar" => new ChineseLunisolarCalendar(), 
			"GregorianCalendar" => new GregorianCalendar(), 
			"HebrewCalendar" => new HebrewCalendar(), 
			"HijriCalendar" => new HijriCalendar(), 
			"JapaneseCalendar" => new JapaneseCalendar(), 
			"JapaneseLunisolarCalendar" => new JapaneseLunisolarCalendar(), 
			"JulianCalendar" => new JulianCalendar(), 
			"KoreanCalendar" => new KoreanCalendar(), 
			"KoreanLunisolarCalendar" => new KoreanLunisolarCalendar(), 
			"PersianCalendar" => new PersianCalendar(), 
			"TaiwanCalendar" => new TaiwanCalendar(), 
			"TaiwanLunisolarCalendar" => new TaiwanLunisolarCalendar(), 
			"ThaiBuddhistCalendar" => new ThaiBuddhistCalendar(), 
			"UmAlQuraCalendar" => new UmAlQuraCalendar(), 
			_ => throw new ArgumentException($"The calendar name '{calendarName}' is not a recognized System.Globalization calendar name.", "calendarName"), 
		};
	}
}
