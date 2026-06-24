// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.BackgroundOperations.BaseBackgroundOperationWithCallbacks
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.BackgroundOperations
{
  /// <summary>
  /// Базовый класс-держатель информации по запуску фоновой операции с поддержкой делегатов обратного вызова как при успешном, так и при неудачном завершении.
  /// </summary>
  [Serializable]
  public abstract class BaseBackgroundOperationWithCallbacks : 
    IBackgroundOperation,
    ISuccessCallbackInvokable,
    IErrorCallbackInvokable
  {
    private static BaseBackgroundOperationWithCallbacks Ircp7XWcq5E2JG9EUGHF;

    /// <summary>Ctor</summary>
    public BaseBackgroundOperationWithCallbacks()
    {
      BaseBackgroundOperationWithCallbacks.OewIMRWcTyhRsUIcPXOM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.ErrorCallback = (ICallbackDelegate) new CallbackDelegate();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
            continue;
          default:
            this.SuccessCallback = (ICallbackDelegate) new CallbackDelegate();
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Информация о делегате, который будет вызван при успешном завершении фоновой задачи.
    /// </summary>
    public ICallbackDelegate SuccessCallback
    {
      get => this.\u003CSuccessCallback\u003Ek__BackingField;
      protected set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSuccessCallback\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Информация о делегате, который будет вызван при неудачном завершении фоновой задачи.
    /// </summary>
    public ICallbackDelegate ErrorCallback
    {
      get => this.\u003CErrorCallback\u003Ek__BackingField;
      protected set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CErrorCallback\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void OewIMRWcTyhRsUIcPXOM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool G8w0xCWcK73XJlhRkaua() => BaseBackgroundOperationWithCallbacks.Ircp7XWcq5E2JG9EUGHF == null;

    internal static BaseBackgroundOperationWithCallbacks tUJF09WcXWax2xcjIFLx() => BaseBackgroundOperationWithCallbacks.Ircp7XWcq5E2JG9EUGHF;
  }
}
