// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.MessageManagerExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Messaging
{
  public static class MessageManagerExtensions
  {
    internal static MessageManagerExtensions n5JpSZhmy2XqMfZo2VGJ;

    /// <summary>Отложить отправку сообщения по действию с сущностью</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="actionUid">Уникальный идентификатор действия</param>
    public static void Delay(this IMessageManager messageManager, IEntity entity, Guid actionUid)
    {
      int num = 6;
      UidAttribute attribute;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_10;
          case 1:
            goto label_2;
          case 2:
            if (attribute == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
              continue;
            }
            goto case 4;
          case 3:
            goto label_13;
          case 4:
            MessageManagerExtensions.IWFdoDhmlBDYVQb7lm6a((object) messageManager, MessageManagerExtensions.wIfv0fhm9l3myoWTKOgu((object) attribute), (object) MessageManagerExtensions.VDQ9Owhmd445UHRv8dpn((object) entity).ToString(), actionUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 5:
            if (entity == null)
            {
              num = 3;
              continue;
            }
            goto case 7;
          case 6:
            if (messageManager != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 5 : 4;
              continue;
            }
            goto label_3;
          case 7:
            attribute = AttributeHelper<UidAttribute>.GetAttribute(entity.CastAsRealType<IEntity>().GetType(), true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 1;
            continue;
          default:
            goto label_14;
        }
      }
label_10:
      return;
label_2:
      return;
label_13:
      return;
label_14:
      return;
label_3:;
    }

    internal static Guid wIfv0fhm9l3myoWTKOgu([In] object obj0) => ((UidAttribute) obj0).Uid;

    internal static object VDQ9Owhmd445UHRv8dpn([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void IWFdoDhmlBDYVQb7lm6a(
      [In] object obj0,
      Guid objectUid,
      [In] object obj2,
      Guid actionUid)
    {
      ((IMessageManager) obj0).Delay(objectUid, (string) obj2, actionUid);
    }

    internal static bool IhJICehmMRrMwbyCXLnp() => MessageManagerExtensions.n5JpSZhmy2XqMfZo2VGJ == null;

    internal static MessageManagerExtensions XBxuqMhmJ6CBVVpI9kGM() => MessageManagerExtensions.n5JpSZhmy2XqMfZo2VGJ;
  }
}
