using System.Globalization;

namespace Orchard.Localization.Services;

internal static class PersianDateTimeFormatInfo
{
	internal static DateTimeFormatInfo Build(DateTimeFormatInfo original)
	{
		DateTimeFormatInfo dateTimeFormatInfo = (DateTimeFormatInfo)original.Clone();
		string[] array = new string[13]
		{
			"فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی",
			"بهمن", "اسفند", ""
		};
		string[] array3 = (dateTimeFormatInfo.AbbreviatedMonthGenitiveNames = array);
		string[] array5 = (dateTimeFormatInfo.MonthGenitiveNames = array3);
		string[] array8 = (dateTimeFormatInfo.MonthNames = (dateTimeFormatInfo.AbbreviatedMonthNames = array5));
		string[] array9 = new string[7] { "یکشنبه", "دوشنبه", "سه شنبه", "چهارشنبه", "پنجشنبه", "جمعه", "شنبه" };
		array8 = (dateTimeFormatInfo.DayNames = (dateTimeFormatInfo.AbbreviatedDayNames = array9));
		dateTimeFormatInfo.SetAllDateTimePatterns(new string[4] { "yyyy/MM/dd", "yy/MM/dd", "yyyy/M/d", "yy/M/d" }, 'd');
		dateTimeFormatInfo.SetAllDateTimePatterns(new string[2] { "dddd، d MMMM yyyy", "d MMMM yyyy" }, 'D');
		dateTimeFormatInfo.SetAllDateTimePatterns(new string[2] { "MMMM yyyy", "MMMM yy" }, 'y');
		dateTimeFormatInfo.SetAllDateTimePatterns(new string[4] { "HH:mm", "H:mm", "hh:mm tt", "h:mm tt" }, 't');
		dateTimeFormatInfo.SetAllDateTimePatterns(new string[4] { "HH:mm:ss", "H:mm:ss", "hh:mm:ss tt", "h:mm:ss tt" }, 'T');
		return dateTimeFormatInfo;
	}
}
