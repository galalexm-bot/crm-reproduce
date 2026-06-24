// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.TransactionInterceptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.AOP;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Concurrent;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Перехватчик методов, имеющих атрибут TransactionAttribute
  /// </summary>
  internal sealed class TransactionInterceptor : AbstractAsyncInterceptor
  {
    private static readonly ConcurrentDictionary<MethodInfo, TransactionAttribute> AttributesCache;
    private readonly ILazy<IUnitOfWorkManagerAsync> unitOfWorkManager;
    internal static TransactionInterceptor ihGtuhWHQGVkDUQpFKEE;

    /// <summary>Ctor</summary>
    /// <param name="unitOfWorkManager">Фабрика единицы работ</param>
    public TransactionInterceptor(ILazy<IUnitOfWorkManagerAsync> unitOfWorkManager)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.unitOfWorkManager = unitOfWorkManager;
    }

    /// <inheritdoc />
    [DebuggerHidden]
    public override void Intercept(IInvocation invocation)
    {
      int num1 = 3;
      IUnitOfWork unitOfWork;
      IInvocation invocation1;
      while (true)
      {
        int num2 = num1;
        TransactionAttribute orAdd;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (orAdd != null)
              {
                unitOfWork = this.unitOfWorkManager.Value.Create(string.Empty, true, TransactionInterceptor.M67RqqWHuqx8n4KLYXGF((object) orAdd));
                num2 = 7;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_7;
            case 3:
              num2 = 2;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated method
              orAdd = TransactionInterceptor.AttributesCache.GetOrAdd((MethodInfo) TransactionInterceptor.FJ9syFWH81oMQZpaP2q9((object) invocation1), (System.Func<MethodInfo, TransactionAttribute>) (method => AttributeHelper<TransactionAttribute>.GetAttribute((MemberInfo) TransactionInterceptor.\u003C\u003Ec__DisplayClass3_0.XedAojQrWq0an0hT6twU((object) invocation1), true)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
              continue;
            case 5:
              goto label_29;
            case 6:
              goto label_5;
            case 7:
              goto label_11;
            default:
              TransactionInterceptor.e1tL0NWHZfNNsPdu1iEQ((object) invocation1);
              num2 = 5;
              continue;
          }
        }
label_7:
        invocation1 = invocation;
        num1 = 4;
      }
label_29:
      return;
label_5:
      return;
label_11:
      try
      {
        try
        {
          TransactionInterceptor.e1tL0NWHZfNNsPdu1iEQ((object) invocation1);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
        catch
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                TransactionInterceptor.gxt34DWHI0KYEPSEPu2I((object) unitOfWork);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                continue;
              default:
                goto label_18;
            }
          }
label_18:
          throw;
        }
label_20:
        unitOfWork.Commit();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
          goto label_21;
label_19:
        switch (num5)
        {
          case 0:
            return;
          case 1:
            goto label_20;
          default:
            return;
        }
label_21:
        num5 = 0;
        goto label_19;
      }
      finally
      {
        int num6;
        if (unitOfWork == null)
          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
        else
          goto label_27;
label_25:
        switch (num6)
        {
          case 1:
            break;
          default:
        }
label_27:
        TransactionInterceptor.iDIjNPWHV6bRvb33i8MS((object) unitOfWork);
        num6 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        {
          num6 = 2;
          goto label_25;
        }
        else
          goto label_25;
      }
    }

    /// <inheritdoc />
    [DebuggerHidden]
    public override Task InterceptAsync(
      IInvocationAsync invocation,
      CancellationToken cancellationToken)
    {
      int num = 6;
      // ISSUE: variable of a compiler-generated type
      TransactionInterceptor.\u003CInterceptAsync\u003Ed__4 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 5 : 7;
            continue;
          case 2:
            goto label_3;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cancellationToken = cancellationToken;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 4:
            tBuilder.Start<TransactionInterceptor.\u003CInterceptAsync\u003Ed__4>(ref stateMachine);
            num = 2;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.invocation = invocation;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 2 : 3;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 5;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 4;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = TransactionInterceptor.xDvZlfWHSpdaFTIYZNw6();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    static TransactionInterceptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TransactionInterceptor.AttributesCache = new ConcurrentDictionary<MethodInfo, TransactionAttribute>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          case 2:
            TransactionInterceptor.BqdlUOWHiRKEYGvvucKe();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object FJ9syFWH81oMQZpaP2q9([In] object obj0) => (object) ((IInvocation) obj0).Method;

    internal static void e1tL0NWHZfNNsPdu1iEQ([In] object obj0) => ((IInvocation) obj0).Proceed();

    internal static IsolationLevel M67RqqWHuqx8n4KLYXGF([In] object obj0) => ((TransactionAttribute) obj0).IsolationLevel;

    internal static void gxt34DWHI0KYEPSEPu2I([In] object obj0) => ((IUnitOfWork) obj0).Rollback();

    internal static void iDIjNPWHV6bRvb33i8MS([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool eEZNWFWHCPmSsZQnvc73() => TransactionInterceptor.ihGtuhWHQGVkDUQpFKEE == null;

    internal static TransactionInterceptor kGUfAPWHvjQsuYSNSbnu() => TransactionInterceptor.ihGtuhWHQGVkDUQpFKEE;

    internal static AsyncTaskMethodBuilder xDvZlfWHSpdaFTIYZNw6() => AsyncTaskMethodBuilder.Create();

    internal static void BqdlUOWHiRKEYGvvucKe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
