// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts.CachePart
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
  /// <summary>
  /// Статистика по работе с кешем на странице отчета "Общая"
  /// </summary>
  [ComponentOrder(50)]
  internal class CachePart : CommonInformationPart
  {
    internal static CachePart msk9wEEvEEKgaerwewjl;

    /// <inheritdoc />
    public override string Title => (string) CachePart.D3tkuqEvCuUWpm6AQ2Sf((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886898597));

    /// <inheritdoc />
    public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
    {
      MetricsGroup<CacheMetric> source1 = metrics.Get<CacheMetric>();
      if (source1 == null)
        return (IEnumerable<CommonInformationPartItem>) new CommonInformationPartItem[0];
      MetricsGroup<WebRequestMetric> source2 = metrics.Get<WebRequestMetric>();
      MetricsGroup<BackgroundTaskMetric> source3 = metrics.Get<BackgroundTaskMetric>();
      long num1 = (source2 != null ? source2.Sum<KeyValuePair<string, WebRequestMetric>>((Func<KeyValuePair<string, WebRequestMetric>, long>) (m => m.Value.TotalTime.Ticks)) : 0L) + (source3 != null ? source3.Sum<KeyValuePair<string, BackgroundTaskMetric>>((Func<KeyValuePair<string, BackgroundTaskMetric>, long>) (m => m.Value.TotalTime.Ticks)) : 0L);
      long num2 = source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.CountCall));
      long num3 = source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.ReadTotalCount));
      long num4 = source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.WriteTotalCount));
      long num5 = source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.LockTotalCount));
      return (IEnumerable<CommonInformationPartItem>) new CommonInformationPartItem[17]
      {
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113590237)),
          Value1 = (object) (num2 == 0L ? 0.0 : Math.Round(source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, double>) (m => m.Value.AvgTime * (double) m.Value.CountCall)) / (double) num2, 3))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841658792)),
          Value1 = (object) new CellValue((object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, TimeSpan>) (m => m.Value.TotalTime)), (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS)),
          Value2 = (object) new CellValue((object) ((double) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.TotalTime.Ticks)) / (double) num1), (IExcelCellFormat) PercentFormat.Default)
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853108682)),
          Value1 = (object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.CountCall))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335254951)),
          Value1 = (object) (num3 == 0L ? 0.0 : Math.Round(source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, double>) (m => m.Value.AvgReadTime * (double) m.Value.ReadTotalCount)) / (double) num3, 3))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978209198)),
          Value1 = (object) new CellValue((object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, TimeSpan>) (m => m.Value.ReadTotalTime)), (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS)),
          Value2 = (object) new CellValue((object) (num1 == 0L ? 0.0 : (double) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.ReadTotalTime.Ticks)) / (double) num1), (IExcelCellFormat) PercentFormat.Default)
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917009472)),
          Value1 = (object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.ReadTotalCount))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459300397)),
          Value1 = (object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.ReadErrorTotalCount)),
          Value2 = (object) new CellValue((object) (num3 == 0L ? 0.0 : (double) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.ReadErrorTotalCount)) / (double) num3), (IExcelCellFormat) PercentFormat.Default)
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710322216)),
          Value1 = (object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.SuccesReadTotalCount)),
          Value2 = (object) new CellValue((object) (num3 == 0L ? 0.0 : (double) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.SuccesReadTotalCount)) / (double) num3), (IExcelCellFormat) PercentFormat.Default)
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669638313)),
          Value1 = (object) (num4 == 0L ? 0.0 : Math.Round(source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, double>) (m => m.Value.AvgWriteTime * (double) m.Value.WriteTotalCount)) / (double) num4, 3))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218698950)),
          Value1 = (object) new CellValue((object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, TimeSpan>) (m => m.Value.WriteTotalTime)), (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS)),
          Value2 = (object) new CellValue((object) (num1 == 0L ? 0.0 : (double) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.WriteTotalTime.Ticks)) / (double) num1), (IExcelCellFormat) PercentFormat.Default)
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727093504)),
          Value1 = (object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.WriteTotalCount))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767472091)),
          Value1 = (object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.WriteErrorTotalCount)),
          Value2 = (object) new CellValue((object) (num4 == 0L ? 0.0 : (double) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.WriteErrorTotalCount)) / (double) num4), (IExcelCellFormat) PercentFormat.Default)
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333465068)),
          Value1 = (object) (num5 == 0L ? 0.0 : Math.Round(source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, double>) (m => m.Value.AvgLockTime * (double) m.Value.LockTotalCount)) / (double) num5, 3))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306193140)),
          Value1 = (object) new CellValue((object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, TimeSpan>) (m => m.Value.LockTotalTime)), (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS)),
          Value2 = (object) new CellValue((object) (num1 == 0L ? 0.0 : (double) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.LockTotalTime.Ticks)) / (double) num1), (IExcelCellFormat) PercentFormat.Default)
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767471239)),
          Value1 = (object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.LockTotalCount))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281587190)),
          Value1 = (object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.LockErrorTotalCount)),
          Value2 = (object) new CellValue((object) (num5 == 0L ? 0.0 : (double) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.LockErrorTotalCount)) / (double) num5), (IExcelCellFormat) PercentFormat.Default)
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104924872)),
          Value1 = (object) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.LockSuccesTotalCount)),
          Value2 = (object) new CellValue((object) (num5 == 0L ? 0.0 : (double) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (m => m.Value.LockSuccesTotalCount)) / (double) num5), (IExcelCellFormat) PercentFormat.Default)
        }
      };
    }

    public CachePart()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object D3tkuqEvCuUWpm6AQ2Sf([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool TFoW78EvfQS7C0bAGfo3() => CachePart.msk9wEEvEEKgaerwewjl == null;

    internal static CachePart vCS6sAEvQSAAcJJ9broR() => CachePart.msk9wEEvEEKgaerwewjl;
  }
}
