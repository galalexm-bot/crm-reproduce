// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ExtensionPoints.IDomainExternalMembership
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Settings;
using System;

namespace EleWise.ELMA.Security.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для реализации внешней авторизации доменного пользователя
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IDomainExternalMembership
  {
    Guid Uid { get; }

    IUser ValidateDomainUser(string userName, IExternalMembershipModuleSettings settings);
  }
}
