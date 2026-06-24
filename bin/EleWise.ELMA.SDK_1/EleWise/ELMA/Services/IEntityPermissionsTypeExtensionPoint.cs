// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IEntityPermissionsTypeExtensionPoint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Services
{
  /// <summary>Точка расширения для обработки изменения прав доступа</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IEntityPermissionsTypeExtensionPoint
  {
    /// <summary>Выполнить изменение типа прав доступа</summary>
    /// <param name="metadata">Метаданные обновляемого объекта</param>
    /// <param name="needDropOldData">Удалить текущие права доступа</param>
    void UpdatePermissions(EntityMetadata metadata, bool needDropOldData);

    /// <summary>Выполнить изменение типа прав доступа</summary>
    /// <param name="type">Тип объекта</param>
    /// <param name="id">Идентификатор объекта</param>
    /// <param name="needDropOldData">Сбрасывать ли накопленные привилегии</param>
    void UpdatePermissions(Type type, long id, bool needDropOldData);

    /// <summary>Создать сущность для хранения прав доступа</summary>
    /// <param name="metadata">Метаданные типа, для которого создаётся тип привилегий</param>
    IEnumerable<PropertyMetadata> GetDefaultPermissionMetadataProperties(EntityMetadata metadata);

    /// <summary>Добавить интерфейсы типу</summary>
    /// <param name="metadata">Метаданные типа, для которого создаётся тип привилегий</param>
    IEnumerable<string> GetImplementedInterfaces(EntityMetadata metadata);

    /// <summary>Получить partial кастомный код для класса</summary>
    /// <param name="metadata">Метаданные типа, для которого создаётся тип привилегий</param>
    /// <param name="permissionMetadata">Метаданные создаваемого типа</param>
    /// <param name="enabled">Метаданные поддерживают права доступа</param>
    string CustomCode(EntityMetadata metadata, EntityMetadata permissionMetadata, bool enabled);

    /// <summary>Поддерживаются ли права доступа к сущности</summary>
    /// <param name="instance">Объект привилегий</param>
    bool IsInstancePermissionMode(object instance);
  }
}
