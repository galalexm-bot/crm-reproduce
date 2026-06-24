// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.Modules.ContextCacheInterceptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Runtime.AOP;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Cache.Modules
{
  /// <summary>
  /// Перехватчик методов, отмеченных атрибутом <see cref="T:EleWise.ELMA.Cache.Attributes.ContextCacheAttribute" />
  /// </summary>
  public class ContextCacheInterceptor : CacheInterceptorBase<ContextCacheAttribute>
  {
    private readonly IContextBoundVariableService contextBoundVariableService;
    internal static ContextCacheInterceptor HqSi3mfKLFtSpI5DObRx;

    /// <summary>Ctor</summary>
    /// <param name="contextBoundVariableService">Сервис для работы с переменными в рамках контекста</param>
    public ContextCacheInterceptor(
      IContextBoundVariableService contextBoundVariableService)
    {
      ContextCacheInterceptor.NJ80wxfKcov1fCytV1jt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.contextBoundVariableService = contextBoundVariableService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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
    protected override void Invoke(
      IInvocation invocation,
      string cacheKey,
      string cacheRegion,
      ContextCacheAttribute cacheAttribute)
    {
      int num = 2;
      object result;
      while (true)
      {
        switch (num)
        {
          case 1:
            cacheRegion = (string) ContextCacheInterceptor.TklZBsfKzY5KgCxf7lTQ((object) cacheAttribute);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 2 : 7;
            continue;
          case 2:
            if (ContextCacheInterceptor.TklZBsfKzY5KgCxf7lTQ((object) cacheAttribute) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
              continue;
            }
            goto case 7;
          case 3:
            goto label_4;
          case 4:
            ContextCacheInterceptor.gO8h9ZfXB4m9XmTbtl9P((object) invocation);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_3;
          case 6:
            ContextCacheInterceptor.eXVgxYfXFBeDJulxn8vN((object) invocation, result);
            num = 5;
            continue;
          case 7:
            if (!ContextCacheInterceptor.TryGetValue(this.contextBoundVariableService, cacheKey, cacheRegion, out result))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 4 : 1;
              continue;
            }
            goto case 6;
          default:
            ContextCacheInterceptor.Set(this.contextBoundVariableService, cacheKey, cacheRegion, ContextCacheInterceptor.KAnrM6fXWHFwyA2C5a96((object) invocation));
            num = 3;
            continue;
        }
      }
label_4:
      return;
label_3:;
    }

    /// <inheritdoc />
    protected override Task InvokeAsync(
      IInvocationAsync invocation,
      string cacheKey,
      string cacheRegion,
      ContextCacheAttribute cacheAttribute,
      CancellationToken cancellationToken)
    {
      int num1 = 3;
      // ISSUE: variable of a compiler-generated type
      ContextCacheInterceptor.\u003CInvokeAsync\u003Ed__4 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              tBuilder.Start<ContextCacheInterceptor.\u003CInvokeAsync\u003Ed__4>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 5;
              continue;
            case 2:
              goto label_5;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 2;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 1;
              continue;
            case 5:
              goto label_11;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cacheRegion = cacheRegion;
              num2 = 8;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = ContextCacheInterceptor.fBIKLmfXofOlG5EvjIk4();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cacheAttribute = cacheAttribute;
              num2 = 7;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cacheKey = cacheKey;
              num2 = 6;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = 4;
              continue;
          }
        }
label_5:
        // ISSUE: reference to a compiler-generated field
        stateMachine.invocation = invocation;
        num1 = 9;
      }
label_11:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>
    /// Установить значение <paramref name="value" /> в регион <paramref name="region" /> контекстного кэша по ключу <paramref name="key" />
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="key">Ключ</param>
    /// <param name="region">Регион</param>
    /// <param name="value">Значение</param>
    internal static void Set(
      IContextBoundVariableService contextBoundVariableService,
      string key,
      string region,
      object value)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        object obj;
        IDictionary<string, IDictionary<string, object>> dictionary1;
        IDictionary<string, object> dictionary2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              goto label_13;
            case 3:
              dictionary1.Add(region, dictionary2 = (IDictionary<string, object>) new Dictionary<string, object>());
              num2 = 9;
              continue;
            case 4:
              goto label_14;
            case 5:
              if (dictionary1.TryGetValue(region, out dictionary2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 6:
              ContextCacheInterceptor.WnpxorfXhdOOCcZDuOrW((object) contextBoundVariableService, ContextCacheInterceptor.pwoawDfXbTD35iLI7NVs(--1867379187 ^ 1867035959), (object) (Dictionary<string, IDictionary<string, object>>) (dictionary1 = (IDictionary<string, IDictionary<string, object>>) new Dictionary<string, IDictionary<string, object>>()));
              num2 = 5;
              continue;
            case 7:
              if (!contextBoundVariableService.TryGetValue<IDictionary<string, IDictionary<string, object>>>((string) ContextCacheInterceptor.pwoawDfXbTD35iLI7NVs(-1598106783 - -968262081 ^ -630189594), out dictionary1))
              {
                num2 = 6;
                continue;
              }
              goto case 5;
            case 8:
              obj = (object) MemoryCacheService.NullValue.Null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
              continue;
            case 10:
              if (obj != null)
              {
                num2 = 2;
                continue;
              }
              goto case 8;
            default:
              goto label_6;
          }
        }
label_6:
        obj = value;
        num1 = 10;
        continue;
label_13:
        dictionary2[key] = obj;
        num1 = 4;
      }
label_14:;
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
    internal static bool TryGetValue(
      IContextBoundVariableService contextBoundVariableService,
      string key,
      string region,
      out object result)
    {
      int num = 3;
      while (true)
      {
        IDictionary<string, IDictionary<string, object>> dictionary1;
        IDictionary<string, object> dictionary2;
        switch (num)
        {
          case 1:
            goto label_13;
          case 2:
            if (!dictionary1.TryGetValue(region, out dictionary2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 3:
            if (contextBoundVariableService.TryGetValue<IDictionary<string, IDictionary<string, object>>>((string) ContextCacheInterceptor.pwoawDfXbTD35iLI7NVs(1178210108 ^ 1178553336), out dictionary1))
            {
              num = 2;
              continue;
            }
            break;
          case 4:
            goto label_7;
          case 5:
            if (dictionary2.TryGetValue(key, out result))
            {
              if (result is MemoryCacheService.NullValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 3 : 6;
                continue;
              }
              goto label_13;
            }
            else
            {
              num = 7;
              continue;
            }
          case 6:
            result = (object) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
            continue;
        }
        result = (object) null;
        num = 4;
      }
label_7:
      return false;
label_13:
      return true;
    }

    /// <summary>
    /// Очистить регион <paramref name="region" /> в контекстном кэше
    /// </summary>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="region">Регион</param>
    internal static void ClearRegion(
      IContextBoundVariableService contextBoundVariableService,
      string region)
    {
      int num = 3;
      IDictionary<string, IDictionary<string, object>> dictionary1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_2;
          case 2:
            IDictionary<string, object> dictionary2;
            if (!dictionary1.TryGetValue(region, out dictionary2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            }
            dictionary2.Clear();
            num = 4;
            continue;
          case 3:
            if (contextBoundVariableService.TryGetValue<IDictionary<string, IDictionary<string, object>>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939720632), out dictionary1))
            {
              num = 2;
              continue;
            }
            goto label_10;
          case 4:
            dictionary1.Remove(region);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
            continue;
          default:
            goto label_11;
        }
      }
label_3:
      return;
label_2:
      return;
label_11:
      return;
label_10:;
    }

    /// <summary>
    /// Удалить значение в регионе <paramref name="region" /> контекстного кэша по ключу <paramref name="key" />
    /// </summary>
    /// <param name="contextBoundVariableService">Контекст</param>
    /// <param name="key">Ключ</param>
    /// <param name="region">Регион</param>
    internal static void Remove(
      IContextBoundVariableService contextBoundVariableService,
      string key,
      string region)
    {
      int num = 4;
      IDictionary<string, IDictionary<string, object>> dictionary1;
      IDictionary<string, object> dictionary2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_6;
          case 2:
            dictionary2.Remove(key);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 1;
            continue;
          case 3:
            if (dictionary1.TryGetValue(region, out dictionary2))
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 4:
            if (contextBoundVariableService.TryGetValue<IDictionary<string, IDictionary<string, object>>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87681127), out dictionary1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 3 : 3;
              continue;
            }
            goto label_10;
          default:
            goto label_11;
        }
      }
label_3:
      return;
label_6:
      return;
label_11:
      return;
label_2:
      return;
label_10:;
    }

    /// <summary>Очитстить контекстный кэш</summary>
    /// <param name="contextBoundVariableService">Контекст</param>
    internal static void Clear(
      IContextBoundVariableService contextBoundVariableService)
    {
      int num1 = 2;
      while (true)
      {
        IDictionary<string, IDictionary<string, object>> dictionary;
        IEnumerator<KeyValuePair<string, IDictionary<string, object>>> enumerator;
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (!contextBoundVariableService.TryGetValue<IDictionary<string, IDictionary<string, object>>>((string) ContextCacheInterceptor.pwoawDfXbTD35iLI7NVs(-2138958856 ^ -2138613956), out dictionary))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
              continue;
            }
            enumerator = dictionary.GetEnumerator();
            num1 = 4;
            continue;
          case 3:
            goto label_17;
          case 4:
            try
            {
label_11:
              if (ContextCacheInterceptor.iQTS4OfXExule5WLQnxi((object) enumerator))
                goto label_9;
              else
                goto label_12;
label_7:
              KeyValuePair<string, IDictionary<string, object>> current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    ContextCacheInterceptor.J9DpuEfXGxx69aCcrqu1((object) current.Value);
                    num2 = 3;
                    continue;
                  case 2:
                    goto label_9;
                  case 3:
                    goto label_11;
                  default:
                    goto label_5;
                }
              }
label_9:
              current = enumerator.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
              {
                num2 = 1;
                goto label_7;
              }
              else
                goto label_7;
label_12:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              goto label_7;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      ContextCacheInterceptor.tpdPaSfXfWZpGoD4DnVm((object) enumerator);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_19;
                  }
                }
              }
label_19:;
            }
        }
label_5:
        ContextCacheInterceptor.YGJIp0fXQjPdHZc7TwwY((object) dictionary);
        num1 = 3;
      }
label_2:
      return;
label_17:;
    }

    internal static void NJ80wxfKcov1fCytV1jt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool nqlxECfKUMAFiLjW3lob() => ContextCacheInterceptor.HqSi3mfKLFtSpI5DObRx == null;

    internal static ContextCacheInterceptor C3BoJrfKsNMvHRSbCCkO() => ContextCacheInterceptor.HqSi3mfKLFtSpI5DObRx;

    internal static object TklZBsfKzY5KgCxf7lTQ([In] object obj0) => (object) ((ContextCacheAttribute) obj0).Region;

    internal static void eXVgxYfXFBeDJulxn8vN([In] object obj0, [In] object obj1) => ((IInvocation) obj0).ReturnValue = obj1;

    internal static void gO8h9ZfXB4m9XmTbtl9P([In] object obj0) => ((IInvocation) obj0).Proceed();

    internal static object KAnrM6fXWHFwyA2C5a96([In] object obj0) => ((IInvocation) obj0).ReturnValue;

    internal static AsyncTaskMethodBuilder fBIKLmfXofOlG5EvjIk4() => AsyncTaskMethodBuilder.Create();

    internal static object pwoawDfXbTD35iLI7NVs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void WnpxorfXhdOOCcZDuOrW([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);

    internal static void J9DpuEfXGxx69aCcrqu1([In] object obj0) => ((ICollection<KeyValuePair<string, object>>) obj0).Clear();

    internal static bool iQTS4OfXExule5WLQnxi([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void tpdPaSfXfWZpGoD4DnVm([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void YGJIp0fXQjPdHZc7TwwY([In] object obj0) => ((ICollection<KeyValuePair<string, IDictionary<string, object>>>) obj0).Clear();
  }
}
