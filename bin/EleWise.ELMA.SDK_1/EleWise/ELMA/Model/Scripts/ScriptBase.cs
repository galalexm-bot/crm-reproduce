// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ScriptBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Базовый класс для модуля сценариев</summary>
  public class ScriptBase : IScriptBaseInitializer
  {
    private IScriptConsole console;
    private bool isDebug;
    internal static ScriptBase zG9etfbi6OsY27I6DRNn;

    /// <summary>Консоль для отладки</summary>
    public IScriptConsole Console => this.console;

    /// <summary>Выполняется ли сценарий для отладки</summary>
    public bool IsDebug => this.isDebug;

    void IScriptBaseInitializer.SetConsole(IScriptConsole console)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              goto label_3;
            case 3:
              if (console != null)
                break;
              goto label_6;
          }
          this.console = console;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 0;
        }
label_6:
        num1 = 2;
      }
label_4:
      return;
label_3:;
    }

    void IScriptBaseInitializer.SetIsDebug(bool isDebug)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.isDebug = isDebug;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    [Obsolete]
    protected ScriptBase.LoggerClass get_Logger() => ScriptBase.LoggerClass.Instance;

    public ScriptBase()
    {
      ScriptBase.CA3w8Sbi7UHs10u8EmTo();
      this.console = (IScriptConsole) new ScriptConsoleStub();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool I53Au7biHu8vwH9Md3mt() => ScriptBase.zG9etfbi6OsY27I6DRNn == null;

    internal static ScriptBase LbFaFWbiAGbtSMSMcoyD() => ScriptBase.zG9etfbi6OsY27I6DRNn;

    internal static void CA3w8Sbi7UHs10u8EmTo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    protected static class Logger
    {
      public static ILogger Log => (ILogger) ScriptBase.Logger.tRi2rhC1RE6DBqff9hmO();

      internal static object tRi2rhC1RE6DBqff9hmO() => (object) ScriptLogger.Log;
    }

    [Obsolete]
    public class LoggerClass
    {
      internal static readonly ScriptBase.LoggerClass Instance;
      internal static ScriptBase.LoggerClass YG58IkC1qA6U1yqhXAIS;

      public ILogger Log => (ILogger) ScriptBase.LoggerClass.c98jx6C1TgyVKrn0opQ0();

      public LoggerClass()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
          num = 0;
        switch (num)
        {
        }
      }

      static LoggerClass()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              ScriptBase.LoggerClass.MtHNFAC1kcd9JcpDj4Jc();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              ScriptBase.LoggerClass.Instance = new ScriptBase.LoggerClass();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static object c98jx6C1TgyVKrn0opQ0() => (object) ScriptLogger.Log;

      internal static bool l0evO7C1KMFIQhRkr3vU() => ScriptBase.LoggerClass.YG58IkC1qA6U1yqhXAIS == null;

      internal static ScriptBase.LoggerClass R2gvE4C1XvNJeAX8MHu5() => ScriptBase.LoggerClass.YG58IkC1qA6U1yqhXAIS;

      internal static void MtHNFAC1kcd9JcpDj4Jc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
