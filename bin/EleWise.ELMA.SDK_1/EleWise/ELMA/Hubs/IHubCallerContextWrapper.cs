// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Hubs.IHubCallerContextWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;
using System.Security.Principal;

namespace EleWise.ELMA.Hubs
{
  /// <summary>Контекст пользователя, вызывающего метод хаба</summary>
  public interface IHubCallerContextWrapper
  {
    /// <summary>Получить идентификатор соединения вызывающего клиента</summary>
    string ConnectionId { get; }

    /// <summary>Получить куки для запроса</summary>
    IDictionary<string, ICookieWrapper> RequestCookies { get; }

    /// <summary>Получить заголовки для запроса</summary>
    INameValueCollectionWrapper Headers { get; }

    /// <summary>Получить строку запроса</summary>
    INameValueCollectionWrapper QueryString { get; }

    /// <summary>
    /// Получить информацию о безопасности для текущего http-запроса
    /// </summary>
    IPrincipal User { get; }

    /// <summary>
    /// Получить <see cref="T:EleWise.ELMA.Hubs.IRequestWrapper" /> для текущего http-запроса.
    /// </summary>
    IRequestWrapper Request { get; }
  }
}
