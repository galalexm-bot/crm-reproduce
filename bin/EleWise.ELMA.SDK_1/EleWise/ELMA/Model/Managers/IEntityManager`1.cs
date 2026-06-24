// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.IEntityManager`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Типизированный интерфейс менеджера сущности</summary>
  /// <typeparam name="T">Тип класса сущности</typeparam>
  [ExtensionPoint(false, ComponentType.Server, ServiceScope.Application)]
  public interface IEntityManager<T> : IEntityManager where T : IEntity
  {
    /// <summary>Создать новую сущность (без записи в БД)</summary>
    /// <returns>Сущность</returns>
    [NotNull]
    T Create();

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Сущность</returns>
    [NotNull]
    T Load(object id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность или null</returns>
    [CanBeNull]
    T LoadOrNull(object id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается новая сущность
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность</returns>
    [NotNull]
    T LoadOrCreate(object id);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается новая сущность
    /// </summary>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность</returns>
    [NotNull]
    T LoadOrCreate(Guid uid);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность</returns>
    [NotNull]
    T Load(Guid uid);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность или null</returns>
    [CanBeNull]
    T LoadOrNull(Guid uid);

    /// <summary>
    /// Проверить возможно ли сохранить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    ActionCheckResult CanSave(T obj);

    /// <summary>Сохранить сущность в БД</summary>
    /// <param name="obj">Сущность</param>
    void Save(T obj);

    /// <summary>
    /// Проверить возможно ли удалить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    ActionCheckResult CanDelete(T obj);

    /// <summary>Удалить сущность в БД</summary>
    /// <param name="obj">Сущность</param>
    void Delete(T obj);

    /// <summary>Обновить сущность</summary>
    /// <param name="obj">Сущность</param>
    void Refresh(T obj);

    /// <summary>Обновить сущность</summary>
    /// <param name="obj">Сущность</param>
    void Refresh(T obj, LockMode mode);

    /// <summary>Сущность не сохранялась в базе</summary>
    /// <param name="obj">Сущность</param>
    bool IsNew(T obj);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>True, если есть</returns>
    bool IsDirty(T obj);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>True, если есть</returns>
    bool IsDirty(T obj, object originalState);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Список идентификаторов свойств</returns>
    Guid[] GetDirtyPropertyUids(T obj);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>Список идентификаторов свойств</returns>
    Guid[] GetDirtyPropertyUids(T obj, object originalState);

    /// <summary>
    /// Получить текущее состояние сущности (для применения в функции GetDirtyPropertyUids)
    /// </summary>
    /// <returns></returns>
    object GetCurrentState(T obj);

    /// <summary>Найти все сущности</summary>
    /// <returns>Список всех сущностей</returns>
    ICollection<T> FindAll();

    /// <summary>Найти все сущности по идентификаторам из массива</summary>
    /// <param name="idArray">Массив идентификаторов</param>
    /// <returns>Список сущностей</returns>
    ICollection<T> FindByIdArray(object[] idArray);

    /// <summary>Найти сущности в соответствии с параметрами выборки</summary>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Список найденных сущностей</returns>
    ICollection<T> Find(FetchOptions fetchOptions);

    /// <summary>
    /// Найти сущности в соответствии с фильтром и параметрами выборки
    /// </summary>
    /// <param name="filter">Фильтр</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Список найденных сущностей</returns>
    ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions);

    /// <summary>Поиск по условию в выражении</summary>
    /// <param name="condition">Условие поиска</param>
    /// <returns>Список сущностей удовлетвояющих условию поиска</returns>
    ICollection<T> Find(Expression<Func<T, bool>> condition);

    /// <summary>Поиск по условию в выражении</summary>
    /// <param name="condition">Условие поиска</param>
    /// <returns>Список сущностей удовлетвояющих условию поиска</returns>
    ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition);

    /// <summary>Поиск по условию в выражении</summary>
    /// <param name="condition">Условие поиска</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Список сущностей удовлетвояющих условию поиска</returns>
    ICollection<T> Find(Expression<Func<T, bool>> condition, FetchOptions fetchOptions);

    /// <summary>Поиск по условию в выражении</summary>
    /// <param name="condition">Условие поиска</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Список сущностей удовлетвояющих условию поиска</returns>
    ICollection<TResult> Find<TResult>(
      Expression<Func<TResult, bool>> condition,
      FetchOptions fetchOptions);

    /// <summary>Поиск по условию в выражении</summary>
    /// <param name="eqlFilter">Условие поиска на языке EQL</param>
    /// <returns>Список сущностей удовлетвояющих условию поиска</returns>
    ICollection<T> Find(string eqlFilter);
  }
}
