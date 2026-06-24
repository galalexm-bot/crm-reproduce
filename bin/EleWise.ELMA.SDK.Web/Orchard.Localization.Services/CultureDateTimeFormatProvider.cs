using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Orchard.Localization.Services;

public class CultureDateTimeFormatProvider : IDateTimeFormatProvider, IDependency
{
	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly ICalendarManager _calendarManager;

	public virtual string[] MonthNames => DateTimeFormat.MonthNames;

	public virtual string[] MonthNamesGenitive => DateTimeFormat.MonthGenitiveNames;

	public virtual string[] MonthNamesShort => DateTimeFormat.AbbreviatedMonthNames;

	public virtual string[] MonthNamesShortGenitive => DateTimeFormat.AbbreviatedMonthGenitiveNames;

	public virtual string[] DayNames => DateTimeFormat.DayNames;

	public virtual string[] DayNamesShort => DateTimeFormat.AbbreviatedDayNames;

	public virtual string[] DayNamesMin => DateTimeFormat.ShortestDayNames;

	public virtual string ShortDateFormat => DateTimeFormat.ShortDatePattern;

	public virtual string ShortTimeFormat => DateTimeFormat.ShortTimePattern;

	public virtual string ShortDateTimeFormat => DateTimeFormat.GetAllDateTimePatterns('g').First();

	public virtual string LongDateFormat => DateTimeFormat.LongDatePattern;

	public virtual string LongTimeFormat => DateTimeFormat.LongTimePattern;

	public virtual string LongDateTimeFormat => DateTimeFormat.FullDateTimePattern;

	public virtual IEnumerable<string> AllDateFormats
	{
		get
		{
			List<string> list = new List<string>();
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('d'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('D'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('m'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('y'));
			return list.Distinct();
		}
	}

	public virtual IEnumerable<string> AllTimeFormats
	{
		get
		{
			List<string> list = new List<string>();
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('t'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('T'));
			return list.Distinct();
		}
	}

	public virtual IEnumerable<string> AllDateTimeFormats
	{
		get
		{
			List<string> list = new List<string>();
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('f'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('F'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('g'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('G'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('o'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('r'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('s'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('u'));
			list.AddRange(DateTimeFormat.GetAllDateTimePatterns('U'));
			return list.Distinct();
		}
	}

	public virtual int FirstDay => Convert.ToInt32(DateTimeFormat.FirstDayOfWeek);

	public virtual bool Use24HourTime
	{
		get
		{
			if (ShortTimeFormat.Contains("H"))
			{
				return true;
			}
			return false;
		}
	}

	public virtual string DateSeparator => DateTimeFormat.DateSeparator;

	public virtual string TimeSeparator => DateTimeFormat.TimeSeparator;

	public virtual string AmPmPrefix => " ";

	public virtual string[] AmPmDesignators => new string[2] { DateTimeFormat.AMDesignator, DateTimeFormat.PMDesignator };

	protected virtual DateTimeFormatInfo DateTimeFormat
	{
		get
		{
			CultureInfo currentCulture = CurrentCulture;
			Calendar currentCalendar = CurrentCalendar;
			if (!currentCulture.DateTimeFormat.Calendar.GetType().IsInstanceOfType(currentCalendar))
			{
				Calendar[] optionalCalendars = currentCulture.OptionalCalendars;
				foreach (Calendar calendar in optionalCalendars)
				{
					if (calendar.GetType().IsInstanceOfType(currentCalendar))
					{
						DateTimeFormatInfo obj = (DateTimeFormatInfo)currentCulture.DateTimeFormat.Clone();
						obj.Calendar = calendar;
						return obj;
					}
				}
				if (currentCulture.Name == "fa-IR" && currentCalendar is PersianCalendar)
				{
					return PersianDateTimeFormatInfo.Build(currentCulture.DateTimeFormat);
				}
			}
			return currentCulture.DateTimeFormat;
		}
	}

	protected virtual CultureInfo CurrentCulture => CultureInfo.GetCultureInfo(_workContextAccessor.GetContext().CurrentCulture);

	protected virtual Calendar CurrentCalendar
	{
		get
		{
			WorkContext context = _workContextAccessor.GetContext();
			if (!string.IsNullOrEmpty(context.CurrentCalendar))
			{
				return _calendarManager.GetCalendarByName(context.CurrentCalendar);
			}
			return CurrentCulture.Calendar;
		}
	}

	public CultureDateTimeFormatProvider(IWorkContextAccessor workContextAccessor, ICalendarManager calendarManager)
	{
		_workContextAccessor = workContextAccessor;
		_calendarManager = calendarManager;
	}

	public string GetEraName(int era)
	{
		return DateTimeFormat.GetEraName(era);
	}

	public string GetShortEraName(int era)
	{
		return DateTimeFormat.GetAbbreviatedEraName(era);
	}

	public int GetEra(string eraName)
	{
		return DateTimeFormat.GetEra(eraName);
	}
}
