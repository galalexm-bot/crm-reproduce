// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.Modules.CacheInterceptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Cache.Modules
{
  /// <summary>
  /// Перехватчик методов, отмеченных атрибутом <see cref="T:EleWise.ELMA.Cache.Attributes.CacheAttribute" />
  /// </summary>
  public class CacheInterceptor : CacheInterceptorBase<CacheAttribute>
  {
    private readonly ICacheService cacheService;
    internal static CacheInterceptor LFMGp2fKyxQwubqTcMW8;

    /// <summary>Ctor</summary>
    /// <param name="cacheService">Сервис для работы с кешем</param>
    public CacheInterceptor(ICacheService cacheService)
    {
      CacheInterceptor.IIvFbOfK9hLsYoyjjABF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.cacheService = cacheService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    protected override void Invoke(
      IInvocation invocation,
      string cacheKey,
      string cacheRegion,
      CacheAttribute cacheAttribute)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          TimeSpan? durationTime;
          object obj1;
          switch (num2)
          {
            case 1:
              ICacheService cacheService = this.cacheService;
              string key = cacheKey;
              object obj2 = CacheInterceptor.T0gaPIfKlYORyOjg77jX((object) invocation);
              string region = cacheRegion;
              durationTime = cacheAttribute.DurationTime;
              TimeSpan cacheDuration = durationTime.Value;
              cacheService.Insert<object>(key, obj2, region, cacheDuration);
              num2 = 3;
              continue;
            case 2:
              durationTime = cacheAttribute.DurationTime;
              num2 = 5;
              continue;
            case 3:
              goto label_3;
            case 4:
              this.cacheService.Insert<object>(cacheKey, CacheInterceptor.T0gaPIfKlYORyOjg77jX((object) invocation), cacheRegion);
              num2 = 7;
              continue;
            case 5:
              if (durationTime.HasValue)
                goto case 1;
              else
                goto label_6;
            case 6:
              goto label_9;
            case 7:
              goto label_10;
            case 8:
              CacheInterceptor.BOdTlDfKd4qfweKBOtwu((object) invocation);
              num2 = 2;
              continue;
            case 9:
              if (!this.cacheService.TryGetValue<object>(cacheKey, cacheRegion, out obj1))
              {
                num2 = 8;
                continue;
              }
              break;
          }
          invocation.ReturnValue = obj1;
          num2 = 6;
        }
label_6:
        num1 = 4;
      }
label_3:
      return;
label_9:
      return;
label_10:;
    }

    /// <inheritdoc />
    protected override Task InvokeAsync(
      IInvocationAsync invocation,
      string cacheKey,
      string cacheRegion,
      CacheAttribute cacheAttribute,
      CancellationToken cancellationToken)
    {
      int num1 = 9;
      // ISSUE: variable of a compiler-generated type
      CacheInterceptor.\u003CInvokeAsync\u003Ed__3 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cacheAttribute = cacheAttribute;
              num2 = 3;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = CacheInterceptor.MQQEuKfKr9ATuMXxQAyM();
              num2 = 6;
              continue;
            case 4:
              goto label_7;
            case 5:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 7;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = 5;
              continue;
            case 7:
              tBuilder.Start<CacheInterceptor.\u003CInvokeAsync\u003Ed__3>(ref stateMachine);
              num2 = 4;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              stateMachine.invocation = invocation;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 8;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cacheKey = cacheKey;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
              continue;
          }
        }
label_11:
        // ISSUE: reference to a compiler-generated field
        stateMachine.cacheRegion = cacheRegion;
        num1 = 2;
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>
    /// Очистить регион <paramref name="cacheRegion" /> в кэше
    /// </summary>
    /// <param name="cacheService">Кэш</param>
    /// <param name="cacheRegion">Регион</param>
    internal static void ClearRegion(ICacheService cacheService, string cacheRegion)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CacheInterceptor.n8G4nGfKgO1gZPW9y0Km((object) cacheService, (object) cacheRegion);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void IIvFbOfK9hLsYoyjjABF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool D39Fk0fKMrulKWhwUx6J() => CacheInterceptor.LFMGp2fKyxQwubqTcMW8 == null;

    internal static CacheInterceptor RrlL2hfKJu4MUK2NWJkl() => CacheInterceptor.LFMGp2fKyxQwubqTcMW8;

    internal static void BOdTlDfKd4qfweKBOtwu([In] object obj0) => ((IInvocation) obj0).Proceed();

    internal static object T0gaPIfKlYORyOjg77jX([In] object obj0) => ((IInvocation) obj0).ReturnValue;

    internal static AsyncTaskMethodBuilder MQQEuKfKr9ATuMXxQAyM() => AsyncTaskMethodBuilder.Create();

    internal static void n8G4nGfKgO1gZPW9y0Km([In] object obj0, [In] object obj1) => ((ICacheService) obj0).ClearRegion((string) obj1);
  }
}
