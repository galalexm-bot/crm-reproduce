// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityHolder`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Сериализуемое хранилище сущности</summary>
  /// <typeparam name="TId">Тип идентификатора сущности</typeparam>
  /// <typeparam name="TEntity">Тип сущности</typeparam>
  [Serializable]
  public class EntityHolder<TId, TEntity> where TEntity : class, IEntity<TId>
  {
    private TId id;
    private bool isNull;
    private static object fqQCmXhZcSLJKZrkkDVO;

    /// <summary>Создать хранилище</summary>
    /// <param name="id">Идентификатор сущности</param>
    public EntityHolder(TId id)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.id = id;
    }

    /// <summary>Создать хранилище</summary>
    /// <param name="entity">Сущность</param>
    public EntityHolder(TEntity entity)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.SetEntity(entity);
    }

    /// <summary>Идентификатор сущности</summary>
    public TId Id
    {
      get => this.id;
      set => this.id = value;
    }

    /// <summary>Сущность</summary>
    public virtual TEntity Object
    {
      get
      {
        if (this.isNull)
          return default (TEntity);
        string name = this.CacheEnabled ? this.GetCacheKey(this.Id) : string.Empty;
        TEntity entity1;
        if (this.CacheEnabled && ContextVars.TryGetValue<TEntity>(name, out entity1))
          return entity1;
        TEntity entity2 = this.EntityManager.Load((object) this.id) as TEntity;
        if (this.CacheEnabled)
          ContextVars.Set<TEntity>(name, entity2);
        return entity2;
      }
      set => this.SetEntity(value);
    }

    /// <summary>Менеджер сущности</summary>
    protected IEntityManager EntityManager => ModelHelper.GetEntityManager(typeof (TEntity));

    /// <summary>Использовать ли кэш (по умолчанию true)</summary>
    protected virtual bool CacheEnabled => true;

    private string GetCacheKey(TId id) => typeof (TEntity).FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712478067) + (object) this.Id;

    private void SetEntity(TEntity value)
    {
      if ((object) value == null)
      {
        this.isNull = true;
      }
      else
      {
        this.isNull = false;
        this.id = value.Id;
        if ((object) value == null || !this.CacheEnabled)
          return;
        ContextVars.Set<TEntity>(this.GetCacheKey(value.Id), value);
      }
    }

    internal static bool G2j4f3hZz9nYKc3GDhRJ() => EntityHolder<TId, TEntity>.fqQCmXhZcSLJKZrkkDVO == null;

    internal static object bFUObkhuFKyF4hv8GtNX() => EntityHolder<TId, TEntity>.fqQCmXhZcSLJKZrkkDVO;
  }
}
