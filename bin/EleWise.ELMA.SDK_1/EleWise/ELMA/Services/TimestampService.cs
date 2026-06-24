// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.TimestampService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Scheduling;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис временных штампов.</summary>
  [Service(Type = ComponentType.Server, Scope = ServiceScope.Application)]
  public class TimestampService : ITimestampService, ISweepHandler
  {
    private readonly DateTime ORIGIN_DATE;
    private ILogger logger;
    private ITransformationProvider transformationProvider;
    private double syncInterval;
    private long nextSyncTimestamp;
    private long timestampDiff;
    private static TimestampService hxla1bB6cddcx1MJWo5c;

    /// <summary>Ctor</summary>
    public TimestampService()
    {
      TimestampService.WCLGaZBHBjm0VVsa6sow();
      this.ORIGIN_DATE = new DateTime(2000, 1, 1);
      this.timestampDiff = long.MinValue;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.LoadSettings();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Получить временной штамп.</summary>
    /// <returns>Временной штамп.</returns>
    /// <exception cref="T:System.InvalidOperationException">Служба временных штампов не инициализирована</exception>
    public long GetTimestamp()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.TryInitialize();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return TimestampService.b3rJWbBHWpnVDnDYD45k((object) this) - this.timestampDiff;
    }

    /// <summary>
    /// Получить временной штамп для времени, указанного как смещение относительно текущего.
    /// </summary>
    /// <param name="timeOffset">Смещение относительно текущего врмемени.</param>
    /// <returns>Временной штамп</returns>
    /// <exception cref="T:System.InvalidOperationException">Служба временных штампов не инициализирована</exception>
    public long GetTimeStampRelativeToNow(TimeSpan timeOffset) => this.GetTimestamp() + this.GetTimestampOffset(timeOffset);

    /// <summary>Тело Sweep handler-а</summary>
    void ISweepHandler.Execute()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.nextSyncTimestamp = this.GetTimeStampRelativeToNow(TimestampService.bV4aXEBHoQG04080rr9s(this.syncInterval));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
            continue;
          case 2:
            this.SyncTime();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
            continue;
          case 3:
            if (this.GetTimestamp() >= this.nextSyncTimestamp)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 2 : 2;
              continue;
            }
            goto label_7;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_7:;
    }

    /// <summary>Провайдер трансформации БД</summary>
    protected virtual ITransformationProvider TransformationProvider
    {
      get
      {
        int num = 1;
        ITransformationProvider service;
        ITransformationProvider transformationProvider;
        while (true)
        {
          switch (num)
          {
            case 1:
              transformationProvider = this.transformationProvider;
              if (transformationProvider == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.transformationProvider = service = Locator.GetService<ITransformationProvider>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return transformationProvider;
label_6:
        return service;
      }
    }

    /// <summary>Логгер службы</summary>
    protected virtual ILogger TimestampLogger
    {
      get
      {
        int num = 1;
        ILogger timestampLogger;
        ILogger logger;
        while (true)
        {
          switch (num)
          {
            case 1:
              logger = this.logger;
              if (logger == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.logger = timestampLogger = (ILogger) TimestampService.hCbbOABHhSrlvVy9Wa8E(TimestampService.yGyU7ABHbhlO3LbwSmex(1251470110 >> 2 ^ 312781955));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return logger;
label_6:
        return timestampLogger;
      }
    }

    /// <summary>Признак, была ли инициализирована служба.</summary>
    protected bool IsInitialized => this.timestampDiff != long.MinValue;

    /// <summary>Синхронизировать время</summary>
    protected void SyncTime()
    {
      int num1 = 3;
      long num2;
      long num3;
      while (true)
      {
        switch (num1)
        {
          case 2:
            if (!this.IsInitialized)
            {
              num1 = 5;
              continue;
            }
            goto case 8;
          case 3:
            num2 = this.GetServerTimestamp() - this.GetMasterTimestamp();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_12;
          case 6:
            if (num3 > 30L)
            {
              num1 = 7;
              continue;
            }
            goto case 10;
          case 7:
            TimestampService.ALe6NwBHEDInEBHWp0sK(TimestampService.TQVowdBHGWuRM4sG7tAY((object) this), TimestampService.yGyU7ABHbhlO3LbwSmex(694673736 ^ -23604109 ^ -672046247));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 7 : 9;
            continue;
          case 8:
            num3 = Math.Abs(num2 - this.timestampDiff) / 100L;
            num1 = 6;
            continue;
          case 10:
            if (num3 <= 1L)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            }
            goto case 11;
          case 11:
            TimestampService.ai9VEOBHfbh8PQDPE8l4(TimestampService.TQVowdBHGWuRM4sG7tAY((object) this), TimestampService.yGyU7ABHbhlO3LbwSmex(333888594 ^ 1075625116 ^ 1408980480));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
            continue;
          default:
            this.timestampDiff = num2;
            num1 = 4;
            continue;
        }
      }
label_12:;
    }

    /// <summary>
    /// Получить штамп времени из источника эталонного времени.
    /// </summary>
    /// <returns>Штамп времени.</returns>
    protected long GetMasterTimestamp() => this.GetTimestampOffset(this.TransformationProvider.GetUtcDateTimeNow() - this.ORIGIN_DATE);

    /// <summary>Получить штамп времени локального сервера.</summary>
    /// <returns>Штамп времени.</returns>
    protected virtual long GetServerTimestamp() => (long) (TimestampService.GetTickCount64() / 10UL);

    /// <summary>
    /// Получить смещение для штампа времени из интервала времени.
    /// </summary>
    /// <param name="timeSpan">Интервал времени.</param>
    /// <returns>Смещение для штампа времени.</returns>
    protected long GetTimestampOffset(TimeSpan timeSpan) => timeSpan.Ticks / 10000L / 10L;

    /// <summary>Загрузить настройки службы</summary>
    protected void LoadSettings()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        long result;
        string s;
        while (true)
        {
          switch (num2)
          {
            case 1:
              result = 0L;
              num2 = 6;
              continue;
            case 2:
              s = (string) TimestampService.DI3is9BHCxtOFDEEVrV7(TimestampService.rQ6jW0BHQdsUw2b9XTY5(), TimestampService.yGyU7ABHbhlO3LbwSmex(979449278 ^ 979395204));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_12;
            case 4:
            case 5:
              if (result <= 0L)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 6:
              goto label_7;
            case 7:
              this.syncInterval = (double) result;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 2 : 8;
              continue;
            case 8:
              goto label_4;
            default:
              result = 30L;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 7 : 1;
              continue;
          }
        }
label_7:
        if (string.IsNullOrEmpty(s))
        {
          num1 = 4;
          continue;
        }
label_12:
        long.TryParse(s, out result);
        num1 = 5;
      }
label_4:;
    }

    private void TryInitialize()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (TimestampService.UoTitwBHv0RShD1OvMwf((object) this) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 2:
              if (!this.IsInitialized)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
                continue;
              }
              goto label_3;
            case 3:
              goto label_4;
            case 4:
              goto label_6;
            default:
              goto label_5;
          }
        }
label_5:
        this.SyncTime();
        num1 = 4;
      }
label_4:
      return;
label_6:
      return;
label_9:
      throw new InvalidOperationException((string) TimestampService.a56j3BBH8dkbyShrvInU(TimestampService.yGyU7ABHbhlO3LbwSmex(-1088304168 ^ -1088381792)));
label_3:;
    }

    [DllImport("kernel32.dll")]
    private static extern ulong GetTickCount64();

    internal static void WCLGaZBHBjm0VVsa6sow() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JF0SXKB6zvHqSXC5daC1() => TimestampService.hxla1bB6cddcx1MJWo5c == null;

    internal static TimestampService B0KQXCBHFB8MxTZJ5pMM() => TimestampService.hxla1bB6cddcx1MJWo5c;

    internal static long b3rJWbBHWpnVDnDYD45k([In] object obj0) => ((TimestampService) obj0).GetServerTimestamp();

    internal static TimeSpan bV4aXEBHoQG04080rr9s([In] double obj0) => TimeSpan.FromSeconds(obj0);

    internal static object yGyU7ABHbhlO3LbwSmex(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object hCbbOABHhSrlvVy9Wa8E([In] object obj0) => (object) Logger.GetLogger((string) obj0);

    internal static object TQVowdBHGWuRM4sG7tAY([In] object obj0) => (object) ((TimestampService) obj0).TimestampLogger;

    internal static void ALe6NwBHEDInEBHWp0sK([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static void ai9VEOBHfbh8PQDPE8l4([In] object obj0, [In] object obj1) => ((ILogger) obj0).Warn(obj1);

    internal static object rQ6jW0BHQdsUw2b9XTY5() => (object) ConfigurationManager.AppSettings;

    internal static object DI3is9BHCxtOFDEEVrV7([In] object obj0, [In] object obj1) => (object) ((NameValueCollection) obj0)[(string) obj1];

    internal static object UoTitwBHv0RShD1OvMwf([In] object obj0) => (object) ((TimestampService) obj0).TransformationProvider;

    internal static object a56j3BBH8dkbyShrvInU([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
