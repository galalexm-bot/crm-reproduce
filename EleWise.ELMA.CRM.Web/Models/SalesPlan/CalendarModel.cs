// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.SalesPlan.CalendarModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models.SalesPlan
{
  public class CalendarModel
  {
    public List<Month> Months { get; set; }

    public List<ISale> Sales { get; set; }

    public CalendarModel()
    {
    }

    public CalendarModel(int monthCount, DateTime startDate)
    {
      this.Months = new List<Month>();
      string str1 = startDate.ToString("MMMM", (IFormatProvider) CultureInfo.CurrentCulture);
      List<Week> weeks = this.GetWeeks(startDate.Year, startDate.Month);
      this.Months.Add(new Month()
      {
        Name = str1,
        Weeks = weeks
      });
      if (monthCount <= 1)
        return;
      for (int months = 1; months < monthCount; ++months)
      {
        DateTime dateTime = startDate.AddMonths(months);
        string str2 = dateTime.ToString("MMMM", (IFormatProvider) CultureInfo.CurrentCulture);
        dateTime = startDate.AddMonths(months);
        int year = dateTime.Year;
        dateTime = startDate.AddMonths(months);
        int month = dateTime.Month;
        List<Week> list = this.GetWeeks(year, month).ToList<Week>();
        this.Months.Add(new Month()
        {
          Name = str2,
          Weeks = list
        });
      }
    }

    public CalendarModel(
      int monthCount,
      DateTime startDate,
      List<ISale> sales,
      List<IPayment> actualPayments)
    {
      this.Months = new List<Month>();
      string str1 = startDate.ToString("MMMM", (IFormatProvider) CultureInfo.CurrentCulture);
      List<Week> weeks = this.GetWeeks(startDate.Year, startDate.Month);
      this.Months.Add(new Month()
      {
        Name = str1,
        Weeks = weeks
      });
      if (monthCount > 1)
      {
        for (int months = 1; months < monthCount; ++months)
        {
          DateTime dateTime = startDate.AddMonths(months);
          string str2 = dateTime.ToString("MMMM", (IFormatProvider) CultureInfo.CurrentCulture);
          dateTime = startDate.AddMonths(months);
          int year = dateTime.Year;
          dateTime = startDate.AddMonths(months);
          int month = dateTime.Month;
          List<Week> list = this.GetWeeks(year, month).ToList<Week>();
          this.Months.Add(new Month()
          {
            Name = str2,
            Weeks = list
          });
        }
      }
      this.Sales = sales;
      foreach (Month month in this.Months)
      {
        foreach (Week week1 in month.Weeks)
        {
          Week week = week1;
          week.Payments = actualPayments.Where<IPayment>((Func<IPayment, bool>) (p => p.PaymentDate >= week.FirstDay && p.PaymentDate <= week.LastDay)).ToList<IPayment>();
        }
      }
    }

    private List<Week> GetWeeks(int year, int month)
    {
      DayOfWeek firstDayOfWeek = DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek;
      DateTime dateTime = new DateTime(year, month, 1);
      int num = (int) ((dateTime.DayOfWeek != DayOfWeek.Sunday ? (int) dateTime.DayOfWeek : 7) - firstDayOfWeek);
      List<Week> weeks = new List<Week>();
      CultureInfo currentCulture = CultureInfo.CurrentCulture;
      int weekInMonth = this.GetWeekInMonth(new DateTime(year, month, DateTime.DaysInMonth(year, month)));
      for (byte index = 1; (int) index <= weekInMonth; ++index)
      {
        Week week;
        if (index == (byte) 1)
          week = new Week()
          {
            FirstDay = new DateTime(year, month, 1),
            LastDay = new DateTime(year, month, 7 - num)
          };
        else if ((int) index == weekInMonth)
          week = new Week()
          {
            FirstDay = new DateTime(year, month, ((int) index - 1) * 7 - num + 1),
            LastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month))
          };
        else
          week = new Week()
          {
            FirstDay = new DateTime(year, month, ((int) index - 1) * 7 - num + 1),
            LastDay = new DateTime(year, month, ((int) index - 1) * 7 - num + 7)
          };
        week.Number = currentCulture.Calendar.GetWeekOfYear(week.FirstDay, CalendarWeekRule.FirstFourDayWeek, DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);
        weeks.Add(week);
      }
      return weeks;
    }

    private int GetWeekInMonth(DateTime date)
    {
      DateTime time = date.AddDays((double) (-date.Day + 1));
      CultureInfo currentCulture = CultureInfo.CurrentCulture;
      int weekOfYear = currentCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstDay, DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);
      return currentCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek) - weekOfYear + 2;
    }
  }
}
