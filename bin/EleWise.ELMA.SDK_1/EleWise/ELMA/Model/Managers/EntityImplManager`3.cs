// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EntityImplManager`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
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
  /// <summary>Менеджер сущности-реализации интерфейса</summary>
  /// <typeparam name="T">Тип сущности реализации</typeparam>
  /// <typeparam name="TIntf">Тип интерфейса</typeparam>
  /// <typeparam name="IdT">Тип идентификатора</typeparam>
  public class EntityImplManager<T, TIntf, IdT> : 
    IEntityManager<T, IdT>,
    IEntityManager<T>,
    IEntityManager
    where T : TIntf
    where TIntf : IEntity<IdT>
  {
    private IEntityManager<TIntf, IdT> manager;
    private static object cbLsBLhQq4ccC6agKptk;

    /// <summary>Создать новую сущность (без записи в БД)</summary>
    /// <returns>Сущность</returns>
    [PublicApiMember]
    public T Create() => (T) (object) this.Manager.Create();

    /// <summary>
    /// Проверить, является ли объект новым (не сохранен в БД)
    /// </summary>
    /// <param name="obj">Объект системы</param>
    /// <returns><c>true</c>, если новый</returns>
    [PublicApiMember]
    public bool IsNew(T obj) => this.Manager.IsNew((TIntf) obj);

    /// <summary>Проверить, есть ли несохраненные изменения в объекте</summary>
    /// <param name="obj">Объект системы</param>
    /// <returns><c>true</c>, если есть изменения</returns>
    [PublicApiMember]
    public bool IsDirty(T obj) => this.Manager.IsDirty((TIntf) obj);

    /// <summary>Проверить, есть ли несохраненные изменения в объекте</summary>
    /// <param name="obj">Объект системы</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns><c>true</c>, если есть изменения</returns>
    public bool IsDirty(T obj, object originalState) => this.Manager.IsDirty((TIntf) obj, originalState);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Объект системы</param>
    /// <returns>Список идентификаторов свойств</returns>
    public Guid[] GetDirtyPropertyUids(T obj) => this.Manager.GetDirtyPropertyUids((TIntf) obj);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Объект системы</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>Список идентификаторов свойств</returns>
    public Guid[] GetDirtyPropertyUids(T obj, object originalState) => this.Manager.GetDirtyPropertyUids((TIntf) obj, originalState);

    /// <summary>
    /// Получить текущее состояние сущности (для применения в функции GetDirtyPropertyUids)
    /// </summary>
    /// <returns></returns>
    public object GetCurrentState(T obj) => this.Manager.GetCurrentState((TIntf) obj);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="id">Идентификатор</param>
    /// <returns>Объект системы</returns>
    [PublicApiMember]
    public T Load(IdT id) => (T) (object) this.Manager.Load(id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="id">Идентификатор</param>
    /// <returns>Объект системы или null</returns>
    [PublicApiMember]
    public T LoadOrNull(IdT id) => (T) (object) this.Manager.LoadOrNull(id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найден - возвращается новый объект
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="id">Идентификатор объекта</param>
    /// <returns>Сущность</returns>
    [PublicApiMember]
    public T LoadOrCreate(IdT id) => (T) (object) this.Manager.LoadOrCreate(id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найден - возвращается новый объект
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="uid">Уникальный идентификатор объекта системы</param>
    /// <returns>Сущность</returns>
    [PublicApiMember]
    public T LoadOrCreate(Guid uid) => (T) (object) this.Manager.LoadOrCreate(uid);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="uid">Уникальный идентификатор объекта</param>
    /// <returns>Объект системы</returns>
    [PublicApiMember]
    public T Load(Guid uid) => (T) (object) this.Manager.Load(uid);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="uid">Уникальный идентификатор объекта системы</param>
    /// <returns>Объект системы или null</returns>
    [PublicApiMember]
    public T LoadOrNull(Guid uid) => (T) (object) this.Manager.LoadOrNull(uid);

    /// <summary>
    /// Проверить возможно ли сохранить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    public virtual ActionCheckResult CanSave(T obj) => ActionCheckResult.True;

    /// <summary>Сохранить объект в БД</summary>
    /// <param name="obj">Объект системы</param>
    [PublicApiMember]
    public void Save(T obj) => this.Manager.Save((TIntf) obj);

    /// <summary>
    /// Проверить возможно ли удалить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    public virtual ActionCheckResult CanDelete(T obj) => ActionCheckResult.True;

    /// <summary>Удалить объект</summary>
    /// <param name="obj">Объект системы</param>
    [PublicApiMember]
    public void Delete(T obj) => this.Manager.Delete((TIntf) obj);

    public void DeleteAll()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.DeleteAll();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Обновить (перечитать) объект из БД</summary>
    /// <param name="obj">Объект системы</param>
    [PublicApiMember]
    public void Refresh(T obj) => this.Manager.Refresh((TIntf) obj);

    /// <summary>Обновить (перечитать) сущность из БД с блокировками</summary>
    /// <param name="obj">Объект системы</param>
    /// <param name="mode"></param>
    public void Refresh(T obj, LockMode mode) => this.Manager.Refresh((TIntf) obj, mode);

    public ICollection<T> FindAll() => (ICollection<T>) this.Manager.FindAll().Cast<T>().ToList<T>();

    /// <summary>Найти все объекты по идентификаторам из массива</summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="idArray">Массив идентификаторов</param>
    /// <returns>Список найденных объектов</returns>
    [PublicApiMember]
    [NotNull]
    public ICollection<T> FindByIdArray(IdT[] idArray) => (ICollection<T>) this.Manager.FindByIdArray(idArray).Cast<T>().ToList<T>();

    /// <summary>Найти объекты в соответствии с параметрами выборки</summary>
    /// <param name="fetchOptions">Параметры выборки (для получения всех результатов из БД используйте <see cref="P:EleWise.ELMA.Model.Common.FetchOptions.All" />)</param>
    /// <returns>Список найденных объектов</returns>
    [PublicApiMember]
    [NotNull]
    public ICollection<T> Find(FetchOptions fetchOptions) => (ICollection<T>) this.Manager.Find(fetchOptions).Cast<T>().ToList<T>();

    /// <summary>
    /// Найти объекты в соответствии с фильтром и параметрами выборки
    /// </summary>
    /// <example>
    /// <code>
    /// //Создаем фильтр (в данном случае для документа)
    /// var docFilter = PublicAPI.Docflow.Document.CreateFilter();
    /// //Указываем критерии выборки
    /// docFilter.Folder = PublicAPI.Docflow.Folder.LoadOrNull(35);
    /// docFilter.Name = "Документ от 10.07.1991";
    /// //Передаем фильтр в функцию поиска
    /// //documents - список документов удовлетворяющих условию выборки, заданной в фильтре
    /// var documents = PublicAPI.Docflow.Document.Find(docFilter, null);
    /// </code>
    /// </example>
    /// <param name="filter">Фильтр объекта</param>
    /// <param name="fetchOptions">Параметры выборки (для получения всех результатов из БД используйте <see cref="P:EleWise.ELMA.Model.Common.FetchOptions.All" />)</param>
    /// <returns>Список найденных объектов</returns>
    [PublicApiMember]
    [NotNull]
    public ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions) => (ICollection<T>) this.Manager.Find(filter, fetchOptions).Cast<T>().ToList<T>();

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <returns>Коллекция объектов</returns>
    public ICollection<T> Find(Expression<Func<T, bool>> condition) => this.Manager.Find<T>(condition);

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <returns>Коллекция объектов</returns>
    public ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition) => this.Manager.Find<TResult>(condition);

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Коллекция объектов</returns>
    public ICollection<T> Find(Expression<Func<T, bool>> condition, FetchOptions fetchOptions) => this.Manager.Find<T>(condition, fetchOptions);

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Коллекция объектов</returns>
    public ICollection<TResult> Find<TResult>(
      Expression<Func<TResult, bool>> condition,
      FetchOptions fetchOptions)
    {
      return this.Manager.Find<TResult>(condition, fetchOptions);
    }

    [NotNull]
    [PublicApiMember]
    public ICollection<T> Find(string eqlFilter) => (ICollection<T>) this.Manager.Find(eqlFilter).Cast<T>().ToList<T>();

    /// <summary>Возвращает количество всех объектов этого типа</summary>
    /// <returns>Количество всех объектов</returns>
    [PublicApiMember]
    public long Count() => this.Manager.Count();

    /// <summary>Получить количество объектов по фильтру</summary>
    /// <param name="filter">Фильтр объекта</param>
    /// <returns>Количество объектов по фильтру</returns>
    [PublicApiMember]
    public long Count(IEntityFilter filter) => this.Manager.Count(filter);

    /// <summary>
    /// Проверяет правильность фильтра (основная проверка для EQL), в противном случае исключение
    /// </summary>
    /// <param name="filter">Фильт</param>
    [PublicApiMember]
    public void CheckFilter(IEntityFilter filter)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.CheckFilter(filter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public ExportRuleList ExportRules() => (ExportRuleList) (null ?? throw new NotImplementedException());

    public bool ExistPropertiesForFastSearch(IEntityMetadata metadata, IEntityFilter filter = null) => this.Manager.ExistPropertiesForFastSearch(metadata, filter);

    T IEntityManager<T>.Load(object id) => (T) (object) this.Manager.Load(id);

    T IEntityManager<T>.LoadOrNull(object id) => (T) (object) this.Manager.LoadOrNull(id);

    T IEntityManager<T>.LoadOrCreate(object id) => (T) (object) this.Manager.LoadOrCreate(id);

    ICollection<T> IEntityManager<T>.FindByIdArray(object[] idArray) => (ICollection<T>) this.Manager.FindByIdArray(idArray).Cast<T>().ToList<T>();

    ActionCheckResult IEntityManager<T>.CanSave(T obj) => this.Manager.CanSave((TIntf) obj);

    ActionCheckResult IEntityManager<T>.CanDelete(T obj) => this.Manager.CanDelete((TIntf) obj);

    object IEntityManager.Create() => this.Manager.Create();

    bool IEntityManager.IsNew(object obj) => this.Manager.IsNew(obj);

    bool IEntityManager.IsDirty(object obj) => this.Manager.IsDirty(obj);

    bool IEntityManager.IsDirty(object obj, object originalState) => this.Manager.IsDirty(obj, originalState);

    Guid[] IEntityManager.GetDirtyPropertyUids(object obj) => this.Manager.GetDirtyPropertyUids(obj);

    Guid[] IEntityManager.GetDirtyPropertyUids(object obj, object originalState) => this.Manager.GetDirtyPropertyUids(obj, originalState);

    object IEntityManager.GetCurrentState(object obj) => this.Manager.GetCurrentState(obj);

    object IEntityManager.Load(object id) => this.Manager.Load(id);

    object IEntityManager.LoadOrNull(object id) => this.Manager.LoadOrNull(id);

    object IEntityManager.LoadOrCreate(object id) => this.Manager.LoadOrCreate(id);

    object IEntityManager.LoadOrCreate(Guid uid) => this.Manager.LoadOrCreate(uid);

    object IEntityManager.Load(Guid uid) => this.Manager.Load(uid);

    object IEntityManager.LoadOrNull(Guid uid) => this.Manager.LoadOrNull(uid);

    ActionCheckResult IEntityManager.CanSave(object obj) => this.Manager.CanSave(obj);

    public void Save(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.Save(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    ActionCheckResult IEntityManager.CanDelete(object obj) => this.Manager.CanDelete(obj);

    public void Delete(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.Delete(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void Delete(string query)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.Delete(query);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void Refresh(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.Refresh(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void Refresh(object obj, LockMode mode)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.Refresh(obj, mode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    IEnumerable IEntityManager.FindAll() => this.Manager.FindAll();

    IEnumerable IEntityManager.FindByIdArray(object[] idArray) => this.Manager.FindByIdArray(idArray);

    IEnumerable IEntityManager.Find(FetchOptions fetchOptions) => this.Manager.Find(fetchOptions);

    IEnumerable IEntityManager.Find(IEntityFilter filter, FetchOptions fetchOptions) => this.Manager.Find(filter, fetchOptions);

    public ICollection<PT> Projection<PT>(string propertyName) => this.Manager.Projection<PT>(propertyName);

    IEnumerable<T1> IEntityManager.Find<T1>(IEntityFilter filter, FetchOptions fetchOptions) => this.Manager.Find<T1>(filter, fetchOptions);

    public void SetupFilter(ICriteria criteria, IEntityFilter filter)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.SetupFilter(criteria, filter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public DetachedCriteria CreateDetachedCriteria(
      FetchOptions fetchOptions,
      Type type,
      string alias = null,
      IEntityFilter filter = null)
    {
      return this.Manager.CreateDetachedCriteria(fetchOptions, type, alias, filter);
    }

    public void FilterDetachedCriteria(
      DetachedCriteria detachedCriteria,
      FetchOptions fetchOptions,
      Type type,
      IEntityFilter filter = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.FilterDetachedCriteria(detachedCriteria, fetchOptions, type, filter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public SecurityException CreateSecurityException(string text, object id) => this.Manager.CreateSecurityException(text, id);

    private IEntityManager<TIntf, IdT> Manager => this.manager ?? (this.manager = Locator.GetServiceNotNull<IEntityManager<TIntf, IdT>>());

    public EntityImplManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool hK1YRvhQKUgceRvy5LMR() => EntityImplManager<T, TIntf, IdT>.cbLsBLhQq4ccC6agKptk == null;

    internal static object Ntpv6uhQXXrcXpbptNGo() => EntityImplManager<T, TIntf, IdT>.cbLsBLhQq4ccC6agKptk;
  }
}
