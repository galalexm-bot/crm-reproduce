// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IPropertyPermissionService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Сервис для работы с настройками доступа к полям и свойствам справочников
  /// </summary>
  public interface IPropertyPermissionService
  {
    /// <summary>Проверить привилегии на свойство</summary>
    /// <param name="dataItem">Объект проверки</param>
    /// <param name="propertyGuid">UID свойства в объекте</param>
    /// <param name="user">Пользователь. Если не указан - проверять для текущего</param>
    /// <returns>Уровень доступа</returns>
    PropertyPermissionType CheckPropertyPermission(object dataItem, Guid propertyGuid, IUser user = null);

    /// <summary>
    /// Проверить привилегии на свойство используя только глобальные проверки (Пользователь, Группа, Должность)
    /// </summary>
    /// <param name="modelType">Тип объекта для проверки</param>
    /// <param name="propertyGuid">UID свойства в типе объекта</param>
    /// <param name="user">Пользователь. Если не указан - проверять для текущего</param>
    /// <returns>Уровень доступа</returns>
    PropertyPermissionType CheckPropertyPermissionByGlobalOnly(
      Type modelType,
      Guid propertyGuid,
      IUser user = null);

    /// <summary>
    /// Проверить привилегии на свойство используя только проверки по связанному свойству.
    /// </summary>
    /// <param name="dataItem">Объект проверки</param>
    /// <param name="propertyGuid">UID свойства в объекте</param>
    /// <param name="user">Пользователь. Если не указан - проверять для текущего</param>
    /// <returns>Уровень доступа</returns>
    PropertyPermissionType CheckPropertyPermissionByRoleOnly(
      object dataItem,
      Guid propertyGuid,
      IUser user = null);

    /// <summary>
    /// Проверить, настроены ли привилегии по связанному свойству
    /// </summary>
    /// <param name="modelType">Тип объекта для проверки</param>
    /// <param name="propertyGuid">UID свойства в типе объекта</param>
    /// <param name="user">Пользователь. Если не указан - проверять для текущего</param>
    /// <returns><c>true</c>, если есть хотя бы одна ролевая настройка для указанного свойства</returns>
    bool HasPermissionsByRole(Type modelType, Guid propertyGuid, IUser user = null);

    /// <summary>
    /// Проверить, настроены ли для указанного типа какие-либо привилегии для свойств
    /// </summary>
    /// <param name="modelType">Тип объекта для проверки</param>
    /// <returns><c>true</c>, если есть хотя бы одна настройка для свойства</returns>
    bool HasPermissions(Type modelType);
  }
}
