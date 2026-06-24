// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.IMetadataRuntimeService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>
  /// Интерфейс службы управления метаданными в режиме Runtime
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IMetadataRuntimeService : IMetadataService
  {
    /// <summary>Получить родительский объект метаданных</summary>
    /// <param name="metadataUid">Уникальный идентификатор подчиненного объекта метаданных</param>
    /// <returns>Родительский объект метаданных или Null</returns>
    IMetadata GetParentMetadata(Guid metadataUid);

    /// <summary>Получить тип по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор типа</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Тип. Если не найден, вызывается исключение.</returns>
    Type GetTypeByUid(Guid uid, bool loadImplementation = true);

    /// <summary>Получить тип по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор типа</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Тип. Если не найден, возвращается Null.</returns>
    Type GetTypeByUidOrNull(Guid uid, bool loadImplementation = true);

    /// <summary>Зарегистрировать тип</summary>
    /// <param name="type">Тип</param>
    void RegisterType(Type type);

    /// <summary>Зарегистрировать тип</summary>
    /// <param name="type">Тип</param>
    /// <param name="asEntity">Регистрировать как сущность</param>
    void RegisterType(Type type, bool asEntity);

    /// <summary>Зарегистрировать типы</summary>
    /// <param name="types">Типы</param>
    /// <param name="registrationException">Действие, которое нужно выполнять при ошибке регистрации</param>
    void RegisterTypes(IEnumerable<Type> types, Action<Type, Exception> registrationException = null);

    /// <summary>Зарегистрировать типы</summary>
    /// <param name="types">Типы</param>
    /// <param name="asEntity">Регистрировать как сущность</param>
    /// <param name="registrationException">Действие, которое нужно выполнять при ошибке регистрации</param>
    void RegisterTypes(
      IEnumerable<Type> types,
      bool asEntity,
      Action<Type, Exception> registrationException = null);

    /// <summary>Зарегистрировать типы</summary>
    /// <param name="types">Типы</param>
    /// <param name="entityNames">Имена сущностей для регистрации</param>
    /// <param name="registrationException">Действие, которое нужно выполнять при ошибке регистрации</param>
    void RegisterTypes(
      IEnumerable<Type> types,
      IDictionary<Type, string> entityNames,
      Action<Type, Exception> registrationException = null);

    /// <summary>Получить список текущих метаданных моделей сборок</summary>
    /// <returns>Список метаданных моделей сборок</returns>
    IEnumerable<AssemblyModelsMetadata> GetAssemblyModelsMetadataList();

    /// <summary>
    /// Получить список метаданных моделей сборок в предыдущий запуск приложения
    /// </summary>
    /// <returns>Список метаданных моделей сборок</returns>
    IEnumerable<AssemblyModelsMetadata> GetPreviousAssemblyModelsMetadataList();

    /// <summary>
    /// Признак, что требуется перекомпиляция сценариев модели дизайнера
    /// </summary>
    bool ConfigurationScriptsRecompileRequired { get; }

    /// <summary>Ошибки при компиляции сценариев</summary>
    string ConfigurationScriptsErrors { get; }

    /// <summary>Являются ли метаданные системными</summary>
    /// <param name="typeUid">Идентификатор метаданных</param>
    new bool IsSystem(Guid typeUid);

    /// <summary>Являются ли метаданные созданными в конфигурации</summary>
    /// <param name="typeUid">Идентификатор метаданных</param>
    new bool IsConfig(Guid typeUid);
  }
}
