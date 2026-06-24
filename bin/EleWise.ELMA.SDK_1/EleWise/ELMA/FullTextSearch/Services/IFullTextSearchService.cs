// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Services.IFullTextSearchService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EleWise.ELMA.FullTextSearch.Services
{
  /// <summary>Интерфейс сервиса полнотекстового поиска</summary>
  public interface IFullTextSearchService
  {
    IFullTextSearchProvider Provider { get; }

    FullTextSearchState GetIndexState();

    void SetOffIndexState();

    void SetReadyIndexState();

    void SetOnIndexState();

    bool IndexingIsWorking();

    /// <summary>Полнотекстовый поиск по строке</summary>
    FullTextSearchResultModel Search(
      Type cardType,
      string searchString,
      int? pageIndex = null,
      int? pageSize = null);

    /// <summary>
    /// Полнотекстовый поиск по строке с передачей дополнительных данных
    /// </summary>
    FullTextSearchResultModel Search(
      Type cardType,
      FullTextSearchResultModel resultModel,
      string searchString,
      int? pageIndex = null,
      int? pageSize = null);

    /// <summary>Индексация объектов по списук их Uid</summary>
    bool IndexEntities(Type cardType, List<Guid> listUid);

    /// <summary>Индексация объектов по спискe их Id</summary>
    bool IndexEntities(Type cardType, List<long> listId);

    /// <summary>Полная переиндексация всех типов</summary>
    bool ReIndexAllEntities(IIndexQueue item, string dirtyValues, out bool breakBecauseIsIndexAll);

    /// <summary>Полная переиндексация типа</summary>
    bool ReIndexAllEntitiesByType(Type cardType, Guid? typeUidFilter = null);

    /// <summary>
    /// Реиндексация объектов по их представлению в виде списка значений свойств
    /// </summary>
    bool ReIndexByPropertyList(
      Type cardType,
      List<IEnumerable<KeyValuePair<string, object>>> listProperty);

    void StartIndexing();

    void StopIndexing();

    void StopIndexing(string info);

    void StartReIndexing();

    void StopIndexingType(Type cardType);

    string GetStopIndexingInfo();

    FullTextSearchResultModel Find(
      Type cardType,
      FullTextSearchResultModel resultModel,
      IEntityFilter filter,
      SerializableFilter filterFields,
      List<Guid> selectedColumns,
      int firstResult,
      int maxResult,
      string sortExpression,
      ListSortDirection sortDirection);

    /// <summary>Поиск Find</summary>
    /// <param name="cardType">Тип карточки</param>
    /// <param name="listReturnFields">Список возвращаемых полей</param>
    /// <param name="listFilterFields">Список полей для фильтрации</param>
    /// <param name="firstResult">Первая запись</param>
    /// <param name="maxResult">Максимальный результат</param>
    /// <returns>Возвращаемый результат</returns>
    FullTextSearchResultModel Find(
      Type cardType,
      List<string> listReturnFields,
      FilterList listFilterFields,
      SortList listSortFields,
      int firstResult,
      int maxResult);

    FullTextSearchResultModel Count(
      Type cardType,
      FullTextSearchResultModel resultModel,
      IEntityFilter filter,
      SerializableFilter filterFields);
  }
}
