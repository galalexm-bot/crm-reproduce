// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.ISearchMetadataService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Сервис поиска метаданных</summary>
  public interface ISearchMetadataService
  {
    /// <summary>Получить все опубликованные метаданные DTO</summary>
    /// <returns>Опубликованные метаданные DTO вместе со сборками</returns>
    IEnumerable<DataClassMetadata> GetPublishedDataClasses();

    /// <summary>Получить все опубликованные сборки метаданных DTO</summary>
    /// <returns></returns>
    IEnumerable<DataClassAssemblyInfo> GetPublishedDataClassAssemblies();

    /// <summary>Получить все черновые метаданные DTO</summary>
    /// <returns>Черновики метаданных DTO</returns>
    IEnumerable<DataClassMetadata> GetDraftDataClasses();

    /// <summary>
    /// Получить все черновые метаданные DTO за исключением внутренних
    /// </summary>
    /// <returns>Черновики метаданных DTO</returns>
    IEnumerable<DataClassMetadata> GetNonInternalDraftDataClasses();

    /// <summary>Получить все опубликованные метаданные функций</summary>
    /// <returns>Опубликованные метаданные функций</returns>
    IEnumerable<FunctionMetadata> GetPublishedFunctions();

    /// <summary>Получить все черновые метаданные функций</summary>
    /// <returns>Черновики метаданные функций</returns>
    IEnumerable<FunctionMetadata> GetDraftFunctions();

    /// <summary>Получить все опубликованные метаданные компонентов</summary>
    /// <returns>Опубликованные метаданные компонентов</returns>
    IEnumerable<ComponentMetadata> GetPublishedComponents();

    /// <summary>Получить все черновые метаданные компонентов</summary>
    /// <returns>Черновики метаданные компонентов</returns>
    IEnumerable<ComponentMetadata> GetDraftComponents();
  }
}
