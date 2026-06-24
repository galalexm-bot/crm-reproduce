// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.IndexQueryMetric
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
  /// <summary>Метрики запроса в индекс</summary>
  [Aggregator(typeof (IndexQueryCallMetricAggregator))]
  public class IndexQueryMetric : CountTimeMetric
  {
    private static IndexQueryMetric s9kcK8EZTVZDXo47S865;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) IndexQueryMetric.JEJNdTEZOnBxGg1FfTrx(1051802738 - -1831968059 ^ -1410951345));

    public IndexQueryMetric()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object JEJNdTEZOnBxGg1FfTrx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool QcIycQEZkfFGb109dnl3() => IndexQueryMetric.s9kcK8EZTVZDXo47S865 == null;

    internal static IndexQueryMetric HhO2WjEZnc0CYLtGlK99() => IndexQueryMetric.s9kcK8EZTVZDXo47S865;
  }
}
