// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.CacheExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache.Modules;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Cache
{
  /// <summary>Получение, либо занесение данных в кэш.</summary>
  public static class CacheExtensions
  {
    private static CacheExtensions qlS8w0fqSxDmmqb0nLXP;

    public static T GetOrAdd<T>(this IMemoryCacheService cache, string key, Func<T> factory)
    {
      T result;
      if (!cache.TryGetValue<T>(key, out result))
      {
        result = factory();
        cache.Insert<T>(key, result);
      }
      return result;
    }

    public static T GetOrAdd<T>(
      this IMemoryCacheService cache,
      string key,
      Func<T> factory,
      TimeSpan cacheDuration)
    {
      T result;
      if (!cache.TryGetValue<T>(key, out result))
      {
        result = factory();
        cache.Insert<T>(key, result, cacheDuration);
      }
      return result;
    }

    public static T GetOrAdd<T>(this ICacheService cache, string key, Func<T> factory)
    {
      T orAdd;
      if (!cache.TryGetValue<T>(key, out orAdd))
      {
        orAdd = factory();
        cache.Insert<T>(key, orAdd);
      }
      return orAdd;
    }

    public static T GetOrAdd<T>(
      this ICacheService cache,
      string key,
      Func<T> factory,
      TimeSpan cacheDuration)
    {
      T orAdd;
      if (!cache.TryGetValue<T>(key, out orAdd))
      {
        orAdd = factory();
        cache.Insert<T>(key, orAdd, cacheDuration);
      }
      return orAdd;
    }

    public static T GetOrAdd<T>(
      this ICacheService cache,
      string key,
      Func<T> factory,
      string region)
    {
      T orAdd;
      if (!cache.TryGetValue<T>(key, region, out orAdd))
      {
        orAdd = factory();
        cache.Insert<T>(key, orAdd, region);
      }
      return orAdd;
    }

    public static T GetOrAdd<T>(
      this ICacheService cache,
      string key,
      Func<T> factory,
      string region,
      TimeSpan cacheDuration)
    {
      T orAdd;
      if (!cache.TryGetValue<T>(key, region, out orAdd))
      {
        orAdd = factory();
        cache.Insert<T>(key, orAdd, region, cacheDuration);
      }
      return orAdd;
    }

    /// <summary>
    /// Очистить кэш для значения функции <paramref name="func" />
    /// </summary>
    /// <typeparam name="TResult">Тип возращаемого значения</typeparam>
    /// <param name="cacheService">Кэш</param>
    /// <param name="func">Функция</param>
    public static void ClearFor<TResult>(this ICacheService cacheService, Func<TResult> func) => cacheService.ClearFor(func.Method);

    /// <summary>
    /// Очистить кэш для значения функции <paramref name="func" />
    /// </summary>
    /// <typeparam name="T">Тип параметра</typeparam>
    /// <typeparam name="TResult">Тип возращаемого значения</typeparam>
    /// <param name="cacheService">Кэш</param>
    /// <param name="func">Функция</param>
    public static void ClearFor<T, TResult>(this ICacheService cacheService, Func<T, TResult> func) => cacheService.ClearFor(func.Method);

    /// <summary>
    /// Очистить кэш для значения функции <paramref name="func" />
    /// </summary>
    /// <typeparam name="T1">Тип параметра 1</typeparam>
    /// <typeparam name="T2">Тип параметра 2</typeparam>
    /// <typeparam name="TResult">Тип возращаемого значения</typeparam>
    /// <param name="cacheService">Кэш</param>
    /// <param name="func">Функция</param>
    public static void ClearFor<T1, T2, TResult>(
      this ICacheService cacheService,
      Func<T1, T2, TResult> func)
    {
      cacheService.ClearFor(func.Method);
    }

    /// <summary>
    /// Очистить кэш для значения функции <paramref name="func" />
    /// </summary>
    /// <typeparam name="T1">Тип параметра 1</typeparam>
    /// <typeparam name="T2">Тип параметра 2</typeparam>
    /// <typeparam name="T3">Тип параметра 3</typeparam>
    /// <typeparam name="TResult">Тип возращаемого значения</typeparam>
    /// <param name="cacheService">Кэш</param>
    /// <param name="func">Функция</param>
    public static void ClearFor<T1, T2, T3, TResult>(
      this ICacheService cacheService,
      Func<T1, T2, T3, TResult> func)
    {
      cacheService.ClearFor(func.Method);
    }

    /// <summary>
    /// Очистить кэш для значения функции <paramref name="method" />
    /// </summary>
    /// <param name="cacheService">Кэш</param>
    /// <param name="method">Функция</param>
    public static void ClearFor(this ICacheService cacheService, MethodInfo method)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CacheInterceptor.ClearRegion(cacheService, method.GetCacheRegion());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
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
    /// Очистить кэш для значения функции <paramref name="func" />
    /// </summary>
    /// <typeparam name="TResult">Тип возращаемого значения</typeparam>
    /// <param name="complexCacheService">Кэш</param>
    /// <param name="func">Функция</param>
    public static void ClearFor<TResult>(
      this IComplexCacheService complexCacheService,
      Func<TResult> func)
    {
      complexCacheService.ClearFor(func.Method);
    }

    /// <summary>
    /// Очистить кэш для значения функции <paramref name="func" />
    /// </summary>
    /// <typeparam name="T">Тип параметра</typeparam>
    /// <typeparam name="TResult">Тип возращаемого значения</typeparam>
    /// <param name="complexCacheService">Кэш</param>
    /// <param name="func">Функция</param>
    public static void ClearFor<T, TResult>(
      this IComplexCacheService complexCacheService,
      Func<T, TResult> func)
    {
      complexCacheService.ClearFor(func.Method);
    }

    /// <summary>
    /// Очистить кэш для значения функции <paramref name="func" />
    /// </summary>
    /// <typeparam name="T1">Тип параметра 1</typeparam>
    /// <typeparam name="T2">Тип параметра 2</typeparam>
    /// <typeparam name="TResult">Тип возращаемого значения</typeparam>
    /// <param name="complexCacheService">Кэш</param>
    /// <param name="func">Функция</param>
    public static void ClearFor<T1, T2, TResult>(
      this IComplexCacheService complexCacheService,
      Func<T1, T2, TResult> func)
    {
      complexCacheService.ClearFor(func.Method);
    }

    /// <summary>
    /// Очистить кэш для значения функции <paramref name="func" />
    /// </summary>
    /// <typeparam name="T1">Тип параметра 1</typeparam>
    /// <typeparam name="T2">Тип параметра 2</typeparam>
    /// <typeparam name="T3">Тип параметра 3</typeparam>
    /// <typeparam name="TResult">Тип возращаемого значения</typeparam>
    /// <param name="complexCacheService">Кэш</param>
    /// <param name="func">Функция</param>
    public static void ClearFor<T1, T2, T3, TResult>(
      this IComplexCacheService complexCacheService,
      Func<T1, T2, T3, TResult> func)
    {
      complexCacheService.ClearFor(func.Method);
    }

    /// <summary>
    /// Очистить кэш для значения функции <paramref name="method" />
    /// </summary>
    /// <param name="complexCacheService">Кэш</param>
    /// <param name="method">Функция</param>
    public static void ClearFor(this IComplexCacheService complexCacheService, MethodInfo method)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CacheExtensions.U1G1oCfqKct4nd3IKXMV((object) complexCacheService, CacheExtensions.EAEr5ufqqIdk9YkdZTCM((object) method));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Вычислить регион кэша для метода</summary>
    /// <param name="method">Метод</param>
    /// <returns>Регион кэша для метода</returns>
    internal static string GetCacheRegion(this MethodInfo method) => (string) CacheExtensions.RX205vfqXdlhGX8uEuvB((object) method, method.DeclaringType);

    /// <summary>Вычислить регион кэша для метода в типе</summary>
    /// <param name="method">Метод</param>
    /// <param name="targetType">Тип для метода</param>
    /// <returns>Регион кэша для метода</returns>
    internal static string GetCacheRegion(this MethodInfo method, Type targetType)
    {
      int num1 = 4;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        int index;
        ParameterInfo[] parameterInfoArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, CacheExtensions.SyoNBWfqTOL07IHxfY3E(1461625753 ^ 1461643963));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 4 : 8;
              continue;
            case 3:
              CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, CacheExtensions.SyoNBWfqTOL07IHxfY3E(-1598106783 - -968262081 ^ -630188310));
              num2 = 12;
              continue;
            case 4:
              stringBuilder = new StringBuilder();
              num2 = 3;
              continue;
            case 5:
              if (index < parameterInfoArray.Length - 1)
                goto case 10;
              else
                goto label_21;
            case 6:
              stringBuilder.Append((string) CacheExtensions.SyoNBWfqTOL07IHxfY3E(1461625753 ^ 1461632047));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 5 : 14;
              continue;
            case 7:
            case 19:
              if (index < parameterInfoArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 17 : 4;
                continue;
              }
              goto case 15;
            case 8:
              CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, (object) parameterInfoArray[index].Name);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 5;
              continue;
            case 9:
              CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319459576));
              num2 = 18;
              continue;
            case 10:
              CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, CacheExtensions.SyoNBWfqTOL07IHxfY3E(-1317790512 ^ -1317779444));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 16 : 4;
              continue;
            case 11:
            case 16:
              ++index;
              num2 = 7;
              continue;
            case 12:
              stringBuilder.Append((object) targetType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 9;
              continue;
            case 13:
            case 17:
              goto label_8;
            case 14:
              parameterInfoArray = (ParameterInfo[]) CacheExtensions.iBsfDGfqOP5h0Ou3pBHU((object) method);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 15:
              CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, CacheExtensions.SyoNBWfqTOL07IHxfY3E(1113862659 ^ 1113861567));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
              continue;
            case 18:
              stringBuilder.Append((string) CacheExtensions.gWqPvvfqnNhKERDVarVN((object) method));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 6 : 2;
              continue;
            default:
              index = 0;
              num2 = 19;
              continue;
          }
        }
label_8:
        CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, (object) CacheExtensions.sKhZBNfq2MCOKOOEWhy2((object) parameterInfoArray[index]).FullName);
        num1 = 2;
        continue;
label_21:
        num1 = 11;
      }
label_7:
      return stringBuilder.ToString();
    }

    /// <summary>Вычислить ключ кэша для метода с аргументами в типе</summary>
    /// <param name="method">Метод</param>
    /// <param name="targetType">Тип для метода</param>
    /// <param name="arguments">Аргументы метода</param>
    /// <returns>Ключ кэша для метода</returns>
    internal static string GetCacheKey(this MethodInfo method, Type targetType, object[] arguments)
    {
      int num = 11;
      StringBuilder stringBuilder;
      while (true)
      {
        int index;
        ParameterInfo[] parameters;
        object obj;
        switch (num)
        {
          case 1:
            CacheExtensions.oXNQLpfqeDFoPb3D26W3((object) stringBuilder, (object) targetType);
            num = 8;
            continue;
          case 2:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 13 : 2;
            continue;
          case 3:
            CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, CacheExtensions.gWqPvvfqnNhKERDVarVN((object) method));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 9 : 3;
            continue;
          case 4:
            CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, CacheExtensions.SyoNBWfqTOL07IHxfY3E(901793403 ^ 901846841));
            num = 17;
            continue;
          case 5:
            goto label_7;
          case 6:
            stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901780135));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 12 : 4;
            continue;
          case 7:
            CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35987857));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 5 : 1;
            continue;
          case 8:
            stringBuilder.Append((string) CacheExtensions.SyoNBWfqTOL07IHxfY3E(372753449 ^ 372760301));
            num = 3;
            continue;
          case 9:
            CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, CacheExtensions.SyoNBWfqTOL07IHxfY3E(1917998801 >> 2 ^ 479496706));
            num = 14;
            continue;
          case 10:
            CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, CacheExtensions.SyoNBWfqTOL07IHxfY3E(1178210108 ^ 1178553588));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
            continue;
          case 11:
            stringBuilder = new StringBuilder();
            num = 10;
            continue;
          case 12:
          case 16:
            ++index;
            num = 15;
            continue;
          case 13:
          case 15:
            if (index >= parameters.Length)
            {
              num = 7;
              continue;
            }
            break;
          case 14:
            parameters = method.GetParameters();
            num = 2;
            continue;
          case 17:
            obj = arguments[index];
            num = 19;
            continue;
          case 18:
            if (index >= parameters.Length - 1)
            {
              num = 16;
              continue;
            }
            goto case 6;
          case 19:
            CacheExtensions.Jjq71nfqkvmDjQ1vSQyq((object) stringBuilder, (object) CacheExtensions.PrepareForCacheKeyValue(obj, CacheExtensions.sKhZBNfq2MCOKOOEWhy2((object) parameters[index])));
            num = 18;
            continue;
        }
        stringBuilder.Append((string) CacheExtensions.yvk1EffqPebybMlGLvBr((object) parameters[index]));
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 4 : 4;
      }
label_7:
      return stringBuilder.ToString();
    }

    private static string PrepareForCacheKeyValue(object value, Type parameterType)
    {
      int num1 = 17;
      object obj1;
      Guid guid;
      IIdentified identified;
      IEnumerator enumerator;
      Type genericArgument;
      List<string> values;
      while (true)
      {
        int num2 = num1;
        ReferenceOnEntityType referenceOnEntityType;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!parameterType.IsGenericType)
              {
                num2 = 8;
                continue;
              }
              goto case 19;
            case 2:
              identified = value as IIdentified;
              num2 = 23;
              continue;
            case 3:
              enumerator = (IEnumerator) CacheExtensions.vVU3oSfqpJ2PMZASWFvK((object) (IEnumerable) value);
              num2 = 11;
              continue;
            case 4:
              referenceOnEntityType = value as ReferenceOnEntityType;
              num2 = 14;
              continue;
            case 5:
              guid = CacheExtensions.AWD7LOfqtI75sg8M0vna((object) referenceOnEntityType);
              num2 = 10;
              continue;
            case 6:
              values = new List<string>();
              num2 = 3;
              continue;
            case 7:
              goto label_19;
            case 8:
            case 20:
              if (!parameterType.IsClass)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 18 : 18;
                continue;
              }
              goto case 4;
            case 9:
              genericArgument = type.GetGenericArguments()[0];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 6 : 4;
              continue;
            case 10:
              goto label_13;
            case 11:
              goto label_30;
            case 12:
              goto label_52;
            case 13:
              obj1 = CacheExtensions.cgTrktfqww8Wj6qWQXgO((object) identified);
              num2 = 25;
              continue;
            case 14:
              if (referenceOnEntityType == null)
              {
                num2 = 2;
                continue;
              }
              goto case 5;
            case 15:
              // ISSUE: type reference
              if (CacheExtensions.L1FDYNfqNBhnVHwm6LCW(parameterType, CacheExtensions.sZMXInfq1TJrgFEuamsj(__typeref (string))))
              {
                num2 = 12;
                continue;
              }
              // ISSUE: type reference
              if (!CacheExtensions.sZMXInfq1TJrgFEuamsj(__typeref (IEnumerable)).IsAssignableFrom(parameterType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 20 : 11;
                continue;
              }
              goto case 1;
            case 16:
              if (!parameterType.IsPrimitive)
              {
                num2 = 15;
                continue;
              }
              goto label_52;
            case 17:
              goto label_5;
            case 18:
              if (parameterType.IsInterface)
              {
                num2 = 4;
                continue;
              }
              goto label_20;
            case 19:
              // ISSUE: type reference
              type = parameterType.GetInterface((string) CacheExtensions.gWqPvvfqnNhKERDVarVN((object) CacheExtensions.sZMXInfq1TJrgFEuamsj(__typeref (IEnumerable<>))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 22 : 5;
              continue;
            case 21:
              goto label_49;
            case 22:
              if (CacheExtensions.KvTOIrfq3iaYvNS727kn(type, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 9 : 6;
                continue;
              }
              goto case 8;
            case 23:
              if (identified == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 7 : 2;
                continue;
              }
              goto case 13;
            case 24:
              goto label_17;
            case 25:
              if (obj1 == null)
              {
                num2 = 24;
                continue;
              }
              goto label_18;
            default:
              goto label_25;
          }
        }
label_5:
        if (value != null)
          num1 = 16;
        else
          goto label_25;
      }
label_13:
      return guid.ToString();
label_17:
      return identified.GetType().FullName;
label_18:
      return (string) CacheExtensions.SbU4f0fq4Sj0J8Pm1K5M((object) identified.GetType().FullName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87339341), obj1);
label_19:
      return value.GetType().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539361419) + (object) value.GetHashCode();
label_20:
      return value.ToString();
label_25:
      return "";
label_30:
      try
      {
label_33:
        if (CacheExtensions.jXkZt8fqDZQL1SbWixDx((object) enumerator))
          goto label_35;
        else
          goto label_34;
label_31:
        object obj2;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_35;
            case 2:
              goto label_33;
            case 3:
              values.Add(CacheExtensions.PrepareForCacheKeyValue(obj2, genericArgument));
              num3 = 2;
              continue;
            default:
              goto label_49;
          }
        }
label_34:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
        goto label_31;
label_35:
        obj2 = CacheExtensions.XeZOC3fqaeFjhjCMdSaW((object) enumerator);
        num3 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
        {
          num3 = 0;
          goto label_31;
        }
        else
          goto label_31;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              disposable.Dispose();
              num4 = 2;
              continue;
            case 2:
              goto label_43;
            default:
              if (disposable != null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
                continue;
              }
              goto label_43;
          }
        }
label_43:;
      }
label_49:
      return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123620210), (IEnumerable<string>) values);
label_52:
      return value.ToString();
    }

    internal static bool ePwioUfqiOQKmJMsIuP5() => CacheExtensions.qlS8w0fqSxDmmqb0nLXP == null;

    internal static CacheExtensions Py2kTCfqRWheq3dXhBPQ() => CacheExtensions.qlS8w0fqSxDmmqb0nLXP;

    internal static object EAEr5ufqqIdk9YkdZTCM([In] object obj0) => (object) ((MethodInfo) obj0).GetCacheRegion();

    internal static void U1G1oCfqKct4nd3IKXMV([In] object obj0, [In] object obj1) => ComplexCacheInterceptor.ClearRegion((IComplexCacheService) obj0, (string) obj1);

    internal static object RX205vfqXdlhGX8uEuvB([In] object obj0, Type targetType) => (object) ((MethodInfo) obj0).GetCacheRegion(targetType);

    internal static object SyoNBWfqTOL07IHxfY3E(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Jjq71nfqkvmDjQ1vSQyq([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object gWqPvvfqnNhKERDVarVN([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object iBsfDGfqOP5h0Ou3pBHU([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static Type sKhZBNfq2MCOKOOEWhy2([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

    internal static object oXNQLpfqeDFoPb3D26W3([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append(obj1);

    internal static object yvk1EffqPebybMlGLvBr([In] object obj0) => (object) ((ParameterInfo) obj0).Name;

    internal static Type sZMXInfq1TJrgFEuamsj([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool L1FDYNfqNBhnVHwm6LCW([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool KvTOIrfq3iaYvNS727kn([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object vVU3oSfqpJ2PMZASWFvK([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object XeZOC3fqaeFjhjCMdSaW([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static bool jXkZt8fqDZQL1SbWixDx([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static Guid AWD7LOfqtI75sg8M0vna([In] object obj0) => ((ReferenceOnEntityType) obj0).TypeUid;

    internal static object cgTrktfqww8Wj6qWQXgO([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static object SbU4f0fq4Sj0J8Pm1K5M([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);
  }
}
