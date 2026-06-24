using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models.SalesPlan;

public class CalendarModel
{
	public List<Month> Months { get; set; }

	public List<ISale> Sales { get; set; }

	public CalendarModel()
	{
	}

	public CalendarModel(int monthCount, DateTime startDate)
	{
		Months = new List<Month>();
		string name = startDate.ToString("MMMM", CultureInfo.CurrentCulture);
		List<Week> weeks = GetWeeks(startDate.Year, startDate.Month);
		Months.Add(new Month
		{
			Name = name,
			Weeks = weeks
		});
		if (monthCount > 1)
		{
			for (int i = 1; i < monthCount; i++)
			{
				string name2 = startDate.AddMonths(i).ToString("MMMM", CultureInfo.CurrentCulture);
				List<Week> weeks2 = GetWeeks(startDate.AddMonths(i).Year, startDate.AddMonths(i).Month).ToList();
				Months.Add(new Month
				{
					Name = name2,
					Weeks = weeks2
				});
			}
		}
	}

	public CalendarModel(int monthCount, DateTime startDate, List<ISale> sales, List<IPayment> actualPayments)
	{
		Months = new List<Month>();
		string name = startDate.ToString("MMMM", CultureInfo.CurrentCulture);
		List<Week> weeks = GetWeeks(startDate.Year, startDate.Month);
		Months.Add(new Month
		{
			Name = name,
			Weeks = weeks
		});
		if (monthCount > 1)
		{
			for (int i = 1; i < monthCount; i++)
			{
				string name2 = startDate.AddMonths(i).ToString("MMMM", CultureInfo.CurrentCulture);
				List<Week> weeks2 = GetWeeks(startDate.AddMonths(i).Year, startDate.AddMonths(i).Month).ToList();
				Months.Add(new Month
				{
					Name = name2,
					Weeks = weeks2
				});
			}
		}
		Sales = sales;
		foreach (Month month in Months)
		{
			foreach (Week week in month.Weeks)
			{
				week.Payments = actualPayments.Where((IPayment p) => p.PaymentDate >= week.FirstDay && p.PaymentDate <= week.LastDay).ToList();
			}
		}
	}

	private List<Week> GetWeeks(int year, int month)
	{
		DayOfWeek firstDayOfWeek = DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek;
		DateTime dateTime = new DateTime(year, month, 1);
		DayOfWeek num = ((dateTime.DayOfWeek != 0) ? dateTime.DayOfWeek : ((DayOfWeek)7));
		int num2 = (int)firstDayOfWeek;
		int num3 = (int)(num - num2);
		List<Week> list = new List<Week>();
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		int weekInMonth = GetWeekInMonth(new DateTime(year, month, DateTime.DaysInMonth(year, month)));
		for (byte b = 1; b <= weekInMonth; b = (byte)(b + 1))
		{
			Week week = ((b != 1) ? ((b != weekInMonth) ? new Week
			{
				FirstDay = new DateTime(year, month, (b - 1) * 7 - num3 + 1),
				LastDay = new DateTime(year, month, (b - 1) * 7 - num3 + 7)
			} : new Week
			{
				FirstDay = new DateTime(year, month, (b - 1) * 7 - num3 + 1),
				LastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month))
			}) : new Week
			{
				FirstDay = new DateTime(year, month, 1),
				LastDay = new DateTime(year, month, 7 - num3)
			});
			week.Number = currentCulture.Calendar.GetWeekOfYear(week.FirstDay, CalendarWeekRule.FirstFourDayWeek, DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);
			list.Add(week);
		}
		return list;
	}

	private int GetWeekInMonth(DateTime date)
	{
		DateTime time = date.AddDays(-date.Day + 1);
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		int weekOfYear = currentCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstDay, DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);
		return currentCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek) - weekOfYear + 2;
	}
}
