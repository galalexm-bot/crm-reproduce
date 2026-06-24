// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.PublicContractInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.API
{
  public static class PublicContractInfo
  {
    /// <summary>Ключ текущей сессии в контексте</summary>
    public const string SessionContextKey = "PublicContractInfo.SessionContextKey";
    /// <summary>Ключ текущего публичного приложения в контексте</summary>
    public const string ExecutingApplicationContextKey = "PublicContractInfo.ExecutingApplicationContextKey";
    /// <summary>Имя пространства имен API</summary>
    public const string ContractNamespace = "http://www.elma-bpm.ru/api/";
    /// <summary>
    /// Заголовок запроса содержащий токен доверенного приложения
    /// </summary>
    public const string ApplicationTokenHeader = "ApplicationToken";
    /// <summary>Заголовок запроса содержащий токен сессии приложения</summary>
    public const string SessionTokenHeader = "SessionToken";
    /// <summary>
    /// Заголовок запроса содержащий токен текущей авторизации
    /// </summary>
    public const string AuthTokenHeader = "AuthToken";
    /// <summary>Заголовок дополнительной информации для авторизации</summary>
    public const string AuthInfoHeader = "Auth-Info";
    /// <summary>Заголовок со списком подписанных заголовков</summary>
    public const string SignedHeadersHeader = "Signed-Headers";
    /// <summary>
    /// Стандартный заголовок авторизации <a href="https://tools.ietf.org/html/rfc7235#section-4.2">RFC7235</a>
    /// </summary>
    public const string AuthorizationHeader = "Authorization";
    /// <summary>
    /// Префикс для Bearer-схемы авторизации <a href="https://tools.ietf.org/html/rfc6750#section-2.1">RFC6750</a>
    /// </summary>
    public const string AuthorizationBearerPrefix = "Bearer ";
    /// <summary>
    /// Ключ параметра языка авторизованного пользователя для токена авторизации
    /// </summary>
    public const string JwtLangClaim = "lang";
    /// <summary>
    /// Текущая версия корневого API системы. Увеличивается при изменении сигнатуры сервисов SDK.<para />
    /// Минорное увеличение может быть сделано при добавлении функций или добавлении опциональных параметров в методы API.
    /// </summary>
    /// <remarks>
    /// Первое число - основная версия API, ее изменение означает, что функционал изменен кардинально <para />
    /// Второе число - мажорная версия API, ее изменение означает, что были изменены обязательные параметры методов или сами методы переименованы \ удалены <para />
    /// Третье число - минорная версия API, ее изменение означает, что добавлены необязательные функции или опциональные параметры <para />
    /// <para />
    /// Описание корневых сервисов в базе знаний: http://www.elma-bpm.ru/kb/article-137.html <para />
    /// Обновление до версии 1.0.1: http://www.elma-bpm.ru/kb/article-359.html
    /// </remarks>
    public const string ApiVersionString = "1.0.9";
  }
}
