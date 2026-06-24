// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.EventNotification
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Dynamic;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Данные события оповещения</summary>
  public class EventNotification : IEventNotification, INotification, IExtendedPropertiesContainer
  {
    private string @event;
    private IAuditEventArgs e;
    private static EventNotification aTcOSqtICpZGdJOhbqP;

    /// <summary>Ctor</summary>
    /// <param name="event">Имя события</param>
    /// <param name="e">Параметры события</param>
    public EventNotification(string @event, IAuditEventArgs e)
    {
      EventNotification.jawZ9VtiZLxO3l6mYYC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 5;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        num1 = 4;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            EventNotification.OCUjNBtqimZf7FMwE9Z((object) e, EventNotification.tOTajrtRabDpkAQr0rA(712480695 ^ 712449951));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 3:
            this.e = e;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
            continue;
          case 4:
            EventNotification.VXYcQXtKh6ciFBgE7N9((object) @event, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408927958));
            num2 = 2;
            break;
          case 5:
            EventNotification.OCUjNBtqimZf7FMwE9Z((object) @event, EventNotification.tOTajrtRabDpkAQr0rA(-812025778 ^ -811995050));
            num1 = 4;
            continue;
          default:
            this.@event = @event;
            num2 = 3;
            break;
        }
        num1 = num2;
      }
label_4:;
    }

    /// <summary>
    /// Имя шаблона оповещения. Для оповещения о событии не указывается (null).
    /// </summary>
    public string TemplateName => (string) null;

    /// <summary>Имя события</summary>
    public string Event => this.@event;

    /// <summary>Объект события</summary>
    public IAuditObject Object => (IAuditObject) EventNotification.yTO4IntXTaHMHGOrStJ((object) this.e);

    /// <summary>Действие</summary>
    public IAuditAction Action => (IAuditAction) EventNotification.rqL4V9tTFW9boJ9TcFU((object) this.e);

    /// <summary>
    /// Получить словарь объектов по имени, которые могут быть использованы в шаблонах
    /// </summary>
    public IDictionary<string, object> ExtendedProperties => this.e.ExtendedProperties;

    internal static void jawZ9VtiZLxO3l6mYYC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object tOTajrtRabDpkAQr0rA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void OCUjNBtqimZf7FMwE9Z([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void VXYcQXtKh6ciFBgE7N9([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static bool tNQTjVtVlKOoxWBOeBY() => EventNotification.aTcOSqtICpZGdJOhbqP == null;

    internal static EventNotification EpC94ctS4Hon5Wl2Sng() => EventNotification.aTcOSqtICpZGdJOhbqP;

    internal static object yTO4IntXTaHMHGOrStJ([In] object obj0) => (object) ((IAuditEventHolder) obj0).Object;

    internal static object rqL4V9tTFW9boJ9TcFU([In] object obj0) => (object) ((IAuditEventHolder) obj0).Action;
  }
}
