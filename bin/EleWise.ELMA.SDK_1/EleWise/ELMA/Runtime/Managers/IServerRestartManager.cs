// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.IServerRestartManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using System;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Реализация менеджера перезапуска сервера.</summary>
  public interface IServerRestartManager : IConfigurationService
  {
    /// <summary>Запланировать перезапуск сервера на назначенную дату.</summary>
    /// <param name="userId">Пользователь, от имени которого планируется перезапустить сервер.</param>
    /// <param name="targetDate">Запланированная дата перезапуска сервера.</param>
    /// <param name="reason">Причина перезапуска.</param>
    /// <param name="sendNotifications">Отправлять уведомления о перезапуске в ленту.</param>
    /// <returns>Идентификатор задачи на перезапуск.</returns>
    Guid Schedule(long userId, DateTime targetDate, string reason, bool sendNotifications);

    /// <summary>Отменить запланированный перезапуск.</summary>
    /// <param name="restartId">Идентификатор задачи на перезапуск.</param>
    /// <exception cref="T:EleWise.ELMA.Exceptions.ServerRestartCancellationException">Произошла ошибка отмены перезапуска.</exception>
    void CancelRestart(Guid restartId);

    /// <summary>
    /// Получает минимальное время, считая от текущего момента времени, через которое можно запланировать перезапуск из настроек.
    /// </summary>
    TimeSpan GetMinimumRestartTime();
  }
}
