// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IPermissionManagmentService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security
{
  /// <summary>Управление привилегиями: манипуляции со списком</summary>
  public interface IPermissionManagmentService
  {
    /// <summary>Получить список привилегий</summary>
    /// <returns></returns>
    IEnumerable<Permission> GetPermissions();

    /// <summary>Получить информацию о привилегии по идентификатору</summary>
    /// <param name="permissionId"></param>
    /// <returns></returns>
    Permission GetPermission(Guid permissionId);

    /// <summary>Пролучить привилегию по базовой</summary>
    /// <param name="permission"></param>
    /// <returns></returns>
    Permission GetPermissionForBase(Permission permission, Type entityType);

    /// <summary>
    /// Получить привилегию, которая определяет доступ к модулю
    /// </summary>
    /// <param name="moduleUid"></param>
    /// <returns></returns>
    Permission GetModuleAccessPermission(string moduleUid);
  }
}
