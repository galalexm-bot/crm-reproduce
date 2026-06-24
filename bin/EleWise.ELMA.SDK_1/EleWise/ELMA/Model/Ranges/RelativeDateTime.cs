// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Ranges.RelativeDateTime
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Ranges
{
  public class RelativeDateTime
  {
    internal static RelativeDateTime o4kOmAWz8LOMG9KUo2Pi;

    public RelativeDateTime()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public RelativeDateTime(DateTime? from, DateTime? to)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.IsRelative = false;
      this.RelativeFrom = (string) null;
      this.RelativeTo = (string) null;
      this.DateTimeRange = new DateTimeRange(from, to);
    }

    /// <summary>Ctor</summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    public RelativeDateTime(string from, string to)
    {
      RelativeDateTime.b2eoQNWzIK6xkGCR4PdF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.IsRelative = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.RelativeTo = to;
            num = 2;
            continue;
          default:
            this.RelativeFrom = from;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 3 : 3;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Относительная дата/время или нет</summary>
    public bool IsRelative
    {
      get => this.\u003CIsRelative\u003Ek__BackingField;
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
              this.\u003CIsRelative\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    /// <summary>Относительная дата From</summary>
    public string RelativeFrom
    {
      get => this.\u003CRelativeFrom\u003Ek__BackingField;
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
              this.\u003CRelativeFrom\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    /// <summary>Относительная дата To</summary>
    public string RelativeTo
    {
      get => this.\u003CRelativeTo\u003Ek__BackingField;
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
              this.\u003CRelativeTo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
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
    /// Дата/время (Диапазон), обычный DateTimeRange если дата абсолютная
    /// </summary>
    public DateTimeRange DateTimeRange
    {
      get => this.\u003CDateTimeRange\u003Ek__BackingField;
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
              this.\u003CDateTimeRange\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
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

    public DateTime? FromValue
    {
      get
      {
        if (!this.IsRelative)
          return this.DateTimeRange.From;
        DateTime? result;
        RelativeDateTimeParser.TryParseFromDate(this.RelativeFrom, out result);
        return result;
      }
    }

    public DateTime? ToValue
    {
      get
      {
        if (!this.IsRelative)
          return this.DateTimeRange.To;
        DateTime? result;
        RelativeDateTimeParser.TryParseToDate(this.RelativeTo, out result);
        return result;
      }
    }

    public static explicit operator DateTimeRange(RelativeDateTime rdt)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!RelativeDateTime.WykNQgWzVyydCgYJcUeU((object) rdt))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return rdt.DateTimeRange;
label_5:
      return new DateTimeRange(rdt.FromValue, rdt.ToValue);
    }

    internal static bool PKg7lxWzZhVk0AJ1LWek() => RelativeDateTime.o4kOmAWz8LOMG9KUo2Pi == null;

    internal static RelativeDateTime B2JOIrWzu1FjNpWURqQA() => RelativeDateTime.o4kOmAWz8LOMG9KUo2Pi;

    internal static void b2eoQNWzIK6xkGCR4PdF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool WykNQgWzVyydCgYJcUeU([In] object obj0) => ((RelativeDateTime) obj0).IsRelative;
  }
}
