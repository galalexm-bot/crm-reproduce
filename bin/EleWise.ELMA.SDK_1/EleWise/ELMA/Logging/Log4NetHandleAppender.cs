// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.Log4NetHandleAppender
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Logging
{
  [Component(EnableInterceptiors = false, InjectProerties = false)]
  internal class Log4NetHandleAppender : AppenderSkeleton, ILoggerEventHandler
  {
    internal static Log4NetHandleAppender h6HSVbhlUT9U56jh7Adh;

    internal Log4NetHandleAppender()
    {
      Log4NetHandleAppender.v7uPywhlzsugO97qZL0y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public event LogEventHandler Logged
    {
      add
      {
        int num1 = 4;
        while (true)
        {
          int num2 = num1;
          LogEventHandler logEventHandler1;
          LogEventHandler comparand;
          LogEventHandler logEventHandler2;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_3;
              case 1:
                if (logEventHandler1 == comparand)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                  continue;
                }
                goto label_4;
              case 2:
                logEventHandler2 = (LogEventHandler) Log4NetHandleAppender.fkaGO3hrFRB5JRvrrTSA((object) comparand, (object) value);
                num2 = 5;
                continue;
              case 3:
                goto label_4;
              case 4:
                logEventHandler1 = this.Logged;
                num2 = 3;
                continue;
              case 5:
                logEventHandler1 = Interlocked.CompareExchange<LogEventHandler>(ref this.Logged, logEventHandler2, comparand);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
                continue;
              default:
                goto label_10;
            }
          }
label_4:
          comparand = logEventHandler1;
          num1 = 2;
        }
label_3:
        return;
label_10:;
      }
      remove
      {
        int num = 2;
        LogEventHandler logEventHandler1;
        LogEventHandler comparand;
        LogEventHandler logEventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              comparand = logEventHandler1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 5 : 5;
              continue;
            case 2:
              logEventHandler1 = this.Logged;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
              continue;
            case 3:
              logEventHandler1 = Interlocked.CompareExchange<LogEventHandler>(ref this.Logged, logEventHandler2, comparand);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_2;
            case 5:
              logEventHandler2 = (LogEventHandler) Log4NetHandleAppender.mfD8bchrBU074IlXdY4R((object) comparand, (object) value);
              num = 3;
              continue;
            default:
              if (logEventHandler1 == comparand)
              {
                num = 4;
                continue;
              }
              goto case 1;
          }
        }
label_2:;
      }
    }

    internal void Append(LoggingEventArgs loggingEventArgs)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Logged.RaiseSafe((object) loggingEventArgs);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override void Append([NotNull] LoggingEvent loggingEvent)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        LoggingEventArgs loggingEventArgs1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              Log4NetHandleAppender.Vd6NGMhrfMTIovhYj9ey((object) loggingEventArgs1, LogLevel.Fatal);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 15 : 8;
              continue;
            case 2:
            case 13:
              if (Log4NetHandleAppender.xliEiChrQdtkF9kxtpj7((object) loggingEvent.Level, (object) Level.Info))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 9 : 8;
                continue;
              }
              goto default;
            case 3:
            case 12:
              if (!Log4NetHandleAppender.xliEiChrQdtkF9kxtpj7(Log4NetHandleAppender.q4ZGVAhrCS4nvihY29Z5((object) loggingEvent), (object) Level.Verbose))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 2;
                continue;
              }
              goto case 8;
            case 4:
            case 23:
              if (Log4NetHandleAppender.xliEiChrQdtkF9kxtpj7(Log4NetHandleAppender.q4ZGVAhrCS4nvihY29Z5((object) loggingEvent), (object) Level.Warn))
              {
                num2 = 5;
                continue;
              }
              goto case 14;
            case 5:
              loggingEventArgs1.Level = LogLevel.Warning;
              num2 = 14;
              continue;
            case 6:
              LoggingEventArgs loggingEventArgs2 = new LoggingEventArgs();
              Log4NetHandleAppender.nIHR08hrbROnWLQTML3t((object) loggingEventArgs2, Log4NetHandleAppender.qkDTQ1hroetR6O0sclOP((object) loggingEvent));
              Log4NetHandleAppender.reREPLhrhot0CTkPuEmO((object) loggingEventArgs2, (object) loggingEvent.ExceptionObject);
              Log4NetHandleAppender.JOAQ8YhrEsxEL8JeNhJi((object) loggingEventArgs2, Log4NetHandleAppender.rF9AeVhrG2KhQ1YRgDoQ((object) loggingEvent));
              Log4NetHandleAppender.Vd6NGMhrfMTIovhYj9ey((object) loggingEventArgs2, LogLevel.Verbose);
              loggingEventArgs1 = loggingEventArgs2;
              num2 = 17;
              continue;
            case 7:
              goto label_5;
            case 8:
              Log4NetHandleAppender.Vd6NGMhrfMTIovhYj9ey((object) loggingEventArgs1, LogLevel.Verbose);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 13 : 13;
              continue;
            case 9:
              Log4NetHandleAppender.Vd6NGMhrfMTIovhYj9ey((object) loggingEventArgs1, LogLevel.Information);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            case 10:
              Log4NetHandleAppender.Vd6NGMhrfMTIovhYj9ey((object) loggingEventArgs1, LogLevel.Error);
              num2 = 11;
              continue;
            case 11:
            case 22:
              if (!Log4NetHandleAppender.xliEiChrQdtkF9kxtpj7(Log4NetHandleAppender.q4ZGVAhrCS4nvihY29Z5((object) loggingEvent), (object) Level.Fatal))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 16 : 1;
                continue;
              }
              goto case 1;
            case 14:
              if (!Log4NetHandleAppender.xliEiChrQdtkF9kxtpj7(Log4NetHandleAppender.q4ZGVAhrCS4nvihY29Z5((object) loggingEvent), (object) Level.Error))
              {
                num2 = 22;
                continue;
              }
              goto case 10;
            case 15:
            case 16:
              this.Append(loggingEventArgs1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 19 : 16;
              continue;
            case 17:
              if (!Log4NetHandleAppender.xliEiChrQdtkF9kxtpj7((object) loggingEvent.Level, (object) Level.Trace))
              {
                num2 = 3;
                continue;
              }
              goto case 21;
            case 18:
              goto label_23;
            case 19:
              goto label_29;
            case 20:
              Log4NetHandleAppender.Vd6NGMhrfMTIovhYj9ey((object) loggingEventArgs1, LogLevel.Debug);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 4;
              continue;
            case 21:
              Log4NetHandleAppender.Vd6NGMhrfMTIovhYj9ey((object) loggingEventArgs1, LogLevel.Trace);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 4 : 12;
              continue;
            default:
              if (!Log4NetHandleAppender.xliEiChrQdtkF9kxtpj7(Log4NetHandleAppender.q4ZGVAhrCS4nvihY29Z5((object) loggingEvent), (object) Level.Debug))
              {
                num2 = 23;
                continue;
              }
              goto case 20;
          }
        }
label_5:
        if (loggingEvent != null)
          num1 = 6;
        else
          goto label_23;
      }
label_29:
      return;
label_23:
      throw new ArgumentNullException((string) Log4NetHandleAppender.Pm5mQihrWkT7VnNNkVIf(-787452571 ^ -787219551));
    }

    internal static void v7uPywhlzsugO97qZL0y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool PR75F6hlsst5vqPb95Gl() => Log4NetHandleAppender.h6HSVbhlUT9U56jh7Adh == null;

    internal static Log4NetHandleAppender EiLsKphlc8UM182HO7lD() => Log4NetHandleAppender.h6HSVbhlUT9U56jh7Adh;

    internal static object fkaGO3hrFRB5JRvrrTSA([In] object obj0, [In] object obj1) => (object) Delegate.Combine((Delegate) obj0, (Delegate) obj1);

    internal static object mfD8bchrBU074IlXdY4R([In] object obj0, [In] object obj1) => (object) Delegate.Remove((Delegate) obj0, (Delegate) obj1);

    internal static object Pm5mQihrWkT7VnNNkVIf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static DateTime qkDTQ1hroetR6O0sclOP([In] object obj0) => ((LoggingEvent) obj0).TimeStamp;

    internal static void nIHR08hrbROnWLQTML3t([In] object obj0, DateTime value) => ((LoggingEventArgs) obj0).TimeStamp = value;

    internal static void reREPLhrhot0CTkPuEmO([In] object obj0, [In] object obj1) => ((LoggingEventArgs) obj0).Exception = (Exception) obj1;

    internal static object rF9AeVhrG2KhQ1YRgDoQ([In] object obj0) => (object) ((LoggingEvent) obj0).RenderedMessage;

    internal static void JOAQ8YhrEsxEL8JeNhJi([In] object obj0, [In] object obj1) => ((LoggingEventArgs) obj0).Message = (string) obj1;

    internal static void Vd6NGMhrfMTIovhYj9ey([In] object obj0, LogLevel value) => ((LoggingEventArgs) obj0).Level = value;

    internal static bool xliEiChrQdtkF9kxtpj7([In] object obj0, [In] object obj1) => (Level) obj0 == (Level) obj1;

    internal static object q4ZGVAhrCS4nvihY29Z5([In] object obj0) => (object) ((LoggingEvent) obj0).Level;
  }
}
