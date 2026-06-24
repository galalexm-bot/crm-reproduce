// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.EntityActionNotificationUnitOfWorkListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Events.Audit.Impl;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Notifications.Impl
{
  [Component(Order = 1000010, Type = ComponentType.WebServer)]
  internal class EntityActionNotificationUnitOfWorkListener : BaseEntityActionUnitOfWorkListener
  {
    internal static readonly string EntityActionHandlerEventName;
    private readonly INotificationManager notificationManager;
    internal static EntityActionNotificationUnitOfWorkListener NnoymkDVDKcfyydIhWe;

    /// <summary>Ctor</summary>
    /// <param name="contextBoundVariableService"></param>
    /// <param name="sessionProvider"></param>
    /// <param name="logger"></param>
    public EntityActionNotificationUnitOfWorkListener(
      [NotNull] IContextBoundVariableService contextBoundVariableService,
      [NotNull] ISessionProvider sessionProvider,
      [NotNull] ILogger logger,
      [NotNull] INotificationManager notificationManager)
    {
      EntityActionNotificationUnitOfWorkListener.Qudx3yDRcC4S16KFj67();
      // ISSUE: explicit constructor call
      base.\u002Ector(contextBoundVariableService, sessionProvider, logger);
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            this.notificationManager = notificationManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (notificationManager != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 1;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_2:
      return;
label_3:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901825465));
    }

    /// <summary>
    /// Ключ значения в IContextBoundVariableService, содержащий список событий с сущностью, который нужно обработать
    /// </summary>
    protected override string EventListContextKey => (string) EntityActionNotificationUnitOfWorkListener.kNuT8NDq00VrDbfnV9K(-740338220 ^ -740306690);

    /// <summary>Сохранить событие</summary>
    /// <param name="e"></param>
    protected override void PersistEvent(EntityActionEventArgs e)
    {
      int num = 2;
      EventNotification eventNotification;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityActionNotificationUnitOfWorkListener.gYqSU1DKFOltYCncJG5((object) this.notificationManager, (object) eventNotification);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          case 2:
            eventNotification = new EventNotification(EntityActionNotificationUnitOfWorkListener.EntityActionHandlerEventName, (IAuditEventArgs) e);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    static EntityActionNotificationUnitOfWorkListener()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityActionNotificationUnitOfWorkListener.EntityActionHandlerEventName = (string) EntityActionNotificationUnitOfWorkListener.HGhKetDTnZVaaVchaG6(EntityActionNotificationUnitOfWorkListener.JlKrDrDXWgGB5nAnkvx((object) typeof (IEntityActionHandler)), EntityActionNotificationUnitOfWorkListener.kNuT8NDq00VrDbfnV9K(-97972138 ^ -97937990));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
            EntityActionNotificationUnitOfWorkListener.Qudx3yDRcC4S16KFj67();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void Qudx3yDRcC4S16KFj67() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fKTQy9DSdRSH63xl6fJ() => EntityActionNotificationUnitOfWorkListener.NnoymkDVDKcfyydIhWe == null;

    internal static EntityActionNotificationUnitOfWorkListener xWVmymDiiuQXqesg8kt() => EntityActionNotificationUnitOfWorkListener.NnoymkDVDKcfyydIhWe;

    internal static object kNuT8NDq00VrDbfnV9K(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void gYqSU1DKFOltYCncJG5([In] object obj0, [In] object obj1) => ((INotificationManager) obj0).Send((INotification) obj1);

    internal static object JlKrDrDXWgGB5nAnkvx([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object HGhKetDTnZVaaVchaG6([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
  }
}
