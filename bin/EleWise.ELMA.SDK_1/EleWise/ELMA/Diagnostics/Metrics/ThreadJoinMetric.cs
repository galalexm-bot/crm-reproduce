// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.ThreadJoinMetric
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Метрика вызова ожидания завершения потока</summary>
  [Aggregator(typeof (ThreadJoinMetricAggregator))]
  public class ThreadJoinMetric : CountTimeMetric
  {
    internal static ThreadJoinMetric KdEIbZE8h4TM6P6pLTaS;

    /// <inheritdoc />
    public override Guid Uid => new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012364445));

    public ThreadJoinMetric()
    {
      ThreadJoinMetric.qSdbiNE8fE83WRlHphXg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool LRy3VgE8Ge8U0mZhbOsS() => ThreadJoinMetric.KdEIbZE8h4TM6P6pLTaS == null;

    internal static ThreadJoinMetric zAwt1OE8EwPwqpjwFWsa() => ThreadJoinMetric.KdEIbZE8h4TM6P6pLTaS;

    internal static void qSdbiNE8fE83WRlHphXg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
