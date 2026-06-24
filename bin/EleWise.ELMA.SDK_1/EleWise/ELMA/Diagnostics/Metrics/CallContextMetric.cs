// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.CallContextMetric
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
  /// <summary>Метрики контекста исполнения</summary>
  public class CallContextMetric : CountTimeMetric
  {
    private static CallContextMetric zWEAaPE8mxPX4RbqKZvV;

    /// <summary>Ctor</summary>
    public CallContextMetric()
    {
      CallContextMetric.Tjiw09E8JSJv1cA0m2dw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Metrics = new MetricsContainer();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override Guid Uid => new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470197500));

    /// <summary>
    /// Общее количество времени, которое потратил поток на обработку процессором
    /// </summary>
    [Order(310)]
    [DisplayName(typeof (CallContextMetric.__CallContextMetricLocalization), "TotalProcessorTime")]
    public TimeSpan TotalProcessorTime
    {
      get => this.\u003CTotalProcessorTime\u003Ek__BackingField;
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
              this.\u003CTotalProcessorTime\u003Ek__BackingField = value;
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
    /// Общее количество времени, которое поток потратил на выполнение кода внутри приложения
    /// </summary>
    [DisplayName(typeof (CallContextMetric.__CallContextMetricLocalization), "UserProcessorTime")]
    [Order(320)]
    public TimeSpan UserProcessorTime
    {
      get => this.\u003CUserProcessorTime\u003Ek__BackingField;
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
              this.\u003CUserProcessorTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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

    /// <summary>Метрики</summary>
    public MetricsContainer Metrics
    {
      get => this.\u003CMetrics\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMetrics\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
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
      int num = 7;
      CallContextMetric callContextMetric;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_9;
          case 1:
            this.Metrics.Merge((MetricsContainer) CallContextMetric.ECkq38E8lbLBflDIb6B0((object) callContextMetric));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.UserProcessorTime = CallContextMetric.U77PE9E8dtsTVdMv2T8d(this.UserProcessorTime, callContextMetric.UserProcessorTime);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
            continue;
          case 4:
            this.TotalProcessorTime = CallContextMetric.U77PE9E8dtsTVdMv2T8d(this.TotalProcessorTime, CallContextMetric.GtaK77E895pCRy84iPik((object) callContextMetric));
            num = 3;
            continue;
          case 5:
            base.Merge(metric);
            num = 4;
            continue;
          case 6:
            if (callContextMetric == null)
            {
              num = 2;
              continue;
            }
            goto case 5;
          case 7:
            callContextMetric = metric as CallContextMetric;
            num = 6;
            continue;
          default:
            goto label_11;
        }
      }
label_9:
      return;
label_2:
      return;
label_11:;
    }

    internal static void Tjiw09E8JSJv1cA0m2dw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool oZ7AucE8ycBovdOQsUF9() => CallContextMetric.zWEAaPE8mxPX4RbqKZvV == null;

    internal static CallContextMetric qGeutME8M7SniqJj9ADy() => CallContextMetric.zWEAaPE8mxPX4RbqKZvV;

    internal static TimeSpan GtaK77E895pCRy84iPik([In] object obj0) => ((CallContextMetric) obj0).TotalProcessorTime;

    internal static TimeSpan U77PE9E8dtsTVdMv2T8d([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 + obj1;

    internal static object ECkq38E8lbLBflDIb6B0([In] object obj0) => (object) ((CallContextMetric) obj0).Metrics;

    internal static class __CallContextMetricLocalization
    {
      private static CallContextMetric.__CallContextMetricLocalization mVVuqs8KvmOqnajKjSLH;

      public static string TotalProcessorTime => (string) CallContextMetric.__CallContextMetricLocalization.CTIh428KIQ6L8Yj5JBOi(CallContextMetric.__CallContextMetricLocalization.fUCrrb8KuoFMKIRZeplv(1021410165 ^ 1021614263));

      public static string UserProcessorTime => (string) CallContextMetric.__CallContextMetricLocalization.CTIh428KIQ6L8Yj5JBOi((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516667162));

      internal static object fUCrrb8KuoFMKIRZeplv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object CTIh428KIQ6L8Yj5JBOi([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool MpWXmW8K8P5Ybkxdocfc() => CallContextMetric.__CallContextMetricLocalization.mVVuqs8KvmOqnajKjSLH == null;

      internal static CallContextMetric.__CallContextMetricLocalization ROiIAn8KZLwahBTiRlfG() => CallContextMetric.__CallContextMetricLocalization.mVVuqs8KvmOqnajKjSLH;
    }
  }
}
