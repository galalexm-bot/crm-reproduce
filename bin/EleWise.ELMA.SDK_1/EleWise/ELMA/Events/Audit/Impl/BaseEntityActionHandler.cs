// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.Impl.BaseEntityActionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Audit.Impl
{
  public abstract class BaseEntityActionHandler : IEntityActionHandler, IEventHandler
  {
    private readonly IContextBoundVariableService contextBoundVariableService;
    private readonly IUnitOfWorkManager unitOfWorkManager;
    private static BaseEntityActionHandler qBAR4sGsa0BZ0gJeOPEr;

    /// <summary>Ctor</summary>
    /// <param name="contextBoundVariableService"></param>
    /// <param name="unitOfWorkManager"></param>
    public BaseEntityActionHandler(
      [NotNull] IContextBoundVariableService contextBoundVariableService,
      [NotNull] IUnitOfWorkManager unitOfWorkManager)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_8;
          case 3:
            if (contextBoundVariableService == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 0;
              continue;
            }
            if (unitOfWorkManager != null)
            {
              num = 4;
              continue;
            }
            goto label_9;
          case 4:
            this.contextBoundVariableService = contextBoundVariableService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_9;
          default:
            this.unitOfWorkManager = unitOfWorkManager;
            num = 2;
            continue;
        }
      }
label_8:
      return;
label_5:
      throw new ArgumentNullException((string) BaseEntityActionHandler.geLdTtGswyETuOqjeRdj(-1876063057 ^ -1876323857));
label_9:
      throw new ArgumentNullException((string) BaseEntityActionHandler.geLdTtGswyETuOqjeRdj(825385222 ^ 825654396));
    }

    /// <summary>После выполнения действия</summary>
    /// <param name="e">Параметры события</param>
    public void ActionExecuted(EntityActionEventArgs e)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_15;
            case 2:
              if (BaseEntityActionHandler.RwfWr0Gs6bS0Mc30eCwF((object) this.unitOfWorkManager, (object) ""))
              {
                num2 = 6;
                continue;
              }
              goto label_13;
            case 3:
              goto label_8;
            case 4:
              if (e != null)
              {
                if (this.NeedPersistEvent(e))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                  continue;
                }
                goto label_14;
              }
              else
                goto label_4;
            case 5:
            case 6:
              BaseEntityActionHandler.UJHDTvGsxdhI0CwVp5GP((object) this, (object) e);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
              continue;
            case 7:
              goto label_13;
            case 8:
              goto label_7;
            default:
              if (!BaseEntityActionHandler.RLaEK5Gs439G5QVLDfDi((object) this))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 5 : 0;
                continue;
              }
              goto case 2;
          }
        }
label_4:
        num1 = 3;
      }
label_15:
      return;
label_8:
      return;
label_7:
      return;
label_14:
      return;
label_13:
      throw new TransactionRequiredException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409162606), BaseEntityActionHandler.QpyV3AGsHrsuwAamPwwC((object) e) == null ? (object) "" : BaseEntityActionHandler.FgW3k1GsAdol8C1OpMqj(BaseEntityActionHandler.QpyV3AGsHrsuwAamPwwC((object) e)), BaseEntityActionHandler.RDxujnGs7ZmCer3TPFUe((object) e) == null ? (object) "" : (object) ((IAuditObject) BaseEntityActionHandler.RDxujnGs7ZmCer3TPFUe((object) e)).Name));
    }

    /// <summary>
    /// Требутеся ли проверка, чтобы в момент выполнения действия существовала активная транзакция (по умолчанию true)
    /// </summary>
    protected virtual bool TransactionRequired => true;

    /// <summary>
    /// Ключ значения в IContextBoundVariableService, содержащий список событий с сущностью, который нужно обработать
    /// </summary>
    protected abstract string EventListContextKey { get; }

    /// <summary>Сохранить событие</summary>
    /// <param name="e"></param>
    protected virtual void PersistEvent(EntityActionEventArgs e)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            IContextBoundVariableService boundVariableService = this.contextBoundVariableService;
            object name = BaseEntityActionHandler.eXmrnYGs0q53Rabpip3o((object) this);
            // ISSUE: reference to a compiler-generated field
            Func<List<EntityActionEventArgs>> func = BaseEntityActionHandler.\u003C\u003Ec.\u003C\u003E9__6_0;
            Func<List<EntityActionEventArgs>> factory;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              BaseEntityActionHandler.\u003C\u003Ec.\u003C\u003E9__6_0 = factory = (Func<List<EntityActionEventArgs>>) (() => new List<EntityActionEventArgs>());
            }
            else
              goto label_7;
label_6:
            boundVariableService.GetOrAdd<List<EntityActionEventArgs>>((string) name, factory).Add(e);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
label_7:
            factory = func;
            goto label_6;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    /// <summary>Нужно ли сохранять событие</summary>
    /// <param name="e"></param>
    /// <returns></returns>
    protected abstract bool NeedPersistEvent(EntityActionEventArgs e);

    internal static object geLdTtGswyETuOqjeRdj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Qa6SPBGsDw7K6YFwq2EC() => BaseEntityActionHandler.qBAR4sGsa0BZ0gJeOPEr == null;

    internal static BaseEntityActionHandler zWjHy1GstWuhwQ2Jfbo8() => BaseEntityActionHandler.qBAR4sGsa0BZ0gJeOPEr;

    internal static bool RLaEK5Gs439G5QVLDfDi([In] object obj0) => ((BaseEntityActionHandler) obj0).TransactionRequired;

    internal static bool RwfWr0Gs6bS0Mc30eCwF([In] object obj0, [In] object obj1) => ((IUnitOfWorkManager) obj0).HasActiveTransaction((string) obj1);

    internal static object QpyV3AGsHrsuwAamPwwC([In] object obj0) => (object) ((AuditEventArgs) obj0).Action;

    internal static object FgW3k1GsAdol8C1OpMqj([In] object obj0) => (object) ((IAuditAction) obj0).Name;

    internal static object RDxujnGs7ZmCer3TPFUe([In] object obj0) => (object) ((AuditEventArgs) obj0).Object;

    internal static void UJHDTvGsxdhI0CwVp5GP([In] object obj0, [In] object obj1) => ((BaseEntityActionHandler) obj0).PersistEvent((EntityActionEventArgs) obj1);

    internal static object eXmrnYGs0q53Rabpip3o([In] object obj0) => (object) ((BaseEntityActionHandler) obj0).EventListContextKey;
  }
}
