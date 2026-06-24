// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.RelativeDateTimeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [XmlRoot("RelativeDateTimeValue")]
  [Component]
  public class RelativeDateTimeWrapper : IXsiType
  {
    internal static RelativeDateTimeWrapper C4RHiKbbybbdVl5J192A;

    public RelativeDateTimeWrapper()
    {
      RelativeDateTimeWrapper.hesuwabb9IKCcC4Hrxvv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public RelativeDateTimeWrapper(RelativeDateTime source)
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
            this.RelativeFrom = (string) RelativeDateTimeWrapper.esQx1obbry76tDWZT4NC((object) source);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 4 : 0;
            continue;
          case 2:
            this.IsRelative = RelativeDateTimeWrapper.YdpJVYbbdZCRQQmPcY4a((object) source);
            num = 3;
            continue;
          case 3:
            this.DateTimeRange = new DateTimeRangeWrapper(RelativeDateTimeWrapper.h4O8VBbblPBbapeIrLnx((object) source));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
            continue;
          case 4:
            this.RelativeTo = (string) RelativeDateTimeWrapper.V5Eyp9bbg0f52YwymTDM((object) source);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    [XmlElement("DateTimeRange")]
    public DateTimeRangeWrapper DateTimeRange
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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

    [XmlElement("IsRelative")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
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

    [XmlElement("RelativeFrom")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
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

    [XmlElement("RelativeTo")]
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

    [XmlElement("From")]
    public DateTime? From { get; set; }

    [XmlElement("To")]
    public DateTime? To { get; set; }

    internal static void hesuwabb9IKCcC4Hrxvv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Bjh2XabbMr2Xh84M0to6() => RelativeDateTimeWrapper.C4RHiKbbybbdVl5J192A == null;

    internal static RelativeDateTimeWrapper MuUq5DbbJDx25o1gBKXP() => RelativeDateTimeWrapper.C4RHiKbbybbdVl5J192A;

    internal static bool YdpJVYbbdZCRQQmPcY4a([In] object obj0) => ((RelativeDateTime) obj0).IsRelative;

    internal static EleWise.ELMA.Model.Ranges.DateTimeRange h4O8VBbblPBbapeIrLnx([In] object obj0) => ((RelativeDateTime) obj0).DateTimeRange;

    internal static object esQx1obbry76tDWZT4NC([In] object obj0) => (object) ((RelativeDateTime) obj0).RelativeFrom;

    internal static object V5Eyp9bbg0f52YwymTDM([In] object obj0) => (object) ((RelativeDateTime) obj0).RelativeTo;
  }
}
