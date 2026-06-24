// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.ServerRestartManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Реализация менеджера перезапуска сервера.</summary>
  [Component(Type = ComponentType.WebServer)]
  public class ServerRestartManager : DTOManager, IServerRestartManager, IConfigurationService
  {
    private IServerRestartService service;
    internal static ServerRestartManager S5W00ZWMKB2XuJRxykT1;

    /// <summary>
    /// Инициализирует менеджер с указанным планировщиком перезапуска сервера.
    /// </summary>
    /// <param name="service"></param>
    public ServerRestartManager(IServerRestartService service)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.service = service;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) service, (string) ServerRestartManager.AiFV7OWMksSOu014ZwgH(--1867379187 ^ 1867288979));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Запланировать перезапуск сервера на назначенную дату.</summary>
    /// <param name="userId">Пользователь, от имени которого планируется перезапустить сервер.</param>
    /// <param name="targetDate">Запланированная дата перезапуска сервера.</param>
    /// <param name="reason">Причина перезапуска.</param>
    /// <param name="sendNotifications">Отправлять уведомления о перезапуске в ленту.</param>
    /// <returns>Идентификатор перезапуска.</returns>
    public virtual Guid Schedule(
      long userId,
      DateTime targetDate,
      string reason,
      bool sendNotifications)
    {
      return ServerRestartManager.yBSX1YWMnN49vixfNTyr((object) this.service, userId, targetDate, (object) reason, sendNotifications);
    }

    /// <summary>Отменить запланированный перезапуск.</summary>
    /// <param name="restartId">Идентификатор задачи на перезапуск.</param>
    /// <exception cref="T:EleWise.ELMA.Exceptions.ServerRestartCancellationException">Произошла ошибка отмены перезапуска.</exception>
    public virtual void CancelRestart(Guid restartId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ServerRestartManager.qVIPEjWMO2j86Ivfgwt4((object) this.service, restartId);
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

    /// <summary>
    /// Получает минимальное время, считая от текущего момента времени, через которое можно запланировать перезапуск из настроек.
    /// </summary>
    public virtual TimeSpan GetMinimumRestartTime() => ServerRestartManager.WansdlWM24eip04epmjQ((object) this.service);

    internal static object AiFV7OWMksSOu014ZwgH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool vVBl8eWMXpbnBmOQZNP9() => ServerRestartManager.S5W00ZWMKB2XuJRxykT1 == null;

    internal static ServerRestartManager tX4vY2WMTRlBHvtMhtGw() => ServerRestartManager.S5W00ZWMKB2XuJRxykT1;

    internal static Guid yBSX1YWMnN49vixfNTyr(
      [In] object obj0,
      long userId,
      DateTime restartDate,
      [In] object obj3,
      bool sendNotifications)
    {
      return ((IServerRestartService) obj0).Schedule(userId, restartDate, (string) obj3, sendNotifications);
    }

    internal static void qVIPEjWMO2j86Ivfgwt4([In] object obj0, Guid restartId) => ((IServerRestartService) obj0).CancelRestart(restartId);

    internal static TimeSpan WansdlWM24eip04epmjQ([In] object obj0) => ((IServerRestartService) obj0).GetMinimumRestartTime();
  }
}
