// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.Log4NetLogger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using log4net;
using log4net.Core;
using log4net.Repository;
using log4net.Util;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Logging
{
  [Serializable]
  internal class Log4NetLogger : MarshalByRefObject, ILogger
  {
    private static readonly Type DeclaringType;
    private static readonly Type DefaultCallerType;
    private readonly log4net.Core.ILogger logger;
    private static readonly Lazy<ILogger> Instance;
    internal static Log4NetLogger yIoIKOhd7iS5X804JP0W;

    public static ILogger DefaultInstance
    {
      get
      {
        ILogger defaultInstance;
        switch (1)
        {
          case 1:
            try
            {
              defaultInstance = Log4NetLogger.Instance.Value;
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                num = 0;
              switch (num)
              {
              }
            }
            catch
            {
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                num = 0;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    goto label_1;
                  default:
                    defaultInstance = (ILogger) new NullLogger();
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
                    continue;
                }
              }
            }
            break;
        }
label_1:
        return defaultInstance;
      }
    }

    static Log4NetLogger()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            Log4NetLogger.DeclaringType = Log4NetLogger.dlUFBLhdyp4gUyfGkkru(__typeref (Log4NetLogger));
            num = 4;
            continue;
          case 2:
            // ISSUE: type reference
            // ISSUE: reference to a compiler-generated method
            Log4NetLogger.Instance = new Lazy<ILogger>((Func<ILogger>) (() => new Log4NetFactory().CreateLogger(Log4NetLogger.\u003C\u003Ec.jXAEnCvHPcCjbGYsd3R6(__typeref (Logger)))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
            continue;
          case 3:
            Log4NetLogger.nWL3brhdmDapZ2oNiPd5();
            num = 2;
            continue;
          case 4:
            Log4NetLogger.DefaultCallerType = typeof (LoggingExtensions);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    internal Log4NetLogger()
    {
      Log4NetLogger.nWL3brhdmDapZ2oNiPd5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public Log4NetLogger(log4net.Core.ILogger logger)
    {
      Log4NetLogger.nWL3brhdmDapZ2oNiPd5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.logger = logger;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal Log4NetLogger(ILog log)
    {
      Log4NetLogger.nWL3brhdmDapZ2oNiPd5();
      // ISSUE: explicit constructor call
      this.\u002Ector(log.Logger);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Level GetLevel(LogLevel level)
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
                goto label_2;
              case LogLevel.Trace:
                goto label_3;
              case LogLevel.Debug:
                goto label_4;
              case LogLevel.Information:
                goto label_5;
              case LogLevel.Warning:
                goto label_6;
              case LogLevel.Error:
                goto label_7;
              case LogLevel.Fatal:
                goto label_8;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                continue;
            }
          case 2:
            goto label_2;
          default:
            goto label_9;
        }
      }
label_2:
      return Level.Verbose;
label_3:
      return Level.Trace;
label_4:
      return Level.Debug;
label_5:
      return Level.Info;
label_6:
      return Level.Warn;
label_7:
      return Level.Error;
label_8:
      return Level.Fatal;
label_9:
      return Level.All;
    }

    public bool IsEnabled(LogLevel level) => Log4NetLogger.G7MEWshdM662KBHYltXC((object) this.logger, (object) Log4NetLogger.GetLevel(level));

    public void Log(LogLevel level, Exception exception, string format, params object[] args)
    {
      int num1 = 7;
      while (true)
      {
        Type declaringType;
        int num2;
        switch (num1)
        {
          case 1:
            if (((ComponentManager) Log4NetLogger.DtueSxhd94AenMIi76KD()).Stage != ComponentManager.LifetimeStage.Disposed)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 3;
              continue;
            }
            break;
          case 2:
            goto label_9;
          case 3:
            num2 = Log4NetLogger.piaefChddMvUMynYvjLf((object) ComponentManager.Current) != 0 ? 1 : 0;
            goto label_14;
          case 4:
label_16:
            log4net.Core.ILogger logger = this.logger;
            Type type = declaringType;
            Type callerStackBoundaryDeclaringType = (object) type == null ? Log4NetLogger.DefaultCallerType : type;
            object obj = Log4NetLogger.VsXPr9hdlTbdsp3aH0OB(level);
            SystemStringFormat message = new SystemStringFormat((IFormatProvider) Log4NetLogger.kAeT3VhdrjybIS5um6j8(), format, args);
            Exception exception1 = exception;
            logger.Log(callerStackBoundaryDeclaringType, (Level) obj, (object) message, exception1);
            num1 = 5;
            continue;
          case 5:
            goto label_17;
          case 6:
            declaringType = Log4NetLogger.DeclaringType;
            num1 = 8;
            continue;
          case 7:
            if (this.IsEnabled(level))
            {
              num1 = 6;
              continue;
            }
            goto label_5;
          case 8:
            if (Log4NetLogger.zOQcSphdJw1ka7L2hZYr())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
              continue;
            }
            break;
          default:
            ContextVars.TryGetValue<Type>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882358398), out declaringType);
            num1 = 4;
            continue;
        }
        num2 = 0;
label_14:
        if (num2 != 0)
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
        else
          goto label_16;
      }
label_9:
      return;
label_17:
      return;
label_5:;
    }

    public event EventHandler ConfigurationChanged
    {
      add
      {
        int num1 = 3;
        EventHandler value1;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_2;
            case 1:
              Log4NetLogger.sImVEkhd51Z3YaoPeb9r(Log4NetLogger.isOO2NhdgvXMDFRPkO1L((object) this.logger), (object) (LoggerRepositoryConfigurationChangedEventHandler) ((sender, args) =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      Log4NetLogger.\u003C\u003Ec__DisplayClass14_0.AYI6kevHaMV3DoOUeyfm((object) value1, sender, (object) args);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            case 2:
              value1 = value;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
              continue;
            case 3:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 2;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return;
label_6:;
      }
      remove
      {
        int num1 = 2;
        EventHandler value1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              value1 = value;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            case 2:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_2;
            default:
              Log4NetLogger.krPItrhdjAIAPb6gPM2R(Log4NetLogger.isOO2NhdgvXMDFRPkO1L((object) this.logger), (object) (LoggerRepositoryConfigurationChangedEventHandler) ((sender, args) =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      Log4NetLogger.\u003C\u003Ec__DisplayClass15_0.OhdNXIvH6ma9EwxjhyDb((object) value1, sender, (object) args);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num1 = 3;
              continue;
          }
        }
label_2:;
      }
    }

    internal static bool dcFAA8hdxtrtYe9imr4Z() => Log4NetLogger.yIoIKOhd7iS5X804JP0W == null;

    internal static Log4NetLogger Ei6vfZhd0FcMtxbJ6CQI() => Log4NetLogger.yIoIKOhd7iS5X804JP0W;

    internal static void nWL3brhdmDapZ2oNiPd5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type dlUFBLhdyp4gUyfGkkru([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool G7MEWshdM662KBHYltXC([In] object obj0, [In] object obj1) => ((log4net.Core.ILogger) obj0).IsEnabledFor((Level) obj1);

    internal static bool zOQcSphdJw1ka7L2hZYr() => ComponentManager.Initialized;

    internal static object DtueSxhd94AenMIi76KD() => (object) ComponentManager.Current;

    internal static ComponentManager.LifetimeStage piaefChddMvUMynYvjLf([In] object obj0) => ((ComponentManager) obj0).Stage;

    internal static object VsXPr9hdlTbdsp3aH0OB(LogLevel level) => (object) Log4NetLogger.GetLevel(level);

    internal static object kAeT3VhdrjybIS5um6j8() => (object) CultureInfo.InvariantCulture;

    internal static object isOO2NhdgvXMDFRPkO1L([In] object obj0) => (object) ((log4net.Core.ILogger) obj0).Repository;

    internal static void sImVEkhd51Z3YaoPeb9r([In] object obj0, [In] object obj1) => ((ILoggerRepository) obj0).ConfigurationChanged += (LoggerRepositoryConfigurationChangedEventHandler) obj1;

    internal static void krPItrhdjAIAPb6gPM2R([In] object obj0, [In] object obj1) => ((ILoggerRepository) obj0).ConfigurationChanged -= (LoggerRepositoryConfigurationChangedEventHandler) obj1;
  }
}
