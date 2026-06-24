// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CallSessionInterceptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using EleWise.ELMA.Runtime.AOP;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Перехватывает вызовы методов и оборачивает их в <see cref="T:EleWise.ELMA.Runtime.NH.CallContextSessionOwner" />
  /// </summary>
  public class CallSessionInterceptor : AbstractAsyncInterceptor
  {
    internal static CallSessionInterceptor wY27LYW4rakj2ihnqaPO;

    /// <inheritdoc />
    public override void Intercept(IInvocation invocation)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            new BackgroundTask(new System.Action(invocation.Proceed), CallSessionInterceptor.J8mQE4W4jGPK1fkO2g7Y((object) invocation).GetType(), (string) CallSessionInterceptor.NNU9yqW4znOChTMbYDMM(CallSessionInterceptor.VGRfJdW4YITSNROBDrLM(-688192331 - 435440695 ^ -1123771748), CallSessionInterceptor.roqws0W4LGsD4QscGAmS((object) invocation.TargetType), !CallSessionInterceptor.OKbKbaW4sKamXQbdIf79(CallSessionInterceptor.F82y1GW4Ui20J3gNV3vT((object) invocation), (object) null) ? (object) "" : CallSessionInterceptor.z3iLH9W4cI0QwU7O4ip9(CallSessionInterceptor.VGRfJdW4YITSNROBDrLM(-688192331 - 435440695 ^ -1123638598), CallSessionInterceptor.roqws0W4LGsD4QscGAmS(CallSessionInterceptor.F82y1GW4Ui20J3gNV3vT((object) invocation)))), EleWise.ELMA.SR.T((string) CallSessionInterceptor.VGRfJdW4YITSNROBDrLM(-1867198571 ^ -1867060079)), handleExceptions: false).Execute();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    /// <inheritdoc />
    public override Task InterceptAsync(
      IInvocationAsync invocation,
      CancellationToken cancellationToken)
    {
      int num = 4;
      // ISSUE: variable of a compiler-generated type
      CallSessionInterceptor.\u003CInterceptAsync\u003Ed__1 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 5 : 5;
            continue;
          case 2:
            tBuilder.Start<CallSessionInterceptor.\u003CInterceptAsync\u003Ed__1>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.invocation = invocation;
            num = 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    public CallSessionInterceptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object J8mQE4W4jGPK1fkO2g7Y([In] object obj0) => ((IInvocation) obj0).InvocationTarget;

    internal static object VGRfJdW4YITSNROBDrLM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object roqws0W4LGsD4QscGAmS([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object F82y1GW4Ui20J3gNV3vT([In] object obj0) => (object) ((IInvocation) obj0).Method;

    internal static bool OKbKbaW4sKamXQbdIf79([In] object obj0, [In] object obj1) => (MethodInfo) obj0 != (MethodInfo) obj1;

    internal static object z3iLH9W4cI0QwU7O4ip9([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object NNU9yqW4znOChTMbYDMM([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool DZZBmNW4gidO7FIdI3AC() => CallSessionInterceptor.wY27LYW4rakj2ihnqaPO == null;

    internal static CallSessionInterceptor P9fxNxW45v4CIH7eYqkD() => CallSessionInterceptor.wY27LYW4rakj2ihnqaPO;
  }
}
