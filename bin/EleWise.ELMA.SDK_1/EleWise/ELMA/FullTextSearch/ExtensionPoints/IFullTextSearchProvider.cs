// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.ExtensionPoints.IFullTextSearchProvider
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
  /// <summary>Точка расширения провайдера полнотекстового поиска</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IFullTextSearchProvider
  {
    /// <summary>Uid провайдера полнотекстового поиска</summary>
    Guid ProviderUid { get; }

    string ProviderName { get; }

    /// <summary>Проверка статуса сервера для предполагаемых настроек</summary>
    bool CheckServerStatus(ICollection<string> checkSettings, out string info);

    /// <summary>Проверка статуса сервера для действующих настроек</summary>
    bool GetServerStatus();

    /// <summary>Поиск по строке</summary>
    FullTextSearchResultModel Search(
      Type cardType,
      string searchString,
      List<string> listForHighlight,
      FilterList listForFilter,
      List<string> listForFields,
      List<string> listForSearchFields,
      int? from = null,
      int? size = null);

    /// <summary>Поиск Find для EntityManager'а</summary>
    /// <param name="cardType">тип карточки</param>
    /// <param name="listFastSearch">список полей для быстрого поиска</param>
    /// <param name="listSearchFields">список полей для поиска</param>
    /// <param name="listFilterField">список полей для фильтрации</param>
    /// <param name="listReturnFields">список возвращаемых полей</param>
    /// <param name="sortFields">поля для сортировки</param>
    /// <param name="from">начинать поиск с элемента from</param>
    /// <param name="size">выбирать size элементов</param>
    FullTextSearchResultModel Find(
      Type cardType,
      FastSearchList listFastSearch,
      FieldList listSearchFields,
      FilterList listFilterField,
      List<string> listReturnFields,
      SortList sortFields,
      int? from,
      int? size);

    /// <summary>Поиск Find</summary>
    /// <param name="cardType">Тип карточки</param>
    /// <param name="listReturnFields">Список возвращаемых полей</param>
    /// <param name="listFilterFields">Список полей для фильтрации</param>
    /// <param name="size">Размер возвращаемого результата</param>
    /// <returns>Возвращаемый результат</returns>
    FullTextSearchResultModel Find(
      Type cardType,
      List<string> listReturnFields,
      FilterList listFilterFields,
      SortList listSortFields,
      int size);

    /// <summary>Поиск Count для EntityManager'а</summary>
    /// <param name="cardType">тип карточки</param>
    /// <param name="listFastSearch">списое полей для быстрого поиска</param>
    /// <param name="listSearchFields">список полей для поиска</param>
    /// <param name="listFilterField">список полей для фильтрации</param>
    FullTextSearchResultModel Count(
      Type cardType,
      FastSearchList listFastSearch,
      FieldList listSearchFields,
      FilterList listFilterField);

    /// <summary>Индексирование группы объектов</summary>
    /// <param name="type">Тип карточки</param>
    /// <param name="objects">Обертки объектов индексации</param>
    bool Index(
      Type type,
      IEnumerable<IFullTextSearchObjectContainer> objects);

    /// <summary>Реиндексирование группы объектов</summary>
    bool ReIndex(Type cardType, List<ToReindex> listToReIndex);

    /// <summary>Удаление индекса для типа карточки</summary>
    /// <param name="cardType"></param>
    /// <returns></returns>
    bool DeleteAllFromType(Type cardType);

    /// <summary>Удаление индекса</summary>
    /// <returns></returns>
    bool DeleteIndex();
  }
}
