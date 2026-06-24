// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.IMetadataService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Интерфейс службы управления метаданными</summary>
  public interface IMetadataService
  {
    /// <summary>Получить объект метаданных по Uid-у</summary>
    /// <param name="metadataUid">Uid объекта метаданных</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Метаданные</returns>
    IMetadata GetMetadata(Guid metadataUid, bool loadImplementation = true);

    /// <summary>Получить список метаданных</summary>
    /// <returns>Список метаданных</returns>
    IEnumerable<IMetadata> GetMetadataList();

    /// <summary>Являются ли метаданные системными</summary>
    /// <param name="typeUid">Идентификатор метаданных</param>
    bool IsSystem(Guid typeUid);

    /// <summary>Являются ли метаданные созданными в конфигурации</summary>
    /// <param name="typeUid">Идентификатор метаданных</param>
    bool IsConfig(Guid typeUid);

    /// <summary>Получить описание доступных типов данных</summary>
    /// <returns>Список типов данных</returns>
    IEnumerable<ITypeDescriptor> GetTypeDescriptors();

    /// <summary>
    /// Получить описание типа данных по его уникальному идентификатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Описание типа данных</returns>
    ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid);

    /// <summary>
    /// Получить описание типа данных по его уникальному идентификатору. Если не нашли - null
    /// </summary>
    /// <returns>Описание типа данных</returns>
    ITypeDescriptor GetTypeDescriptor(Type runtimeType);

    /// <summary>
    /// Получить описание типов данных, которые можно использовать для первичного ключа
    /// </summary>
    /// <returns>Список типов данных</returns>
    IEnumerable<ITypeDescriptor> GetIdTypeDescriptors();

    /// <summary>
    /// Получить описание типа данных, который можно использовать для первичного ключа, по его уникальному идентфикатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <returns>Описание типа данных</returns>
    ITypeDescriptor GetIdTypeDescriptor(Guid typeUid);
  }
}
