using System;
using System.Globalization;
using Bridge;

namespace EleWise.ELMA.Core;

public class SR
{
	[Convention(/*Could not decode attribute arguments.*/)]
	[External]
	private class ELMACultureInfo
	{
		public extern string ShortDate { get; }

		public extern string LongDate { get; }

		public extern string ShortTime { get; }

		public extern string LongTime { get; }

		public extern string FullDateTime { get; }

		public extern string SortableDateTime { get; }

		public extern string UniversalSortableDateTime { get; }

		public extern string GeneralDateShortTime { get; }

		public extern string GeneralDateTime { get; }

		public extern string MonthDay { get; }

		public extern string MonthYear { get; }

		public extern string[] Days { get; }

		public extern string[] AbbrDays { get; }

		public extern string[] AbbrMonths { get; }

		public extern string[] Months { get; }

		public extern string Am { get; }

		public extern string Pm { get; }

		public extern string DateSeparator { get; }

		public extern string TimeSeparator { get; }

		public extern int FirstDayOfWeek { get; }

		public extern int Currencydecimaldigits { get; }

		public extern string Currencydecimalseparator { get; }

		public extern string Currencygroupseparator { get; }

		public extern int Currencygroupsize { get; }

		public extern int Currencynegative { get; }

		public extern int Currencypositive { get; }

		public extern string Currencysymbol { get; }

		public extern int Numericdecimaldigits { get; }

		public extern string Numericdecimalseparator { get; }

		public extern string Numericgroupseparator { get; }

		public extern int Numericgroupsize { get; }

		public extern string Numericnegative { get; }

		public extern int Percentdecimaldigits { get; }

		public extern string Percentdecimalseparator { get; }

		public extern string Percentgroupseparator { get; }

		public extern int Percentgroupsize { get; }

		public extern int Percentnegative { get; }

		public extern int Percentpositive { get; }

		public extern string Percentsymbol { get; }

		public extern string Name { get; }

		public extern string NativeName { get; }

		public extern string EnglishName { get; }

		public extern string DateElementOrder { get; }

		public extern string Rfc1123 { get; }

		public extern string TwoDigitYearMax { get; }
	}

	private static CultureInfo currentCulture;

	public static string Yes => T("Да");

	public static string No => T("Нет");

	public static string Delete => T("Удалить");

	public static string Cancel => T("Отменить");

	public static string Save => T("Сохранить");

	public static string PleaseWait => T("Пожалуйста, подождите");

	public static string NoData => T("Нет данных");

	public static string Copy => T("Копировать");

	public static string Paste => T("Вставить");

	public static string Cut => T("Вырезать");

	public static string Untitled => T("<Без названия>");

	public static CultureInfo CurrentCulture => currentCulture;

	[Template("SR.{@}({t}, {*parameters})")]
	public static extern string T(string t, params object[] parameters);

	[Template("SR.{@}({t})")]
	public static extern string T(string t);

	public static void InitCulture()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		if (currentCulture == null)
		{
			ELMACultureInfo eLMACultureInfo = Script.Write<ELMACultureInfo>("elma.cultureInfo", new object[0]);
			if (eLMACultureInfo == null)
			{
				currentCulture = CultureInfo.get_InvariantCulture();
			}
			else
			{
				CultureInfo val = Script.Write<CultureInfo>("new System.Globalization.CultureInfo({0}, {1})", new object[2] { eLMACultureInfo.Name, true });
				val.set_EnglishName(eLMACultureInfo.EnglishName);
				val.set_NativeName(eLMACultureInfo.NativeName);
				DateTimeFormatInfo val2 = new DateTimeFormatInfo();
				val2.set_DateSeparator(eLMACultureInfo.DateSeparator);
				val2.set_DayNames(eLMACultureInfo.Days);
				val2.set_MonthNames(eLMACultureInfo.Months);
				val2.set_TimeSeparator(eLMACultureInfo.TimeSeparator);
				val2.set_MonthGenitiveNames(eLMACultureInfo.Months);
				val2.set_ShortestDayNames(eLMACultureInfo.AbbrDays);
				val2.set_AbbreviatedDayNames(eLMACultureInfo.AbbrDays);
				val2.set_AbbreviatedMonthNames(eLMACultureInfo.AbbrMonths);
				val2.set_AbbreviatedMonthGenitiveNames(eLMACultureInfo.AbbrMonths);
				val2.set_AMDesignator(eLMACultureInfo.Am);
				val2.set_PMDesignator(eLMACultureInfo.Pm);
				val2.set_LongDatePattern(eLMACultureInfo.LongDate);
				val2.set_LongTimePattern(eLMACultureInfo.LongTime);
				val2.set_YearMonthPattern(eLMACultureInfo.MonthYear);
				val2.set_MonthDayPattern(eLMACultureInfo.MonthDay);
				val2.set_ShortDatePattern(eLMACultureInfo.ShortDate);
				val2.set_ShortTimePattern(eLMACultureInfo.ShortTime);
				val2.set_FirstDayOfWeek((DayOfWeek)eLMACultureInfo.FirstDayOfWeek);
				val2.set_FullDateTimePattern(eLMACultureInfo.FullDateTime);
				val2.set_RFC1123Pattern(eLMACultureInfo.Rfc1123);
				val2.set_SortableDateTimePattern(eLMACultureInfo.SortableDateTime);
				val2.set_UniversalSortableDateTimePattern(eLMACultureInfo.UniversalSortableDateTime);
				val2.set_RoundtripFormat(CultureInfo.get_InvariantCulture().get_DateTimeFormat().get_RoundtripFormat());
				val.set_DateTimeFormat(val2);
				NumberFormatInfo val3 = new NumberFormatInfo();
				val3.set_CurrencySymbol(eLMACultureInfo.Currencysymbol);
				val3.set_PercentSymbol(eLMACultureInfo.Percentsymbol);
				val3.set_CurrencyDecimalDigits(eLMACultureInfo.Currencydecimaldigits);
				val3.set_CurrencyDecimalSeparator(eLMACultureInfo.Currencydecimalseparator);
				val3.set_CurrencyGroupSeparator(eLMACultureInfo.Currencygroupseparator);
				val3.set_CurrencyGroupSizes(new int[1] { eLMACultureInfo.Currencygroupsize });
				val3.set_CurrencyNegativePattern(eLMACultureInfo.Currencynegative);
				val3.set_CurrencyPositivePattern(eLMACultureInfo.Currencypositive);
				val3.set_NumberDecimalDigits(eLMACultureInfo.Numericdecimaldigits);
				val3.set_NumberDecimalSeparator(eLMACultureInfo.Numericdecimalseparator);
				val3.set_NumberGroupSeparator(eLMACultureInfo.Numericgroupseparator);
				val3.set_NumberGroupSizes(new int[1] { eLMACultureInfo.Numericgroupsize });
				((object)val3).set_Item("numberNegativePattern", (object)eLMACultureInfo.Numericnegative);
				val3.set_PercentDecimalDigits(eLMACultureInfo.Percentdecimaldigits);
				val3.set_PercentDecimalSeparator(eLMACultureInfo.Percentdecimalseparator);
				val3.set_PercentGroupSeparator(eLMACultureInfo.Percentgroupseparator);
				val3.set_PercentGroupSizes(new int[1] { eLMACultureInfo.Percentgroupsize });
				val3.set_PercentNegativePattern(eLMACultureInfo.Percentnegative);
				val3.set_PercentPositivePattern(eLMACultureInfo.Percentpositive);
				val3.set_NegativeInfinitySymbol(CultureInfo.get_InvariantCulture().get_NumberFormat().get_NegativeInfinitySymbol());
				val3.set_PositiveInfinitySymbol(CultureInfo.get_InvariantCulture().get_NumberFormat().get_PositiveInfinitySymbol());
				val3.set_NaNSymbol(CultureInfo.get_InvariantCulture().get_NumberFormat().get_NaNSymbol());
				val3.set_PositiveSign(CultureInfo.get_InvariantCulture().get_NumberFormat().get_PositiveSign());
				val3.set_NegativeSign(CultureInfo.get_InvariantCulture().get_NumberFormat().get_NegativeSign());
				val.set_NumberFormat(val3);
				currentCulture = val;
			}
			CultureInfo.set_CurrentCulture(currentCulture);
		}
	}
}
