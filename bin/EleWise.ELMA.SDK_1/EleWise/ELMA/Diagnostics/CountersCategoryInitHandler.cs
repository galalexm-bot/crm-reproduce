// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.CountersCategoryInitHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>
  /// Проверка и создание категорий и счётчиков производительности
  /// </summary>
  [Component(Type = ComponentType.Server)]
  internal sealed class CountersCategoryInitHandler : IInitHandler
  {
    private readonly IPerformanceCategoryRegistrar registrar;
    internal static CountersCategoryInitHandler TggPjTGzuGVqYywLoJdU;

    /// <summary>Ctor</summary>
    /// <param name="registrar">Регистратор категорий и счетчиков производительности</param>
    public CountersCategoryInitHandler(IPerformanceCategoryRegistrar registrar)
    {
      CountersCategoryInitHandler.ocwEEUGzSNA3o6Dg87No();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.registrar = registrar;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public void Init()
    {
      switch (1)
      {
        case 1:
          try
          {
            CountersCategoryInitHandler.W2fiprGzRtMLG36Lv3Zh(CountersCategoryInitHandler.vPZTkmGzifFCN2AEGIhe((object) this.registrar));
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
          catch
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
      }
    }

    /// <inheritdoc />
    public void InitComplete()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            ThreadStarter.StartNewThread(new ThreadStart(this.StartCheck), (Action<Thread>) (t =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    CountersCategoryInitHandler.\u003C\u003Ec.PpSYU38VnU1ViUK1Evh7((object) t, true);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_2;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    CountersCategoryInitHandler.\u003C\u003Ec.TaY5pD8V2ugsjp4QwuLp((object) t, CountersCategoryInitHandler.\u003C\u003Ec.jpQwkQ8VOnsxye8A0QM7(-1886646897 ^ -1886793511));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 2;
                    continue;
                }
              }
label_2:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Выполнить проверку и регистрацию категорий</summary>
    private void StartCheck()
    {
      switch (1)
      {
        case 1:
          try
          {
            this.registrar.CheckRegisterDefault();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
          catch
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
      }
    }

    internal static void ocwEEUGzSNA3o6Dg87No() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Cb3xgYGzItx3T9u0gT4B() => CountersCategoryInitHandler.TggPjTGzuGVqYywLoJdU == null;

    internal static CountersCategoryInitHandler mJwE1jGzVWiH4nQtDE8w() => CountersCategoryInitHandler.TggPjTGzuGVqYywLoJdU;

    internal static object vPZTkmGzifFCN2AEGIhe([In] object obj0) => (object) ((IPerformanceCategoryRegistrar) obj0).GetMissingCountersFileName();

    internal static void W2fiprGzRtMLG36Lv3Zh([In] object obj0) => File.Delete((string) obj0);
  }
}
