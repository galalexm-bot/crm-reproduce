// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Activity.ActivityReport
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Activity
{
  /// <summary>Отчет о текущей активности в системе</summary>
  [Component(Order = 20)]
  public class ActivityReport : DiagnosticsReport
  {
    private static ActivityReport y7f70hEfTJJls7VKQ6Pn;

    public ActivityReport(IEnumerable<IActivityReportPage> pages)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Pages = pages;
    }

    public override Guid Uid => new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124379136));

    public override string Name => (string) ActivityReport.oiYsPZEf2SV5p2KApZ3t(ActivityReport.mgEweMEfOjx18fYbtahD(-53329496 >> 4 ^ -3600188));

    public IEnumerable<IActivityReportPage> Pages { get; private set; }

    public override string Export()
    {
      int num = 2;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            ActivityReport.OESuqHEfpI5wo78rlHfr((object) this, (object) str);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
            continue;
          case 2:
            str = (string) ActivityReport.uyywjIEf3qtVd2c9Q9lC(ActivityReport.kYrYfVEfeDwNtSUWKYwb((object) this), ActivityReport.vwqnkqEfN0xZX23W11Mv((object) new string[5]
            {
              (string) ActivityReport.mgEweMEfOjx18fYbtahD(~210725948 ^ -210458903),
              (string) ActivityReport.qsMRowEfP2wIc1rawSCn(),
              (string) ActivityReport.mgEweMEfOjx18fYbtahD(-1598106783 - -968262081 ^ -629843624),
              ActivityReport.TDu8NUEf1pNRZyAFTLhk().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813345435)).Replace((string) ActivityReport.mgEweMEfOjx18fYbtahD(-812025778 ^ -812031350), z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236070325)),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210644215)
            }));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            this.ClearOldReports((string) ActivityReport.uyywjIEf3qtVd2c9Q9lC(ActivityReport.kYrYfVEfeDwNtSUWKYwb((object) this), ActivityReport.VEyYZqEfaNUUNjHxoabm((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561342386), (object) Environment.MachineName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283126709))));
            num = 3;
            continue;
        }
      }
label_4:
      return str;
    }

    public override void Export(string fileName)
    {
      int num1 = 8;
      List<CallContextInfo> list;
      ExcelReportBuilder builder;
      IEnumerator<IActivityReportPage> enumerator;
      string str;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_17;
          case 2:
            File.Delete(fileName);
            num1 = 3;
            continue;
          case 3:
            ActivityReport.Tlga8qEf0XALp1hbN4E8(ActivityReport.mqtRfvEfx8AvpBkrhqhA((object) builder), (object) fileName, SaveFormat.Xlsx);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
            continue;
          case 4:
            ActivityReport.UQoEMVEfDJf6Joljte2w((object) str);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 5:
            enumerator = this.Pages.GetEnumerator();
            num1 = 10;
            continue;
          case 6:
            if (!ActivityReport.zjax0nEfAHcowyUSbblq((object) str))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 3 : 4;
              continue;
            }
            goto default;
          case 7:
            builder = new ExcelReportBuilder();
            num1 = 9;
            continue;
          case 8:
            ActivityReport.UQoEMVEfDJf6Joljte2w((object) Path.GetDirectoryName(fileName));
            num1 = 7;
            continue;
          case 9:
            list = DiagnosticsManager.Instance.GetCurrentCalls().ToList<CallContextInfo>();
            num1 = 5;
            continue;
          case 10:
            try
            {
label_7:
              if (ActivityReport.Xyy5VwEf4YlLVZ2MbMk5((object) enumerator))
                goto label_9;
              else
                goto label_8;
label_6:
              IActivityReportPage current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_9;
                  case 2:
                    current.ExportExcel((IEnumerable<CallContextInfo>) list, builder);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 4 : 0;
                    continue;
                  case 3:
                    goto label_27;
                  case 4:
                    goto label_7;
                  default:
                    ActivityReport.bb7QsAEfwsKqDLnNTega((object) builder, ActivityReport.oEebdvEftDI5GrYpUkX0((object) current));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 2;
                    continue;
                }
              }
label_8:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 3 : 3;
              goto label_6;
label_9:
              current = enumerator.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
              {
                num2 = 0;
                goto label_6;
              }
              else
                goto label_6;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_19;
                    default:
                      ActivityReport.CiFVvsEf6pP7rlMKjg9h((object) enumerator);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_19:;
            }
          case 11:
label_27:
            str = (string) ActivityReport.SqMGYJEfHe9wOi2Ks5Nq((object) fileName);
            num1 = 6;
            continue;
          default:
            if (ActivityReport.KWNRUFEf74xY20PR3Y2t((object) fileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 2;
              continue;
            }
            goto case 3;
        }
      }
label_17:;
    }

    internal static bool lI3moOEfkIqZxaYGE13m() => ActivityReport.y7f70hEfTJJls7VKQ6Pn == null;

    internal static ActivityReport MHn5hvEfnXO4nX0A2iwD() => ActivityReport.y7f70hEfTJJls7VKQ6Pn;

    internal static object mgEweMEfOjx18fYbtahD(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object oiYsPZEf2SV5p2KApZ3t([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object kYrYfVEfeDwNtSUWKYwb([In] object obj0) => (object) ((DiagnosticsReport) obj0).DefaultFolder;

    internal static object qsMRowEfP2wIc1rawSCn() => (object) Environment.MachineName;

    internal static DateTime TDu8NUEf1pNRZyAFTLhk() => DateTime.Now;

    internal static object vwqnkqEfN0xZX23W11Mv([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static object uyywjIEf3qtVd2c9Q9lC([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static void OESuqHEfpI5wo78rlHfr([In] object obj0, [In] object obj1) => ((DiagnosticsReport) obj0).Export((string) obj1);

    internal static object VEyYZqEfaNUUNjHxoabm([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object UQoEMVEfDJf6Joljte2w([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object oEebdvEftDI5GrYpUkX0([In] object obj0) => (object) ((IActivityReportPage) obj0).Name;

    internal static object bb7QsAEfwsKqDLnNTega([In] object obj0, [In] object obj1) => (object) ((ExcelReportBuilder) obj0).AddWorksheet((string) obj1);

    internal static bool Xyy5VwEf4YlLVZ2MbMk5([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void CiFVvsEf6pP7rlMKjg9h([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object SqMGYJEfHe9wOi2Ks5Nq([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static bool zjax0nEfAHcowyUSbblq([In] object obj0) => Directory.Exists((string) obj0);

    internal static bool KWNRUFEf74xY20PR3Y2t([In] object obj0) => File.Exists((string) obj0);

    internal static object mqtRfvEfx8AvpBkrhqhA([In] object obj0) => (object) ((ExcelReportBuilder) obj0).Workbook;

    internal static void Tlga8qEf0XALp1hbN4E8([In] object obj0, [In] object obj1, [In] SaveFormat obj2) => ((Workbook) obj0).Save((string) obj1, obj2);
  }
}
