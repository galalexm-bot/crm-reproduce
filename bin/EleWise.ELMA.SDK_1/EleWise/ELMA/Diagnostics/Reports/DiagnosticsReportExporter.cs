// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.DiagnosticsReportExporter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports
{
  /// <summary>Сервис для автоматического экспорта отчетов</summary>
  [Service(Type = ComponentType.WebServer, Scope = ServiceScope.Shell)]
  internal class DiagnosticsReportExporter
  {
    private DateTime? _lastRunTime;
    private string _lastRunFileName;
    internal static DiagnosticsReportExporter EqYNCDEh6dhctPWLhIos;

    public DiagnosticsReportExporter()
    {
      DiagnosticsReportExporter.t4Fa1LEh7SpRPwQWmVoT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this._lastRunFileName = Path.Combine(((ComponentManager) DiagnosticsReportExporter.iNWJZdEhxeafaolo2d3F()).WorkDirectory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477406074));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 2;
            continue;
          case 2:
            if (DiagnosticsReportExporter.rATjqeEh0TSRA8j3vvj4((object) this._lastRunFileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            }
            goto label_16;
          case 3:
            goto label_18;
          default:
            goto label_4;
        }
      }
label_18:
      return;
label_4:
      try
      {
        DateTime result;
        int num2;
        if (!DateTime.TryParse((string) DiagnosticsReportExporter.zbRZxAEhmf95WRC3QJYm((object) this._lastRunFileName), (IFormatProvider) DiagnosticsReportExporter.sH3l5KEhyVUPsYyXNRli(), DateTimeStyles.None, out result))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
        else
          goto label_9;
label_7:
        switch (num2)
        {
          case 0:
            return;
          case 1:
            return;
          case 2:
            break;
          default:
            return;
        }
label_9:
        this._lastRunTime = new DateTime?(result);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
        {
          num2 = 1;
          goto label_7;
        }
        else
          goto label_7;
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_3;
            case 1:
              DiagnosticsReportExporter.PDMwwLEh9CHuPwcq2IXe(DiagnosticsReportExporter.h8rSK4EhMaI22MJvWAkZ(), DiagnosticsReportExporter.Thk43iEhJEuuS55GqhkA(901793403 ^ 902068195), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            default:
              goto label_22;
          }
        }
label_3:
        return;
label_22:
        return;
      }
label_16:;
    }

    public void Execute()
    {
      int num1 = 9;
      DateTime today;
      while (true)
      {
        DateTime? timeAfterUnfolded;
        DiagnosticsSettings settings;
        int num2;
        switch (num1)
        {
          case 1:
            goto label_22;
          case 2:
            goto label_10;
          case 3:
            goto label_32;
          case 4:
            goto label_15;
          case 5:
            if (timeAfterUnfolded.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 6 : 7;
              continue;
            }
            goto label_30;
          case 6:
            NthIncludedDaySettings nthIncludedDaySettings = new NthIncludedDaySettings();
            nthIncludedDaySettings.ScheduleType = ScheduleType.Daily;
            nthIncludedDaySettings.DailySettings = new DailySettings()
            {
              EveryDay = 1,
              OnlyWorkDays = false
            };
            nthIncludedDaySettings.RepeatSettings = new RepeatSettings()
            {
              Enabled = num2 > 0 && num2 < 1440,
              RepeatEvery = DiagnosticsReportExporter.I3kRkXEh5NLMfY7EgF45((double) num2),
              RepeatTo = DiagnosticsReportExporter.GPCjWaEhjMEM9X7rhFIp(24.0)
            };
            today = DateTime.Today;
            nthIncludedDaySettings.StartDate = today.Add(settings.ExportReportStartTime.TimeOfDay);
            timeAfterUnfolded = new NthIncludedDayTrigger(nthIncludedDaySettings, (IProductionSchedule) DiagnosticsReportExporter.NKJMgAEhYO4mruHQxmPN((object) Locator.GetServiceNotNull<IProductionCalendarService>()))
            {
              Name = ((string) DiagnosticsReportExporter.sRAYNpEhL8mp1N071dgn(DiagnosticsReportExporter.Thk43iEhJEuuS55GqhkA(1232639661 >> 3 ^ 153822009))),
              Id = new Guid((string) DiagnosticsReportExporter.Thk43iEhJEuuS55GqhkA(1052221104 - 768835541 ^ 283126927))
            }.GetNextTimeAfterUnfolded(this._lastRunTime, DiagnosticsReportExporter.etjPF0EhUppWVc2B5Akj());
            num1 = 5;
            continue;
          case 7:
            try
            {
              this.Export(timeAfterUnfolded.Value);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                num3 = 0;
              switch (num3)
              {
              }
            }
            catch (Exception ex)
            {
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
                num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    DiagnosticsReportExporter.huWm7pEhsA5ycEuwR21p((object) Logger.Log, DiagnosticsReportExporter.Thk43iEhJEuuS55GqhkA(1669371371 ^ 1669637967), (object) ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
            }
            break;
          case 8:
            if (!DiagnosticsReportExporter.kvIJsbEhlj67mBFiGlHb((object) settings))
            {
              num1 = 4;
              continue;
            }
            goto case 10;
          case 9:
            settings = ((DiagnosticsManager) DiagnosticsReportExporter.QNsjUbEhdh6KRdWFL6bL()).Settings;
            num1 = 8;
            continue;
          case 10:
            if (!DiagnosticsReportExporter.QkORRJEhriws3qMJW5br((object) settings))
            {
              num1 = 2;
              continue;
            }
            num2 = DiagnosticsReportExporter.js8vFcEhgko7fti2ZQyw((object) settings);
            num1 = 6;
            continue;
        }
label_2:
        this._lastRunTime = new DateTime?(timeAfterUnfolded.Value);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
      }
label_10:
      return;
label_32:
      return;
label_15:
      return;
label_30:
      return;
label_22:
      try
      {
        string lastRunFileName = this._lastRunFileName;
        today = this._lastRunTime.Value;
        string str = today.ToString((IFormatProvider) DiagnosticsReportExporter.sH3l5KEhyVUPsYyXNRli());
        DiagnosticsReportExporter.gigTZrEhcQ43VGXiHIbQ((object) lastRunFileName, (object) str);
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
          num5 = 0;
        switch (num5)
        {
        }
      }
      catch (Exception ex)
      {
        int num6 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
          num6 = 1;
        while (true)
        {
          switch (num6)
          {
            case 0:
              goto label_21;
            case 1:
              DiagnosticsReportExporter.huWm7pEhsA5ycEuwR21p((object) Logger.Log, DiagnosticsReportExporter.Thk43iEhJEuuS55GqhkA(--1360331293 ^ 1360081141), (object) ex);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            default:
              goto label_19;
          }
        }
label_21:
        return;
label_19:;
      }
    }

    private void Export(DateTime dateToRun)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        IEnumerator<IDiagnosticsReport> enumerator;
        DateTime dateTime;
        bool flag;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              enumerator = ComponentManager.Current.GetExtensionPoints<IDiagnosticsReport>().GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
              continue;
            case 3:
              flag = true;
              num2 = 15;
              continue;
            case 4:
              if (((ILogger) DiagnosticsReportExporter.h8rSK4EhMaI22MJvWAkZ()).IsDebugEnabled())
              {
                num2 = 5;
                continue;
              }
              goto label_20;
            case 5:
              DiagnosticsReportExporter.OUt5o2EGfrXijYwghsfy((object) Logger.Log, DiagnosticsReportExporter.Thk43iEhJEuuS55GqhkA(712480695 ^ 712221757));
              num2 = 8;
              continue;
            case 6:
              dateTime = this._lastRunTime.Value;
              num2 = 10;
              continue;
            case 7:
            case 9:
            case 15:
              if (flag)
              {
                num2 = 4;
                continue;
              }
              goto label_22;
            case 8:
              goto label_40;
            case 10:
              if (!DiagnosticsReportExporter.R36FeLEGGxy2ZBMEXv7R(dateTime.Date, dateToRun.Date))
              {
                num2 = 9;
                continue;
              }
              goto label_24;
            case 11:
              goto label_24;
            case 12:
              if (DiagnosticsReportExporter.xnQwykEGhF10ivOw6TWi(DiagnosticsReportExporter.DlIYb6EGbhHNm2Wbb8NL((object) DiagnosticsManager.Instance)) == ClearStatisticsPeriod.AfterEveryReport)
              {
                num2 = 16;
                continue;
              }
              goto default;
            case 13:
              goto label_35;
            case 14:
              if (this._lastRunTime.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 3 : 6;
                continue;
              }
              goto label_24;
            case 16:
              DiagnosticsManager.Instance.ClearStatistics();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 17 : 4;
              continue;
            case 17:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 7 : 7;
              continue;
            default:
              if (((DiagnosticsSettings) DiagnosticsReportExporter.DlIYb6EGbhHNm2Wbb8NL(DiagnosticsReportExporter.QNsjUbEhdh6KRdWFL6bL())).ClearStatisticsPeriod == ClearStatisticsPeriod.AfterFirstReportAtDay)
              {
                num2 = 14;
                continue;
              }
              goto case 7;
          }
        }
label_3:
        try
        {
label_6:
          if (DiagnosticsReportExporter.AT0kuqEGWTiFRJVRdxQg((object) enumerator))
            goto label_5;
          else
            goto label_7;
label_4:
          IDiagnosticsReport current;
          int num3;
          switch (num3)
          {
            case 1:
              goto label_6;
            case 2:
              try
              {
                DiagnosticsReportExporter.Ih7vcyEhzUUwNx9Prx2Z((object) current);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    goto label_6;
                }
              }
              catch (Exception ex)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      ((ILogger) DiagnosticsReportExporter.h8rSK4EhMaI22MJvWAkZ()).Error(DiagnosticsReportExporter.BdGc0pEGBfwfIGYTRH3A(DiagnosticsReportExporter.Thk43iEhJEuuS55GqhkA(-35995181 ^ -35720465), DiagnosticsReportExporter.ApkuuJEGFr83h2XXfljK((object) current)), ex);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_6;
                  }
                }
              }
            case 3:
              break;
            default:
              goto label_35;
          }
label_5:
          current = enumerator.Current;
          num3 = 2;
          goto label_4;
label_7:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
          goto label_4;
        }
        finally
        {
          int num6;
          if (enumerator == null)
            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
          else
            goto label_18;
label_17:
          switch (num6)
          {
            case 2:
              break;
            default:
          }
label_18:
          DiagnosticsReportExporter.F60JoVEGonOf4p5SHeg3((object) enumerator);
          num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
          {
            num6 = 0;
            goto label_17;
          }
          else
            goto label_17;
        }
label_24:
        DiagnosticsReportExporter.n43W09EGEXG9YMW8RpE3((object) DiagnosticsManager.Instance);
        num1 = 3;
        continue;
label_35:
        flag = false;
        num1 = 12;
      }
label_40:
      return;
label_22:
      return;
label_20:;
    }

    internal static void t4Fa1LEh7SpRPwQWmVoT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object iNWJZdEhxeafaolo2d3F() => (object) ComponentManager.Current;

    internal static bool rATjqeEh0TSRA8j3vvj4([In] object obj0) => File.Exists((string) obj0);

    internal static object zbRZxAEhmf95WRC3QJYm([In] object obj0) => (object) File.ReadAllText((string) obj0);

    internal static object sH3l5KEhyVUPsYyXNRli() => (object) CultureInfo.InvariantCulture;

    internal static object h8rSK4EhMaI22MJvWAkZ() => (object) Logger.Log;

    internal static object Thk43iEhJEuuS55GqhkA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void PDMwwLEh9CHuPwcq2IXe([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static bool ydXcnKEhHnK5EEyiejJW() => DiagnosticsReportExporter.EqYNCDEh6dhctPWLhIos == null;

    internal static DiagnosticsReportExporter q1QIriEhAo5N2F7PxxU5() => DiagnosticsReportExporter.EqYNCDEh6dhctPWLhIos;

    internal static object QNsjUbEhdh6KRdWFL6bL() => (object) DiagnosticsManager.Instance;

    internal static bool kvIJsbEhlj67mBFiGlHb([In] object obj0) => ((DiagnosticsSettings) obj0).Enabled;

    internal static bool QkORRJEhriws3qMJW5br([In] object obj0) => ((DiagnosticsSettings) obj0).ExportReports;

    internal static int js8vFcEhgko7fti2ZQyw([In] object obj0) => ((DiagnosticsSettings) obj0).ExportReportPeriod;

    internal static TimeSpan I3kRkXEh5NLMfY7EgF45([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static TimeSpan GPCjWaEhjMEM9X7rhFIp([In] double obj0) => TimeSpan.FromHours(obj0);

    internal static object NKJMgAEhYO4mruHQxmPN([In] object obj0) => (object) ((IProductionCalendarService) obj0).GetGlobalProductionSchedule();

    internal static object sRAYNpEhL8mp1N071dgn([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static DateTime etjPF0EhUppWVc2B5Akj() => DateTime.Now;

    internal static void huWm7pEhsA5ycEuwR21p([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void gigTZrEhcQ43VGXiHIbQ([In] object obj0, [In] object obj1) => File.WriteAllText((string) obj0, (string) obj1);

    internal static object Ih7vcyEhzUUwNx9Prx2Z([In] object obj0) => (object) ((IDiagnosticsReport) obj0).Export();

    internal static object ApkuuJEGFr83h2XXfljK([In] object obj0) => (object) ((IDiagnosticsReport) obj0).Name;

    internal static object BdGc0pEGBfwfIGYTRH3A([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static bool AT0kuqEGWTiFRJVRdxQg([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void F60JoVEGonOf4p5SHeg3([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object DlIYb6EGbhHNm2Wbb8NL([In] object obj0) => (object) ((DiagnosticsManager) obj0).Settings;

    internal static ClearStatisticsPeriod xnQwykEGhF10ivOw6TWi([In] object obj0) => ((DiagnosticsSettings) obj0).ClearStatisticsPeriod;

    internal static bool R36FeLEGGxy2ZBMEXv7R([In] DateTime obj0, [In] DateTime obj1) => obj0 < obj1;

    internal static void n43W09EGEXG9YMW8RpE3([In] object obj0) => ((DiagnosticsManager) obj0).ClearStatistics();

    internal static void OUt5o2EGfrXijYwghsfy([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);
  }
}
