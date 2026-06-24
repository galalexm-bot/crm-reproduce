// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.BackgroundTask
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Threading
{
  /// <summary>Фоновая задача</summary>
  public class BackgroundTask
  {
    private readonly System.Action action;
    private readonly Type ownerType;
    private readonly string name;
    private readonly string description;
    private readonly bool useCallSessionOwner;
    private readonly bool handleExceptions;
    private static BackgroundTask nflL6bBiJ5DPLd6fS1Km;

    /// <summary>Ctor</summary>
    /// <param name="action">Действие выполняемое в рамках задачи</param>
    /// <param name="ownerType">Тип владельца</param>
    /// <param name="name">Название</param>
    /// <param name="description">Описание</param>
    /// <param name="useCallSessionOwner">Использовать сессию вызова владельца</param>
    /// <param name="handleExceptions">Перехватывать исключения</param>
    public BackgroundTask(
      System.Action action,
      Type ownerType,
      string name,
      string description,
      bool useCallSessionOwner = true,
      bool handleExceptions = true)
    {
      BackgroundTask.IjRXKaBil8DVLLNNVDIh();
      // ISSUE: explicit constructor call
      this.\u002Ector(ownerType, name, description, useCallSessionOwner, handleExceptions);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (action == null)
            {
              num = 2;
              continue;
            }
            this.action = action;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:
      return;
label_6:
      throw new ArgumentNullException((string) BackgroundTask.xpP9flBirW5vOPgri2IK(1574260816 ^ 1574193572));
    }

    /// <summary>Protected ctor</summary>
    /// <param name="ownerType">Тип владельца</param>
    /// <param name="name">Название</param>
    /// <param name="description">Описание</param>
    /// <param name="useCallSessionOwner">Использовать сессию вызова владельца</param>
    /// <param name="handleExceptions">Перехватывать исключения</param>
    protected BackgroundTask(
      Type ownerType,
      string name,
      string description,
      bool useCallSessionOwner = true,
      bool handleExceptions = true)
    {
      BackgroundTask.IjRXKaBil8DVLLNNVDIh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ownerType = ownerType;
            num = 5;
            continue;
          case 2:
            this.useCallSessionOwner = useCallSessionOwner;
            num = 4;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.handleExceptions = handleExceptions;
            num = 3;
            continue;
          case 5:
            this.name = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          default:
            this.description = description;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Выполнить задачу</summary>
    public void Execute()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            DiagnosticsManager.Instance.BackgroundTaskStart(this.name, this.ownerType, this.description);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_32;
          default:
            goto label_2;
        }
      }
label_32:
      return;
label_2:
      try
      {
        int num2;
        if (this.useCallSessionOwner)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
        else
          goto label_17;
label_5:
        CallContextSessionOwner contextSessionOwner;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
                BackgroundTask.OxoWGWBi5LeeoiUyIvpR((object) this);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_16;
                }
              }
              finally
              {
                int num4;
                if (contextSessionOwner == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
                else
                  goto label_13;
label_11:
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                    case 2:
                      goto label_15;
                    case 3:
                      goto label_13;
                    default:
                      contextSessionOwner = (CallContextSessionOwner) null;
                      num4 = 2;
                      continue;
                  }
                }
label_15:
label_13:
                contextSessionOwner.Dispose();
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                {
                  num4 = 0;
                  goto label_11;
                }
                else
                  goto label_11;
              }
            case 2:
              goto label_17;
            case 3:
label_16:
              ((DiagnosticsManager) BackgroundTask.GYuRIZBijuugk3oNhFbt()).BackgroundTaskEnd();
              num2 = 4;
              continue;
            case 4:
              goto label_25;
            default:
              goto label_18;
          }
        }
label_25:
        return;
label_18:
        object obj = BackgroundTask.WyKHenBigkWNlkFDyo3k();
        goto label_19;
label_17:
        obj = (object) null;
label_19:
        contextSessionOwner = (CallContextSessionOwner) obj;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        {
          num2 = 1;
          goto label_5;
        }
        else
          goto label_5;
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_26;
            case 2:
              if (this.handleExceptions)
              {
                this.ExecutionException = ex;
                num5 = 3;
                continue;
              }
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_21;
            case 4:
              ((DiagnosticsManager) BackgroundTask.GYuRIZBijuugk3oNhFbt()).BackgroundTaskError(ex);
              num5 = 2;
              continue;
            default:
              Logger.Log.Error(BackgroundTask.YkSBO7BiY5XQyPE0GWOR(BackgroundTask.xpP9flBirW5vOPgri2IK(589593376 ^ -1977315327 ^ -1459490331), (object) this.description), ex);
              num5 = 4;
              continue;
          }
        }
label_21:
        return;
label_26:
        throw;
      }
    }

    /// <summary>Исключение, возникшее при исполнении задачи</summary>
    public Exception ExecutionException
    {
      get => this.\u003CExecutionException\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CExecutionException\u003Ek__BackingField = value;
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
    }

    /// <summary>Выполнить делегат пользователя.</summary>
    protected virtual void ExecuteUserDelegate()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            BackgroundTask.pp7ZbrBiLZAwdAtH54hI((object) this.action);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void IjRXKaBil8DVLLNNVDIh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object xpP9flBirW5vOPgri2IK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool gpNlO7Bi96Snfq0yMj0V() => BackgroundTask.nflL6bBiJ5DPLd6fS1Km == null;

    internal static BackgroundTask WVba9WBidYvCIZr6raFv() => BackgroundTask.nflL6bBiJ5DPLd6fS1Km;

    internal static object WyKHenBigkWNlkFDyo3k() => (object) CallContextSessionOwner.Create();

    internal static void OxoWGWBi5LeeoiUyIvpR([In] object obj0) => ((BackgroundTask) obj0).ExecuteUserDelegate();

    internal static object GYuRIZBijuugk3oNhFbt() => (object) DiagnosticsManager.Instance;

    internal static object YkSBO7BiY5XQyPE0GWOR([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void pp7ZbrBiLZAwdAtH54hI([In] object obj0) => ((System.Action) obj0)();
  }
}
