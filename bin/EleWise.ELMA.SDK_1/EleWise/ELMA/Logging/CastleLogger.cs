// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.CastleLogger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Logging
{
  internal class CastleLogger : ILogger
  {
    private readonly Castle.Core.Logging.ILogger castleLogger;
    internal static CastleLogger pZSJxshdBAnMXM7qsaZh;

    public CastleLogger(Castle.Core.Logging.ILogger castleLogger)
    {
      CastleLogger.I2WwJ7hdb8l3wVY54dOs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.castleLogger = castleLogger;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public bool IsEnabled(LogLevel level)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            switch (level)
            {
              case LogLevel.Verbose:
              case LogLevel.Trace:
              case LogLevel.Debug:
                goto label_2;
              case LogLevel.Information:
                goto label_3;
              case LogLevel.Warning:
                goto label_4;
              case LogLevel.Error:
                goto label_5;
              case LogLevel.Fatal:
                goto label_6;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                continue;
            }
          case 2:
            goto label_2;
          default:
            goto label_7;
        }
      }
label_2:
      return CastleLogger.EWEdt9hdhvKFXeMjHqYl((object) this.castleLogger);
label_3:
      return CastleLogger.yHEi4XhdGaqGkFtO0ntU((object) this.castleLogger);
label_4:
      return CastleLogger.RE1Q6RhdEfO4eOoZ9Gcy((object) this.castleLogger);
label_5:
      return this.castleLogger.IsErrorEnabled;
label_6:
      return CastleLogger.hBcQdmhdfs0ay7Nu25JI((object) this.castleLogger);
label_7:
      return false;
    }

    public void Log(LogLevel level, Exception exception, string format, params object[] args)
    {
      int num = 14;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_23;
          case 2:
            goto label_29;
          case 3:
            goto label_14;
          case 4:
            goto label_25;
          case 5:
            goto label_12;
          case 6:
            goto label_3;
          case 7:
            goto label_10;
          case 8:
            switch (level)
            {
              case LogLevel.Verbose:
              case LogLevel.Trace:
              case LogLevel.Debug:
                CastleLogger.TMapFHhdQNSDaytJpiBE((object) this.castleLogger, (object) format, (object) exception);
                num = 11;
                continue;
              case LogLevel.Information:
                CastleLogger.sj3m3phdCPPiNhymZaY6((object) this.castleLogger, (object) format, (object) exception);
                num = 3;
                continue;
              case LogLevel.Warning:
                CastleLogger.h3lZSKhdvIacGrne6JL4((object) this.castleLogger, (object) format, (object) exception);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 10 : 2;
                continue;
              case LogLevel.Error:
                CastleLogger.xBaKryhd8THpyJbnkHnw((object) this.castleLogger, (object) format, (object) exception);
                num = 2;
                continue;
              case LogLevel.Fatal:
                CastleLogger.AdgvTIhdZx68tdP6VHvI((object) this.castleLogger, (object) format, (object) exception);
                num = 9;
                continue;
              default:
                num = 6;
                continue;
            }
          case 9:
            goto label_18;
          case 10:
            goto label_20;
          case 11:
            goto label_9;
          case 12:
            goto label_7;
          case 13:
            switch (level)
            {
              case LogLevel.Verbose:
              case LogLevel.Trace:
              case LogLevel.Debug:
                CastleLogger.Md7tPUhdug9Bskb6Q2qn((object) this.castleLogger, (object) exception, (object) format, (object) args);
                num = 7;
                continue;
              case LogLevel.Information:
                CastleLogger.fTOpLxhdI9l2VmiySeyp((object) this.castleLogger, (object) exception, (object) format, (object) args);
                num = 4;
                continue;
              case LogLevel.Warning:
                CastleLogger.MnWkJZhdVBe3H7Aw1PMa((object) this.castleLogger, (object) exception, (object) format, (object) args);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
                continue;
              case LogLevel.Error:
                CastleLogger.bjovochdSGqvZJyYuNhF((object) this.castleLogger, (object) exception, (object) format, (object) args);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                continue;
              case LogLevel.Fatal:
                CastleLogger.Alh9QphdiX8BG0mFIRfS((object) this.castleLogger, (object) exception, (object) format, (object) args);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 6 : 12;
                continue;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 5 : 5;
                continue;
            }
          case 14:
            if (args != null)
            {
              num = 13;
              continue;
            }
            goto case 8;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_23:
      return;
label_29:
      return;
label_14:
      return;
label_25:
      return;
label_12:
      return;
label_3:
      return;
label_10:
      return;
label_18:
      return;
label_20:
      return;
label_9:
      return;
label_7:
      return;
label_2:;
    }

    public event EventHandler ConfigurationChanged
    {
      add
      {
        int num = 3;
        EventHandler eventHandler1;
        EventHandler comparand;
        EventHandler eventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              eventHandler2 = (EventHandler) CastleLogger.LuxCDkhdRNcDmY1YaXKw((object) comparand, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
              continue;
            case 2:
              comparand = eventHandler1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
              continue;
            case 3:
              eventHandler1 = this.ConfigurationChanged;
              num = 2;
              continue;
            case 4:
              goto label_2;
            case 5:
              if (eventHandler1 == comparand)
              {
                num = 4;
                continue;
              }
              goto case 2;
            default:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler2, comparand);
              num = 5;
              continue;
          }
        }
label_2:;
      }
      remove
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          EventHandler eventHandler1;
          EventHandler comparand;
          EventHandler eventHandler2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_4;
              case 2:
                goto label_9;
              case 3:
                eventHandler1 = this.ConfigurationChanged;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 1;
                continue;
              case 4:
                goto label_3;
              case 5:
                eventHandler2 = (EventHandler) CastleLogger.K7GboOhdqRKQY3WJ0UgH((object) comparand, (object) value);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                continue;
              default:
                eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler2, comparand);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
                continue;
            }
          }
label_4:
          if (eventHandler1 == comparand)
          {
            num1 = 4;
            continue;
          }
label_9:
          comparand = eventHandler1;
          num1 = 5;
        }
label_3:;
      }
    }

    internal static void I2WwJ7hdb8l3wVY54dOs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xxErg4hdWeHnA7pms5M7() => CastleLogger.pZSJxshdBAnMXM7qsaZh == null;

    internal static CastleLogger Co8Bs4hdo0AXDYOR0d0w() => CastleLogger.pZSJxshdBAnMXM7qsaZh;

    internal static bool EWEdt9hdhvKFXeMjHqYl([In] object obj0) => ((Castle.Core.Logging.ILogger) obj0).IsDebugEnabled;

    internal static bool yHEi4XhdGaqGkFtO0ntU([In] object obj0) => ((Castle.Core.Logging.ILogger) obj0).IsInfoEnabled;

    internal static bool RE1Q6RhdEfO4eOoZ9Gcy([In] object obj0) => ((Castle.Core.Logging.ILogger) obj0).IsWarnEnabled;

    internal static bool hBcQdmhdfs0ay7Nu25JI([In] object obj0) => ((Castle.Core.Logging.ILogger) obj0).IsFatalEnabled;

    internal static void TMapFHhdQNSDaytJpiBE([In] object obj0, [In] object obj1, [In] object obj2) => ((Castle.Core.Logging.ILogger) obj0).Debug((string) obj1, (Exception) obj2);

    internal static void sj3m3phdCPPiNhymZaY6([In] object obj0, [In] object obj1, [In] object obj2) => ((Castle.Core.Logging.ILogger) obj0).Info((string) obj1, (Exception) obj2);

    internal static void h3lZSKhdvIacGrne6JL4([In] object obj0, [In] object obj1, [In] object obj2) => ((Castle.Core.Logging.ILogger) obj0).Warn((string) obj1, (Exception) obj2);

    internal static void xBaKryhd8THpyJbnkHnw([In] object obj0, [In] object obj1, [In] object obj2) => ((Castle.Core.Logging.ILogger) obj0).Error((string) obj1, (Exception) obj2);

    internal static void AdgvTIhdZx68tdP6VHvI([In] object obj0, [In] object obj1, [In] object obj2) => ((Castle.Core.Logging.ILogger) obj0).Fatal((string) obj1, (Exception) obj2);

    internal static void Md7tPUhdug9Bskb6Q2qn([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((Castle.Core.Logging.ILogger) obj0).DebugFormat((Exception) obj1, (string) obj2, (object[]) obj3);

    internal static void fTOpLxhdI9l2VmiySeyp([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((Castle.Core.Logging.ILogger) obj0).InfoFormat((Exception) obj1, (string) obj2, (object[]) obj3);

    internal static void MnWkJZhdVBe3H7Aw1PMa([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((Castle.Core.Logging.ILogger) obj0).WarnFormat((Exception) obj1, (string) obj2, (object[]) obj3);

    internal static void bjovochdSGqvZJyYuNhF([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((Castle.Core.Logging.ILogger) obj0).ErrorFormat((Exception) obj1, (string) obj2, (object[]) obj3);

    internal static void Alh9QphdiX8BG0mFIRfS([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((Castle.Core.Logging.ILogger) obj0).FatalFormat((Exception) obj1, (string) obj2, (object[]) obj3);

    internal static object LuxCDkhdRNcDmY1YaXKw([In] object obj0, [In] object obj1) => (object) Delegate.Combine((Delegate) obj0, (Delegate) obj1);

    internal static object K7GboOhdqRKQY3WJ0UgH([In] object obj0, [In] object obj1) => (object) Delegate.Remove((Delegate) obj0, (Delegate) obj1);
  }
}
