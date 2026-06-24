// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.IModelManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>
  /// Менеджер управления моделями приложения через дизайнер ELMA
  /// </summary>
  public interface IModelManager : IConfigurationService
  {
    /// <summary>Получить метаданные моделей сборки с указанным именем</summary>
    /// <param name="assemblyName">Имя сборки</param>
    /// <returns>Метаданные сборки</returns>
    AssemblyModelsMetadata GetAssemblyModelsMetadata(string assemblyName);

    /// <summary>Получить список метаданных моделей сборкок</summary>
    /// <returns>Список метаданных моделей сборок</returns>
    IEnumerable<AssemblyModelsMetadata> GetAssemblyModelsMetadataList();

    /// <summary>
    /// Получить список метаданных моделей сборкок в сжатом виде для дизайнера
    /// </summary>
    /// <returns>Список метаданных моделей сборок</returns>
    byte[] GetAssemblyModelsMetadataCompressed();

    /// <summary>
    /// Инициализировано ли дерево ELMA API. Если нет - возвращается False, и на сервере асинхронно начинается инициализация
    /// </summary>
    /// <returns></returns>
    bool IsElmaApiTreeInitialized();

    /// <summary>Получить метаданные дерева ELMA API</summary>
    /// <returns></returns>
    byte[] GetElmaApiTree();

    /// <summary>Получить список элементов метаданных</summary>
    /// <returns>Список элементов метаданных</returns>
    IEnumerable<MetadataItemDTO> GetMetadataItems();

    /// <summary>Сохранить элементы метаданных</summary>
    /// <param name="metadataItems">Элементы метаданных</param>
    /// <returns>Сохраненный элемент</returns>
    List<MetadataItemDTO> SaveMetadataItems(List<MetadataItemDTO> metadataItems);

    /// <summary>Удалить объект метаданных</summary>
    /// <param name="metadataItemId">Идентификатор объекта метаданных</param>
    void DeleteMetadataItem(long metadataItemId);

    /// <summary>Опубликовать указанные элементы метаданных</summary>
    /// <param name="comment">Комментарий к публикации</param>
    /// <param name="headerIds">Идентификаторы заголовков метаданных</param>
    /// <returns>Метаданные сборки конфигурации</returns>
    MetadataPublishResult Publish(string comment, params long[] headerIds);

    /// <summary>
    /// Загрузить элемент метаданных по идентификатору заголовка
    /// </summary>
    /// <param name="headerId">Элемент метаданных</param>
    MetadataItemDTO LoadMetadataItemByHeaderId(long headerId);

    /// <summary>Запущен ли объект метаданных</summary>
    /// <param name="metadataUid">Уникальный идентификатор метаданных</param>
    /// <returns>True, если запущен</returns>
    bool IsMetadataStarted(Guid metadataUid);

    /// <summary>UID-ы запущенных метаданных</summary>
    /// <returns></returns>
    List<Guid> GetMetadataStarted();

    /// <summary>
    /// Опубликовано ли свойство с идентификатором <paramref name="propertyUid" /> в сущности с идентификатором <paramref name="metadataUid" />
    /// </summary>
    /// <param name="metadataUid">Уникальный идентификатор метаданных сущности</param>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns></returns>
    bool IsPublishedProperty(Guid metadataUid, Guid propertyUid);

    /// <summary>Является ли имя зарезервированным словом СУБД</summary>
    /// <param name="name">Имя</param>
    /// <returns>True, если является</returns>
    bool IsDbReservedWord(string name);

    /// <summary>
    /// Получить список идентификаторов объектов метаданных, для которых требуется перезапуск сервера
    /// </summary>
    /// <returns></returns>
    List<Guid> GetRestartRequiredMetadataUids();

    /// <summary>Получить главный модуль сценариев модели</summary>
    /// <returns></returns>
    [Obsolete("Not used", true)]
    ScriptModuleDTO GetModelScriptModule();

    /// <summary>Сохранить главный модуль сценариев модели</summary>
    /// <param name="scriptModuleDto">Модуль сценариев</param>
    [Obsolete("Not used", true)]
    void SaveModelScriptModule(ScriptModuleDTO scriptModuleDto);

    /// <summary>
    /// Добавить в главный модуль сценариев модули указанные ссылки на сборки
    /// </summary>
    /// <param name="references"></param>
    [Obsolete("Not used", true)]
    void AddModelScriptModuleReferences(IEnumerable<string> references);

    /// <summary>Получить информацию о сущности</summary>
    /// <param name="typeUid">Уникальный идентификатор типа сущности</param>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Информация о сущности</returns>
    EntityInfo GetEntityInfo(Guid typeUid, string id);

    /// <summary>
    /// Получить опубликованные DTO для элемента метаданных по Uid
    /// </summary>
    /// <param name="uid">Уникальный идентификатор объекта метаданных</param>
    /// <returns>Опубликованные метаданные</returns>
    MetadataItemDTO GetPublishedMetadataByUid(Guid uid);
  }
}
