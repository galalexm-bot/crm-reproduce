// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.MonthlySettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;

namespace EleWise.ELMA.Scheduling
{
  [Serializable]
  public class MonthlySettings
  {
    public static readonly Collection<int> AllMonths;
    /// <summary>Месяцы запуска (от 1 до 12)</summary>
    public Collection<int> Months;
    public MonthlySettings.MonthDaySelectionType DaySelectionType;
    /// <summary>День месяца (1-31)</summary>
    public int MonthDay;
    /// <summary>Рабочий день месяца</summary>
    public int MonthWorkDay;
    /// <summary>день недели</summary>
    public DayOfWeek DayOfWeek;
    /// <summary>
    /// Неделя месяца (1-5)
    /// TODO нужно обозначить как то последнюю неделю месяца
    /// </summary>
    public int WeekOfMonth;
    private static MonthlySettings OS1NYQBKO7GXl1S86Jci;

    [XmlIgnore]
    public Collection<int> MonthsProperty
    {
      get => this.Months;
      set => this.Months = value;
    }

    [XmlIgnore]
    public MonthlySettings.MonthDaySelectionType DaySelectionTypeProperty
    {
      get => this.DaySelectionType;
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
              this.DaySelectionType = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
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
    public int MonthDayProperty
    {
      get => this.MonthDay;
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
              this.MonthDay = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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
    public int MonthWorkDayProperty
    {
      get => this.MonthWorkDay;
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
              this.MonthWorkDay = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
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
    public DayOfWeek DayOfWeekProperty
    {
      get => this.DayOfWeek;
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
              this.DayOfWeek = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
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
    public int WeekOfMonthProperty
    {
      get => this.WeekOfMonth;
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
              this.WeekOfMonth = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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
      if (this.DaySelectionType == MonthlySettings.MonthDaySelectionType.MonthDay)
      {
        DateTime nowDate = DateTime.Now;
        int num = 31;
        if (this.Months.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          num = this.Months.Select<int, int>((Func<int, int>) (m => MonthlySettings.\u003C\u003Ec__DisplayClass26_0.iZfYm4QZYQMha0c8iys4(nowDate.Year, m))).Min();
        }
        if (this.MonthDay < 1 || this.MonthDay > num)
        {
          errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475800311), (object) num));
          return false;
        }
      }
      if (this.DaySelectionType == MonthlySettings.MonthDaySelectionType.MonthWorkDay && (this.MonthWorkDay < 1 || this.MonthWorkDay > 24))
      {
        errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345477128)));
        return false;
      }
      if (this.Months.Count != 0)
        return true;
      errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825443216)));
      return false;
    }

    public MonthlySettings()
    {
      MonthlySettings.z2fFRoBKP0rnm2xrfkJc();
      this.Months = new Collection<int>();
      this.MonthDay = 1;
      this.MonthWorkDay = 1;
      this.DayOfWeek = DayOfWeek.Monday;
      this.WeekOfMonth = 1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static MonthlySettings()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            MonthlySettings.AllMonths = new Collection<int>()
            {
              1,
              2,
              3,
              4,
              5,
              6,
              7,
              8,
              9,
              10,
              11,
              12
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool NuSgO7BK21gVTp0d0uFO() => MonthlySettings.OS1NYQBKO7GXl1S86Jci == null;

    internal static MonthlySettings vDjDgVBKetQFmRn5funr() => MonthlySettings.OS1NYQBKO7GXl1S86Jci;

    internal static void z2fFRoBKP0rnm2xrfkJc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public enum MonthDaySelectionType
    {
      /// <summary>В какой то день месяца</summary>
      MonthDay,
      /// <summary>в какой то рабочий день месяца</summary>
      MonthWorkDay,
      /// <summary>
      /// в какой то день недели, например, в первый понедельник месяца
      /// </summary>
      MothDayOfWeek,
      /// <summary>в последний день месяца</summary>
      LastDay,
    }
  }
}
