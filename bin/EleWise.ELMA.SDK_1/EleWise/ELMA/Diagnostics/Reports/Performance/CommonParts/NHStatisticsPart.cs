// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts.NHStatisticsPart
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Stat;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts
{
  /// <summary>Статистика по объектам на странице отчета "Общая"</summary>
  [ComponentOrder(30)]
  internal class NHStatisticsPart : CommonInformationPart
  {
    internal static NHStatisticsPart IPFEsKEvVxyfN4g3Pqio;

    /// <inheritdoc />
    public override string Title => (string) NHStatisticsPart.E8MleVEvqKWKgueM0pgv(NHStatisticsPart.tVnduKEvRYZDO27Rv8d2(-675505729 ^ -675762553));

    /// <inheritdoc />
    public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
    {
      IStatistics statistics = Locator.GetServiceNotNull<SessionFactoryHolder>().SessionFactory.Statistics;
      double num = statistics.EntityFetchFromCacheCount == 0L ? 0.0 : (double) statistics.EntityFetchFromCacheSuccessCount / (double) statistics.EntityFetchFromCacheCount;
      return (IEnumerable<CommonInformationPartItem>) new CommonInformationPartItem[16]
      {
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1322842752)),
          Value1 = (object) statistics.EntityLoadCount
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87092065)),
          Value1 = (object) statistics.EntityFetchCount
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740597144)),
          Value1 = (object) new CellValue((object) statistics.EntityFetchTime, (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS))
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841628844)),
          Value1 = (object) statistics.EntityFetchFromCacheCount
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606900152)),
          Value1 = (object) statistics.EntityFetchFromCacheSuccessCount,
          Value2 = (object) new CellValue((object) num, (IExcelCellFormat) PercentFormat.Default)
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178482496)),
          Value1 = (object) new CellValue((object) statistics.EntityFetchFromCacheTime, (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS))
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418719008)),
          Value1 = (object) statistics.EntityQueryCount
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978603543)),
          Value1 = (object) new CellValue((object) statistics.EntityQueryTime, (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS))
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410951053)),
          Value1 = (object) statistics.EntityQueryFromCacheCount
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426342273)),
          Value1 = (object) new CellValue((object) statistics.EntityQueryFromCacheTime, (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS))
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410950215)),
          Value1 = (object) statistics.EntityInsertCount
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319205248)),
          Value1 = (object) new CellValue((object) statistics.EntityInsertTime, (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS))
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459312257)),
          Value1 = (object) statistics.EntityUpdateCount
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642608270)),
          Value1 = (object) new CellValue((object) statistics.EntityUpdateTime, (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS))
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112424404)),
          Value1 = (object) statistics.EntityDeleteCount
        },
        new CommonInformationPartItem()
        {
          Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825645992)),
          Value1 = (object) new CellValue((object) statistics.EntityDeleteTime, (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS))
        }
      };
    }

    public NHStatisticsPart()
    {
      NHStatisticsPart.CQr5bmEvKbVynthRdKIZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object tVnduKEvRYZDO27Rv8d2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object E8MleVEvqKWKgueM0pgv([In] object obj0) => (object) SR.T((string) obj0);

    internal static bool u03HdjEvSDkKnPBcUvGo() => NHStatisticsPart.IPFEsKEvVxyfN4g3Pqio == null;

    internal static NHStatisticsPart JnxgeqEvix5i4PxdjMUF() => NHStatisticsPart.IPFEsKEvVxyfN4g3Pqio;

    internal static void CQr5bmEvKbVynthRdKIZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
