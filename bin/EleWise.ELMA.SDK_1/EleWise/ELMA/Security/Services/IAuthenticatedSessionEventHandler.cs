// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IAuthenticatedSessionEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Обработчик событий авторизованной сессии пользователя</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IAuthenticatedSessionEventHandler : IEventHandler
  {
    /// <summary>Зарегистрирована новая сессия</summary>
    void SessionRegistered(IUser user, AuthenticatedSessionInfo sessionInfo);

    /// <summary>Сессия закрыта</summary>
    void SessionClosed(IUser user, AuthenticatedSessionInfo sessionInfo);
  }
}
