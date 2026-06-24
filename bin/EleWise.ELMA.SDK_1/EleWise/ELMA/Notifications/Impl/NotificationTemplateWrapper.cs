// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationTemplateWrapper
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

namespace EleWise.ELMA.Notifications.Impl
{
  public class NotificationTemplateWrapper : NotificationTemplateBase
  {
    private readonly NotificationTemplateBase template;
    private readonly NotificationTemplateBase parent;
    private bool recipientSetsInitialized;
    private List<NotificationRecipientSet> recipientSets;
    internal static NotificationTemplateWrapper gZRb1mDtsCSmFm8tjZh;

    public NotificationTemplateWrapper(
      NotificationTemplateBase template,
      NotificationTemplateBase parent)
    {
      NotificationTemplateWrapper.DFke9bD6ByenHtvq6uV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.template = template;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          default:
            this.parent = parent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Информация о файле шаблонов</summary>
    public override NotificationTemplateFileInfo FileInfo => (NotificationTemplateFileInfo) NotificationTemplateWrapper.JmVwkXDHQKndQTUo6g0((object) this.template);

    /// <summary>Имя шаблона (для информации)</summary>
    public override string Name => (string) NotificationTemplateWrapper.aiJOkBDAdnsJDgjbCRg((object) this.template);

    public override string Channels
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.ChannelsTemplateBase == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return (string) null;
label_3:
        return (string) NotificationTemplateWrapper.Y6di6bDxNToaNf8qXeW(NotificationTemplateWrapper.nnXNfJD7U9V70aZERNU((object) this));
      }
    }

    /// <summary>Базовый шаблон, срдержащий данный шаблон</summary>
    public override NotificationTemplateBase ChannelsTemplateBase
    {
      get
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_7;
            case 2:
              if (this.parent != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
                continue;
              }
              goto label_6;
            case 3:
              goto label_8;
            case 4:
              if (NotificationTemplateWrapper.Y6di6bDxNToaNf8qXeW((object) this.template) != null)
              {
                num = 3;
                continue;
              }
              goto case 2;
            default:
              goto label_6;
          }
        }
label_6:
        return (NotificationTemplateBase) null;
label_7:
        return this.parent.ChannelsTemplateBase;
label_8:
        return (NotificationTemplateBase) NotificationTemplateWrapper.nnXNfJD7U9V70aZERNU((object) this.template);
      }
    }

    /// <summary>Наборы получателей оповещения</summary>
    public override List<NotificationRecipientSet> RecipientSets
    {
      get
      {
        if (!this.recipientSetsInitialized)
        {
          this.recipientSets = new List<NotificationRecipientSet>();
          if (this.parent != null && this.parent.RecipientSets != null)
            this.recipientSets.AddRange(this.parent.RecipientSets.Select<NotificationRecipientSet, NotificationRecipientSet>((Func<NotificationRecipientSet, NotificationRecipientSet>) (rs => (NotificationRecipientSet) NotificationTemplateWrapper.\u003C\u003Ec.nhqv26flSLFrfALoZUUb((object) rs))));
          if (this.template.RecipientSets != null)
          {
            foreach (NotificationRecipientSet recipientSet1 in this.template.RecipientSets)
            {
              NotificationRecipientSet recipientSet = recipientSet1;
              NotificationRecipientSet notificationRecipientSet = this.recipientSets.FirstOrDefault<NotificationRecipientSet>((Func<NotificationRecipientSet, bool>) (s => NotificationTemplateWrapper.\u003C\u003Ec__DisplayClass10_0.uvp30Mfl8YVOMxIw9JRn(NotificationTemplateWrapper.\u003C\u003Ec__DisplayClass10_0.A7OO7DflvJrWTCuGlILw((object) s), NotificationTemplateWrapper.\u003C\u003Ec__DisplayClass10_0.A7OO7DflvJrWTCuGlILw((object) recipientSet))));
              if (notificationRecipientSet != null && recipientSet1.Clear)
              {
                this.recipientSets.Remove(notificationRecipientSet);
                notificationRecipientSet = (NotificationRecipientSet) null;
              }
              if (notificationRecipientSet == null)
                this.recipientSets.Add(recipientSet1.Clone());
              else
                notificationRecipientSet.Items.AddRange((IEnumerable<NotificationRecipientItem>) recipientSet1.Items);
            }
          }
          if (this.RecipientSetsClear.HasValue && this.RecipientSetsClear.Value)
            this.recipientSets.Clear();
          this.recipientSetsInitialized = true;
        }
        return this.recipientSets;
      }
    }

    /// <summary>Очистить все наборы получателей оповещения.</summary>
    public override bool? RecipientSetsClear
    {
      get
      {
        if (this.template.RecipientSetsClear.HasValue)
          return new bool?(this.template.RecipientSetsClear.Value);
        return this.parent != null ? this.parent.RecipientSetsClear : new bool?();
      }
    }

    /// <summary>URL</summary>
    public override string URL
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (NotificationTemplateWrapper.NfCVbiD03fyRCEDZq5b((object) this) != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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
        return (string) null;
label_5:
        return this.URLTemplateBase.URL;
      }
    }

    /// <summary>Базовый шаблон, содержащий данный шаблон URL</summary>
    public override NotificationTemplateBase URLTemplateBase
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              goto label_4;
            case 3:
              if (this.template.URL != null)
              {
                num = 2;
                continue;
              }
              break;
          }
          if (this.parent == null)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
          else
            goto label_3;
        }
label_2:
        return (NotificationTemplateBase) null;
label_3:
        return (NotificationTemplateBase) NotificationTemplateWrapper.NfCVbiD03fyRCEDZq5b((object) this.parent);
label_4:
        return this.template.URLTemplateBase;
      }
    }

    /// <summary>Автор</summary>
    /// <param name="notificationDataSource"></param>
    /// <returns></returns>
    public override string GetAuthor(object notificationDataSource)
    {
      int num = 3;
      NotificationTemplateBase authorTemplateBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (authorTemplateBase != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            authorTemplateBase = this.GetAuthorTemplateBase(notificationDataSource);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 2 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return (string) null;
label_3:
      return authorTemplateBase.GetAuthor(notificationDataSource);
    }

    /// <summary>Автор переопределен</summary>
    /// <param name="notificationDataSource"></param>
    public override bool IsAuthorOverride(object notificationDataSource)
    {
      int num = 2;
      NotificationTemplateBase notificationTemplateBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (notificationTemplateBase != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            notificationTemplateBase = (NotificationTemplateBase) NotificationTemplateWrapper.CyYTHnDmuUTdjAf58uc((object) this, notificationDataSource);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return NotificationTemplateWrapper.DAyUcZDyIqdbbEZpLAn((object) notificationTemplateBase, notificationDataSource);
label_3:
      return false;
    }

    /// <summary>Базовый шаблон, содержащий данный шаблон автора</summary>
    /// <param name="notificationDataSource"></param>
    public override NotificationTemplateBase GetAuthorTemplateBase(object notificationDataSource)
    {
      int num = 8;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            if (NotificationTemplateWrapper.rXhaNwDMQSJVJyhIMwl((object) this.template, notificationDataSource) == null)
            {
              num = 6;
              continue;
            }
            goto label_4;
          case 2:
            goto label_3;
          case 3:
            if (!this.parent.IsAuthorOverride(notificationDataSource))
            {
              num = 4;
              continue;
            }
            goto label_5;
          case 5:
            goto label_2;
          case 6:
            if (this.parent != null)
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 7:
            goto label_8;
          case 8:
            if (!NotificationTemplateWrapper.DAyUcZDyIqdbbEZpLAn((object) this.template, notificationDataSource))
            {
              if (this.parent == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
                continue;
              }
              goto case 3;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 3 : 7;
              continue;
            }
          default:
            goto label_5;
        }
      }
label_2:
      return (NotificationTemplateBase) null;
label_3:
      return (NotificationTemplateBase) NotificationTemplateWrapper.CyYTHnDmuUTdjAf58uc((object) this.parent, notificationDataSource);
label_4:
      return (NotificationTemplateBase) NotificationTemplateWrapper.CyYTHnDmuUTdjAf58uc((object) this.template, notificationDataSource);
label_5:
      return (NotificationTemplateBase) NotificationTemplateWrapper.CyYTHnDmuUTdjAf58uc((object) this.parent, notificationDataSource);
label_8:
      return (NotificationTemplateBase) NotificationTemplateWrapper.CyYTHnDmuUTdjAf58uc((object) this.template, notificationDataSource);
    }

    /// <summary>Тема</summary>
    /// <param name="notificationDataSource"></param>
    public override string GetSubject(object notificationDataSource)
    {
      int num = 2;
      NotificationTemplateBase notificationTemplateBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (notificationTemplateBase != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            notificationTemplateBase = (NotificationTemplateBase) NotificationTemplateWrapper.CT5qBKDJNw7599nY6rQ((object) this, notificationDataSource);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (string) null;
label_3:
      return (string) NotificationTemplateWrapper.hjxqjZD9r2BrE0GTC20((object) notificationTemplateBase, notificationDataSource);
    }

    public override bool IsSubjectOverride(object notificationDataSource)
    {
      int num = 3;
      NotificationTemplateBase notificationTemplateBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (notificationTemplateBase == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 3:
            notificationTemplateBase = (NotificationTemplateBase) NotificationTemplateWrapper.CT5qBKDJNw7599nY6rQ((object) this, notificationDataSource);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 2;
            continue;
          default:
            goto label_5;
        }
      }
label_4:
      return notificationTemplateBase.IsSubjectOverride(notificationDataSource);
label_5:
      return false;
    }

    /// <summary>Базовый шаблон, содержащий данный шаблон темы</summary>
    /// <param name="notificationDataSource"></param>
    public override NotificationTemplateBase GetSubjectTemplateBase(object notificationDataSource)
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_10;
          case 2:
            goto label_2;
          case 3:
            if (this.parent == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 2 : 2;
              continue;
            }
            goto label_3;
          case 4:
            goto label_4;
          case 5:
            if (this.parent != null)
            {
              num = 8;
              continue;
            }
            goto default;
          case 6:
            if (!NotificationTemplateWrapper.zQ7V7RDdIiat2kTGSRh((object) this.template, notificationDataSource))
            {
              num = 5;
              continue;
            }
            goto label_10;
          case 7:
            goto label_7;
          case 8:
            if (!NotificationTemplateWrapper.zQ7V7RDdIiat2kTGSRh((object) this.parent, notificationDataSource))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          default:
            if (this.template.GetSubject(notificationDataSource) != null)
            {
              num = 4;
              continue;
            }
            goto case 3;
        }
      }
label_2:
      return (NotificationTemplateBase) null;
label_3:
      return this.parent.GetSubjectTemplateBase(notificationDataSource);
label_4:
      return this.template.GetSubjectTemplateBase(notificationDataSource);
label_7:
      return (NotificationTemplateBase) NotificationTemplateWrapper.CT5qBKDJNw7599nY6rQ((object) this.parent, notificationDataSource);
label_10:
      return (NotificationTemplateBase) NotificationTemplateWrapper.CT5qBKDJNw7599nY6rQ((object) this.template, notificationDataSource);
    }

    /// <summary>Короткое сообщение</summary>
    /// <param name="notificationDataSource"></param>
    public override string GetShortMessage(object notificationDataSource)
    {
      int num = 2;
      NotificationTemplateBase messageTemplateBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (messageTemplateBase == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            messageTemplateBase = this.GetShortMessageTemplateBase(notificationDataSource);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) null;
label_4:
      return (string) NotificationTemplateWrapper.UnN9NeDlCEQ6X7wdH1V((object) messageTemplateBase, notificationDataSource);
    }

    public override bool IsShortMessageOverride(object notificationDataSource)
    {
      int num = 1;
      NotificationTemplateBase notificationTemplateBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            notificationTemplateBase = (NotificationTemplateBase) NotificationTemplateWrapper.bEmKQLDrvcjrrdRaRhU((object) this, notificationDataSource);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            if (notificationTemplateBase != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 0;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return NotificationTemplateWrapper.gF9BYvDgJJevlNukx7x((object) notificationTemplateBase, notificationDataSource);
label_3:
      return false;
    }

    /// <summary>
    /// Базовый шаблон, содержащий данный шаблон короткого сообщения
    /// </summary>
    /// <param name="notificationDataSource"></param>
    public override NotificationTemplateBase GetShortMessageTemplateBase(
      object notificationDataSource)
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
              if (!NotificationTemplateWrapper.gF9BYvDgJJevlNukx7x((object) this.parent, notificationDataSource))
              {
                num2 = 4;
                continue;
              }
              goto label_13;
            case 2:
            case 4:
              goto label_14;
            case 3:
              goto label_13;
            case 5:
              if (this.parent == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 6:
              goto label_8;
            case 7:
              if (NotificationTemplateWrapper.gF9BYvDgJJevlNukx7x((object) this.template, notificationDataSource))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 6;
                continue;
              }
              if (this.parent == null)
              {
                num2 = 2;
                continue;
              }
              goto case 1;
            default:
              goto label_5;
          }
        }
label_14:
        if (NotificationTemplateWrapper.UnN9NeDlCEQ6X7wdH1V((object) this.template, notificationDataSource) == null)
          num1 = 5;
        else
          goto label_7;
      }
label_5:
      return (NotificationTemplateBase) null;
label_6:
      return (NotificationTemplateBase) NotificationTemplateWrapper.bEmKQLDrvcjrrdRaRhU((object) this.parent, notificationDataSource);
label_7:
      return (NotificationTemplateBase) NotificationTemplateWrapper.bEmKQLDrvcjrrdRaRhU((object) this.template, notificationDataSource);
label_8:
      return (NotificationTemplateBase) NotificationTemplateWrapper.bEmKQLDrvcjrrdRaRhU((object) this.template, notificationDataSource);
label_13:
      return (NotificationTemplateBase) NotificationTemplateWrapper.bEmKQLDrvcjrrdRaRhU((object) this.parent, notificationDataSource);
    }

    /// <summary>Полное сообщение</summary>
    /// <param name="notificationDataSource"></param>
    public override string GetFullMessage(object notificationDataSource)
    {
      int num = 3;
      NotificationTemplateBase notificationTemplateBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (notificationTemplateBase != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            notificationTemplateBase = (NotificationTemplateBase) NotificationTemplateWrapper.vp6S9gD592VXCfylMOM((object) this, notificationDataSource);
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return (string) null;
label_3:
      return (string) NotificationTemplateWrapper.qhBM25DjqgbnC3F42ZB((object) notificationTemplateBase, notificationDataSource);
    }

    public override bool IsFullMessageOverride(object notificationDataSource)
    {
      int num = 1;
      NotificationTemplateBase notificationTemplateBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            notificationTemplateBase = (NotificationTemplateBase) NotificationTemplateWrapper.vp6S9gD592VXCfylMOM((object) this, notificationDataSource);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_4;
          default:
            if (notificationTemplateBase == null)
            {
              num = 3;
              continue;
            }
            goto label_3;
        }
      }
label_3:
      return NotificationTemplateWrapper.ubrlpxDYEYKWcTo9sM0((object) notificationTemplateBase, notificationDataSource);
label_4:
      return false;
    }

    /// <summary>
    /// Базовый шаблон, содержащий данный шаблон полного сообщения
    /// </summary>
    /// <param name="notificationDataSource"></param>
    public override NotificationTemplateBase GetFullMessageTemplateBase(
      object notificationDataSource)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.parent != null)
            {
              num = 4;
              continue;
            }
            break;
          case 2:
            if (!NotificationTemplateWrapper.ubrlpxDYEYKWcTo9sM0((object) this.template, notificationDataSource))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          case 3:
            goto label_4;
          case 4:
            if (this.parent.IsFullMessageOverride(notificationDataSource))
            {
              num = 5;
              continue;
            }
            break;
          case 5:
            goto label_7;
          case 6:
            if (this.parent == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            }
            goto label_15;
          default:
            goto label_14;
        }
        if (this.template.GetFullMessage(notificationDataSource) == null)
          num = 6;
        else
          goto label_16;
      }
label_4:
      return this.template.GetFullMessageTemplateBase(notificationDataSource);
label_7:
      return (NotificationTemplateBase) NotificationTemplateWrapper.vp6S9gD592VXCfylMOM((object) this.parent, notificationDataSource);
label_14:
      return (NotificationTemplateBase) null;
label_15:
      return (NotificationTemplateBase) NotificationTemplateWrapper.vp6S9gD592VXCfylMOM((object) this.parent, notificationDataSource);
label_16:
      return (NotificationTemplateBase) NotificationTemplateWrapper.vp6S9gD592VXCfylMOM((object) this.template, notificationDataSource);
    }

    public override CustomMessage[] GetCustomMessages(object notificationDataSource)
    {
      int num = 1;
      NotificationTemplateBase notificationTemplateBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            notificationTemplateBase = (NotificationTemplateBase) NotificationTemplateWrapper.JR0XGLDLJlaCuS3RcLf((object) this, notificationDataSource);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          default:
            if (notificationTemplateBase != null)
            {
              num = 3;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return (CustomMessage[]) null;
label_3:
      return (CustomMessage[]) NotificationTemplateWrapper.ej3kTUDU0MJPiSYGHMB((object) notificationTemplateBase, notificationDataSource);
    }

    public override NotificationTemplateBase GetCustomMessagesTemplateBase(
      object notificationDataSource)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (NotificationTemplateWrapper.ej3kTUDU0MJPiSYGHMB((object) this.template, notificationDataSource) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_4;
          case 3:
            if (this.parent == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 1;
              continue;
            }
            goto label_5;
          default:
            goto label_6;
        }
      }
label_4:
      return (NotificationTemplateBase) null;
label_5:
      return (NotificationTemplateBase) NotificationTemplateWrapper.JR0XGLDLJlaCuS3RcLf((object) this.parent, notificationDataSource);
label_6:
      return this.template.GetCustomMessagesTemplateBase(notificationDataSource);
    }

    /// <summary>Ссылка на объект</summary>
    public override NotificationTemplateObject ObjectTemplate
    {
      get
      {
        int num = 1;
        object objectTemplate;
        while (true)
        {
          switch (num)
          {
            case 1:
              objectTemplate = NotificationTemplateWrapper.MNvcQaDsDGvdbboAM6D((object) this.template);
              if (objectTemplate == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_7;
            default:
              if (this.parent == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 2;
                continue;
              }
              goto label_8;
          }
        }
label_2:
        return (NotificationTemplateObject) objectTemplate;
label_7:
        return (NotificationTemplateObject) null;
label_8:
        return (NotificationTemplateObject) NotificationTemplateWrapper.MNvcQaDsDGvdbboAM6D((object) this.parent);
      }
    }

    /// <summary>Отправлять сообщение автору</summary>
    /// <param name="notificationDataSource"></param>
    public override bool IsSendToAuthor(object notificationDataSource)
    {
      int num = 3;
      NotificationTemplateBase notificationTemplateBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (notificationTemplateBase == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            notificationTemplateBase = (NotificationTemplateBase) NotificationTemplateWrapper.CT5qBKDJNw7599nY6rQ((object) this, notificationDataSource);
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return NotificationTemplateWrapper.LhWilqDct28WXJmG33f((object) notificationTemplateBase, notificationDataSource);
label_3:
      return false;
    }

    /// <summary>Проверить, удовлетворяет ли оповещение шаблону</summary>
    /// <param name="notification">Оповещение</param>
    /// <returns>True, если удовлетворяют</returns>
    public override bool CheckFilter(INotification notification)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            NotificationTemplateWrapper.cVtkP7tFMjjAg4wKLRQ((object) notification, NotificationTemplateWrapper.DqG4XwDziyluhlYWe8y(322893104 - -1992822529 ^ -1979219393));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          case 2:
            if (!NotificationTemplateWrapper.ae66octB3qJ2OXDdbSP((object) this.parent, (object) notification))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 3 : 2;
              continue;
            }
            goto label_5;
          case 3:
            goto label_4;
          default:
            if (this.parent != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 0;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return false;
label_5:
      return NotificationTemplateWrapper.ae66octB3qJ2OXDdbSP((object) this.template, (object) notification);
    }

    internal static void DFke9bD6ByenHtvq6uV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool nCdu4HDwQBoOBdSq7ip() => NotificationTemplateWrapper.gZRb1mDtsCSmFm8tjZh == null;

    internal static NotificationTemplateWrapper TForZAD4O8CAPF8MsuX() => NotificationTemplateWrapper.gZRb1mDtsCSmFm8tjZh;

    internal static object JmVwkXDHQKndQTUo6g0([In] object obj0) => (object) ((NotificationTemplateBase) obj0).FileInfo;

    internal static object aiJOkBDAdnsJDgjbCRg([In] object obj0) => (object) ((NotificationTemplateBase) obj0).Name;

    internal static object nnXNfJD7U9V70aZERNU([In] object obj0) => (object) ((NotificationTemplateBase) obj0).ChannelsTemplateBase;

    internal static object Y6di6bDxNToaNf8qXeW([In] object obj0) => (object) ((NotificationTemplateBase) obj0).Channels;

    internal static object NfCVbiD03fyRCEDZq5b([In] object obj0) => (object) ((NotificationTemplateBase) obj0).URLTemplateBase;

    internal static object CyYTHnDmuUTdjAf58uc([In] object obj0, [In] object obj1) => (object) ((NotificationTemplateBase) obj0).GetAuthorTemplateBase(obj1);

    internal static bool DAyUcZDyIqdbbEZpLAn([In] object obj0, [In] object obj1) => ((NotificationTemplateBase) obj0).IsAuthorOverride(obj1);

    internal static object rXhaNwDMQSJVJyhIMwl([In] object obj0, [In] object obj1) => (object) ((NotificationTemplateBase) obj0).GetAuthor(obj1);

    internal static object CT5qBKDJNw7599nY6rQ([In] object obj0, [In] object obj1) => (object) ((NotificationTemplateBase) obj0).GetSubjectTemplateBase(obj1);

    internal static object hjxqjZD9r2BrE0GTC20([In] object obj0, [In] object obj1) => (object) ((NotificationTemplateBase) obj0).GetSubject(obj1);

    internal static bool zQ7V7RDdIiat2kTGSRh([In] object obj0, [In] object obj1) => ((NotificationTemplateBase) obj0).IsSubjectOverride(obj1);

    internal static object UnN9NeDlCEQ6X7wdH1V([In] object obj0, [In] object obj1) => (object) ((NotificationTemplateBase) obj0).GetShortMessage(obj1);

    internal static object bEmKQLDrvcjrrdRaRhU([In] object obj0, [In] object obj1) => (object) ((NotificationTemplateBase) obj0).GetShortMessageTemplateBase(obj1);

    internal static bool gF9BYvDgJJevlNukx7x([In] object obj0, [In] object obj1) => ((NotificationTemplateBase) obj0).IsShortMessageOverride(obj1);

    internal static object vp6S9gD592VXCfylMOM([In] object obj0, [In] object obj1) => (object) ((NotificationTemplateBase) obj0).GetFullMessageTemplateBase(obj1);

    internal static object qhBM25DjqgbnC3F42ZB([In] object obj0, [In] object obj1) => (object) ((NotificationTemplateBase) obj0).GetFullMessage(obj1);

    internal static bool ubrlpxDYEYKWcTo9sM0([In] object obj0, [In] object obj1) => ((NotificationTemplateBase) obj0).IsFullMessageOverride(obj1);

    internal static object JR0XGLDLJlaCuS3RcLf([In] object obj0, [In] object obj1) => (object) ((NotificationTemplateBase) obj0).GetCustomMessagesTemplateBase(obj1);

    internal static object ej3kTUDU0MJPiSYGHMB([In] object obj0, [In] object obj1) => (object) ((NotificationTemplateBase) obj0).GetCustomMessages(obj1);

    internal static object MNvcQaDsDGvdbboAM6D([In] object obj0) => (object) ((NotificationTemplateBase) obj0).ObjectTemplate;

    internal static bool LhWilqDct28WXJmG33f([In] object obj0, [In] object obj1) => ((NotificationTemplateBase) obj0).IsSendToAuthor(obj1);

    internal static object DqG4XwDziyluhlYWe8y(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void cVtkP7tFMjjAg4wKLRQ([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool ae66octB3qJ2OXDdbSP([In] object obj0, [In] object obj1) => ((NotificationTemplateBase) obj0).CheckFilter((INotification) obj1);
  }
}
