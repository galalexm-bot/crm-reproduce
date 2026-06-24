// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.LoggingExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Logging
{
  public static class LoggingExtensions
  {
    public const string CONTEXT_LOG_CALL_TYPE_KEY = "EleWise.ELMA.Logging.LoggingExtensions.ContextCallType";
    internal static LoggingExtensions tkG30Mhl8R3J75S1mhjP;

    public static bool IsVerboseEnabled(this ILogger log) => log.IsEnabled(LogLevel.Verbose);

    public static bool IsTraceEnabled(this ILogger log) => log.IsEnabled(LogLevel.Trace);

    public static bool IsDebugEnabled(this ILogger log) => LoggingExtensions.buKaZQhlIBuDdLWyTtfb((object) log, LogLevel.Debug);

    public static bool IsInfoEnabled(this ILogger log) => LoggingExtensions.buKaZQhlIBuDdLWyTtfb((object) log, LogLevel.Information);

    public static bool IsWarnEnabled(this ILogger log) => LoggingExtensions.buKaZQhlIBuDdLWyTtfb((object) log, LogLevel.Warning);

    public static bool IsErrorEnabled(this ILogger log) => log.IsEnabled(LogLevel.Error);

    public static bool IsFatalEnabled(this ILogger log) => LoggingExtensions.buKaZQhlIBuDdLWyTtfb((object) log, LogLevel.Fatal);

    public static void Verbose(this ILogger logger, object message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.CFc3UlhlVhaoLL6ktxNV((object) logger, LogLevel.Verbose, message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Trace(this ILogger logger, object message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            logger.Log(LogLevel.Trace, message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Debug(this ILogger logger, object message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            logger.Log(LogLevel.Debug, message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Info(this ILogger logger, object message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.CFc3UlhlVhaoLL6ktxNV((object) logger, LogLevel.Information, message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Warn(this ILogger logger, object message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.CFc3UlhlVhaoLL6ktxNV((object) logger, LogLevel.Warning, message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Error(this ILogger logger, object message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.CFc3UlhlVhaoLL6ktxNV((object) logger, LogLevel.Error, message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Fatal(this ILogger logger, object message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.CFc3UlhlVhaoLL6ktxNV((object) logger, LogLevel.Fatal, message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Log(this ILogger logger, LogLevel level, object message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.UlxBLPhlSIMjgwpjPXGw((object) logger, level, (object) null, message, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Verbose(this ILogger logger, object message, Exception exception)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            logger.Log(LogLevel.Verbose, message, exception);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Trace(this ILogger logger, object message, Exception exception)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.GJ90ONhlisSfgjgFfgsl((object) logger, LogLevel.Trace, message, (object) exception);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Debug(this ILogger logger, object message, Exception exception)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.GJ90ONhlisSfgjgFfgsl((object) logger, LogLevel.Debug, message, (object) exception);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Info(this ILogger logger, object message, Exception exception)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.GJ90ONhlisSfgjgFfgsl((object) logger, LogLevel.Information, message, (object) exception);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Warn(this ILogger logger, object message, Exception exception)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.GJ90ONhlisSfgjgFfgsl((object) logger, LogLevel.Warning, message, (object) exception);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Error(this ILogger logger, object message, Exception exception)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.GJ90ONhlisSfgjgFfgsl((object) logger, LogLevel.Error, message, (object) exception);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Fatal(this ILogger logger, object message, Exception exception)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.GJ90ONhlisSfgjgFfgsl((object) logger, LogLevel.Fatal, message, (object) exception);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Log(
      this ILogger logger,
      LogLevel level,
      object message,
      Exception exception)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.UlxBLPhlSIMjgwpjPXGw((object) logger, level, (object) exception, message, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void VerboseFormat(this ILogger logger, string format, params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            logger.LogFormat(LogLevel.Verbose, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void TraceFormat(this ILogger logger, string format, params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            logger.LogFormat(LogLevel.Trace, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void DebugFormat(this ILogger logger, string format, params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            logger.LogFormat(LogLevel.Debug, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void InfoFormat(this ILogger logger, string format, params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            logger.LogFormat(LogLevel.Information, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void WarnFormat(this ILogger logger, string format, params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            logger.LogFormat(LogLevel.Warning, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void ErrorFormat(this ILogger logger, string format, params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            logger.LogFormat(LogLevel.Error, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void FatalFormat(this ILogger logger, string format, params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            logger.LogFormat(LogLevel.Fatal, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void LogFormat(
      this ILogger logger,
      LogLevel level,
      string format,
      params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.FilteredLog((object) logger, level, (object) null, (object) format, (object) args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Verbose(
      this ILogger logger,
      Exception exception,
      string format,
      params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.Log(logger, LogLevel.Verbose, exception, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Trace(
      this ILogger logger,
      Exception exception,
      string format,
      params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.Log(logger, LogLevel.Trace, exception, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Debug(
      this ILogger logger,
      Exception exception,
      string format,
      params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.Log(logger, LogLevel.Debug, exception, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Info(
      this ILogger logger,
      Exception exception,
      string format,
      params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.Log(logger, LogLevel.Information, exception, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Warn(
      this ILogger logger,
      Exception exception,
      string format,
      params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.Log(logger, LogLevel.Warning, exception, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Error(
      this ILogger logger,
      Exception exception,
      string format,
      params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.Log(logger, LogLevel.Error, exception, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Fatal(
      this ILogger logger,
      Exception exception,
      string format,
      params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.Log(logger, LogLevel.Fatal, exception, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Log(
      this ILogger logger,
      LogLevel level,
      Exception exception,
      string format,
      params object[] args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LoggingExtensions.UlxBLPhlSIMjgwpjPXGw((object) logger, level, (object) exception, (object) format, (object) args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static void FilteredLog(
      object logger,
      LogLevel level,
      object exception,
      object format,
      object objects)
    {
      int num1 = 5;
      IDisposable disposable;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_27;
            case 2:
              disposable = (IDisposable) LoggingExtensions.Wb3fS2hlRq6h7cKNrtdJ();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_28;
            case 4:
              if (!((ILogger) logger).IsEnabled(level))
              {
                num2 = 3;
                continue;
              }
              goto case 2;
            case 5:
              goto label_29;
            case 6:
              goto label_22;
            default:
              goto label_4;
          }
        }
label_29:
        if (logger != null)
          num1 = 4;
        else
          goto label_18;
      }
label_27:
      return;
label_28:
      return;
label_22:
      return;
label_4:
      try
      {
        int num3;
        if (!LoggingExtensions.z8ohvWhlqAFnwfPhWd5j())
        {
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
          goto label_8;
        }
        else
          goto label_9;
label_7:
        int num4;
        num3 = num4;
label_8:
        int num5;
        switch (num3)
        {
          case 1:
            goto label_13;
          case 2:
            return;
          case 3:
            return;
          case 4:
            goto label_11;
          case 5:
            num5 = LoggingExtensions.SjbQ3ChlKyS73KRtRKeF(LoggingExtensions.SUlnIkhlXTNEmGpUteIT()) != 0 ? 1 : 0;
            goto label_14;
        }
label_9:
        if (LoggingExtensions.SjbQ3ChlKyS73KRtRKeF((object) ComponentManager.Current) != ComponentManager.LifetimeStage.Disposed)
        {
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 5 : 2;
          goto label_8;
        }
        else
          goto label_13;
label_11:
        ContextVars.Set<Type>((string) LoggingExtensions.CHQfMphlTFs9675WNTMs(--1418440330 ^ 1418213482), (Type) null);
        num4 = 3;
        goto label_7;
label_13:
        num5 = 0;
label_14:
        if (num5 != 0 && !LoggingExtensions.jY7ktchlkM3RMbroWyqV(LoggingExtensions.CHQfMphlTFs9675WNTMs(~289714581 ^ -289875830)))
        {
          // ISSUE: type reference
          ContextVars.Set<Type>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88029763), LoggingExtensions.ByavuKhlnoU1muoD8XQT(__typeref (LoggingExtensions)));
        }
        string format1 = format == null ? "" : format.ToString();
        ((ILogger) logger).Log(level, (Exception) exception, format1, (object[]) objects);
        if (num5 == 0)
        {
          num4 = 2;
          goto label_7;
        }
        else
          goto label_11;
      }
      finally
      {
        int num6;
        if (disposable == null)
          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
        else
          goto label_24;
label_21:
        switch (num6)
        {
          case 1:
          case 2:
        }
label_24:
        LoggingExtensions.s3JNJfhlOK2tfnnMbZob((object) disposable);
        num6 = 2;
        goto label_21;
      }
label_18:;
    }

    internal static bool ViiBFIhlZPxO7P7nhW8i() => LoggingExtensions.tkG30Mhl8R3J75S1mhjP == null;

    internal static LoggingExtensions l8FQHqhlumex8LCaaJYH() => LoggingExtensions.tkG30Mhl8R3J75S1mhjP;

    internal static bool buKaZQhlIBuDdLWyTtfb([In] object obj0, LogLevel level) => ((ILogger) obj0).IsEnabled(level);

    internal static void CFc3UlhlVhaoLL6ktxNV([In] object obj0, LogLevel level, [In] object obj2) => ((ILogger) obj0).Log(level, obj2);

    internal static void UlxBLPhlSIMjgwpjPXGw(
      [In] object obj0,
      LogLevel level,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      LoggingExtensions.FilteredLog(obj0, level, obj2, obj3, obj4);
    }

    internal static void GJ90ONhlisSfgjgFfgsl(
      [In] object obj0,
      LogLevel level,
      [In] object obj2,
      [In] object obj3)
    {
      ((ILogger) obj0).Log(level, obj2, (Exception) obj3);
    }

    internal static object Wb3fS2hlRq6h7cKNrtdJ() => (object) ELMAContext.Create();

    internal static bool z8ohvWhlqAFnwfPhWd5j() => ComponentManager.Initialized;

    internal static ComponentManager.LifetimeStage SjbQ3ChlKyS73KRtRKeF([In] object obj0) => ((ComponentManager) obj0).Stage;

    internal static object SUlnIkhlXTNEmGpUteIT() => (object) ComponentManager.Current;

    internal static object CHQfMphlTFs9675WNTMs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool jY7ktchlkM3RMbroWyqV([In] object obj0) => ContextVars.Contains((string) obj0);

    internal static Type ByavuKhlnoU1muoD8XQT([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void s3JNJfhlOK2tfnnMbZob([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
