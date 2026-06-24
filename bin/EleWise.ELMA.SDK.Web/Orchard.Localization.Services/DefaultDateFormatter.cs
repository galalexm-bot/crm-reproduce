using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Orchard.Localization.Models;
using Orchard.Utility.Extensions;

namespace Orchard.Localization.Services;

public class DefaultDateFormatter : IDateFormatter, IDependency
{
	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly IDateTimeFormatProvider _dateTimeFormatProvider;

	private readonly ICalendarManager _calendarManager;

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

	protected virtual TimeZoneInfo CurrentTimeZone => _workContextAccessor.GetContext().CurrentTimeZone;

	public DefaultDateFormatter(IWorkContextAccessor workContextAccessor, IDateTimeFormatProvider dateTimeFormatProvider, ICalendarManager calendarManager)
	{
		_workContextAccessor = workContextAccessor;
		_dateTimeFormatProvider = dateTimeFormatProvider;
		_calendarManager = calendarManager;
	}

	public virtual DateTimeParts ParseDateTime(string dateTimeString)
	{
		Dictionary<string, string> replacements = GetDateParseReplacements().Concat(GetTimeParseReplacements()).ToDictionary((KeyValuePair<string, string> item) => item.Key, (KeyValuePair<string, string> item) => item.Value);
		foreach (string allDateTimeFormat in _dateTimeFormatProvider.AllDateTimeFormats)
		{
			DateTimeParts? dateTimeParts = TryParseDateTime(dateTimeString, allDateTimeFormat, replacements);
			if (dateTimeParts.HasValue)
			{
				return dateTimeParts.Value;
			}
		}
		throw new FormatException("The string was not recognized as a valid date and time.");
	}

	public virtual DateTimeParts ParseDateTime(string dateTimeString, string format)
	{
		Dictionary<string, string> replacements = GetDateParseReplacements().Concat(GetTimeParseReplacements()).ToDictionary((KeyValuePair<string, string> item) => item.Key, (KeyValuePair<string, string> item) => item.Value);
		DateTimeParts? dateTimeParts = TryParseDateTime(dateTimeString, format, replacements);
		if (dateTimeParts.HasValue)
		{
			return dateTimeParts.Value;
		}
		throw new FormatException("The string was not recognized as a valid date and time.");
	}

	public virtual DateParts ParseDate(string dateString)
	{
		Dictionary<string, string> dateParseReplacements = GetDateParseReplacements();
		foreach (string allDateFormat in _dateTimeFormatProvider.AllDateFormats)
		{
			DateParts? dateParts = TryParseDate(dateString, allDateFormat, dateParseReplacements);
			if (dateParts.HasValue)
			{
				return dateParts.Value;
			}
		}
		throw new FormatException("The string was not recognized as a valid date.");
	}

	public virtual DateParts ParseDate(string dateString, string format)
	{
		Dictionary<string, string> dateParseReplacements = GetDateParseReplacements();
		DateParts? dateParts = TryParseDate(dateString, format, dateParseReplacements);
		if (dateParts.HasValue)
		{
			return dateParts.Value;
		}
		throw new FormatException("The string was not recognized as a valid date.");
	}

	public virtual TimeParts ParseTime(string timeString)
	{
		Dictionary<string, string> timeParseReplacements = GetTimeParseReplacements();
		foreach (string allTimeFormat in _dateTimeFormatProvider.AllTimeFormats)
		{
			TimeParts? timeParts = TryParseTime(timeString, allTimeFormat, timeParseReplacements);
			if (timeParts.HasValue)
			{
				return timeParts.Value;
			}
		}
		throw new FormatException("The string was not recognized as a valid time.");
	}

	public virtual TimeParts ParseTime(string timeString, string format)
	{
		Dictionary<string, string> timeParseReplacements = GetTimeParseReplacements();
		TimeParts? timeParts = TryParseTime(timeString, format, timeParseReplacements);
		if (timeParts.HasValue)
		{
			return timeParts.Value;
		}
		throw new FormatException("The string was not recognized as a valid time.");
	}

	public virtual string FormatDateTime(DateTimeParts parts)
	{
		return FormatDateTime(parts, _dateTimeFormatProvider.ShortDateTimeFormat);
	}

	public virtual string FormatDateTime(DateTimeParts parts, string format)
	{
		bool useGenitiveMonthName = GetUseGenitiveMonthName(format);
		Dictionary<string, string> replacements = GetDateFormatReplacements(useGenitiveMonthName).Concat(GetTimeFormatReplacements()).ToDictionary((KeyValuePair<string, string> item) => item.Key, (KeyValuePair<string, string> item) => item.Value);
		string format2 = ConvertToFormatString(format, replacements);
		GetDateFormatValues(calendar: CurrentCalendar, parts: parts.Date, twoDigitYear: out var twoDigitYear, monthName: out var monthName, monthNameShort: out var monthNameShort, monthNameGenitive: out var monthNameGenitive, monthNameShortGenitive: out var monthNameShortGenitive, dayName: out var dayName, dayNameShort: out var dayNameShort, eraName: out var eraName, eraNameShort: out var eraNameShort);
		GetTimeFormatValues(parts.Time, out var _, out var hour, out var amPm, out var amPmShort, out var timeZone, out var offsetSign, out var offsetHours, out var offsetMinutes, out var fraction1Zero, out var fraction2Zero, out var fraction3Zero, out var fraction1Digit, out var fraction2Digit, out var fraction3Digit);
		return string.Format(format2, parts.Date.Year, twoDigitYear, parts.Date.Month, monthName, monthNameShort, monthNameGenitive, monthNameShortGenitive, parts.Date.Day, dayName, dayNameShort, eraName, eraNameShort, parts.Time.Hour, hour, parts.Time.Minute, parts.Time.Second, fraction1Zero, fraction2Zero, fraction3Zero, fraction1Digit, fraction2Digit, fraction3Digit, amPm, amPmShort, timeZone, offsetSign, offsetHours, offsetMinutes);
	}

	public virtual string FormatDate(DateParts parts)
	{
		return FormatDate(parts, _dateTimeFormatProvider.ShortDateFormat);
	}

	public virtual string FormatDate(DateParts parts, string format)
	{
		bool useGenitiveMonthName = GetUseGenitiveMonthName(format);
		Dictionary<string, string> dateFormatReplacements = GetDateFormatReplacements(useGenitiveMonthName);
		string format2 = ConvertToFormatString(format, dateFormatReplacements);
		GetDateFormatValues(calendar: CurrentCalendar, parts: parts, twoDigitYear: out var twoDigitYear, monthName: out var monthName, monthNameShort: out var monthNameShort, monthNameGenitive: out var monthNameGenitive, monthNameShortGenitive: out var monthNameShortGenitive, dayName: out var dayName, dayNameShort: out var dayNameShort, eraName: out var eraName, eraNameShort: out var eraNameShort);
		return string.Format(format2, parts.Year, twoDigitYear, parts.Month, monthName, monthNameShort, monthNameGenitive, monthNameShortGenitive, parts.Day, dayName, dayNameShort, eraName, eraNameShort);
	}

	public virtual string FormatTime(TimeParts parts)
	{
		return FormatTime(parts, _dateTimeFormatProvider.LongTimeFormat);
	}

	public virtual string FormatTime(TimeParts parts, string format)
	{
		Dictionary<string, string> timeFormatReplacements = GetTimeFormatReplacements();
		string format2 = ConvertToFormatString(format, timeFormatReplacements);
		GetTimeFormatValues(parts, out var _, out var hour, out var amPm, out var amPmShort, out var timeZone, out var offsetSign, out var offsetHours, out var offsetMinutes, out var fraction1Zero, out var fraction2Zero, out var fraction3Zero, out var fraction1Digit, out var fraction2Digit, out var fraction3Digit);
		return string.Format(format2, null, null, null, null, null, null, null, null, null, null, null, null, parts.Hour, hour, parts.Minute, parts.Second, fraction1Zero, fraction2Zero, fraction3Zero, fraction1Digit, fraction2Digit, fraction3Digit, amPm, amPmShort, timeZone, offsetSign, offsetHours, offsetMinutes);
	}

	protected virtual DateTimeParts? TryParseDateTime(string dateTimeString, string format, IDictionary<string, string> replacements)
	{
		string pattern = ConvertToRegexPattern(format, replacements);
		Match match = Regex.Match(dateTimeString, pattern, RegexOptions.IgnoreCase);
		if (match.Success)
		{
			return new DateTimeParts(ExtractDateParts(match), ExtractTimeParts(match));
		}
		return null;
	}

	protected virtual DateParts? TryParseDate(string dateString, string format, IDictionary<string, string> replacements)
	{
		string pattern = ConvertToRegexPattern(format, replacements);
		Match match = Regex.Match(dateString, pattern, RegexOptions.IgnoreCase);
		if (match.Success)
		{
			return ExtractDateParts(match);
		}
		return null;
	}

	protected virtual TimeParts? TryParseTime(string timeString, string format, IDictionary<string, string> replacements)
	{
		string pattern = ConvertToRegexPattern(format, replacements);
		Match match = Regex.Match(timeString, pattern, RegexOptions.IgnoreCase);
		if (match.Success)
		{
			return ExtractTimeParts(match);
		}
		return null;
	}

	protected virtual DateParts ExtractDateParts(Match m)
	{
		int year = 0;
		int month = 0;
		int day = 0;
		if (m.Groups["year"].Success)
		{
			year = CurrentCalendar.ToFourDigitYear(int.Parse(m.Groups["year"].Value));
		}
		if (m.Groups["month"].Success)
		{
			month = int.Parse(m.Groups["month"].Value);
		}
		else if (m.Groups["monthNameShort"].Success)
		{
			string item = m.Groups["monthNameShort"].Value.ToLowerInvariant();
			List<string> list = _dateTimeFormatProvider.MonthNamesShortGenitive.Select((string x) => x.ToLowerInvariant()).ToList();
			List<string> list2 = _dateTimeFormatProvider.MonthNamesShort.Select((string x) => x.ToLowerInvariant()).ToList();
			if (list.Contains(item))
			{
				month = list.IndexOf(item) + 1;
			}
			else if (list2.Contains(item))
			{
				month = list2.IndexOf(item) + 1;
			}
		}
		else if (m.Groups["monthName"].Success)
		{
			string item2 = m.Groups["monthName"].Value.ToLowerInvariant();
			List<string> list3 = _dateTimeFormatProvider.MonthNamesGenitive.Select((string x) => x.ToLowerInvariant()).ToList();
			List<string> list4 = _dateTimeFormatProvider.MonthNames.Select((string x) => x.ToLowerInvariant()).ToList();
			if (list3.Contains(item2))
			{
				month = list3.IndexOf(item2) + 1;
			}
			else if (list4.Contains(item2))
			{
				month = list4.IndexOf(item2) + 1;
			}
		}
		if (m.Groups["day"].Success)
		{
			day = int.Parse(m.Groups["day"].Value);
		}
		return new DateParts(year, month, day);
	}

	protected virtual TimeParts ExtractTimeParts(Match m)
	{
		int hour = 0;
		int minute = 0;
		int second = 0;
		int millisecond = 0;
		DateTimeKind kind = DateTimeKind.Unspecified;
		TimeSpan timeSpan = TimeSpan.Zero;
		if (m.Groups["hour24"].Success)
		{
			hour = int.Parse(m.Groups["hour24"].Value);
		}
		else if (m.Groups["hour12"].Success)
		{
			if (!m.Groups["amPm"].Success)
			{
				throw new FormatException("The string was not recognized as a valid time. The hour is in 12-hour notation but no AM/PM designator was found.");
			}
			int num = int.Parse(m.Groups["hour12"].Value);
			bool flag = false;
			flag = ((!(_dateTimeFormatProvider.AmPmDesignators[0] == _dateTimeFormatProvider.AmPmDesignators[1])) ? m.Groups["amPm"].Value.Equals(_dateTimeFormatProvider.AmPmDesignators[1], StringComparison.InvariantCultureIgnoreCase) : (num >= 12));
			hour = ConvertToHour24(num, flag);
		}
		if (m.Groups["minute"].Success)
		{
			minute = int.Parse(m.Groups["minute"].Value);
		}
		if (m.Groups["second"].Success)
		{
			second = int.Parse(m.Groups["second"].Value);
		}
		if (m.Groups["fraction"].Success)
		{
			millisecond = Convert.ToInt32(decimal.Parse(string.Format(CultureInfo.InvariantCulture, "0.{0}", m.Groups["fraction"].Value), CultureInfo.InvariantCulture) * 1000m);
		}
		if (m.Groups["timeZone"].Success)
		{
			string value = m.Groups["timeZone"].Value;
			if (value.ToUpperInvariant() == "Z")
			{
				kind = DateTimeKind.Utc;
			}
			else
			{
				timeSpan = TimeSpan.Parse(value.TrimStart('+'));
				if (timeSpan == CurrentTimeZone.BaseUtcOffset)
				{
					kind = DateTimeKind.Local;
				}
				else if (timeSpan == TimeSpan.Zero)
				{
					kind = DateTimeKind.Utc;
				}
			}
		}
		else if (m.Groups["offsetSign"].Success && m.Groups["offsetHours"].Success)
		{
			int hours = int.Parse(m.Groups["offsetHours"].Value);
			int minutes = 0;
			if (m.Groups["offsetMinutes"].Success)
			{
				minutes = int.Parse(m.Groups["offsetMinutes"].Value);
			}
			timeSpan = new TimeSpan(hours, minutes, 0);
			if (m.Groups["offsetSign"].Value == "-")
			{
				timeSpan = timeSpan.Negate();
			}
			if (timeSpan == CurrentTimeZone.BaseUtcOffset)
			{
				kind = DateTimeKind.Local;
			}
			else if (timeSpan == TimeSpan.Zero)
			{
				kind = DateTimeKind.Utc;
			}
		}
		return new TimeParts(hour, minute, second, millisecond, kind, timeSpan);
	}

	protected virtual void GetDateFormatValues(DateParts parts, Calendar calendar, out int twoDigitYear, out string monthName, out string monthNameShort, out string monthNameGenitive, out string monthNameShortGenitive, out string dayName, out string dayNameShort, out string eraName, out string eraNameShort)
	{
		string text = parts.Year.ToString("00", CultureInfo.InvariantCulture);
		twoDigitYear = int.Parse(text.Substring(text.Length - 2));
		monthName = ((parts.Month > 0) ? _dateTimeFormatProvider.MonthNames[parts.Month - 1] : null);
		monthNameShort = ((parts.Month > 0) ? _dateTimeFormatProvider.MonthNamesShort[parts.Month - 1] : null);
		monthNameGenitive = ((parts.Month > 0) ? _dateTimeFormatProvider.MonthNamesGenitive[parts.Month - 1] : null);
		monthNameShortGenitive = ((parts.Month > 0) ? _dateTimeFormatProvider.MonthNamesShortGenitive[parts.Month - 1] : null);
		dayName = ((parts.Day > 0) ? _dateTimeFormatProvider.DayNames[(int)calendar.GetDayOfWeek(parts.ToDateTime(calendar))] : null);
		dayNameShort = ((parts.Day > 0) ? _dateTimeFormatProvider.DayNamesShort[(int)calendar.GetDayOfWeek(parts.ToDateTime(calendar))] : null);
		eraName = ((parts.Day > 0) ? _dateTimeFormatProvider.GetEraName(calendar.GetEra(parts.ToDateTime(calendar))) : null);
		eraNameShort = ((parts.Day > 0) ? _dateTimeFormatProvider.GetShortEraName(calendar.GetEra(parts.ToDateTime(calendar))) : null);
	}

	protected virtual void GetTimeFormatValues(TimeParts parts, out bool isPm, out int hour12, out string amPm, out string amPmShort, out string timeZone, out string offsetSign, out int offsetHours, out int offsetMinutes, out string fraction1Zero, out string fraction2Zero, out string fraction3Zero, out string fraction1Digit, out string fraction2Digit, out string fraction3Digit)
	{
		hour12 = ConvertToHour12(parts.Hour, out isPm);
		amPm = _dateTimeFormatProvider.AmPmDesignators[isPm ? 1 : 0];
		amPmShort = (string.IsNullOrEmpty(amPm) ? "" : amPm[0].ToString());
		offsetSign = ((parts.Offset.GetValueOrDefault() < TimeSpan.Zero) ? "-" : "+");
		offsetHours = Math.Abs(parts.Offset.GetValueOrDefault().Hours);
		offsetMinutes = Math.Abs(parts.Offset.GetValueOrDefault().Minutes);
		timeZone = "";
		switch (parts.Kind)
		{
		case DateTimeKind.Utc:
			timeZone = "Z";
			break;
		case DateTimeKind.Local:
			timeZone = $"{offsetSign}{offsetHours:00}:{offsetMinutes:00}";
			break;
		}
		fraction1Zero = ((decimal)parts.Millisecond / 1000m).ToString("0.0", CultureInfo.InvariantCulture).Substring(2);
		fraction2Zero = ((decimal)parts.Millisecond / 1000m).ToString("0.00", CultureInfo.InvariantCulture).Substring(2);
		fraction3Zero = ((decimal)parts.Millisecond / 1000m).ToString("0.000", CultureInfo.InvariantCulture).Substring(2);
		string text = ((decimal)parts.Millisecond / 1000m).ToString("0.#", CultureInfo.InvariantCulture);
		string text2 = ((decimal)parts.Millisecond / 1000m).ToString("0.##", CultureInfo.InvariantCulture);
		string text3 = ((decimal)parts.Millisecond / 1000m).ToString("0.###", CultureInfo.InvariantCulture);
		fraction1Digit = ((text.Length >= 2) ? text.Substring(2) : "");
		fraction2Digit = ((text2.Length >= 2) ? text2.Substring(2) : "");
		fraction3Digit = ((text3.Length >= 2) ? text3.Substring(2) : "");
	}

	protected virtual bool GetUseGenitiveMonthName(string format)
	{
		string input = Regex.Replace(format, "(?<!\\\\)'(.*?)(?<!\\\\)'|(?<!\\\\)\"(.*?)(?<!\\\\)\"", "", RegexOptions.Compiled);
		string pattern = "(\\b|[^d])d{1,2}(\\b|[^d])";
		return Regex.IsMatch(input, pattern, RegexOptions.Compiled);
	}

	protected virtual Dictionary<string, string> GetDateParseReplacements()
	{
		return new Dictionary<string, string>
		{
			{
				"dddd",
				string.Format("(?<dayName>{0})", string.Join("|", _dateTimeFormatProvider.DayNames.Select((string x) => EscapeForRegex(x))))
			},
			{
				"ddd",
				string.Format("(?<dayNameShort>{0})", string.Join("|", _dateTimeFormatProvider.DayNamesShort.Select((string x) => EscapeForRegex(x))))
			},
			{ "dd", "(?<day>[0-9]{2})" },
			{ "d", "(?<day>[0-9]{1,2})" },
			{
				"MMMM",
				string.Format("(?<monthName>{0})", string.Join("|", from x in (from x in _dateTimeFormatProvider.MonthNames.Union(_dateTimeFormatProvider.MonthNamesGenitive)
						where !string.IsNullOrEmpty(x)
						select x).Distinct()
					select EscapeForRegex(x)))
			},
			{
				"MMM",
				string.Format("(?<monthNameShort>{0})", string.Join("|", from x in (from x in _dateTimeFormatProvider.MonthNamesShort.Union(_dateTimeFormatProvider.MonthNamesShortGenitive)
						where !string.IsNullOrEmpty(x)
						select x).Distinct()
					select EscapeForRegex(x)))
			},
			{ "MM", "(?<month>[0-9]{2})" },
			{ "M", "(?<month>[0-9]{1,2})" },
			{ "yyyyy", "(?<year>[0-9]{5})" },
			{ "yyyy", "(?<year>[0-9]{4})" },
			{ "yyy", "(?<year>[0-9]{3})" },
			{ "yy", "(?<year>[0-9]{2})" },
			{ "y", "(?<year>[0-9]{1})" },
			{
				"gg",
				$"(?<eraName>{$"{EscapeForRegex(_dateTimeFormatProvider.GetEraName(0))}|{EscapeForRegex(_dateTimeFormatProvider.GetEraName(1))}"})"
			},
			{
				"g",
				$"(?<eraName>{$"{EscapeForRegex(_dateTimeFormatProvider.GetEraName(0))}|{EscapeForRegex(_dateTimeFormatProvider.GetEraName(1))}"})"
			}
		};
	}

	protected virtual Dictionary<string, string> GetTimeParseReplacements()
	{
		string text = _dateTimeFormatProvider.AmPmDesignators[0];
		string text2 = _dateTimeFormatProvider.AmPmDesignators[1];
		return new Dictionary<string, string>
		{
			{ "HH", "(?<hour24>[0-9]{2})" },
			{ "H", "(?<hour24>[0-9]{1,2})" },
			{ "hh", "(?<hour12>[0-9]{2})" },
			{ "h", "(?<hour12>[0-9]{1,2})" },
			{ "mm", "(?<minute>[0-9]{2})" },
			{ "m", "(?<minute>[0-9]{1,2})" },
			{ "ss", "(?<second>[0-9]{2})" },
			{ "s", "(?<second>[0-9]{1,2})" },
			{ "fffffff", "(?<fraction>[0-9]{7})" },
			{ "ffffff", "(?<fraction>[0-9]{6})" },
			{ "fffff", "(?<fraction>[0-9]{5})" },
			{ "ffff", "(?<fraction>[0-9]{4})" },
			{ "fff", "(?<fraction>[0-9]{3})" },
			{ "ff", "(?<fraction>[0-9]{2})" },
			{ "f", "(?<fraction>[0-9]{1})" },
			{ "FFFFFFF", "(?<fraction>[0-9]{7})" },
			{ "FFFFFF", "(?<fraction>[0-9]{6})" },
			{ "FFFFF", "(?<fraction>[0-9]{5})" },
			{ "FFFF", "(?<fraction>[0-9]{4})" },
			{ "FFF", "(?<fraction>[0-9]{3})" },
			{ "FF", "(?<fraction>[0-9]{2})" },
			{ "F", "(?<fraction>[0-9]{1})" },
			{
				"tt",
				$"\\s*(?<amPm>{EscapeForRegex(text)}|{EscapeForRegex(text2)})\\s*"
			},
			{
				"t",
				string.Format("\\s*(?<amPm>{0}|{1})\\s*", string.IsNullOrEmpty(text) ? "" : EscapeForRegex(text[0].ToString()), string.IsNullOrEmpty(text2) ? "" : EscapeForRegex(text2[0].ToString()))
			},
			{ "K", "(?<timeZone>Z|(\\+|-)[0-9]{2}:[0-9]{2})*" },
			{ "zzz", "(?<offsetSign>\\+|-)(?<offsetHours>[0-9]{2}):(?<offsetMinutes>[0-9]{2})" },
			{ "zz", "(?<offsetSign>\\+|-)(?<offsetHours>[0-9]{2})" },
			{ "z", "(?<offsetSign>\\+|-)(?<offsetHours>[0-9]{1,2})" }
		};
	}

	protected virtual Dictionary<string, string> GetDateFormatReplacements(bool useMonthNameGenitive)
	{
		return new Dictionary<string, string>
		{
			{ "dddd", "{8}" },
			{ "ddd", "{9}" },
			{ "dd", "{7:00}" },
			{ "d", "{7:##}" },
			{
				"MMMM",
				useMonthNameGenitive ? "{5}" : "{3}"
			},
			{ "MMM", "{4}" },
			{ "MM", "{2:00}" },
			{ "M", "{2:##}" },
			{ "yyyyy", "{0:00000}" },
			{ "yyyy", "{0:0000}" },
			{ "yyy", "{0:000}" },
			{ "yy", "{1:00}" },
			{ "y", "{1:0}" },
			{ "gg", "{10}" },
			{ "g", "{10}" }
		};
	}

	protected virtual Dictionary<string, string> GetTimeFormatReplacements()
	{
		return new Dictionary<string, string>
		{
			{ "HH", "{12:00}" },
			{ "H", "{12:#0}" },
			{ "hh", "{13:00}" },
			{ "h", "{13:#0}" },
			{ "mm", "{14:00}" },
			{ "m", "{14:#0}" },
			{ "ss", "{15:00}" },
			{ "s", "{15:#0}" },
			{ "fffffff", "{18}0000" },
			{ "ffffff", "{18}000" },
			{ "fffff", "{18}00" },
			{ "ffff", "{18}0" },
			{ "fff", "{18}" },
			{ "ff", "{17}" },
			{ "f", "{16}" },
			{ "FFFFFFF", "{21}" },
			{ "FFFFFF", "{21}" },
			{ "FFFFF", "{21}" },
			{ "FFFF", "{21}" },
			{ "FFF", "{21}" },
			{ "FF", "{20}" },
			{ "F", "{19}" },
			{ "tt", "{22}" },
			{ "t", "{23}" },
			{ "K", "{24}" },
			{ "zzz", "{25}{26:00}:{27:00}" },
			{ "zz", "{25}{26:00}" },
			{ "z", "{25}{26:#0}" }
		};
	}

	protected virtual string ConvertToRegexPattern(string format, IDictionary<string, string> replacements)
	{
		string input = format;
		input = Regex.Replace(input, "\\/|:", (Match m) => (!(m.Value == "/")) ? _dateTimeFormatProvider.TimeSeparator : _dateTimeFormatProvider.DateSeparator, RegexOptions.Compiled);
		input = EscapeForRegex(input);
		input = Regex.Replace(input, "(?<!\\\\)'(.*?)(?<!\\\\)'|(?<!\\\\)\"(.*?)(?<!\\\\)\"", (Match m) => string.Format("(?:.{{{0}}})", m.Value.Replace("\\", "").Length - 2), RegexOptions.Compiled);
		input = input.ReplaceAll(replacements);
		return $"^{input}$";
	}

	protected virtual string ConvertToFormatString(string format, IDictionary<string, string> replacements)
	{
		string text = "(?<!\\\\)'(.*?)(?<!\\\\)'|(?<!\\\\)\"(.*?)(?<!\\\\)\"";
		string text2 = "\\/|:";
		string pattern = string.Format("{0}", string.Join("|", new string[2] { text, text2 }.Concat(replacements.Keys)));
		return Regex.Replace(format, pattern, delegate(Match m)
		{
			if (replacements.ContainsKey(m.Value))
			{
				return replacements[m.Value];
			}
			if (m.Value == "/")
			{
				return _dateTimeFormatProvider.DateSeparator;
			}
			if (m.Value == ":")
			{
				return _dateTimeFormatProvider.TimeSeparator;
			}
			string text3 = m.Value.Replace("\\'", "'");
			return text3.Substring(1, text3.Length - 2);
		});
	}

	protected virtual int ConvertToHour24(int hour12, bool isPm)
	{
		if (isPm)
		{
			if (hour12 != 12)
			{
				return hour12 + 12;
			}
			return 12;
		}
		if (hour12 != 12)
		{
			return hour12;
		}
		return 0;
	}

	protected virtual int ConvertToHour12(int hour24, out bool isPm)
	{
		if (hour24 >= 12)
		{
			isPm = true;
			if (hour24 != 12)
			{
				return hour24 - 12;
			}
			return 12;
		}
		isPm = false;
		if (hour24 != 0)
		{
			return hour24;
		}
		return 12;
	}

	protected virtual string EscapeForRegex(string input)
	{
		return Regex.Replace(input, "\\.|\\$|\\^|\\{|\\[|\\(|\\||\\)|\\*|\\+|\\?|\\\\", (Match m) => $"\\{m.Value}", RegexOptions.Compiled);
	}
}
