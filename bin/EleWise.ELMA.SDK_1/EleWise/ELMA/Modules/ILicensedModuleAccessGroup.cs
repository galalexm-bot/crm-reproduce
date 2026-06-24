// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.ILicensedModuleAccessGroup
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Modules
{
  /// <summary>
  /// Определяет для лицензируемого модуля группу пользователей с правами доступа на этот модуль
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface ILicensedModuleAccessGroup
  {
    /// <summary>Идентификатор модуля</summary>
    Guid ModuleUid { get; }

    /// <summary>Идентификатор группы пользователей</summary>
    Guid UserGroupUid { get; }
  }
}
