using System;
using System.Globalization;
using Orchard.Localization.Models;
using Orchard.Services;

namespace Orchard.Localization.Services;

public class DefaultDateLocalizationServices : IDateLocalizationServices, IDependency
{
	private readonly IClock _clock;

	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly IDateTimeFormatProvider _dateTimeFormatProvider;

	private readonly IDateFormatter _dateFormatter;

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

	public DefaultDateLocalizationServices(IClock clock, IWorkContextAccessor workContextAccessor, IDateTimeFormatProvider dateTimeFormatProvider, IDateFormatter dateFormatter, ICalendarManager calendarManager)
	{
		_clock = clock;
		_workContextAccessor = workContextAccessor;
		_dateTimeFormatProvider = dateTimeFormatProvider;
		_dateFormatter = dateFormatter;
		_calendarManager = calendarManager;
	}

	public virtual DateTime ConvertToSiteTimeZone(DateTime dateUtc)
	{
		if (dateUtc.Kind == DateTimeKind.Local)
		{
			return dateUtc;
		}
		if (CurrentTimeZone == TimeZoneInfo.Utc)
		{
			if (dateUtc.Kind == DateTimeKind.Unspecified)
			{
				return DateTime.SpecifyKind(dateUtc, DateTimeKind.Utc);
			}
			return dateUtc;
		}
		return DateTime.SpecifyKind(TimeZoneInfo.ConvertTimeFromUtc(dateUtc, CurrentTimeZone), DateTimeKind.Local);
	}

	public virtual DateTime ConvertFromSiteTimeZone(DateTime dateLocal)
	{
		if (dateLocal.Kind == DateTimeKind.Utc)
		{
			return dateLocal;
		}
		return DateTime.SpecifyKind(TimeZoneInfo.ConvertTimeToUtc(new DateTime(dateLocal.Ticks, DateTimeKind.Unspecified), CurrentTimeZone), DateTimeKind.Utc);
	}

	public virtual DateTimeParts ConvertToSiteCalendar(DateTime date, TimeSpan offset)
	{
		Calendar currentCalendar = CurrentCalendar;
		return new DateTimeParts(currentCalendar.GetYear(date), currentCalendar.GetMonth(date), currentCalendar.GetDayOfMonth(date), currentCalendar.GetHour(date), currentCalendar.GetMinute(date), currentCalendar.GetSecond(date), Convert.ToInt32(currentCalendar.GetMilliseconds(date)), date.Kind, offset);
	}

	public virtual DateTime ConvertFromSiteCalendar(DateTimeParts parts)
	{
		return new DateTime(parts.Date.Year, parts.Date.Month, parts.Date.Day, parts.Time.Hour, parts.Time.Minute, parts.Time.Second, parts.Time.Millisecond, CurrentCalendar, parts.Time.Kind);
	}

	public string ConvertToLocalizedDateString(DateTime date, DateLocalizationOptions options = null)
	{
		return ConvertToLocalizedDateString(ToNullable(date), options);
	}

	public string ConvertToLocalizedDateString(DateTime? date, DateLocalizationOptions options = null)
	{
		return ConvertToLocalizedString(date, _dateTimeFormatProvider.ShortDateFormat, options);
	}

	public string ConvertToLocalizedTimeString(DateTime date, DateLocalizationOptions options = null)
	{
		return ConvertToLocalizedTimeString(ToNullable(date), options);
	}

	public string ConvertToLocalizedTimeString(DateTime? date, DateLocalizationOptions options = null)
	{
		options = options ?? new DateLocalizationOptions();
		if (!date.HasValue)
		{
			return options.NullText;
		}
		DateTime dateTime = date.Value;
		TimeSpan offset = TimeSpan.Zero;
		if (options.EnableTimeZoneConversion)
		{
			if (options.IgnoreDate)
			{
				DateTime dateUtc = new DateTime(2000, 1, 1, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond, dateTime.Kind);
				dateUtc = ConvertToSiteTimeZone(dateUtc);
				dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateUtc.Hour, dateUtc.Minute, dateUtc.Second, dateUtc.Millisecond, dateUtc.Kind);
			}
			else
			{
				dateTime = ConvertToSiteTimeZone(dateTime);
			}
			offset = CurrentTimeZone.GetUtcOffset(date.Value);
		}
		DateTimeParts parts = DateTimeParts.FromDateTime(dateTime, offset);
		return _dateFormatter.FormatDateTime(parts, _dateTimeFormatProvider.LongTimeFormat);
	}

	public string ConvertToLocalizedString(DateTime date, DateLocalizationOptions options = null)
	{
		return ConvertToLocalizedString(ToNullable(date), options);
	}

	public string ConvertToLocalizedString(DateTime? date, DateLocalizationOptions options = null)
	{
		return ConvertToLocalizedString(date, _dateTimeFormatProvider.ShortDateTimeFormat, options);
	}

	public string ConvertToLocalizedString(DateTime date, string format, DateLocalizationOptions options = null)
	{
		return ConvertToLocalizedString(ToNullable(date), format, options);
	}

	public string ConvertToLocalizedString(DateTime? date, string format, DateLocalizationOptions options = null)
	{
		options = options ?? new DateLocalizationOptions();
		if (!date.HasValue)
		{
			return options.NullText;
		}
		DateTime dateTime = date.Value;
		TimeSpan offset = TimeSpan.Zero;
		if (options.EnableTimeZoneConversion)
		{
			dateTime = ConvertToSiteTimeZone(dateTime);
			offset = CurrentTimeZone.GetUtcOffset(date.Value);
		}
		DateTimeParts parts = DateTimeParts.FromDateTime(dateTime, offset);
		if (options.EnableCalendarConversion && !(CurrentCalendar is GregorianCalendar))
		{
			parts = ConvertToSiteCalendar(dateTime, offset);
		}
		return _dateFormatter.FormatDateTime(parts, format);
	}

	public DateTime? ConvertFromLocalizedDateString(string dateString, DateLocalizationOptions options = null)
	{
		return ConvertFromLocalizedString(dateString, null, options);
	}

	public DateTime? ConvertFromLocalizedTimeString(string timeString, DateLocalizationOptions options = null)
	{
		return ConvertFromLocalizedString(null, timeString, options);
	}

	public DateTime? ConvertFromLocalizedString(string dateString, string timeString, DateLocalizationOptions options = null)
	{
		options = options ?? new DateLocalizationOptions();
		bool flag = dateString != null && dateString != options.NullText;
		bool flag2 = timeString != null && timeString != options.NullText;
		if (!flag && !flag2)
		{
			return null;
		}
		DateTimeParts parts = new DateTimeParts(flag ? _dateFormatter.ParseDate(dateString) : DateParts.MinValue, flag2 ? _dateFormatter.ParseTime(timeString) : TimeParts.MinValue);
		DateTime dateTime = ((!flag || !options.EnableCalendarConversion || CurrentCalendar is GregorianCalendar) ? parts.ToDateTime(new GregorianCalendar()) : ConvertFromSiteCalendar(parts));
		if (flag2 && options.EnableTimeZoneConversion)
		{
			if (!flag)
			{
				dateTime = new DateTime(2000, 1, 1, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond, dateTime.Kind);
			}
			dateTime = ConvertFromSiteTimeZone(dateTime);
			if (!flag)
			{
				dateTime = new DateTime(DateTime.MinValue.Year, DateTime.MinValue.Month, DateTime.MinValue.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond, dateTime.Kind);
			}
		}
		if (options.EnableTimeZoneConversion)
		{
			dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
		}
		return dateTime;
	}

	public DateTime? ConvertFromLocalizedString(string dateTimeString, DateLocalizationOptions options = null)
	{
		options = options ?? new DateLocalizationOptions();
		if (dateTimeString == null || dateTimeString == options.NullText)
		{
			return null;
		}
		DateTimeParts parts = _dateFormatter.ParseDateTime(dateTimeString);
		DateTime dateTime = ((!options.EnableCalendarConversion || CurrentCalendar is GregorianCalendar) ? parts.ToDateTime(new GregorianCalendar()) : ConvertFromSiteCalendar(parts));
		if (options.EnableTimeZoneConversion)
		{
			dateTime = ConvertFromSiteTimeZone(dateTime);
		}
		return dateTime;
	}

	protected virtual DateTime? ToNullable(DateTime date)
	{
		if (!(date == DateTime.MinValue))
		{
			return date;
		}
		return null;
	}
}
