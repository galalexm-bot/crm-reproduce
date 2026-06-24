// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IPermissionTypeRoleService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security
{
  public interface IPermissionTypeRoleService
  {
    /// <summary>Получить все роли</summary>
    /// <returns></returns>
    IEnumerable<PermissionRoleType> All();

    /// <summary>Получить роль по идентификатору</summary>
    /// <returns>null если не найдена</returns>
    PermissionRoleType Get(Guid id);

    /// <summary>
    /// Получить роль по идентификатору
    /// если не найдена бросается исключение
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    PermissionRoleType Load(Guid id);

    /// <summary>
    /// Получить возможные привилегии и роли по типу сущности.
    /// </summary>
    /// <returns></returns>
    IEnumerable<Tuple<Permission, PermissionRoleType[]>> GetPermissionRoles(Type type);
  }
}
