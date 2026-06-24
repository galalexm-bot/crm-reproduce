// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationTemplate
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Messaging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Стандартный шаблон оповещения</summary>
  public class NotificationTemplate : NotificationTemplateBase
  {
    private readonly NotificationTemplateFileInfo fileInfo;
    private readonly string name;
    private readonly string parentName;
    private readonly string defaultName;
    private bool defaultLoaded;
    private NotificationTemplate @default;
    private readonly NotificationTemplateFilter filter;
    private readonly string channels;
    private readonly List<NotificationRecipientSet> recipientSets;
    private readonly bool? recipientSetsClear;
    private readonly string url;
    private readonly string subject;
    private readonly string author;
    private readonly NotificationTemplateFilterCondition authorOverrideCondition;
    private readonly string shortMessage;
    private readonly NotificationTemplateFilterCondition shortMessageOverrideCondition;
    private readonly string fullMessage;
    private readonly NotificationTemplateFilterCondition fullMessageOverrideCondition;
    private readonly NotificationTemplateObject objectTemplate;
    private readonly NotificationTemplateFilterCondition sendToAuthorCondition;
    private readonly NotificationTemplateFilterCondition subjectOverrideCondition;
    private CustomMessage[] customMessages;
    private static NotificationTemplate pWHfCG6vgsOMj2LAVxi;

    /// <summary>Информация о файле шаблонов</summary>
    public override NotificationTemplateFileInfo FileInfo => this.fileInfo;

    /// <summary>Имя шаблона</summary>
    public override string Name => this.name;

    /// <summary>
    /// Имя родительского оповещения (в формате "Имя файла шаблонов без расширения/Имя оповещения")
    /// </summary>
    public string ParentName => this.parentName;

    /// <summary>Шаблон со значениями по умолчанию</summary>
    public NotificationTemplate Default
    {
      get
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          string str;
          while (true)
          {
            object obj;
            switch (num2)
            {
              case 1:
                if (!(this.defaultName == string.Empty))
                {
                  num2 = 5;
                  continue;
                }
                goto label_10;
              case 2:
                if (!this.defaultLoaded)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
                  continue;
                }
                goto label_9;
              case 3:
                goto label_9;
              case 4:
                goto label_10;
              case 5:
                obj = (object) this.defaultName;
                if (obj == null)
                {
                  num2 = 7;
                  continue;
                }
                break;
              case 6:
                this.defaultLoaded = true;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 3;
                continue;
              case 7:
                obj = NotificationTemplate.u5wFYi6uInyKWCPklIB((object) this.fileInfo);
                break;
              default:
                goto label_3;
            }
            str = (string) obj;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
          }
label_3:
          this.@default = (NotificationTemplate) NotificationTemplate.BaekG26IYe8evL7wF7c((object) this.fileInfo.Loader, (object) this.fileInfo, (object) str);
          num1 = 6;
        }
label_9:
        return this.@default;
label_10:
        return (NotificationTemplate) null;
      }
    }

    /// <summary>
    /// Фильтр, определяющий, в каком случае нужно применять данный шаблон
    /// </summary>
    public NotificationTemplateFilter Filter => this.filter;

    /// <summary>Каналы</summary>
    public override string Channels => this.channels;

    /// <summary>Базовый шаблон, срдержащий данный шаблон</summary>
    public override NotificationTemplateBase ChannelsTemplateBase => (NotificationTemplateBase) this;

    /// <summary>Наборы получателей оповещения</summary>
    public override List<NotificationRecipientSet> RecipientSets => this.recipientSets;

    /// <summary>URL</summary>
    public override string URL => this.url;

    /// <summary>Очистить все наборы получателей оповещения.</summary>
    public override bool? RecipientSetsClear => this.recipientSetsClear;

    /// <summary>Базовый шаблон, содержащий данный шаблон URL</summary>
    public override NotificationTemplateBase URLTemplateBase => (NotificationTemplateBase) this;

    /// <summary>Автор</summary>
    /// <param name="notificationDataSource"></param>
    /// <returns></returns>
    public override string GetAuthor(object notificationDataSource) => this.author;

    /// <summary>Автор переопределен</summary>
    /// <param name="notificationDataSource"></param>
    public override bool IsAuthorOverride(object notificationDataSource)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.authorOverrideCondition == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return this.authorOverrideCondition.Evaluate(notificationDataSource);
label_5:
      return false;
    }

    /// <summary>Базовый шаблон, содержащий данный шаблон автора</summary>
    /// <param name="notificationDataSource"></param>
    public override NotificationTemplateBase GetAuthorTemplateBase(object notificationDataSource) => (NotificationTemplateBase) this;

    /// <summary>Тема</summary>
    /// <param name="notificationDataSource"></param>
    public override string GetSubject(object notificationDataSource) => this.subject;

    /// <summary>Тема переопределена</summary>
    /// <param name="notificationDataSource"></param>
    public override bool IsSubjectOverride(object notificationDataSource)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.subjectOverrideCondition != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return NotificationTemplate.Phh5qK6VoLwye2APyNN((object) this.subjectOverrideCondition, notificationDataSource);
label_5:
      return false;
    }

    /// <summary>Базовый шаблон, содержащий данный шаблон темы</summary>
    /// <param name="notificationDataSource"></param>
    public override NotificationTemplateBase GetSubjectTemplateBase(object notificationDataSource) => (NotificationTemplateBase) this;

    /// <summary>Короткое сообщение</summary>
    /// <param name="notificationDataSource"></param>
    public override string GetShortMessage(object notificationDataSource) => this.shortMessage;

    /// <summary>Короткое сообщение переопределено</summary>
    /// <param name="notificationDataSource"></param>
    public override bool IsShortMessageOverride(object notificationDataSource)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.shortMessageOverrideCondition == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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
      return NotificationTemplate.Phh5qK6VoLwye2APyNN((object) this.shortMessageOverrideCondition, notificationDataSource);
label_5:
      return false;
    }

    /// <summary>
    /// Базовый шаблон, содержащий данный шаблон короткого сообщения
    /// </summary>
    /// <param name="notificationDataSource"></param>
    public override NotificationTemplateBase GetShortMessageTemplateBase(
      object notificationDataSource)
    {
      return (NotificationTemplateBase) this;
    }

    /// <summary>Полное сообщение</summary>
    /// <param name="notificationDataSource"></param>
    public override string GetFullMessage(object notificationDataSource) => this.fullMessage;

    /// <summary>Полное сообщение переопределено</summary>
    /// <param name="notificationDataSource"></param>
    public override bool IsFullMessageOverride(object notificationDataSource)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.fullMessageOverrideCondition != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return NotificationTemplate.Phh5qK6VoLwye2APyNN((object) this.fullMessageOverrideCondition, notificationDataSource);
label_5:
      return false;
    }

    /// <summary>
    /// Базовый шаблон, содержащий данный шаблон полного сообщения
    /// </summary>
    /// <param name="notificationDataSource"></param>
    public override NotificationTemplateBase GetFullMessageTemplateBase(
      object notificationDataSource)
    {
      return (NotificationTemplateBase) this;
    }

    public void SetCustomMessages(CustomMessage[] customMessages)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.customMessages = customMessages;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override CustomMessage[] GetCustomMessages(object notificationDataSource) => this.customMessages;

    public override NotificationTemplateBase GetCustomMessagesTemplateBase(
      object notificationDataSource)
    {
      return (NotificationTemplateBase) this;
    }

    /// <summary>Ссылка на объект</summary>
    public override NotificationTemplateObject ObjectTemplate => this.objectTemplate;

    public override bool IsSendToAuthor(object notificationDataSource)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.sendToAuthorCondition == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return this.sendToAuthorCondition.Evaluate(notificationDataSource);
label_3:
      return false;
    }

    /// <summary>Проверить, удовлетворяет ли оповещение шаблону</summary>
    /// <param name="notification">Оповещение</param>
    /// <returns>True, если удовлетворяют</returns>
    public override bool CheckFilter(INotification notification)
    {
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_11;
          case 4:
            if (NotificationTemplate.wXoS7N6SFZul9iJZCDJ((object) this) == null)
            {
              num = 3;
              continue;
            }
            goto case 5;
          case 5:
            if (NotificationTemplate.FjLGxS6iOGT47xSbnSL((object) notification.TemplateName, NotificationTemplate.wXoS7N6SFZul9iJZCDJ((object) this), StringComparison.CurrentCultureIgnoreCase))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 6:
            goto label_6;
          case 7:
            if (notification != null)
            {
              if (notification.TemplateName == null)
              {
                num = 2;
                continue;
              }
              goto case 4;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 6 : 2;
              continue;
            }
          default:
            goto label_12;
        }
      }
label_6:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712446393));
label_11:
      return false;
label_12:
      return NotificationTemplate.ckqAyD6R2dCkqtIJBVd((object) this.Filter, (object) notification);
    }

    /// <summary>Загрузка из XML</summary>
    /// <param name="fileInfo">Файл шаблонов</param>
    /// <param name="node">Узел документа XML</param>
    public NotificationTemplate(NotificationTemplateFileInfo fileInfo, XmlElement node)
    {
      NotificationTemplate.q7lFrW6qsNb2usSglRX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 99;
      while (true)
      {
        int num2;
        uint num3;
        XmlNode xmlNode;
        string str;
        string expressionText;
        XmlElement node1;
        NotificationRecipientSet notificationRecipientSet;
        switch (num1)
        {
          case 4:
          case 36:
            xmlNode = (XmlNode) NotificationTemplate.FXogur6n5iCuPJMyoZ8((object) node);
            num1 = 11;
            continue;
          case 5:
            if (num3 <= 2180989045U)
            {
              num1 = 115;
              continue;
            }
            goto case 87;
          case 6:
            if (NotificationTemplate.uMyuMZ6TgLRMDT5qQeO(NotificationTemplate.JMwum76K3nshCLQ6ISr((object) xmlNode), NotificationTemplate.DWl5a36Xr7CtEvgbIZg(1581325282 << 3 ^ -234336704)) == null)
            {
              num2 = 67;
              break;
            }
            goto case 23;
          case 7:
          case 54:
            NotificationTemplate.TiEMn46N8lasLxEawpd((object) this.filter, (object) node1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 76 : 70;
            continue;
          case 9:
          case 11:
          case 72:
            if (xmlNode != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 45 : 26;
              continue;
            }
            goto label_114;
          case 10:
            this.customMessages = new CustomMessage[0];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 3 : 0;
            continue;
          case 12:
            if (num3 != 3873537942U)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 9 : 47;
              continue;
            }
            goto case 56;
          case 13:
          case 88:
            this.shortMessage = expressionText;
            num1 = 57;
            continue;
          case 17:
            str = (string) NotificationTemplate.iZHM9P6e4s1R9IYeFWQ(NotificationTemplate.G5Xirq62iXhfCLnfAqo((object) xmlNode));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 102 : 118;
            continue;
          case 18:
            if (!(str == (string) NotificationTemplate.DWl5a36Xr7CtEvgbIZg(-542721635 ^ -542758749)))
            {
              num1 = 81;
              continue;
            }
            goto case 64;
          case 21:
            if (num3 != 2631317565U)
            {
              num1 = 39;
              continue;
            }
            goto case 63;
          case 22:
            this.name = ((XmlAttributeCollection) NotificationTemplate.JMwum76K3nshCLQ6ISr((object) node))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124626766)].Value;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 55 : 73;
            continue;
          case 23:
            if (NotificationTemplate.zPT8sg6paJOpt7MXkKf(NotificationTemplate.Vywpw06ktZHyA521CEn((object) ((XmlAttributeCollection) NotificationTemplate.JMwum76K3nshCLQ6ISr((object) xmlNode))[(string) NotificationTemplate.DWl5a36Xr7CtEvgbIZg(572119659 - -337058038 ^ 909140529)])))
            {
              num1 = 114;
              continue;
            }
            goto case 69;
          case 25:
            if (num3 != 510073957U)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 55 : 33;
              continue;
            }
            goto case 116;
          case 27:
            this.parentName = (string) NotificationTemplate.Vywpw06ktZHyA521CEn(NotificationTemplate.uMyuMZ6TgLRMDT5qQeO(NotificationTemplate.JMwum76K3nshCLQ6ISr((object) node), NotificationTemplate.DWl5a36Xr7CtEvgbIZg(~541731958 ^ -541768769)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 119 : 87;
            continue;
          case 28:
            if (NotificationTemplate.ARDVLK616D3WjOshe5D((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767757533)))
            {
              num1 = 88;
              continue;
            }
            goto default;
          case 30:
            if (node1 == null)
            {
              num1 = 59;
              continue;
            }
            goto case 60;
          case 31:
            if (!string.IsNullOrWhiteSpace((string) NotificationTemplate.Vywpw06ktZHyA521CEn((object) xmlNode.Attributes[(string) NotificationTemplate.DWl5a36Xr7CtEvgbIZg(1470440286 ^ 1470476814)])))
            {
              num1 = 40;
              continue;
            }
            goto default;
          case 34:
          case 108:
            this.url = expressionText;
            num1 = 32;
            continue;
          case 35:
            this.recipientSets = new List<NotificationRecipientSet>();
            num1 = 38;
            continue;
          case 37:
            if (num3 != 290803319U)
            {
              num2 = 25;
              break;
            }
            goto case 102;
          case 38:
            if (((XmlAttributeCollection) NotificationTemplate.JMwum76K3nshCLQ6ISr((object) node))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998535430)] != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 11 : 22;
              continue;
            }
            goto case 73;
          case 39:
            if (num3 != 3788036667U)
            {
              num1 = 16;
              continue;
            }
            goto case 58;
          case 40:
            this.subjectOverrideCondition = new NotificationTemplateFilterCondition((string) NotificationTemplate.Vywpw06ktZHyA521CEn(NotificationTemplate.uMyuMZ6TgLRMDT5qQeO(NotificationTemplate.JMwum76K3nshCLQ6ISr((object) xmlNode), NotificationTemplate.DWl5a36Xr7CtEvgbIZg(~210725948 ^ -210763117))));
            num1 = 74;
            continue;
          case 41:
          case 45:
            node1 = xmlNode as XmlElement;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 30 : 0;
            continue;
          case 44:
          case 51:
            this.fullMessage = expressionText;
            num1 = 6;
            continue;
          case 46:
            this.filter = new NotificationTemplateFilter();
            num2 = 35;
            break;
          case 47:
            if (num3 != 3988852052U)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 89 : 21;
              continue;
            }
            goto case 28;
          case 48:
            this.authorOverrideCondition = new NotificationTemplateFilterCondition(((XmlNode) NotificationTemplate.uMyuMZ6TgLRMDT5qQeO(NotificationTemplate.JMwum76K3nshCLQ6ISr((object) xmlNode), NotificationTemplate.DWl5a36Xr7CtEvgbIZg(654297945 ^ 654268937))).Value);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 77;
            continue;
          case 52:
            notificationRecipientSet = new NotificationRecipientSet(node1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 62 : 58;
            continue;
          case 55:
            if (num3 != 931238212U)
            {
              num2 = 20;
              break;
            }
            goto case 18;
          case 56:
            if (NotificationTemplate.ARDVLK616D3WjOshe5D((object) str, NotificationTemplate.DWl5a36Xr7CtEvgbIZg(-1487388570 ^ -1487351600)))
            {
              num1 = 93;
              continue;
            }
            goto default;
          case 57:
            if (NotificationTemplate.uMyuMZ6TgLRMDT5qQeO((object) xmlNode.Attributes, NotificationTemplate.DWl5a36Xr7CtEvgbIZg(1642859704 ^ 1642896872)) != null)
            {
              num1 = 83;
              continue;
            }
            goto default;
          case 58:
            if (NotificationTemplate.ARDVLK616D3WjOshe5D((object) str, NotificationTemplate.DWl5a36Xr7CtEvgbIZg(901793403 ^ 901830287)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 44 : 32;
              continue;
            }
            goto default;
          case 59:
            xmlNode = xmlNode.NextSibling;
            num1 = 9;
            continue;
          case 60:
            expressionText = (string) NotificationTemplate.KeQr8x6OC2WAo6dVJUV((object) xmlNode);
            num1 = 17;
            continue;
          case 62:
            this.recipientSets.Add(notificationRecipientSet);
            num1 = 42;
            continue;
          case 63:
            if (NotificationTemplate.ARDVLK616D3WjOshe5D((object) str, NotificationTemplate.DWl5a36Xr7CtEvgbIZg(1051276242 - 990076387 ^ 61162701)))
            {
              num2 = 109;
              break;
            }
            goto default;
          case 64:
            if (string.IsNullOrWhiteSpace(expressionText))
            {
              num1 = 50;
              continue;
            }
            goto case 10;
          case 65:
          case 109:
            if (string.IsNullOrWhiteSpace(expressionText))
            {
              num1 = 43;
              continue;
            }
            goto case 68;
          case 66:
            if (num3 != 1969840958U)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 15 : 96;
              continue;
            }
            goto case 86;
          case 68:
            this.sendToAuthorCondition = new NotificationTemplateFilterCondition(expressionText);
            num1 = 117;
            continue;
          case 69:
            this.fullMessageOverrideCondition = new NotificationTemplateFilterCondition((string) NotificationTemplate.Vywpw06ktZHyA521CEn((object) ((XmlAttributeCollection) NotificationTemplate.JMwum76K3nshCLQ6ISr((object) xmlNode))[(string) NotificationTemplate.DWl5a36Xr7CtEvgbIZg(~541731958 ^ -541768999)]));
            num1 = 61;
            continue;
          case 70:
            if (!(str == (string) NotificationTemplate.DWl5a36Xr7CtEvgbIZg(~210725948 ^ -210763059)))
            {
              num1 = 111;
              continue;
            }
            goto case 84;
          case 71:
            if (NotificationTemplate.uMyuMZ6TgLRMDT5qQeO(NotificationTemplate.JMwum76K3nshCLQ6ISr((object) xmlNode), NotificationTemplate.DWl5a36Xr7CtEvgbIZg(-1290212282 ^ -644262414 ^ 1786849508)) == null)
            {
              num1 = 29;
              continue;
            }
            goto case 31;
          case 73:
            if (((XmlAttributeCollection) NotificationTemplate.JMwum76K3nshCLQ6ISr((object) node))[(string) NotificationTemplate.DWl5a36Xr7CtEvgbIZg(-1380439818 << 3 ^ 1841420166)] != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 27 : 11;
              continue;
            }
            goto case 119;
          case 78:
          case 100:
            if (num3 != 1418384879U)
            {
              num1 = 66;
              continue;
            }
            goto case 105;
          case 79:
          case 90:
            this.recipientSetsClear = new bool?(NotificationTemplate.Q4hbj763Er8vTrFKXDl((object) expressionText));
            num2 = 15;
            break;
          case 83:
            if (NotificationTemplate.zPT8sg6paJOpt7MXkKf(NotificationTemplate.Vywpw06ktZHyA521CEn(NotificationTemplate.uMyuMZ6TgLRMDT5qQeO(NotificationTemplate.JMwum76K3nshCLQ6ISr((object) xmlNode), NotificationTemplate.DWl5a36Xr7CtEvgbIZg(-1426456882 ^ 2009939514 ^ -583773788)))))
            {
              num1 = 82;
              continue;
            }
            goto case 103;
          case 84:
            this.objectTemplate = new NotificationTemplateObject(node1);
            num1 = 107;
            continue;
          case 86:
            if (str == z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889488660))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 12 : 34;
              continue;
            }
            goto default;
          case 87:
            if (num3 <= 3788036667U)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 98 : 27;
              continue;
            }
            goto case 12;
          case 89:
            if (num3 != 4003449272U)
            {
              num1 = 53;
              continue;
            }
            goto case 113;
          case 91:
            goto label_115;
          case 92:
            if (NotificationTemplate.zPT8sg6paJOpt7MXkKf(NotificationTemplate.Vywpw06ktZHyA521CEn(NotificationTemplate.uMyuMZ6TgLRMDT5qQeO(NotificationTemplate.JMwum76K3nshCLQ6ISr((object) xmlNode), NotificationTemplate.DWl5a36Xr7CtEvgbIZg(1304605005 ^ 1304567837)))))
            {
              num1 = 19;
              continue;
            }
            goto case 48;
          case 93:
          case 110:
            this.author = expressionText;
            num1 = 94;
            continue;
          case 94:
            if (NotificationTemplate.uMyuMZ6TgLRMDT5qQeO((object) xmlNode.Attributes, NotificationTemplate.DWl5a36Xr7CtEvgbIZg(-105199646 ^ -105228622)) == null)
            {
              num1 = 8;
              continue;
            }
            goto case 92;
          case 95:
            if (!NotificationTemplate.ARDVLK616D3WjOshe5D((object) str, NotificationTemplate.DWl5a36Xr7CtEvgbIZg(~-122002947 ^ 121966164)))
            {
              num2 = 75;
              break;
            }
            goto case 101;
          case 96:
            if (num3 != 2180989045U)
            {
              num1 = 106;
              continue;
            }
            goto case 95;
          case 97:
            this.defaultName = (string) NotificationTemplate.Vywpw06ktZHyA521CEn(NotificationTemplate.uMyuMZ6TgLRMDT5qQeO((object) node.Attributes, NotificationTemplate.DWl5a36Xr7CtEvgbIZg(236071375 ^ 236103001)));
            num1 = 4;
            continue;
          case 98:
            if (num3 != 2374511479U)
            {
              num1 = 21;
              continue;
            }
            goto case 70;
          case 99:
            this.fileInfo = fileInfo;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 20 : 46;
            continue;
          case 101:
            this.channels = expressionText;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 11 : 24;
            continue;
          case 102:
            if (str == (string) NotificationTemplate.DWl5a36Xr7CtEvgbIZg(-1204263869 ^ -1341583247 ^ 137487476))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 7 : 1;
              continue;
            }
            goto default;
          case 103:
            this.shortMessageOverrideCondition = new NotificationTemplateFilterCondition((string) NotificationTemplate.Vywpw06ktZHyA521CEn(NotificationTemplate.uMyuMZ6TgLRMDT5qQeO(NotificationTemplate.JMwum76K3nshCLQ6ISr((object) xmlNode), NotificationTemplate.DWl5a36Xr7CtEvgbIZg(589593376 ^ -1977315327 ^ -1459586447))));
            num1 = 2;
            continue;
          case 105:
            if (!NotificationTemplate.ARDVLK616D3WjOshe5D((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132941305)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 33 : 19;
              continue;
            }
            goto case 112;
          case 112:
            this.subject = expressionText;
            num1 = 71;
            continue;
          case 113:
            if (!NotificationTemplate.ARDVLK616D3WjOshe5D((object) str, NotificationTemplate.DWl5a36Xr7CtEvgbIZg(825385222 ^ 825422188)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 75 : 85;
              continue;
            }
            goto case 52;
          case 115:
            if (num3 > 931238212U)
            {
              num1 = 100;
              continue;
            }
            goto case 37;
          case 116:
            if (NotificationTemplate.ARDVLK616D3WjOshe5D((object) str, NotificationTemplate.DWl5a36Xr7CtEvgbIZg(-1598106783 - -968262081 ^ -629815900)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 14 : 90;
              continue;
            }
            goto default;
          case 118:
            num3 = NotificationTemplate.OsAgAt6P9nT0lu4d4c6((object) str);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 5 : 5;
            continue;
          case 119:
            if (NotificationTemplate.uMyuMZ6TgLRMDT5qQeO(NotificationTemplate.JMwum76K3nshCLQ6ISr((object) node), NotificationTemplate.DWl5a36Xr7CtEvgbIZg(-218496594 ^ -218460872)) == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 19 : 36;
              continue;
            }
            goto case 97;
          default:
            xmlNode = (XmlNode) NotificationTemplate.Uk5j5H6aLshix5DU1MR((object) xmlNode);
            num1 = 72;
            continue;
        }
        num1 = num2;
      }
label_115:
      return;
label_114:;
    }

    /// <summary>
    /// Получить содержимое элемента XML и обрезать переносы строк, табуляцию и пробелы в началах строк, если у элемента не установлен атрибут trim в false
    /// </summary>
    /// <param name="node">Элемент XML</param>
    /// <returns>Содержимое элемента</returns>
    public static string GetContentAndTrim(XmlNode node)
    {
      int num = 7;
      string contentAndTrim;
      string[] source;
      while (true)
      {
        XmlNodeType nodeType;
        switch (num)
        {
          case 1:
          case 19:
            contentAndTrim = (string) NotificationTemplate.mIl1gV6DunvJj8ljYQ8((object) node);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 12;
            continue;
          case 2:
          case 3:
          case 12:
          case 20:
            if (NotificationTemplate.uMyuMZ6TgLRMDT5qQeO((object) node.Attributes, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740309840)) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            }
            break;
          case 4:
            goto label_29;
          case 5:
            if (NotificationTemplate.r8k5uG6wF1bysJKrCAZ((object) node.ChildNodes) == 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 5 : 18;
              continue;
            }
            goto case 16;
          case 6:
          case 9:
            goto label_17;
          case 7:
            if (node == null)
            {
              num = 6;
              continue;
            }
            goto case 8;
          case 8:
            if (NotificationTemplate.mIl1gV6DunvJj8ljYQ8((object) node) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 10 : 6;
              continue;
            }
            goto case 5;
          case 10:
            if (NotificationTemplate.Ux9OXU6t15wr8cMBf8y((object) node) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 5 : 0;
              continue;
            }
            goto label_17;
          case 11:
            if (nodeType != XmlNodeType.CDATA)
            {
              num = 19;
              continue;
            }
            goto case 15;
          case 13:
            nodeType = ((XmlNode) NotificationTemplate.FXogur6n5iCuPJMyoZ8((object) node)).NodeType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 19 : 21;
            continue;
          case 14:
            source = (string[]) NotificationTemplate.pPkmQc66st1bIOj8RLC((object) contentAndTrim, (object) new string[1]
            {
              (string) NotificationTemplate.DWl5a36Xr7CtEvgbIZg(272623989 ^ 272599627)
            }, StringSplitOptions.None);
            num = 4;
            continue;
          case 15:
            contentAndTrim = (string) NotificationTemplate.Ux9OXU6t15wr8cMBf8y(NotificationTemplate.FXogur6n5iCuPJMyoZ8((object) node));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 2 : 1;
            continue;
          case 16:
            contentAndTrim = (string) NotificationTemplate.mIl1gV6DunvJj8ljYQ8((object) node);
            num = 3;
            continue;
          case 17:
            contentAndTrim = (string) NotificationTemplate.Ux9OXU6t15wr8cMBf8y((object) node);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 16 : 20;
            continue;
          case 18:
            if (node.FirstChild != null)
            {
              num = 13;
              continue;
            }
            goto case 16;
          case 21:
            if (nodeType != XmlNodeType.Text)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 11 : 11;
              continue;
            }
            goto case 17;
          case 22:
            goto label_4;
          default:
            if (NotificationTemplate.FjLGxS6iOGT47xSbnSL((object) ((XmlNode) NotificationTemplate.uMyuMZ6TgLRMDT5qQeO(NotificationTemplate.JMwum76K3nshCLQ6ISr((object) node), NotificationTemplate.DWl5a36Xr7CtEvgbIZg(236071375 ^ 236107947))).Value, NotificationTemplate.DWl5a36Xr7CtEvgbIZg(--1333735954 ^ 1333733384), StringComparison.CurrentCultureIgnoreCase))
            {
              num = 22;
              continue;
            }
            break;
        }
        contentAndTrim = contentAndTrim.Trim((char[]) NotificationTemplate.TjU5XS64iOcYJlVKNI2((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852857272)));
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 4 : 14;
      }
label_4:
      return contentAndTrim;
label_17:
      return string.Empty;
label_29:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633489045), ((IEnumerable<string>) source).Select<string, string>((Func<string, string>) (s => (string) NotificationTemplate.\u003C\u003Ec.tdMx54fr0T5i3odb5RNa((object) s, NotificationTemplate.\u003C\u003Ec.M4PUpDfrxivkdA7eH7QE(NotificationTemplate.\u003C\u003Ec.Q22wZ7fr760fqUsIMjx5(1574260816 ^ 1574241820))))));
    }

    internal static object u5wFYi6uInyKWCPklIB([In] object obj0) => (object) ((NotificationTemplateFileInfo) obj0).DefaultName;

    internal static object BaekG26IYe8evL7wF7c([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((NotificationTemplateLoader) obj0).GetDefaultTemplate((NotificationTemplateFileInfo) obj1, (string) obj2);

    internal static bool P3VCxW68A7RExh9iNVN() => NotificationTemplate.pWHfCG6vgsOMj2LAVxi == null;

    internal static NotificationTemplate rXqYW06ZHKu5tZxR9WN() => NotificationTemplate.pWHfCG6vgsOMj2LAVxi;

    internal static bool Phh5qK6VoLwye2APyNN([In] object obj0, [In] object obj1) => ((NotificationTemplateFilterCondition) obj0).Evaluate(obj1);

    internal static object wXoS7N6SFZul9iJZCDJ([In] object obj0) => (object) ((NotificationTemplateBase) obj0).Name;

    internal static bool FjLGxS6iOGT47xSbnSL([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static bool ckqAyD6R2dCkqtIJBVd([In] object obj0, [In] object obj1) => ((NotificationTemplateFilter) obj0).Check((INotification) obj1);

    internal static void q7lFrW6qsNb2usSglRX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object JMwum76K3nshCLQ6ISr([In] object obj0) => (object) ((XmlNode) obj0).Attributes;

    internal static object DWl5a36Xr7CtEvgbIZg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object uMyuMZ6TgLRMDT5qQeO([In] object obj0, [In] object obj1) => (object) ((XmlAttributeCollection) obj0)[(string) obj1];

    internal static object Vywpw06ktZHyA521CEn([In] object obj0) => (object) ((XmlNode) obj0).Value;

    internal static object FXogur6n5iCuPJMyoZ8([In] object obj0) => (object) ((XmlNode) obj0).FirstChild;

    internal static object KeQr8x6OC2WAo6dVJUV([In] object obj0) => (object) NotificationTemplate.GetContentAndTrim((XmlNode) obj0);

    internal static object G5Xirq62iXhfCLnfAqo([In] object obj0) => (object) ((XmlNode) obj0).Name;

    internal static object iZHM9P6e4s1R9IYeFWQ([In] object obj0) => (object) ((string) obj0).ToUpper();

    internal static uint OsAgAt6P9nT0lu4d4c6([In] object obj0) => \u003CPrivateImplementationDetails\u003E.ComputeStringHash((string) obj0);

    internal static bool ARDVLK616D3WjOshe5D([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void TiEMn46N8lasLxEawpd([In] object obj0, [In] object obj1) => ((NotificationTemplateFilter) obj0).Parse((XmlElement) obj1);

    internal static bool Q4hbj763Er8vTrFKXDl([In] object obj0) => Convert.ToBoolean((string) obj0);

    internal static bool zPT8sg6paJOpt7MXkKf([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object Uk5j5H6aLshix5DU1MR([In] object obj0) => (object) ((XmlNode) obj0).NextSibling;

    internal static object mIl1gV6DunvJj8ljYQ8([In] object obj0) => (object) ((XmlNode) obj0).InnerXml;

    internal static object Ux9OXU6t15wr8cMBf8y([In] object obj0) => (object) ((XmlNode) obj0).InnerText;

    internal static int r8k5uG6wF1bysJKrCAZ([In] object obj0) => ((XmlNodeList) obj0).Count;

    internal static object TjU5XS64iOcYJlVKNI2([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object pPkmQc66st1bIOj8RLC([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);
  }
}
