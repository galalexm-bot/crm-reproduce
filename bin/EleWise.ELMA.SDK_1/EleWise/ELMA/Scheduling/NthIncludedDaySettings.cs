// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.NthIncludedDaySettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Scheduling
{
  [Serializable]
  public class NthIncludedDaySettings : ICloneable
  {
    /// <summary>Начало работы триггера</summary>
    public DateTime StartDate;
    /// <summary>Завершение работы триггера</summary>
    public DateTime? EndAt;
    /// <summary>Тип расписания: ежедневно, еженедельно, ...</summary>
    public ScheduleType ScheduleType;
    /// <summary>Настройки ежедневного запуска</summary>
    [NotNull]
    public DailySettings DailySettings;
    /// <summary>Настройки еженедельного запуска</summary>
    [NotNull]
    public WeeklySettings WeeklySettings;
    /// <summary>Настройки ежемесячного запуска</summary>
    [NotNull]
    public MonthlySettings MonthlySettings;
    [NotNull]
    public RepeatSettings RepeatSettings;
    /// <summary>
    /// Время, через которое еще можно выполнить задачу, если в нужное время выполнить не получилось по какой-то причине (например не был запущен сервер).
    /// </summary>
    [XmlIgnore]
    [NotNull]
    public TimeSpan OvertimeToRun;
    public static readonly TimeSpan DefaultOvertimeToRun;
    internal static NthIncludedDaySettings DY1hV4BK0o74iqkaWNK7;

    public long OvertimeToRunTicks
    {
      get => this.OvertimeToRun.Ticks;
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
              this.OvertimeToRun = new TimeSpan(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
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
    /// Creates a new object that is a copy of the current instance.
    /// </summary>
    /// <returns>A new object that is a copy of this instance.</returns>
    /// <filterpriority>2</filterpriority>
    public object Clone() => (object) ClassSerializationHelper.CloneObject<NthIncludedDaySettings>(this);

    [XmlIgnore]
    public DateTime StartDateProperty
    {
      get => this.StartDate;
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
              this.StartDate = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
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

    [XmlIgnore]
    public ScheduleType ScheduleTypeProperty
    {
      get => this.ScheduleType;
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
              this.ScheduleType = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    [XmlIgnore]
    public DailySettings DailySettingsProperty
    {
      get => this.DailySettings;
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
              this.DailySettings = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
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

    [XmlIgnore]
    public WeeklySettings WeeklySettingsProperty
    {
      get => this.WeeklySettings;
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
              this.WeeklySettings = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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

    [XmlIgnore]
    public MonthlySettings MonthlySettingsProperty
    {
      get => this.MonthlySettings;
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
              this.MonthlySettings = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    [XmlIgnore]
    public RepeatSettings RepeatSettingsProperty
    {
      get => this.RepeatSettings;
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
              this.RepeatSettings = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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

    public bool Validate(List<string> errors)
    {
      switch (this.ScheduleType)
      {
        case ScheduleType.Daily:
          return this.DailySettings.Validate(errors);
        case ScheduleType.Weekly:
          return this.WeeklySettings.Validate(errors);
        case ScheduleType.Monthly:
          return this.MonthlySettings.Validate(errors);
        default:
          return true;
      }
    }

    public NthIncludedDaySettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.StartDate = NthIncludedDaySettings.hchGSZBKMXulL5xOM3m0();
      this.ScheduleType = ScheduleType.Daily;
      this.DailySettings = new DailySettings();
      this.WeeklySettings = new WeeklySettings();
      this.MonthlySettings = new MonthlySettings();
      this.RepeatSettings = new RepeatSettings();
      this.OvertimeToRun = NthIncludedDaySettings.DefaultOvertimeToRun;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static NthIncludedDaySettings()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            NthIncludedDaySettings.DefaultOvertimeToRun = TimeSpan.FromMinutes(2.0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          case 2:
            NthIncludedDaySettings.vgtb5vBKJK4QWuV7fP2c();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool uSkUQ7BKmNAVnXebcqYw() => NthIncludedDaySettings.DY1hV4BK0o74iqkaWNK7 == null;

    internal static NthIncludedDaySettings EQMKY2BKyoprV5eQvWLt() => NthIncludedDaySettings.DY1hV4BK0o74iqkaWNK7;

    internal static DateTime hchGSZBKMXulL5xOM3m0() => DateTime.Now;

    internal static void vgtb5vBKJK4QWuV7fP2c() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
