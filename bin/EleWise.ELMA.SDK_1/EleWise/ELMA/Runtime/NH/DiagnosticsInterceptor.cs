// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.DiagnosticsInterceptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Перехватывает вызовы методов и оборачивает их в <see cref="T:EleWise.ELMA.Runtime.NH.CallContextSessionOwner" />
  /// </summary>
  public class DiagnosticsInterceptor : AbstractAsyncInterceptor
  {
    internal static DiagnosticsInterceptor fB5weJWaLDLGNRRmRB0y;

    /// <inheritdoc />
    [DebuggerHidden]
    public override void Intercept(IInvocation invocation)
    {
      int num = 1;
      IInvocation invocation1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            DiagnosticsManager.StartCall<MethodCallInfo>((Func<MethodCallInfo>) (() => new MethodCallInfo(invocation1.TargetType, (MethodInfo) DiagnosticsInterceptor.\u003C\u003Ec__DisplayClass0_0.Giv5ouQ97pJbgVQ1oMVb((object) invocation1), invocation1.Arguments)), new System.Action(invocation1.Proceed));
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            invocation1 = invocation;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    [DebuggerHidden]
    public override Task InterceptAsync(
      IInvocationAsync invocation,
      CancellationToken cancellationToken)
    {
      int num = 1;
      IInvocationAsync invocation1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            invocation1 = invocation;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return DiagnosticsManager.StartAsyncCall<MethodCallInfo>((Func<MethodCallInfo>) (() => new MethodCallInfo(DiagnosticsInterceptor.\u003C\u003Ec__DisplayClass1_0.dIg1vAQ9yAnbG08FP7L3((object) invocation1), (MethodInfo) DiagnosticsInterceptor.\u003C\u003Ec__DisplayClass1_0.pgpqO9Q9M2yZSyMjn17k((object) invocation1), (object[]) DiagnosticsInterceptor.\u003C\u003Ec__DisplayClass1_0.pSQ4BaQ9Ju45hKp1KnTo((object) invocation1))), (Func<CancellationToken, Task>) (_ => (Task) DiagnosticsInterceptor.\u003C\u003Ec__DisplayClass1_0.PVj8vcQ993CIGMVgBkSK((object) invocation1)), cancellationToken);
    }

    public DiagnosticsInterceptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool idGIUpWaUWCnwLHxIFA0() => DiagnosticsInterceptor.fB5weJWaLDLGNRRmRB0y == null;

    internal static DiagnosticsInterceptor sWlcv4WasIBsy8HZin7m() => DiagnosticsInterceptor.fB5weJWaLDLGNRRmRB0y;
  }
}
