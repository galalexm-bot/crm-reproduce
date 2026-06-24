using System.Collections.Generic;

namespace Orchard.Localization.Services;

public interface IDateTimeFormatProvider : IDependency
{
	string[] MonthNames { get; }

	string[] MonthNamesGenitive { get; }

	string[] MonthNamesShort { get; }

	string[] MonthNamesShortGenitive { get; }

	string[] DayNames { get; }

	string[] DayNamesShort { get; }

	string[] DayNamesMin { get; }

	string ShortDateFormat { get; }

	string ShortTimeFormat { get; }

	string ShortDateTimeFormat { get; }

	string LongDateFormat { get; }

	string LongTimeFormat { get; }

	string LongDateTimeFormat { get; }

	IEnumerable<string> AllDateFormats { get; }

	IEnumerable<string> AllTimeFormats { get; }

	IEnumerable<string> AllDateTimeFormats { get; }

	int FirstDay { get; }

	bool Use24HourTime { get; }

	string DateSeparator { get; }

	string TimeSeparator { get; }

	string AmPmPrefix { get; }

	string[] AmPmDesignators { get; }

	string GetEraName(int era);

	string GetShortEraName(int era);

	int GetEra(string eraName);
}
