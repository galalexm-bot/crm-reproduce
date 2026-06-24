// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IInstancePermissionTypeRoleService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Привилегии для объекта типа, роли для привилегий, на основе экземпляра сущности
  /// </summary>
  public interface IInstancePermissionTypeRoleService : IPermissionTypeRoleService
  {
    /// <summary>
    /// Получить возможные привилегии и роли по экземпляру объекта.
    /// </summary>
    /// <param name="instance">Экземпляр объекта</param>
    /// <returns>Возвращает все возможные привилегии и роли</returns>
    IEnumerable<Tuple<Permission, PermissionRoleType[]>> GetInstancePermissionRoles(object instance);
  }
}
