// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts.SQLPart
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
  /// <summary>Статистика по SQL-запросам на странице отчета "Общая"</summary>
  [ComponentOrder(40)]
  internal class SQLPart : CommonInformationPart
  {
    internal static SQLPart M5Rl1lEvXEjUH8LTcYT5;

    /// <inheritdoc />
    public override string Title => (string) SQLPart.qeVhp7EvOy8CrEhJTUlf(SQLPart.mm9duBEvnEanup7bNaKv(-441065788 ^ -2092910478 ^ 1727090056));

    /// <inheritdoc />
    public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
    {
      MetricsGroup<SqlQueryMetric> source1 = metrics.Get<SqlQueryMetric>();
      if (source1 == null)
        return (IEnumerable<CommonInformationPartItem>) new CommonInformationPartItem[0];
      MetricsGroup<WebRequestMetric> source2 = metrics.Get<WebRequestMetric>();
      MetricsGroup<BackgroundTaskMetric> source3 = metrics.Get<BackgroundTaskMetric>();
      long num = (source2 != null ? source2.Sum<KeyValuePair<string, WebRequestMetric>>((Func<KeyValuePair<string, WebRequestMetric>, long>) (m => m.Value.TotalTime.Ticks)) : 0L) + (source3 != null ? source3.Sum<KeyValuePair<string, BackgroundTaskMetric>>((Func<KeyValuePair<string, BackgroundTaskMetric>, long>) (m => m.Value.TotalTime.Ticks)) : 0L);
      return (IEnumerable<CommonInformationPartItem>) new CommonInformationPartItem[3]
      {
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132666929)),
          Value1 = (object) source1.Sum<KeyValuePair<string, SqlQueryMetric>>((Func<KeyValuePair<string, SqlQueryMetric>, long>) (m => m.Value.CountCall))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867100851)),
          Value1 = (object) source1.Sum<KeyValuePair<string, SqlQueryMetric>>((Func<KeyValuePair<string, SqlQueryMetric>, long>) (m => m.Value.CountErrorCall))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099506127)),
          Value1 = (object) new CellValue((object) source1.Sum<KeyValuePair<string, SqlQueryMetric>>((Func<KeyValuePair<string, SqlQueryMetric>, TimeSpan>) (m => m.Value.TotalTime)), (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS)),
          Value2 = (object) new CellValue((object) (num == 0L ? 0.0 : (double) source1.Sum<KeyValuePair<string, SqlQueryMetric>>((Func<KeyValuePair<string, SqlQueryMetric>, long>) (m => m.Value.TotalTime.Ticks)) / (double) num), (IExcelCellFormat) PercentFormat.Default)
        }
      };
    }

    public SQLPart()
    {
      SQLPart.AQIbefEv24lwIsjkU44S();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object mm9duBEvnEanup7bNaKv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object qeVhp7EvOy8CrEhJTUlf([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool XrDxNbEvTnLVH4MH6swC() => SQLPart.M5Rl1lEvXEjUH8LTcYT5 == null;

    internal static SQLPart c00nhfEvkSDYMRoMiqBv() => SQLPart.M5Rl1lEvXEjUH8LTcYT5;

    internal static void AQIbefEv24lwIsjkU44S() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
