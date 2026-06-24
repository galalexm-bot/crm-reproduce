// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.ExtensionPoints.IFullTextSearchObjectHandlerExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Model;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints
{
  /// <summary>
  /// Точка расширения обработчика объекта полнотекстового поиска
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IFullTextSearchObjectHandlerExtension
  {
    /// <summary>Uid обработчика объекта</summary>
    Guid Uid { get; }

    /// <summary>Базовый тип карточки, поддерживаемой расширением</summary>
    Type SupportedCard { get; }

    /// <summary>
    /// Список uid'ов базовых сущностей поддерживаемых реализацией точки расширения
    /// </summary>
    List<Guid> SupportedUids { get; }

    /// <summary>
    /// Получение списка названий полей влияющих на статические поля индексированных данные
    /// </summary>
    List<string> GetImportantProperties { get; }

    /// <summary>
    /// Получение списка названий полей влияющих отображение в гридах
    /// </summary>
    List<string> GetVisualDataProperties { get; }

    /// <summary>
    /// Получение данных, готовых к индексированию, из очереди полуфабрикатов
    /// </summary>
    List<QueueToIndex> ProcessingMergedIndexQueue(
      List<KeyValuePair<string, object>> mergedIndexQueueItem,
      long id,
      Guid typeUid);

    /// <summary>Обработка объекта при создании</summary>
    void OnInsertProcessing(Guid typeUid, object obj);

    /// <summary>Обработка объекта при удалении</summary>
    void OnDeleteProcessing(Guid typeUid, object obj);
  }
}
