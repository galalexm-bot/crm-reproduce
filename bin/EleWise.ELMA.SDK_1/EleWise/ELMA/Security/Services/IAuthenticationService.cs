// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IAuthenticationService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Служба аутентификации системы</summary>
  /// <example>
  /// <code>
  /// //С помощью данного сервиса мы можем получить текущего пользователя,
  /// //получить информацию о авторизованных сессиях. Так же предоставляется возможность
  /// //удалять сессии.
  /// //запишем сервис в переменную, чтобы с ним легче было работать
  /// <![CDATA[var service = Locator.GetServiceNotNull<IAuthenticationService>();
  /// 
  /// //чтобы получить текущего пользователя, используйте следующие функции:
  /// //1. GetCurrentUser() - для получения системного пользователя (EleWise.ELMA.Security.IUser)
  /// var currentUser = service.GetCurrentUser();
  /// 
  /// //2. GetCurrentUser<T>() - для получения пользователя определённого типа
  /// var currentUser2 = service.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
  /// ]]>
  /// 
  /// //чтобы авторизовать пользователя в системе, используйте функцию SignIn(user, rememberMeSet)
  /// service.SignIn(UserManager.Instance.Load(4), false);
  /// 
  /// //чтобы убрать авторизацию пользователя, используйте функцию SignOut();
  /// //убирает авторизацию текущего пользователя
  /// service.SignOut();
  /// 
  /// //для установки авторизированного пользователя в рамках
  /// //одного запроса используйте функцию SetAuthenticatedUserForRequest
  /// service.SetAuthenticatedUserForRequest(UserManager.Instance.Load(5));
  /// 
  /// //для получения информации о активных авторизированных сессиях используйте функцию GetActiveSessions()
  /// var activeSessions = service.GetActiveSessions();
  /// 
  /// //для получения информации о авторизированных сессиях используйте функцию GetSession(filter),
  /// //где filter - экземпляр класса AuthenticatedSessionFilter. Данный фильтр предоставляет возможность
  /// //фильтровать по двум полям:
  /// //1.bool OnlyActive - выбирать только активные сессии;
  /// //2.bool OnlyConcurrentUsers - выбирать только сессии пользователей с конкурентными лицензиями.
  /// //Так же вместо filter можно передать null
  /// var sessions = service.GetSessions(null);
  /// 
  /// //чтобы удалить сессию по её тикету, используйте функцию RemoveSession(ticketId)
  /// service.RemoveSession(activeSession.First().TicketUid);
  /// 
  /// //чтобы удалить все авторизованные сессии пользователя, используйте функцию RemoveAllUserSessions(userId)
  /// service.RemoveAllUserSessions(user.Id);
  /// </code>
  /// </example>
  [PublicApiMember("AuthenticationServicesApi", "SR.M('Служба аутентификации системы')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса мы можем получить текущего пользователя,\r\n    /// //получить информацию о авторизованных сессиях. Так же предоставляется возможность\r\n    /// //удалять сессии.\r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.Authentication;\r\n    /// \r\n    /// //для получения текущего пользователя используйте функцию GetCurrentUser()\r\n    /// var currentUser = service.GetCurrentUser();\r\n    /// \r\n    /// //для получения информации о активных авторизированных сессиях используйте функцию GetActiveSessions()\r\n    /// var activeSessions = service.GetActiveSessions();\r\n    /// \r\n    /// //для получения информации о авторизированных сессиях используйте функцию GetSession(filter),\r\n    /// //где filter - экземпляр класса AuthenticatedSessionFilter. Данный фильтр предоставляет возможность\r\n    /// //фильтровать по двум полям:\r\n    /// //1.bool OnlyActive - выбирать только активные сессии;\r\n    /// //2.bool OnlyConcurrentUsers - выбирать только сессии пользователей с конкурентными лицензиями.\r\n    /// //Так же вместо filter можно передать null\r\n    /// var sessions = service.GetSessions(null); \r\n    /// \r\n    /// //чтобы удалить сессию по её тикету, используйте функцию RemoveSession(ticketId)\r\n    /// service.RemoveSession(activeSession.First().TicketUid);\r\n    /// \r\n    /// //чтобы удалить все авторизованные сессии пользователя, используйте функцию RemoveAllUserSessions(userId)\r\n    /// service.RemoveAllUserSessions(user.Id);\r\n    /// </code>')")]
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IAuthenticationService
  {
    /// <summary>Получить текущего пользователя системы</summary>
    /// <returns>Текущий пользователь, либо <c>null</c></returns>
    [PublicApiNodeId("AuthenticationServicesApi")]
    IUser GetCurrentUser();

    /// <summary>
    /// Получить идентификатор текущего авторизованного пользователя
    /// </summary>
    /// <returns></returns>
    object GetCurrentUserId();

    /// <summary>Получить текущего пользователя системы</summary>
    /// <typeparam name="T">Тип пользователя</typeparam>
    /// <returns>Текущий пользователь, либо <c>null</c></returns>
    T GetCurrentUser<T>() where T : IUser;

    /// <summary>Авторизовать пользователя системы</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="rememberMeSet">Запомнить авторизацию для следующей сессии</param>
    void SignIn(IUser user, bool rememberMeSet = false);

    /// <summary>Авторизовать пользователя системы</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="rememberMeSet">Запомнить авторизацию для следующей сессии</param>
    /// <param name="checkRequireChangePassword">Проверять обязательную смену пароля</param>
    void SignIn(IUser user, bool rememberMeSet, bool checkRequireChangePassword);

    /// <summary>Убрать авторизацию пользователя</summary>
    void SignOut();

    /// <summary>
    /// Установить авторизованного пользователя только в рамках этого запроса
    /// </summary>
    /// <param name="user">Пользователь</param>
    void SetAuthenticatedUserForRequest(IUser user);

    /// <summary>
    /// Установить идентификатор авторизованного пользователя в рамках этого запроса
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    void SetAuthenticatedUserIdForRequest(object userId);

    /// <summary>
    /// Получить информацию о текущей активной сессии контекста
    /// </summary>
    /// <returns>Сессия</returns>
    [PublicApiNodeId("AuthenticationServicesApi")]
    AuthenticatedSessionInfo GetCurrentSession();

    /// <summary>
    /// Получить информацию об активных авторизованных сессиях
    /// </summary>
    /// <returns></returns>
    [PublicApiNodeId("AuthenticationServicesApi")]
    IEnumerable<AuthenticatedSessionInfo> GetActiveSessions();

    /// <summary>Получить информацию об авторизованных сессиях</summary>
    /// <param name="filter">Фильтр</param>
    /// <returns>Список авторизованных сессий</returns>
    [PublicApiNodeId("AuthenticationServicesApi")]
    IEnumerable<AuthenticatedSessionInfo> GetSessions(AuthenticatedSessionFilter filter);

    /// <summary>Удалить авторизованную сессию</summary>
    /// <param name="ticketId"></param>
    [PublicApiNodeId("AuthenticationServicesApi")]
    void RemoveSession(Guid ticketId);

    /// <summary>
    /// Удалить все авторизованные сессии указанного пользователя
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    [PublicApiNodeId("AuthenticationServicesApi")]
    void RemoveAllUserSessions(object userId);
  }
}
