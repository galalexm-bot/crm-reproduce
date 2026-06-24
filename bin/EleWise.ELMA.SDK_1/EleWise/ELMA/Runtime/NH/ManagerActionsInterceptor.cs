// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.ManagerActionsInterceptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Actions.Impl;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Перехватчик методов с атрибутом <see cref="T:EleWise.ELMA.Actions.ActionMethodAttribute" />
  /// </summary>
  internal class ManagerActionsInterceptor : AbstractAsyncInterceptor
  {
    private readonly ActionDispatcherService dispatcherService;
    internal static ManagerActionsInterceptor vX9RPsWwRqx95E6uanHY;

    /// <summary>Ctor</summary>
    /// <param name="dispatcherService">Сервис для работы с действиями</param>
    public ManagerActionsInterceptor(ActionDispatcherService dispatcherService)
    {
      ManagerActionsInterceptor.hrPYyUWwX7xS5YrBEW1f();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.dispatcherService = dispatcherService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Перехват</summary>
    /// <param name="invocation">Контекст вызова</param>
    [DebuggerHidden]
    public override void Intercept(IInvocation invocation)
    {
      int num1 = 9;
      while (true)
      {
        ActionCheckAttribute attribute1;
        IAuditEventHolder auditEventHolder1;
        IAuditEventHolder auditEventHolder2;
        ActionCheckResult actionCheckResult;
        ActionMethodAttribute attribute2;
        object obj1;
        object obj2;
        switch (num1)
        {
          case 1:
            goto label_45;
          case 2:
            goto label_5;
          case 3:
            obj2 = ManagerActionsInterceptor.VXomU9WwO2EcfNJM61Og((object) auditEventHolder2);
            goto label_61;
          case 4:
label_54:
            ManagerActionsInterceptor.bi3mMeWwktqF7cveQkt6((object) invocation);
            num1 = 11;
            continue;
          case 5:
            goto label_2;
          case 6:
            goto label_12;
          case 7:
          case 18:
            ManagerActionsInterceptor.bi3mMeWwktqF7cveQkt6((object) invocation);
            num1 = 2;
            continue;
          case 8:
            if ((MethodInfo) ManagerActionsInterceptor.iaiZOiWwTWZ0AmB07q1d((object) invocation) == (MethodInfo) null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
              continue;
            }
            attribute2 = AttributeHelper<ActionMethodAttribute>.GetAttribute((MemberInfo) ManagerActionsInterceptor.iaiZOiWwTWZ0AmB07q1d((object) invocation), false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 15 : 7;
            continue;
          case 9:
            if (invocation != null)
            {
              num1 = 8;
              continue;
            }
            goto label_51;
          case 10:
            ManagerActionsInterceptor.bi3mMeWwktqF7cveQkt6((object) invocation);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 6 : 4;
            continue;
          case 11:
            goto label_9;
          case 12:
            ManagerActionsInterceptor.bi3mMeWwktqF7cveQkt6((object) invocation);
            num1 = 5;
            continue;
          case 13:
            try
            {
              auditEventHolder2 = ManagerActionInvokeProvider.GetActionInfoForCheck((MethodInfo) ManagerActionsInterceptor.iaiZOiWwTWZ0AmB07q1d((object) invocation));
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_48;
              }
            }
            catch (InvalidOperationException ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    auditEventHolder2 = (IAuditEventHolder) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_48;
                }
              }
            }
          case 14:
            ManagerActionsInterceptor.u6hEsZWw2uSCl3c1YbID((object) invocation, this.dispatcherService.InvokeAction((IAuditObject) ManagerActionsInterceptor.VXomU9WwO2EcfNJM61Og((object) auditEventHolder1), auditEventHolder1.Action, (object[]) ManagerActionsInterceptor.b4ScAwWwnyEsj8oLmDBw((object) invocation)));
            num1 = 25;
            continue;
          case 15:
            attribute1 = AttributeHelper<ActionCheckAttribute>.GetAttribute((MemberInfo) ManagerActionsInterceptor.iaiZOiWwTWZ0AmB07q1d((object) invocation), false);
            num1 = 23;
            continue;
          case 16:
            if (!this.dispatcherService.InterceptMethodInvocation(invocation.Method, (object[]) ManagerActionsInterceptor.b4ScAwWwnyEsj8oLmDBw((object) invocation)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 6 : 10;
              continue;
            }
            if (attribute2 == null)
            {
              if (attribute1 != null)
              {
                num1 = 13;
                continue;
              }
              goto label_55;
            }
            else
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            }
          case 17:
            if (attribute1 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 8 : 12;
              continue;
            }
            goto case 16;
          case 19:
label_28:
            if (auditEventHolder1 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 6 : 20;
              continue;
            }
            obj1 = ManagerActionsInterceptor.VXomU9WwO2EcfNJM61Og((object) auditEventHolder1);
            break;
          case 20:
            obj1 = (object) null;
            break;
          case 21:
            obj2 = (object) null;
            goto label_61;
          case 22:
            goto label_30;
          case 23:
            if (attribute2 != null)
            {
              num1 = 16;
              continue;
            }
            goto case 17;
          case 24:
label_52:
            if (auditEventHolder1.Action != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 12 : 14;
              continue;
            }
            goto case 7;
          case 25:
            goto label_64;
          case 26:
            if (auditEventHolder2.Action != null)
            {
              actionCheckResult = this.dispatcherService.CheckAction((IAuditObject) ManagerActionsInterceptor.VXomU9WwO2EcfNJM61Og((object) auditEventHolder2), (IAuditAction) ManagerActionsInterceptor.IbRa97WwePEBOO3jnvSD((object) auditEventHolder2), invocation.Arguments);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 22 : 28;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 4;
            continue;
          case 27:
label_48:
            if (auditEventHolder2 != null)
            {
              num1 = 3;
              continue;
            }
            goto case 21;
          case 28:
            ManagerActionsInterceptor.u6hEsZWw2uSCl3c1YbID((object) invocation, !ManagerActionsInterceptor.byvDxvWw1SaGZycq5xGA(ManagerActionsInterceptor.YVW2bDWwP8ajA0mlLgVd(ManagerActionsInterceptor.iaiZOiWwTWZ0AmB07q1d((object) invocation)), typeof (ActionCheckResult)) ? (object) actionCheckResult.Result : (object) actionCheckResult);
            num1 = 22;
            continue;
          default:
            try
            {
              auditEventHolder1 = ManagerActionInvokeProvider.GetActionInfoForMethod(invocation.Method);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
                num4 = 0;
              switch (num4)
              {
                default:
                  goto label_28;
              }
            }
            catch (InvalidOperationException ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_28;
                  default:
                    auditEventHolder1 = (IAuditEventHolder) null;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
                    continue;
                }
              }
            }
        }
        if (obj1 == null)
        {
          num1 = 18;
          continue;
        }
        goto label_52;
label_61:
        if (obj2 != null)
          num1 = 26;
        else
          goto label_54;
      }
label_45:
      return;
label_5:
      return;
label_2:
      return;
label_12:
      return;
label_9:
      return;
label_30:
      return;
label_64:
      return;
label_55:
      return;
label_51:;
    }

    /// <inheritdoc />
    [DebuggerHidden]
    public override Task InterceptAsync(
      IInvocationAsync invocation,
      CancellationToken cancellationToken)
    {
      int num = 1;
      AsyncTaskMethodBuilder tBuilder;
      // ISSUE: variable of a compiler-generated type
      ManagerActionsInterceptor.\u003CInterceptAsync\u003Ed__3 stateMachine;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cancellationToken = cancellationToken;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 4 : 5;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 7;
            continue;
          case 4:
            goto label_5;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ManagerActionsInterceptor.zScToVWwNAJRVvYRrEcx();
            num = 6;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 2 : 3;
            continue;
          case 7:
            tBuilder.Start<ManagerActionsInterceptor.\u003CInterceptAsync\u003Ed__3>(ref stateMachine);
            num = 4;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.invocation = invocation;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 1;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    internal static void hrPYyUWwX7xS5YrBEW1f() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool BolHWpWwqEsn6hQmmG4p() => ManagerActionsInterceptor.vX9RPsWwRqx95E6uanHY == null;

    internal static ManagerActionsInterceptor PbnerRWwKxo1ebBHZFyB() => ManagerActionsInterceptor.vX9RPsWwRqx95E6uanHY;

    internal static object iaiZOiWwTWZ0AmB07q1d([In] object obj0) => (object) ((IInvocation) obj0).Method;

    internal static void bi3mMeWwktqF7cveQkt6([In] object obj0) => ((IInvocation) obj0).Proceed();

    internal static object b4ScAwWwnyEsj8oLmDBw([In] object obj0) => (object) ((IInvocation) obj0).Arguments;

    internal static object VXomU9WwO2EcfNJM61Og([In] object obj0) => (object) ((IAuditEventHolder) obj0).Object;

    internal static void u6hEsZWw2uSCl3c1YbID([In] object obj0, [In] object obj1) => ((IInvocation) obj0).ReturnValue = obj1;

    internal static object IbRa97WwePEBOO3jnvSD([In] object obj0) => (object) ((IAuditEventHolder) obj0).Action;

    internal static Type YVW2bDWwP8ajA0mlLgVd([In] object obj0) => ((MethodInfo) obj0).ReturnType;

    internal static bool byvDxvWw1SaGZycq5xGA([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static AsyncTaskMethodBuilder zScToVWwNAJRVvYRrEcx() => AsyncTaskMethodBuilder.Create();
  }
}
