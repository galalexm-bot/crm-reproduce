// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationRecipientItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Элемент набора получателей оповещения</summary>
  public class NotificationRecipientItem
  {
    private readonly ExpressionTemplateEvaluator expressionEvaluator;
    internal static NotificationRecipientItem HHZvCutdnbvHbVti8eL;

    /// <summary>Имя типа элемента</summary>
    public string TypeName
    {
      get => this.\u003CTypeName\u003Ek__BackingField;
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
              this.\u003CTypeName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
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

    /// <summary>Шаблон выражения, задающий получателя</summary>
    public string ExpressionText
    {
      get => this.\u003CExpressionText\u003Ek__BackingField;
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
              this.\u003CExpressionText\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    /// <summary>Получить список получателей (пользователей)</summary>
    /// <param name="notification">Оповещение</param>
    /// <returns>Список получателей (пользователей). Или null, если ну удалось определить список</returns>
    public IEnumerable<object> GetRecipients(INotification notification)
    {
      if (this.expressionEvaluator == null)
        return (IEnumerable<object>) null;
      if (this.Condition != null && !this.Condition.Evaluate((object) notification))
        return (IEnumerable<object>) null;
      INotificationRecipientTypeHandler recipientTypeHandler = ComponentManager.Current.GetExtensionPoints<INotificationRecipientTypeHandler>().FirstOrDefault<INotificationRecipientTypeHandler>((Func<INotificationRecipientTypeHandler, bool>) (rth => NotificationRecipientItem.MsZ7AWwBIwuhdGrl8aI(NotificationRecipientItem.HhtYPOwFLQ1liaGKL5e((object) rth), (object) this.TypeName)));
      if (recipientTypeHandler == null)
      {
        Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858918321), (object) this.TypeName));
        return (IEnumerable<object>) null;
      }
      object obj = this.expressionEvaluator.Evaluate((object) notification)?.Value;
      return recipientTypeHandler.GetRecipients(obj);
    }

    /// <summary>Ctor</summary>
    /// <param name="node">Элемент документа XML</param>
    public NotificationRecipientItem(XmlElement node)
    {
      NotificationRecipientItem.PEWfyBtgavkwew23aZ8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num1 = 0;
      XmlAttribute xmlAttribute;
      while (true)
      {
        switch (num1)
        {
          case 1:
            xmlAttribute = ((XmlAttributeCollection) NotificationRecipientItem.n0QqJJtUDq7SHOjk5E4((object) node))[(string) NotificationRecipientItem.ViB08Lt5l0M6XCvChoW(-441065788 ^ -2092910478 ^ 1727392978)];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 4 : 4;
            continue;
          case 2:
          case 9:
          case 10:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          case 3:
            if (node == null)
            {
              num1 = 7;
              continue;
            }
            this.TypeName = (string) NotificationRecipientItem.u4Dw1TtjThF7MaYwBdC((object) node);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 11 : 11;
            continue;
          case 4:
            if (xmlAttribute == null)
            {
              num1 = 10;
              continue;
            }
            goto case 5;
          case 5:
            if (xmlAttribute.Value == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 0;
              continue;
            }
            goto case 6;
          case 6:
            this.Condition = new NotificationTemplateFilterCondition((string) NotificationRecipientItem.M07qwptsl8ViZd3Cw7D((object) xmlAttribute));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 4 : 9;
            continue;
          case 7:
            goto label_5;
          case 8:
            goto label_27;
          case 11:
            this.ExpressionText = ((string) NotificationRecipientItem.Xn9C6etYZuNxEug8u4B((object) node)).Trim((char[]) NotificationRecipientItem.gca7mbtLUxokMAsKwiL(NotificationRecipientItem.ViB08Lt5l0M6XCvChoW(1597012150 ^ 1596993274)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
            continue;
          default:
            goto label_12;
        }
      }
label_27:
      return;
label_5:
      throw new ArgumentNullException((string) NotificationRecipientItem.ViB08Lt5l0M6XCvChoW(1178210108 ^ 1178240356));
label_12:
      try
      {
        int num2;
        if (NotificationRecipientItem.vPrh0ktc0L6XAgislry((object) this.ExpressionText))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 2 : 2;
        else
          goto label_16;
label_15:
        switch (num2)
        {
          case 1:
            return;
          case 2:
            return;
        }
label_16:
        this.expressionEvaluator = new ExpressionTemplateEvaluator(this.ExpressionText);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        {
          num2 = 1;
          goto label_15;
        }
        else
          goto label_15;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new Exception((string) NotificationRecipientItem.CW8GnntzYEiuPTSawKg(NotificationRecipientItem.ViB08Lt5l0M6XCvChoW(1012087039 ^ 1012121423), (object) this.ExpressionText), ex);
        }
      }
    }

    internal static bool zPgdXutl9wDG9a7HbSq() => NotificationRecipientItem.HHZvCutdnbvHbVti8eL == null;

    internal static NotificationRecipientItem amxTqNtrGmtwh0h3FYW() => NotificationRecipientItem.HHZvCutdnbvHbVti8eL;

    internal static void PEWfyBtgavkwew23aZ8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object ViB08Lt5l0M6XCvChoW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object u4Dw1TtjThF7MaYwBdC([In] object obj0) => (object) ((XmlNode) obj0).Name;

    internal static object Xn9C6etYZuNxEug8u4B([In] object obj0) => (object) ((XmlNode) obj0).InnerXml;

    internal static object gca7mbtLUxokMAsKwiL([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object n0QqJJtUDq7SHOjk5E4([In] object obj0) => (object) ((XmlNode) obj0).Attributes;

    internal static object M07qwptsl8ViZd3Cw7D([In] object obj0) => (object) ((XmlNode) obj0).Value;

    internal static bool vPrh0ktc0L6XAgislry([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object CW8GnntzYEiuPTSawKg([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object HhtYPOwFLQ1liaGKL5e([In] object obj0) => (object) ((INotificationRecipientTypeHandler) obj0).Name;

    internal static bool MsZ7AWwBIwuhdGrl8aI([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;
  }
}
