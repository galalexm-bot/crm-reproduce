// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationRecipientSet
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Набор получателей оповещения</summary>
  public class NotificationRecipientSet
  {
    private static NotificationRecipientSet UcdOxUwWt70ximRriB8;

    /// <summary>Имя набора</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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

    /// <summary>
    /// Не применять список исполнителей из базового шаблона (или шаблона по умолчанию)
    /// </summary>
    public bool Clear
    {
      get => this.\u003CClear\u003Ek__BackingField;
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
              this.\u003CClear\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
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

    /// <summary>
    /// Применять список исполнителей только к автору действия
    /// </summary>
    public bool SendToAuthorOnly
    {
      get => this.\u003CSendToAuthorOnly\u003Ek__BackingField;
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
              this.\u003CSendToAuthorOnly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

    /// <summary>Условие</summary>
    public NotificationTemplateFilterCondition Condition
    {
      get => this.\u003CCondition\u003Ek__BackingField;
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
              this.\u003CCondition\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    /// <summary>Элементы набора</summary>
    public List<NotificationRecipientItem> Items { get; set; }

    /// <summary>Получить список получателей (пользователей)</summary>
    /// <param name="notification">Оповещение</param>
    /// <returns>Список получателей (пользователей). Или null, если ну удалось определить список</returns>
    public virtual IEnumerable<object> GetRecipients(INotification notification)
    {
      List<object> recipients1 = new List<object>();
      if (this.Condition == null || this.Condition.Evaluate((object) notification))
      {
        foreach (NotificationRecipientItem notificationRecipientItem in this.Items)
        {
          IEnumerable<object> recipients2 = notificationRecipientItem.GetRecipients(notification);
          if (recipients2 != null)
            recipients1.AddRange(recipients2);
        }
      }
      return (IEnumerable<object>) recipients1;
    }

    /// <summary>Клонировать элемент</summary>
    /// <returns></returns>
    public NotificationRecipientSet Clone()
    {
      NotificationRecipientSet notificationRecipientSet = new NotificationRecipientSet();
      NotificationRecipientSet.GL0BHDwhBkUrGK2HoF7((object) notificationRecipientSet, this.Clear);
      NotificationRecipientSet.dxemyTwGDnV5FUFtyw0((object) notificationRecipientSet, (object) this.Condition);
      notificationRecipientSet.Items = this.Items.ToList<NotificationRecipientItem>();
      NotificationRecipientSet.NlQYoGwEXPWXNLqE6Rr((object) notificationRecipientSet, (object) this.Name);
      NotificationRecipientSet.ovaKq9wfJu0ujhIYV0j((object) notificationRecipientSet, this.SendToAuthorOnly);
      return notificationRecipientSet;
    }

    /// <summary>Ctor</summary>
    protected NotificationRecipientSet()
    {
      NotificationRecipientSet.VNmuEZwQtVInjUijBgQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="node">Элемент документа XML</param>
    public NotificationRecipientSet(XmlElement node)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 14;
      XmlElement node1;
      XmlNode xmlNode;
      NotificationRecipientItem notificationRecipientItem;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 10:
            notificationRecipientItem = new NotificationRecipientItem(node1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 8 : 5;
            continue;
          case 2:
          case 4:
            node1 = xmlNode as XmlElement;
            num = 13;
            continue;
          case 5:
          case 17:
            if (!NotificationRecipientSet.fB1eBAwSDR9GL77GRsq(NotificationRecipientSet.X50AvuwV3uMq6GssSsy((object) node1), NotificationRecipientSet.kYnNNhwvtyTUP9PUiIL(-1487388570 ^ -1487353142)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 10 : 4;
              continue;
            }
            goto case 23;
          case 6:
            if (NotificationRecipientSet.r9phBWw8hKAXT0OlGbW(NotificationRecipientSet.FaAXUUwC9pi1gmbiUMq((object) node), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335028089)) != null)
            {
              num = 12;
              continue;
            }
            goto case 9;
          case 8:
            this.Items.Add(notificationRecipientItem);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 18 : 11;
            continue;
          case 9:
            this.Items = new List<NotificationRecipientItem>();
            num = 22;
            continue;
          case 11:
            if (((XmlAttributeCollection) NotificationRecipientSet.FaAXUUwC9pi1gmbiUMq((object) node))[(string) NotificationRecipientSet.kYnNNhwvtyTUP9PUiIL(1461625753 ^ 1461594595)] != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 15 : 19;
              continue;
            }
            goto case 6;
          case 12:
            this.SendToAuthorOnly = ((string) NotificationRecipientSet.b0obbQwZV3ochBY2adi(NotificationRecipientSet.r9phBWw8hKAXT0OlGbW(NotificationRecipientSet.FaAXUUwC9pi1gmbiUMq((object) node), NotificationRecipientSet.kYnNNhwvtyTUP9PUiIL(-2107978722 ^ -2108012906)))).Equals((string) NotificationRecipientSet.kYnNNhwvtyTUP9PUiIL(647913418 ^ 647906756), StringComparison.CurrentCultureIgnoreCase);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 5 : 9;
            continue;
          case 13:
            if (node1 != null)
            {
              num = 5;
              continue;
            }
            goto case 15;
          case 14:
            this.Name = string.Empty;
            num = 24;
            continue;
          case 15:
            xmlNode = (XmlNode) NotificationRecipientSet.SvBFC8wIsQe6qWLb9pc((object) xmlNode);
            num = 3;
            continue;
          case 16:
            this.Name = (string) NotificationRecipientSet.b0obbQwZV3ochBY2adi(NotificationRecipientSet.r9phBWw8hKAXT0OlGbW(NotificationRecipientSet.FaAXUUwC9pi1gmbiUMq((object) node), NotificationRecipientSet.kYnNNhwvtyTUP9PUiIL(1052221104 - 768835541 ^ 283405595)));
            num = 11;
            continue;
          case 18:
            xmlNode = (XmlNode) NotificationRecipientSet.SvBFC8wIsQe6qWLb9pc((object) xmlNode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          case 19:
            this.Clear = ((XmlNode) NotificationRecipientSet.r9phBWw8hKAXT0OlGbW(NotificationRecipientSet.FaAXUUwC9pi1gmbiUMq((object) node), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921233479))).Value.Equals((string) NotificationRecipientSet.kYnNNhwvtyTUP9PUiIL(1051276242 - 990076387 ^ 61198305), StringComparison.CurrentCultureIgnoreCase);
            num = 6;
            continue;
          case 20:
            goto label_9;
          case 22:
            xmlNode = (XmlNode) NotificationRecipientSet.gFxdSewuAxJMmLVt9iy((object) node);
            num = 21;
            continue;
          case 23:
            this.Condition = new NotificationTemplateFilterCondition(node1);
            num = 7;
            continue;
          case 24:
            if (NotificationRecipientSet.r9phBWw8hKAXT0OlGbW(NotificationRecipientSet.FaAXUUwC9pi1gmbiUMq((object) node), NotificationRecipientSet.kYnNNhwvtyTUP9PUiIL(1142330761 ^ 1541959139 ^ 536775594)) != null)
            {
              num = 16;
              continue;
            }
            goto case 11;
          default:
            if (xmlNode != null)
            {
              num = 4;
              continue;
            }
            goto label_8;
        }
      }
label_9:
      return;
label_8:;
    }

    internal static bool pktgbwwoS4WNGXAEyjN() => NotificationRecipientSet.UcdOxUwWt70ximRriB8 == null;

    internal static NotificationRecipientSet ye6J69wbwO6oUPYB7Vr() => NotificationRecipientSet.UcdOxUwWt70ximRriB8;

    internal static void GL0BHDwhBkUrGK2HoF7([In] object obj0, bool value) => ((NotificationRecipientSet) obj0).Clear = value;

    internal static void dxemyTwGDnV5FUFtyw0([In] object obj0, [In] object obj1) => ((NotificationRecipientSet) obj0).Condition = (NotificationTemplateFilterCondition) obj1;

    internal static void NlQYoGwEXPWXNLqE6Rr([In] object obj0, [In] object obj1) => ((NotificationRecipientSet) obj0).Name = (string) obj1;

    internal static void ovaKq9wfJu0ujhIYV0j([In] object obj0, bool value) => ((NotificationRecipientSet) obj0).SendToAuthorOnly = value;

    internal static void VNmuEZwQtVInjUijBgQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object FaAXUUwC9pi1gmbiUMq([In] object obj0) => (object) ((XmlNode) obj0).Attributes;

    internal static object kYnNNhwvtyTUP9PUiIL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object r9phBWw8hKAXT0OlGbW([In] object obj0, [In] object obj1) => (object) ((XmlAttributeCollection) obj0)[(string) obj1];

    internal static object b0obbQwZV3ochBY2adi([In] object obj0) => (object) ((XmlNode) obj0).Value;

    internal static object gFxdSewuAxJMmLVt9iy([In] object obj0) => (object) ((XmlNode) obj0).FirstChild;

    internal static object SvBFC8wIsQe6qWLb9pc([In] object obj0) => (object) ((XmlNode) obj0).NextSibling;

    internal static object X50AvuwV3uMq6GssSsy([In] object obj0) => (object) ((XmlNode) obj0).Name;

    internal static bool fB1eBAwSDR9GL77GRsq([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;
  }
}
