// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.Modules.CacheInterceptorBase`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Cache.Modules
{
  /// <summary>Базовый абстрактный перехватчик методов кеширования</summary>
  /// <typeparam name="T">Тип атрибута</typeparam>
  public abstract class CacheInterceptorBase<T> : AbstractAsyncInterceptor where T : Attribute
  {
    private readonly ConcurrentDictionary<MethodInfo, T> methodAttributes;
    private static object YZdPN2fK55AqoPiJWhbQ;

    /// <inheritdoc />
    public override void Intercept(IInvocation invocation)
    {
      int num = 5;
      T orAdd;
      string cacheKey;
      InvocationParameters invocationParams;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            invocation.Proceed();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            orAdd = this.methodAttributes.GetOrAdd(invocation.Method, (Func<MethodInfo, T>) (mi => AttributeHelper<T>.GetAttribute((MemberInfo) mi, true)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 6;
            continue;
          case 5:
            num = 4;
            continue;
          case 6:
            if ((object) orAdd == null)
            {
              num = 2;
              continue;
            }
            cacheKey = invocation.Method.GetCacheKey(invocation.TargetType, invocation.Arguments);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          case 7:
            this.Invoke(invocation, cacheKey, invocation.Method.GetCacheRegion(invocation.TargetType), orAdd);
            num = 3;
            continue;
          case 8:
            cacheKey = ComponentManager.Current.GetExtensionPoints<ICacheKeyFormatter>(true).Aggregate<ICacheKeyFormatter, string>(cacheKey, (Func<string, ICacheKeyFormatter, string>) ((s, formatter) => formatter.Format(cacheKey, invocationParams)));
            num = 7;
            continue;
          default:
            invocationParams = new InvocationParameters(invocation);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 8 : 8;
            continue;
        }
      }
label_6:
      return;
label_2:;
    }

    /// <inheritdoc />
    public override Task InterceptAsync(
      IInvocationAsync invocation,
      CancellationToken cancellationToken)
    {
      int num = 7;
      // ISSUE: variable of a compiler-generated type
      CacheInterceptorBase<T>.\u003CInterceptAsync\u003Ed__2 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cancellationToken = cancellationToken;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 3;
            continue;
          case 3:
            tBuilder.Start<CacheInterceptorBase<T>.\u003CInterceptAsync\u003Ed__2>(ref stateMachine);
            num = 4;
            continue;
          case 4:
            goto label_7;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 2;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.invocation = invocation;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = 6;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = 5;
            continue;
        }
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>
    /// Вычислить результат (или достать из кэша) и записать в <paramref name="invocation" />
    /// </summary>
    /// <param name="invocation">Информация о вызове метода</param>
    /// <param name="cacheKey">Ключ кеша</param>
    /// <param name="cacheRegion">Регион кеша</param>
    /// <param name="cacheAttribute">Атрибут кеша</param>
    protected abstract void Invoke(
      IInvocation invocation,
      string cacheKey,
      string cacheRegion,
      T cacheAttribute);

    /// <summary>
    /// Вычислить результат (или достать из кэша) и записать в <paramref name="invocation" />
    /// </summary>
    /// <param name="invocation">Информация о вызове метода</param>
    /// <param name="cacheKey">Ключ кеша</param>
    /// <param name="cacheRegion">Регион кеша</param>
    /// <param name="cacheAttribute">Атрибут кеша</param>
    /// <param name="cancellationToken">Токен отмены</param>
    protected abstract Task InvokeAsync(
      IInvocationAsync invocation,
      string cacheKey,
      string cacheRegion,
      T cacheAttribute,
      CancellationToken cancellationToken);

    protected CacheInterceptorBase()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.methodAttributes = new ConcurrentDictionary<MethodInfo, T>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool YNL93EfKjFAJ8A5pVwvJ() => CacheInterceptorBase<T>.YZdPN2fK55AqoPiJWhbQ == null;

    internal static object Wx6TRmfKYae5KUsXPbcw() => CacheInterceptorBase<T>.YZdPN2fK55AqoPiJWhbQ;
  }
}
