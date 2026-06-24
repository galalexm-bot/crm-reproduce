// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IInstanceSettingsPermissionHolder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Информация об облажателе привилегии (элемент коллекции)
  /// TODO объединить это с интерфейсом IInstanceExpressionPermissionHolder ???
  /// </summary>
  public interface IInstanceSettingsPermissionHolder
  {
    /// <summary>
    /// Обладатель привилегии (пользователь, группа, эл-т организационной структуры и пр.)
    /// </summary>
    IEntity Assigned { get; set; }

    /// <summary>
    /// Роль обладателя привилегии, это может быть автор, инициатор процесса, группа пользователей и пр.
    /// </summary>
    Guid TypeRoleId { get; set; }

    /// <summary>Идентификатор привилегии</summary>
    Guid PermissionId { get; set; }

    /// <summary>
    /// Предмет привилегии ( то на что предоставлена привилегия)
    /// </summary>
    object Target { get; set; }
  }
}
