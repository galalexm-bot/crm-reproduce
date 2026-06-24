// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.Logger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Logging
{
  public static class Logger
  {
    private static ILogger log;
    internal static Logger nQ3LWfhl01eGXhS9XokJ;

    public static ILogger Log
    {
      get
      {
        int num1 = 2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            case 2:
              if (Logger.KGjwF3hlMhhQ1aIWW2Jy())
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
                continue;
              }
              goto label_3;
            case 3:
              goto label_3;
            case 4:
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        ILogger log;
        return log;
label_3:
        return NullLogger.Instance;
label_5:
        try
        {
          ILogger logger = Logger.log;
          int num2;
          if (logger == null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 2;
          else
            goto label_10;
label_8:
          switch (num2)
          {
            case 1:
              logger = NullLogger.Instance;
              goto label_13;
            case 2:
              logger = Logger.log = Locator.GetService<ILogger>();
              break;
            default:
              goto label_2;
          }
label_10:
          if (logger == null)
          {
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 1;
            goto label_8;
          }
label_13:
          log = logger;
          num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
          {
            num2 = 0;
            goto label_8;
          }
          else
            goto label_8;
        }
        catch
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                log = (ILogger) Logger.uwB94IhlJKw4Nj91KZMa();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
        }
      }
    }

    public static ILogger GetLogger(Type componentType) => (ILogger) new Logger.LazyInitLogger(componentType);

    public static ILogger GetLogger(string name) => (ILogger) new Logger.LazyInitLogger(name);

    private static void AddEvent(object logged)
    {
      int num1 = 1;
      IEnumerator<ILoggerEventHandler> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (Logger.lCGajkhl9hbicwvaU9wk())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            }
            goto label_13;
          case 2:
            goto label_18;
          case 3:
            goto label_6;
          default:
            enumerator = ((ComponentManager) Logger.xMAosEhldm4lyNjhfNEp()).GetExtensionPoints<ILoggerEventHandler>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 3;
            continue;
        }
      }
label_18:
      return;
label_13:
      return;
label_6:
      try
      {
label_9:
        if (Logger.QS5oSUhlrw09cK3VS9Up((object) enumerator))
          goto label_11;
        else
          goto label_10;
label_7:
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            goto label_9;
          case 2:
            goto label_11;
          default:
            return;
        }
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
        goto label_7;
label_11:
        Logger.NGB91phlls1wt9Pbqvib((object) enumerator.Current, logged);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        {
          num2 = 1;
          goto label_7;
        }
        else
          goto label_7;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                Logger.BR8nnbhlgaggZFhp5jd6((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
    }

    private static void RemoveEvent(object logged)
    {
      int num1 = 2;
      IEnumerator<ILoggerEventHandler> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_14;
          case 2:
            if (!Logger.lCGajkhl9hbicwvaU9wk())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
              continue;
            }
            break;
          case 3:
            goto label_9;
          case 4:
            goto label_3;
        }
        enumerator = ((ComponentManager) Logger.xMAosEhldm4lyNjhfNEp()).GetExtensionPoints<ILoggerEventHandler>().GetEnumerator();
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 3;
      }
label_14:
      return;
label_9:
      return;
label_3:
      try
      {
label_7:
        if (enumerator.MoveNext())
          goto label_6;
        else
          goto label_8;
label_4:
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            break;
          case 2:
            goto label_7;
          default:
            return;
        }
label_6:
        enumerator.Current.Logged -= (LogEventHandler) logged;
        num2 = 2;
        goto label_4;
label_8:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
        goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_16;
              default:
                Logger.BR8nnbhlgaggZFhp5jd6((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_16:;
      }
    }

    public static event LogEventHandler Logged
    {
      add => Logger.niviyChl5WBYF2rU34js((object) value);
      remove => Logger.SfZjdQhljbTHsdIk2kI5((object) value);
    }

    public static bool LogDllImport => true;

    internal static string GetConfigFile(string fileName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!Logger.cmQ3L0hlYsEGOPrL2s1s((object) fileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return fileName;
label_3:
      return Path.Combine((string) Logger.CnZf1ghlLAbC9jV4V7PD((object) AppDomain.CurrentDomain), fileName);
    }

    internal static bool KGjwF3hlMhhQ1aIWW2Jy() => Locator.Initialized;

    internal static object uwB94IhlJKw4Nj91KZMa() => (object) NullLogger.Instance;

    internal static bool v27mmvhlmucHsD2RCP1C() => Logger.nQ3LWfhl01eGXhS9XokJ == null;

    internal static Logger DT0Yurhly9epVsI8V067() => Logger.nQ3LWfhl01eGXhS9XokJ;

    internal static bool lCGajkhl9hbicwvaU9wk() => ComponentManager.Initialized;

    internal static object xMAosEhldm4lyNjhfNEp() => (object) ComponentManager.Current;

    internal static void NGB91phlls1wt9Pbqvib([In] object obj0, [In] object obj1) => ((ILoggerEventHandler) obj0).Logged += (LogEventHandler) obj1;

    internal static bool QS5oSUhlrw09cK3VS9Up([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void BR8nnbhlgaggZFhp5jd6([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void niviyChl5WBYF2rU34js([In] object obj0) => Logger.AddEvent(obj0);

    internal static void SfZjdQhljbTHsdIk2kI5([In] object obj0) => Logger.RemoveEvent(obj0);

    internal static bool cmQ3L0hlYsEGOPrL2s1s([In] object obj0) => Path.IsPathRooted((string) obj0);

    internal static object CnZf1ghlLAbC9jV4V7PD([In] object obj0) => (object) ((AppDomain) obj0).BaseDirectory;

    private class LazyInitLogger : ILogger
    {
      private readonly object name;
      private object logger;
      private readonly Type type;
      internal static object eTWRMyvAoCWb8YC0EO6e;

      internal LazyInitLogger(string name)
      {
        Logger.LazyInitLogger.WCgPF6vAGyibikOQfcPn();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.name = (object) name;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      internal LazyInitLogger(Type type)
      {
        Logger.LazyInitLogger.WCgPF6vAGyibikOQfcPn();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.type = type;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      private ILogger GetLogger()
      {
        int num1 = 6;
        object logger;
        while (true)
        {
          switch (num1)
          {
            case 1:
              num1 = 2;
              continue;
            case 2:
              try
              {
                ILoggerFactory service = Locator.GetService<ILoggerFactory>();
                int num2 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
                  num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                    case 8:
                      if (Logger.LazyInitLogger.Qk3ciWvAfg5NK3yDClL5(this.type, (Type) null))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 4 : 1;
                        continue;
                      }
                      break;
                    case 2:
                    case 5:
                      goto label_28;
                    case 3:
                      if (service == null)
                      {
                        num2 = 2;
                        continue;
                      }
                      goto case 6;
                    case 4:
                      this.logger = (object) service.CreateLogger(this.type);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                      continue;
                    case 6:
                      if (this.name == null)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
                        continue;
                      }
                      goto case 9;
                    case 7:
                      Logger.LazyInitLogger.DXkdZ2vAQ0hGF0SEkXZ0(this.logger, (object) new EventHandler(this.OnConfigurationChanged));
                      num2 = 5;
                      continue;
                    case 9:
                      this.logger = (object) service.CreateLogger((string) this.name);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 10 : 1;
                      continue;
                  }
                  if (this.logger != null)
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 7;
                  else
                    goto case 3;
                }
              }
              catch (Exception ex)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_28;
                    default:
                      Logger.TraceLogger.Instance.Log(LogLevel.Error, ex, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178583062), new object[2]
                      {
                        this.name,
                        (object) this.type
                      });
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
                      continue;
                  }
                }
              }
            case 3:
label_28:
              logger = this.logger;
              if (logger == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 4 : 3;
                continue;
              }
              goto label_27;
            case 4:
              goto label_30;
            case 5:
              goto label_22;
            case 6:
              if (this.logger == null)
              {
                if (Logger.LazyInitLogger.KXmNUFvAEk7P2ibPSAM5())
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
                  continue;
                }
                goto label_2;
              }
              else
              {
                num1 = 5;
                continue;
              }
            default:
              goto label_2;
          }
        }
label_2:
        return NullLogger.Instance;
label_22:
        return (ILogger) this.logger;
label_27:
        return (ILogger) logger;
label_30:
        return (ILogger) Logger.LazyInitLogger.X113davAC96oZM6Uy0dF();
      }

      private void OnConfigurationChanged(object sender, EventArgs e)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              Logger.LazyInitLogger.qHaaMPvAvIK5cWluFaTV((object) this.ConfigurationChanged, sender, (object) e);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public bool IsEnabled(LogLevel level) => Logger.LazyInitLogger.lekndovA84syfMAC54Aw((object) this.GetLogger(), level);

      public void Log(LogLevel level, Exception exception, string format, params object[] args)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.GetLogger().Log(level, exception, format, args);
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
                goto label_2;
              case 2:
                comparand = eventHandler1;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                continue;
              case 3:
                eventHandler1 = this.ConfigurationChanged;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 2;
                continue;
              case 4:
                if (eventHandler1 == comparand)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 1;
                  continue;
                }
                goto case 2;
              case 5:
                eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler2, comparand);
                num = 4;
                continue;
              default:
                eventHandler2 = (EventHandler) Logger.LazyInitLogger.zu8V0YvAZfeFwLft6jbY((object) comparand, (object) value);
                num = 5;
                continue;
            }
          }
label_2:;
        }
        remove
        {
          int num = 2;
          EventHandler comparand;
          EventHandler eventHandler1;
          EventHandler eventHandler2;
          while (true)
          {
            switch (num)
            {
              case 1:
                comparand = eventHandler2;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                continue;
              case 2:
                eventHandler2 = this.ConfigurationChanged;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 1;
                continue;
              case 3:
                goto label_2;
              case 4:
                eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler1, comparand);
                num = 5;
                continue;
              case 5:
                if (eventHandler2 == comparand)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 3 : 0;
                  continue;
                }
                goto case 1;
              default:
                eventHandler1 = (EventHandler) Logger.LazyInitLogger.lfZ5ZDvAuQU7rOarNr5K((object) comparand, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 4 : 0;
                continue;
            }
          }
label_2:;
        }
      }

      internal static void WCgPF6vAGyibikOQfcPn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool TmJ55xvAbJrLiGUC03VW() => Logger.LazyInitLogger.eTWRMyvAoCWb8YC0EO6e == null;

      internal static Logger.LazyInitLogger seaHsXvAhhvr0B0Vcj83() => (Logger.LazyInitLogger) Logger.LazyInitLogger.eTWRMyvAoCWb8YC0EO6e;

      internal static bool KXmNUFvAEk7P2ibPSAM5() => Locator.Initialized;

      internal static bool Qk3ciWvAfg5NK3yDClL5([In] Type obj0, [In] Type obj1) => obj0 != obj1;

      internal static void DXkdZ2vAQ0hGF0SEkXZ0([In] object obj0, [In] object obj1) => ((ILogger) obj0).ConfigurationChanged += (EventHandler) obj1;

      internal static object X113davAC96oZM6Uy0dF() => (object) NullLogger.Instance;

      internal static void qHaaMPvAvIK5cWluFaTV([In] object obj0, [In] object obj1, [In] object obj2) => ((Delegate) obj0).RaiseSafe(obj1, (EventArgs) obj2);

      internal static bool lekndovA84syfMAC54Aw([In] object obj0, LogLevel level) => ((ILogger) obj0).IsEnabled(level);

      internal static object zu8V0YvAZfeFwLft6jbY([In] object obj0, [In] object obj1) => (object) Delegate.Combine((Delegate) obj0, (Delegate) obj1);

      internal static object lfZ5ZDvAuQU7rOarNr5K([In] object obj0, [In] object obj1) => (object) Delegate.Remove((Delegate) obj0, (Delegate) obj1);
    }

    public class DebugLogger : ILogger
    {
      public static Logger.DebugLogger Instance;
      private static Logger.DebugLogger WCIZ1nvAIMOSeYKrqqpq;

      public bool IsEnabled(LogLevel level) => true;

      public void Log(LogLevel level, Exception exception, string format, params object[] args)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              if (args == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              Logger.DebugLogger.jVLlxMvAiXGmt5R43yrA((object) format, (object) args);
              num = 3;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_2:
        return;
label_7:;
      }

      public event EventHandler ConfigurationChanged
      {
        add
        {
          int num = 4;
          EventHandler eventHandler1;
          EventHandler comparand;
          EventHandler eventHandler2;
          while (true)
          {
            switch (num)
            {
              case 1:
                eventHandler2 = (EventHandler) Logger.DebugLogger.wClFJcvAR5luTfinnTPl((object) comparand, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 1;
                continue;
              case 2:
                eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler2, comparand);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              case 3:
                comparand = eventHandler1;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
                continue;
              case 4:
                eventHandler1 = this.ConfigurationChanged;
                num = 3;
                continue;
              case 5:
                goto label_2;
              default:
                if (eventHandler1 == comparand)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 5;
                  continue;
                }
                goto case 3;
            }
          }
label_2:;
        }
        remove
        {
          int num = 4;
          EventHandler eventHandler1;
          EventHandler comparand;
          EventHandler eventHandler2;
          while (true)
          {
            switch (num)
            {
              case 1:
                eventHandler1 = comparand - value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 5 : 5;
                continue;
              case 2:
                goto label_2;
              case 3:
                comparand = eventHandler2;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
                continue;
              case 4:
                eventHandler2 = this.ConfigurationChanged;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 3;
                continue;
              case 5:
                eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler1, comparand);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
                continue;
              default:
                if (eventHandler2 == comparand)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 2 : 2;
                  continue;
                }
                goto case 3;
            }
          }
label_2:;
        }
      }

      public DebugLogger()
      {
        Logger.DebugLogger.TLlia7vAqPhukrPN09J7();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
          num = 0;
        switch (num)
        {
        }
      }

      static DebugLogger()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              Logger.DebugLogger.TLlia7vAqPhukrPN09J7();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              Logger.DebugLogger.Instance = new Logger.DebugLogger();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static object jVLlxMvAiXGmt5R43yrA([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

      internal static bool jCuIVMvAVGCF8RT4Myhu() => Logger.DebugLogger.WCIZ1nvAIMOSeYKrqqpq == null;

      internal static Logger.DebugLogger S5L1slvASEmZcgF2CIb3() => Logger.DebugLogger.WCIZ1nvAIMOSeYKrqqpq;

      internal static object wClFJcvAR5luTfinnTPl([In] object obj0, [In] object obj1) => (object) Delegate.Combine((Delegate) obj0, (Delegate) obj1);

      internal static void TLlia7vAqPhukrPN09J7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    public class TraceLogger : ILogger
    {
      public static Logger.TraceLogger Instance;
      internal static Logger.TraceLogger NxZ2wKvAKL6bkS7GOBI8;

      public bool IsEnabled(LogLevel level) => true;

      public void Log(LogLevel level, Exception exception, string format, params object[] args)
      {
        int num = 2;
        while (true)
        {
          string str1;
          string str2;
          switch (num)
          {
            case 1:
              str2 = string.Format(format, args);
              break;
            case 2:
              if (args != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
                continue;
              }
              goto case 3;
            case 3:
              str2 = format;
              break;
            case 4:
              goto label_5;
            case 5:
              Trace.Flush();
              num = 4;
              continue;
            default:
              Logger.TraceLogger.Mbouo0vAOLgG0S8MFUjX(Logger.TraceLogger.a6Uiv1vAnuPwFySBTGOw((object) new object[6]
              {
                Logger.TraceLogger.CkojPOvAklSCx7QyLQ1K(-342626196 - 1290888215 ^ -1633205283),
                (object) level,
                Logger.TraceLogger.CkojPOvAklSCx7QyLQ1K(-342626196 - 1290888215 ^ -1633499785),
                (object) str1,
                Logger.TraceLogger.CkojPOvAklSCx7QyLQ1K(-1837662597 ^ -1837680807),
                (object) exception
              }));
              num = 5;
              continue;
          }
          str1 = str2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
        }
label_5:;
      }

      public event EventHandler ConfigurationChanged
      {
        add
        {
          int num = 1;
          while (true)
          {
            EventHandler comparand;
            EventHandler eventHandler1;
            EventHandler eventHandler2;
            switch (num)
            {
              case 1:
                eventHandler2 = this.ConfigurationChanged;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              case 3:
                eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler1, comparand);
                num = 4;
                continue;
              case 4:
                if (eventHandler2 == comparand)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 1;
                  continue;
                }
                break;
              case 5:
                eventHandler1 = (EventHandler) Logger.TraceLogger.EWU6XIvA28u6FRM37dO0((object) comparand, (object) value);
                num = 3;
                continue;
            }
            comparand = eventHandler2;
            num = 5;
          }
label_2:;
        }
        remove
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
                eventHandler2 = this.ConfigurationChanged;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                continue;
              case 2:
                eventHandler1 = (EventHandler) Logger.TraceLogger.rWwnTOvAeCtKrCZowsr7((object) comparand, (object) value);
                num = 3;
                continue;
              case 3:
                eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler1, comparand);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 4 : 2;
                continue;
              case 4:
                if (eventHandler2 == comparand)
                {
                  num = 5;
                  continue;
                }
                break;
              case 5:
                goto label_2;
            }
            comparand = eventHandler2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 2 : 0;
          }
label_2:;
        }
      }

      public TraceLogger()
      {
        Logger.TraceLogger.q9BjDivAPjfuOMJx5D6M();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      static TraceLogger()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              Logger.TraceLogger.Instance = new Logger.TraceLogger();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static object CkojPOvAklSCx7QyLQ1K(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object a6Uiv1vAnuPwFySBTGOw([In] object obj0) => (object) string.Concat((object[]) obj0);

      internal static void Mbouo0vAOLgG0S8MFUjX([In] object obj0) => Trace.WriteLine((string) obj0);

      internal static bool BTIKBfvAX2egS6eWltcp() => Logger.TraceLogger.NxZ2wKvAKL6bkS7GOBI8 == null;

      internal static Logger.TraceLogger OfhXiBvATBfCav63vFIG() => Logger.TraceLogger.NxZ2wKvAKL6bkS7GOBI8;

      internal static object EWU6XIvA28u6FRM37dO0([In] object obj0, [In] object obj1) => (object) Delegate.Combine((Delegate) obj0, (Delegate) obj1);

      internal static object rWwnTOvAeCtKrCZowsr7([In] object obj0, [In] object obj1) => (object) Delegate.Remove((Delegate) obj0, (Delegate) obj1);

      internal static void q9BjDivAPjfuOMJx5D6M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    public class ConsoleLogger : ILogger
    {
      public static Logger.ConsoleLogger Instance;
      internal static Logger.ConsoleLogger VqYmQnvA1vok7wadNpVO;

      public bool IsEnabled(LogLevel level) => true;

      public void Log(LogLevel level, Exception exception, string format, params object[] args)
      {
        int num = 2;
        while (true)
        {
          string str1;
          string str2;
          switch (num)
          {
            case 1:
              str2 = string.Format(format, args);
              break;
            case 2:
              if (args != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
                continue;
              }
              goto case 4;
            case 3:
              goto label_6;
            case 4:
              str2 = format;
              break;
            default:
              Logger.ConsoleLogger.qc26divADDjwbQlINRE7(Logger.ConsoleLogger.r3mtTfvAaSSkq0jYKoUQ((object) new object[7]
              {
                (object) DateTime.Now,
                Logger.ConsoleLogger.VMifd4vApar76f4xl2Ib(-1350312861 << 3 ^ 2082349246),
                (object) level,
                Logger.ConsoleLogger.VMifd4vApar76f4xl2Ib(-1872275253 >> 6 ^ -29240255),
                (object) str1,
                Logger.ConsoleLogger.VMifd4vApar76f4xl2Ib(-1824388195 ^ -1824374081),
                (object) exception
              }));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 3;
              continue;
          }
          str1 = str2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
        }
label_6:;
      }

      public event EventHandler ConfigurationChanged
      {
        add
        {
          int num = 5;
          EventHandler eventHandler1;
          EventHandler eventHandler2;
          EventHandler comparand;
          while (true)
          {
            switch (num)
            {
              case 1:
                eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler2, comparand);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 2;
                continue;
              case 2:
                if (eventHandler1 == comparand)
                {
                  num = 3;
                  continue;
                }
                goto case 4;
              case 3:
                goto label_2;
              case 4:
                comparand = eventHandler1;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                continue;
              case 5:
                eventHandler1 = this.ConfigurationChanged;
                num = 4;
                continue;
              default:
                eventHandler2 = comparand + value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
                continue;
            }
          }
label_2:;
        }
        remove
        {
          int num = 2;
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
                comparand = eventHandler1;
                num = 5;
                continue;
              case 2:
                eventHandler1 = this.ConfigurationChanged;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
                continue;
              case 3:
                if (eventHandler1 == comparand)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                  continue;
                }
                goto case 1;
              case 4:
                eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler2, comparand);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 3 : 3;
                continue;
              case 5:
                eventHandler2 = (EventHandler) Logger.ConsoleLogger.EeZjOQvAtWNlfDhU0J9w((object) comparand, (object) value);
                num = 4;
                continue;
              default:
                goto label_9;
            }
          }
label_2:
          return;
label_9:;
        }
      }

      public ConsoleLogger()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      static ConsoleLogger()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              Logger.ConsoleLogger.Instance = new Logger.ConsoleLogger();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 1;
              continue;
          }
        }
label_2:;
      }

      internal static object VMifd4vApar76f4xl2Ib(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object r3mtTfvAaSSkq0jYKoUQ([In] object obj0) => (object) string.Concat((object[]) obj0);

      internal static void qc26divADDjwbQlINRE7([In] object obj0) => Console.WriteLine((string) obj0);

      internal static bool X39YGgvANTeXaQZbD0Pq() => Logger.ConsoleLogger.VqYmQnvA1vok7wadNpVO == null;

      internal static Logger.ConsoleLogger Iso9cqvA33djn7DCDNCm() => Logger.ConsoleLogger.VqYmQnvA1vok7wadNpVO;

      internal static object EeZjOQvAtWNlfDhU0J9w([In] object obj0, [In] object obj1) => (object) Delegate.Remove((Delegate) obj0, (Delegate) obj1);
    }
  }
}
