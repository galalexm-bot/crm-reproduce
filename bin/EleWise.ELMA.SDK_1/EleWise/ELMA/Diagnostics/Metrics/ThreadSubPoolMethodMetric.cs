// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.ThreadSubPoolMethodMetric
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
  /// <summary>Метрики вызова метода в пуле потоков</summary>
  [Aggregator(typeof (ThreadSubPoolCallMetricAggregator))]
  public class ThreadSubPoolMethodMetric : MethodMetric
  {
    internal static ThreadSubPoolMethodMetric DlwuqtE8Q9CCI1eSRZdv;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) ThreadSubPoolMethodMetric.k3rkExE88HONH1M71EKL(1232639661 >> 3 ^ 153837159));

    public ThreadSubPoolMethodMetric()
    {
      ThreadSubPoolMethodMetric.G2iX85E8Z2TsWCsQpivZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object k3rkExE88HONH1M71EKL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool HGWPHCE8CAOmPAQ2u8WR() => ThreadSubPoolMethodMetric.DlwuqtE8Q9CCI1eSRZdv == null;

    internal static ThreadSubPoolMethodMetric RBC1adE8vdKKPJZEJriI() => ThreadSubPoolMethodMetric.DlwuqtE8Q9CCI1eSRZdv;

    internal static void G2iX85E8Z2TsWCsQpivZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
