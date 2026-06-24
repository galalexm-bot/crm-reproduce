// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.MemoryEntityManager`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>
  /// Менеджер для временного хранения сущностей в памяти (например для отладки сценариев)
  /// </summary>
  /// <typeparam name="T">Тип сущности</typeparam>
  /// <typeparam name="IdT">тип идентификатора(long, Guid, etc)</typeparam>
  public class MemoryEntityManager<T, IdT> : AbstractNHEntityManager<T, IdT> where T : IEntity<IdT>
  {
    private PropertyMetadata _uidPropertyMetadata;
    private PropertyInfo _uidProperty;
    private object _idSync;
    private bool? isTablePart;
    private static object hP2k7JhG4cUlPIRVDS6I;

    public MemoryEntityManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this._idSync = new object();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
        num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            this._uidProperty = typeof (T).GetReflectionProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222134508));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
            continue;
          default:
            List<PropertyMetadata> properties = ((ClassMetadata) MetadataLoader.LoadMetadata(typeof (T))).Properties;
            // ISSUE: reference to a compiler-generated field
            Func<PropertyMetadata, bool> func = MemoryEntityManager<T, IdT>.\u003C\u003Ec.\u003C\u003E9__0_0;
            Func<PropertyMetadata, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              MemoryEntityManager<T, IdT>.\u003C\u003Ec.\u003C\u003E9__0_0 = predicate = (Func<PropertyMetadata, bool>) (p =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      if (!(p.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751169934)))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_4;
                    case 2:
                      goto label_4;
                    default:
                      goto label_5;
                  }
                }
label_4:
                return p.TypeUid == GuidDescriptor.UID;
label_5:
                return false;
              });
            }
            else
              goto label_8;
label_7:
            this._uidPropertyMetadata = properties.FirstOrDefault<PropertyMetadata>(predicate);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 2;
            continue;
label_8:
            predicate = func;
            goto label_7;
        }
      }
label_5:;
    }

    public override T Create() => Activator.CreateInstance<T>();

    public override bool IsNew(T obj) => true;

    public override bool IsDirty(T obj) => false;

    public override bool IsDirty(T obj, object originalState) => false;

    public override Guid[] GetDirtyPropertyUids(T obj) => (Guid[]) null;

    public override Guid[] GetDirtyPropertyUids(T obj, object originalState) => (Guid[]) null;

    public override object GetCurrentState(T obj) => (object) null;

    public override T Load(IdT id) => this.LoadOrNull(id) ?? throw new EleWise.ELMA.Exceptions.ObjectNotFoundException(typeof (T).AssemblyQualifiedName, (object) id);

    public override T LoadOrNull(IdT id)
    {
      List<MemoryEntityManager<T, IdT>.EntityEntry> entries = this.GetEntries();
      MemoryEntityManager<T, IdT>.EntityEntry entityEntry = entries.FirstOrDefault<MemoryEntityManager<T, IdT>.EntityEntry>((Func<MemoryEntityManager<T, IdT>.EntityEntry, bool>) (e => e.Entity.Id.Equals((object) id)));
      if (entityEntry == null && this.CreateOnLoad(id))
      {
        T entity = this.Create();
        entity.Id = id;
        entityEntry = new MemoryEntityManager<T, IdT>.EntityEntry(entity);
        entries.Add(entityEntry);
      }
      if (entityEntry == null)
        return default (T);
      entityEntry.LastAccessTime = DateTime.Now;
      return entityEntry.Entity;
    }

    public override T Load(Guid uid) => this.LoadOrNull(uid) ?? throw new EleWise.ELMA.Exceptions.ObjectNotFoundException(typeof (T).AssemblyQualifiedName, (object) uid);

    public override T LoadOrNull(Guid uid)
    {
      if (this._uidProperty == (PropertyInfo) null)
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811966852), (object) typeof (T).AssemblyQualifiedName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289725960)));
      MemoryEntityManager<T, IdT>.EntityEntry entityEntry = this.GetEntries().FirstOrDefault<MemoryEntityManager<T, IdT>.EntityEntry>((Func<MemoryEntityManager<T, IdT>.EntityEntry, bool>) (e => (Guid) this._uidProperty.GetValue((object) e.Entity, (object[]) null) == uid));
      if (entityEntry == null)
        return default (T);
      entityEntry.LastAccessTime = DateTime.Now;
      return entityEntry.Entity;
    }

    public override ActionCheckResult CanSave(T obj) => ActionCheckResult.True;

    public override T LoadOrCreate(IdT id)
    {
      T entity = this.LoadOrNull(id);
      if ((object) entity == null)
      {
        entity = this.Create();
        entity.Id = id;
        this.GetEntries().Add(new MemoryEntityManager<T, IdT>.EntityEntry(entity));
      }
      return entity;
    }

    public override T LoadOrCreate(Guid uid)
    {
      T entity = this.LoadOrNull(uid);
      if ((object) entity == null)
      {
        entity = this.Create();
        this._uidProperty.SetValue((object) entity, (object) uid, (object[]) null);
        this.GetEntries().Add(new MemoryEntityManager<T, IdT>.EntityEntry(entity));
      }
      return entity;
    }

    public override void Save(T obj)
    {
    }

    public override ActionCheckResult CanDelete(T obj) => ActionCheckResult.True;

    public override void Delete(T obj)
    {
      if ((object) obj == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333760410));
      List<MemoryEntityManager<T, IdT>.EntityEntry> entries = this.GetEntries();
      MemoryEntityManager<T, IdT>.EntityEntry entityEntry = entries.FirstOrDefault<MemoryEntityManager<T, IdT>.EntityEntry>((Func<MemoryEntityManager<T, IdT>.EntityEntry, bool>) (e => e.Entity.Equals((object) obj)));
      if (entityEntry == null)
        return;
      entries.Remove(entityEntry);
    }

    public override void Delete(string query) => throw new NotImplementedException();

    public override void DeleteAll()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GetEntries().Clear();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void Refresh(T obj)
    {
    }

    public override void Refresh(T obj, LockMode mode)
    {
    }

    public override ICollection<T> FindAll() => this.Unwrap((IEnumerable<MemoryEntityManager<T, IdT>.EntityEntry>) this.GetEntries());

    public override ICollection<T> FindByIdArray(IdT[] idArray)
    {
      if (idArray == null)
        return this.FindAll();
      List<MemoryEntityManager<T, IdT>.EntityEntry> entityEntryList = new List<MemoryEntityManager<T, IdT>.EntityEntry>();
      return (ICollection<T>) ((IEnumerable<IdT>) idArray).Select<IdT, T>((Func<IdT, T>) (id => this.LoadOrNull(id))).Where<T>((Func<T, bool>) (e => (object) e != null)).ToArray<T>();
    }

    public override ICollection<T> FindAll(bool cacheble) => this.FindAll();

    public override ICollection<T> Find(FetchOptions fetchOptions) => this.Find((IEntityFilter) null, fetchOptions);

    public override ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions) => this.FindAll();

    public override ICollection<T> Find(Expression<Func<T, bool>> condition) => this.Unwrap(this.GetEntries().Where<MemoryEntityManager<T, IdT>.EntityEntry>((Func<MemoryEntityManager<T, IdT>.EntityEntry, bool>) (e => condition.Compile()(e.Entity))));

    public override ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition) => (ICollection<TResult>) this.Unwrap(this.GetEntries().Where<MemoryEntityManager<T, IdT>.EntityEntry>((Func<MemoryEntityManager<T, IdT>.EntityEntry, bool>) (e => (object) e.Entity is TResult && condition.Compile()((TResult) (object) e.Entity)))).Cast<TResult>().ToList<TResult>();

    public override ICollection<T> Find(
      Expression<Func<T, bool>> condition,
      FetchOptions fetchOptions)
    {
      return this.Find(condition);
    }

    public override ICollection<TResult> Find<TResult>(
      Expression<Func<TResult, bool>> condition,
      FetchOptions fetchOptions)
    {
      return this.Find<TResult>(condition);
    }

    /// <inheritdoc />
    public override ICollection<T> Find(string eqlFilter) => this.Find((IEntityFilter) new Filter()
    {
      Query = eqlFilter
    }, FetchOptions.All);

    /// <inheritdoc />
    public override ICollection<T> Find(string eqlFilter, FetchOptions fetchOptions) => this.Find((IEntityFilter) new Filter()
    {
      Query = eqlFilter
    }, fetchOptions);

    public override long Count() => this.Count((IEntityFilter) null);

    public override long Count(IEntityFilter filter) => (long) this.GetEntries().Count;

    public override void CheckFilter(IEntityFilter filter)
    {
    }

    public override ICollection<TProperty> Projection<TProperty>(string propertyName) => throw new NotImplementedException();

    public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
    {
    }

    public override DetachedCriteria CreateDetachedCriteria(
      FetchOptions fetchOptions,
      Type type,
      string alias = null,
      IEntityFilter filter = null)
    {
      throw new NotImplementedException();
    }

    public override void FilterDetachedCriteria(
      DetachedCriteria detachedCriteria,
      FetchOptions fetchOptions,
      Type type,
      IEntityFilter filter = null)
    {
      throw new NotImplementedException();
    }

    public override ExportRuleList ExportRules() => throw new NotImplementedException();

    protected ICollection<T> Unwrap(
      IEnumerable<MemoryEntityManager<T, IdT>.EntityEntry> collection)
    {
      if (collection == null)
        return (ICollection<T>) null;
      foreach (MemoryEntityManager<T, IdT>.EntityEntry entityEntry in collection)
        entityEntry.LastAccessTime = DateTime.Now;
      return (ICollection<T>) collection.Select<MemoryEntityManager<T, IdT>.EntityEntry, T>((Func<MemoryEntityManager<T, IdT>.EntityEntry, T>) (e => e.Entity)).ToList<T>();
    }

    protected virtual bool CreateOnLoad(IdT id)
    {
      if (!this.IsTablePart)
        return false;
      long? nullable = (object) id as long?;
      long num = 0;
      return nullable.GetValueOrDefault() < num & nullable.HasValue;
    }

    /// <summary>Менеджер для блока</summary>
    protected bool IsTablePart
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!this.isTablePart.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              this.isTablePart = new bool?(InterfaceActivator.LoadMetadata<T>() is ITablePartMetadata);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 1;
              continue;
          }
        }
label_2:
        return this.isTablePart.Value;
      }
    }

    private List<MemoryEntityManager<T, IdT>.EntityEntry> GetEntries() => ContextVars.GetOrAdd<List<MemoryEntityManager<T, IdT>.EntityEntry>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957619138) + typeof (T).AssemblyQualifiedName, (Func<List<MemoryEntityManager<T, IdT>.EntityEntry>>) (() => new List<MemoryEntityManager<T, IdT>.EntityEntry>()));

    internal static bool PLQTrNhG64vkIDtwmqbD() => MemoryEntityManager<T, IdT>.hP2k7JhG4cUlPIRVDS6I == null;

    internal static object Ifj5mYhGHP6HdTfpV6r0() => MemoryEntityManager<T, IdT>.hP2k7JhG4cUlPIRVDS6I;

    protected class EntityEntry
    {
      private static object IKij9xCghmhALW24KmAr;

      public EntityEntry(T entity)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.Entity = entity;
        this.LastAccessTime = DateTime.Now;
      }

      public T Entity { get; private set; }

      public DateTime LastAccessTime
      {
        get => this.\u003CLastAccessTime\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CLastAccessTime\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      internal static bool kjQ9WACgGlHLFTcWCllV() => MemoryEntityManager<T, IdT>.EntityEntry.IKij9xCghmhALW24KmAr == null;

      internal static object vjRodHCgERdjXDDPpVUx() => MemoryEntityManager<T, IdT>.EntityEntry.IKij9xCghmhALW24KmAr;
    }
  }
}
