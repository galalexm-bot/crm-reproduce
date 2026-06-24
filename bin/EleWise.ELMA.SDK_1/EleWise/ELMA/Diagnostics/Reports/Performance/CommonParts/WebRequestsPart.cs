// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts.WebRequestsPart
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts
{
  /// <summary>Статистика по Web-запросам на странице отчета "Общая"</summary>
  [ComponentOrder(10)]
  internal class WebRequestsPart : CommonInformationPart
  {
    internal static WebRequestsPart VbK8WdEvaW6YbsJ1Jvrk;

    /// <inheritdoc />
    public override string Title => (string) WebRequestsPart.YUM9ntEv4BlhVEWnps6m(WebRequestsPart.ftHfbvEvwxxPJIC9QADt(1251470110 >> 2 ^ 312590395));

    /// <inheritdoc />
    public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
    {
      MetricsGroup<WebRequestMetric> source = metrics.Get<WebRequestMetric>();
      if (source == null)
        return (IEnumerable<CommonInformationPartItem>) new CommonInformationPartItem[0];
      long num = source.Sum<KeyValuePair<string, WebRequestMetric>>((Func<KeyValuePair<string, WebRequestMetric>, long>) (m => m.Value.CountCall));
      return (IEnumerable<CommonInformationPartItem>) new CommonInformationPartItem[4]
      {
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841628100)),
          Value1 = (object) source.Sum<KeyValuePair<string, WebRequestMetric>>((Func<KeyValuePair<string, WebRequestMetric>, long>) (m => m.Value.CountCall))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -584022958)),
          Value1 = (object) new CellValue((object) source.Sum<KeyValuePair<string, WebRequestMetric>>((Func<KeyValuePair<string, WebRequestMetric>, TimeSpan>) (m => m.Value.TotalTime)), (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727079020)),
          Value1 = (object) (num == 0L ? 0L : (long) source.Sum<KeyValuePair<string, WebRequestMetric>>((Func<KeyValuePair<string, WebRequestMetric>, double>) (m => (double) m.Value.CountCall * m.Value.AvgTime)) / num)
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410950015)),
          Value1 = (object) source.Sum<KeyValuePair<string, WebRequestMetric>>((Func<KeyValuePair<string, WebRequestMetric>, long>) (m => m.Value.CountErrorCall))
        }
      };
    }

    public WebRequestsPart()
    {
      WebRequestsPart.YGaFdgEv6dtDNMfjwtce();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object ftHfbvEvwxxPJIC9QADt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YUM9ntEv4BlhVEWnps6m([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool tVp2hMEvDZ9KVjmgTwuG() => WebRequestsPart.VbK8WdEvaW6YbsJ1Jvrk == null;

    internal static WebRequestsPart EiRBCREvtZQDT1lhUq63() => WebRequestsPart.VbK8WdEvaW6YbsJ1Jvrk;

    internal static void YGaFdgEv6dtDNMfjwtce() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
