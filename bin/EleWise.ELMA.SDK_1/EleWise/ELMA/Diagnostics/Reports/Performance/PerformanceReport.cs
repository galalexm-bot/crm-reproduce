// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.PerformanceReport
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Performance
{
  /// <summary>Отчет по производительности системы</summary>
  [Component(Order = 10)]
  public class PerformanceReport : DiagnosticsReport
  {
    private static PerformanceReport xYf4BUECJFOKPOnADg2J;

    /// <summary>Ctor</summary>
    /// <param name="pages">Страницы отчета производительности</param>
    public PerformanceReport(IEnumerable<IPerformanceReportPage> pages)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.PagesExt = pages;
    }

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) PerformanceReport.GFy2DFEClFl8ngBglLmL(-740338220 ^ -740593982));

    /// <inheritdoc />
    public override string Name => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293428098));

    /// <summary>Страницы отчета производительности</summary>
    public IEnumerable<IPerformanceReportPage> PagesExt { get; private set; }

    /// <inheritdoc />
    public override string Export()
    {
      int num = 1;
      string fileName;
      while (true)
      {
        switch (num)
        {
          case 1:
            fileName = (string) PerformanceReport.wJXc64ECj4ncn7P91sL6(PerformanceReport.CaLRE8ECr70fxa3lRytw((object) this), (object) ((string) PerformanceReport.GFy2DFEClFl8ngBglLmL(92412609 - 1050237057 ^ -957548050) + (string) PerformanceReport.Ul2DrWECgCJEpN80yyRY() + (string) PerformanceReport.GFy2DFEClFl8ngBglLmL(-138018305 ^ -138015355) + (string) PerformanceReport.dOWSCsEC55vj7uFJtE5v((object) DateTime.Now.ToString((string) PerformanceReport.GFy2DFEClFl8ngBglLmL(-680446928 - -370807692 ^ -309366026)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3326242), PerformanceReport.GFy2DFEClFl8ngBglLmL(372753449 ^ 372754515)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521184118)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            this.ClearOldReports((string) PerformanceReport.wJXc64ECj4ncn7P91sL6((object) this.DefaultFolder, PerformanceReport.Xu5EiZECYxhc4TwDIVsB(PerformanceReport.GFy2DFEClFl8ngBglLmL(-812025778 ^ -811777056), PerformanceReport.Ul2DrWECgCJEpN80yyRY(), PerformanceReport.GFy2DFEClFl8ngBglLmL(-477139494 ^ -477407052))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 2 : 0;
            continue;
          default:
            this.Export(fileName);
            num = 3;
            continue;
        }
      }
label_4:
      return fileName;
    }

    /// <inheritdoc />
    public override void Export(string fileName)
    {
      int num1 = 9;
      ExcelReportBuilder excelReportBuilder;
      string str;
      MetricsContainer metricsContainer;
      IEnumerator<IPerformanceReportPage> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_26;
          case 2:
            PerformanceReport.P7RQ0OEvhe6EumCS6NUI((object) fileName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 6 : 6;
            continue;
          case 3:
            if (PerformanceReport.q8dOWKEvoa5feHnfjmxJ((object) str))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            }
            goto case 11;
          case 4:
            enumerator = this.PagesExt.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 5 : 12;
            continue;
          case 6:
            ((Workbook) PerformanceReport.qggVjJEvGTxlCJBKcQBi((object) excelReportBuilder)).Save(fileName, SaveFormat.Xlsx);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
            continue;
          case 7:
label_7:
            str = (string) PerformanceReport.pISiFcECLFfXJtQW9Rg8((object) fileName);
            num1 = 3;
            continue;
          case 8:
            excelReportBuilder = new ExcelReportBuilder();
            num1 = 10;
            continue;
          case 9:
            PerformanceReport.d9X1YbECUjbFge7fKVTy(PerformanceReport.pISiFcECLFfXJtQW9Rg8((object) fileName));
            num1 = 8;
            continue;
          case 10:
            metricsContainer = (MetricsContainer) PerformanceReport.gnwgcaECclx7LoW7jrOT(PerformanceReport.RfROBEECsWq9DcuOCMnN());
            num1 = 4;
            continue;
          case 11:
            PerformanceReport.d9X1YbECUjbFge7fKVTy((object) str);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 5;
            continue;
          case 12:
            try
            {
label_19:
              if (PerformanceReport.s0IbuYEvWoukRyr3bd4S((object) enumerator))
                goto label_16;
              else
                goto label_20;
label_15:
              IPerformanceReportPage current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    PerformanceReport.Nkh4FqEvF2nrwcKvwx2j((object) excelReportBuilder, PerformanceReport.N19JErECzFcnP6niP26c((object) current));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 0;
                    continue;
                  case 2:
                    PerformanceReport.oLaJd8EvBLl9CffQlDvX((object) current, (object) metricsContainer, (object) excelReportBuilder);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_7;
                  case 4:
                    goto label_16;
                  default:
                    goto label_19;
                }
              }
label_16:
              current = enumerator.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
              {
                num2 = 1;
                goto label_15;
              }
              else
                goto label_15;
label_20:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 3;
              goto label_15;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
                  num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      enumerator.Dispose();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_28;
                  }
                }
              }
label_28:;
            }
          default:
            if (PerformanceReport.KpN1XBEvb0tL6sMRFYHM((object) fileName))
            {
              num1 = 2;
              continue;
            }
            goto case 6;
        }
      }
label_26:;
    }

    internal static object GFy2DFEClFl8ngBglLmL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool JWbQJuEC9hLlwqAOcK37() => PerformanceReport.xYf4BUECJFOKPOnADg2J == null;

    internal static PerformanceReport u7gWmKECdJNQCYvbEIJP() => PerformanceReport.xYf4BUECJFOKPOnADg2J;

    internal static object CaLRE8ECr70fxa3lRytw([In] object obj0) => (object) ((DiagnosticsReport) obj0).DefaultFolder;

    internal static object Ul2DrWECgCJEpN80yyRY() => (object) Environment.MachineName;

    internal static object dOWSCsEC55vj7uFJtE5v([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object wJXc64ECj4ncn7P91sL6([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object Xu5EiZECYxhc4TwDIVsB([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object pISiFcECLFfXJtQW9Rg8([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object d9X1YbECUjbFge7fKVTy([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object RfROBEECsWq9DcuOCMnN() => (object) DiagnosticsManager.Instance;

    internal static object gnwgcaECclx7LoW7jrOT([In] object obj0) => (object) ((DiagnosticsManager) obj0).Metrics;

    internal static object N19JErECzFcnP6niP26c([In] object obj0) => (object) ((IPerformanceReportPage) obj0).Name;

    internal static object Nkh4FqEvF2nrwcKvwx2j([In] object obj0, [In] object obj1) => (object) ((ExcelReportBuilder) obj0).AddWorksheet((string) obj1);

    internal static void oLaJd8EvBLl9CffQlDvX([In] object obj0, [In] object obj1, [In] object obj2) => ((IPerformanceReportPage) obj0).ExportExcel((MetricsContainer) obj1, (ExcelReportBuilder) obj2);

    internal static bool s0IbuYEvWoukRyr3bd4S([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool q8dOWKEvoa5feHnfjmxJ([In] object obj0) => Directory.Exists((string) obj0);

    internal static bool KpN1XBEvb0tL6sMRFYHM([In] object obj0) => File.Exists((string) obj0);

    internal static void P7RQ0OEvhe6EumCS6NUI([In] object obj0) => File.Delete((string) obj0);

    internal static object qggVjJEvGTxlCJBKcQBi([In] object obj0) => (object) ((ExcelReportBuilder) obj0).Workbook;
  }
}
