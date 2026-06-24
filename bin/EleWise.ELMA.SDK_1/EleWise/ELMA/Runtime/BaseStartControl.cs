// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.BaseStartControl
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime
{
  /// <summary>Базовый компонент для управления запуском сервера</summary>
  public abstract class BaseStartControl : IStartControl
  {
    internal static BaseStartControl niQxpIWWGdfffq5XwxIc;

    /// <summary>Продолжить запуск сервера</summary>
    public abstract void Continue();

    /// <summary>Приостановить запуск сервера</summary>
    /// <param name="suspendReason">Код причины приостановки запуска сервера</param>
    public virtual void Suspend(StartStatus suspendReason)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Suspend(suspendReason, string.Empty);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Приостановить запуск сервера</summary>
    /// <param name="suspendReason">Код причины приостановки запуска сервера</param>
    /// <param name="suspendMessage">Сообщение, поясняющее причину приостановки</param>
    public abstract void Suspend(StartStatus suspendReason, string suspendMessage);

    protected BaseStartControl()
    {
      BaseStartControl.fdeGUTWWQmk8EpEeQgxO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DuSOpdWWEmT7GAF3uJBQ() => BaseStartControl.niQxpIWWGdfffq5XwxIc == null;

    internal static BaseStartControl CuQDcQWWf3jM1KRoUUOE() => BaseStartControl.niQxpIWWGdfffq5XwxIc;

    internal static void fdeGUTWWQmk8EpEeQgxO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
