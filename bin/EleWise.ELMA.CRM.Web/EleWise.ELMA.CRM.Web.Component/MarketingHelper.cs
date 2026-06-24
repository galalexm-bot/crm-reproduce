using System;
using System.Collections.Generic;
using System.Threading;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.CRM.Web.Components;

public static class MarketingHelper
{
	public static List<DateTimeRange> GetPeriodList(MarketingPeriodEnum mode, DateTime currentDate)
	{
		List<DateTimeRange> list = new List<DateTimeRange>();
		switch (mode)
		{
		case MarketingPeriodEnum.Day:
		{
			for (int j = 0; j <= 14; j++)
			{
				list.Add(new DateTimeRange(currentDate.AddDays(-14 + j), currentDate.AddDays(-14 + j + 1).AddSeconds(-1.0)));
			}
			break;
		}
		case MarketingPeriodEnum.Week:
		{
			DateTime firstDayOfWeek = GetFirstDayOfWeek(currentDate);
			for (int k = 0; k <= 6; k++)
			{
				list.Add(new DateTimeRange(firstDayOfWeek.AddDays((-6 + k) * 7), firstDayOfWeek.AddDays((-6 + k + 1) * 7).AddSeconds(-1.0)));
			}
			break;
		}
		case MarketingPeriodEnum.Month:
		{
			DateTime dateTime = new DateTime(currentDate.Year, currentDate.Month, 1);
			for (int i = 0; i <= 6; i++)
			{
				list.Add(new DateTimeRange(dateTime.AddMonths(-6 + i), dateTime.AddMonths(-6 + i + 1).AddDays(-1.0)));
			}
			break;
		}
		}
		return list;
	}

	public static DateTime GetFirstDayOfWeek(DateTime date)
	{
		return date.AddDays(Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek - date.DayOfWeek);
	}

	public static string HeaderTableDateText(MarketingPeriodEnum mode, DateTime date1, DateTime date2)
	{
		switch (mode)
		{
		case MarketingPeriodEnum.Day:
			return string.Format("<span class=\"bold_text\">{0}</span> <span>{1}</span>", SR.GetCurrentCulture().DateTimeFormat.AbbreviatedDayNames[(int)date1.DayOfWeek], SR.T("{0:dd MMM}", date1));
		case MarketingPeriodEnum.Week:
		{
			string text = SR.GetCurrentCulture().DateTimeFormat.MonthGenitiveNames[date1.Month - 1];
			text = char.ToUpper(text[0]) + text.Substring(1);
			return string.Format("<span class=\"bold_text\">{0}-{1}</span> <span>{2}</span>", SR.T("{0:dd}", date1), SR.T("{0:dd}", date2), text);
		}
		case MarketingPeriodEnum.Month:
			return string.Format("<span class=\"bold_text\">{0}</span> <span>{1}</span>", date1.ToString("MMMM"), SR.Year(date1));
		default:
			return "";
		}
	}
}
