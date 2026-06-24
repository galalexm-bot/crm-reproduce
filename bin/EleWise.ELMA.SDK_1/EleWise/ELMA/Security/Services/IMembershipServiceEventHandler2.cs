// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IMembershipServiceEventHandler2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Расширенный обработчик событий авторизации в системе</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IMembershipServiceEventHandler2 : IMembershipServiceEventHandler, IEventHandler
  {
    /// <summary>Обработка ошибки валидации</summary>
    /// <param name="context"></param>
    void ValidationError(UserValidationContext context);
  }
}
