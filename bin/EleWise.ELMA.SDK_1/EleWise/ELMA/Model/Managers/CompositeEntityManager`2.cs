// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.CompositeEntityManager`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Менеджер составной сущности</summary>
  /// <typeparam name="T">Тип сущности</typeparam>
  /// <typeparam name="IdT">Тип идентификатора сущности</typeparam>
  public abstract class CompositeEntityManager<T, IdT> : 
    IEntityManager<T, IdT>,
    IEntityManager<T>,
    IEntityManager,
    ICompositeEntityManager
    where T : class, ICompositeEntity<IdT>
  {
    private static object Cle3dkhQ6JOnXvBFj9u4;

    public abstract T Create();

    public virtual T Load(IdT id) => this.LoadOrNull(id) ?? throw new EleWise.ELMA.Exceptions.ObjectNotFoundException(typeof (T).FullName, (object) id);

    public abstract T LoadOrNull(IdT id);

    public abstract T LoadOrCreate(IdT id);

    public abstract T LoadOrCreate(Guid uid);

    public virtual T Load(Guid uid) => this.LoadOrNull(uid) ?? throw new EleWise.ELMA.Exceptions.ObjectNotFoundException(typeof (T).FullName, (object) uid);

    public virtual T LoadOrNull(Guid uid) => throw new NotImplementedException();

    /// <summary>
    /// Проверить возможно ли сохранить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    public virtual ActionCheckResult CanSave(T obj) => ActionCheckResult.True;

    public virtual void Save(T obj)
    {
      foreach (IEntity compositeEntity in obj.GetCompositeEntities())
        this.GetPartialManager(compositeEntity).Save((object) compositeEntity);
    }

    /// <summary>
    /// Проверить возможно ли удалить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    public virtual ActionCheckResult CanDelete(T obj) => ActionCheckResult.True;

    public virtual void Delete(T obj)
    {
      foreach (IEntity compositeEntity in obj.GetCompositeEntities())
        this.GetPartialManager(compositeEntity).Delete((object) compositeEntity);
    }

    public virtual void DeleteAll() => throw new NotImplementedException();

    public virtual void Refresh(T obj)
    {
      foreach (IEntity compositeEntity in obj.GetCompositeEntities())
        this.GetPartialManager(compositeEntity).Refresh((object) compositeEntity);
    }

    public virtual void Refresh(T obj, LockMode mode)
    {
      foreach (IEntity compositeEntity in obj.GetCompositeEntities())
        this.GetPartialManager(compositeEntity).Refresh((object) compositeEntity, mode);
    }

    /// <summary>Сущность не сохранялась в базе</summary>
    /// <param name="obj">Сущность</param>
    public bool IsNew(object obj) => this.IsNew((T) obj);

    /// <summary>Сущность не сохранялась в базе</summary>
    /// <param name="obj">Сущность</param>
    public bool IsNew(T obj) => obj.GetCompositeEntities().Any<IEntity>((Func<IEntity, bool>) (e => e.IsNew()));

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>True, если есть</returns>
    public bool IsDirty(object obj) => this.IsDirty((T) obj);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>True, если есть</returns>
    public bool IsDirty(object obj, object originalState) => this.IsDirty((T) obj, originalState);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Список идентификаторов свойств</returns>
    public Guid[] GetDirtyPropertyUids(object obj) => this.GetDirtyPropertyUids((T) obj);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>Список идентификаторов свойств</returns>
    public Guid[] GetDirtyPropertyUids(object obj, object originalState) => this.GetDirtyPropertyUids((T) obj, originalState);

    /// <summary>
    /// Получить текущее состояние сущности (для применения в функции GetDirtyPropertyUids)
    /// </summary>
    /// <returns></returns>
    public virtual object GetCurrentState(object obj) => this.GetCurrentState((T) obj);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>True, если есть</returns>
    public virtual bool IsDirty(T obj) => this.IsDirty(obj, (object) null);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>True, если есть</returns>
    public virtual bool IsDirty(T obj, object originalState)
    {
      Dictionary<string, object> originalStateDict = originalState as Dictionary<string, object>;
      return obj.GetCompositeEntities().Any<IEntity>((Func<IEntity, bool>) (e =>
      {
        int num1 = 4;
        object originalState1;
        while (true)
        {
          int num2 = num1;
          string key;
          while (true)
          {
            switch (num2)
            {
              case 1:
                key = e.GetType().GetTypeWithoutProxy().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710651424) + e.GetId();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                continue;
              case 2:
              case 5:
                goto label_3;
              case 3:
                if (originalStateDict == null)
                {
                  num2 = 2;
                  continue;
                }
                goto case 1;
              case 4:
                goto label_6;
              default:
                originalStateDict.TryGetValue(key, out originalState1);
                num2 = 5;
                continue;
            }
          }
label_6:
          originalState1 = (object) null;
          num1 = 3;
        }
label_3:
        return EntityHelper.GetEntityManager(e.GetType().GetTypeWithoutProxy()).IsDirty((object) e, originalState1);
      }));
    }

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Список идентификаторов свойств</returns>
    public virtual Guid[] GetDirtyPropertyUids(T obj) => this.GetDirtyPropertyUids(obj, (object) null);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>Список идентификаторов свойств</returns>
    public virtual Guid[] GetDirtyPropertyUids(T obj, object originalState)
    {
      List<Guid> guidList = new List<Guid>();
      Dictionary<string, object> dictionary = originalState as Dictionary<string, object>;
      foreach (IEntity compositeEntity in obj.GetCompositeEntities())
      {
        object originalState1 = (object) null;
        if (dictionary != null)
        {
          string key = compositeEntity.GetType().GetTypeWithoutProxy().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882317752) + compositeEntity.GetId();
          dictionary.TryGetValue(key, out originalState1);
        }
        Guid[] dirtyPropertyUids = EntityHelper.GetEntityManager(compositeEntity.GetType().GetTypeWithoutProxy()).GetDirtyPropertyUids((object) compositeEntity, originalState1);
        if (dirtyPropertyUids != null)
          guidList.AddRange((IEnumerable<Guid>) dirtyPropertyUids);
      }
      return guidList.ToArray();
    }

    /// <summary>
    /// Получить текущее состояние сущности (для применения в функции GetDirtyPropertyUids)
    /// </summary>
    /// <returns></returns>
    public virtual object GetCurrentState(T obj)
    {
      Dictionary<string, object> currentState = new Dictionary<string, object>();
      foreach (IEntity compositeEntity in obj.GetCompositeEntities())
      {
        string key = compositeEntity.GetType().GetTypeWithoutProxy().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541662045) + compositeEntity.GetId();
        IEntityManager entityManager = EntityHelper.GetEntityManager(compositeEntity.GetType().GetTypeWithoutProxy());
        currentState[key] = entityManager.GetCurrentState((object) compositeEntity);
      }
      return (object) currentState;
    }

    public virtual ICollection<T> FindAll() => throw new NotImplementedException();

    public virtual ICollection<T> FindByIdArray(IdT[] idArray) => throw new NotImplementedException();

    public virtual ICollection<T> Find(FetchOptions fetchOptions) => throw new NotImplementedException();

    public virtual ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions) => throw new NotImplementedException();

    public virtual IEnumerable<TItem> Find<TItem>(IEntityFilter filter, FetchOptions fetchOptions) => throw new NotImplementedException();

    public ICollection<T> Find(Expression<Func<T, bool>> condition) => throw new NotImplementedException();

    public ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition) => throw new NotImplementedException();

    public ICollection<T> Find(Expression<Func<T, bool>> condition, FetchOptions fetchOptions) => throw new NotImplementedException();

    public ICollection<TResult> Find<TResult>(
      Expression<Func<TResult, bool>> condition,
      FetchOptions fetchOptions)
    {
      throw new NotImplementedException();
    }

    public ICollection<T> Find(string eqlFilter) => throw new NotImplementedException();

    public virtual void Delete(string query) => throw new NotImplementedException();

    public virtual long Count() => throw new NotImplementedException();

    public virtual long Count(IEntityFilter filter) => throw new NotImplementedException();

    public virtual void CheckFilter(IEntityFilter filter) => throw new NotImplementedException();

    public virtual ICollection<PT> Projection<PT>(string propertyName) => throw new NotImplementedException();

    public ExportRuleList ExportRules() => (ExportRuleList) (null ?? throw new NotImplementedException());

    public virtual bool ExistPropertiesForFastSearch(IEntityMetadata metadata, IEntityFilter filter = null) => true;

    T IEntityManager<T>.Load(object id) => this.Load((IdT) id);

    T IEntityManager<T>.LoadOrNull(object id) => this.LoadOrNull((IdT) id);

    T IEntityManager<T>.LoadOrCreate(object id) => this.LoadOrCreate((IdT) id);

    ICollection<T> IEntityManager<T>.FindByIdArray(object[] idArray) => this.FindByIdArray(idArray.Cast<IdT>().ToArray<IdT>());

    object IEntityManager.Create() => (object) this.Create();

    object IEntityManager.Load(object id) => (object) this.Load((IdT) id);

    object IEntityManager.LoadOrCreate(object id) => (object) this.LoadOrCreate((IdT) id);

    object IEntityManager.LoadOrCreate(Guid uid) => (object) this.LoadOrCreate(uid);

    object IEntityManager.LoadOrNull(object id) => (object) this.LoadOrNull((IdT) id);

    object IEntityManager.Load(Guid uid) => (object) this.Load(uid);

    object IEntityManager.LoadOrNull(Guid uid) => (object) this.LoadOrNull(uid);

    ActionCheckResult IEntityManager.CanSave(object obj) => this.CanSave((T) obj);

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
            this.Save((T) obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    ActionCheckResult IEntityManager.CanDelete(object obj) => this.CanDelete((T) obj);

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
            this.Delete((T) obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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
            this.Refresh((T) obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
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
            this.Refresh((T) obj, mode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    IEnumerable IEntityManager.FindAll() => (IEnumerable) this.FindAll();

    IEnumerable IEntityManager.FindByIdArray(object[] idArray) => (IEnumerable) this.FindByIdArray(idArray.Cast<IdT>().ToArray<IdT>());

    IEnumerable IEntityManager.Find(FetchOptions fetchOptions) => (IEnumerable) this.Find(fetchOptions);

    IEnumerable IEntityManager.Find(IEntityFilter filter, FetchOptions fetchOptions) => (IEnumerable) this.Find(filter, fetchOptions);

    public void SetupFilter(ICriteria criteria, IEntityFilter filter) => throw new NotImplementedException();

    public DetachedCriteria CreateDetachedCriteria(
      FetchOptions fetchOptions,
      Type type,
      string alias = null,
      IEntityFilter filter = null)
    {
      throw new NotImplementedException();
    }

    public void FilterDetachedCriteria(
      DetachedCriteria detachedCriteria,
      FetchOptions fetchOptions,
      Type type,
      IEntityFilter filter = null)
    {
      throw new NotImplementedException();
    }

    public virtual SecurityException CreateSecurityException(string text, object id) => new SecurityException(text);

    /// <summary>Получить менеджер для указанного типа сущности</summary>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Менеджер сущности</returns>
    public virtual IEntityManager GetPartialManager(Type entityType) => ModelHelper.GetEntityManager(entityType);

    /// <summary>Получить менеджер для указанной сущности</summary>
    /// <param name="entity">Сущность</param>
    /// <returns>Менеджер сущности</returns>
    protected IEntityManager GetPartialManager(IEntity entity)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) entity, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317752716));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return ModelHelper.GetEntityManager(entity.GetType().GetTypeWithoutProxy());
    }

    protected CompositeEntityManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool MwRLwlhQHwjFio5BwY4y() => CompositeEntityManager<T, IdT>.Cle3dkhQ6JOnXvBFj9u4 == null;

    internal static object a8i9AwhQA4LGnV4v55bJ() => CompositeEntityManager<T, IdT>.Cle3dkhQ6JOnXvBFj9u4;
  }
}
