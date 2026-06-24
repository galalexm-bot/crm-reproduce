// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.IEntityManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Нетипизированный интерфейс менеджера сущности</summary>
  [ExtensionPoint(false, ComponentType.Server, ServiceScope.Application)]
  public interface IEntityManager
  {
    /// <summary>Создать новую сущность (без записи в БД)</summary>
    /// <returns>Сущность</returns>
    object Create();

    /// <summary>
    /// Проверить, является ли сущность новой (не сохраненной в БД)
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>True, если новая</returns>
    bool IsNew(object obj);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>True, если есть</returns>
    bool IsDirty(object obj);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>True, если есть</returns>
    bool IsDirty(object obj, object originalState);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Список идентификаторов свойств</returns>
    Guid[] GetDirtyPropertyUids(object obj);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>Список идентификаторов свойств</returns>
    Guid[] GetDirtyPropertyUids(object obj, object originalState);

    /// <summary>
    /// Получить текущее состояние сущности (для применения в функции GetDirtyPropertyUids)
    /// </summary>
    /// <returns></returns>
    object GetCurrentState(object obj);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Сущность</returns>
    object Load(object id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность или null</returns>
    object LoadOrNull(object id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается новая сущность
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность</returns>
    object LoadOrCreate(object id);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается новая сущность
    /// </summary>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность</returns>
    object LoadOrCreate(Guid uid);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность</returns>
    object Load(Guid uid);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность или null</returns>
    object LoadOrNull(Guid uid);

    /// <summary>
    /// Проверить возможно ли сохранить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    ActionCheckResult CanSave(object obj);

    /// <summary>Сохранить сущность в БД</summary>
    /// <param name="obj">Сущность</param>
    void Save(object obj);

    /// <summary>
    /// Проверить возможно ли удалить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    ActionCheckResult CanDelete(object obj);

    /// <summary>Удалить сущность в БД</summary>
    /// <param name="obj">Сущность</param>
    void Delete(object obj);

    /// <summary>
    /// Удалить сущность в БД по запросу.
    /// ВНИМАНИЕ!!! Не использовать для больших массивов, т.к. данные сначала загружаются в память из БД и только потом удаляются.
    /// </summary>
    /// <param name="query">Запрос</param>
    void Delete(string query);

    /// <summary>Удалить все сущности из БД</summary>
    /// <remarks>Метод выполняется долго, т.к. загружает все записи в память и формирует большую транзакцию для удаления.
    /// При необходимости нужно написать свою реализацию либо одним запросом, либо разбивать на удаление небольшими пачками в отдельных транзакциях.</remarks>
    [Obsolete("При необходимости используйте собственную реализацию метода, текущая работает долго и может превысить допустимое время выполнения при большом количестве записей.")]
    void DeleteAll();

    /// <summary>Обновить (перечитать) сущность из БД</summary>
    /// <param name="obj">Сущность</param>
    void Refresh(object obj);

    /// <summary>Обновить (перечитать) сущность из БД c блокировками</summary>
    /// <param name="obj">Сущность</param>
    void Refresh(object obj, LockMode mode);

    /// <summary>Найти все сущности</summary>
    /// <returns>Список всех сущностей</returns>
    IEnumerable FindAll();

    /// <summary>Найти все сущности по идентификаторам из массива</summary>
    /// <param name="idArray">Массив идентификаторов</param>
    /// <returns>Список сущностей</returns>
    IEnumerable FindByIdArray(object[] idArray);

    /// <summary>Найти сущности в соответствии с параметрами выборки</summary>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Список найденных сущностей</returns>
    IEnumerable Find(FetchOptions fetchOptions);

    /// <summary>
    /// Найти сущности в соответствии с фильтром и параметрами выборки
    /// </summary>
    /// <param name="filter">Фильтр</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Список найденных сущностей</returns>
    IEnumerable Find(IEntityFilter filter, FetchOptions fetchOptions);

    /// <summary>
    /// Найти сущности в соответствии с фильтром и параметрами выборки
    /// </summary>
    /// <param name="filter">Фильтр</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <typeparam name="T">Тип сущности</typeparam>
    /// <returns>Список найденных сущностей</returns>
    IEnumerable<T> Find<T>(IEntityFilter filter, FetchOptions fetchOptions);

    /// <summary>Возвращает количество всех сущностей</summary>
    /// <returns>Количество всех сущностей</returns>
    long Count();

    /// <summary>Возвращает количество сущностей по фильтру</summary>
    /// <param name="filter">Фильтр</param>
    /// <returns>Количество сущностей по фильтру</returns>
    long Count(IEntityFilter filter);

    /// <summary>
    /// Проверяет правильность фильтра (основная проверка для EQL), в противном случае исключение
    /// </summary>
    /// <param name="filter">Фильт</param>
    void CheckFilter(IEntityFilter filter);

    /// <summary>Получить проекцию значений свойства</summary>
    /// <typeparam name="PT">Тип свойства</typeparam>
    /// <param name="propertyName">Имя свойства</param>
    /// <returns>Список выбранных значений</returns>
    ICollection<PT> Projection<PT>(string propertyName);

    /// <summary>Установить фильтр в NHibernate критерию</summary>
    /// <param name="criteria"></param>
    /// <param name="filter"></param>
    void SetupFilter(ICriteria criteria, IEntityFilter filter);

    /// <summary>Создать detached-критерию</summary>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="type">Тип, для которого производится выборка</param>
    /// <param name="alias">Псевдоним</param>
    /// <param name="filter"></param>
    /// <returns>Критерий</returns>
    DetachedCriteria CreateDetachedCriteria(
      FetchOptions fetchOptions,
      Type type,
      string alias = null,
      IEntityFilter filter = null);

    /// <summary>Заполнить фильтрацию в detached-критерии</summary>
    /// <param name="detachedCriteria">detached-критерия</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="type">Тип, для которого производится выборка</param>
    /// <param name="filter"></param>
    void FilterDetachedCriteria(
      DetachedCriteria detachedCriteria,
      FetchOptions fetchOptions,
      Type type,
      IEntityFilter filter = null);

    /// <summary>Генерировать исключение безопасности</summary>
    /// <param name="text"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    SecurityException CreateSecurityException(string text, object id);

    /// <summary>Правила экспорта для свойств сущности</summary>
    /// <returns></returns>
    ExportRuleList ExportRules();

    /// <summary>Есть ли поля учавствующие в быстром поиске</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="filter">Фильтр</param>
    /// <returns>true если есть поля учавствующие в быстром поиске</returns>
    bool ExistPropertiesForFastSearch(IEntityMetadata metadata, IEntityFilter filter = null);
  }
}
