// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationTemplateFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Фильтр шаблона оповещений</summary>
  public class NotificationTemplateFilter
  {
    internal static NotificationTemplateFilter RdmUjZwmSCCxhUEkMHP;

    /// <summary>Имя события</summary>
    public string Event
    {
      get => this.\u003CEvent\u003Ek__BackingField;
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
              this.\u003CEvent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

    /// <summary>Имя объекта</summary>
    public string ObjectName
    {
      get => this.\u003CObjectName\u003Ek__BackingField;
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
              this.\u003CObjectName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
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

    /// <summary>Учитывать наследование объектов</summary>
    public bool ObjectInherit
    {
      get => this.\u003CObjectInherit\u003Ek__BackingField;
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
              this.\u003CObjectInherit\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
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

    /// <summary>Имя действия</summary>
    public string ActionName
    {
      get => this.\u003CActionName\u003Ek__BackingField;
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
              this.\u003CActionName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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

    /// <summary>Проверить, удовлетворяет ли оповещение фильтру</summary>
    /// <param name="notification">Оповещение</param>
    /// <returns>True, если удовлетворяют</returns>
    public virtual bool Check(INotification notification)
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        IEventNotification eventNotification;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (eventNotification != null)
              {
                num2 = 12;
                continue;
              }
              goto label_31;
            case 2:
              goto label_17;
            case 3:
            case 19:
              goto label_26;
            case 4:
            case 5:
              if (this.Condition == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 7 : 2;
                continue;
              }
              goto case 21;
            case 6:
              if (this.IsChildOf((IAuditObject) NotificationTemplateFilter.MKLD6ywlKSSR1QtndGt((object) eventNotification), this.ObjectName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 4 : 8;
                continue;
              }
              goto label_21;
            case 7:
            case 13:
              goto label_31;
            case 8:
              if (this.ActionName == null)
              {
                num2 = 5;
                continue;
              }
              goto case 9;
            case 9:
              if (NotificationTemplateFilter.hshaPtwrQreJLHt5LwP((object) eventNotification) != null)
              {
                num2 = 15;
                continue;
              }
              goto label_17;
            case 10:
              goto label_21;
            case 11:
              if (NotificationTemplateFilter.oMvV9Wwd4Dy2mXFv1O0(NotificationTemplateFilter.QRdOyowgLFS7pkc7XUW(NotificationTemplateFilter.hshaPtwrQreJLHt5LwP((object) eventNotification)), (object) this.ActionName, StringComparison.CurrentCultureIgnoreCase))
              {
                num2 = 4;
                continue;
              }
              goto label_17;
            case 12:
              if (this.Event != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 18 : 8;
                continue;
              }
              goto default;
            case 14:
              if (NotificationTemplateFilter.oMvV9Wwd4Dy2mXFv1O0(NotificationTemplateFilter.v63NQBw9bkndBXGlYrd((object) eventNotification), (object) this.Event, StringComparison.CurrentCultureIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                continue;
              }
              goto label_26;
            case 15:
              goto label_3;
            case 16:
              eventNotification = notification as IEventNotification;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
              continue;
            case 17:
              Contract.ArgumentNotNull((object) notification, (string) NotificationTemplateFilter.e3uU8qwJSDVsXs3TI4w(1113862659 ^ 1113895949));
              num2 = 16;
              continue;
            case 18:
              if (NotificationTemplateFilter.v63NQBw9bkndBXGlYrd((object) eventNotification) == null)
              {
                num2 = 19;
                continue;
              }
              goto case 14;
            case 20:
              goto label_30;
            case 21:
              if (NotificationTemplateFilter.ngM3tJw558gCcTk7PQd((object) this.Condition, (object) notification))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 10 : 13;
                continue;
              }
              goto label_30;
            default:
              if (this.ObjectName != null)
              {
                num2 = 6;
                continue;
              }
              goto case 8;
          }
        }
label_3:
        if (NotificationTemplateFilter.QRdOyowgLFS7pkc7XUW(NotificationTemplateFilter.hshaPtwrQreJLHt5LwP((object) eventNotification)) != null)
          num1 = 11;
        else
          break;
      }
label_17:
      return false;
label_21:
      return false;
label_26:
      return false;
label_30:
      return false;
label_31:
      return true;
    }

    /// <summary>Ctor</summary>
    public NotificationTemplateFilter()
    {
      NotificationTemplateFilter.bv6DP0wj3rXbfk6tBf3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ObjectInherit = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Загрузить из документа XML</summary>
    /// <param name="node">Узел документа XML</param>
    public NotificationTemplateFilter(XmlElement node)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ObjectInherit = true;
            num = 2;
            continue;
          case 2:
            this.Parse(node);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Загрузить из документа XML</summary>
    /// <param name="node">Узел документа XML</param>
    public void Parse(XmlElement node)
    {
      int num1 = 18;
      while (true)
      {
        int num2 = num1;
        XmlNode xmlNode;
        XmlElement node1;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              this.ObjectName = (string) NotificationTemplateFilter.obVNxjwz0G5A0QWZL9F((object) xmlNode.InnerXml, NotificationTemplateFilter.mr5Qt7wc8I3T4ore376((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740359272)));
              num2 = 15;
              continue;
            case 3:
            case 25:
              str = (string) NotificationTemplateFilter.g8Si4kwLSJRxjLsomde((object) xmlNode);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 21 : 11;
              continue;
            case 4:
            case 17:
            case 19:
              if (xmlNode != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 21 : 24;
                continue;
              }
              goto label_26;
            case 5:
              this.Event = (string) NotificationTemplateFilter.obVNxjwz0G5A0QWZL9F(NotificationTemplateFilter.KgFIKNws7oQsbMPIdBB((object) xmlNode), NotificationTemplateFilter.mr5Qt7wc8I3T4ore376(NotificationTemplateFilter.e3uU8qwJSDVsXs3TI4w(-787452571 ^ -787465431)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 11;
              continue;
            case 6:
              this.ObjectInherit = NotificationTemplateFilter.oMvV9Wwd4Dy2mXFv1O0(NotificationTemplateFilter.eO9U0e4WR7gh7pnLduc(NotificationTemplateFilter.UQABG14Ba5ArHgLh0UP(NotificationTemplateFilter.t7QAWX4F2uqisDmXslA((object) xmlNode), NotificationTemplateFilter.e3uU8qwJSDVsXs3TI4w(-740338220 ^ -740304816))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767754643), StringComparison.CurrentCultureIgnoreCase);
              num2 = 23;
              continue;
            case 7:
              if (!NotificationTemplateFilter.qAnJnnwUksSEIJF31I2((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87826903)))
              {
                num2 = 9;
                continue;
              }
              goto case 8;
            case 8:
              this.ActionName = (string) NotificationTemplateFilter.obVNxjwz0G5A0QWZL9F(NotificationTemplateFilter.KgFIKNws7oQsbMPIdBB((object) xmlNode), NotificationTemplateFilter.mr5Qt7wc8I3T4ore376((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883328124)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 22 : 11;
              continue;
            case 9:
              if (!NotificationTemplateFilter.qAnJnnwUksSEIJF31I2((object) str, NotificationTemplateFilter.e3uU8qwJSDVsXs3TI4w(-1872275253 >> 6 ^ -29288497)))
              {
                num2 = 12;
                continue;
              }
              goto case 26;
            case 10:
            case 24:
              node1 = xmlNode as XmlElement;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 20 : 17;
              continue;
            case 11:
            case 12:
            case 14:
            case 22:
            case 23:
              xmlNode = (XmlNode) NotificationTemplateFilter.k2LLTuwYS01Jotau79p((object) xmlNode);
              num2 = 19;
              continue;
            case 13:
              xmlNode = (XmlNode) NotificationTemplateFilter.k2LLTuwYS01Jotau79p((object) xmlNode);
              num2 = 4;
              continue;
            case 15:
              if (((XmlAttributeCollection) NotificationTemplateFilter.t7QAWX4F2uqisDmXslA((object) xmlNode))[(string) NotificationTemplateFilter.e3uU8qwJSDVsXs3TI4w(236071375 ^ 236102731)] != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 6 : 6;
                continue;
              }
              goto case 11;
            case 16:
              goto label_27;
            case 18:
              goto label_25;
            case 20:
              if (node1 != null)
              {
                num2 = 25;
                continue;
              }
              goto case 13;
            case 21:
              if (!NotificationTemplateFilter.qAnJnnwUksSEIJF31I2((object) str, NotificationTemplateFilter.e3uU8qwJSDVsXs3TI4w(-1217523399 ^ -1217487761)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 26:
              this.Condition = new NotificationTemplateFilterCondition(node1);
              num2 = 14;
              continue;
            default:
              if (!(str == (string) NotificationTemplateFilter.e3uU8qwJSDVsXs3TI4w(1033719030 - 2012070891 ^ -978385809)))
                goto case 7;
              else
                goto label_22;
          }
        }
label_22:
        num1 = 2;
        continue;
label_25:
        xmlNode = node.FirstChild;
        num1 = 17;
      }
label_27:
      return;
label_26:;
    }

    private bool IsChildOf(IAuditObject obj, string name)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (NotificationTemplateFilter.Mm86Ss4brdnqNrpucCk((object) obj) != null)
              {
                num2 = 3;
                continue;
              }
              goto label_11;
            case 2:
              goto label_11;
            case 3:
              goto label_10;
            case 4:
            case 6:
              goto label_14;
            case 5:
              goto label_7;
            case 7:
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 6 : 4;
                continue;
              }
              goto default;
            default:
              if (obj.Name == null)
              {
                num2 = 4;
                continue;
              }
              if (!NotificationTemplateFilter.oMvV9Wwd4Dy2mXFv1O0(NotificationTemplateFilter.UXumUx4on14q54FF87Y((object) obj), (object) name, StringComparison.CurrentCultureIgnoreCase))
              {
                if (!this.ObjectInherit)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 2 : 2;
                  continue;
                }
                goto case 1;
              }
              else
                goto label_16;
          }
        }
label_16:
        num1 = 5;
      }
label_7:
      return true;
label_10:
      return this.IsChildOf((IAuditObject) NotificationTemplateFilter.Mm86Ss4brdnqNrpucCk((object) obj), name);
label_11:
      return false;
label_14:
      return false;
    }

    internal static bool l413SlwyxxOkbK1v84P() => NotificationTemplateFilter.RdmUjZwmSCCxhUEkMHP == null;

    internal static NotificationTemplateFilter zKUoqYwMh9O49iGR0O5() => NotificationTemplateFilter.RdmUjZwmSCCxhUEkMHP;

    internal static object e3uU8qwJSDVsXs3TI4w(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object v63NQBw9bkndBXGlYrd([In] object obj0) => (object) ((IEventNotification) obj0).Event;

    internal static bool oMvV9Wwd4Dy2mXFv1O0([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static object MKLD6ywlKSSR1QtndGt([In] object obj0) => (object) ((IEventNotification) obj0).Object;

    internal static object hshaPtwrQreJLHt5LwP([In] object obj0) => (object) ((IEventNotification) obj0).Action;

    internal static object QRdOyowgLFS7pkc7XUW([In] object obj0) => (object) ((IAuditAction) obj0).Name;

    internal static bool ngM3tJw558gCcTk7PQd([In] object obj0, [In] object obj1) => ((NotificationTemplateFilterCondition) obj0).Evaluate(obj1);

    internal static void bv6DP0wj3rXbfk6tBf3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object k2LLTuwYS01Jotau79p([In] object obj0) => (object) ((XmlNode) obj0).NextSibling;

    internal static object g8Si4kwLSJRxjLsomde([In] object obj0) => (object) ((XmlNode) obj0).Name;

    internal static bool qAnJnnwUksSEIJF31I2([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object KgFIKNws7oQsbMPIdBB([In] object obj0) => (object) ((XmlNode) obj0).InnerXml;

    internal static object mr5Qt7wc8I3T4ore376([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object obVNxjwz0G5A0QWZL9F([In] object obj0, [In] object obj1) => (object) ((string) obj0).Trim((char[]) obj1);

    internal static object t7QAWX4F2uqisDmXslA([In] object obj0) => (object) ((XmlNode) obj0).Attributes;

    internal static object UQABG14Ba5ArHgLh0UP([In] object obj0, [In] object obj1) => (object) ((XmlAttributeCollection) obj0)[(string) obj1];

    internal static object eO9U0e4WR7gh7pnLduc([In] object obj0) => (object) ((XmlNode) obj0).Value;

    internal static object UXumUx4on14q54FF87Y([In] object obj0) => (object) ((IAuditObject) obj0).Name;

    internal static object Mm86Ss4brdnqNrpucCk([In] object obj0) => (object) ((IAuditObject) obj0).Parent;
  }
}
