// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionInvoker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Actions
{
  /// <summary>Исполнитель действий</summary>
  [Obsolete("Класс устарел и больше не используется. Используйте EleWise.ELMA.Actions.ActionInvokerAsync", true)]
  public sealed class ActionInvoker : IActionInvoker
  {
    private static ActionInvoker qv5lf2ft976kgvnR2pJC;

    /// <summary>Конструктор</summary>
    /// <param name="actionObject">Объект действия</param>
    /// <param name="actionType">Тип действия</param>
    /// <param name="targetMethodInfo">Описание вызываемого метода, для построения <see cref="P:EleWise.ELMA.Actions.ActionInvoker.MethodMetadata" /></param>
    /// <param name="handler">Обработчик вызова исполнения действия</param>
    /// <param name="checkHandler">Обработчик вызова проверки доступности</param>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров равен <c>null</c></exception>
    public ActionInvoker(
      [NotNull] IAuditObject actionObject,
      [NotNull] IAuditAction actionType,
      [NotNull] MethodInfo targetMethodInfo,
      [NotNull] Func<ActionInvokeEventArgs, object> handler,
      Func<ActionInvokeEventArgs, ActionCheckResult> checkHandler = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) actionType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426399691));
      Contract.ArgumentNotNull((object) actionObject, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138617080));
      Contract.ArgumentNotNull((object) targetMethodInfo, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309454024));
      Contract.ArgumentNotNull((object) handler, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867410627));
      this.Handler = handler;
      this.CheckHandler = checkHandler;
      this.ActionType = actionType;
      this.ActionObject = actionObject;
      this.MethodMetadata = ActionMethodMetadata.Create(actionObject, actionType, targetMethodInfo);
    }

    /// <summary>Обработчик вызова исполнения действия</summary>
    public Func<ActionInvokeEventArgs, object> Handler { get; private set; }

    /// <summary>Обработчик вызова проверки доступности</summary>
    public Func<ActionInvokeEventArgs, ActionCheckResult> CheckHandler { get; private set; }

    /// <inheritdoc />
    public IAuditObject ActionObject
    {
      get => this.\u003CActionObject\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CActionObject\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <inheritdoc />
    public IAuditAction ActionType
    {
      get => this.\u003CActionType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CActionType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <inheritdoc />
    public ActionMethodMetadata MethodMetadata
    {
      get => this.\u003CMethodMetadata\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMethodMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <inheritdoc />
    public object InvokeAction(ActionInvokeEventArgs e)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.Handler != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      throw new InvalidOperationException((string) ActionInvoker.XkcxwoftgctsRmCwNyh7(ActionInvoker.TKAx1VftrfCDrbgPNRii(1021410165 ^ 1021585359)));
label_5:
      return this.Handler(e);
    }

    /// <inheritdoc />
    public ActionCheckResult CheckAction(ActionInvokeEventArgs e)
    {
      int num = 1;
      Func<ActionInvokeEventArgs, ActionCheckResult> checkHandler;
      while (true)
      {
        switch (num)
        {
          case 1:
            checkHandler = this.CheckHandler;
            if (checkHandler == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return ActionInvoker.GPctldft5lUQjmCdtbY2();
label_5:
      return checkHandler(e);
    }

    internal static bool DhUYc7ftdH7PPXDRBnKE() => ActionInvoker.qv5lf2ft976kgvnR2pJC == null;

    internal static ActionInvoker btXnL4ftlKgcL1XjY2P1() => ActionInvoker.qv5lf2ft976kgvnR2pJC;

    internal static object TKAx1VftrfCDrbgPNRii(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object XkcxwoftgctsRmCwNyh7([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static ActionCheckResult GPctldft5lUQjmCdtbY2() => ActionCheckResult.True;
  }
}
