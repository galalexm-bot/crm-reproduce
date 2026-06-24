// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IAuthenticationServiceEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using System;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Обработчик событий авторизации в системе</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IAuthenticationServiceEventHandler : IEventHandler
  {
    /// <summary>Пользователь вошел в систему</summary>
    void SignedIn(IUser user);

    /// <summary>Пользователь вышел из системы</summary>
    void SignedOut(IUser user);

    /// <summary>Зарегистрирована новая сессия</summary>
    [Obsolete("Устаревший метод. Используйте интерфейс IAuthenticatedSessionEventHandler вместо этого. Будет удалена в будущих версиях")]
    void SessionRegistered(IUser user);

    /// <summary>Сессия закрыта</summary>
    [Obsolete("Устаревший метод. Используйте интерфейс IAuthenticatedSessionEventHandler вместо этого. Будет удалена в будущих версиях")]
    void SessionClosed(IUser user);
  }
}
