// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.ScriptMetric
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
  /// <summary>Метрики пользовательских сценариев</summary>
  [Aggregator(typeof (ScriptCallMetricAggregator))]
  public class ScriptMetric : MethodMetric
  {
    private static ScriptMetric zsVS4AEZMgHMUjsG6qbj;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) ScriptMetric.sW6V6pEZdN75S4egCl14(1113862659 ^ 1113619925));

    public ScriptMetric()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object sW6V6pEZdN75S4egCl14(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool PnL58GEZJi8Tc4mG9Pqr() => ScriptMetric.zsVS4AEZMgHMUjsG6qbj == null;

    internal static ScriptMetric vcAcSEEZ95WBRnRohHFw() => ScriptMetric.zsVS4AEZMgHMUjsG6qbj;
  }
}
