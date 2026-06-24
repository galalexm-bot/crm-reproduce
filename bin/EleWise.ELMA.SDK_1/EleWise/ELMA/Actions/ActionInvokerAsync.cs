// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionInvokerAsync
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Actions
{
  /// <summary>Исполнитель синхронных и асинхронных действий</summary>
  public sealed class ActionInvokerAsync : IActionInvokerAsync, IActionInvoker
  {
    private readonly ILazy<ActionDispatcherService> actionDispatcherService;
    private readonly object entityManager;
    private readonly MethodInfo targetMethodInfo;
    private readonly MethodInfo checkMethodInfo;
    private readonly Func<ActionInvokeEventArgs, object> invokeActionHandler;
    private readonly Func<ActionInvokeEventArgs, CancellationToken, Task<object>> invokeActionHandlerAsync;
    private readonly Func<ActionInvokeEventArgs, ActionCheckResult> checkActionHandler;
    private readonly Func<ActionInvokeEventArgs, CancellationToken, Task<ActionCheckResult>> checkActionHandlerAsync;
    internal static ActionInvokerAsync BwLiu5ftjwfSVal36NQF;

    /// <summary>Ctor</summary>
    /// <param name="actionObject">Объект действия</param>
    /// <param name="actionType">Тип действия</param>
    /// <param name="targetMethodInfo">Вызываемый метод</param>
    /// <param name="invokeActionHandler">Синхронный обработчик вызова действия</param>
    /// <param name="invokeActionHandlerAsync">Асинхронный обработчик вызова действия</param>
    /// <param name="checkActionHandler">Синхронный обработчик вызова проверки доступности</param>
    /// <param name="checkActionHandlerAsync">Асинхронный обработчик вызова проверки доступности</param>
    public ActionInvokerAsync(
      IAuditObject actionObject,
      IAuditAction actionType,
      MethodInfo targetMethodInfo,
      Func<ActionInvokeEventArgs, object> invokeActionHandler,
      Func<ActionInvokeEventArgs, CancellationToken, Task<object>> invokeActionHandlerAsync,
      Func<ActionInvokeEventArgs, ActionCheckResult> checkActionHandler = null,
      Func<ActionInvokeEventArgs, CancellationToken, Task<ActionCheckResult>> checkActionHandlerAsync = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) actionType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575799640));
      Contract.ArgumentNotNull((object) actionObject, z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521452368));
      Contract.ArgumentNotNull((object) targetMethodInfo, z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 221819898));
      Contract.ArgumentNotNull((object) invokeActionHandler, z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874316553));
      Contract.ArgumentNotNull((object) invokeActionHandlerAsync, z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406016461));
      this.ActionObject = actionObject;
      this.ActionType = actionType;
      this.MethodMetadata = ActionMethodMetadata.Create(actionObject, actionType, targetMethodInfo);
      this.invokeActionHandler = invokeActionHandler;
      this.invokeActionHandlerAsync = invokeActionHandlerAsync;
      this.checkActionHandler = checkActionHandler;
      this.checkActionHandlerAsync = checkActionHandlerAsync;
    }

    /// <summary>Ctor</summary>
    /// <param name="actionDispatcherService">Сервис для работы с действиями</param>
    /// <param name="entityManager">Экземпляр менеджера сущности</param>
    /// <param name="actionObject">Объект действия</param>
    /// <param name="actionType">Тип действия</param>
    /// <param name="targetMethodInfo">Информация о вызываемом методе</param>
    /// <param name="checkMethodInfo">Информация о методе проверки возможности исполнения вызываемого метода</param>
    public ActionInvokerAsync(
      ILazy<ActionDispatcherService> actionDispatcherService,
      object entityManager,
      IAuditObject actionObject,
      IAuditAction actionType,
      MethodInfo targetMethodInfo,
      MethodInfo checkMethodInfo = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) actionDispatcherService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459243365));
      Contract.ArgumentNotNull((object) actionObject, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138617080));
      Contract.ArgumentNotNull((object) actionType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751485716));
      Contract.ArgumentNotNull(entityManager, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410890687));
      Contract.ArgumentNotNull((object) targetMethodInfo, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87160589));
      this.ActionObject = actionObject;
      this.ActionType = actionType;
      this.actionDispatcherService = actionDispatcherService;
      this.entityManager = entityManager;
      this.targetMethodInfo = targetMethodInfo;
      this.checkMethodInfo = checkMethodInfo;
      this.MethodMetadata = ActionMethodMetadata.Create(actionObject, actionType, targetMethodInfo);
      if (checkMethodInfo != (MethodInfo) null)
      {
        this.checkActionHandler = new Func<ActionInvokeEventArgs, ActionCheckResult>(this.CheckHandle);
        this.checkActionHandlerAsync = new Func<ActionInvokeEventArgs, CancellationToken, Task<ActionCheckResult>>(this.CheckHandleAsync);
      }
      this.invokeActionHandler = new Func<ActionInvokeEventArgs, object>(this.ActionHandle);
      this.invokeActionHandlerAsync = new Func<ActionInvokeEventArgs, CancellationToken, Task<object>>(this.ActionHandleAsync);
    }

    /// <inheritdoc />
    public IAuditObject ActionObject { get; }

    /// <inheritdoc />
    public IAuditAction ActionType { get; }

    /// <inheritdoc />
    public ActionMethodMetadata MethodMetadata { get; }

    /// <inheritdoc />
    public object InvokeAction(ActionInvokeEventArgs e) => this.invokeActionHandler(e);

    /// <inheritdoc />
    public ActionCheckResult CheckAction(ActionInvokeEventArgs e)
    {
      ActionCheckResult actionCheckResult1;
      switch (1)
      {
        case 1:
          try
          {
            Func<ActionInvokeEventArgs, ActionCheckResult> checkActionHandler = this.checkActionHandler;
            int num;
            if (checkActionHandler == null)
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
            else
              goto label_6;
label_4:
            ActionCheckResult actionCheckResult2;
            switch (num)
            {
              case 1:
                goto label_1;
              default:
                actionCheckResult2 = ActionInvokerAsync.BN6fO9ftUPoa4T4yH0Wu();
                goto label_7;
            }
label_6:
            actionCheckResult2 = checkActionHandler(e);
label_7:
            actionCheckResult1 = actionCheckResult2;
            num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
            {
              num = 0;
              goto label_4;
            }
            else
              goto label_4;
          }
          catch (TargetInvocationException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  if (ex.InnerException == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 3;
                    continue;
                  }
                  goto case 2;
                case 2:
                  ActionInvokerAsync.ufmCCrftzXWdunpIKLiV(ActionInvokerAsync.UIbnUoftcVIwLoyoUsU3(ActionInvokerAsync.q5iG3MftsyuDywJUVZ2g((object) ex)));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_15;
              }
            }
label_15:
            throw;
          }
      }
label_1:
      return actionCheckResult1;
    }

    /// <inheritdoc />
    public Task<object> InvokeActionAsync(
      ActionInvokeEventArgs e,
      CancellationToken cancellationToken)
    {
      return this.invokeActionHandlerAsync(e, cancellationToken);
    }

    /// <inheritdoc />
    public Task<ActionCheckResult> CheckActionAsync(
      ActionInvokeEventArgs e,
      CancellationToken cancellationToken)
    {
      Func<ActionInvokeEventArgs, CancellationToken, Task<ActionCheckResult>> actionHandlerAsync = this.checkActionHandlerAsync;
      return (actionHandlerAsync != null ? actionHandlerAsync(e, cancellationToken) : (Task<ActionCheckResult>) null) ?? Task.FromResult<ActionCheckResult>(ActionCheckResult.True);
    }

    /// <summary>Обработчик проверки возможности выполнения действия</summary>
    /// <param name="e">Аргументы вызова</param>
    /// <returns>Результат проверки</returns>
    private ActionCheckResult CheckHandle(ActionInvokeEventArgs e)
    {
      int num1 = 6;
      ActionCheckResult? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ActionInvokerAsync.oYg0OAfwFdTcENcRURKJ((object) e, ActionInvokerAsync.OqtnpufwoEjHWVQR8AJ2((object) this.checkMethodInfo, this.entityManager, (object) e.Params.ToArray<object>()));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 8 : 2;
            continue;
          case 2:
            e.Invoked = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 3 : 4;
            continue;
          case 3:
            ActionInvokerAsync.s1X5aDfwB5v0mVfR3W6f((object) e, false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_17;
          case 5:
            ActionInvokerAsync.oYg0OAfwFdTcENcRURKJ((object) e, (object) false);
            num1 = 3;
            continue;
          case 6:
            if (!AttributeHelper<ActionPermissionAttribute>.GetAttributes((MemberInfo) this.targetMethodInfo, false).Any<ActionPermissionAttribute>((Func<ActionPermissionAttribute, bool>) (attr =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (attr == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_2;
                  case 2:
                    goto label_2;
                  default:
                    goto label_3;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              return !ActionInvokerAsync.\u003C\u003Ec.ODTpLDZfvYX4WmuIQgJH((object) attr);
label_3:
              return true;
            })))
            {
              if (!ActionInvokerAsync.NA5GJffwWQIUjsreooCS((object) this.checkMethodInfo, (object) null))
              {
                ActionInvokerAsync.oYg0OAfwFdTcENcRURKJ((object) e, (object) true);
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 2;
                continue;
              }
              num1 = 11;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 5 : 3;
            continue;
          case 7:
            goto label_3;
          case 8:
            ActionInvokerAsync.s1X5aDfwB5v0mVfR3W6f((object) e, true);
            num1 = 9;
            continue;
          case 9:
            nullable = ActionInvokerAsync.td9FgRfwbnqnfQ6aQkUd((object) e) as ActionCheckResult?;
            num1 = 10;
            continue;
          case 10:
            if (nullable.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 7;
              continue;
            }
            goto label_2;
          case 11:
            this.actionDispatcherService.Value.StartMethodInvocation(this.checkMethodInfo, e.Params.ToArray<object>());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
            continue;
          case 12:
            goto label_2;
          default:
            goto label_10;
        }
      }
label_2:
      return new ActionCheckResult((bool) e.Result, (string) null);
label_3:
      return nullable.GetValueOrDefault();
label_10:
      return new ActionCheckResult(false, (string) null);
label_17:
      return new ActionCheckResult(true, (string) null);
    }

    /// <summary>Обработчик проверки возможности выполнения действия</summary>
    /// <param name="e">Аргументы вызова</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат проверки</returns>
    private async Task<ActionCheckResult> CheckHandleAsync(
      ActionInvokeEventArgs e,
      CancellationToken cancellationToken)
    {
      int num1 = 2;
      int num2;
      ActionCheckResult result1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
            continue;
          case 3:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 4;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 5 : 4;
            continue;
          case 5:
            goto label_103;
          default:
            try
            {
              TaskAwaiter<bool> taskAwaiter1;
              ValueTaskAwaiter<bool> valueTaskAwaiter1;
              TaskAwaiter<ActionCheckResult> taskAwaiter2;
              ValueTaskAwaiter<ActionCheckResult> valueTaskAwaiter2;
              TaskAwaiter<bool> awaiter1;
              TaskAwaiter<ActionCheckResult> awaiter2;
              ValueTaskAwaiter<bool> awaiter3;
              ValueTaskAwaiter<ActionCheckResult> awaiter4;
              int num3;
              switch (num2)
              {
                case 0:
label_10:
                  awaiter1 = taskAwaiter1;
                  num3 = 57;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
                  {
                    num3 = 21;
                    break;
                  }
                  break;
                case 1:
label_72:
                  awaiter3 = valueTaskAwaiter1;
                  num3 = 7;
                  break;
                case 2:
label_71:
                  awaiter2 = taskAwaiter2;
                  num3 = 12;
                  break;
                case 3:
label_31:
                  awaiter4 = valueTaskAwaiter2;
                  num3 = 24;
                  break;
                default:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 49 : 29;
                  break;
              }
              while (true)
              {
                ActionInvokeEventArgs actionInvokeEventArgs;
                int num4;
                bool result2;
                ActionCheckResult result3;
                ActionCheckResult? nullable;
                ValueTask<ActionCheckResult> valueTask1;
                ValueTask<bool> valueTask2;
                ActionCheckResult actionCheckResult;
                switch (num3)
                {
                  case 1:
                  case 26:
                  case 35:
                  case 52:
                    // ISSUE: reference to a compiler-generated method
                    ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.YEjSDjZfRF1RE26LCAfE((object) e, true);
                    num3 = 59;
                    continue;
                  case 2:
                    result1 = new ActionCheckResult(true, (string) null);
                    num3 = 5;
                    continue;
                  case 3:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 14 : 7;
                    continue;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.kC6lIyZfIp3yMJmNE2x0((object) actionInvokeEventArgs, (object) result2);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 28 : 19;
                    continue;
                  case 5:
                  case 33:
                  case 79:
                    goto label_3;
                  case 6:
                    if (awaiter2.IsCompleted)
                    {
                      num3 = 56;
                      continue;
                    }
                    goto case 70;
                  case 7:
                    valueTaskAwaiter1 = new ValueTaskAwaiter<bool>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 65 : 33;
                    continue;
                  case 8:
                    taskAwaiter2 = awaiter2;
                    num3 = 11;
                    continue;
                  case 9:
                  case 77:
                    result2 = awaiter3.GetResult();
                    num3 = 23;
                    continue;
                  case 10:
                    // ISSUE: reference to a compiler-generated method
                    ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.kC6lIyZfIp3yMJmNE2x0((object) actionInvokeEventArgs, (object) result3);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 44;
                    continue;
                  case 11:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ActionCheckResult>, ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24>(ref awaiter2, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 42 : 50;
                    continue;
                  case 12:
                    taskAwaiter2 = new TaskAwaiter<ActionCheckResult>();
                    num3 = 54;
                    continue;
                  case 13:
                    this.actionDispatcherService.Value.StartMethodInvocation(this.checkMethodInfo, e.Params.ToArray<object>());
                    num4 = 22;
                    break;
                  case 14:
                  case 64:
                    result2 = awaiter1.GetResult();
                    num3 = 4;
                    continue;
                  case 15:
                    // ISSUE: reference to a compiler-generated method
                    awaiter2 = ((Task<ActionCheckResult>) ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.sae7gIZfikfodZURb7Dh((object) this.checkMethodInfo, this.entityManager, (object) e.Params.ToArray<object>())).GetAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 6 : 3;
                    continue;
                  case 16:
                    goto label_100;
                  case 17:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 47;
                    continue;
                  case 18:
                    goto label_96;
                  case 19:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.RBtSMlZfSQClC1Rftj9D(ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.F6KNOpZfVl1Ptqo4iq5y((object) this.checkMethodInfo), TypeOf<ValueTask<bool>>.Raw))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 45 : 19;
                      continue;
                    }
                    goto case 36;
                  case 20:
                    IList<ActionPermissionAttribute> attributes = AttributeHelper<ActionPermissionAttribute>.GetAttributes((MemberInfo) this.targetMethodInfo, false);
                    // ISSUE: reference to a compiler-generated field
                    Func<ActionPermissionAttribute, bool> func = ActionInvokerAsync.\u003C\u003Ec.\u003C\u003E9__24_0;
                    Func<ActionPermissionAttribute, bool> predicate;
                    if (func == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      ActionInvokerAsync.\u003C\u003Ec.\u003C\u003E9__24_0 = predicate = (Func<ActionPermissionAttribute, bool>) (attr =>
                      {
                        int num5 = 1;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              if (attr == null)
                              {
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                                continue;
                              }
                              goto label_4;
                            case 2:
                              goto label_4;
                            default:
                              goto label_5;
                          }
                        }
label_4:
                        return !attr.CheckPermissionCurrentUser();
label_5:
                        return true;
                      });
                    }
                    else
                      goto label_105;
label_92:
                    if (attributes.Any<ActionPermissionAttribute>(predicate))
                    {
                      num3 = 25;
                      continue;
                    }
                    goto case 61;
label_105:
                    predicate = func;
                    goto label_92;
                  case 21:
                    // ISSUE: reference to a compiler-generated method
                    actionCheckResult = new ActionCheckResult((bool) ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.xOERgFZfqJZsuNI1ThCe((object) e), (string) null);
                    goto label_95;
                  case 22:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.RBtSMlZfSQClC1Rftj9D(ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.F6KNOpZfVl1Ptqo4iq5y((object) this.checkMethodInfo), TypeOf<Task<bool>>.Raw))
                    {
                      num4 = 29;
                      break;
                    }
                    goto case 19;
                  case 23:
                    actionInvokeEventArgs.Result = (object) result2;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 76 : 43;
                    continue;
                  case 24:
                    valueTaskAwaiter2 = new ValueTaskAwaiter<ActionCheckResult>();
                    num3 = 17;
                    continue;
                  case 25:
                    // ISSUE: reference to a compiler-generated method
                    ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.kC6lIyZfIp3yMJmNE2x0((object) e, (object) false);
                    num3 = 32;
                    continue;
                  case 27:
                    valueTaskAwaiter1 = awaiter3;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 18 : 42;
                    continue;
                  case 28:
                    actionInvokeEventArgs = (ActionInvokeEventArgs) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
                    continue;
                  case 29:
                    actionInvokeEventArgs = e;
                    num3 = 55;
                    continue;
                  case 30:
                  case 47:
                    result3 = awaiter4.GetResult();
                    num3 = 10;
                    continue;
                  case 31:
                    valueTaskAwaiter2 = awaiter4;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 40;
                    continue;
                  case 32:
                    e.Invoked = false;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                    continue;
                  case 34:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 3;
                    num3 = 31;
                    continue;
                  case 36:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.RBtSMlZfSQClC1Rftj9D(ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.F6KNOpZfVl1Ptqo4iq5y((object) this.checkMethodInfo), TypeOf<Task<ActionCheckResult>>.Raw))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 71 : 71;
                      continue;
                    }
                    goto case 60;
                  case 37:
                    goto label_10;
                  case 38:
                    // ISSUE: reference to a compiler-generated method
                    valueTask1 = (ValueTask<ActionCheckResult>) ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.sae7gIZfikfodZURb7Dh((object) this.checkMethodInfo, this.entityManager, (object) e.Params.ToArray<object>());
                    num3 = 41;
                    continue;
                  case 39:
                    goto label_90;
                  case 40:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<ActionCheckResult>, ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24>(ref awaiter4, this);
                    num3 = 18;
                    continue;
                  case 41:
                    awaiter4 = valueTask1.GetAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 16 : 80;
                    continue;
                  case 42:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24>(ref awaiter3, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 16;
                    continue;
                  case 43:
                    taskAwaiter1 = awaiter1;
                    num3 = 75;
                    continue;
                  case 44:
                    actionInvokeEventArgs = (ActionInvokeEventArgs) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 52 : 43;
                    continue;
                  case 45:
                    actionInvokeEventArgs = e;
                    num4 = 81;
                    break;
                  case 46:
                    if (awaiter1.IsCompleted)
                    {
                      num3 = 64;
                      continue;
                    }
                    goto case 66;
                  case 48:
                    goto label_72;
                  case 49:
                    cancellationToken.ThrowIfCancellationRequested();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 14 : 20;
                    continue;
                  case 50:
                    goto label_84;
                  case 51:
                    if (nullable.HasValue)
                    {
                      num3 = 67;
                      continue;
                    }
                    goto case 21;
                  case 53:
                    goto label_71;
                  case 54:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 20 : 63;
                    continue;
                  case 55:
                    awaiter1 = ((Task<bool>) this.checkMethodInfo.Invoke(this.entityManager, e.Params.ToArray<object>())).GetAwaiter();
                    num3 = 46;
                    continue;
                  case 56:
                  case 63:
                    result3 = awaiter2.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 69 : 8;
                    continue;
                  case 57:
                    taskAwaiter1 = new TaskAwaiter<bool>();
                    num3 = 3;
                    continue;
                  case 58:
                    awaiter3 = valueTask2.GetAwaiter();
                    num3 = 74;
                    continue;
                  case 59:
                    // ISSUE: reference to a compiler-generated method
                    nullable = ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.xOERgFZfqJZsuNI1ThCe((object) e) as ActionCheckResult?;
                    num3 = 51;
                    continue;
                  case 60:
                    actionInvokeEventArgs = e;
                    num3 = 38;
                    continue;
                  case 61:
                    if (this.checkMethodInfo != (MethodInfo) null)
                    {
                      num3 = 13;
                      continue;
                    }
                    goto case 62;
                  case 62:
                    // ISSUE: reference to a compiler-generated method
                    ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.kC6lIyZfIp3yMJmNE2x0((object) e, (object) true);
                    num3 = 73;
                    continue;
                  case 65:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 77;
                    continue;
                  case 66:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 43;
                    continue;
                  case 67:
                    actionCheckResult = nullable.GetValueOrDefault();
                    goto label_95;
                  case 68:
                    goto label_31;
                  case 69:
                    // ISSUE: reference to a compiler-generated method
                    ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.kC6lIyZfIp3yMJmNE2x0((object) actionInvokeEventArgs, (object) result3);
                    num3 = 72;
                    continue;
                  case 70:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 2;
                    num3 = 8;
                    continue;
                  case 71:
                    actionInvokeEventArgs = e;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 15 : 2;
                    continue;
                  case 72:
                    actionInvokeEventArgs = (ActionInvokeEventArgs) null;
                    num3 = 35;
                    continue;
                  case 73:
                    // ISSUE: reference to a compiler-generated method
                    ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.YEjSDjZfRF1RE26LCAfE((object) e, false);
                    num4 = 2;
                    break;
                  case 74:
                    if (awaiter3.IsCompleted)
                    {
                      num3 = 9;
                      continue;
                    }
                    goto case 78;
                  case 75:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24>(ref awaiter1, this);
                    num3 = 39;
                    continue;
                  case 76:
                    actionInvokeEventArgs = (ActionInvokeEventArgs) null;
                    num4 = 26;
                    break;
                  case 78:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = 27;
                    continue;
                  case 80:
                    if (awaiter4.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 30 : 1;
                      continue;
                    }
                    goto case 34;
                  case 81:
                    // ISSUE: reference to a compiler-generated method
                    valueTask2 = (ValueTask<bool>) ActionInvokerAsync.\u003CCheckHandleAsync\u003Ed__24.sae7gIZfikfodZURb7Dh((object) this.checkMethodInfo, this.entityManager, (object) e.Params.ToArray<object>());
                    num3 = 58;
                    continue;
                  default:
                    result1 = new ActionCheckResult(false, (string) null);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 13 : 33;
                    continue;
                }
                num3 = num4;
                continue;
label_95:
                result1 = actionCheckResult;
                num3 = 79;
              }
label_100:
              return;
label_96:
              return;
label_90:
              return;
label_84:
              return;
            }
            catch (Exception ex)
            {
              int num6 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
                num6 = 1;
              while (true)
              {
                switch (num6)
                {
                  case 0:
                    goto label_65;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 1;
                    continue;
                  default:
                    goto label_54;
                }
              }
label_65:
              return;
label_54:
              return;
            }
        }
      }
label_103:;
    }

    /// <summary>Обработчик выполнения действия</summary>
    /// <param name="e">Аргументы вызова</param>
    /// <returns>Результат выполнения</returns>
    private object ActionHandle(ActionInvokeEventArgs e)
    {
      int num1 = 2;
      IEnumerator<ActionPermissionAttribute> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
label_18:
              if (ActionInvokerAsync.rjtHH0fwQ8Gb8Tkt8bnN((object) enumerator))
                goto label_20;
              else
                goto label_19;
label_16:
              ActionPermissionAttribute current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_31;
                  case 2:
                    goto label_18;
                  case 3:
                    if (ActionInvokerAsync.R38LD8fwh4G7tasT6je5((object) current))
                    {
                      num2 = 2;
                      continue;
                    }
                    goto label_17;
                  case 4:
                    goto label_17;
                  default:
                    goto label_20;
                }
              }
label_17:
              throw new SecurityException(EleWise.ELMA.SR.T((string) ActionInvokerAsync.cdGbHGfwG7C1dDtamwC8(1505778440 - 1981636111 ^ -475553037), ActionInvokerAsync.p8aVvsfwf4TMWR2rxMy8(ActionInvokerAsync.LbcTKvfwEXt5Z1tkTvFE((object) current))));
label_19:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
              goto label_16;
label_20:
              current = enumerator.Current;
              num2 = 3;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
              {
                num2 = 3;
                goto label_16;
              }
              else
                goto label_16;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              else
                goto label_27;
label_26:
              switch (num3)
              {
                case 1:
                  break;
                default:
              }
label_27:
              ActionInvokerAsync.KkqDq4fwCYjewTDxI6xa((object) enumerator);
              num3 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
              {
                num3 = 2;
                goto label_26;
              }
              else
                goto label_26;
            }
          case 2:
            enumerator = AttributeHelper<ActionPermissionAttribute>.GetAttributes((MemberInfo) this.targetMethodInfo, false).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
            continue;
          case 3:
label_31:
            this.actionDispatcherService.Value.StartMethodInvocation(this.targetMethodInfo, e.Params.ToArray<object>());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      object result;
      return result;
label_3:
      try
      {
        ActionInvokerAsync.oYg0OAfwFdTcENcRURKJ((object) e, this.targetMethodInfo.Invoke(this.entityManager, e.Params.ToArray<object>()));
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_2;
            case 2:
              result = e.Result;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
              continue;
            default:
              ActionInvokerAsync.s1X5aDfwB5v0mVfR3W6f((object) e, true);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 2;
              continue;
          }
        }
      }
      catch (TargetInvocationException ex)
      {
        int num5 = 2;
        while (true)
        {
          switch (num5)
          {
            case 1:
              ActionInvokerAsync.ufmCCrftzXWdunpIKLiV(ActionInvokerAsync.UIbnUoftcVIwLoyoUsU3(ActionInvokerAsync.q5iG3MftsyuDywJUVZ2g((object) ex)));
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            case 2:
              if (ex.InnerException != null)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
                continue;
              }
              goto label_14;
            default:
              goto label_14;
          }
        }
label_14:
        throw;
      }
    }

    /// <summary>Обработчик выполнения действия</summary>
    /// <param name="e">Аргументы вызова</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат выполнения</returns>
    private async Task<object> ActionHandleAsync(
      ActionInvokeEventArgs e,
      CancellationToken cancellationToken)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        int num3;
        object result1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_98;
            case 1:
              goto label_5;
            case 2:
              goto label_4;
            case 3:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
              continue;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
              continue;
            case 5:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num3 = (^this).\u003C\u003E1__state;
              num2 = 4;
              continue;
            default:
              goto label_95;
          }
        }
label_4:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 3;
        continue;
label_5:
        try
        {
          TaskAwaiter taskAwaiter1;
          ValueTaskAwaiter valueTaskAwaiter1;
          TaskAwaiter<object> taskAwaiter2;
          ValueTaskAwaiter<object> valueTaskAwaiter2;
          ValueTaskAwaiter<object> awaiter1;
          TaskAwaiter<object> awaiter2;
          ValueTaskAwaiter awaiter3;
          TaskAwaiter awaiter4;
          int num4;
          switch (num3)
          {
            case 0:
label_63:
              awaiter4 = taskAwaiter1;
              num4 = 12;
              break;
            case 1:
label_49:
              awaiter3 = valueTaskAwaiter1;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 59 : 38;
              break;
            case 2:
label_20:
              awaiter2 = taskAwaiter2;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 51 : 24;
              break;
            case 3:
label_57:
              awaiter1 = valueTaskAwaiter2;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 18 : 11;
              break;
            default:
              num4 = 6;
              break;
          }
          while (true)
          {
            ActionInvokeEventArgs actionInvokeEventArgs;
            int num5;
            IEnumerator<ActionPermissionAttribute> enumerator;
            ValueTask<object> valueTask1;
            object result2;
            ValueTask valueTask2;
            switch (num4)
            {
              case 1:
              case 4:
                awaiter4.GetResult();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 2 : 55;
                continue;
              case 2:
                goto label_4;
              case 3:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = 2;
                num4 = 11;
                continue;
              case 5:
                goto label_91;
              case 6:
                cancellationToken.ThrowIfCancellationRequested();
                num4 = 58;
                continue;
              case 7:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26>(ref awaiter4, this);
                num4 = 5;
                continue;
              case 8:
                valueTask1 = this.targetMethodInfo.InvokeValueFunctionAsync(this.entityManager, e.Params.ToArray<object>());
                num4 = 66;
                continue;
              case 9:
              case 20:
              case 28:
              case 53:
                // ISSUE: reference to a compiler-generated method
                ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.X241WHZfpbfOfYhIEKsj((object) e, true);
                num4 = 15;
                continue;
              case 10:
                // ISSUE: reference to a compiler-generated method
                ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.ukVpuTZfNI2IY3I8y4FP((object) actionInvokeEventArgs, result2);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 57 : 44;
                continue;
              case 11:
                taskAwaiter2 = awaiter2;
                num5 = 19;
                break;
              case 12:
                taskAwaiter1 = new TaskAwaiter();
                num5 = 62;
                break;
              case 13:
                goto label_20;
              case 14:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = 0;
                num4 = 25;
                continue;
              case 15:
                // ISSUE: reference to a compiler-generated method
                result1 = ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.LWbCXOZfaaA6ipnmnNUY((object) e);
                num4 = 2;
                continue;
              case 16:
                // ISSUE: reference to a compiler-generated method
                ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.ukVpuTZfNI2IY3I8y4FP((object) e, (object) null);
                num4 = 20;
                continue;
              case 17:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = -1;
                num4 = 42;
                continue;
              case 18:
                valueTaskAwaiter2 = new ValueTaskAwaiter<object>();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 17 : 9;
                continue;
              case 19:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26>(ref awaiter2, this);
                num4 = 43;
                continue;
              case 21:
                awaiter2 = this.targetMethodInfo.InvokeFunctionAsync(this.entityManager, e.Params.ToArray<object>()).GetAwaiter();
                num4 = 38;
                continue;
              case 22:
                awaiter4 = this.targetMethodInfo.InvokeActionAsync(this.entityManager, e.Params.ToArray<object>()).GetAwaiter();
                num4 = 37;
                continue;
              case 23:
              case 40:
                actionInvokeEventArgs = e;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 8 : 4;
                continue;
              case 24:
                goto label_88;
              case 25:
                taskAwaiter1 = awaiter4;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 7 : 2;
                continue;
              case 26:
              case 42:
                result2 = awaiter1.GetResult();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 10 : 9;
                continue;
              case 27:
                goto label_83;
              case 29:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.VxjIvJZf1V7Qamh9QPoZ(ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.iRO8TXZfPMvfRJ6DkfSO((object) this.targetMethodInfo).GetGenericTypeDefinition(), ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.sjhfnFZf3O4chRwTgrw3((object) TypeOf.Task1)))
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 31 : 40;
                  continue;
                }
                goto case 65;
              case 30:
                valueTaskAwaiter2 = awaiter1;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 39 : 9;
                continue;
              case 31:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26>(ref awaiter3, this);
                num5 = 27;
                break;
              case 32:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = 1;
                num4 = 44;
                continue;
              case 33:
                goto label_63;
              case 34:
                // ISSUE: reference to a compiler-generated method
                if (ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.iRO8TXZfPMvfRJ6DkfSO((object) this.targetMethodInfo) == TypeOf<ValueTask>.Raw)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 41;
                  continue;
                }
                goto case 29;
              case 35:
                awaiter3 = valueTask2.GetAwaiter();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 23 : 61;
                continue;
              case 36:
label_55:
                this.actionDispatcherService.Value.StartMethodInvocation(this.targetMethodInfo, e.Params.ToArray<object>());
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 5 : 50;
                continue;
              case 37:
                if (awaiter4.IsCompleted)
                {
                  num4 = 4;
                  continue;
                }
                goto case 14;
              case 38:
                if (!awaiter2.IsCompleted)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 3;
                  continue;
                }
                goto case 45;
              case 39:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<object>, ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26>(ref awaiter1, this);
                num4 = 24;
                continue;
              case 41:
                valueTask2 = this.targetMethodInfo.InvokeValueActionAsync(this.entityManager, e.Params.ToArray<object>());
                num4 = 35;
                continue;
              case 43:
                goto label_74;
              case 44:
                valueTaskAwaiter1 = awaiter3;
                num4 = 31;
                continue;
              case 45:
                result2 = awaiter2.GetResult();
                num5 = 54;
                break;
              case 46:
                goto label_57;
              case 47:
                if (awaiter1.IsCompleted)
                {
                  num4 = 26;
                  continue;
                }
                goto case 60;
              case 48:
                try
                {
label_25:
                  // ISSUE: reference to a compiler-generated method
                  if (ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.M2Qg11Zf2UkWOoLOYZ3Z((object) enumerator))
                    goto label_23;
                  else
                    goto label_26;
label_22:
                  ActionPermissionAttribute current;
                  int num6;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        goto label_25;
                      case 2:
                        if (current.CheckPermissionCurrentUser())
                        {
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
                          continue;
                        }
                        goto label_24;
                      case 3:
                        goto label_55;
                      case 4:
                        goto label_24;
                      default:
                        goto label_23;
                    }
                  }
label_24:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  throw new SecurityException(EleWise.ELMA.SR.T((string) ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.RyT3rkZfkf625UrEQu22(993438473 ^ 993260803), ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.uJfoEyZfOo7UdVC9N4St(ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.XvFtvjZfnr840hW7BlKm((object) current))));
label_23:
                  current = enumerator.Current;
                  num6 = 2;
                  goto label_22;
label_26:
                  num6 = 3;
                  goto label_22;
                }
                finally
                {
                  int num7;
                  if (num3 >= 0)
                    num7 = 2;
                  else
                    goto label_33;
label_31:
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_33;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.n4t6qiZfeT4rQdL1TTYW((object) enumerator);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_36;
                    }
                  }
label_33:
                  if (enumerator != null)
                  {
                    num7 = 3;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                    {
                      num7 = 2;
                      goto label_31;
                    }
                    else
                      goto label_31;
                  }
label_36:;
                }
              case 49:
                goto label_49;
              case 50:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.VxjIvJZf1V7Qamh9QPoZ(ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.iRO8TXZfPMvfRJ6DkfSO((object) this.targetMethodInfo), TypeOf<Task>.Raw))
                {
                  num4 = 22;
                  continue;
                }
                goto case 34;
              case 51:
                taskAwaiter2 = new TaskAwaiter<object>();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                continue;
              case 52:
              case 63:
                awaiter3.GetResult();
                num4 = 16;
                continue;
              case 54:
                // ISSUE: reference to a compiler-generated method
                ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.ukVpuTZfNI2IY3I8y4FP((object) actionInvokeEventArgs, result2);
                num4 = 56;
                continue;
              case 55:
                // ISSUE: reference to a compiler-generated method
                ActionInvokerAsync.\u003CActionHandleAsync\u003Ed__26.ukVpuTZfNI2IY3I8y4FP((object) e, (object) null);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 6 : 53;
                continue;
              case 56:
                actionInvokeEventArgs = (ActionInvokeEventArgs) null;
                num4 = 28;
                continue;
              case 57:
                actionInvokeEventArgs = (ActionInvokeEventArgs) null;
                num5 = 9;
                break;
              case 58:
                enumerator = AttributeHelper<ActionPermissionAttribute>.GetAttributes((MemberInfo) this.targetMethodInfo, false).GetEnumerator();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 48 : 13;
                continue;
              case 59:
                valueTaskAwaiter1 = new ValueTaskAwaiter();
                num4 = 64;
                continue;
              case 60:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = 3;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 30 : 29;
                continue;
              case 61:
                if (awaiter3.IsCompleted)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 52 : 36;
                  continue;
                }
                goto case 32;
              case 62:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = -1;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
                continue;
              case 64:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = -1;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 32 : 63;
                continue;
              case 65:
                actionInvokeEventArgs = e;
                num4 = 21;
                continue;
              case 66:
                awaiter1 = valueTask1.GetAwaiter();
                num4 = 47;
                continue;
              default:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = -1;
                num4 = 45;
                continue;
            }
            num4 = num5;
          }
label_91:
          return;
label_88:
          return;
label_83:
          return;
label_74:
          return;
        }
        catch (Exception ex)
        {
          int num8 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 0:
                goto label_68;
              case 1:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = -2;
                num8 = 2;
                continue;
              case 2:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.SetException(ex);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              default:
                goto label_67;
            }
          }
label_68:
          return;
label_67:
          return;
        }
      }
label_98:
      return;
label_95:;
    }

    internal static bool kehb03ftYvIZC3nOkNuD() => ActionInvokerAsync.BwLiu5ftjwfSVal36NQF == null;

    internal static ActionInvokerAsync VJBnneftLfxpM1jyYXK0() => ActionInvokerAsync.BwLiu5ftjwfSVal36NQF;

    internal static ActionCheckResult BN6fO9ftUPoa4T4yH0Wu() => ActionCheckResult.True;

    internal static object q5iG3MftsyuDywJUVZ2g([In] object obj0) => (object) ((Exception) obj0).InnerException;

    internal static object UIbnUoftcVIwLoyoUsU3([In] object obj0) => (object) ExceptionDispatchInfo.Capture((Exception) obj0);

    internal static void ufmCCrftzXWdunpIKLiV([In] object obj0) => ((ExceptionDispatchInfo) obj0).Throw();

    internal static void oYg0OAfwFdTcENcRURKJ([In] object obj0, [In] object obj1) => ((ActionInvokeEventArgs) obj0).Result = obj1;

    internal static void s1X5aDfwB5v0mVfR3W6f([In] object obj0, bool value) => ((ActionInvokeEventArgs) obj0).Invoked = value;

    internal static bool NA5GJffwWQIUjsreooCS([In] object obj0, [In] object obj1) => (MethodInfo) obj0 != (MethodInfo) obj1;

    internal static object OqtnpufwoEjHWVQR8AJ2([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static object td9FgRfwbnqnfQ6aQkUd([In] object obj0) => ((ActionInvokeEventArgs) obj0).Result;

    internal static bool R38LD8fwh4G7tasT6je5([In] object obj0) => ((ActionPermissionAttribute) obj0).CheckPermissionCurrentUser();

    internal static object cdGbHGfwG7C1dDtamwC8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object LbcTKvfwEXt5Z1tkTvFE([In] object obj0) => (object) ((ActionPermissionAttribute) obj0).Permission;

    internal static object p8aVvsfwf4TMWR2rxMy8([In] object obj0) => (object) ((Permission) obj0).Name;

    internal static bool rjtHH0fwQ8Gb8Tkt8bnN([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void KkqDq4fwCYjewTDxI6xa([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
