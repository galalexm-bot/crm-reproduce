// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.EntityActionNotificationHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit.Impl;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Перехватчик событий сущности для генерации оповещений</summary>
  [Component(Type = ComponentType.WebServer)]
  internal class EntityActionNotificationHandler : BaseEntityActionHandler
  {
    /// <summary>
    /// Ключ значения в IContextBoundVariableService, содержащий список событий с сущностью, который нужно обработать
    /// </summary>
    public const string EventListContextKeyConst = "EleWise.ELMA.Notifications.Impl.EntityActionNotificationHandler.EventsList";
    private static EntityActionNotificationHandler DVBOoHD8xmxFHbmdX9T;

    /// <summary>Ctor</summary>
    /// <param name="contextBoundVariableService"></param>
    /// <param name="unitOfWorkManager"></param>
    public EntityActionNotificationHandler(
      [NotNull] IContextBoundVariableService contextBoundVariableService,
      [NotNull] IUnitOfWorkManager unitOfWorkManager)
    {
      EntityActionNotificationHandler.X4FOMEDIeTCjE1IaklI();
      // ISSUE: explicit constructor call
      base.\u002Ector(contextBoundVariableService, unitOfWorkManager);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Ключ значения в IContextBoundVariableService, содержащий список событий с сущностью, который нужно обработать
    /// </summary>
    protected override string EventListContextKey => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36027143);

    /// <summary>Нужно ли сохранять событие</summary>
    /// <param name="e"></param>
    /// <returns></returns>
    protected override bool NeedPersistEvent(EntityActionEventArgs e)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (e == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (e.Object != null)
            {
              num = 3;
              continue;
            }
            goto label_5;
          case 3:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return e.Action != null;
label_5:
      return false;
    }

    internal static void X4FOMEDIeTCjE1IaklI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool nH3yVBDZqcsNWP8U1Ij() => EntityActionNotificationHandler.DVBOoHD8xmxFHbmdX9T == null;

    internal static EntityActionNotificationHandler GID5imDu0Yp15ZfDS2Z() => EntityActionNotificationHandler.DVBOoHD8xmxFHbmdX9T;
  }
}
