// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.CustomDiagnosticsSessionMetrics
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
  /// <summary>Метрики кастомных сессий диагностики</summary>
  [Aggregator(typeof (CustomDiagnostcisSessionMetricAggregator))]
  public class CustomDiagnosticsSessionMetrics : CallContextMetric
  {
    private static CustomDiagnosticsSessionMetrics D0p9m3E8FaZd5AMxuv2h;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) CustomDiagnosticsSessionMetrics.l4voNZE8oJhZ60wkN8jG(-643786247 ^ -643508757));

    public CustomDiagnosticsSessionMetrics()
    {
      CustomDiagnosticsSessionMetrics.on4dhnE8b4YxnR5IYbvs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object l4voNZE8oJhZ60wkN8jG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool WVR28fE8Bb1DvhliofC6() => CustomDiagnosticsSessionMetrics.D0p9m3E8FaZd5AMxuv2h == null;

    internal static CustomDiagnosticsSessionMetrics MftMBXE8Wi5aa0GZAlTC() => CustomDiagnosticsSessionMetrics.D0p9m3E8FaZd5AMxuv2h;

    internal static void on4dhnE8b4YxnR5IYbvs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
