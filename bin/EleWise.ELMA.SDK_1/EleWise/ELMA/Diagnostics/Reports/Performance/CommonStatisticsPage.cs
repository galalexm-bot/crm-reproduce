// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.CommonStatisticsPage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Performance
{
  /// <summary>Страница с общей (сводной) информацией</summary>
  [ComponentOrder(0)]
  internal class CommonStatisticsPage : PerformanceReportPage
  {
    internal static CommonStatisticsPage aBRGMMEQXfjp2Sk0MLWh;

    /// <summary>Ctor</summary>
    /// <param name="builders">Построители колонок</param>
    public CommonStatisticsPage(
      IEnumerable<IPerformanceReportPageColumnBuilder> builders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(builders);
    }

    /// <inheritdoc />
    public override string Name => (string) CommonStatisticsPage.yMSoRuEQOMy2jxBatbEZ(CommonStatisticsPage.Wb38NaEQn7wkAn8k42e6(694673736 ^ -23604109 ^ -671874213));

    /// <inheritdoc />
    public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
    {
      int num1 = 1;
      IEnumerator<ICommonInformationPart> enumerator1;
      while (true)
      {
        int num2 = num1;
        List<DateTimeRange> source;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ExcelReportBuilder excelReportBuilder = builder;
              int[] numArray = new int[3];
              // ISSUE: field reference
              CommonStatisticsPage.w1lNvkEQ2eoepOklYnXd((object) numArray, __fieldref (\u003CPrivateImplementationDetails\u003E.\u00340148BE4CEC9781F386C38B18C36032BB4F79C23));
              excelReportBuilder.SetColumnsWidths(numArray);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_51;
            case 3:
              source.Add(new DateTimeRange(new DateTime?(CommonStatisticsPage.IYhjAAEQpWuyWIl7yWso((object) metrics)), new DateTime?(DateTime.Now)));
              num2 = 6;
              continue;
            case 4:
              if (!CommonStatisticsPage.PK1DjpEQ3PvGcIwNHhTG())
              {
                num2 = 14;
                continue;
              }
              goto case 3;
            case 5:
              goto label_7;
            case 6:
            case 14:
              builder.SetValues(CommonStatisticsPage.yMSoRuEQOMy2jxBatbEZ(CommonStatisticsPage.Wb38NaEQn7wkAn8k42e6(222162814 ^ 221895084)), (object) string.Join((string) CommonStatisticsPage.Wb38NaEQn7wkAn8k42e6(-1858887263 ^ -1858884189), source.Select<DateTimeRange, string>((Func<DateTimeRange, string>) (p =>
              {
                int num3 = 1;
                DateTime? from;
                DateTime dateTime;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      from = p.From;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_4;
                    default:
                      dateTime = from.Value;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
                      continue;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return (string) CommonStatisticsPage.\u003C\u003Ec.QoM6wo8R1DJ4jHjr8O1i((object) dateTime.ToString((string) CommonStatisticsPage.\u003C\u003Ec.p3qKqv8RPXOxZ5jxe9sj(1199946765 ^ 1199917965)), CommonStatisticsPage.\u003C\u003Ec.p3qKqv8RPXOxZ5jxe9sj(333888594 ^ 1075625116 ^ 1408942952), (object) p.To.Value.ToString((string) CommonStatisticsPage.\u003C\u003Ec.p3qKqv8RPXOxZ5jxe9sj(~210725948 ^ -210738109)));
              }))));
              num2 = 9;
              continue;
            case 7:
              goto label_43;
            case 8:
              CommonStatisticsPage.UJLYPTEQ13HZHdiKall8((object) builder);
              num2 = 13;
              continue;
            case 9:
              enumerator1 = ((ComponentManager) CommonStatisticsPage.TBD752EQatEUEJC9sfeW()).GetExtensionPoints<ICommonInformationPart>().GetEnumerator();
              num2 = 5;
              continue;
            case 10:
              CommonStatisticsPage.UJLYPTEQ13HZHdiKall8((object) builder);
              num2 = 11;
              continue;
            case 11:
              builder.SetValues(CommonStatisticsPage.yMSoRuEQOMy2jxBatbEZ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335252297)), CommonStatisticsPage.k1o4MeEQNyNCblxqBLdj());
              num2 = 8;
              continue;
            case 12:
              builder.SetValues(CommonStatisticsPage.yMSoRuEQOMy2jxBatbEZ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921453651)));
              num2 = 10;
              continue;
            case 13:
              source = new List<DateTimeRange>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
              continue;
            default:
              builder.SetRowStyle((IExcelStyle) CommonStatisticsPage.WHB9x5EQPmwJF4aG8qMo(CommonStatisticsPage.Jct9XiEQew538rQqxEdX((object) builder)));
              num2 = 12;
              continue;
          }
        }
label_51:
        source.AddRange((IEnumerable<DateTimeRange>) metrics.Periods);
        num1 = 4;
      }
label_43:
      return;
label_7:
      try
      {
label_33:
        if (CommonStatisticsPage.dLXAuuEQHMFGYjIP1RKI((object) enumerator1))
          goto label_31;
        else
          goto label_34;
label_8:
        IEnumerator<CommonInformationPartItem> enumerator2;
        ICommonInformationPart current1;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              enumerator2 = current1.GetItems(metrics).GetEnumerator();
              num4 = 8;
              continue;
            case 2:
              goto label_40;
            case 3:
              goto label_33;
            case 4:
              CommonStatisticsPage.UJLYPTEQ13HZHdiKall8((object) builder);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 7 : 7;
              continue;
            case 5:
              goto label_31;
            case 6:
              builder.SetValues(CommonStatisticsPage.d097wlEQt2PwNSUIgYfN((object) current1));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
              continue;
            case 7:
              CommonStatisticsPage.UJLYPTEQ13HZHdiKall8((object) builder);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            case 8:
              goto label_9;
            default:
              builder.SetCellStyle(0, (IExcelStyle) CommonStatisticsPage.PUMltOEQDxtA8UAGEORY(CommonStatisticsPage.Jct9XiEQew538rQqxEdX((object) builder)));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 2 : 6;
              continue;
          }
        }
label_40:
        return;
label_9:
        try
        {
label_15:
          if (CommonStatisticsPage.dLXAuuEQHMFGYjIP1RKI((object) enumerator2))
            goto label_11;
          else
            goto label_16;
label_10:
          CommonInformationPartItem current2;
          int num5;
          while (true)
          {
            switch (num5)
            {
              case 1:
                CommonStatisticsPage.UJLYPTEQ13HZHdiKall8((object) builder);
                num5 = 2;
                continue;
              case 2:
                builder.SetValue(0, CommonStatisticsPage.ICMlEgEQw7n5HOyiNYGq((object) current2));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 3 : 8;
                continue;
              case 3:
                goto label_15;
              case 4:
                builder.SetValue(2, CommonStatisticsPage.LXf74IEQ6jgAeYvMwTPw((object) current2));
                num5 = 3;
                continue;
              case 5:
                builder.SetValue(1, CommonStatisticsPage.dSTJFfEQ4wZbTPvj3LvP((object) current2));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 4 : 6;
                continue;
              case 6:
                if (CommonStatisticsPage.LXf74IEQ6jgAeYvMwTPw((object) current2) != null)
                {
                  num5 = 4;
                  continue;
                }
                goto label_15;
              case 7:
                goto label_33;
              case 8:
                if (CommonStatisticsPage.dSTJFfEQ4wZbTPvj3LvP((object) current2) != null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 5 : 5;
                  continue;
                }
                goto case 6;
              default:
                goto label_11;
            }
          }
label_11:
          current2 = enumerator2.Current;
          num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
          {
            num5 = 0;
            goto label_10;
          }
          else
            goto label_10;
label_16:
          num5 = 7;
          goto label_10;
        }
        finally
        {
          int num6;
          if (enumerator2 == null)
            num6 = 2;
          else
            goto label_26;
label_25:
          switch (num6)
          {
            case 1:
            case 2:
          }
label_26:
          enumerator2.Dispose();
          num6 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
          {
            num6 = 0;
            goto label_25;
          }
          else
            goto label_25;
        }
label_31:
        current1 = enumerator1.Current;
        num4 = 4;
        goto label_8;
label_34:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 2;
        goto label_8;
      }
      finally
      {
        int num7;
        if (enumerator1 == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 0;
        else
          goto label_41;
label_39:
        switch (num7)
        {
          case 1:
            break;
          default:
        }
label_41:
        CommonStatisticsPage.UnZecxEQAXpI4il4sTxm((object) enumerator1);
        num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        {
          num7 = 0;
          goto label_39;
        }
        else
          goto label_39;
      }
    }

    internal static object Wb38NaEQn7wkAn8k42e6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object yMSoRuEQOMy2jxBatbEZ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool LidTPdEQTrqr4HeBsfNN() => CommonStatisticsPage.aBRGMMEQXfjp2Sk0MLWh == null;

    internal static CommonStatisticsPage d85sL7EQkTqW4GcDbicF() => CommonStatisticsPage.aBRGMMEQXfjp2Sk0MLWh;

    internal static void w1lNvkEQ2eoepOklYnXd([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);

    internal static object Jct9XiEQew538rQqxEdX([In] object obj0) => (object) ((ExcelReportBuilder) obj0).Styles;

    internal static object WHB9x5EQPmwJF4aG8qMo([In] object obj0) => (object) ((ExcelStylesheet) obj0).MainHeaderStyle;

    internal static void UJLYPTEQ13HZHdiKall8([In] object obj0) => ((ExcelReportBuilder) obj0).NextRow();

    internal static object k1o4MeEQNyNCblxqBLdj() => (object) Environment.MachineName;

    internal static bool PK1DjpEQ3PvGcIwNHhTG() => DiagnosticsManager.Enabled;

    internal static DateTime IYhjAAEQpWuyWIl7yWso([In] object obj0) => ((MetricsContainer) obj0).StartTime;

    internal static object TBD752EQatEUEJC9sfeW() => (object) ComponentManager.Current;

    internal static object PUMltOEQDxtA8UAGEORY([In] object obj0) => (object) ((ExcelStylesheet) obj0).HeaderStyle;

    internal static object d097wlEQt2PwNSUIgYfN([In] object obj0) => (object) ((ICommonInformationPart) obj0).Title;

    internal static object ICMlEgEQw7n5HOyiNYGq([In] object obj0) => (object) ((CommonInformationPartItem) obj0).Name;

    internal static object dSTJFfEQ4wZbTPvj3LvP([In] object obj0) => ((CommonInformationPartItem) obj0).Value1;

    internal static object LXf74IEQ6jgAeYvMwTPw([In] object obj0) => ((CommonInformationPartItem) obj0).Value2;

    internal static bool dLXAuuEQHMFGYjIP1RKI([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void UnZecxEQAXpI4il4sTxm([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
