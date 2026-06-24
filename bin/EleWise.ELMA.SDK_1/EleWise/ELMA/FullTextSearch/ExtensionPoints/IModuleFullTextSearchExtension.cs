// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.ExtensionPoints.IModuleFullTextSearchExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Runtime.Settings;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для реализации настроек и обработки полнотекстового поиска по модулям
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IModuleFullTextSearchExtension
  {
    /// <summary>Получить типы карточек поддерживаемых расширением</summary>
    List<KeyValuePair<Type, Guid>> GetSupportedCardTypes(bool checkSettings = true);

    /// <summary>Получить тип карточки поддерживаемой расширением</summary>
    Type GetSupportedCardType(Guid cardUid);

    /// <summary>Получить Uid типа карточки поддерживаемой расширением</summary>
    Guid? GetSupportedCardType(Type cardType);

    /// <summary>
    /// Получить типы поддерживаемых карточек для типа объекта
    /// </summary>
    Type GetSupportedCardTypeByTypeUid(Guid objectTypeUid);

    /// <summary>Получить типы поддерживаемых карточек для объекта</summary>
    Type GetSupportedCardTypeByObject(object obj);

    /// <summary>Получить мэппинг динамических полей</summary>
    Dictionary<Type, Dictionary<Guid, List<string>>> GetDynamicFieldsMapping();

    /// <summary>
    /// Получить список названий полей для подсветки найденого
    /// </summary>
    List<string> GetHighlightFields(Type cardType);

    /// <summary>Возвращаемые поля</summary>
    List<string> GetFields(Type cardType);

    /// <summary>Поля поиска</summary>
    List<string> GetSearchFields(Type cardType);

    /// <summary>Поля поиска</summary>
    List<string> GetSearchFields(Type cardType, IEntityFilter filter);

    /// <summary>Веса полей поиска</summary>
    Dictionary<string, Weight> GetWeightSearchFields(Type cardType);

    /// <summary>
    /// Получение названий данных из индекса для отображения на клиентской части
    /// </summary>
    Dictionary<string, string> GetReverseMapping(Type cardType);

    /// <summary>Порядок отображения данных из индекса</summary>
    Dictionary<string, long> GetHighlightsOrder(Type cardType);

    /// <summary>Получить данные для фильтрации</summary>
    FilterList GetFilterFields(Type cardType, FullTextSearchResultModel searchModel);

    /// <summary>Получить данные для поиска по кастомным полям</summary>
    FieldList GetCustomSearchFields(Type cardType, FilterProperty filterProperty);

    /// <summary>Получить данные для фильтрации по кастомным полям</summary>
    FilterList GetCustomFilterFields(
      Type cardType,
      FilterProperty filterProperty,
      FullTextSearchResultModel searchModel);

    /// <summary>Получить данные для переопределяемых полей фильтрации</summary>
    FilterList GetAutoFilterFields(
      Type cardType,
      FilterProperty filterProperty,
      FullTextSearchResultModel searchModel);

    /// <summary>
    /// Заполнение новой карточки индекса по индексируемой сущности
    /// </summary>
    /// <param name="cardType">Тип карточки</param>
    /// <param name="obj">Обертка объекта индексации</param>
    /// <param name="entity">Сущность</param>
    void FillObject(Type cardType, IFullTextSearchObjectContainer obj, IEntity entity);

    /// <summary>
    /// Загрузка пачки индексируемых сущностей по списку Uid'ов
    /// </summary>
    List<IEntity> GetEntities(Type cardType, List<Guid> listUid);

    /// <summary>Загрузка пачки индексируемых сущностей по списку Id</summary>
    List<IEntity> GetEntities(Type cardType, List<long> listId);

    /// <summary>
    /// Загрузка пачки индексируемых сущностей по страницам, для новых реализаций достаточно возвращать пустой список
    /// </summary>
    List<IEntity> LoadEntitiesByPage(Type cardType, int page, List<Guid> typeUidFilter = null);

    /// <summary>
    /// Загрузка пачки индексируемых сущностей по страницам, используя фильтрацию по послденему полученному идентификатору
    /// </summary>
    List<IEntity> LoadEntities(Type cardType, long? lastId, List<Guid> typeUidFilter = null);

    /// <summary>Создание заготовки возвращаемой модели по фильтру</summary>
    FullTextSearchResultModel CreateResultModelByFilter(IEntityFilter filter);

    /// <summary>Поле сортировки по умолчанию</summary>
    SortList GetDefaultSortExpression();

    /// <summary>
    /// Преобразование статических свойств объекта в список пригодный для индексации
    /// </summary>
    /// <param name="cardType">Тип карточки</param>
    /// <param name="obj">Обертка объекта индексации</param>
    List<KeyValuePair<string, object>> CreateFromObject(
      Type cardType,
      IFullTextSearchObjectContainer obj);

    /// <summary>
    /// Восстановление искусственного объекта по данным из результата поиска в индексе
    /// </summary>
    void ReconstructEntity(
      Type cardType,
      IFullTextSearchResultItem resultItem,
      IEntity<long> fakeEntity);

    /// <summary>Настройки модуля индексации для карточки</summary>
    IGlobalSettingsModule SettingModule { get; }
  }
}
