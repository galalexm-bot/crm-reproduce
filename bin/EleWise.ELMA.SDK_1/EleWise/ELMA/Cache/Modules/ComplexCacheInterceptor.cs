// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.Modules.ComplexCacheInterceptor
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
  /// Перехватчик методов, отмеченных атрибутом <see cref="T:EleWise.ELMA.Cache.Attributes.ComplexCacheAttribute" />
  /// </summary>
  public class ComplexCacheInterceptor : CacheInterceptorBase<ComplexCacheAttribute>
  {
    private readonly IComplexCacheService complexCacheService;
    private static ComplexCacheInterceptor i04wPjfKHnyj4wXo8OWm;

    /// <summary>Ctor</summary>
    /// <param name="complexCacheService">Сервис для работы с составным кешем</param>
    public ComplexCacheInterceptor(IComplexCacheService complexCacheService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.complexCacheService = complexCacheService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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
      ComplexCacheAttribute cacheAttribute)
    {
      int num1 = 2;
      IInvocation invocation1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            invocation1 = invocation;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 3 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
            continue;
          case 3:
            ComplexCacheInterceptor.mAySWDfK0pKh8gTCeEu7((object) invocation1, this.complexCacheService.GetOrAdd<object>(cacheKey, (string) ComplexCacheInterceptor.gYevuxfKxGnuskWthsl7((object) cacheAttribute), cacheRegion, (Func<object>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    invocation1.Proceed();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              return ComplexCacheInterceptor.\u003C\u003Ec__DisplayClass2_0.vd0KDR8LNfdmdqCmNs0r((object) invocation1);
            })));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <inheritdoc />
    protected override Task InvokeAsync(
      IInvocationAsync invocation,
      string cacheKey,
      string cacheRegion,
      ComplexCacheAttribute cacheAttribute,
      CancellationToken cancellationToken)
    {
      int num = 1;
      // ISSUE: variable of a compiler-generated type
      ComplexCacheInterceptor.\u003CInvokeAsync\u003Ed__3 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cacheAttribute = cacheAttribute;
            num = 6;
            continue;
          case 3:
            goto label_8;
          case 4:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 9;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 4 : 4;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ComplexCacheInterceptor.c3UEnhfKmO51VVLtG5bN();
            num = 5;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cacheRegion = cacheRegion;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 2;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cacheKey = cacheKey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 7 : 7;
            continue;
          case 9:
            tBuilder.Start<ComplexCacheInterceptor.\u003CInvokeAsync\u003Ed__3>(ref stateMachine);
            num = 3;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.invocation = invocation;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 8 : 8;
            continue;
        }
      }
label_8:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>
    /// Очистить регион <paramref name="cacheRegion" /> в кэше
    /// </summary>
    /// <param name="complexCacheService">Кэш</param>
    /// <param name="cacheRegion">Регион</param>
    internal static void ClearRegion(IComplexCacheService complexCacheService, string cacheRegion)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            complexCacheService.RefreshTimestampRegion(cacheRegion);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool Xv22BHfKANrEpqKvsh51() => ComplexCacheInterceptor.i04wPjfKHnyj4wXo8OWm == null;

    internal static ComplexCacheInterceptor XTr5LwfK787F37e4xRoY() => ComplexCacheInterceptor.i04wPjfKHnyj4wXo8OWm;

    internal static object gYevuxfKxGnuskWthsl7([In] object obj0) => (object) ((ComplexCacheAttribute) obj0).TimestampKey;

    internal static void mAySWDfK0pKh8gTCeEu7([In] object obj0, [In] object obj1) => ((IInvocation) obj0).ReturnValue = obj1;

    internal static AsyncTaskMethodBuilder c3UEnhfKmO51VVLtG5bN() => AsyncTaskMethodBuilder.Create();
  }
}
