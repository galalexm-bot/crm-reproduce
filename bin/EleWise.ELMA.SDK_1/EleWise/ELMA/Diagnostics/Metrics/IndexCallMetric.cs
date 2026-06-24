// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.IndexCallMetric
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Метрики обращения к индексу</summary>
  [Aggregator(typeof (IndexCallMetricAggregator))]
  public class IndexCallMetric : CountTimeMetric
  {
    internal static IndexCallMetric tGBQktEZvGwjTA6gDtBx;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) IndexCallMetric.gJMFi6EZu4VsOMRXUBfP(-1710575414 ^ -1710293416));

    /// <summary>Количество отмененных запросов</summary>
    [DisplayName(typeof (IndexCallMetric.__IndexCallMetricLocalization), "CountCancelCall")]
    [Order(600)]
    public long CountCancelCall
    {
      get => this.\u003CCountCancelCall\u003Ek__BackingField;
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
              this.\u003CCountCancelCall\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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
      int num = 3;
      IndexCallMetric indexCallMetric;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            base.Merge(metric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 4;
            continue;
          case 2:
            if (indexCallMetric != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 1;
              continue;
            }
            goto label_8;
          case 3:
            indexCallMetric = metric as IndexCallMetric;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 2;
            continue;
          case 4:
            this.CountCancelCall += IndexCallMetric.wwxfH1EZI1muPACLvxmY((object) indexCallMetric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:
      return;
label_8:;
    }

    public IndexCallMetric()
    {
      IndexCallMetric.iMb96wEZV8Hc30UFsFId();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object gJMFi6EZu4VsOMRXUBfP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool xdbcSBEZ8T5VUCO14cN8() => IndexCallMetric.tGBQktEZvGwjTA6gDtBx == null;

    internal static IndexCallMetric vRP49NEZZlT9cdfDyqmi() => IndexCallMetric.tGBQktEZvGwjTA6gDtBx;

    internal static long wwxfH1EZI1muPACLvxmY([In] object obj0) => ((IndexCallMetric) obj0).CountCancelCall;

    internal static void iMb96wEZV8Hc30UFsFId() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static class __IndexCallMetricLocalization
    {
      private static IndexCallMetric.__IndexCallMetricLocalization RohhmR8KOpiJsKYJ8bst;

      public static string CountCancelCall => (string) IndexCallMetric.__IndexCallMetricLocalization.AV3Y7C8K1o9PyDjBpewD(IndexCallMetric.__IndexCallMetricLocalization.X1JW058KPNU39FBrW60G(979449278 ^ 979685436));

      internal static object X1JW058KPNU39FBrW60G(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object AV3Y7C8K1o9PyDjBpewD([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool hOQRtP8K24ieVLPqYwYi() => IndexCallMetric.__IndexCallMetricLocalization.RohhmR8KOpiJsKYJ8bst == null;

      internal static IndexCallMetric.__IndexCallMetricLocalization S8QNfe8KeuE79fW1jBip() => IndexCallMetric.__IndexCallMetricLocalization.RohhmR8KOpiJsKYJ8bst;
    }
  }
}
