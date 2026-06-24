// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationTemplateBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Globalization;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Notifications.Impl.TemplateGenerator;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Базовый класс для стандартных шаблонов оповещений</summary>
  public abstract class NotificationTemplateBase : INotificationTemplate
  {
    private static TimeSpan totalGenTime;
    internal static NotificationTemplateBase dAt48pD2K458JDw6TSE;

    /// <summary>Сгенерировать сообщения</summary>
    /// <param name="notification">Оповещение</param>
    /// <returns>Список сгенерированных сообщений</returns>
    public virtual IEnumerable<IMessageBase> Generate(INotification notification)
    {
      Contract.ArgumentNotNull((object) notification, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137984015));
      IMessageManager messageManager = Locator.GetServiceNotNull<IMessageManager>();
      List<IMessageBase> messageBaseList = new List<IMessageBase>();
      List<long> allRecipients = new List<long>();
      IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
      NotificationManager serviceNotNull1 = Locator.GetServiceNotNull<NotificationManager>();
      List<long> ignoredUserIds = serviceNotNull1.GetIgnoredUserIds();
      List<long> forceSendUserIds = serviceNotNull1.GetForceSendUserIds();
      List<IUser> additionalSendUsers = serviceNotNull1.GetAdditionalSendUsers();
      ILocalizationService serviceNotNull2 = Locator.GetServiceNotNull<ILocalizationService>();
      ITimeZoneService serviceNotNull3 = Locator.GetServiceNotNull<ITimeZoneService>();
      if (notification is EventNotification)
      {
        EventNotification eventNotification = (EventNotification) notification;
        if (eventNotification.ExtendedProperties.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867347929)) && eventNotification.ExtendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561108146)] is IUser extendedProperty)
          currentUser = extendedProperty;
      }
      IEnumerable<NotificationRecipientSet> notificationRecipientSets;
      if (additionalSendUsers.Count == 0)
        notificationRecipientSets = (IEnumerable<NotificationRecipientSet>) this.RecipientSets;
      else
        notificationRecipientSets = this.RecipientSets.Union<NotificationRecipientSet>((IEnumerable<NotificationRecipientSet>) new NotificationRecipientSet[1]
        {
          (NotificationRecipientSet) new NotificationRecipientSetFromUsers((IEnumerable<IUser>) additionalSendUsers)
        });
      foreach (NotificationRecipientSet notificationRecipientSet in notificationRecipientSets)
      {
        IUser[] array = notificationRecipientSet.GetRecipients(notification).OfType<IUser>().Where<IUser>((Func<IUser, bool>) (r =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (r == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
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
          return !allRecipients.Contains((long) r.GetId());
label_5:
          return false;
        })).ToArray<IUser>();
        if (((IEnumerable<IUser>) array).Any<IUser>())
        {
          NotificationGenerationData dataSource = new NotificationGenerationData(notification);
          dataSource[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921236603)] = (object) notificationRecipientSet.Name;
          dataSource[z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870859179)] = (object) currentUser;
          if (Locator.Initialized && Locator.GetService<CommonSettingsModule>() != null)
            dataSource[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178241358)] = (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408927306);
          List<IUser> source1 = new List<IUser>();
          // ISSUE: reference to a compiler-generated method
          List<string> list = EleWise.ELMA.SR.GetCultureNames().Select<CultureInfo, string>((Func<CultureInfo, string>) (c => (string) NotificationTemplateBase.\u003C\u003Ec.tlMVWuflBPji4pr7ELv7((object) c))).ToList<string>();
          Dictionary<long, Tuple<int, CultureInfo>> messageKindDictionary = new Dictionary<long, Tuple<int, CultureInfo>>();
          bool flag = notificationRecipientSet.SendToAuthorOnly || this.IsSendToAuthor((object) dataSource);
          foreach (IUser user in array)
          {
            if (!allRecipients.Contains((long) user.GetId()) && (!notificationRecipientSet.SendToAuthorOnly || user == currentUser) && (user == currentUser & flag || !ignoredUserIds.Contains((long) user.GetId())))
            {
              long id = (long) user.GetId();
              allRecipients.Add(id);
              source1.Add(user);
              int offset = serviceNotNull3.GetUserTimeZone(user).Offset;
              CultureInfo cultureInfo = serviceNotNull2.Load(user);
              if (!list.Contains(cultureInfo.Name))
                cultureInfo = EleWise.ELMA.SR.GetDefaultCulture() ?? EleWise.ELMA.SR.KeyCultureInfo;
              messageKindDictionary.Add(id, new Tuple<int, CultureInfo>(offset, cultureInfo));
            }
          }
          Dictionary<Tuple<int, string>, IMessage> messageTemplates = new Dictionary<Tuple<int, string>, IMessage>();
          foreach (Tuple<int, CultureInfo> tuple in messageKindDictionary.Values.Distinct<Tuple<int, CultureInfo>>())
          {
            int offset = tuple.Item1;
            CultureInfo culture = tuple.Item2;
            EleWise.ELMA.SR.RunWithCulture(culture, (System.Action) (() =>
            {
              int num = 4;
              IMessage message1;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    IMessage message2 = message1;
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ParameterExpression parameterExpression1 = (ParameterExpression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.JDckurfd621DjstOJest(NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(__typeref (IMessage)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333610684));
                    // ISSUE: method reference
                    Expression<Func<IMessage, string>> messageProperty1 = Expression.Lambda<Func<IMessage, string>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IMessage.get_FullMessageHtml))), parameterExpression1);
                    // ISSUE: reference to a compiler-generated method
                    object template1 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.BdGvLDfdrTiIUPkRRaji((object) this, (object) dataSource);
                    // ISSUE: reference to a compiler-generated method
                    object templateBase1 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.WfSAp4fdgYHafyGhgFjk((object) this, (object) dataSource);
                    NotificationGenerationData dataSource1 = dataSource;
                    int offset1 = offset;
                    this.GenerateMessagePart(message2, messageProperty1, (string) template1, (NotificationTemplateBase) templateBase1, (object) dataSource1, offset1, TemplateRenderMode.HTML);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    IMessage message3 = message1;
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ParameterExpression parameterExpression2 = (ParameterExpression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.JDckurfd621DjstOJest(typeof (IMessage), NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-867826612 ^ -867926302));
                    // ISSUE: method reference
                    // ISSUE: reference to a compiler-generated method
                    Expression<Func<IMessage, string>> messageProperty2 = Expression.Lambda<Func<IMessage, string>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy(__methodref (IMessage.get_URL))), parameterExpression2);
                    // ISSUE: reference to a compiler-generated method
                    object template2 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.fWPFsSfdyenMDhU2MY4m((object) this);
                    // ISSUE: reference to a compiler-generated method
                    object templateBase2 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.EjQIo6fdMD9G6pihvew3((object) this);
                    NotificationGenerationData dataSource2 = dataSource;
                    int offset2 = offset;
                    this.GenerateMessagePart(message3, messageProperty2, (string) template2, (NotificationTemplateBase) templateBase2, (object) dataSource2, offset2);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 11 : 14;
                    continue;
                  case 3:
                    IMessage message4 = message1;
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ParameterExpression parameterExpression3 = (ParameterExpression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.JDckurfd621DjstOJest(NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(__typeref (IMessage)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408793184));
                    // ISSUE: method reference
                    // ISSUE: reference to a compiler-generated method
                    Expression<Func<IMessage, string>> messageProperty3 = Expression.Lambda<Func<IMessage, string>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy(__methodref (IMessage.get_AuthorText))), parameterExpression3);
                    // ISSUE: reference to a compiler-generated method
                    object template3 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.XbyllifdAw5fA3f5yBtj((object) this, (object) dataSource);
                    NotificationTemplateBase authorTemplateBase = this.GetAuthorTemplateBase((object) dataSource);
                    NotificationGenerationData dataSource3 = dataSource;
                    int offset3 = offset;
                    this.GenerateMessagePart(message4, messageProperty3, (string) template3, authorTemplateBase, (object) dataSource3, offset3);
                    num = 12;
                    continue;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    message1 = (IMessage) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.wIvfbxfdwWY0JIgEAJqL((object) messageManager);
                    num = 3;
                    continue;
                  case 5:
                    IMessage message5 = message1;
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ParameterExpression parameterExpression4 = (ParameterExpression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.JDckurfd621DjstOJest(NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(__typeref (IMessage)), NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-16752921 ^ -16636855));
                    // ISSUE: method reference
                    // ISSUE: reference to a compiler-generated method
                    Expression<Func<IMessage, string>> messageProperty4 = Expression.Lambda<Func<IMessage, string>>((Expression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.DsZwd8fdxZT7m3BmPdSE((object) parameterExpression4, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IMessage.get_ShortMessageHtml))), parameterExpression4);
                    // ISSUE: reference to a compiler-generated method
                    object template4 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.F1aK6kfddlG9pRGExOfo((object) this, (object) dataSource);
                    // ISSUE: reference to a compiler-generated method
                    object templateBase3 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.GPGdIlfdlsteP8uqnrVp((object) this, (object) dataSource);
                    NotificationGenerationData dataSource4 = dataSource;
                    int offset4 = offset;
                    this.GenerateMessagePart(message5, messageProperty4, (string) template4, (NotificationTemplateBase) templateBase3, (object) dataSource4, offset4, TemplateRenderMode.HTML);
                    num = 9;
                    continue;
                  case 6:
                    IMessage message6 = message1;
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ParameterExpression parameterExpression5 = (ParameterExpression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.JDckurfd621DjstOJest(typeof (IMessage), NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-1334993905 ^ -1334843743));
                    // ISSUE: method reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    Expression<Func<IMessage, string>> messageProperty5 = Expression.Lambda<Func<IMessage, string>>((Expression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.DsZwd8fdxZT7m3BmPdSE((object) parameterExpression5, (object) (MethodInfo) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy(__methodref (IMessage.get_ShortMessageText))), parameterExpression5);
                    // ISSUE: reference to a compiler-generated method
                    object template5 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.F1aK6kfddlG9pRGExOfo((object) this, (object) dataSource);
                    // ISSUE: reference to a compiler-generated method
                    object templateBase4 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.GPGdIlfdlsteP8uqnrVp((object) this, (object) dataSource);
                    NotificationGenerationData dataSource5 = dataSource;
                    int offset5 = offset;
                    this.GenerateMessagePart(message6, messageProperty5, (string) template5, (NotificationTemplateBase) templateBase4, (object) dataSource5, offset5);
                    num = 5;
                    continue;
                  case 7:
                  case 8:
                    // ISSUE: reference to a compiler-generated method
                    messageTemplates.Add(new Tuple<int, string>(offset, (string) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.wxAOOPfdUcHbZ8i8phjZ((object) culture)), message1);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 10 : 8;
                    continue;
                  case 9:
                    IMessage message7 = message1;
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ParameterExpression parameterExpression6 = (ParameterExpression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.JDckurfd621DjstOJest(typeof (IMessage), NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-2138160520 ^ -2138294058));
                    // ISSUE: method reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    Expression<Func<IMessage, string>> messageProperty6 = Expression.Lambda<Func<IMessage, string>>((Expression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.DsZwd8fdxZT7m3BmPdSE((object) parameterExpression6, (object) (MethodInfo) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy(__methodref (IMessage.get_FullMessageText))), parameterExpression6);
                    // ISSUE: reference to a compiler-generated method
                    object template6 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.BdGvLDfdrTiIUPkRRaji((object) this, (object) dataSource);
                    // ISSUE: reference to a compiler-generated method
                    object templateBase5 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.WfSAp4fdgYHafyGhgFjk((object) this, (object) dataSource);
                    NotificationGenerationData dataSource6 = dataSource;
                    int offset6 = offset;
                    this.GenerateMessagePart(message7, messageProperty6, (string) template6, (NotificationTemplateBase) templateBase5, (object) dataSource6, offset6);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
                    continue;
                  case 10:
                    goto label_13;
                  case 11:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.clAypKfdL7Wk0jfThPu2((object) message1, NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.BoXDQJfdYmghQJ7YRWH8(NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.Rfu1fcfdjYRi5dnU45lZ((object) this), (object) dataSource));
                    num = 8;
                    continue;
                  case 12:
                    IMessage message8 = message1;
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ParameterExpression parameterExpression7 = (ParameterExpression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.JDckurfd621DjstOJest(NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(__typeref (IMessage)), NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-1487388570 ^ -1487258936));
                    // ISSUE: method reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    Expression<Func<IMessage, string>> messageProperty7 = Expression.Lambda<Func<IMessage, string>>((Expression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.DsZwd8fdxZT7m3BmPdSE((object) parameterExpression7, (object) (MethodInfo) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy(__methodref (IMessageBase.get_Channels))), parameterExpression7);
                    // ISSUE: reference to a compiler-generated method
                    object template7 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.M5qp2Efd0g11aqU2oXmE((object) this);
                    // ISSUE: reference to a compiler-generated method
                    object templateBase6 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.IJqnRRfdmvY9GsErhHQK((object) this);
                    NotificationGenerationData dataSource7 = dataSource;
                    int offset7 = offset;
                    this.GenerateMessagePart(message8, messageProperty7, (string) template7, (NotificationTemplateBase) templateBase6, (object) dataSource7, offset7);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 2;
                    continue;
                  case 13:
                    // ISSUE: reference to a compiler-generated method
                    if (NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.Rfu1fcfdjYRi5dnU45lZ((object) this) == null)
                    {
                      num = 7;
                      continue;
                    }
                    goto case 11;
                  case 14:
                    IMessage message9 = message1;
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ParameterExpression parameterExpression8 = (ParameterExpression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.JDckurfd621DjstOJest(NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(__typeref (IMessage)), NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-53329496 >> 4 ^ -3187020));
                    // ISSUE: method reference
                    Expression<Func<IMessage, string>> messageProperty8 = Expression.Lambda<Func<IMessage, string>>((Expression) Expression.Property((Expression) parameterExpression8, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IMessage.get_Subject))), parameterExpression8);
                    // ISSUE: reference to a compiler-generated method
                    object template8 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.CEEbV1fdJVNUFVitmtG0((object) this, (object) dataSource);
                    // ISSUE: reference to a compiler-generated method
                    object templateBase7 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.D1Ir4xfd9VuJDU4qYjpq((object) this, (object) dataSource);
                    NotificationGenerationData dataSource8 = dataSource;
                    int offset8 = offset;
                    this.GenerateMessagePart(message9, messageProperty8, (string) template8, (NotificationTemplateBase) templateBase7, (object) dataSource8, offset8);
                    num = 6;
                    continue;
                  default:
                    IMessage message10 = message1;
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ParameterExpression parameterExpression9 = (ParameterExpression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.JDckurfd621DjstOJest(NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(__typeref (IMessage)), NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(1642859704 ^ 1643017750));
                    // ISSUE: method reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    Expression<Func<IMessage, CustomMessage[]>> messageProperty9 = Expression.Lambda<Func<IMessage, CustomMessage[]>>((Expression) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.DsZwd8fdxZT7m3BmPdSE((object) parameterExpression9, (object) (MethodInfo) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy(__methodref (IMessage.get_CustomMessages))), parameterExpression9);
                    CustomMessage[] customMessages = this.GetCustomMessages((object) dataSource);
                    // ISSUE: reference to a compiler-generated method
                    object templateBase8 = NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_2.O9jBFsfd54vegNCMJlnQ((object) this, (object) dataSource);
                    NotificationGenerationData dataSource9 = dataSource;
                    int offset9 = offset;
                    this.GenerateMessagePart(message10, messageProperty9, customMessages, (NotificationTemplateBase) templateBase8, (object) dataSource9, offset9, TemplateRenderMode.HTML);
                    num = 13;
                    continue;
                }
              }
label_13:;
            }));
          }
          foreach (IGrouping<Tuple<int, string>, IUser> source2 in source1.GroupBy<IUser, Tuple<int, string>>((Func<IUser, Tuple<int, string>>) (i =>
          {
            Tuple<int, CultureInfo> tuple = messageKindDictionary[(long) i.GetId()];
            return new Tuple<int, string>(tuple.Item1, tuple.Item2.Name);
          })).ToList<IGrouping<Tuple<int, string>, IUser>>())
          {
            IMessage message11 = messageTemplates[source2.Key];
            IMessage message12 = messageManager.Create();
            message12.Author = (object) currentUser;
            message12.AuthorText = message11.AuthorText;
            message12.Channels = message11.Channels;
            message12.Recipient = (object) source2.ToList<IUser>();
            message12.URL = message11.URL;
            message12.Subject = message11.Subject;
            message12.ShortMessageText = message11.ShortMessageText;
            message12.ShortMessageHtml = message11.ShortMessageHtml;
            message12.FullMessageText = message11.FullMessageText;
            message12.FullMessageHtml = message11.FullMessageHtml;
            message12.ObjectId = message11.ObjectId;
            message12.SendToAuthor = flag || currentUser != null && source2.Any<IUser>((Func<IUser, bool>) (u =>
            {
              int num = 2;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    goto label_5;
                  case 2:
                    if (u == null)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                      continue;
                    }
                    goto label_4;
                  default:
                    goto label_4;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return (long) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_0.txpjR0fde5m8W0r0YKOK((object) u) == (long) NotificationTemplateBase.\u003C\u003Ec__DisplayClass0_0.txpjR0fde5m8W0r0YKOK((object) currentUser);
label_5:
              return false;
            })) && forceSendUserIds.Contains((long) currentUser.GetId());
            message12.CustomMessages = message11.CustomMessages;
            INotificationMessageHandler serviceNotNull4 = Locator.GetServiceNotNull<INotificationMessageHandler>();
            if (notification is IEventNotification eventNotification)
            {
              message12.ObjectUid = eventNotification.Object != null ? new Guid?(eventNotification.Object.Uid) : new Guid?();
              message12.ActionUid = eventNotification.Action != null ? new Guid?(eventNotification.Action.Uid) : new Guid?();
            }
            if (message12.ObjectUid.HasValue && message12.ObjectId != null && message12.ActionUid.HasValue)
              message12.Delayed = messageManager.IsDelayed(message12.ObjectUid.Value, message12.ObjectId, message12.ActionUid.Value);
            INotification notification1 = notification;
            IMessage message13 = message12;
            serviceNotNull4.ProcessNotificationToMessage(notification1, message13);
            messageBaseList.Add((IMessageBase) message12);
          }
        }
      }
      return (IEnumerable<IMessageBase>) messageBaseList;
    }

    /// <summary>Проверить, удовлетворяет ли оповещение шаблону</summary>
    /// <param name="notification">Оповещение</param>
    /// <returns>True, если удовлетворяют</returns>
    public abstract bool CheckFilter(INotification notification);

    /// <summary>Информация о файле шаблонов</summary>
    public abstract NotificationTemplateFileInfo FileInfo { get; }

    /// <summary>Имя шаблона</summary>
    public abstract string Name { get; }

    /// <summary>Наборы получателей оповещения</summary>
    public abstract List<NotificationRecipientSet> RecipientSets { get; }

    /// <summary>Очистить все наборы получателей оповещения.</summary>
    public abstract bool? RecipientSetsClear { get; }

    /// <summary>Каналы</summary>
    public abstract string Channels { get; }

    /// <summary>Базовый шаблон, срдержащий данный шаблон</summary>
    public abstract NotificationTemplateBase ChannelsTemplateBase { get; }

    /// <summary>URL</summary>
    public abstract string URL { get; }

    /// <summary>Базовый шаблон, содержащий данный шаблон URL</summary>
    public abstract NotificationTemplateBase URLTemplateBase { get; }

    /// <summary>Автор</summary>
    /// <param name="notificationDataSource"></param>
    /// <returns></returns>
    public abstract string GetAuthor(object notificationDataSource);

    /// <summary>Автор переопределен</summary>
    /// <param name="notificationDataSource"></param>
    public abstract bool IsAuthorOverride(object notificationDataSource);

    /// <summary>Базовый шаблон, содержащий данный шаблон автора</summary>
    /// <param name="notificationDataSource"></param>
    public abstract NotificationTemplateBase GetAuthorTemplateBase(object notificationDataSource);

    /// <summary>Тема</summary>
    /// <param name="notificationDataSource"></param>
    public abstract string GetSubject(object notificationDataSource);

    /// <summary>Тема переопределена</summary>
    /// <param name="notificationDataSource"></param>
    public abstract bool IsSubjectOverride(object notificationDataSource);

    /// <summary>Базовый шаблон, содержащий данный шаблон темы</summary>
    /// <param name="notificationDataSource"></param>
    public abstract NotificationTemplateBase GetSubjectTemplateBase(object notificationDataSource);

    /// <summary>Короткое сообщение</summary>
    /// <param name="notificationDataSource"></param>
    public abstract string GetShortMessage(object notificationDataSource);

    /// <summary>Короткое сообщение переопределено</summary>
    /// <param name="notificationDataSource"></param>
    public abstract bool IsShortMessageOverride(object notificationDataSource);

    /// <summary>
    /// Базовый шаблон, содержащий данный шаблон короткого сообщения
    /// </summary>
    /// <param name="notificationDataSource"></param>
    public abstract NotificationTemplateBase GetShortMessageTemplateBase(
      object notificationDataSource);

    /// <summary>Полное сообщение</summary>
    /// <param name="notificationDataSource"></param>
    public abstract string GetFullMessage(object notificationDataSource);

    /// <summary>Полное сообщение переопределено</summary>
    /// <param name="notificationDataSource"></param>
    public abstract bool IsFullMessageOverride(object notificationDataSource);

    /// <summary>
    /// Базовый шаблон, содержащий данный шаблон полного сообщения
    /// </summary>
    /// <param name="notificationDataSource"></param>
    public abstract NotificationTemplateBase GetFullMessageTemplateBase(
      object notificationDataSource);

    /// <summary>Кастомные сообщения</summary>
    /// <param name="notificationDataSource"></param>
    public abstract CustomMessage[] GetCustomMessages(object notificationDataSource);

    /// <summary>Базовый шаблон, содержащий шаблон кастомных сообщений</summary>
    /// <param name="notificationDataSource"></param>
    public abstract NotificationTemplateBase GetCustomMessagesTemplateBase(
      object notificationDataSource);

    /// <summary>Ссылка на объект</summary>
    public abstract NotificationTemplateObject ObjectTemplate { get; }

    /// <summary>Отправлять оповещение автору.</summary>
    /// <param name="notificationDataSource"></param>
    public abstract bool IsSendToAuthor(object notificationDataSource);

    /// <summary>Сгенерировать часть для сообщения оповещения</summary>
    /// <param name="message">Сообщение оповещения</param>
    /// <param name="messageProperty">Выражение свойства сообщения, для которого генерируется значение</param>
    /// <param name="template">Текстовый блок шаблон оповещения</param>
    /// <param name="templateBase">Базовый шаблон, содержащий данный текстовый блок шаблона</param>
    /// <param name="dataSource">Источник данных для генерации</param>
    /// <param name="offset">Смещение часового пояса для генерации</param>
    /// <param name="renderMode">Режим генерации</param>
    protected void GenerateMessagePart(
      IMessage message,
      Expression<Func<IMessage, string>> messageProperty,
      string template,
      NotificationTemplateBase templateBase,
      object dataSource,
      int offset,
      TemplateRenderMode renderMode = TemplateRenderMode.Default)
    {
      if (!(messageProperty.Body is MemberExpression body))
        throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867233013));
      PropertyInfo member = body.Member as PropertyInfo;
      if (member == (PropertyInfo) null)
        throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957856590));
      try
      {
        DateTime now = DateTime.Now;
        string empty;
        if (string.IsNullOrEmpty(template))
        {
          empty = string.Empty;
        }
        else
        {
          NotificationTemplateGenerator templateGenerator = new NotificationTemplateGenerator(template, templateBase, renderMode);
          templateGenerator.Provider.TemplateTimeZoneOffset = new int?(offset);
          empty = templateGenerator.Generate(dataSource);
        }
        NotificationTemplateBase.totalGenTime += DateTime.Now - now;
        member.SetValue((object) message, (object) empty, (object[]) null);
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876096005), (object) member.Name), ex);
      }
    }

    /// <summary>Сгенерировать часть для сообщения оповещения</summary>
    /// <param name="message">Сообщение оповещения</param>
    /// <param name="messageProperty">Выражение свойства сообщения, для которого генерируется значение</param>
    /// <param name="templateBase">Базовый шаблон, содержащий данный текстовый блок шаблона</param>
    /// <param name="dataSource">Источник данных для генерации</param>
    /// <param name="offset">Смещение часового пояса для генерации</param>
    /// <param name="renderMode">Режим</param>
    protected void GenerateMessagePart(
      IMessage message,
      Expression<Func<IMessage, CustomMessage[]>> messageProperty,
      CustomMessage[] templates,
      NotificationTemplateBase templateBase,
      object dataSource,
      int offset,
      TemplateRenderMode renderMode = TemplateRenderMode.Default)
    {
      if (!(messageProperty.Body is MemberExpression body))
        throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470473664));
      PropertyInfo member = body.Member as PropertyInfo;
      if (member == (PropertyInfo) null)
        throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461593451));
      try
      {
        DateTime now = DateTime.Now;
        if (templates == null || !((IEnumerable<CustomMessage>) templates).Any<CustomMessage>())
          return;
        List<CustomMessage> list = ((IEnumerable<CustomMessage>) templates).Select<CustomMessage, CustomMessage>((Func<CustomMessage, CustomMessage>) (t =>
        {
          int num = 2;
          NotificationTemplateGenerator templateGenerator;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                ((IGeneratorProvider) NotificationTemplateBase.\u003C\u003Ec__DisplayClass36_0.d7EHKcflGp2LKetyEVZa((object) templateGenerator)).TemplateTimeZoneOffset = new int?(offset);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                continue;
              case 2:
                templateGenerator = new NotificationTemplateGenerator(t.Content, templateBase, renderMode);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          return new CustomMessage()
          {
            Key = t.Key,
            Content = (string) NotificationTemplateBase.\u003C\u003Ec__DisplayClass36_0.aiDiy1flEQDXH5aYOwaB((object) templateGenerator, dataSource)
          };
        })).ToList<CustomMessage>();
        NotificationTemplateBase.totalGenTime += DateTime.Now - now;
        member.SetValue((object) message, (object) list.ToArray(), (object[]) null);
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978383265), (object) member.Name), ex);
      }
    }

    /// <summary>ToString</summary>
    /// <returns>ToString value</returns>
    public override string ToString() => (string) NotificationTemplateBase.ApA6ftDaknufGp9qM48(NotificationTemplateBase.H61YwpDNtaBFiBZtxE0(NotificationTemplateBase.wKVO8UD1QPQGFKENrAt((object) this)), NotificationTemplateBase.mE9wd9D3Drp4jO1Q5A7(-2099751081 ^ -2099760377), NotificationTemplateBase.TqhT3DDpwHraE9uKvor((object) this));

    protected NotificationTemplateBase()
    {
      NotificationTemplateBase.sw4YKxDDkZY4jnkKj05();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static NotificationTemplateBase()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            NotificationTemplateBase.sw4YKxDDkZY4jnkKj05();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            NotificationTemplateBase.totalGenTime = TimeSpan.Zero;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object wKVO8UD1QPQGFKENrAt([In] object obj0) => (object) ((NotificationTemplateBase) obj0).FileInfo;

    internal static object H61YwpDNtaBFiBZtxE0([In] object obj0) => (object) ((NotificationTemplateFileInfo) obj0).Name;

    internal static object mE9wd9D3Drp4jO1Q5A7(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object TqhT3DDpwHraE9uKvor([In] object obj0) => (object) ((NotificationTemplateBase) obj0).Name;

    internal static object ApA6ftDaknufGp9qM48([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool dAoVF4DeKyMBpiFEaIB() => NotificationTemplateBase.dAt48pD2K458JDw6TSE == null;

    internal static NotificationTemplateBase d8gZ3CDPfljsZ7AMOhD() => NotificationTemplateBase.dAt48pD2K458JDw6TSE;

    internal static void sw4YKxDDkZY4jnkKj05() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
