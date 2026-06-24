// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IAuthenticationTokenService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Сервис, позволяющий создавать токены для авторизованных пользователей
  /// </summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IAuthenticationTokenService
  {
    /// <summary>Создать токен</summary>
    /// <param name="user">Пользователь</param>
    /// <returns>Токен</returns>
    Guid CreateToken([NotNull] IUser user);

    /// <summary>Получить пользователя по токену</summary>
    /// <param name="token">Токен</param>
    /// <returns>Пользователь</returns>
    [CanBeNull]
    IUser GetUser(Guid token);

    /// <summary>Удалить токен</summary>
    /// <param name="token">Токен</param>
    void RemoveToken(Guid token);
  }
}
