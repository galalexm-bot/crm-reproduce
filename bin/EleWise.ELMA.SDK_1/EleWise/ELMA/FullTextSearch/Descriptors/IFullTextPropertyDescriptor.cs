// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.IFullTextPropertyDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  /// <summary>
  /// Интерфейс классов описывающих правила поиска и индексирования для типов
  /// </summary>
  public interface IFullTextPropertyDescriptor
  {
    /// <summary>Поддерживается индексирование</summary>
    bool IsSupportedIndexing { get; }

    /// <summary>Поддерживается поиск в индексе</summary>
    bool IsSupportedSearchInIndex { get; }

    /// <summary>Поддерживается полнотекстовый поиск в индексе</summary>
    bool IsSupportedFullTextSearchInIndex { get; }

    /// <summary>
    /// Получение пары название списка поле индекса / значение в индексе при индексировании (эти данные заносятся в индекс)
    /// </summary>
    FieldIndexList GetIndexField(object value, IPropertyMetadata propMd, bool reindex);

    /// <summary>
    /// Получение искомого значение для свойства при быстром поиске в индексе
    /// </summary>
    FieldListItem GetSearchField(object value, IPropertyMetadata propMd);

    /// <summary>Получение списков для поиске (фильтрации) в индексе</summary>
    FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter);

    /// <summary>Получение названия возвращаемого из индекса поля</summary>
    List<string> GetReturnField(IPropertyMetadata propMd);

    /// <summary>
    /// Получение названия поля для сортировке при поиске в индексе
    /// </summary>
    SortListItem GetSortField(IPropertyMetadata propMd);

    /// <summary>Восстановление данных полученых из индекса</summary>
    void SetIndexField(object obj, object value, IPropertyMetadata propMd);

    /// <summary>
    /// Восстановление данных которые искали в индексе, но не нашли
    /// </summary>
    void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName);
  }
}
