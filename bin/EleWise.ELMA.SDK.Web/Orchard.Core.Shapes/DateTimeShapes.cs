using System;
using System.Web;
using System.Web.Mvc;
using Orchard.DisplayManagement;
using Orchard.Localization;
using Orchard.Localization.Services;
using Orchard.Mvc.Html;
using Orchard.Services;

namespace Orchard.Core.Shapes;

public class DateTimeShapes : IDependency
{
	private readonly IClock _clock;

	private readonly IDateLocalizationServices _dateLocalizationServices;

	private readonly IDateTimeFormatProvider _dateTimeLocalization;

	public Localizer T { get; set; }

	public DateTimeShapes(IClock clock, IDateLocalizationServices dateLocalizationServices, IDateTimeFormatProvider dateTimeLocalization)
	{
		_clock = clock;
		_dateLocalizationServices = dateLocalizationServices;
		_dateTimeLocalization = dateTimeLocalization;
		T = NullLocalizer.Instance;
	}

	[Shape]
	public IHtmlString DateTimeRelative(dynamic Display, DateTime DateTimeUtc, DateTime dateTimeUtc)
	{
		DateTimeUtc = ((DateTimeUtc != System.DateTime.MinValue) ? DateTimeUtc : dateTimeUtc);
		TimeSpan time = _clock.UtcNow - DateTimeUtc;
		if (time.TotalYears() > 1)
		{
			return T.Plural("1 year ago", "{0} years ago", time.TotalYears());
		}
		if (time.TotalYears() < -1)
		{
			return T.Plural("in 1 year", "in {0} years", -time.TotalYears());
		}
		if (time.TotalMonths() > 1)
		{
			return T.Plural("1 month ago", "{0} months ago", time.TotalMonths());
		}
		if (time.TotalMonths() < -1)
		{
			return T.Plural("in 1 month", "in {0} months", -time.TotalMonths());
		}
		if (time.TotalWeeks() > 1)
		{
			return T.Plural("1 week ago", "{0} weeks ago", time.TotalWeeks());
		}
		if (time.TotalWeeks() < -1)
		{
			return T.Plural("in 1 week", "in {0} weeks", -time.TotalWeeks());
		}
		if (time.TotalHours > 24.0)
		{
			return T.Plural("1 day ago", "{0} days ago", time.Days);
		}
		if (time.TotalHours < -24.0)
		{
			return T.Plural("in 1 day", "in {0} days", -time.Days);
		}
		if (time.TotalMinutes > 60.0)
		{
			return T.Plural("1 hour ago", "{0} hours ago", time.Hours);
		}
		if (time.TotalMinutes < -60.0)
		{
			return T.Plural("in 1 hour", "in {0} hours", -time.Hours);
		}
		if (time.TotalSeconds > 60.0)
		{
			return T.Plural("1 minute ago", "{0} minutes ago", time.Minutes);
		}
		if (time.TotalSeconds < -60.0)
		{
			return T.Plural("in 1 minute", "in {0} minutes", -time.Minutes);
		}
		if (time.TotalSeconds > 10.0)
		{
			return T.Plural("1 second ago", "{0} seconds ago", time.Seconds);
		}
		if (time.TotalSeconds < -10.0)
		{
			return T.Plural("in 1 second", "in {0} seconds", -time.Seconds);
		}
		if (!(time.TotalMilliseconds > 0.0))
		{
			return T("in a moment");
		}
		return T("a moment ago");
	}

	[Shape]
	public IHtmlString DateTime(DateTime DateTimeUtc, LocalizedString CustomFormat)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		if (CustomFormat != null && !string.IsNullOrWhiteSpace(CustomFormat.Text))
		{
			return (IHtmlString)new MvcHtmlString(_dateLocalizationServices.ConvertToLocalizedString(DateTimeUtc, CustomFormat.Text));
		}
		return (IHtmlString)new MvcHtmlString(_dateLocalizationServices.ConvertToLocalizedString(DateTimeUtc, _dateTimeLocalization.LongDateTimeFormat));
	}
}
