// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Processors.CountTimeMetricProcessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Processors
{
  /// <summary>Обработчик метрик, наследуемых от CountTimeMetric</summary>
  [Component(Order = -5)]
  public class CountTimeMetricProcessor : IMetricProcessor
  {
    private readonly Type baseMetricAggregatorType;
    internal static CountTimeMetricProcessor W1x4bIEIBL8rbXuN4U6X;

    /// <inheritdoc />
    public Type[] AggregatorTypes => new Type[1]
    {
      this.baseMetricAggregatorType
    };

    /// <inheritdoc />
    public void Process(object callInfo, IMetric currentMetric)
    {
      int num1 = 1;
      CountTimeMetric countTimeMetric1;
      IWorkTreeElement workTreeElement;
      TimeSpan timeSpan;
      while (true)
      {
        switch (num1)
        {
          case 1:
            countTimeMetric1 = currentMetric as CountTimeMetric;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (workTreeElement != null)
            {
              num1 = 6;
              continue;
            }
            goto label_15;
          case 4:
            CountTimeMetric countTimeMetric2 = countTimeMetric1;
            CountTimeMetricProcessor.XrbKK0EIG8A2eJAImQFd((object) countTimeMetric2, CountTimeMetricProcessor.XZ4jmsEIbWY9dB1746wn((object) countTimeMetric2) + CountTimeMetricProcessor.AcvPpqEIhqN9u1YNlqva((object) workTreeElement));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 7;
            continue;
          case 5:
            goto label_6;
          case 6:
            if (countTimeMetric1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 4 : 4;
              continue;
            }
            goto label_2;
          case 7:
            double num2 = CountTimeMetricProcessor.s69OZqEIEkNIDV1yxUm2((object) countTimeMetric1);
            timeSpan = CountTimeMetricProcessor.AcvPpqEIhqN9u1YNlqva((object) workTreeElement);
            double totalMilliseconds1 = timeSpan.TotalMilliseconds;
            if (num2 < totalMilliseconds1)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 8;
              continue;
            }
            goto label_16;
          case 8:
            CountTimeMetric countTimeMetric3 = countTimeMetric1;
            timeSpan = CountTimeMetricProcessor.AcvPpqEIhqN9u1YNlqva((object) workTreeElement);
            double totalMilliseconds2 = timeSpan.TotalMilliseconds;
            CountTimeMetricProcessor.gWsTg6EIfuOmwMdCgG6F((object) countTimeMetric3, totalMilliseconds2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 2;
            continue;
          default:
            workTreeElement = callInfo as IWorkTreeElement;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 3 : 2;
            continue;
        }
      }
label_3:
      return;
label_6:
      return;
label_16:
      return;
label_2:
      return;
label_15:;
    }

    public CountTimeMetricProcessor()
    {
      CountTimeMetricProcessor.wB1kWPEIQ75R6vx0ShB1();
      // ISSUE: type reference
      this.baseMetricAggregatorType = CountTimeMetricProcessor.eJZZwEEIC1RQnlCtE94E(__typeref (BaseMetricAggregator<>));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool K6h9L5EIW6WdrLXDPABq() => CountTimeMetricProcessor.W1x4bIEIBL8rbXuN4U6X == null;

    internal static CountTimeMetricProcessor xWnZ8DEIoOOVVk6KLblC() => CountTimeMetricProcessor.W1x4bIEIBL8rbXuN4U6X;

    internal static TimeSpan XZ4jmsEIbWY9dB1746wn([In] object obj0) => ((CountTimeMetric) obj0).TotalTime;

    internal static TimeSpan AcvPpqEIhqN9u1YNlqva([In] object obj0) => ((IWorkTreeElement) obj0).TotalTime;

    internal static void XrbKK0EIG8A2eJAImQFd([In] object obj0, TimeSpan value) => ((CountTimeMetric) obj0).TotalTime = value;

    internal static double s69OZqEIEkNIDV1yxUm2([In] object obj0) => ((CountTimeMetric) obj0).MaxTime;

    internal static void gWsTg6EIfuOmwMdCgG6F([In] object obj0, double value) => ((CountTimeMetric) obj0).MaxTime = value;

    internal static void wB1kWPEIQ75R6vx0ShB1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type eJZZwEEIC1RQnlCtE94E([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
