// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Interceptors.AuditInterceptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Castle.DynamicProxy;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH.Interceptors
{
  /// <summary>
  /// Перехватчик методов с атрибутом <see cref="T:EleWise.ELMA.Events.Audit.AuditableAttribute" />
  /// </summary>
  public class AuditInterceptor : AbstractAsyncInterceptor
  {
    private readonly ConcurrentDictionary<MethodInfo, AuditableAttribute> methodAttributes;
    private IAuditableEventHandler handler;
    private IAuditableEventHandlerAsync handlerAsync;
    private readonly ILifetimeScopeAccessor lifetimeScopeAccessor;
    private bool shellActivated;
    internal static AuditInterceptor rIacVnWAFopPM9CGV9Ok;

    /// <summary>Ctor</summary>
    /// <param name="lifetimeScopeAccessor">Сервис доступа к текущему контексту</param>
    public AuditInterceptor(ILifetimeScopeAccessor lifetimeScopeAccessor)
    {
      AuditInterceptor.AW2TmRWAofmyOVBaLYss();
      this.methodAttributes = new ConcurrentDictionary<MethodInfo, AuditableAttribute>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.lifetimeScopeAccessor = lifetimeScopeAccessor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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
    [DebuggerHidden]
    public override void Intercept(IInvocation invocation)
    {
      int num1 = 20;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          AuditableEventArgs e1;
          AuditableCancelEventArgs e2;
          AuditableAttribute orAdd;
          switch (num2)
          {
            case 1:
              if (!this.ShellActivated)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 7 : 16;
                continue;
              }
              goto default;
            case 2:
              if (orAdd.Postprocess)
                goto case 1;
              else
                goto label_29;
            case 3:
            case 5:
              if (AuditInterceptor.qmBBHfWAh9nes7tO8UA0((object) orAdd))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 15 : 7;
                continue;
              }
              break;
            case 4:
              AuditInterceptor.gF2XSNWACmaxUrEgSpuR((object) e1, AuditInterceptor.UYmIm8WAQgOcnVvBndYT((object) invocation));
              num2 = 18;
              continue;
            case 6:
              this.FillEventArgs(invocation, e1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 4 : 0;
              continue;
            case 7:
              if (orAdd.Preprocess)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 3 : 5;
                continue;
              }
              goto case 8;
            case 8:
              if (orAdd.Postprocess)
              {
                num2 = 3;
                continue;
              }
              goto case 9;
            case 9:
              AuditInterceptor.Q11auKWAbJ7UNLLHigHT((object) invocation);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 11 : 3;
              continue;
            case 10:
              AuditInterceptor.t9CUIrWAGPAWY1WeGKcY((object) this.handler, (object) e2);
              num2 = 17;
              continue;
            case 11:
              goto label_6;
            case 12:
              AuditInterceptor.bKahnVWAfaMDpvynX7ay((object) invocation, e1.Result);
              num2 = 22;
              continue;
            case 13:
              e2 = new AuditableCancelEventArgs();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 14 : 1;
              continue;
            case 14:
              this.FillEventArgs(invocation, (AuditableEventArgs) e2);
              num2 = 10;
              continue;
            case 15:
              if (this.ShellActivated)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 4 : 13;
                continue;
              }
              break;
            case 16:
              goto label_18;
            case 17:
              if (AuditInterceptor.Pv0lxmWAE1VsFXnvK7VB((object) e2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 7 : 23;
                continue;
              }
              break;
            case 18:
              this.handler.Postprocess(e1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 6 : 12;
              continue;
            case 19:
              if (orAdd == null)
                goto case 9;
              else
                goto label_33;
            case 20:
              ConcurrentDictionary<MethodInfo, AuditableAttribute> methodAttributes = this.methodAttributes;
              MethodInfo method = invocation.Method;
              // ISSUE: reference to a compiler-generated field
              Func<MethodInfo, AuditableAttribute> func = AuditInterceptor.\u003C\u003Ec.\u003C\u003E9__2_0;
              Func<MethodInfo, AuditableAttribute> valueFactory;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                AuditInterceptor.\u003C\u003Ec.\u003C\u003E9__2_0 = valueFactory = (Func<MethodInfo, AuditableAttribute>) (mi => AttributeHelper<AuditableAttribute>.GetAttribute((MemberInfo) mi, true));
              }
              else
                goto label_38;
label_37:
              orAdd = methodAttributes.GetOrAdd(method, valueFactory);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 8 : 19;
              continue;
label_38:
              valueFactory = func;
              goto label_37;
            case 21:
              goto label_35;
            case 22:
              goto label_31;
            case 23:
              AuditInterceptor.bKahnVWAfaMDpvynX7ay((object) invocation, e2.Result);
              num2 = 21;
              continue;
            case 24:
              goto label_30;
            default:
              e1 = new AuditableEventArgs();
              num2 = 6;
              continue;
          }
          AuditInterceptor.Q11auKWAbJ7UNLLHigHT((object) invocation);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 2;
        }
label_29:
        num1 = 24;
        continue;
label_33:
        num1 = 7;
      }
label_6:
      return;
label_18:
      return;
label_35:
      return;
label_31:
      return;
label_30:;
    }

    /// <inheritdoc />
    [DebuggerHidden]
    public override Task InterceptAsync(
      IInvocationAsync invocation,
      CancellationToken cancellationToken)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      AuditInterceptor.\u003CInterceptAsync\u003Ed__3 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = 3;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 7;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.invocation = invocation;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 1;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 4;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = AuditInterceptor.tdvNBGWAv8Rwp87RkgSs();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 0;
              continue;
            case 7:
              tBuilder.Start<AuditInterceptor.\u003CInterceptAsync\u003Ed__3>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_8:
        // ISSUE: reference to a compiler-generated field
        stateMachine.cancellationToken = cancellationToken;
        num1 = 6;
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private bool ShellActivated
    {
      get
      {
        int num = 4;
        ILifetimeScope context;
        while (true)
        {
          switch (num)
          {
            case 2:
              this.handler = context.Resolve<IAuditableEventHandler>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 6 : 7;
              continue;
            case 4:
              if (this.shellActivated)
              {
                num = 3;
                continue;
              }
              goto case 5;
            case 5:
              if (AuditInterceptor.bRZ77hWA8bOv6JX9rXWJ((object) this.lifetimeScopeAccessor) != ServiceScope.Shell)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
                continue;
              }
              goto case 6;
            case 6:
              context = (ILifetimeScope) AuditInterceptor.Tq0WJyWAZ9BEYBCFZrJu((object) this.lifetimeScopeAccessor);
              num = 2;
              continue;
            case 7:
              this.handlerAsync = context.Resolve<IAuditableEventHandlerAsync>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 8 : 6;
              continue;
            case 8:
              this.shellActivated = this.handler != null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return this.shellActivated;
      }
    }

    private void FillEventArgs(IInvocation invocation, AuditableEventArgs e)
    {
      int num = 12;
      int index;
      object obj;
      string name;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 10:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 4 : 3;
            continue;
          case 3:
            name = ((ParameterInfo) AuditInterceptor.x8ycQgWAixgxnophNoy6(AuditInterceptor.thTtp4WAIpuWIHl2wQYX((object) invocation))[index]).Name;
            num = 8;
            continue;
          case 4:
          case 6:
            if (index < AuditInterceptor.x8ycQgWAixgxnophNoy6((object) invocation.Method).Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 5:
            e.Params[name] = obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
            continue;
          case 7:
            goto label_9;
          case 8:
            obj = invocation.Arguments[index];
            num = 5;
            continue;
          case 9:
            index = 0;
            num = 6;
            continue;
          case 11:
            e.InvokerType = invocation.TargetType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 7 : 13;
            continue;
          case 12:
            e.Invoker = AuditInterceptor.d6rHW8WAu6Qr4PGXxUnL((object) invocation);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 11 : 11;
            continue;
          case 13:
            AuditInterceptor.di5a5OWAVjCjJGxCtHh7((object) e, AuditInterceptor.thTtp4WAIpuWIHl2wQYX((object) invocation));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 3 : 9;
            continue;
          default:
            if (index >= AuditInterceptor.sMfR55WASYGgwgdIPbR9((object) invocation).Length)
            {
              num = 10;
              continue;
            }
            goto case 3;
        }
      }
label_9:
      return;
label_8:;
    }

    internal static void AW2TmRWAofmyOVBaLYss() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool AKGDN3WABAtFtL8qb1m1() => AuditInterceptor.rIacVnWAFopPM9CGV9Ok == null;

    internal static AuditInterceptor JvYNo1WAWoQXfV5Tdxtu() => AuditInterceptor.rIacVnWAFopPM9CGV9Ok;

    internal static void Q11auKWAbJ7UNLLHigHT([In] object obj0) => ((IInvocation) obj0).Proceed();

    internal static bool qmBBHfWAh9nes7tO8UA0([In] object obj0) => ((AuditableAttribute) obj0).Preprocess;

    internal static void t9CUIrWAGPAWY1WeGKcY([In] object obj0, [In] object obj1) => ((IAuditableEventHandler) obj0).Preprocess((AuditableCancelEventArgs) obj1);

    internal static bool Pv0lxmWAE1VsFXnvK7VB([In] object obj0) => ((AuditableCancelEventArgs) obj0).Cancel;

    internal static void bKahnVWAfaMDpvynX7ay([In] object obj0, [In] object obj1) => ((IInvocation) obj0).ReturnValue = obj1;

    internal static object UYmIm8WAQgOcnVvBndYT([In] object obj0) => ((IInvocation) obj0).ReturnValue;

    internal static void gF2XSNWACmaxUrEgSpuR([In] object obj0, [In] object obj1) => ((AuditableEventArgs) obj0).Result = obj1;

    internal static AsyncTaskMethodBuilder tdvNBGWAv8Rwp87RkgSs() => AsyncTaskMethodBuilder.Create();

    internal static ServiceScope bRZ77hWA8bOv6JX9rXWJ([In] object obj0) => ((ILifetimeScopeAccessor) obj0).CurrentType;

    internal static object Tq0WJyWAZ9BEYBCFZrJu([In] object obj0) => (object) ((ILifetimeScopeAccessor) obj0).Current;

    internal static object d6rHW8WAu6Qr4PGXxUnL([In] object obj0) => ((IInvocation) obj0).Proxy;

    internal static object thTtp4WAIpuWIHl2wQYX([In] object obj0) => (object) ((IInvocation) obj0).Method;

    internal static void di5a5OWAVjCjJGxCtHh7([In] object obj0, [In] object obj1) => ((AuditableEventArgs) obj0).Method = (MethodInfo) obj1;

    internal static object sMfR55WASYGgwgdIPbR9([In] object obj0) => (object) ((IInvocation) obj0).Arguments;

    internal static object x8ycQgWAixgxnophNoy6([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();
  }
}
