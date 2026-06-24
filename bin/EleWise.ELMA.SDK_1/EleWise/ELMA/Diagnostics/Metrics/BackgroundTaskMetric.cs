// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.BackgroundTaskMetric
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
  /// <summary>Метрики фоновой задачи</summary>
  [Aggregator(typeof (BackgroundTaskMetricAggregator))]
  public class BackgroundTaskMetric : CallContextMetric
  {
    private static BackgroundTaskMetric MQLSHaE8u5Rwhjxi6uZZ;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) BackgroundTaskMetric.NK866qE8SlCh4SXE0yTK(979449278 ^ 979728572));

    public BackgroundTaskMetric()
    {
      BackgroundTaskMetric.fayQv1E8i36vUUxwDorp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object NK866qE8SlCh4SXE0yTK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool CO0sTYE8IwisTsZOEx53() => BackgroundTaskMetric.MQLSHaE8u5Rwhjxi6uZZ == null;

    internal static BackgroundTaskMetric cWJTaKE8VQWl1qa86Vnu() => BackgroundTaskMetric.MQLSHaE8u5Rwhjxi6uZZ;

    internal static void fayQv1E8i36vUUxwDorp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
