// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Services.IFullTextTypeMappingService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Model;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.Services
{
  /// <summary>
  /// Интерфейс сервиса управления типами полнотекстового поиска
  /// </summary>
  public interface IFullTextTypeMappingService
  {
    /// <summary>Создание карты соответствий</summary>
    void CreateMapping();

    /// <summary>
    /// Получение списка названий важных статических свойств для типа сущности
    /// </summary>
    Dictionary<Guid, List<string>> GetImportantProperties(Guid objectTypeUid);

    /// <summary>
    /// Получение списка названий свойств влияющих на отображение в таблице для типа сущности
    /// </summary>
    Dictionary<Guid, List<string>> GetVisualDataProperties(Guid objectTypeUid);

    /// <summary>
    /// Получение списка названий важных динамических свойств для типа сущности
    /// </summary>
    Dictionary<Guid, List<string>> GetImportantDynamicProperties(Guid objectTypeUid);

    /// <summary>
    /// Выполнение действий при создании для точек обработки данных
    /// </summary>
    List<KeyValuePair<string, object>> OnInsertProcessing(Guid objectTypeUid, object obj);

    /// <summary>
    /// Выполнение действий при удалении для точек обработки данных
    /// </summary>
    List<KeyValuePair<string, object>> OnDeleteProcessing(Guid objectTypeUid, object obj);

    bool IsSupported(Guid objectTypeUid);

    List<QueueToIndex> GetQueueToIndex(
      List<KeyValuePair<string, object>> item,
      long id,
      Guid objectTypeUid);
  }
}
