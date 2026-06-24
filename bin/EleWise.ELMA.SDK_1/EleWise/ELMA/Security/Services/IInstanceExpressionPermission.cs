// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IInstanceExpressionPermission
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System;
using System.Collections;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Интерфейс определения способа доступа к сущности на основе выражений, содержащих значения свойств экземпляра
  /// типа User, ICollection[User]
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IInstanceExpressionPermission
  {
    /// <summary>Тип сущности</summary>
    Type EntityType { get; }

    /// <summary>Тип привилегии</summary>
    Type PermissionType { get; }

    /// <summary>
    /// Названия свойств, по которым определяется факт обладания привилегией
    /// </summary>
    IPropertyExpressionDescriptor[] AccessExpressions { get; }

    /// <summary>Получить список привилегий</summary>
    /// <returns></returns>
    IEnumerable GetPermissionCollection(object target);

    /// <summary>
    /// Таблица в котрой хранятся привилегии
    /// В таблице должно быть 2 обязательных столбца
    /// 1) Target - идентификатор объекта к которому относится привилегия
    /// 2) UserId - идентификатор пользователя
    /// </summary>
    string PermissionsTable { get; }
  }
}
