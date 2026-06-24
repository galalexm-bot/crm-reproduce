// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.NullLogger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Logging
{
  /// <summary>Пустой логгер</summary>
  public class NullLogger : ILogger
  {
    [NotNull]
    private static volatile ILogger instance;
    internal static NullLogger qgZlsmhlpsr84XurRORn;

    /// <summary>Установить реализацию для пустого логгера</summary>
    /// <param name="impl">Реализация логгера</param>
    internal static void SetupImpl(ILogger impl)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_5;
          case 2:
            if (impl == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
              continue;
            }
            NullLogger.instance = impl;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_5:
      throw new ArgumentNullException((string) NullLogger.h8HnIkhltqN899YHGfEl(-1852837372 ^ -1853027924));
    }

    /// <summary>Экземпляр</summary>
    [NotNull]
    public static ILogger Instance => NullLogger.instance;

    public bool IsEnabled(LogLevel level) => false;

    public void Log(LogLevel level, Exception exception, string format, params object[] args)
    {
    }

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
              eventHandler2 = this.ConfigurationChanged;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            case 2:
              eventHandler1 = comparand + value;
              num = 4;
              continue;
            case 3:
              goto label_2;
            case 4:
              eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler1, comparand);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 5 : 2;
              continue;
            case 5:
              if (eventHandler2 == comparand)
              {
                num = 3;
                continue;
              }
              break;
          }
          comparand = eventHandler2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 2;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
              continue;
            case 3:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler2, comparand);
              num = 4;
              continue;
            case 4:
              if (eventHandler1 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 5:
              eventHandler2 = (EventHandler) NullLogger.udA0WDhlwRUcHtJB90Fv((object) comparand, (object) value);
              num = 3;
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

    public NullLogger()
    {
      NullLogger.rgaPwkhl4LM8QC7XGAC2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static NullLogger()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            NullLogger.rgaPwkhl4LM8QC7XGAC2();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            NullLogger.instance = (ILogger) new NullLogger();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object h8HnIkhltqN899YHGfEl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool yET7Alhlaj3RKrviLjGc() => NullLogger.qgZlsmhlpsr84XurRORn == null;

    internal static NullLogger p6Fo6BhlDggx0GuMIXs3() => NullLogger.qgZlsmhlpsr84XurRORn;

    internal static object udA0WDhlwRUcHtJB90Fv([In] object obj0, [In] object obj1) => (object) Delegate.Remove((Delegate) obj0, (Delegate) obj1);

    internal static void rgaPwkhl4LM8QC7XGAC2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
