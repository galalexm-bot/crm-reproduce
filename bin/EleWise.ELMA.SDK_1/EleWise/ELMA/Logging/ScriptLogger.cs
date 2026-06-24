// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.ScriptLogger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Logging
{
  public static class ScriptLogger
  {
    private static ILogger log;
    internal static ScriptLogger VGdROoh996ndudqeXqRu;

    public static ILogger Log
    {
      get
      {
        int num1 = 3;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_2;
            case 3:
              if (ScriptLogger.OTJssDh9r8D6Nf4LbKbq())
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 1;
                continue;
              }
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 2;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return (ILogger) ScriptLogger.UJ7mVgh9gcZ705pscFNT();
label_6:
        ILogger log;
        return log;
label_7:
        try
        {
          int num2;
          if (ScriptLogger.log != null)
            num2 = 3;
          else
            goto label_11;
label_9:
          Log4NetFactory service;
          while (true)
          {
            ILogger logger;
            switch (num2)
            {
              case 1:
                goto label_11;
              case 2:
                logger = NullLogger.Instance;
                break;
              case 5:
                if (service == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 3 : 4;
                  continue;
                }
                goto case 7;
              case 6:
                goto label_6;
              case 7:
                ScriptLogger.log = (ILogger) ScriptLogger.kK1lG2h9j493nQYxAp45((object) service, ScriptLogger.IVDgJxh95GU5vLfcw56e(1012087039 ^ 1012034529));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                continue;
              default:
                logger = ScriptLogger.log;
                if (logger == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 2;
                  continue;
                }
                break;
            }
            log = logger;
            num2 = 6;
          }
label_11:
          service = Locator.GetService<ILoggerFactory>() as Log4NetFactory;
          num2 = 5;
          goto label_9;
        }
        catch
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_6;
              default:
                log = NullLogger.Instance;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
                continue;
            }
          }
        }
      }
    }

    static ScriptLogger() => ScriptLogger.TtMMa5h9YAREWwSf7Qj3();

    internal static bool OTJssDh9r8D6Nf4LbKbq() => Locator.Initialized;

    internal static object UJ7mVgh9gcZ705pscFNT() => (object) NullLogger.Instance;

    internal static object IVDgJxh95GU5vLfcw56e(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object kK1lG2h9j493nQYxAp45([In] object obj0, [In] object obj1) => (object) ((Log4NetFactory) obj0).Create((string) obj1);

    internal static bool vwc9Dhh9d2Uvu4VOvawC() => ScriptLogger.VGdROoh996ndudqeXqRu == null;

    internal static ScriptLogger wbuOuVh9lCm4wvhgiXxH() => ScriptLogger.VGdROoh996ndudqeXqRu;

    internal static void TtMMa5h9YAREWwSf7Qj3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
