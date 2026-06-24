// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IInstanceSettingsPermission
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Интерфейс прав доступа к экземпляру объекта на основе настроек
  /// Пример 1: доступ к документу настраивается в карточке документа, правами могут обладать:
  /// - автор
  /// - пользователь
  /// - группа
  /// - эл-т организационной структуры
  /// Пример 2: доступ к кастомному отчету настривается на странице отчета
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-813.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IInstanceSettingsPermission
  {
    /// <summary>Тип сущности</summary>
    Type EntityType { get; }

    /// <summary>
    /// Получить коллекцию объектов, в которых хранится информация об обладателях привилегий
    /// </summary>
    /// <returns></returns>
    ICollection<IInstanceSettingsPermissionHolder> GetPermissionCollection(object target);

    /// <summary>
    /// Нужно ли фильтровать экземпляры сущности при загрузке автоматически
    /// </summary>
    bool Filtering { get; }

    /// <summary>
    /// Имя свойства-ссылки на сущность в коллекции, хранящей предоставленные привилегии
    /// </summary>
    string TargetPropetyName { get; }

    /// <summary>
    /// Тип сущности, хранящей предоставленные привилегии (в коллекции)
    /// </summary>
    Type PermissionHolderType { get; }

    /// <summary>
    /// Привилегия администрирования сущностей, если задана,
    /// то пользователь, обладающий данной привилегией, получает все привилегии на объекты EntityType
    /// </summary>
    Permission AdminPermission { get; }

    /// <summary>
    /// Проверить, может ли пользователь предоставлять другим пользователям привилегии на объект
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="target">Объект, на который выдаются права</param>
    /// <returns><c>true</c>, если пользователь может предоставлять другим пользователям привилегии на объект</returns>
    bool CanGrandPermissions(IUser user, object target);

    /// <summary>
    /// Расчет привилегий, которые может раздавать данный пользователь
    /// Если null, то раздавать можно любой пермишен
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="target">Объект, на который выдаются права</param>
    /// <returns></returns>
    ICollection<Permission> CanGrandLevel(IUser user, object target);

    /// <summary>Можно ли раздавать права на элемент</summary>
    /// <param name="elementPermission"></param>
    /// <param name="userPermission"></param>
    /// <param name="permissionToCheck"></param>
    /// <param name="permissionRoleTypeId">Идентификатор типа роли</param>
    /// <param name="permissionRole">Роль</param>
    /// <param name="target">Объект, для которого выполняется настройка прав.</param>
    /// <returns><c>true</c>, если можно раздать права на элемент</returns>
    bool CanGrandToElement(
      Permission[] elementPermission,
      Permission[] userPermission,
      Permission permissionToCheck,
      Guid permissionRoleTypeId,
      IEntity permissionRole,
      object target);

    /// <summary>Системная роль, которую нельзя удалять.</summary>
    /// <param name="permissionRoleTypeId">Идентификатор типа роли.</param>
    /// <param name="permissionRole">Роль</param>
    /// <param name="target">Объект, для которого выполняется настройка прав.</param>
    /// <returns><c>true</c>, если роль системная</returns>
    bool IsSystemRole(Guid permissionRoleTypeId, IEntity permissionRole, object target);
  }
}
