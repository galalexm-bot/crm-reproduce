// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.WebRequestMetric
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
  /// <summary>Метрики Web-запроса</summary>
  [Aggregator(typeof (WebRequestMetricAggregator))]
  public class WebRequestMetric : CallContextMetric
  {
    internal static WebRequestMetric BKDOZ7EZzEUA15by4vR8;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) WebRequestMetric.Jd5f98EuWVU9WWJjL7Et(-1837662597 ^ -1837945331));

    public WebRequestMetric()
    {
      WebRequestMetric.OsRipQEuouXLKqHMreWi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Jd5f98EuWVU9WWJjL7Et(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool QTV7E1EuFN2R0YZCC0Qy() => WebRequestMetric.BKDOZ7EZzEUA15by4vR8 == null;

    internal static WebRequestMetric wE04YeEuBtruxUeeQwgf() => WebRequestMetric.BKDOZ7EZzEUA15by4vR8;

    internal static void OsRipQEuouXLKqHMreWi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
