// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.EventNotificationProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Провайдер генерации оповещений о событиях системы</summary>
  [Component(Type = ComponentType.WebServer)]
  public class EventNotificationProvider : IAuditEventProviderAsync, IAuditEventProvider
  {
    internal static EventNotificationProvider wkpO9xtkoI6sdYo5Qrp;

    /// <summary>Менеджер оповещений</summary>
    public INotificationManager NotificationManager
    {
      get => this.\u003CNotificationManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CNotificationManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
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

    /// <summary>Оповестить о событии</summary>
    /// <param name="eventName">Имя события</param>
    /// <param name="e">Параметры события</param>
    public virtual void Notify(string eventName, IAuditEventArgs e)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        EventNotification eventNotification;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              if (eventName == EntityActionNotificationUnitOfWorkListener.EntityActionHandlerEventName)
              {
                num2 = 3;
                continue;
              }
              goto case 7;
            case 2:
              EventNotificationProvider.sjDcZEteiNfZS0pF2Gu((object) this.NotificationManager, EventNotificationProvider.Paq4e9t2xubpMWNxMDk(236071375 ^ 236102113));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_11;
            case 5:
              eventNotification = new EventNotification(eventName, e);
              num2 = 6;
              continue;
            case 6:
              goto label_13;
            case 7:
              if (!(e is AuditableEventArgs))
              {
                num2 = 5;
                continue;
              }
              goto label_4;
            default:
              goto label_14;
          }
        }
label_13:
        EventNotificationProvider.QW6W0vtPqR7uS8sTM4I((object) this.NotificationManager, (object) eventNotification);
        num1 = 4;
      }
label_9:
      return;
label_3:
      return;
label_11:
      return;
label_14:
      return;
label_4:;
    }

    /// <inheritdoc />
    public Task NotifyAsync(
      string eventName,
      IAuditEventArgs e,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EventNotificationProvider.cX4bust17Y1qHyyALS4((object) this, (object) eventName, (object) e);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (Task) EventNotificationProvider.EdRKiFtNXhybWoqwbNU();
    }

    public EventNotificationProvider()
    {
      EventNotificationProvider.KabbNvt3hyxeh327QMU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DfcUtEtngaB9RK8eSyK() => EventNotificationProvider.wkpO9xtkoI6sdYo5Qrp == null;

    internal static EventNotificationProvider B1fyqRtOIQYNhG7h5L3() => EventNotificationProvider.wkpO9xtkoI6sdYo5Qrp;

    internal static object Paq4e9t2xubpMWNxMDk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void sjDcZEteiNfZS0pF2Gu([In] object obj0, [In] object obj1) => Contract.ServiceNotNull(obj0, (string) obj1);

    internal static void QW6W0vtPqR7uS8sTM4I([In] object obj0, [In] object obj1) => ((INotificationManager) obj0).Send((INotification) obj1);

    internal static void cX4bust17Y1qHyyALS4([In] object obj0, [In] object obj1, [In] object obj2) => ((EventNotificationProvider) obj0).Notify((string) obj1, (IAuditEventArgs) obj2);

    internal static object EdRKiFtNXhybWoqwbNU() => (object) Task.CompletedTask;

    internal static void KabbNvt3hyxeh327QMU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
