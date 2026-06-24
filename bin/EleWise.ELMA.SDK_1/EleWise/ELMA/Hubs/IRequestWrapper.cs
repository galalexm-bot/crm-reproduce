// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Hubs.IRequestWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading.Tasks;

namespace EleWise.ELMA.Hubs
{
  /// <summary>Интерфейс запроса</summary>
  public interface IRequestWrapper
  {
    /// <summary>Получить URL для этого запроса</summary>
    Uri Url { get; }

    /// <summary>Локальная часть пути URL</summary>
    string LocalPath { get; }

    /// <summary>Получить строку запроса</summary>
    INameValueCollectionWrapper QueryString { get; }

    /// <summary>Получить заголовки для этого запроса</summary>
    INameValueCollectionWrapper Headers { get; }

    /// <summary>Получить куки для этого запроса</summary>
    IDictionary<string, ICookieWrapper> Cookies { get; }

    /// <summary>
    /// Получить информацию о безопасности для текущего http-запроса
    /// </summary>
    IPrincipal User { get; }

    /// <summary>Получить owin-окружение</summary>
    IDictionary<string, object> Environment { get; }

    /// <summary>Прочитать форму http-запроса</summary>
    /// <returns></returns>
    Task<INameValueCollectionWrapper> ReadForm();
  }
}
