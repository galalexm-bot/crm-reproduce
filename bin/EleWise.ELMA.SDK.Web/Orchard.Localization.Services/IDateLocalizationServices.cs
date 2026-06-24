using System;
using Orchard.Localization.Models;

namespace Orchard.Localization.Services;

public interface IDateLocalizationServices : IDependency
{
	DateTime ConvertToSiteTimeZone(DateTime dateUtc);

	DateTime ConvertFromSiteTimeZone(DateTime dateLocal);

	DateTimeParts ConvertToSiteCalendar(DateTime date, TimeSpan offset);

	DateTime ConvertFromSiteCalendar(DateTimeParts parts);

	string ConvertToLocalizedDateString(DateTime date, DateLocalizationOptions options = null);

	string ConvertToLocalizedDateString(DateTime? date, DateLocalizationOptions options = null);

	string ConvertToLocalizedTimeString(DateTime date, DateLocalizationOptions options = null);

	string ConvertToLocalizedTimeString(DateTime? date, DateLocalizationOptions options = null);

	string ConvertToLocalizedString(DateTime date, DateLocalizationOptions options = null);

	string ConvertToLocalizedString(DateTime? date, DateLocalizationOptions options = null);

	string ConvertToLocalizedString(DateTime date, string format, DateLocalizationOptions options = null);

	string ConvertToLocalizedString(DateTime? date, string format, DateLocalizationOptions options = null);

	DateTime? ConvertFromLocalizedDateString(string dateString, DateLocalizationOptions options = null);

	DateTime? ConvertFromLocalizedTimeString(string timeString, DateLocalizationOptions options = null);

	DateTime? ConvertFromLocalizedString(string dateString, string timeString, DateLocalizationOptions options = null);

	DateTime? ConvertFromLocalizedString(string dateTimeString, DateLocalizationOptions options = null);
}
