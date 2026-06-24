// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IAuthenticationServiceEventHandler2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using System;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Расширенный обработчик событий авторизации в системе
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IAuthenticationServiceEventHandler2 : 
    IAuthenticationServiceEventHandler,
    IEventHandler
  {
    /// <summary>Ошибка при авторизации</summary>
    /// <param name="error"></param>
    void SignInError(IUser user, Exception error);
  }
}
