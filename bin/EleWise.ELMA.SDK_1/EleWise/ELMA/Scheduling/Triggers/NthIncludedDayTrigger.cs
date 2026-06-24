// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Triggers.NthIncludedDayTrigger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.Core;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Scheduling.Triggers
{
  /// <summary>
  /// 
  /// </summary>
  public class NthIncludedDayTrigger : ITriggerExtension, ITrigger
  {
    private readonly IProductionSchedule productionSchedule;
    private readonly NthIncludedDaySettings nthIncludedDaySettings;
    internal static NthIncludedDayTrigger lhlLrJBXKE03VMTkGiFs;

    [Obsolete("Использовать конструктор с параметрами типов NthIncludedDaySettings, IProductionSchedule")]
    public NthIncludedDayTrigger(
      NthIncludedDaySettings nthIncludedDaySettings,
      IProductionCalendarService productionCalendar)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.productionSchedule = (IProductionSchedule) NthIncludedDayTrigger.GmxUBMBXn9CnMOTyonLX((object) productionCalendar);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          case 2:
            if (nthIncludedDaySettings != null)
            {
              if (productionCalendar == null)
              {
                num = 3;
                continue;
              }
              this.nthIncludedDaySettings = nthIncludedDaySettings;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 0;
              continue;
            }
            num = 4;
            continue;
          case 3:
            goto label_9;
          case 4:
            goto label_4;
          default:
            goto label_11;
        }
      }
label_2:
      return;
label_11:
      return;
label_4:
      throw new ArgumentNullException((string) NthIncludedDayTrigger.llAYy0BXkYTDeUCpIa2c(~541731958 ^ -541788495));
label_9:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239637730));
    }

    public NthIncludedDayTrigger(
      NthIncludedDaySettings nthIncludedDaySettings,
      IProductionSchedule productionSchedule)
    {
      NthIncludedDayTrigger.s1vxEoBXOeaIu6OP2MQa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (productionSchedule != null)
            {
              num = 5;
              continue;
            }
            goto label_6;
          case 3:
            goto label_8;
          case 4:
            if (nthIncludedDaySettings != null)
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 5:
            this.nthIncludedDaySettings = nthIncludedDaySettings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 6;
            continue;
          case 6:
            this.productionSchedule = productionSchedule;
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_8:
      return;
label_2:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957749384));
label_6:
      throw new ArgumentNullException((string) NthIncludedDayTrigger.llAYy0BXkYTDeUCpIa2c(-1638402543 ^ -1638476927));
    }

    /// <summary>Получить следующую дату выполнения</summary>
    /// <param name="dateTime">Время последнего запуска</param>
    /// <param name="now">Текущее время</param>
    /// <returns></returns>
    public virtual DateTime? GetNextTimeAfter(DateTime? dateTime, DateTime now)
    {
      if (!dateTime.HasValue)
        return new DateTime?(this.GetFirstStartTime());
      DateTime dateTime1 = dateTime.Value > this.nthIncludedDaySettings.StartDate ? dateTime.Value : this.nthIncludedDaySettings.StartDate;
      DateTime dateTime2 = dateTime1.Add(-dateTime1.TimeOfDay).Add(this.nthIncludedDaySettings.StartDate.TimeOfDay);
      Func<DateTime, IEnumerable<DateTime>> func;
      if (this.nthIncludedDaySettings.ScheduleType == ScheduleType.Daily)
        func = new Func<DateTime, IEnumerable<DateTime>>(this.GetDailySequenseDays);
      else if (this.nthIncludedDaySettings.ScheduleType == ScheduleType.Weekly)
        func = new Func<DateTime, IEnumerable<DateTime>>(this.GetWeeklySequenseDays);
      else if (this.nthIncludedDaySettings.ScheduleType == ScheduleType.Monthly)
      {
        func = new Func<DateTime, IEnumerable<DateTime>>(this.GetMonthlySequenseDays);
      }
      else
      {
        if (this.nthIncludedDaySettings.ScheduleType != ScheduleType.Once)
          throw new NotImplementedException();
        func = (Func<DateTime, IEnumerable<DateTime>>) (time =>
        {
          if (!(time <= this.nthIncludedDaySettings.StartDate))
            return (IEnumerable<DateTime>) new DateTime[0];
          return (IEnumerable<DateTime>) new DateTime[1]
          {
            this.nthIncludedDaySettings.StartDate
          };
        });
      }
      return func(dateTime2).SelectMany<DateTime, DateTime>((Func<DateTime, IEnumerable<DateTime>>) (d =>
      {
        if (!this.nthIncludedDaySettings.RepeatSettings.Enabled)
          return (IEnumerable<DateTime>) new DateTime[1]
          {
            d
          };
        if (this.nthIncludedDaySettings.RepeatSettings.RepeatEvery.TotalSeconds <= 0.0)
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138361396)));
        DateTime repeatTo = d.Add(-d.TimeOfDay).Add(this.nthIncludedDaySettings.RepeatSettings.RepeatTo);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return EleWise.ELMA.Extensions.CollectionExtensions.Unfold<DateTime>(d, (Func<DateTime, DateTime>) (v => NthIncludedDayTrigger.\u003C\u003Ec__DisplayClass4_0.QE1W0PQuQxNqSvE1glTJ(v, this.nthIncludedDaySettings.RepeatSettings.RepeatEvery)), (Func<DateTime, bool>) (v => NthIncludedDayTrigger.\u003C\u003Ec__DisplayClass4_1.N19dLpQuID1sNUIjbEsj(v, repeatTo)));
      })).TakeWhile<DateTime>((Func<DateTime, bool>) (v =>
      {
        int num1 = 5;
        DateTime? endAt;
        DateTime dateTime3;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                endAt = this.nthIncludedDaySettings.EndAt;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                continue;
              case 2:
                dateTime3 = v;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
                continue;
              case 3:
                goto label_7;
              case 4:
                goto label_9;
              case 5:
                if (this.nthIncludedDaySettings.EndAt.HasValue)
                  goto case 2;
                else
                  goto label_5;
              default:
                if (!endAt.HasValue)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 3;
                  continue;
                }
                goto label_8;
            }
          }
label_5:
          num1 = 4;
        }
label_7:
        return false;
label_8:
        // ISSUE: reference to a compiler-generated method
        return NthIncludedDayTrigger.\u003C\u003Ec__DisplayClass4_0.b8HG2KQuChYpmrpdawWB(dateTime3, endAt.GetValueOrDefault());
label_9:
        return true;
      })).Cast<DateTime?>().FirstOrDefault<DateTime?>((Func<DateTime?, bool>) (d =>
      {
        DateTime? nullable = d;
        DateTime dateTime4 = dateTime.Value;
        return nullable.HasValue && nullable.GetValueOrDefault() > dateTime4;
      }));
    }

    public TimeSpan OvertimeToRun => this.nthIncludedDaySettings.OvertimeToRun;

    /// <summary>Уникальный идентификатор триггера</summary>
    public Guid Id
    {
      get => this.\u003CId\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Название триггера</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Интервал, после истечения которого задача считается неактивной (повтор в несколько секунд округляется до минуты)
    /// </summary>
    public int? JobResultTimeout => this.nthIncludedDaySettings.RepeatSettings.Enabled ? new int?(this.nthIncludedDaySettings.RepeatSettings.RepeatEvery.Minutes > 0 ? this.nthIncludedDaySettings.RepeatSettings.RepeatEvery.Minutes : 1) : new int?();

    public IEnumerable<DateTime> GetDailySequenseDays(DateTime from) => this.nthIncludedDaySettings.DailySettings.EveryDay <= 0 ? (IEnumerable<DateTime>) new List<DateTime>() : this.EverydaySequenceGenerator(from).Where<DateTime>((Func<DateTime, bool>) (d =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.nthIncludedDaySettings.DailySettings.OnlyWorkDays)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return NthIncludedDayTrigger.kNMRtqBX2J4qO1ym3qkB((object) this.productionSchedule, d);
label_3:
      return true;
    })).Where<DateTime>((Func<DateTime, int, bool>) ((d, i) => i % this.nthIncludedDaySettings.DailySettings.EveryDay == 0));

    private IEnumerable<DateTime> EverydaySequenceGenerator(DateTime from) => (IEnumerable<DateTime>) new NthIncludedDayTrigger.\u003CEverydaySequenceGenerator\u003Ed__18(-2)
    {
      \u003C\u003E3__from = from
    };

    public IEnumerable<DateTime> GetMonthlySequenseDays(DateTime from) => (IEnumerable<DateTime>) new NthIncludedDayTrigger.\u003CGetMonthlySequenseDays\u003Ed__19(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__from = from
    };

    public IEnumerable<DateTime> GetWeeklySequenseDays(DateTime from) => (IEnumerable<DateTime>) new NthIncludedDayTrigger.\u003CGetWeeklySequenseDays\u003Ed__20(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__from = from
    };

    /// <summary>Получить начало и конец недели по любому дню недели</summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public Pair<DateTime, DateTime> GetWeekRange(DateTime date)
    {
      CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
      DayOfWeek firstDayOfWeek = currentCulture.DateTimeFormat.FirstDayOfWeek;
      int num = currentCulture.Calendar.GetDayOfWeek(date) - firstDayOfWeek;
      if (num < 0)
        num += 7;
      DateTime first = date.AddDays((double) -num);
      DateTime second = first.AddDays(6.0);
      return new Pair<DateTime, DateTime>(first, second);
    }

    private DateTime GetFirstStartTime()
    {
      int num = 5;
      DateTime firstStartTime;
      ScheduleType scheduleType;
      while (true)
      {
        switch (num)
        {
          case 3:
            firstStartTime = this.GetWeeklySequenseDays(this.nthIncludedDaySettings.StartDate).First<DateTime>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
            continue;
          case 4:
            if (scheduleType != ScheduleType.Weekly)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 6;
              continue;
            }
            goto case 3;
          case 5:
            scheduleType = this.nthIncludedDaySettings.ScheduleType;
            num = 4;
            continue;
          case 6:
            if (scheduleType == ScheduleType.Monthly)
            {
              num = 7;
              continue;
            }
            goto case 8;
          case 7:
            firstStartTime = this.GetMonthlySequenseDays(this.nthIncludedDaySettings.StartDate).First<DateTime>();
            num = 2;
            continue;
          case 8:
            firstStartTime = this.nthIncludedDaySettings.StartDate;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return firstStartTime;
    }

    internal static object llAYy0BXkYTDeUCpIa2c(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object GmxUBMBXn9CnMOTyonLX([In] object obj0) => (object) ((IProductionCalendarService) obj0).GetGlobalProductionSchedule();

    internal static bool kgRfQEBXXFh2etWnftDN() => NthIncludedDayTrigger.lhlLrJBXKE03VMTkGiFs == null;

    internal static NthIncludedDayTrigger cVCVORBXTHLOOMAN2bs6() => NthIncludedDayTrigger.lhlLrJBXKE03VMTkGiFs;

    internal static void s1vxEoBXOeaIu6OP2MQa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kNMRtqBX2J4qO1ym3qkB([In] object obj0, DateTime runtimeDateTime) => ((IProductionSchedule) obj0).IsWorkDay(runtimeDateTime);
  }
}
