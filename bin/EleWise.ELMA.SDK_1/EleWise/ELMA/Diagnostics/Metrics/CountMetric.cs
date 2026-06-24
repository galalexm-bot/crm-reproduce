// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.CountMetric
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>
  /// Метрика, способная подсчитывать количество вызовов и ошибок
  /// </summary>
  public class CountMetric : BaseExpandableMetric
  {
    internal static CountMetric mhIXWlE8rqA3vBS9EcQ0;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) CountMetric.YwLo0xE8j1x0rfVqAoSY(-1350312861 << 3 ^ 2082123498));

    /// <summary>Количество вызовов</summary>
    [Order(100)]
    [DisplayName(typeof (CountMetric.__CountMetricLocalization), "CountCall")]
    public long CountCall
    {
      get => this.\u003CCountCall\u003Ek__BackingField;
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
              this.\u003CCountCall\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

    /// <summary>Количество вызовов, завершившихся ошибкой</summary>
    [DisplayName(typeof (CountMetric.__CountMetricLocalization), "CountErrorCall")]
    [Order(200)]
    public long CountErrorCall
    {
      get => this.\u003CCountErrorCall\u003Ek__BackingField;
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
              this.\u003CCountErrorCall\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public override void Merge(IMetric metric)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        CountMetric countMetric;
        while (true)
        {
          switch (num2)
          {
            case 1:
              countMetric = metric as CountMetric;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            case 2:
              base.Merge(metric);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 2;
              continue;
            case 3:
              goto label_6;
            case 4:
              this.CountCall += countMetric.CountCall;
              num2 = 3;
              continue;
            case 5:
              goto label_9;
            case 6:
              goto label_3;
            default:
              if (countMetric == null)
              {
                num2 = 5;
                continue;
              }
              goto case 2;
          }
        }
label_6:
        this.CountErrorCall += CountMetric.pYAb2rE8YuHwgrCbFYDJ((object) countMetric);
        num1 = 6;
      }
label_9:
      return;
label_3:;
    }

    public CountMetric()
    {
      CountMetric.jYCZeEE8LNXD1iLBbbNL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object YwLo0xE8j1x0rfVqAoSY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool stl7qrE8g0f6rWwZfaEE() => CountMetric.mhIXWlE8rqA3vBS9EcQ0 == null;

    internal static CountMetric vpN2lcE85nv0n6XFAShy() => CountMetric.mhIXWlE8rqA3vBS9EcQ0;

    internal static long pYAb2rE8YuHwgrCbFYDJ([In] object obj0) => ((CountMetric) obj0).CountErrorCall;

    internal static void jYCZeEE8LNXD1iLBbbNL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static class __CountMetricLocalization
    {
      internal static CountMetric.__CountMetricLocalization xVG8EV8KV4Ajmb8ag7UX;

      public static string CountCall => (string) CountMetric.__CountMetricLocalization.KCvQ8y8KqsVOOsQnpawv(CountMetric.__CountMetricLocalization.MNDRxu8KRURmubeF3ZWb(-16752921 ^ -16401813));

      public static string CountErrorCall => (string) CountMetric.__CountMetricLocalization.KCvQ8y8KqsVOOsQnpawv(CountMetric.__CountMetricLocalization.MNDRxu8KRURmubeF3ZWb(44884861 ^ 44632009));

      internal static object MNDRxu8KRURmubeF3ZWb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object KCvQ8y8KqsVOOsQnpawv([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool mWRscp8KSOEhm2KIlSRU() => CountMetric.__CountMetricLocalization.xVG8EV8KV4Ajmb8ag7UX == null;

      internal static CountMetric.__CountMetricLocalization sNqksR8KixnbOaUh46wU() => CountMetric.__CountMetricLocalization.xVG8EV8KV4Ajmb8ag7UX;
    }
  }
}
