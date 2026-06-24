// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.ServerInformationPage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Activity;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Performance;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports
{
  [Component(Order = 10000)]
  public class ServerInformationPage : IActivityReportPage, IPerformanceReportPage
  {
    private static ServerInformationPage hEacpBEhZoesLn4NeIDy;

    public string Name => (string) ServerInformationPage.MFhUaSEhST035DqhbaXI(ServerInformationPage.SohE7pEhVTlYY5oPJXnW(516838154 ^ 516586746));

    private void ExportExcel(ExcelReportBuilder builder)
    {
      int num1 = 29;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ServerInformationPage.Mdnl7wEhT8AkghCQvtU4((object) builder);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 9 : 16;
              continue;
            case 2:
              if (ServerInformationPage.omPTXbEhnFdZl5Gwlx5S() != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 23 : 12;
                continue;
              }
              goto case 16;
            case 3:
              builder.SetValues(ServerInformationPage.MFhUaSEhST035DqhbaXI(ServerInformationPage.SohE7pEhVTlYY5oPJXnW(1581325282 << 3 ^ -234033274)), ServerInformationPage.sfmpW9EhPhaJZ8IUlmbq());
              num2 = 30;
              continue;
            case 4:
            case 8:
              if (PatternLayoutExt.ConfigurationDirectory != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 12 : 14;
                continue;
              }
              goto label_23;
            case 5:
              builder.NextRow();
              num2 = 22;
              continue;
            case 6:
            case 21:
              builder.SetValues(ServerInformationPage.MFhUaSEhST035DqhbaXI((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521524222)), ServerInformationPage.omPTXbEhnFdZl5Gwlx5S());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
              continue;
            case 7:
              builder.SetValues(ServerInformationPage.MFhUaSEhST035DqhbaXI(ServerInformationPage.SohE7pEhVTlYY5oPJXnW(1654249598 >> 2 ^ 413288145)), ServerInformationPage.bLFq33EhNHuxavmcapHG());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 8 : 10;
              continue;
            case 9:
              ServerInformationPage.Mdnl7wEhT8AkghCQvtU4((object) builder);
              num2 = 2;
              continue;
            case 10:
              ServerInformationPage.Mdnl7wEhT8AkghCQvtU4((object) builder);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 33 : 2;
              continue;
            case 11:
              if (num3 > 0)
                goto case 12;
              else
                goto label_35;
            case 12:
              ServerInformationPage.No7BDQEhO3wVJJkAxuGQ((object) builder, (num3 + 1) * 17);
              num2 = 27;
              continue;
            case 13:
              builder.NextRow();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 17 : 4;
              continue;
            case 14:
              builder.SetValues(ServerInformationPage.MFhUaSEhST035DqhbaXI((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304854619)), (object) PatternLayoutExt.ConfigurationDirectory);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 13 : 2;
              continue;
            case 15:
              ServerInformationPage.FeHC93EhKPBmYieOfhxd((object) builder, ServerInformationPage.BVFQvGEhqfUZMMptvAep(ServerInformationPage.zsYZTwEhR3EOLjBiHoxv((object) builder)));
              num2 = 20;
              continue;
            case 16:
              builder.SetValues(ServerInformationPage.MFhUaSEhST035DqhbaXI(ServerInformationPage.SohE7pEhVTlYY5oPJXnW(-1822890472 ^ -1822632334)), ServerInformationPage.lAdyfVEhes8a4IbYsMm2());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 32 : 30;
              continue;
            case 17:
              goto label_39;
            case 18:
              ServerInformationPage.Mdnl7wEhT8AkghCQvtU4((object) builder);
              num2 = 25;
              continue;
            case 19:
              builder.SetValues((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574002836)), ServerInformationPage.aNhj7GEh1GWLYKANkXWL());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            case 20:
              builder.SetValues(ServerInformationPage.SHxAeIEhXoU5FZKUEORU());
              num2 = 24;
              continue;
            case 22:
              if (ServerInformationPage.h7fjjxEhpZ45PGcSeQC2() == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 8 : 8;
                continue;
              }
              goto case 31;
            case 23:
              num3 = ((IEnumerable<char>) ServerInformationPage.omPTXbEhnFdZl5Gwlx5S()).Count<char>((Func<char, bool>) (c => c == '\n'));
              num2 = 11;
              continue;
            case 24:
              ServerInformationPage.Mdnl7wEhT8AkghCQvtU4((object) builder);
              num2 = 18;
              continue;
            case 25:
              builder.SetValues(ServerInformationPage.MFhUaSEhST035DqhbaXI((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420493510)), ServerInformationPage.aeVsZWEhkfYB7M1875vA());
              num2 = 9;
              continue;
            case 26:
              ServerInformationPage.Mdnl7wEhT8AkghCQvtU4((object) builder);
              num2 = 4;
              continue;
            case 27:
              ExcelReportBuilder excelReportBuilder = builder;
              ExcelStyle excelStyle = new ExcelStyle();
              // ISSUE: reference to a compiler-generated field
              Action<Style, StyleFlag> action1 = ServerInformationPage.\u003C\u003Ec.\u003C\u003E9__2_1;
              Action<Style, StyleFlag> action2;
              if (action1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ServerInformationPage.\u003C\u003Ec.\u003C\u003E9__2_1 = action2 = (Action<Style, StyleFlag>) ((s, f) =>
                {
                  int num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        ServerInformationPage.\u003C\u003Ec.xGrVyG8iSDAluW0F10IA((object) f, true);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_2;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        ServerInformationPage.\u003C\u003Ec.sqta1x8iiZfjQjItH6lI((object) s, true);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 2;
                        continue;
                    }
                  }
label_2:;
                });
              }
              else
                goto label_42;
label_41:
              excelStyle.Action = action2;
              ServerInformationPage.oiMgk6Eh2frPJq5s7FuY((object) excelReportBuilder, 1, (object) excelStyle);
              num2 = 6;
              continue;
label_42:
              action2 = action1;
              goto label_41;
            case 28:
              builder.SetColumnsWidths(30, 50);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 7 : 15;
              continue;
            case 29:
              ServerInformationPage.ss3xGFEhiMwbFOKIDoU1((object) builder, 0);
              num2 = 28;
              continue;
            case 30:
              ServerInformationPage.Mdnl7wEhT8AkghCQvtU4((object) builder);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 19 : 1;
              continue;
            case 31:
              builder.SetValues(ServerInformationPage.MFhUaSEhST035DqhbaXI(ServerInformationPage.SohE7pEhVTlYY5oPJXnW(-281842504 ^ -281584560)), ServerInformationPage.h7fjjxEhpZ45PGcSeQC2());
              num2 = 26;
              continue;
            case 32:
              builder.NextRow();
              num2 = 3;
              continue;
            case 33:
              goto label_11;
            default:
              ServerInformationPage.Mdnl7wEhT8AkghCQvtU4((object) builder);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 7 : 1;
              continue;
          }
        }
label_11:
        builder.SetValues(ServerInformationPage.MFhUaSEhST035DqhbaXI((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868076398)), ServerInformationPage.qtnR6kEh3U1Sm69rJQQi());
        num1 = 5;
        continue;
label_35:
        num1 = 21;
      }
label_39:
      return;
label_23:;
    }

    public void ExportExcel(IEnumerable<CallContextInfo> currentCalls, ExcelReportBuilder builder) => this.ExportExcel(builder);

    public void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ExportExcel(builder);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public ServerInformationPage()
    {
      ServerInformationPage.PnOK8uEhaI7ki282f75A();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object SohE7pEhVTlYY5oPJXnW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object MFhUaSEhST035DqhbaXI([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool yAbwEhEhutP75jBfT5ju() => ServerInformationPage.hEacpBEhZoesLn4NeIDy == null;

    internal static ServerInformationPage D3Db5MEhI0x6WNmbghha() => ServerInformationPage.hEacpBEhZoesLn4NeIDy;

    internal static void ss3xGFEhiMwbFOKIDoU1([In] object obj0, int value) => ((ExcelReportBuilder) obj0).RowIndex = value;

    internal static object zsYZTwEhR3EOLjBiHoxv([In] object obj0) => (object) ((ExcelReportBuilder) obj0).Styles;

    internal static object BVFQvGEhqfUZMMptvAep([In] object obj0) => (object) ((ExcelStylesheet) obj0).MainHeaderStyle;

    internal static void FeHC93EhKPBmYieOfhxd([In] object obj0, [In] object obj1) => ((ExcelReportBuilder) obj0).SetRowStyle((IExcelStyle) obj1);

    internal static object SHxAeIEhXoU5FZKUEORU() => (object) PatternLayoutExt.Version;

    internal static void Mdnl7wEhT8AkghCQvtU4([In] object obj0) => ((ExcelReportBuilder) obj0).NextRow();

    internal static object aeVsZWEhkfYB7M1875vA() => (object) PatternLayoutExt.ServerSoftware;

    internal static object omPTXbEhnFdZl5Gwlx5S() => (object) PatternLayoutExt.DataBaseSoftware;

    internal static void No7BDQEhO3wVJJkAxuGQ([In] object obj0, int height) => ((ExcelReportBuilder) obj0).SetRowHeight(height);

    internal static void oiMgk6Eh2frPJq5s7FuY([In] object obj0, int columnIndex, [In] object obj2) => ((ExcelReportBuilder) obj0).SetCellStyle(columnIndex, (IExcelStyle) obj2);

    internal static object lAdyfVEhes8a4IbYsMm2() => (object) PatternLayoutExt.OS;

    internal static object sfmpW9EhPhaJZ8IUlmbq() => (object) PatternLayoutExt.Framework;

    internal static object aNhj7GEh1GWLYKANkXWL() => (object) PatternLayoutExt.CPU;

    internal static object bLFq33EhNHuxavmcapHG() => (object) PatternLayoutExt.Memory;

    internal static object qtnR6kEh3U1Sm69rJQQi() => (object) PatternLayoutExt.HDD;

    internal static object h7fjjxEhpZ45PGcSeQC2() => (object) PatternLayoutExt.ApplicationDirectory;

    internal static void PnOK8uEhaI7ki282f75A() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
