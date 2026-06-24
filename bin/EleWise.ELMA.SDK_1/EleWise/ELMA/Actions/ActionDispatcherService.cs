// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionDispatcherService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Actions
{
  /// <summary>Сервис работы с действиями в системе</summary>
  [Service(EnableInterceptors = false)]
  public sealed class ActionDispatcherService
  {
    private readonly IEnumerable<IActionInvokerProvider> actionProviders;
    /// <summary>
    /// Кэш исполнителей действий по 3-м ключам: ActionObjectUid, ActionTypeUid, IsAsync действия
    /// </summary>
    private readonly IDictionary<Guid, IDictionary<Guid, ActionDispatcherService.Invokers>> actionTypeObjectMap;
    /// <summary>
    /// Набор ActionObjectUid, который нежно обновить в кэше при завершении дельта-публикации (по умолчанию null - полностью собрать кэш)
    /// </summary>
    private ISet<Guid> toInitialize;
    internal static ActionDispatcherService pRjBRaftfOWJlp0PqDCY;

    /// <summary>Конструктор</summary>
    /// <param name="actionProviders"></param>
    public ActionDispatcherService(
      IEnumerable<IActionInvokerProvider> actionProviders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.actionTypeObjectMap = PublishCacheContext.CreateCache<Guid, IDictionary<Guid, ActionDispatcherService.Invokers>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) actionProviders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418655382));
      this.actionProviders = actionProviders;
    }

    private void Initialize()
    {
      int num1 = 2;
      ActionDispatcherService dispatcherService;
      bool lockTaken;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            num2 = 0;
            break;
          case 2:
            ISet<Guid> toInitialize = this.toInitialize;
            if (toInitialize == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
              continue;
            }
            num2 = ActionDispatcherService.VEyJVxftv1BdqcPWA24n((object) toInitialize) == 0 ? 1 : 0;
            break;
          case 3:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_47;
          case 5:
            goto label_51;
          default:
            goto label_2;
        }
        if (num2 == 0)
        {
          dispatcherService = this;
          num1 = 3;
        }
        else
          num1 = 4;
      }
label_47:
      return;
label_51:
      return;
label_2:
      try
      {
        Monitor.Enter((object) dispatcherService, ref lockTaken);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
          num3 = 0;
        while (true)
        {
          int num4;
          switch (num3)
          {
            case 1:
              goto label_45;
            case 2:
              num4 = 0;
              break;
            case 3:
              goto label_13;
            case 4:
label_6:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 3 : 0;
              continue;
            default:
              ISet<Guid> toInitialize = this.toInitialize;
              if (toInitialize == null)
              {
                num3 = 2;
                continue;
              }
              num4 = toInitialize.Count == 0 ? 1 : 0;
              break;
          }
          if (num4 != 0)
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
          else
            goto label_6;
        }
label_45:
        return;
label_13:
        try
        {
          IEnumerable<IActionInvokerProvider> actionProviders = this.actionProviders;
          // ISSUE: reference to a compiler-generated field
          Func<IActionInvokerProvider, IEnumerable<IActionInvoker>> func = ActionDispatcherService.\u003C\u003Ec.\u003C\u003E9__4_0;
          Func<IActionInvokerProvider, IEnumerable<IActionInvoker>> selector;
          if (func == null)
          {
            // ISSUE: reference to a compiler-generated field
            ActionDispatcherService.\u003C\u003Ec.\u003C\u003E9__4_0 = selector = (Func<IActionInvokerProvider, IEnumerable<IActionInvoker>>) (p => p.GetInvokers());
          }
          else
            goto label_57;
label_15:
          IEnumerable<IActionInvoker> actionInvokers = actionProviders.SelectMany<IActionInvokerProvider, IActionInvoker>(selector);
          int num5 = 8;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                this.InitializeInvokers(actionInvokers);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 4 : 0;
                continue;
              case 3:
                goto label_42;
              case 4:
                if (this.toInitialize != null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                  continue;
                }
                goto case 6;
              case 5:
                goto label_38;
              case 6:
                this.toInitialize = PublishCacheContext.CreateCache<Guid>();
                num5 = 5;
                continue;
              case 7:
                actionInvokers = actionInvokers.Where<IActionInvoker>((Func<IActionInvoker, bool>) (i => this.toInitialize.Contains(i.ActionObject.Uid)));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 1;
                continue;
              case 8:
                if (this.toInitialize != null)
                {
                  num5 = 7;
                  continue;
                }
                goto case 1;
              default:
                ActionDispatcherService.cRe7p9ft8xesBPIEwTjg((object) this.toInitialize);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 3 : 0;
                continue;
            }
          }
label_42:
          return;
label_38:
          return;
label_57:
          selector = func;
          goto label_15;
        }
        catch (Exception ex)
        {
          int num6 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 0:
                goto label_32;
              case 1:
                ActionDispatcherService.KfYVnlftu8YtLPDLkZqm(ActionDispatcherService.UhMM1uftZhXuQe5lRoif(), (object) ex);
                num6 = 2;
                continue;
              case 2:
                ActionDispatcherService.jjCgHEftIIBEmg7IsY8L((object) this.actionTypeObjectMap);
                num6 = 5;
                continue;
              case 3:
                this.InitializeInvokers(this.actionProviders.SelectMany<IActionInvokerProvider, IActionInvoker>((Func<IActionInvokerProvider, IEnumerable<IActionInvoker>>) (p => p.GetInvokers())));
                num6 = 4;
                continue;
              case 4:
                ActionDispatcherService.cRe7p9ft8xesBPIEwTjg((object) this.toInitialize);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                continue;
              case 5:
                if (this.toInitialize != null)
                {
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 3 : 2;
                  continue;
                }
                goto label_36;
              case 6:
                goto label_36;
              default:
                goto label_29;
            }
          }
label_32:
          return;
label_29:
          return;
label_36:
          throw;
        }
      }
      finally
      {
        int num7;
        if (!lockTaken)
          num7 = 2;
        else
          goto label_43;
label_41:
        switch (num7)
        {
          case 1:
          case 2:
        }
label_43:
        ActionDispatcherService.xtYtBnftVuIaBYLKcvWB((object) dispatcherService);
        num7 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        {
          num7 = 0;
          goto label_41;
        }
        else
          goto label_41;
      }
    }

    private void InitializeInvokers(IEnumerable<IActionInvoker> invokers)
    {
      foreach (IActionInvoker invoker in invokers)
      {
        IDictionary<Guid, ActionDispatcherService.Invokers> orAdd = this.actionTypeObjectMap.GetOrAdd<Guid, IDictionary<Guid, ActionDispatcherService.Invokers>>(invoker.ActionObject.Uid, (Func<Guid, IDictionary<Guid, ActionDispatcherService.Invokers>>) (_ => (IDictionary<Guid, ActionDispatcherService.Invokers>) new Dictionary<Guid, ActionDispatcherService.Invokers>()));
        ActionDispatcherService.Invokers invokers1;
        if (!orAdd.TryGetValue(invoker.ActionType.Uid, out invokers1))
          orAdd.Add(invoker.ActionType.Uid, invokers1 = new ActionDispatcherService.Invokers());
        try
        {
          invokers1[invoker.MethodMetadata.ResultArgument.ArgumentType.IsAsync()] = invoker;
        }
        catch (ArgumentException ex)
        {
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643448377), (object) invoker.ActionType.DisplayName, (object) invoker.ActionObject.DisplayName));
        }
      }
    }

    private IActionInvoker GetInvoker(Guid actionUid, Guid objectUid, bool isAsync)
    {
      int num = 4;
      ActionDispatcherService.Invokers invokers;
      IDictionary<Guid, ActionDispatcherService.Invokers> dictionary;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!dictionary.TryGetValue(actionUid, out invokers))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 3:
            if (!this.actionTypeObjectMap.TryGetValue(objectUid, out dictionary))
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 4:
            this.Initialize();
            num = 3;
            continue;
          case 5:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      return (IActionInvoker) ActionDispatcherService.fFZ35HftSEWmmAivrpbG((object) invokers, isAsync);
label_4:
      return (IActionInvoker) null;
    }

    private ActionInvokeEventArgs GetEventArgs(
      IAuditAction actionType,
      IAuditObject actionObject,
      params object[] methodArgs)
    {
      ActionInvokeEventArgs eventArgs = new ActionInvokeEventArgs();
      ActionDispatcherService.VYjIOiftiHq0pBmLsrp2((object) eventArgs, (object) actionType);
      eventArgs.Object = actionObject;
      eventArgs.Params = (ICollection<object>) ((IEnumerable<object>) methodArgs).ToList<object>();
      return eventArgs;
    }

    internal static string GetKey([NotNull] MethodInfo methodInfo, params object[] methodArgs)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ActionDispatcherService.TwFHLIftRfXmabp2LuNH((object) methodInfo, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      throw new ArgumentNullException((string) ActionDispatcherService.UHVfyeftquEvXN29hEc9(-1350312861 << 3 ^ 2082192292));
label_5:
      object obj = ActionDispatcherService.UHVfyeftquEvXN29hEc9(-2099751081 ^ -2099441789);
      string fullName = methodInfo.DeclaringType.FullName;
      string name = methodInfo.Name;
      object source = ActionDispatcherService.iPDlZNftKWyaKJ8IHirM((object) methodInfo);
      // ISSUE: reference to a compiler-generated field
      Func<ParameterInfo, string> func = ActionDispatcherService.\u003C\u003Ec.\u003C\u003E9__8_0;
      Func<ParameterInfo, string> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        ActionDispatcherService.\u003C\u003Ec.\u003C\u003E9__8_0 = selector = (Func<ParameterInfo, string>) (p => ActionDispatcherService.\u003C\u003Ec.bMbtnIZEdLgMe5eE7gMQ((object) p).FullName);
      }
      else
        goto label_6;
label_8:
      string separatedString = ((IEnumerable<ParameterInfo>) source).Select<ParameterInfo, string>(selector).ToSeparatedString<string>((string) ActionDispatcherService.UHVfyeftquEvXN29hEc9(-675505729 ^ -675506755));
      return (string) ActionDispatcherService.MYtXYJftXnRu8pVjQoXW(obj, (object) fullName, (object) name, (object) separatedString);
label_6:
      selector = func;
      goto label_8;
    }

    /// <summary>
    /// Проверка возможности выполнения действия.
    /// Нет необходимости вызывать перед выполнением.
    /// </summary>
    /// <param name="actionObject">Объект действия</param>
    /// <param name="actionType">Тип действия</param>
    /// <param name="methodArgs">Аргументы, передаваемые в действие</param>
    /// <returns>Можно ли выполнять действие в данном контексте</returns>
    public ActionCheckResult CheckAction(
      IAuditObject actionObject,
      IAuditAction actionType,
      params object[] methodArgs)
    {
      int num = 1;
      IActionInvoker invoker;
      while (true)
      {
        switch (num)
        {
          case 1:
            ActionDispatcherService.A8mnekftTxL2dLh2gqEv((object) actionObject, ActionDispatcherService.UHVfyeftquEvXN29hEc9(-1204263869 ^ -1341583247 ^ 137637058));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            invoker = this.GetInvoker(ActionDispatcherService.sgm1aCftkampsG6LbnmT((object) actionType), actionObject.Uid, false);
            if (invoker == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 2;
              continue;
            }
            goto label_7;
          default:
            ActionDispatcherService.A8mnekftTxL2dLh2gqEv((object) actionType, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1916951430));
            num = 3;
            continue;
        }
      }
label_6:
      return ActionDispatcherService.KN2CxfftnJtVLqZj1hBN(ActionDispatcherService.UHVfyeftquEvXN29hEc9(-1822890472 ^ -1822572740));
label_7:
      return ActionDispatcherService.waFw9jftOW5bRMpLdNrF((object) invoker, (object) this.GetEventArgs(actionType, actionObject, methodArgs));
    }

    /// <summary>Асинхронная проверка возможности выполнения действия</summary>
    /// <param name="actionObject">Объект действия</param>
    /// <param name="actionType">Тип действия</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <param name="methodArgs">Аргументы, передаваемые в действие</param>
    /// <returns>Результат проверки возможности выполнения действия</returns>
    public async Task<ActionCheckResult> CheckActionAsync(
      IAuditObject actionObject,
      IAuditAction actionType,
      CancellationToken cancellationToken,
      params object[] methodArgs)
    {
      int num1 = 1;
      int num2;
      ActionCheckResult result;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_32;
          case 3:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 2;
              else
                goto label_17;
label_7:
              TaskAwaiter<ActionCheckResult> taskAwaiter;
              TaskAwaiter<ActionCheckResult> awaiter;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    result = ActionDispatcherService.\u003CCheckActionAsync\u003Ed__10.uMaGigZEUnMRpjSDjkbM(ActionDispatcherService.\u003CCheckActionAsync\u003Ed__10.U3vYopZEjmhfsARLDyaS(-53329496 >> 4 ^ -3637954));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 13 : 3;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    ActionDispatcherService.\u003CCheckActionAsync\u003Ed__10.VsBw4uZE56XnmZLt8IgY((object) actionObject, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345238220));
                    num3 = 7;
                    continue;
                  case 4:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 9 : 7;
                    continue;
                  case 5:
                    awaiter = invoker.CheckActionAsync(this.GetEventArgs(actionType, actionObject, methodArgs), cancellationToken).GetAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 4 : 12;
                    continue;
                  case 6:
                    result = awaiter.GetResult();
                    num3 = 17;
                    continue;
                  case 7:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ActionDispatcherService.\u003CCheckActionAsync\u003Ed__10.VsBw4uZE56XnmZLt8IgY((object) actionType, ActionDispatcherService.\u003CCheckActionAsync\u003Ed__10.U3vYopZEjmhfsARLDyaS(132912447 ^ 132729907));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                    continue;
                  case 8:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 4 : 6;
                    continue;
                  case 9:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ActionCheckResult>, ActionDispatcherService.\u003CCheckActionAsync\u003Ed__10>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 15 : 7;
                    continue;
                  case 10:
                    goto label_17;
                  case 11:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (!(this.GetInvoker(ActionDispatcherService.\u003CCheckActionAsync\u003Ed__10.TaEarCZEYHnGyUdb6NQ9((object) actionType), ActionDispatcherService.\u003CCheckActionAsync\u003Ed__10.hpIcmmZELhjl3ZwnxJmC((object) actionObject), true) is IActionInvokerAsync invoker))
                    {
                      num3 = 3;
                      continue;
                    }
                    goto case 5;
                  case 12:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = 16;
                      continue;
                    }
                    goto case 6;
                  case 13:
                  case 17:
                    goto label_33;
                  case 14:
                    taskAwaiter = new TaskAwaiter<ActionCheckResult>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 8;
                    continue;
                  case 15:
                    goto label_29;
                  case 16:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 4 : 4;
                    continue;
                  default:
                    cancellationToken.ThrowIfCancellationRequested();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 11 : 10;
                    continue;
                }
              }
label_29:
              return;
label_17:
              awaiter = taskAwaiter;
              num3 = 14;
              goto label_7;
            }
            catch (Exception ex)
            {
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_25;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_21;
                }
              }
label_25:
              return;
label_21:
              return;
            }
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 0;
            continue;
          case 5:
label_33:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 4 : 4;
            continue;
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 3;
            continue;
        }
      }
label_32:;
    }

    /// <summary>Выполнить действие (будет произведена проверка)</summary>
    /// <param name="actionObject">Объект действия</param>
    /// <param name="actionType">Тип действия</param>
    /// <param name="methodArgs">Аргументы, передаваемые в действие</param>
    /// <returns>Результат выполнения действия</returns>
    /// <exception cref="T:System.InvalidOperationException">Если CheckAction вернет false</exception>
    public object InvokeAction(
      [NotNull] IAuditObject actionObject,
      [NotNull] IAuditAction actionType,
      params object[] methodArgs)
    {
      int num1 = 4;
      ActionCheckResult actionCheckResult;
      IActionInvoker invoker;
      string argsString;
      while (true)
      {
        switch (num1)
        {
          case 1:
            invoker = this.GetInvoker(actionType.Uid, ActionDispatcherService.Dw48v8ft1RIoQdndMFkx((object) actionObject), false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 0;
            continue;
          case 2:
            if (invoker != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            Contract.ArgumentNotNull((object) actionType, (string) ActionDispatcherService.UHVfyeftquEvXN29hEc9(-1088304168 ^ -1088122156));
            num1 = 5;
            continue;
          case 4:
            ActionDispatcherService.A8mnekftTxL2dLh2gqEv((object) actionObject, ActionDispatcherService.UHVfyeftquEvXN29hEc9(-138018305 ^ -138192625));
            num1 = 3;
            continue;
          case 5:
            if (ActionDispatcherService.J3Lchjft25tp1Knc9cyZ(actionCheckResult = this.CheckAction(actionObject, actionType, methodArgs)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
              continue;
            }
            goto case 7;
          case 6:
            goto label_11;
          case 7:
            argsString = string.Join((string) ActionDispatcherService.UHVfyeftquEvXN29hEc9(1051802738 - -1831968059 ^ -1411216015), ((IEnumerable<object>) methodArgs).Select<object, string>((Func<object, string>) (a =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (a != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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
              return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837666659);
label_5:
              return a.ToString();
            })));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 6 : 2;
            continue;
          case 8:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_5:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ActionDispatcherService.UHVfyeftquEvXN29hEc9(1052221104 - 768835541 ^ 283199377), (object) actionType.DisplayName, (object) actionObject.DisplayName, (object) ((IEnumerable<object>) methodArgs).ToSeparatedString<object>((string) ActionDispatcherService.UHVfyeftquEvXN29hEc9(-138018305 ^ -138067035))));
label_6:
      return ActionDispatcherService.rntRQWftNUAJn8KCstGG((object) invoker, (object) this.GetEventArgs(actionType, actionObject, methodArgs));
label_11:
      throw new ElmaInvalidOperationException((string) ActionDispatcherService.zqM7dDfteoFKkCFPnbSo((object) actionType), (string) ActionDispatcherService.lANNsXftP4fYOrkaBCWl((object) actionObject), argsString, actionCheckResult.ErrorMessage.IsNullOrWhiteSpace() ? (Exception) null : new Exception(actionCheckResult.ErrorMessage));
    }

    /// <summary>
    /// Выполнить действие асинхронно (будет произведена проверка)
    /// </summary>
    /// <param name="actionObject">Объект действия</param>
    /// <param name="actionType">Тип действия</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <param name="methodArgs">Аргументы, передаваемые в действие</param>
    /// <returns>Результат выполнения действия</returns>
    public async Task<object> InvokeActionAsync(
      IAuditObject actionObject,
      IAuditAction actionType,
      CancellationToken cancellationToken,
      params object[] methodArgs)
    {
      int num1 = 2;
      object result1;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = 5;
            continue;
          case 4:
label_2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 0;
            continue;
          case 5:
            goto label_51;
          default:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 9 : 6;
              else
                goto label_12;
label_7:
              TaskAwaiter<object> taskAwaiter1;
              TaskAwaiter<object> awaiter1;
              ActionCheckResult result2;
              string argsString;
              while (true)
              {
                TaskAwaiter<ActionCheckResult> taskAwaiter2;
                TaskAwaiter<ActionCheckResult> awaiter2;
                switch (num3)
                {
                  case 1:
                    awaiter1 = invoker.InvokeActionAsync(this.GetEventArgs(actionType, actionObject, methodArgs), cancellationToken).GetAwaiter();
                    num3 = 29;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.iF8YIYZfBb8qMM61BuHW((object) actionObject, ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.vpDWiRZfFLnRbrgkvCt4(-1886646897 ^ -1886825089));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 12;
                    continue;
                  case 3:
                    awaiter2 = this.CheckActionAsync(actionObject, actionType, cancellationToken, methodArgs).GetAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 5 : 5;
                    continue;
                  case 4:
                    goto label_8;
                  case 5:
                    if (!awaiter2.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 24 : 24;
                      continue;
                    }
                    goto case 11;
                  case 6:
                    goto label_14;
                  case 7:
                    taskAwaiter2 = awaiter2;
                    num3 = 14;
                    continue;
                  case 8:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 25;
                    continue;
                  case 9:
                  case 27:
                    awaiter2 = taskAwaiter2;
                    num3 = 23;
                    continue;
                  case 10:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = 18;
                    continue;
                  case 11:
                    // ISSUE: reference to a compiler-generated method
                    if (ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.H4fFO2ZfWR5oi1efCiGJ(result2 = awaiter2.GetResult()))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 15 : 15;
                      continue;
                    }
                    break;
                  case 12:
                    // ISSUE: reference to a compiler-generated method
                    Contract.ArgumentNotNull((object) actionType, (string) ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.vpDWiRZfFLnRbrgkvCt4(1505778440 - 1981636111 ^ -475552267));
                    num3 = 28;
                    continue;
                  case 13:
                    goto label_48;
                  case 14:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ActionCheckResult>, ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12>(ref awaiter2, this);
                    num3 = 22;
                    continue;
                  case 15:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (this.GetInvoker(ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.RGsKwUZfhcLbWZduY5M5((object) actionType), ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.vp5HqLZfG6B4YcJknSWc((object) actionObject), true) is IActionInvokerAsync invoker)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
                      continue;
                    }
                    goto label_14;
                  case 16:
                    taskAwaiter1 = new TaskAwaiter<object>();
                    num3 = 8;
                    continue;
                  case 17:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12>(ref awaiter1, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 13 : 5;
                    continue;
                  case 18:
                    taskAwaiter1 = awaiter1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 17 : 2;
                    continue;
                  case 19:
                    goto label_40;
                  case 20:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 11;
                    continue;
                  case 21:
                    goto label_12;
                  case 22:
                    goto label_44;
                  case 23:
                    taskAwaiter2 = new TaskAwaiter<ActionCheckResult>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 15 : 20;
                    continue;
                  case 24:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 7;
                    continue;
                  case 25:
                    result1 = awaiter1.GetResult();
                    num3 = 26;
                    continue;
                  case 26:
                    goto label_2;
                  case 28:
                    cancellationToken.ThrowIfCancellationRequested();
                    num3 = 3;
                    continue;
                  case 29:
                    if (!awaiter1.IsCompleted)
                    {
                      num3 = 10;
                      continue;
                    }
                    goto case 25;
                }
                // ISSUE: reference to a compiler-generated method
                object separator = ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.vpDWiRZfFLnRbrgkvCt4(572119659 - -337058038 ^ 909158333);
                object[] source = methodArgs;
                // ISSUE: reference to a compiler-generated field
                Func<object, string> func = ActionDispatcherService.\u003C\u003Ec.\u003C\u003E9__12_0;
                Func<object, string> selector;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  ActionDispatcherService.\u003C\u003Ec.\u003C\u003E9__12_0 = selector = (Func<object, string>) (a =>
                  {
                    int num4 = 1;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          if (a == null)
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                            continue;
                          }
                          goto label_3;
                        default:
                          goto label_2;
                      }
                    }
label_2:
                    return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16757247);
label_3:
                    return a.ToString();
                  });
                }
                else
                  goto label_11;
label_39:
                IEnumerable<string> values = ((IEnumerable<object>) source).Select<object, string>(selector);
                argsString = string.Join((string) separator, values);
                num3 = 19;
                continue;
label_11:
                selector = func;
                goto label_39;
              }
label_48:
              return;
label_44:
              return;
label_14:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.vpDWiRZfFLnRbrgkvCt4(-1824388195 ^ -1824042281), ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.qv0qb5ZfoWf6ftYAfmen((object) actionType), ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.bB1KQcZfbaagHh5RwmlD((object) actionObject), (object) ((IEnumerable<object>) methodArgs).ToSeparatedString<object>((string) ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.vpDWiRZfFLnRbrgkvCt4(-1380439818 << 3 ^ 1841432042))));
label_40:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              throw new ElmaInvalidOperationException((string) ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.qv0qb5ZfoWf6ftYAfmen((object) actionType), (string) ActionDispatcherService.\u003CInvokeActionAsync\u003Ed__12.bB1KQcZfbaagHh5RwmlD((object) actionObject), argsString, !result2.ErrorMessage.IsNullOrWhiteSpace() ? new Exception(result2.ErrorMessage) : (Exception) null);
label_8:
              awaiter1 = taskAwaiter1;
              num3 = 3;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
              {
                num3 = 16;
                goto label_7;
              }
              else
                goto label_7;
label_12:
              if (num2 != 1)
              {
                num3 = 2;
                goto label_7;
              }
              else
                goto label_8;
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_41;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = 2;
                    continue;
                }
              }
label_41:
              return;
            }
        }
      }
label_51:;
    }

    internal static int VEyJVxftv1BdqcPWA24n([In] object obj0) => ((ICollection<Guid>) obj0).Count;

    internal static void cRe7p9ft8xesBPIEwTjg([In] object obj0) => ((ICollection<Guid>) obj0).Clear();

    internal static object UhMM1uftZhXuQe5lRoif() => (object) Logger.Log;

    internal static void KfYVnlftu8YtLPDLkZqm([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static void jjCgHEftIIBEmg7IsY8L([In] object obj0) => ((ICollection<KeyValuePair<Guid, IDictionary<Guid, ActionDispatcherService.Invokers>>>) obj0).Clear();

    internal static void xtYtBnftVuIaBYLKcvWB([In] object obj0) => Monitor.Exit(obj0);

    internal static bool kWFYFJftQOIdp1l8ycNt() => ActionDispatcherService.pRjBRaftfOWJlp0PqDCY == null;

    internal static ActionDispatcherService WF8vE7ftCnnTaVWLgdp5() => ActionDispatcherService.pRjBRaftfOWJlp0PqDCY;

    internal static object fFZ35HftSEWmmAivrpbG([In] object obj0, bool async) => (object) ((ActionDispatcherService.Invokers) obj0)[async];

    internal static void VYjIOiftiHq0pBmLsrp2([In] object obj0, [In] object obj1) => ((AuditEventArgs) obj0).Action = (IAuditAction) obj1;

    internal static bool TwFHLIftRfXmabp2LuNH([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static object UHVfyeftquEvXN29hEc9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object iPDlZNftKWyaKJ8IHirM([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static object MYtXYJftXnRu8pVjQoXW(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static void A8mnekftTxL2dLh2gqEv([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Guid sgm1aCftkampsG6LbnmT([In] object obj0) => ((IAuditAction) obj0).Uid;

    internal static ActionCheckResult KN2CxfftnJtVLqZj1hBN([In] object obj0) => ActionCheckResult.False((string) obj0);

    internal static ActionCheckResult waFw9jftOW5bRMpLdNrF([In] object obj0, [In] object obj1) => ((IActionInvoker) obj0).CheckAction((ActionInvokeEventArgs) obj1);

    internal static bool J3Lchjft25tp1Knc9cyZ(ActionCheckResult actionCheckResult) => (bool) actionCheckResult;

    internal static object zqM7dDfteoFKkCFPnbSo([In] object obj0) => (object) ((IAuditAction) obj0).DisplayName;

    internal static object lANNsXftP4fYOrkaBCWl([In] object obj0) => (object) ((IAuditObject) obj0).DisplayName;

    internal static Guid Dw48v8ft1RIoQdndMFkx([In] object obj0) => ((IAuditObject) obj0).Uid;

    internal static object rntRQWftNUAJn8KCstGG([In] object obj0, [In] object obj1) => ((IActionInvoker) obj0).InvokeAction((ActionInvokeEventArgs) obj1);

    private class Invokers
    {
      private readonly object invokers;
      private static object jxX3RPZEHQk6IitHrsvr;

      public IActionInvoker this[bool async]
      {
        get => (IActionInvoker) this.invokers[!async ? 1 : 0];
        set
        {
          int num = 4;
          while (true)
          {
            IActionInvoker invoker;
            switch (num)
            {
              case 1:
                goto label_9;
              case 2:
                goto label_7;
              case 3:
                if (invoker != null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                  continue;
                }
                break;
              case 4:
                invoker = (IActionInvoker) this.invokers[async ? 0 : 1];
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 3 : 3;
                continue;
              default:
                if (invoker != value)
                {
                  num = 2;
                  continue;
                }
                break;
            }
            this.invokers[!async ? 1 : 0] = (object) value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
          }
label_9:
          return;
label_7:
          throw new ArgumentException();
        }
      }

      public Invokers()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.invokers = (object) new IActionInvoker[2];
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool sHE1LZZEAotSp3BojNVS() => ActionDispatcherService.Invokers.jxX3RPZEHQk6IitHrsvr == null;

      internal static ActionDispatcherService.Invokers s8JSa7ZE7JKBkJeZxmUL() => (ActionDispatcherService.Invokers) ActionDispatcherService.Invokers.jxX3RPZEHQk6IitHrsvr;
    }

    [Component(Order = -100)]
    private class MetadataPublishFinishedEventHandler : 
      IMetadataPublishFinishedEventHandler,
      IEventHandler
    {
      private readonly object actionDispatcherService;
      internal static object wdyNcYZExdY0KSuu9Vbx;

      public MetadataPublishFinishedEventHandler(ActionDispatcherService actionDispatcherService)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.actionDispatcherService = (object) actionDispatcherService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      public void PublishExecuted(MetadataPublishedEventArgs e)
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_4;
            case 1:
              IEnumerable<EntityMetadata> source = e.DeltaPublishedMetadata.OfType<EntityMetadata>();
              // ISSUE: reference to a compiler-generated field
              Func<EntityMetadata, IEnumerable<Guid>> func = ActionDispatcherService.MetadataPublishFinishedEventHandler.\u003C\u003Ec.\u003C\u003E9__2_0;
              Func<EntityMetadata, IEnumerable<Guid>> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                ActionDispatcherService.MetadataPublishFinishedEventHandler.\u003C\u003Ec.\u003C\u003E9__2_0 = selector = (Func<EntityMetadata, IEnumerable<Guid>>) (m => (IEnumerable<Guid>) new Guid[2]
                {
                  m.Uid,
                  m.ImplementationUid
                });
              }
              else
                goto label_7;
label_6:
              source.SelectMany<EntityMetadata, Guid>(selector).ForEach<Guid>((Action<Guid>) (u =>
              {
                int num2 = 3;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_6;
                    case 1:
                    case 2:
                      ((ActionDispatcherService) this.actionDispatcherService).actionTypeObjectMap.Remove(u);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
                      continue;
                    case 3:
                      ISet<Guid> toInitialize = ((ActionDispatcherService) this.actionDispatcherService).toInitialize;
                      if (toInitialize == null)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 2;
                        continue;
                      }
                      toInitialize.Add(u);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_6:
                return;
label_4:;
              }));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
label_7:
              selector = func;
              goto label_6;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }

      internal static bool pdyHfgZE0jYooeEgpZow() => ActionDispatcherService.MetadataPublishFinishedEventHandler.wdyNcYZExdY0KSuu9Vbx == null;

      internal static ActionDispatcherService.MetadataPublishFinishedEventHandler CTL2XrZEmsVEmGSBTEMu() => (ActionDispatcherService.MetadataPublishFinishedEventHandler) ActionDispatcherService.MetadataPublishFinishedEventHandler.wdyNcYZExdY0KSuu9Vbx;
    }
  }
}
