// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Activity.CurrentCallsReportPage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Activity
{
  public class CurrentCallsReportPage : ActivityReportPage
  {
    internal static CurrentCallsReportPage Oc6sJgEfmVB9WxR64Lvg;

    public override string Name => (string) CurrentCallsReportPage.q2cGvHEf9xWMN3F3ttI8(CurrentCallsReportPage.QWsgJTEfJfYelfutCFgo(-244066886 - -48452443 ^ -195879787));

    public override void ExportExcel(
      IEnumerable<CallContextInfo> currentCalls,
      ExcelReportBuilder builder)
    {
      builder.SetColumnsWidths(21, 150);
      // ISSUE: reference to a compiler-generated method
      foreach (CallContextInfo callContextInfo in (IEnumerable<CallContextInfo>) currentCalls.OrderBy<CallContextInfo, DateTime>((Func<CallContextInfo, DateTime>) (c => CurrentCallsReportPage.\u003C\u003Ec.eTT4s48ilfnu332DIxTx((object) c))))
      {
        builder.SetRowStyle(builder.Styles.HeaderStyle);
        builder.SetValues((object) (callContextInfo.StartTime.ConvertUtcToLocal().ToShortDateString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539382637) + callContextInfo.StartTime.ConvertUtcToLocal().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210459037))), (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312921581) + (object) callContextInfo.Id + (callContextInfo.UserId != null ? (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858628579) + callContextInfo.UserId + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239584098)) : (object) "") + (!string.IsNullOrEmpty(callContextInfo.UserHostAddress) ? (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234034494) + callContextInfo.UserHostAddress + z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405857955)) : (object) "") + (!string.IsNullOrEmpty(callContextInfo.HttpMethod) ? (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2120904683) + callContextInfo.HttpMethod + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16734193)) : (object) "") + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675491683) + callContextInfo.Name));
        builder.NextRow();
        foreach (AbstractCallInfo call in callContextInfo.GetCallStack())
        {
          ExcelReportBuilder excelReportBuilder = builder;
          object[] objArray = new object[2];
          DateTime local = call.StartTime.ConvertUtcToLocal();
          string shortDateString = local.ToShortDateString();
          string str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638416589);
          local = call.StartTime.ConvertUtcToLocal();
          string str2 = local.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647653994));
          objArray[0] = (object) (shortDateString + str1 + str2);
          objArray[1] = (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281830822) + call.CallType + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35722941) + call.Description);
          excelReportBuilder.SetValues(objArray);
          builder.NextRow();
        }
        builder.NextRow();
      }
    }

    public CurrentCallsReportPage()
    {
      CurrentCallsReportPage.Q2LKvNEfdRVx7sGiqbmc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object QWsgJTEfJfYelfutCFgo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object q2cGvHEf9xWMN3F3ttI8([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool B8CuU0Efyrp8nIuZeauT() => CurrentCallsReportPage.Oc6sJgEfmVB9WxR64Lvg == null;

    internal static CurrentCallsReportPage cYthQBEfM0sS2odFNdlI() => CurrentCallsReportPage.Oc6sJgEfmVB9WxR64Lvg;

    internal static void Q2LKvNEfdRVx7sGiqbmc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
