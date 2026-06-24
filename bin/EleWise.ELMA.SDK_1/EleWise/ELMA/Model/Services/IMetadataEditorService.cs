// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.IMetadataEditorService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Интерфейс сервиса редактирования метаданных</summary>
  public interface IMetadataEditorService : IMetadataService
  {
    /// <summary>Получить имя редактируемого проекта</summary>
    string ProjectName { get; }

    /// <summary>
    /// Имя текущего проекта. В зависимости от него работают остальные функции сервиса
    /// </summary>
    string CurrentProjectName { get; set; }

    /// <summary>Получить метаданные сборки для указанного проекта</summary>
    /// <param name="projectName">Имя проекта</param>
    /// <returns>Метаданные сборки (или null, если не найдены)</returns>
    AssemblyInfoMetadata GetAssemblyInfoMetadata(string projectName);

    /// <summary>Получить список метаданных для текущего проекта</summary>
    /// <param name="inherited">True, если в список также нужно включать метаданные из проектов, на которые есть ссылка в текущем проекте</param>
    /// <returns>Список метаданных</returns>
    IEnumerable<IMetadata> GetMetadataList(bool inherited);

    /// <summary>Получить список метаданных для указанного проекта</summary>
    /// <param name="projectName">Имя проекта</param>
    /// <param name="inherited">True, если в список также нужно включать метаданные из проектов, на которые есть ссылка в текущем проекте</param>
    /// <returns>Список метаданных</returns>
    IEnumerable<IMetadata> GetMetadataList(string projectName, bool inherited);

    /// <summary>Получить объект метаданных по Uid-у</summary>
    /// <param name="projectName">Имя проекта</param>
    /// <param name="metadataUid">Uid объекта метаданных</param>
    /// <returns>Метаданные</returns>
    IMetadata GetMetadata(string projectName, Guid metadataUid);

    /// <summary>Сохранить объект метаданных</summary>
    /// <param name="metadata">Объект метаданных</param>
    void SaveMetadata(IMetadata metadata);

    /// <summary>Сохранить объекты метаданных</summary>
    /// <param name="metadataList">Объекты метаданных</param>
    void SaveMetadata(IEnumerable<IMetadata> metadataList);

    /// <summary>Публиковать объект метаданных (текущий черновик)</summary>
    /// <param name="metadata">Объект метаданных</param>
    /// <param name="comment">Комментарий</param>
    void PublishMetadata(IMetadata metadata, string comment);

    /// <summary>Публиковать объекты метаданных (текущие черновики)</summary>
    /// <param name="metadataList">Объекты метаданных</param>
    /// <param name="comment">Комментарий</param>
    void PublishMetadata(IEnumerable<IMetadata> metadataList, string comment);

    /// <summary>Удалить объект метаданных</summary>
    /// <param name="metadata">Объект метаданных</param>
    void RemoveMetadata(IMetadata metadata);

    /// <summary>Создать генератор кода</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Генератор кода</returns>
    ICodeGenerator CreateCodeGenerator(IMetadata metadata);

    /// <summary>Построить документацию</summary>
    void BuildDocumentation();

    /// <summary>Получить информацию об элементе метаданных</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Информация об элементе метаданных</returns>
    MetadataItemDTO GetMetadataItemDTO(IMetadata metadata);

    /// <summary>Получить все текущие элементы метаданных</summary>
    /// <returns>Список элементов метаданных</returns>
    IEnumerable<MetadataItemDTO> GetMetadataItemDTOList();
  }
}
