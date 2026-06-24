// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.IPublicClientSession
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security;
using System;

namespace EleWise.ELMA.API.Models
{
  public interface IPublicClientSession
  {
    /// <summary>Токен авторизации</summary>
    Guid AuthToken { get; }

    /// <summary>Токен публичного приложения</summary>
    IPublicApplicationToken ClientToken { get; }

    /// <summary>Публичное приложение</summary>
    IPublicApplication Application { get; }

    /// <summary>Токен сессии</summary>
    string SessionToken { get; }

    /// <summary>Авторизованный пользователь</summary>
    IUser AuthUser { get; }

    /// <summary>Дата последнего подключения</summary>
    DateTime LastAccess { get; }

    /// <summary>Последний запрос изменений</summary>
    byte[] LastChangesPackage { get; set; }
  }
}
