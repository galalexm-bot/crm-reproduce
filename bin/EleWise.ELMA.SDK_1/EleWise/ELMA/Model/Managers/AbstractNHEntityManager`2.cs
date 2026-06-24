// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.AbstractNHEntityManager`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Абстрактный класс менеджера сущностей</summary>
  /// <typeparam name="T">Тип сущности</typeparam>
  /// <typeparam name="IdT">Тип идентификатора сущности</typeparam>
  [Component]
  public abstract class AbstractNHEntityManager<T, IdT> : 
    NHManager,
    IEntityManager<T, IdT>,
    IEntityManager<T>,
    IEntityManager
    where T : IEntity<IdT>
  {
    private bool? cacheEnabled;
    private static object somXQphQmwQNRiK6SXdl;

    /// <summary>Получить экземпляр менеджера</summary>
    public static IEntityManager<T, IdT> Instance => Locator.GetServiceNotNull<IEntityManager<T, IdT>>();

    /// <summary>Создать новую сущность (без записи в БД)</summary>
    /// <returns>Сущность</returns>
    [NotNull]
    public abstract T Create();

    /// <summary>
    /// Проверить, является ли сущность новой (не сохраненной в БД)
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>True, если новая</returns>
    public abstract bool IsNew(T obj);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>True, если есть</returns>
    public abstract bool IsDirty(T obj);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>True, если есть</returns>
    public abstract bool IsDirty(T obj, object originalState);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Список идентификаторов свойств</returns>
    public abstract Guid[] GetDirtyPropertyUids(T obj);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>Список идентификаторов свойств</returns>
    public abstract Guid[] GetDirtyPropertyUids(T obj, object originalState);

    /// <summary>
    /// Получить текущее состояние сущности (для применения в функции GetDirtyPropertyUids)
    /// </summary>
    /// <returns></returns>
    public abstract object GetCurrentState(T obj);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Сущность</returns>
    [NotNull]
    public abstract T Load(IdT id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность или null</returns>
    [CanBeNull]
    public abstract T LoadOrNull(IdT id);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность</returns>
    [NotNull]
    public abstract T Load(Guid uid);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность или null</returns>
    [CanBeNull]
    public abstract T LoadOrNull(Guid uid);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается новая сущность
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность</returns>
    [NotNull]
    public abstract T LoadOrCreate(IdT id);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается новая сущность
    /// </summary>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность</returns>
    [NotNull]
    public abstract T LoadOrCreate(Guid uid);

    /// <summary>
    /// Проверить возможно ли сохранить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    public abstract ActionCheckResult CanSave(T obj);

    /// <summary>Сохранить сущность в БД</summary>
    /// <param name="obj">Сущность</param>
    public abstract void Save(T obj);

    /// <summary>
    /// Проверить возможно ли удалить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    public abstract ActionCheckResult CanDelete(T obj);

    /// <summary>Удалить сущность в БД</summary>
    /// <param name="obj">Сущность</param>
    public abstract void Delete(T obj);

    /// <summary>
    /// Удалить сущность в БД по запросу.
    /// ВНИМАНИЕ!!! Не использовать для больших массивов, т.к. данные сначала загружаются в память из БД и только потом удаляются.
    /// </summary>
    /// <param name="query">Запрос</param>
    public abstract void Delete(string query);

    /// <summary>Удалить все сущности из БД</summary>
    public abstract void DeleteAll();

    /// <summary>Обновить (перечитать) сущность из БД</summary>
    /// <param name="obj">Сущность</param>
    public abstract void Refresh(T obj);

    /// <summary>Обновить (перечитать) сущность из БД с блокировками</summary>
    /// <param name="obj"></param>
    /// <param name="mode"></param>
    public abstract void Refresh(T obj, LockMode mode);

    /// <summary>Найти все сущности</summary>
    /// <returns>Список всех сущностей</returns>
    public abstract ICollection<T> FindAll();

    /// <summary>Найти все сущности по идентификаторам из массива</summary>
    /// <param name="idArray">Массив идентификаторов</param>
    /// <returns>Список сущностей</returns>
    public abstract ICollection<T> FindByIdArray(IdT[] idArray);

    public abstract ICollection<T> FindAll(bool cacheble);

    public abstract ICollection<T> Find(FetchOptions fetchOptions);

    public abstract ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions);

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <returns>Коллекция объектов</returns>
    public abstract ICollection<T> Find(Expression<Func<T, bool>> condition);

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <returns>Коллекция объектов</returns>
    public abstract ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition);

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Коллекция объектов</returns>
    public abstract ICollection<T> Find(
      Expression<Func<T, bool>> condition,
      FetchOptions fetchOptions);

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Коллекция объектов</returns>
    public abstract ICollection<TResult> Find<TResult>(
      Expression<Func<TResult, bool>> condition,
      FetchOptions fetchOptions);

    /// <summary>Поиск объектов, удовлетворяющих условию EQL фильтра</summary>
    /// <param name="eqlFilter">Строка EQl фильтра</param>
    /// <returns>Возвращет список объектов</returns>
    public abstract ICollection<T> Find(string eqlFilter);

    /// <summary>Поиск объектов, удовлетворяющих условию EQL фильтра</summary>
    /// <param name="eqlFilter">Строка EQl фильтра</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Возвращет список объектов</returns>
    public abstract ICollection<T> Find(string eqlFilter, FetchOptions fetchOptions);

    /// <summary>Возвращает количество всех сущностей</summary>
    /// <returns>Количество всех сущностей</returns>
    public abstract long Count();

    /// <summary>Возвращает количество сущностей по фильтру</summary>
    /// <param name="filter">Фильтр</param>
    /// <returns>Количество сущностей по фильтру</returns>
    public abstract long Count(IEntityFilter filter);

    /// <summary>
    /// Проверяет правильность фильтра (основная проверка для EQL), в противном случае исключение
    /// </summary>
    /// <param name="filter">Фильт</param>
    public abstract void CheckFilter(IEntityFilter filter);

    /// <summary>Получить проекцию значений свойства</summary>
    /// <typeparam name="TProperty">Тип свойства</typeparam>
    /// <param name="propertyName">Имя свойства</param>
    /// <returns>Список выбранных значений</returns>
    public abstract ICollection<TProperty> Projection<TProperty>(string propertyName);

    /// <summary>Установить фильтр в NHibernate критерию</summary>
    /// <param name="criteria"></param>
    /// <param name="filter"></param>
    public abstract void SetupFilter(ICriteria criteria, IEntityFilter filter);

    /// <summary>Создать detached-критерию</summary>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="type">Тип, для которого производится выборка</param>
    /// <param name="alias">Псевдоним</param>
    /// <param name="filter"></param>
    /// <returns>Критерий</returns>
    public abstract DetachedCriteria CreateDetachedCriteria(
      FetchOptions fetchOptions,
      Type type,
      string alias = null,
      IEntityFilter filter = null);

    /// <summary>Заполнить фильтрацию в detached-критерии</summary>
    /// <param name="detachedCriteria">detached-критерия</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="type">Тип, для которого производится выборка</param>
    /// <param name="filter"></param>
    public abstract void FilterDetachedCriteria(
      DetachedCriteria detachedCriteria,
      FetchOptions fetchOptions,
      Type type,
      IEntityFilter filter = null);

    /// <summary>Генерировать исключение безопасности</summary>
    /// <param name="text"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public virtual SecurityException CreateSecurityException(string text, object id) => new SecurityException(text, InterfaceActivator.TypeOf<T>(), id.ToString());

    /// <summary>Есть ли поля учавствующие в быстром поиске</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="filter">Фильтр</param>
    /// <returns>true если есть поля учавствующие в быстром поиске</returns>
    public virtual bool ExistPropertiesForFastSearch(IEntityMetadata metadata, IEntityFilter filter = null) => true;

    T IEntityManager<T>.Load(object id) => this.Load((IdT) id);

    T IEntityManager<T>.LoadOrNull(object id) => this.LoadOrNull((IdT) id);

    T IEntityManager<T>.LoadOrCreate(object id) => this.LoadOrCreate((IdT) id);

    ICollection<T> IEntityManager<T>.FindByIdArray(object[] idArray) => (ICollection<T>) ((IEntityManager) this).FindByIdArray(idArray).Cast<T>().ToList<T>();

    object IEntityManager.Create() => (object) this.Create();

    object IEntityManager.Load(object id) => (object) this.Load((IdT) Convert.ChangeType(id, typeof (IdT)));

    object IEntityManager.LoadOrNull(object id) => (object) this.LoadOrNull((IdT) Convert.ChangeType(id, typeof (IdT)));

    object IEntityManager.LoadOrCreate(object id) => (object) this.LoadOrCreate((IdT) Convert.ChangeType(id, typeof (IdT)));

    object IEntityManager.LoadOrCreate(Guid uid) => (object) this.LoadOrCreate(uid);

    object IEntityManager.Load(Guid uid) => (object) this.Load(uid);

    object IEntityManager.LoadOrNull(Guid uid) => (object) this.LoadOrNull(uid);

    ActionCheckResult IEntityManager.CanSave(object obj) => this.CanSave((T) obj.CastAsRealType());

    void IEntityManager.Save(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Save((T) obj.CastAsRealType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    ActionCheckResult IEntityManager.CanDelete(object obj) => this.CanDelete((T) obj.CastAsRealType());

    void IEntityManager.Delete(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Delete((T) obj.CastAsRealType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Удалить сущность в БД по запросу.
    /// ВНИМАНИЕ!!! Не использовать для больших массивов, т.к. данные сначала загружаются в память из БД и только потом удаляются.
    /// </summary>
    /// <param name="query">Запрос</param>
    void IEntityManager.Delete(string query)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Delete(query);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    void IEntityManager.Refresh(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Refresh((T) obj.CastAsRealType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    void IEntityManager.Refresh(object obj, LockMode mode)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Refresh((T) obj.CastAsRealType(), mode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    bool IEntityManager.IsNew(object obj) => this.IsNew((T) obj.CastAsRealType());

    bool IEntityManager.IsDirty(object obj) => this.IsDirty((T) obj.CastAsRealType());

    bool IEntityManager.IsDirty(object obj, object originalState) => this.IsDirty((T) obj.CastAsRealType(), originalState);

    Guid[] IEntityManager.GetDirtyPropertyUids(object obj) => this.GetDirtyPropertyUids((T) obj.CastAsRealType());

    Guid[] IEntityManager.GetDirtyPropertyUids(object obj, object originalState) => this.GetDirtyPropertyUids((T) obj.CastAsRealType(), originalState);

    object IEntityManager.GetCurrentState(object obj) => this.GetCurrentState((T) obj.CastAsRealType());

    IEnumerable IEntityManager.FindAll() => (IEnumerable) this.FindAll();

    IEnumerable IEntityManager.FindByIdArray(object[] idArray)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (idArray == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (IEnumerable) this.FindByIdArray(idArray.Cast<IdT>().ToArray<IdT>());
label_3:
      return (IEnumerable) this.FindAll();
    }

    IEnumerable IEntityManager.Find(FetchOptions fetchOptions) => (IEnumerable) this.Find(fetchOptions);

    IEnumerable IEntityManager.Find(IEntityFilter filter, FetchOptions fetchOptions) => (IEnumerable) this.Find(filter, fetchOptions);

    IEnumerable<TItem> IEntityManager.Find<TItem>(IEntityFilter filter, FetchOptions fetchOptions) => (IEnumerable<TItem>) this.Find(filter, fetchOptions);

    /// <summary>Использовать кэширование</summary>
    protected virtual bool CacheEnabled
    {
      get
      {
        int num = 1;
        CacheEntityAttribute attribute;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!this.cacheEnabled.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              this.cacheEnabled = new bool?(attribute != null && attribute.Enabled);
              num = 3;
              continue;
            case 3:
              goto label_2;
            default:
              attribute = AttributeHelper<CacheEntityAttribute>.GetAttribute(typeof (T), true);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return this.cacheEnabled.Value;
      }
    }

    /// <summary>Используется ли "мягкое" удаление</summary>
    protected virtual bool IsSoftDeletable => typeof (T).GetInterface(typeof (ISoftDeletable).FullName) != (Type) null;

    protected T Unproxy(T target) => (T) this.Session.GetSessionImplementation().PersistenceContext.Unproxy((object) target);

    public abstract ExportRuleList ExportRules();

    protected AbstractNHEntityManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool fF2ky3hQyI15SSkYfEIV() => AbstractNHEntityManager<T, IdT>.somXQphQmwQNRiK6SXdl == null;

    internal static object okX52xhQM8EZYujI4MmF() => AbstractNHEntityManager<T, IdT>.somXQphQmwQNRiK6SXdl;
  }
}
