// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.MarketingHelper
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Model.Ranges;
using System;
using System.Collections.Generic;
using System.Threading;

namespace EleWise.ELMA.CRM.Web.Components
{
  public static class MarketingHelper
  {
    public static List<DateTimeRange> GetPeriodList(MarketingPeriodEnum mode, DateTime currentDate)
    {
      List<DateTimeRange> periodList = new List<DateTimeRange>();
      switch (mode)
      {
        case MarketingPeriodEnum.Day:
          for (int index = 0; index <= 14; ++index)
            periodList.Add(new DateTimeRange(new DateTime?(currentDate.AddDays((double) (index - 14))), new DateTime?(currentDate.AddDays((double) (index - 14 + 1)).AddSeconds(-1.0))));
          break;
        case MarketingPeriodEnum.Week:
          DateTime firstDayOfWeek = MarketingHelper.GetFirstDayOfWeek(currentDate);
          for (int index = 0; index <= 6; ++index)
            periodList.Add(new DateTimeRange(new DateTime?(firstDayOfWeek.AddDays((double) ((index - 6) * 7))), new DateTime?(firstDayOfWeek.AddDays((double) ((index - 6 + 1) * 7)).AddSeconds(-1.0))));
          break;
        case MarketingPeriodEnum.Month:
          DateTime dateTime = new DateTime(currentDate.Year, currentDate.Month, 1);
          for (int index = 0; index <= 6; ++index)
            periodList.Add(new DateTimeRange(new DateTime?(dateTime.AddMonths(index - 6)), new DateTime?(dateTime.AddMonths(index - 6 + 1).AddDays(-1.0))));
          break;
      }
      return periodList;
    }

    public static DateTime GetFirstDayOfWeek(DateTime date) => date.AddDays((double) (Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek - date.DayOfWeek));

    public static string HeaderTableDateText(
      MarketingPeriodEnum mode,
      DateTime date1,
      DateTime date2)
    {
      switch (mode)
      {
        case MarketingPeriodEnum.Day:
          return string.Format("<span class=\"bold_text\">{0}</span> <span>{1}</span>", (object) EleWise.ELMA.SR.GetCurrentCulture().DateTimeFormat.AbbreviatedDayNames[(int) date1.DayOfWeek], (object) EleWise.ELMA.SR.T("{0:dd MMM}", (object) date1));
        case MarketingPeriodEnum.Week:
          string monthGenitiveName = EleWise.ELMA.SR.GetCurrentCulture().DateTimeFormat.MonthGenitiveNames[date1.Month - 1];
          string str = char.ToUpper(monthGenitiveName[0]).ToString() + monthGenitiveName.Substring(1);
          return string.Format("<span class=\"bold_text\">{0}-{1}</span> <span>{2}</span>", (object) EleWise.ELMA.SR.T("{0:dd}", (object) date1), (object) EleWise.ELMA.SR.T("{0:dd}", (object) date2), (object) str);
        case MarketingPeriodEnum.Month:
          return string.Format("<span class=\"bold_text\">{0}</span> <span>{1}</span>", (object) date1.ToString("MMMM"), (object) EleWise.ELMA.SR.Year(date1));
        default:
          return "";
      }
    }
  }
}
