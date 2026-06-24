// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.NHStatisticsPage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Stat;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Performance
{
  /// <summary>Страница отчета "Объекты"</summary>
  [ComponentOrder(30)]
  internal class NHStatisticsPage : PerformanceReportPage
  {
    internal static NHStatisticsPage y9eCNwECFvqR6duREvym;

    /// <summary>Ctor</summary>
    /// <param name="builders">Построители колонок</param>
    public NHStatisticsPage(
      IEnumerable<IPerformanceReportPageColumnBuilder> builders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(builders);
    }

    /// <inheritdoc />
    public override string Name => (string) NHStatisticsPage.q95v7KECbE7dWM1nbdfH(NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(1581325282 << 3 ^ -234035160));

    /// <summary>Фабрика сессий NHibernate</summary>
    public SessionFactoryHolder SessionFactoryHolder
    {
      get => this.\u003CSessionFactoryHolder\u003Ek__BackingField;
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
              this.\u003CSessionFactoryHolder\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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
    public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
    {
      int num1 = 2;
      ExcelTable<KeyValuePair<string, EntityStatistics>> table;
      IStatistics nhStat;
      while (true)
      {
        switch (num1)
        {
          case 1:
            nhStat = (IStatistics) NHStatisticsPage.zI41Y3ECGgOuboCJA0fn(NHStatisticsPage.rfkmcCEChkqgC1w6vZry((object) this.SessionFactoryHolder));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 6;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
            continue;
          case 3:
            builder.RenderTable<KeyValuePair<string, EntityStatistics>>(table);
            num1 = 7;
            continue;
          case 4:
            goto label_7;
          case 5:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable1 = new ExcelTable<KeyValuePair<string, EntityStatistics>>()
            {
              FixedRows = 1
            }.AddColumn<CellValue>((string) NHStatisticsPage.q95v7KECbE7dWM1nbdfH((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539345565)), 50.0, (Func<KeyValuePair<string, EntityStatistics>, CellValue>) (s => new CellValue((object) s.Key, (IExcelCellFormat) new CustomCellFormat((Action<Cell, object>) ((cell, v) =>
            {
              int num2 = 4;
              int num3;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    object obj = NHStatisticsPage.\u003C\u003Ec__DisplayClass7_1.VxcClA8R9pUFDIjwb3BN(NHStatisticsPage.\u003C\u003Ec__DisplayClass7_1.nLAjKw8RJWKnFH3rqxW7((object) cell, num3, NHStatisticsPage.\u003C\u003Ec__DisplayClass7_1.PCad2G8RMLQ12rD5M0ZS((object) s.Key) - num3));
                    ((Font) obj).Size = 8;
                    // ISSUE: reference to a compiler-generated method
                    ((Font) obj).Color = NHStatisticsPage.\u003C\u003Ec__DisplayClass7_1.xRCULt8Rd6RCo5nTDIFs();
                    num2 = 5;
                    continue;
                  case 2:
                    goto label_3;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    num3 = NHStatisticsPage.\u003C\u003Ec__DisplayClass7_1.bHJdCE8RyUrLGZibgNSH((object) s.Key, '(');
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
                    continue;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    NHStatisticsPage.\u003C\u003Ec__DisplayClass7_1.XJWwnk8RmYuoX9UP9oym((object) cell, (object) s.Key);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 3;
                    continue;
                  case 5:
                    goto label_2;
                  default:
                    if (num3 <= 0)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto case 1;
                }
              }
label_3:
              return;
label_2:;
            })))));
            object title1 = NHStatisticsPage.q95v7KECbE7dWM1nbdfH(NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(-675505729 ^ -675762443));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, long> func1 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_1;
            Func<KeyValuePair<string, EntityStatistics>, long> valueAccessor1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_1 = valueAccessor1 = (Func<KeyValuePair<string, EntityStatistics>, long>) (s => s.Value.LoadCount);
            }
            else
              goto label_47;
label_12:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable2 = excelTable1.AddColumn<long>(10L, (string) title1, 10.0, valueAccessor1);
            string title2 = EleWise.ELMA.SR.T((string) NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(-1120607109 - 305487170 ^ -1426345795));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, long> func2 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_2;
            Func<KeyValuePair<string, EntityStatistics>, long> valueAccessor2;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_2 = valueAccessor2 = (Func<KeyValuePair<string, EntityStatistics>, long>) (s => s.Value.FetchCount);
            }
            else
              goto label_46;
label_14:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable3 = excelTable2.AddColumn<long>(20L, title2, 10.0, valueAccessor2);
            object title3 = NHStatisticsPage.q95v7KECbE7dWM1nbdfH(NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(-342626196 - 1290888215 ^ -1633240087));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, TimeSpan> func3 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_3;
            Func<KeyValuePair<string, EntityStatistics>, TimeSpan> valueAccessor3;
            if (func3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_3 = valueAccessor3 = (Func<KeyValuePair<string, EntityStatistics>, TimeSpan>) (s => s.Value.FetchTime);
            }
            else
              goto label_45;
label_16:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable4 = excelTable3.AddColumn<TimeSpan>(30L, (string) title3, 12.0, valueAccessor3).AddColumn<long>(40L, (string) NHStatisticsPage.q95v7KECbE7dWM1nbdfH(NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(-1487388570 ^ -1487112320)), 10.0, (Func<KeyValuePair<string, EntityStatistics>, long>) (s => s.Value.FetchFromCacheCount)).AddColumn<long>(50L, (string) NHStatisticsPage.q95v7KECbE7dWM1nbdfH((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210457631)), 10.0, (Func<KeyValuePair<string, EntityStatistics>, long>) (s => s.Value.FetchFromCacheSuccessCount));
            object title4 = NHStatisticsPage.q95v7KECbE7dWM1nbdfH(NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(-710283084 ^ -537863435 ^ 173871677));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, TimeSpan> func4 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_6;
            Func<KeyValuePair<string, EntityStatistics>, TimeSpan> valueAccessor4;
            if (func4 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_6 = valueAccessor4 = (Func<KeyValuePair<string, EntityStatistics>, TimeSpan>) (s => s.Value.FetchFromCacheTime);
            }
            else
              goto label_44;
label_18:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable5 = excelTable4.AddColumn<TimeSpan>(60L, (string) title4, 12.0, valueAccessor4);
            object title5 = NHStatisticsPage.q95v7KECbE7dWM1nbdfH((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 221894612));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, long> func5 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_7;
            Func<KeyValuePair<string, EntityStatistics>, long> valueAccessor5;
            if (func5 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_7 = valueAccessor5 = (Func<KeyValuePair<string, EntityStatistics>, long>) (s => s.Value.QueryCount);
            }
            else
              goto label_43;
label_20:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable6 = excelTable5.AddColumn<long>(70L, (string) title5, 10.0, valueAccessor5);
            object title6 = NHStatisticsPage.q95v7KECbE7dWM1nbdfH(NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(-1867198571 ^ -1867450505));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, TimeSpan> func6 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_8;
            Func<KeyValuePair<string, EntityStatistics>, TimeSpan> valueAccessor6;
            if (func6 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_8 = valueAccessor6 = (Func<KeyValuePair<string, EntityStatistics>, TimeSpan>) (s => s.Value.QueryTime);
            }
            else
              goto label_42;
label_22:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable7 = excelTable6.AddColumn<TimeSpan>(80L, (string) title6, 12.0, valueAccessor6).AddColumn<long>(90L, (string) NHStatisticsPage.q95v7KECbE7dWM1nbdfH(NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(372753449 ^ 372505893)), 10.0, (Func<KeyValuePair<string, EntityStatistics>, long>) (s => s.Value.QueryFromCacheCount)).AddColumn<TimeSpan>(100L, (string) NHStatisticsPage.q95v7KECbE7dWM1nbdfH(NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(2008901894 << 3 ^ -1108381322)), 12.0, (Func<KeyValuePair<string, EntityStatistics>, TimeSpan>) (s => s.Value.QueryFromCacheTime));
            object title7 = NHStatisticsPage.q95v7KECbE7dWM1nbdfH(NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(1142330761 ^ 1541959139 ^ 536527128));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, long> func7 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_11;
            Func<KeyValuePair<string, EntityStatistics>, long> valueAccessor7;
            if (func7 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_11 = valueAccessor7 = (Func<KeyValuePair<string, EntityStatistics>, long>) (s => s.Value.InsertCount);
            }
            else
              goto label_41;
label_24:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable8 = excelTable7.AddColumn<long>(110L, (string) title7, 10.0, valueAccessor7);
            object title8 = NHStatisticsPage.q95v7KECbE7dWM1nbdfH(NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(-281842504 ^ -281586428));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, TimeSpan> func8 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_12;
            Func<KeyValuePair<string, EntityStatistics>, TimeSpan> valueAccessor8;
            if (func8 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_12 = valueAccessor8 = (Func<KeyValuePair<string, EntityStatistics>, TimeSpan>) (s => s.Value.InsertTime);
            }
            else
              goto label_40;
label_26:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable9 = excelTable8.AddColumn<TimeSpan>(120L, (string) title8, 12.0, valueAccessor8);
            string title9 = EleWise.ELMA.SR.T((string) NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(-1886646897 ^ -1886899115));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, long> func9 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_13;
            Func<KeyValuePair<string, EntityStatistics>, long> valueAccessor9;
            if (func9 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_13 = valueAccessor9 = (Func<KeyValuePair<string, EntityStatistics>, long>) (s => s.Value.UpdateCount);
            }
            else
              goto label_39;
label_28:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable10 = excelTable9.AddColumn<long>(130L, title9, 10.0, valueAccessor9);
            object title10 = NHStatisticsPage.q95v7KECbE7dWM1nbdfH((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234035930));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, TimeSpan> func10 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_14;
            Func<KeyValuePair<string, EntityStatistics>, TimeSpan> valueAccessor10;
            if (func10 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_14 = valueAccessor10 = (Func<KeyValuePair<string, EntityStatistics>, TimeSpan>) (s => s.Value.UpdateTime);
            }
            else
              goto label_2;
label_31:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable11 = excelTable10.AddColumn<TimeSpan>(140L, (string) title10, 12.0, valueAccessor10);
            string title11 = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -69766022));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, long> func11 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_15;
            Func<KeyValuePair<string, EntityStatistics>, long> valueAccessor11;
            if (func11 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_15 = valueAccessor11 = (Func<KeyValuePair<string, EntityStatistics>, long>) (s => s.Value.DeleteCount);
            }
            else
              goto label_9;
label_34:
            table = excelTable11.AddColumn<long>(150L, title11, 10.0, valueAccessor11).AddColumn<TimeSpan>(160L, (string) NHStatisticsPage.q95v7KECbE7dWM1nbdfH(NHStatisticsPage.uTWRb0ECoEK2mU4PnYlL(-1255365154 ^ 596875508 ^ -1766127740)), 12.0, (Func<KeyValuePair<string, EntityStatistics>, TimeSpan>) (s => s.Value.DeleteTime));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
label_9:
            valueAccessor11 = func11;
            goto label_34;
label_2:
            valueAccessor10 = func10;
            goto label_31;
label_39:
            valueAccessor9 = func9;
            goto label_28;
label_40:
            valueAccessor8 = func8;
            goto label_26;
label_41:
            valueAccessor7 = func7;
            goto label_24;
label_42:
            valueAccessor6 = func6;
            goto label_22;
label_43:
            valueAccessor5 = func5;
            goto label_20;
label_44:
            valueAccessor4 = func4;
            goto label_18;
label_45:
            valueAccessor3 = func3;
            goto label_16;
label_46:
            valueAccessor2 = func2;
            goto label_14;
label_47:
            valueAccessor1 = func1;
            goto label_12;
          case 6:
            if (nhStat != null)
            {
              num1 = 5;
              continue;
            }
            goto label_32;
          case 7:
            goto label_36;
          default:
            ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable12 = table;
            IEnumerable<KeyValuePair<string, EntityStatistics>> source = ((IEnumerable<string>) NHStatisticsPage.VbJ10xECE46vJTEULLCt((object) nhStat)).Select<string, KeyValuePair<string, EntityStatistics>>((Func<string, KeyValuePair<string, EntityStatistics>>) (e =>
            {
              int length = e.LastIndexOf('.');
              return new KeyValuePair<string, EntityStatistics>(length > 0 ? e.Substring(length + 1) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309649258) + e.Substring(0, length) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138153532) : e, nhStat.GetEntityStatistics(e));
            })).Where<KeyValuePair<string, EntityStatistics>>((Func<KeyValuePair<string, EntityStatistics>, bool>) (p => p.Value != null));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, EntityStatistics>, string> func12 = NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_19;
            Func<KeyValuePair<string, EntityStatistics>, string> keySelector;
            if (func12 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHStatisticsPage.\u003C\u003Ec.\u003C\u003E9__7_19 = keySelector = (Func<KeyValuePair<string, EntityStatistics>, string>) (p => p.Key);
            }
            else
              goto label_29;
label_38:
            List<KeyValuePair<string, EntityStatistics>> list = source.OrderBy<KeyValuePair<string, EntityStatistics>, string>(keySelector).ToList<KeyValuePair<string, EntityStatistics>>();
            excelTable12.Items = (IEnumerable<KeyValuePair<string, EntityStatistics>>) list;
            num1 = 3;
            continue;
label_29:
            keySelector = func12;
            goto label_38;
        }
      }
label_7:
      return;
label_36:
      return;
label_32:;
    }

    internal static object uTWRb0ECoEK2mU4PnYlL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object q95v7KECbE7dWM1nbdfH([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool gphag2ECBptjggfONNUx() => NHStatisticsPage.y9eCNwECFvqR6duREvym == null;

    internal static NHStatisticsPage YK3XtPECW5TEXegtpuKF() => NHStatisticsPage.y9eCNwECFvqR6duREvym;

    internal static object rfkmcCEChkqgC1w6vZry([In] object obj0) => (object) ((SessionFactoryHolder) obj0).SessionFactory;

    internal static object zI41Y3ECGgOuboCJA0fn([In] object obj0) => (object) ((ISessionFactory) obj0).Statistics;

    internal static object VbJ10xECE46vJTEULLCt([In] object obj0) => (object) ((IStatistics) obj0).EntityNames;
  }
}
