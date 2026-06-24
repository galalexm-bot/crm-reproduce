// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPM.Components.ExpirationChecker
// Assembly: EleWise.ELMA.BPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1B80B5-F464-4FFF-85CF-6A69B66F676D
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.xml

using EleWise.ELMA.BPM.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Notifications.Impl;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPM.Components
{
  /// <summary>
  /// Компонент отправки сообщений о скором истечении лицензии компонентов
  /// </summary>
  [Component]
  public class ExpirationChecker : ISweepHandler
  {
    /// <summary>Менеджер пользователей</summary>
    private readonly UserManager userManager;
    /// <summary>Менеджер групп пользователей</summary>
    private readonly UserGroupManager userGroupManager;
    /// <summary>Сервис проверки лицензии</summary>
    private readonly ExpirationInfoService expirationInfoService;
    /// <summary>Менеджер оповещений</summary>
    private readonly NotificationManager notificationManager;
    /// <summary>Дата последней проверки</summary>
    private DateTime lastRun;
    private static ExpirationChecker lYMA20AcOkDue7S0eqC;

    /// <summary>ctor</summary>
    /// <param name="userManager">Менеджер пользователей</param>
    /// <param name="userGroupManager">Менеджер груп пользоватлей</param>
    /// <param name="expirationInfoService">Сервис проверки лицензии компонентов</param>
    /// <param name="notificationManager">Менеджер оповещений</param>
    public ExpirationChecker(
      UserManager userManager,
      UserGroupManager userGroupManager,
      ExpirationInfoService expirationInfoService,
      NotificationManager notificationManager)
    {
      ExpirationChecker.i9t7VdANLWvafSKsYON();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (<Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_39ab3eb3910c4f408567739982d91be6 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.userManager = userManager;
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_56d8b8d7dcf34e22b9d74eac50c9d637 != 0 ? 3 : 0;
            continue;
          case 2:
            this.lastRun = DateTime.MinValue;
            num = 4;
            continue;
          case 3:
            this.userGroupManager = userGroupManager;
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1eeecee56c2b4f4c8ddb598cc5980193 != 0 ? 4 : 5;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.expirationInfoService = expirationInfoService;
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_4857ff0c85a64b17b36a438afd6598b1 == 0 ? 0 : 0;
            continue;
          default:
            this.notificationManager = notificationManager;
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_548d43c65bbe47f0899304a136990dba != 0 ? 2 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Проверить существование истекающих лицензий и отправить уведомление
    /// </summary>
    public void Execute()
    {
      int num = 2;
      while (true)
      {
        DynamicNotification dynamicNotification;
        ComponentsExpiration componentsExpiration;
        IMessage message;
        DateTime now;
        switch (num)
        {
          case 1:
            if (!ExpirationChecker.QoASenAwPBdSNi2QkUB(ExpirationChecker.vNh9aVAFelehIiMbeHi(now, this.lastRun), ExpirationChecker.utnA6sAZiNOtAHdADcF(1.0)))
            {
              num = 5;
              continue;
            }
            break;
          case 2:
            now = DateTime.Now;
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_11df0b0286bd46b6a8780d914c7488e8 != 0 ? 1 : 0;
            continue;
          case 3:
            dynamicNotification = new DynamicNotification();
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_64676479b67d49ce9c1e5b9e46e65697 != 0 ? 10 : 11;
            continue;
          case 4:
            this.lastRun = now;
            num = 12;
            continue;
          case 5:
            goto label_22;
          case 6:
            ExpirationChecker.Qfnx6WAE5Zp3TUOLbmJ((object) dynamicNotification, ExpirationChecker.vpxtGwAk5hwln8hCCkH(1694754366 - 1012737507 ^ 682020969));
            num = 7;
            continue;
          case 7:
            INotificationTemplateLoader notificationTemplateLoader = this.notificationManager.TemplateLoaders.FirstOrDefault<INotificationTemplateLoader>();
            if (notificationTemplateLoader != null)
            {
              INotificationTemplate notificationTemplate = notificationTemplateLoader.GetTemplates((INotification) dynamicNotification).FirstOrDefault<INotificationTemplate>();
              if (notificationTemplate != null)
              {
                IMessageBase messageBase = notificationTemplate.Generate((INotification) dynamicNotification).FirstOrDefault<IMessageBase>();
                if (messageBase != null)
                {
                  message = messageBase.GetMessages().FirstOrDefault<IMessage>();
                  num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a2d1cecc368149d18a15dc8b377c30d5 != 0 ? 10 : 4;
                  continue;
                }
                goto label_23;
              }
              else
                goto label_20;
            }
            else
              goto label_17;
          case 8:
            goto label_3;
          case 9:
            if (componentsExpiration.ExpiringComponents.Any<IStoreComponentInfo>())
            {
              num = 3;
              continue;
            }
            goto case 4;
          case 10:
            if (message != null)
            {
              IChannelMessage channelMessage = InterfaceActivator.Create<IChannelMessage>();
              ExpirationChecker.TbZeMwAhSKI9RuYrylI((object) channelMessage, ExpirationChecker.vgelX4ABJmKhS56ARZb((object) message));
              ExpirationChecker.lXIAVdAoan3s6n3LEV2((object) channelMessage, ExpirationChecker.M1t3PjA1ZaQp5xbWod5((object) message));
              channelMessage.Recipients = (ISet<EleWise.ELMA.Security.Models.IUser>) new HashedSet<EleWise.ELMA.Security.Models.IUser>(EnumerableExtensions.CastOrNull<EleWise.ELMA.Security.Models.IUser>(message.GetRecipients()));
              ExpirationChecker.jDUL1jAm4VwlJ45euKx((object) channelMessage, ChannelMessageType.Post);
              ExpirationChecker.ttSqcJARrkrp2aJXAtp((object) channelMessage, (object) this.userManager.Load(SecurityConstants.SystemUserUid));
              channelMessage.CreationDate = new DateTime?(now);
              ExpirationChecker.T2fDaYADJRe12TKcuKQ((object) channelMessage);
              num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_aa54a61f50a144bab587b55f0c6b0d70 != 0 ? 4 : 4;
              continue;
            }
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_554df24f17e6425aa0fa1f122cedd090 != 0 ? 8 : 1;
            continue;
          case 11:
            dynamicNotification.ExtendedProperties.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-262195522 << 6 ^ 399359912), (object) componentsExpiration);
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_09d6ea8f51184538876ee96c32a45b45 != 0 ? 6 : 4;
            continue;
          case 12:
            goto label_19;
        }
        componentsExpiration = new ComponentsExpiration(this.userGroupManager, this.expirationInfoService);
        num = 9;
      }
label_22:
      return;
label_19:
      return;
label_3:
      throw new ArgumentNullException((string) ExpirationChecker.esY7hrAYrMroxi2qlI8(ExpirationChecker.vpxtGwAk5hwln8hCCkH(-1159094452 ^ -1159098840)));
label_17:
      throw new ArgumentNullException((string) ExpirationChecker.esY7hrAYrMroxi2qlI8(ExpirationChecker.vpxtGwAk5hwln8hCCkH(-1541009453 ^ -1541005425)));
label_20:
      throw new ArgumentNullException((string) ExpirationChecker.esY7hrAYrMroxi2qlI8((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1561482429 ^ 1561478167)));
label_23:
      throw new ArgumentNullException((string) ExpirationChecker.esY7hrAYrMroxi2qlI8(ExpirationChecker.vpxtGwAk5hwln8hCCkH(-1929249797 ^ -1929254157)));
    }

    internal static void i9t7VdANLWvafSKsYON() => TKW1L3mlUyvXmg29jA.RWk58XigPN();

    internal static bool CuTl6RA9PRRl7FQC8X6() => ExpirationChecker.lYMA20AcOkDue7S0eqC == null;

    internal static ExpirationChecker sogwfPAWZOItOHum53a() => ExpirationChecker.lYMA20AcOkDue7S0eqC;

    internal static TimeSpan vNh9aVAFelehIiMbeHi([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static TimeSpan utnA6sAZiNOtAHdADcF([In] double obj0) => TimeSpan.FromDays(obj0);

    internal static bool QoASenAwPBdSNi2QkUB([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 > obj1;

    internal static object vpxtGwAk5hwln8hCCkH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Qfnx6WAE5Zp3TUOLbmJ([In] object obj0, [In] object obj1) => ((DynamicNotification) obj0).TemplateName = (string) obj1;

    internal static object esY7hrAYrMroxi2qlI8([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object vgelX4ABJmKhS56ARZb([In] object obj0) => (object) ((IMessage) obj0).Subject;

    internal static void TbZeMwAhSKI9RuYrylI([In] object obj0, [In] object obj1) => ((IBaseMessage) obj0).Subject = (string) obj1;

    internal static object M1t3PjA1ZaQp5xbWod5([In] object obj0) => (object) ((IMessage) obj0).FullMessageText;

    internal static void lXIAVdAoan3s6n3LEV2([In] object obj0, [In] object obj1) => ((IBaseMessage) obj0).FullMessage = (string) obj1;

    internal static void jDUL1jAm4VwlJ45euKx([In] object obj0, [In] ChannelMessageType obj1) => ((IChannelMessage) obj0).MessageType = obj1;

    internal static void ttSqcJARrkrp2aJXAtp([In] object obj0, [In] object obj1) => ((IBaseMessage) obj0).CreationAuthor = (EleWise.ELMA.Security.Models.IUser) obj1;

    internal static void T2fDaYADJRe12TKcuKQ([In] object obj0) => ((IEntity) obj0).Save();
  }
}
