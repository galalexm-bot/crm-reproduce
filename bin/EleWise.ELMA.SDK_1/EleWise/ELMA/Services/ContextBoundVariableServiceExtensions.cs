// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ContextBoundVariableServiceExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Modules;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Runtime.Context;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>Расширение для IContextBoundVariableService</summary>
  public static class ContextBoundVariableServiceExtensions
  {
    internal static ContextBoundVariableServiceExtensions ESKa0LBthgwlRTpeoFrp;

    /// <summary>
    /// Получить значение из сервиса, или установить если ничего не найдено
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="name">Ключ</param>
    /// <param name="factory">Функция получения значения, если ничего не найдено</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>contextObjects</c>,<c>name</c>,<c>factory</c> равно <c>null</c></exception>
    /// <returns>Значение переменной</returns>
    public static T GetOrAdd<T>(
      [NotNull] this IContextBoundVariableService contextBoundVariableService,
      [NotNull] string name,
      [NotNull] Func<T> factory)
    {
      return IAbstractBoundVariableServiceExtensions.GetOrAdd<T>(contextBoundVariableService, name, factory);
    }

    /// <summary>
    /// Очистить контекстный кэш для метода <paramref name="func" />
    /// </summary>
    /// <typeparam name="TResult">Тип возвращаемого параметра</typeparam>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="func">Метод</param>
    public static void ClearFor<TResult>(
      this IContextBoundVariableService contextBoundVariableService,
      Func<TResult> func)
    {
      contextBoundVariableService.ClearFor(func.Method);
    }

    /// <summary>
    /// Очистить контекстный кэш для метода <paramref name="func" />
    /// </summary>
    /// <typeparam name="T">Тип параметра</typeparam>
    /// <typeparam name="TResult">Тип возвращаемого параметра</typeparam>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="func">Метод</param>
    public static void ClearFor<T, TResult>(
      this IContextBoundVariableService contextBoundVariableService,
      Func<T, TResult> func)
    {
      contextBoundVariableService.ClearFor(func.Method);
    }

    /// <summary>
    /// Очистить контекстный кэш для метода <paramref name="func" />
    /// </summary>
    /// <typeparam name="T1">Тип параметра 1</typeparam>
    /// <typeparam name="T2">Тип параметра 2</typeparam>
    /// <typeparam name="TResult">Тип возвращаемого параметра</typeparam>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="func">Метод</param>
    public static void ClearFor<T1, T2, TResult>(
      this IContextBoundVariableService contextBoundVariableService,
      Func<T1, T2, TResult> func)
    {
      contextBoundVariableService.ClearFor(func.Method);
    }

    /// <summary>
    /// Очистить контекстный кэш для метода <paramref name="func" />
    /// </summary>
    /// <typeparam name="T1">Тип параметра 1</typeparam>
    /// <typeparam name="T2">Тип параметра 2</typeparam>
    /// <typeparam name="T3">Тип параметра 3</typeparam>
    /// <typeparam name="TResult">Тип возвращаемого параметра</typeparam>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="func">Метод</param>
    public static void ClearFor<T1, T2, T3, TResult>(
      this IContextBoundVariableService contextBoundVariableService,
      Func<T1, T2, T3, TResult> func)
    {
      contextBoundVariableService.ClearFor(func.Method);
    }

    /// <summary>
    /// Очистить контекстный кэш для метода <paramref name="method" />
    /// </summary>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="method">Метод</param>
    public static void ClearFor(
      this IContextBoundVariableService contextBoundVariableService,
      MethodInfo method)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ContextBoundVariableServiceExtensions.zpJAtYBtQ5Gcg8In3Ld3((object) contextBoundVariableService, ContextBoundVariableServiceExtensions.uonObpBtfI1dc98aALr1((object) method));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Очистить регион <paramref name="region" /> в контекстном кэше
    /// </summary>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="region">Регион</param>
    public static void ClearRegion(
      this IContextBoundVariableService contextBoundVariableService,
      string region)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ContextBoundVariableServiceExtensions.hf9Bp5BtCDVZe4MUsIv6((object) contextBoundVariableService, (object) region);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Установить значение <paramref name="value" /> в регион <paramref name="region" /> контекстного кэша по ключу <paramref name="key" />
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="key">Ключ</param>
    /// <param name="region">Регион</param>
    /// <param name="value">Значение</param>
    public static void Set<T>(
      this IContextBoundVariableService contextBoundVariableService,
      string key,
      string region,
      T value)
    {
      ContextCacheInterceptor.Set(contextBoundVariableService, key, region, (object) value);
    }

    /// <summary>
    /// Попытаться получить значение <paramref name="result" /> из региона <paramref name="region" /> контекстного кэша по ключу <paramref name="key" />
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="key">Ключ</param>
    /// <param name="region">Регион</param>
    /// <param name="result">Полученное значение (или значение по умолчанию для типа <typeparamref name="T" />, если элемент не найден)</param>
    /// <returns>True, если значение найденл</returns>
    public static bool TryGetValue<T>(
      this IContextBoundVariableService contextBoundVariableService,
      string key,
      string region,
      out T result)
    {
      object result1;
      if (ContextCacheInterceptor.TryGetValue(contextBoundVariableService, key, region, out result1))
      {
        result = (T) result1;
        return true;
      }
      result = default (T);
      return false;
    }

    /// <summary>
    /// Содержится ли значение в регионе <paramref name="region" /> контекстного кэша по ключу <paramref name="key" />
    /// </summary>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="key">Ключ</param>
    /// <param name="region">Регион</param>
    /// <returns>True, если содержится</returns>
    public static bool Contains(
      this IContextBoundVariableService contextBoundVariableService,
      string key,
      string region)
    {
      return ContextCacheInterceptor.TryGetValue(contextBoundVariableService, key, region, out object _);
    }

    /// <summary>
    /// Удалить значение в регионе <paramref name="region" /> контекстного кэша по ключу <paramref name="key" />
    /// </summary>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="key">Ключ</param>
    /// <param name="region">Регион</param>
    public static void Remove(
      this IContextBoundVariableService contextBoundVariableService,
      string key,
      string region)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ContextBoundVariableServiceExtensions.Xqjq5sBtvMESq3m46vsi((object) contextBoundVariableService, (object) key, (object) region);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Получить значение в регионе <paramref name="region" /> контекстного кэша по ключу <paramref name="key" />
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="key">Ключ</param>
    /// <param name="region">Регион</param>
    /// <exception cref="T:EleWise.ELMA.Exceptions.VariableNotFoundException">Исключение "Переменная не найдена"</exception>
    /// <returns>Значение</returns>
    public static T Get<T>(
      this IContextBoundVariableService contextBoundVariableService,
      string key,
      string region)
    {
      T result;
      if (!contextBoundVariableService.TryGetValue<T>(key, region, out result))
        throw new VariableNotFoundException(region + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886624293) + key);
      return result;
    }

    /// <summary>Очитстить контекстный кэш</summary>
    /// <param name="contextBoundVariableService">Контекст</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void ClearCache(
      this IContextBoundVariableService contextBoundVariableService)
    {
      ContextBoundVariableServiceExtensions.jK8ROFBt82xy4b8sudd4((object) contextBoundVariableService);
    }

    internal static object uonObpBtfI1dc98aALr1([In] object obj0) => (object) ((MethodInfo) obj0).GetCacheRegion();

    internal static void zpJAtYBtQ5Gcg8In3Ld3([In] object obj0, [In] object obj1) => ((IContextBoundVariableService) obj0).ClearRegion((string) obj1);

    internal static bool v9fppLBtGwTfGFSqLtfJ() => ContextBoundVariableServiceExtensions.ESKa0LBthgwlRTpeoFrp == null;

    internal static ContextBoundVariableServiceExtensions g0qQVBBtEAmHuNK0TlXc() => ContextBoundVariableServiceExtensions.ESKa0LBthgwlRTpeoFrp;

    internal static void hf9Bp5BtCDVZe4MUsIv6([In] object obj0, [In] object obj1) => ContextCacheInterceptor.ClearRegion((IContextBoundVariableService) obj0, (string) obj1);

    internal static void Xqjq5sBtvMESq3m46vsi([In] object obj0, [In] object obj1, [In] object obj2) => ContextCacheInterceptor.Remove((IContextBoundVariableService) obj0, (string) obj1, (string) obj2);

    internal static void jK8ROFBt82xy4b8sudd4([In] object obj0) => ContextCacheInterceptor.Clear((IContextBoundVariableService) obj0);
  }
}
