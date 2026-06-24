// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.IPublicClientService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.API
{
  /// <summary>
  /// Интерфейс сервиса работы с сессиями внешних приложений
  /// </summary>
  public interface IPublicClientService
  {
    /// <summary>Список текущих сессий</summary>
    IEnumerable<IPublicClientSession> Sessions { get; }

    /// <summary>Создать сессию клиента</summary>
    /// <param name="authToken">Токен авторизации</param>
    /// <param name="applicationToken">Токен доверенного приложения</param>
    /// <returns>Сессия или <c>null</c></returns>
    IPublicClientSession CreateSession(Guid authToken, string applicationToken);

    /// <summary>Обновить токен авторизации в сессии</summary>
    /// <param name="sessionToken">Токен клиентской сессии</param>
    /// <param name="newToken">Новый токен авторизации</param>
    /// <returns><c>true</c>, если обновление прошло успешно</returns>
    bool UpdateAuthToken(string sessionToken, Guid newToken);

    /// <summary>Проверить, можно ли использовать сессию</summary>
    /// <param name="sessionToken">Токен клиентской сессии</param>
    /// <param name="session">Сессия</param>
    /// <returns><c>true</c>, если сессия активна</returns>
    bool IsSessionValid(string sessionToken, out IPublicClientSession session);

    /// <summary>Обновить время последнего доступа к сессии</summary>
    /// <param name="sessionToken">Токен клиентской сессии</param>
    /// <returns><c>true</c>, если обновление прошло успешно</returns>
    bool PromoteSession(string sessionToken);

    /// <summary>Удалить сессию и все связанные данные</summary>
    /// <param name="sessionToken">Токен клиентской сессии</param>
    /// <returns><c>true</c>, если удаление прошло успешно</returns>
    bool RemoveSession(string sessionToken);

    /// <summary>
    /// Получить сессию по токену авторизации. Активность сессии не проверяется.
    /// </summary>
    /// <param name="authToken">Токен авторизации</param>
    /// <returns>Сессия или <c>null</c></returns>
    IPublicClientSession GetSession(Guid authToken);

    /// <summary>Обновить последний пакет с изменениями</summary>
    /// <param name="authToken">Токен авторизации</param>
    /// <param name="changesPackage">Пакет изменений</param>
    /// <returns><c>true</c>, если обновление прошло успешно</returns>
    bool UpdateLastChangesPackage(Guid authToken, string changesPackage);

    /// <summary>Удалить истекшие по времени сессии</summary>
    /// <param name="expireInterval">Интервал проверки срока истечения</param>
    /// <returns>Количество удаленных сессий</returns>
    long RemoveExpired(TimeSpan expireInterval);
  }
}
