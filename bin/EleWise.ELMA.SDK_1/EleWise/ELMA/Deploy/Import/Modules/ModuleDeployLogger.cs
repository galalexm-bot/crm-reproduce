// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Modules.ModuleDeployLogger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Deploy.Import.Modules
{
  /// <summary>
  /// Направляет сообщения в лог и произвольный <see cref="T:System.IO.TextWriter" />
  /// </summary>
  public sealed class ModuleDeployLogger : ILogger, IDisposable
  {
    private readonly ILogger logger;
    private TextWriter writer;
    private readonly EleWise.ELMA.Logging.LogLevel logLevel;
    private static ModuleDeployLogger W40AtSEMKRDiqVTYK2ta;

    /// <summary>Ctor</summary>
    /// <param name="logger">Базовый логер</param>
    /// <param name="writer">Дополнительный поток для записи форматированного лога</param>
    /// <param name="logLevel">Уровень логирования для записи в <paramref name="writer" /></param>
    public ModuleDeployLogger(ILogger logger, TextWriter writer, EleWise.ELMA.Logging.LogLevel logLevel = EleWise.ELMA.Logging.LogLevel.Information)
    {
      ModuleDeployLogger.ONyEH7EMklspvU35NVnn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.logger = logger;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
            continue;
          case 3:
            this.logLevel = logLevel;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
            continue;
          default:
            this.writer = writer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 3;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public event EventHandler ConfigurationChanged
    {
      add
      {
        int num = 1;
        while (true)
        {
          EventHandler eventHandler1;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch (num)
          {
            case 1:
              eventHandler1 = this.ConfigurationChanged;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            case 2:
              eventHandler2 = comparand + value;
              num = 5;
              continue;
            case 3:
              if (eventHandler1 == comparand)
              {
                num = 4;
                continue;
              }
              break;
            case 4:
              goto label_2;
            case 5:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler2, comparand);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 3;
              continue;
          }
          comparand = eventHandler1;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 2;
        }
label_2:;
      }
      remove
      {
        int num = 3;
        EventHandler eventHandler1;
        EventHandler comparand;
        EventHandler eventHandler2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              eventHandler1 = (EventHandler) ModuleDeployLogger.rMLTSfEMnK65CYf8mlyA((object) comparand, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 4 : 4;
              continue;
            case 2:
              comparand = eventHandler2;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
              continue;
            case 3:
              eventHandler2 = this.ConfigurationChanged;
              num = 2;
              continue;
            case 4:
              eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler1, comparand);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 3 : 5;
              continue;
            case 5:
              if (eventHandler2 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            default:
              goto label_9;
          }
        }
label_2:
        return;
label_9:;
      }
    }

    /// <inheritdoc />
    public void Log(EleWise.ELMA.Logging.LogLevel level, Exception exception, string format, params object[] args)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.logger.Log(level, exception, format, args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
            continue;
          case 2:
            ModuleDeployLogger.AGY6bBEM1dQoasZr9xKv((object) this.writer, ModuleDeployLogger.m08EdBEMPOWAkXxcjvpM((object) new string[6]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309612194),
              (string) ModuleDeployLogger.dmS8QKEM2MNBkBggFq0d(level),
              (string) ModuleDeployLogger.QiHTCGEMe16NQLSAR3wp(1819636893 << 3 ^ 1672449144),
              DateTime.Now.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488647003)),
              (string) ModuleDeployLogger.QiHTCGEMe16NQLSAR3wp(381945751 ^ 1158627804 ^ 1405847021),
              str
            }));
            num = 4;
            continue;
          case 3:
            goto label_7;
          case 4:
            goto label_2;
          default:
            if (level < this.logLevel)
            {
              num = 3;
              continue;
            }
            str = (string) ModuleDeployLogger.HpcXLhEMOitL1DVOPjBn((object) format, (object) (args ?? Array.Empty<object>()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 2;
            continue;
        }
      }
label_7:
      return;
label_2:;
    }

    private static string StringifyLogLevel(EleWise.ELMA.Logging.LogLevel level)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            switch (level)
            {
              case EleWise.ELMA.Logging.LogLevel.Verbose:
                goto label_2;
              case EleWise.ELMA.Logging.LogLevel.Trace:
                goto label_3;
              case EleWise.ELMA.Logging.LogLevel.Debug:
                goto label_4;
              case EleWise.ELMA.Logging.LogLevel.Information:
                goto label_5;
              case EleWise.ELMA.Logging.LogLevel.Warning:
                goto label_6;
              case EleWise.ELMA.Logging.LogLevel.Error:
                goto label_7;
              case EleWise.ELMA.Logging.LogLevel.Fatal:
                goto label_8;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
                continue;
            }
          default:
            goto label_2;
        }
      }
label_2:
      return (string) ModuleDeployLogger.QiHTCGEMe16NQLSAR3wp(-951514650 ^ -951208032);
label_3:
      return (string) ModuleDeployLogger.QiHTCGEMe16NQLSAR3wp(~541731958 ^ -542020131);
label_4:
      return (string) ModuleDeployLogger.QiHTCGEMe16NQLSAR3wp(~289714581 ^ -289411064);
label_5:
      return (string) ModuleDeployLogger.QiHTCGEMe16NQLSAR3wp(1021410165 ^ 1021691141);
label_6:
      return (string) ModuleDeployLogger.QiHTCGEMe16NQLSAR3wp(1218962250 ^ 1218665780);
label_7:
      return (string) ModuleDeployLogger.QiHTCGEMe16NQLSAR3wp(-1120607109 - 305487170 ^ -1426376267);
label_8:
      return (string) ModuleDeployLogger.QiHTCGEMe16NQLSAR3wp(1597012150 ^ 1597294124);
label_9:
      throw new InvalidOperationException((string) ModuleDeployLogger.QiHTCGEMe16NQLSAR3wp(-787452571 ^ -787164211));
    }

    /// <inheritdoc />
    void IDisposable.Dispose()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              ModuleDeployLogger.mhAqUTEMpCev6LGWJHmq((object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
              continue;
            case 3:
              ModuleDeployLogger.Jn4rqKEMNvevkahesyIt((object) this.writer);
              num2 = 6;
              continue;
            case 4:
              if (this.writer != null)
              {
                num2 = 3;
                continue;
              }
              goto label_11;
            case 5:
              ModuleDeployLogger.xFTSZmEM3YfE0GEX3Ihr((object) this.writer);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_4;
            default:
              this.writer = (TextWriter) null;
              num2 = 2;
              continue;
          }
        }
label_4:
        this.writer.Close();
        num1 = 5;
      }
label_3:
      return;
label_11:;
    }

    /// <summary>Dctor</summary>
    ~ModuleDeployLogger()
    {
      switch (1)
      {
        case 1:
          try
          {
            ModuleDeployLogger.lISf94EMan1NQmvQKQDE((object) this);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
          finally
          {
            ModuleDeployLogger.wVSZAUEMDXG4YuPaFOaU((object) this);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
      }
    }

    /// <inheritdoc />
    bool ILogger.IsEnabled(EleWise.ELMA.Logging.LogLevel level) => true;

    internal static void ONyEH7EMklspvU35NVnn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool nWWsEZEMXHdCtgo7Eb62() => ModuleDeployLogger.W40AtSEMKRDiqVTYK2ta == null;

    internal static ModuleDeployLogger PlBVZVEMToDW5eJaNCA6() => ModuleDeployLogger.W40AtSEMKRDiqVTYK2ta;

    internal static object rMLTSfEMnK65CYf8mlyA([In] object obj0, [In] object obj1) => (object) Delegate.Remove((Delegate) obj0, (Delegate) obj1);

    internal static object HpcXLhEMOitL1DVOPjBn([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object dmS8QKEM2MNBkBggFq0d(EleWise.ELMA.Logging.LogLevel level) => (object) ModuleDeployLogger.StringifyLogLevel(level);

    internal static object QiHTCGEMe16NQLSAR3wp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object m08EdBEMPOWAkXxcjvpM([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static void AGY6bBEM1dQoasZr9xKv([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static void Jn4rqKEMNvevkahesyIt([In] object obj0) => ((TextWriter) obj0).Flush();

    internal static void xFTSZmEM3YfE0GEX3Ihr([In] object obj0) => ((TextWriter) obj0).Dispose();

    internal static void mhAqUTEMpCev6LGWJHmq([In] object obj0) => GC.SuppressFinalize(obj0);

    internal static void lISf94EMan1NQmvQKQDE([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void wVSZAUEMDXG4YuPaFOaU([In] object obj0) => __nonvirtual (obj0.Finalize());
  }
}
