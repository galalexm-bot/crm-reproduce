// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.DisposableCallContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>Контекст вызова, который очищается при Dispose</summary>
  internal sealed class DisposableCallContext : IDisposable
  {
    private readonly object oldInstance;
    private readonly string key;
    private static IContextBoundVariableService contextBoundVariableService;
    internal static DisposableCallContext yWKKkMBD1oOBxmXYrTFx;

    private static IContextBoundVariableService ContextBoundVariableService
    {
      get
      {
        int num = 1;
        IContextBoundVariableService boundVariableService;
        while (true)
        {
          switch (num)
          {
            case 1:
              boundVariableService = DisposableCallContext.contextBoundVariableService;
              if (boundVariableService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return boundVariableService;
label_5:
        return DisposableCallContext.contextBoundVariableService = Locator.GetServiceNotNull<IContextBoundVariableService>();
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="key">Ключ</param>
    /// <param name="oldInstance">Старый экземпляр</param>
    private DisposableCallContext(string key, object oldInstance)
    {
      DisposableCallContext.HPPXBaBDpWB7vbaE9mDP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.oldInstance = oldInstance;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 1;
            continue;
          default:
            this.key = key;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Создать контекст вызова</summary>
    /// <param name="key">Ключ</param>
    /// <param name="newInstance">Новый экземпляр</param>
    /// <returns>Disposable контекст вызова</returns>
    public static IDisposable Create(string key, object newInstance)
    {
      int num = 2;
      object newInstance1;
      while (true)
      {
        switch (num)
        {
          case 1:
            newInstance1 = newInstance;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return DisposableCallContext.Create<object>(key, (Func<object, object>) (_ => newInstance1));
    }

    /// <summary>Создать контекст вызова</summary>
    /// <typeparam name="T">Тип экземпляра</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="instanceFunc">Функция получения текущего экземпляра</param>
    /// <returns>Disposable контекст вызова</returns>
    public static IDisposable Create<T>(string key, Func<T, T> instanceFunc)
    {
      T oldInstance;
      DisposableCallContext.ContextBoundVariableService.TryGetValue<T>(key, out oldInstance);
      DisposableCallContext.ContextBoundVariableService.Set(key, (object) instanceFunc(oldInstance));
      return (IDisposable) new DisposableCallContext(key, (object) oldInstance);
    }

    /// <summary>Получить текущий экземпляр</summary>
    /// <typeparam name="T">Тип экземпляра</typeparam>
    /// <param name="key">Ключ</param>
    /// <returns>Текущий экземпляр</returns>
    public static T GetCurrent<T>(string key)
    {
      T current;
      DisposableCallContext.ContextBoundVariableService.TryGetValue<T>(key, out current);
      return current;
    }

    /// <summary>Создать пустой контекст вызова</summary>
    /// <returns></returns>
    public static IDisposable CreateEmptyCallContext() => (IDisposable) new DisposableCallContext.EmptyCallContext();

    /// <summary>Очистка</summary>
    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DisposableCallContext.kT6S8fBDDnwMAvr488qF(DisposableCallContext.v2EHGEBDa3v2G1oO7PSU(), (object) this.key, this.oldInstance);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool sDc8WRBDNhxVsjhIV6vN() => DisposableCallContext.yWKKkMBD1oOBxmXYrTFx == null;

    internal static DisposableCallContext jXcJmVBD3dsPV6GKl6vS() => DisposableCallContext.yWKKkMBD1oOBxmXYrTFx;

    internal static void HPPXBaBDpWB7vbaE9mDP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object v2EHGEBDa3v2G1oO7PSU() => (object) DisposableCallContext.ContextBoundVariableService;

    internal static void kT6S8fBDDnwMAvr488qF([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);

    /// <summary>Пустой контекст вызова</summary>
    private sealed class EmptyCallContext : IDisposable
    {
      internal static object C2n0hJQXErMnd1wTkSv2;

      public void Dispose()
      {
      }

      public EmptyCallContext()
      {
        DisposableCallContext.EmptyCallContext.uijutRQXC6DuBk9F5tV3();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void uijutRQXC6DuBk9F5tV3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool wGlT2HQXfSM1tQTlAXFb() => DisposableCallContext.EmptyCallContext.C2n0hJQXErMnd1wTkSv2 == null;

      internal static DisposableCallContext.EmptyCallContext JJk0j6QXQrVZ3knYDB0t() => (DisposableCallContext.EmptyCallContext) DisposableCallContext.EmptyCallContext.C2n0hJQXErMnd1wTkSv2;
    }
  }
}
