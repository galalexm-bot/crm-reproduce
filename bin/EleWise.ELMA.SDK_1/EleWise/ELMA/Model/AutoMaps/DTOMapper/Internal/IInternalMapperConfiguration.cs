// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.IInternalMapperConfiguration
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Metadata;
using System;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal
{
  /// <summary>Конфигурация маппера</summary>
  internal interface IInternalMapperConfiguration
  {
    /// <summary>Реальный тип</summary>
    Type SourceType { get; }

    /// <summary>Ссылка на тип структуры обмена данными</summary>
    string TypeRef { get; }

    /// <summary>Создать экземпляр исходного типа</summary>
    /// <param name="dataClass">DTO</param>
    /// <returns>Экземпляр исходного типа</returns>
    object CreateSourceInstance(DataClass dataClass);

    /// <summary>Создать экземпляр структуры обмена данными</summary>
    /// <returns>Экземпляр структуры обмена данными</returns>
    DataClass CreateDestinationInstance();

    /// <summary>
    /// Функция перед маппингом из исходного типа в структуру обмена данными
    /// </summary>
    /// <param name="source">Экземпляр исходного типа</param>
    /// <param name="destination">Экземпляр DTO</param>
    /// <param name="mapperService">Сервис маппинга</param>
    void BeforeMap(object source, DataClass destination, IInternalMapperService mapperService);

    /// <summary>
    /// Функция маппинга из исходного типа в структуру обмена данными
    /// </summary>
    /// <param name="source">Экземпляр исходного типа</param>
    /// <param name="destination">Экземпляр DTO</param>
    /// <param name="mapperService">Сервис маппинга</param>
    void Map(object source, DataClass destination, IInternalMapperService mapperService);

    /// <summary>
    /// Функция маппинга из исходного типа в структуру обмена данными
    /// </summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="source">Экземпляр исходного типа</param>
    /// <param name="destination">Экземпляр DTO</param>
    /// <param name="mapperService">Сервис маппинга</param>
    void Map(
      ClassMetadata metadata,
      object source,
      DataClass destination,
      IInternalMapperService mapperService);

    /// <summary>
    /// Функция перед маппинга из структуры обмена данными в исходный тип
    /// </summary>
    /// <param name="source">Экземпляр структуры обмена данными</param>
    /// <param name="destination">Экземпляр исходного типа</param>
    /// <param name="mapperService">Сервис маппинга</param>
    void BeforeMapReverse(
      DataClass source,
      object destination,
      IInternalMapperService mapperService);

    /// <summary>
    /// Функция маппинга из структуры обмена данными в исходный тип
    /// </summary>
    /// <param name="source">Экземпляр структуры обмена данными</param>
    /// <param name="destination">Экземпляр исходного типа</param>
    /// <param name="mapperService">Сервис маппинга</param>
    void MapReverse(DataClass source, object destination, IInternalMapperService mapperService);

    /// <summary>
    /// Функция маппинга из структуры обмена данными в исходный тип
    /// </summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="source">Экземпляр структуры обмена данными</param>
    /// <param name="destination">Экземпляр исходного типа</param>
    /// <param name="mapperService">Сервис маппинга</param>
    void MapReverse(
      ClassMetadata metadata,
      DataClass source,
      object destination,
      IInternalMapperService mapperService);
  }
}
