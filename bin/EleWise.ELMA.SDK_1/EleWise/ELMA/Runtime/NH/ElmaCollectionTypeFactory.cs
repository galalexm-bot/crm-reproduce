// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.ElmaCollectionTypeFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Collection;
using NHibernate.Engine;
using NHibernate.Persister.Collection;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  /// <inheritdoc />
  public class ElmaCollectionTypeFactory : DefaultCollectionTypeFactory
  {
    private static readonly MethodInfo CreatePersistentCollectionMethod;
    private static readonly MethodInfo CreatePersistentCollectionSetMethod;
    private static readonly MethodInfo CreatePersistentCollectionIntrfMethod;
    private static readonly MethodInfo CreatePersistentCollectionSetIntrfMethod;
    private static readonly MethodInfo CreateSoftDeletablePersistentCollectionMethod;
    private static readonly MethodInfo CreateSoftDeletablePersistentCollectionSetMethod;
    private static readonly MethodInfo CreateSoftDeletablePersistentCollectionIntrfMethod;
    private static readonly MethodInfo CreateSoftDeletablePersistentCollectionSetIntrfMethod;
    internal static ElmaCollectionTypeFactory vQPRvZW3AF64jw2Qw8Lu;

    /// <inheritdoc />
    public override CollectionType Set<T>(string role, string propertyRef) => (CollectionType) new ElmaCollectionTypeFactory.GenericSetType<T>(role, propertyRef);

    /// <inheritdoc />
    public override CollectionType SortedSet<T>(
      string role,
      string propertyRef,
      IComparer<T> comparer)
    {
      return (CollectionType) new ElmaCollectionTypeFactory.GenericSortedSetType<T>(role, propertyRef, comparer);
    }

    /// <inheritdoc />
    public override CollectionType OrderedSet<T>(string role, string propertyRef) => (CollectionType) new ElmaCollectionTypeFactory.GenericOrderedSetType<T>(role, propertyRef);

    private static IPersistentCollection CreatePersistentCollection<TClass>(object session) => (IPersistentCollection) new ElmaCollectionTypeFactory.PersistentGenericSet<TClass>((ISessionImplementor) session);

    private static IPersistentCollection CreatePersistentCollectionSet<TClass>(
      object session,
      System.Collections.Generic.ISet<TClass> set)
    {
      return (IPersistentCollection) new ElmaCollectionTypeFactory.PersistentGenericSet<TClass>((ISessionImplementor) session, set);
    }

    private static IPersistentCollection CreatePersistentCollectionIntrf<TClass, TInterface>(
      object session)
    {
      return (IPersistentCollection) new ElmaCollectionTypeFactory.PersistentGenericSet<TClass, TInterface>((ISessionImplementor) session);
    }

    private static IPersistentCollection CreatePersistentCollectionSetIntrf<TClass, TInterface>(
      object session,
      System.Collections.Generic.ISet<TClass> set)
    {
      return (IPersistentCollection) new ElmaCollectionTypeFactory.PersistentGenericSet<TClass, TInterface>((ISessionImplementor) session, set);
    }

    private static IPersistentCollection CreateSoftDeletablePersistentCollection<TClass>(
      object session)
    {
      return (IPersistentCollection) new ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<TClass>((ISessionImplementor) session);
    }

    private static IPersistentCollection CreateSoftDeletablePersistentCollectionSet<TClass>(
      object session,
      System.Collections.Generic.ISet<TClass> set)
    {
      return (IPersistentCollection) new ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<TClass>((ISessionImplementor) session, set);
    }

    private static IPersistentCollection CreateSoftDeletablePersistentCollectionIntrf<TClass, TInterface>(
      object session)
    {
      return (IPersistentCollection) new ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<TClass, TInterface>((ISessionImplementor) session);
    }

    private static IPersistentCollection CreateSoftDeletablePersistentCollectionSetIntrf<TClass, TInterface>(
      object session,
      System.Collections.Generic.ISet<TClass> set)
    {
      return (IPersistentCollection) new ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<TClass, TInterface>((ISessionImplementor) session, set);
    }

    private static (Func<ISessionImplementor, IPersistentCollection>, Func<ISessionImplementor, System.Collections.Generic.ISet<T>, IPersistentCollection>) GetInstantiators<T>(
      System.Type type)
    {
      bool flag = TypeOf<ISoftDeletable>.Raw.IsAssignableFrom(TypeOf<T>.Raw);
      ParameterExpression parameterExpression1 = Expression.Parameter(TypeOf<ISessionImplementor>.Raw);
      ParameterExpression parameterExpression2 = Expression.Parameter(TypeOf<System.Collections.Generic.ISet<T>>.Raw);
      Expression body1;
      Expression body2;
      if (MetadataLoader.LoadMetadata(type, false, false) is EntityMetadata entityMetadata && entityMetadata.Type == EntityMetadataType.InterfaceImplementation)
      {
        System.Type typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(entityMetadata.ImplementationUid, false);
        body1 = (Expression) Expression.Call((flag ? ElmaCollectionTypeFactory.CreateSoftDeletablePersistentCollectionIntrfMethod : ElmaCollectionTypeFactory.CreatePersistentCollectionIntrfMethod).MakeGenericMethod(type, typeByUid), (Expression) parameterExpression1);
        body2 = (Expression) Expression.Call((flag ? ElmaCollectionTypeFactory.CreateSoftDeletablePersistentCollectionSetIntrfMethod : ElmaCollectionTypeFactory.CreatePersistentCollectionSetIntrfMethod).MakeGenericMethod(type, typeByUid), (Expression) parameterExpression1, (Expression) parameterExpression2);
      }
      else
      {
        body1 = (Expression) Expression.Call((flag ? ElmaCollectionTypeFactory.CreateSoftDeletablePersistentCollectionMethod : ElmaCollectionTypeFactory.CreatePersistentCollectionMethod).MakeGenericMethod(type), (Expression) parameterExpression1);
        body2 = (Expression) Expression.Call((flag ? ElmaCollectionTypeFactory.CreateSoftDeletablePersistentCollectionSetMethod : ElmaCollectionTypeFactory.CreatePersistentCollectionSetMethod).MakeGenericMethod(type), (Expression) parameterExpression1, (Expression) parameterExpression2);
      }
      return ((Func<ISessionImplementor, IPersistentCollection>) Expression.Lambda(body1, parameterExpression1).Compile(), (Func<ISessionImplementor, System.Collections.Generic.ISet<T>, IPersistentCollection>) Expression.Lambda(body2, parameterExpression1, parameterExpression2).Compile());
    }

    public ElmaCollectionTypeFactory()
    {
      ElmaCollectionTypeFactory.nmhRpcW30aJN4ieYg4Dn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ElmaCollectionTypeFactory()
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ElmaCollectionTypeFactory.CreatePersistentCollectionIntrfMethod = typeof (ElmaCollectionTypeFactory).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813468143), BindingFlags.Static | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            case 2:
              ElmaCollectionTypeFactory.CreateSoftDeletablePersistentCollectionSetMethod = typeof (ElmaCollectionTypeFactory).GetMethod((string) ElmaCollectionTypeFactory.X6Bjs4W3y3PP5GtPK5XH(1218962250 ^ 1218835536), BindingFlags.Static | BindingFlags.NonPublic);
              num2 = 3;
              continue;
            case 3:
              // ISSUE: type reference
              // ISSUE: explicit non-virtual call
              ElmaCollectionTypeFactory.CreateSoftDeletablePersistentCollectionIntrfMethod = __nonvirtual (ElmaCollectionTypeFactory.Ss5HhLW3m1dfUuLigYdZ(__typeref (ElmaCollectionTypeFactory)).GetMethod((string) ElmaCollectionTypeFactory.X6Bjs4W3y3PP5GtPK5XH(-1852837372 ^ -1852971658), BindingFlags.Static | BindingFlags.NonPublic));
              num2 = 5;
              continue;
            case 4:
              // ISSUE: type reference
              // ISSUE: explicit non-virtual call
              ElmaCollectionTypeFactory.CreatePersistentCollectionSetMethod = __nonvirtual (ElmaCollectionTypeFactory.Ss5HhLW3m1dfUuLigYdZ(__typeref (ElmaCollectionTypeFactory)).GetMethod((string) ElmaCollectionTypeFactory.X6Bjs4W3y3PP5GtPK5XH(-1334993905 ^ -1334867441), BindingFlags.Static | BindingFlags.NonPublic));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
              continue;
            case 5:
              // ISSUE: type reference
              // ISSUE: explicit non-virtual call
              ElmaCollectionTypeFactory.CreateSoftDeletablePersistentCollectionSetIntrfMethod = __nonvirtual (ElmaCollectionTypeFactory.Ss5HhLW3m1dfUuLigYdZ(__typeref (ElmaCollectionTypeFactory)).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671997195), BindingFlags.Static | BindingFlags.NonPublic));
              num2 = 9;
              continue;
            case 6:
              // ISSUE: type reference
              // ISSUE: explicit non-virtual call
              ElmaCollectionTypeFactory.CreatePersistentCollectionMethod = __nonvirtual (ElmaCollectionTypeFactory.Ss5HhLW3m1dfUuLigYdZ(__typeref (ElmaCollectionTypeFactory)).GetMethod((string) ElmaCollectionTypeFactory.X6Bjs4W3y3PP5GtPK5XH(-1426456882 ^ 2009939514 ^ -583609028), BindingFlags.Static | BindingFlags.NonPublic));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 4 : 3;
              continue;
            case 7:
              goto label_7;
            case 8:
              // ISSUE: type reference
              // ISSUE: explicit non-virtual call
              ElmaCollectionTypeFactory.CreateSoftDeletablePersistentCollectionMethod = __nonvirtual (ElmaCollectionTypeFactory.Ss5HhLW3m1dfUuLigYdZ(__typeref (ElmaCollectionTypeFactory)).GetMethod((string) ElmaCollectionTypeFactory.X6Bjs4W3y3PP5GtPK5XH(-2092274397 << 4 ^ 883213560), BindingFlags.Static | BindingFlags.NonPublic));
              num2 = 2;
              continue;
            case 9:
              goto label_3;
            default:
              // ISSUE: type reference
              // ISSUE: explicit non-virtual call
              ElmaCollectionTypeFactory.CreatePersistentCollectionSetIntrfMethod = __nonvirtual (ElmaCollectionTypeFactory.Ss5HhLW3m1dfUuLigYdZ(__typeref (ElmaCollectionTypeFactory)).GetMethod((string) ElmaCollectionTypeFactory.X6Bjs4W3y3PP5GtPK5XH(712480695 ^ 712343863), BindingFlags.Static | BindingFlags.NonPublic));
              num2 = 8;
              continue;
          }
        }
label_7:
        ElmaCollectionTypeFactory.nmhRpcW30aJN4ieYg4Dn();
        num1 = 6;
      }
label_3:;
    }

    internal static void nmhRpcW30aJN4ieYg4Dn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool r9BIDGW37HgqERSIq9yq() => ElmaCollectionTypeFactory.vQPRvZW3AF64jw2Qw8Lu == null;

    internal static ElmaCollectionTypeFactory yc2703W3xefbBN05argi() => ElmaCollectionTypeFactory.vQPRvZW3AF64jw2Qw8Lu;

    internal static System.Type Ss5HhLW3m1dfUuLigYdZ([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object X6Bjs4W3y3PP5GtPK5XH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    private class PersistentGenericSet<T> : 
      NHibernate.Collection.Generic.PersistentGenericSet<T>,
      ISet,
      ICollection,
      IEnumerable,
      Iesi.Collections.Generic.ISet<T>,
      System.Collections.Generic.ISet<T>,
      ICollection<T>,
      IEnumerable<T>
    {
      internal static object sMBCUaQMDhyLkQTQwtSB;

      public PersistentGenericSet()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      public PersistentGenericSet(ISessionImplementor session)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(session);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      public PersistentGenericSet(ISessionImplementor session, System.Collections.Generic.ISet<T> original)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(session, original);
      }

      public bool IsEmpty
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.Read();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          return this.Empty;
        }
      }

      public bool Contains(object o) => this.Contains((T) o);

      public bool Add(object o) => this.Add((T) o);

      public bool Remove(object o) => this.Remove((T) o);

      public bool AddAll(ICollection<T> c) => c.Aggregate<T, bool>(false, (Func<bool, T, bool>) ((a, item) => this.Add(item) | a));

      public bool ContainsAll(ICollection<T> c) => c.Aggregate<T, bool>(true, (Func<bool, T, bool>) ((a, item) => this.Contains(item) & a));

      public bool RemoveAll(ICollection<T> c) => c.Aggregate<T, bool>(false, (Func<bool, T, bool>) ((a, item) => this.Remove(item) | a));

      public bool RetainAll(ICollection<T> c)
      {
        int count = this.Count;
        this.IntersectWith((IEnumerable<T>) c);
        return this.Count != count;
      }

      public bool ContainsAll(ICollection c) => this.ContainsAll((ICollection<T>) c);

      public bool AddAll(ICollection c) => this.AddAll((ICollection<T>) c);

      public bool RemoveAll(ICollection c) => this.RemoveAll((ICollection<T>) c);

      public bool RetainAll(ICollection c) => this.RetainAll((ICollection<T>) c);

      public void CopyTo(System.Array array, int index)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.CopyTo((T[]) array, index);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      [SpecialName]
      object ICollection.get_SyncRoot() => this.SyncRoot;

      [SpecialName]
      bool ICollection.get_IsSynchronized() => this.IsSynchronized;

      internal static bool m8JFJ1QMtSmV8341723Q() => ElmaCollectionTypeFactory.PersistentGenericSet<T>.sMBCUaQMDhyLkQTQwtSB == null;

      internal static object ggjiBiQMwAZaVQpT978I() => ElmaCollectionTypeFactory.PersistentGenericSet<T>.sMBCUaQMDhyLkQTQwtSB;
    }

    private class PersistentGenericSet<TSource, TTarget> : 
      ElmaCollectionTypeFactory.PersistentGenericSet<TSource>,
      WrappedSetHelper.IWrappedSet<TSource, TTarget>,
      Iesi.Collections.Generic.ISet<TSource>,
      System.Collections.Generic.ISet<TSource>,
      ICollection<TSource>,
      IEnumerable<TSource>,
      IEnumerable
    {
      private Iesi.Collections.Generic.ISet<TTarget> castedSet;
      private static object XBP26bQM4P4xBuI9LIJb;

      public PersistentGenericSet()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      public PersistentGenericSet(ISessionImplementor session)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(session);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
          num = 0;
        switch (num)
        {
        }
      }

      public PersistentGenericSet(ISessionImplementor session, System.Collections.Generic.ISet<TSource> original)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(session, original);
      }

      Iesi.Collections.Generic.ISet<TTarget> WrappedSetHelper.IWrappedSet<TSource, TTarget>.Cast() => this.castedSet ?? (this.castedSet = this.CreateCastedSet<TSource, TTarget>());

      internal static bool cIGjo2QM6VS06flE5LLw() => ElmaCollectionTypeFactory.PersistentGenericSet<TSource, TTarget>.XBP26bQM4P4xBuI9LIJb == null;

      internal static object GNoZQsQMHJJotdFbkskZ() => ElmaCollectionTypeFactory.PersistentGenericSet<TSource, TTarget>.XBP26bQM4P4xBuI9LIJb;
    }

    private class SoftDeletablePersistentGenericSet<T> : 
      ElmaCollectionTypeFactory.PersistentGenericSet<T>,
      ISet,
      ICollection,
      IEnumerable,
      Iesi.Collections.Generic.ISet<T>,
      System.Collections.Generic.ISet<T>,
      ICollection<T>,
      IEnumerable<T>
    {
      private static readonly RunWithSoftDeletableService RunWithSoftDeletableService;
      internal static object bUViVwQMAtUBpvwuWMP9;

      public SoftDeletablePersistentGenericSet()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
          num = 0;
        switch (num)
        {
        }
      }

      public SoftDeletablePersistentGenericSet(ISessionImplementor session)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(session);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      public SoftDeletablePersistentGenericSet(ISessionImplementor session, System.Collections.Generic.ISet<T> original)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(session, original);
      }

      private static bool Filter(T item) => (object) item == null || !((ISoftDeletable) (object) item).IsDeleted;

      bool ICollection<T>.Remove(T item)
      {
        if (!this.Remove(item))
          return false;
        return this.SoftDeletableTurned || ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.Filter(item);
      }

      bool ICollection<T>.Contains(T item)
      {
        if (!this.Contains(item))
          return false;
        return this.SoftDeletableTurned || ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.Filter(item);
      }

      int ICollection<T>.Count
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (!this.SoftDeletableTurned)
                {
                  this.Read();
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 2 : 0;
                  continue;
                }
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_6;
              default:
                goto label_2;
            }
          }
label_2:
          return this.Count;
label_6:
          return this.WrappedSet.Count<T>(new Func<T, bool>(ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.Filter));
        }
      }

      void ICollection<T>.CopyTo(T[] array, int arrayIndex)
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_4;
            case 2:
              this.WrappedSet.Where<T>(new Func<T, bool>(ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.Filter)).ToArray<T>().CopyTo((System.Array) array, arrayIndex);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            case 3:
              this.CopyTo(array, arrayIndex);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 1;
              continue;
            case 4:
              if (this.SoftDeletableTurned)
              {
                num = 3;
                continue;
              }
              this.Read();
              num = 2;
              continue;
            default:
              goto label_9;
          }
        }
label_2:
        return;
label_4:
        return;
label_9:;
      }

      int ICollection.Count => ((ICollection<T>) this).Count;

      void ICollection.CopyTo(System.Array array, int index)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ((ICollection<T>) this).CopyTo((T[]) array, index);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      private System.Collections.Generic.ISet<T> Filtered
      {
        get
        {
          this.Read();
          return !this.SoftDeletableTurned ? (System.Collections.Generic.ISet<T>) new System.Collections.Generic.HashSet<T>(this.WrappedSet.Where<T>(new Func<T, bool>(ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.Filter))) : this.WrappedSet;
        }
      }

      bool System.Collections.Generic.ISet<T>.Add(T item)
      {
        if (!this.Add(item))
          return false;
        return this.SoftDeletableTurned || ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.Filter(item);
      }

      bool System.Collections.Generic.ISet<T>.IsProperSubsetOf(IEnumerable<T> other) => this.Filtered.IsProperSubsetOf(other);

      bool System.Collections.Generic.ISet<T>.IsProperSupersetOf(IEnumerable<T> other) => this.Filtered.IsProperSupersetOf(other);

      bool System.Collections.Generic.ISet<T>.IsSubsetOf(IEnumerable<T> other) => this.Filtered.IsSubsetOf(other);

      bool System.Collections.Generic.ISet<T>.IsSupersetOf(IEnumerable<T> other) => this.Filtered.IsSupersetOf(other);

      bool System.Collections.Generic.ISet<T>.Overlaps(IEnumerable<T> other) => this.Filtered.Overlaps(other);

      bool System.Collections.Generic.ISet<T>.SetEquals(IEnumerable<T> other) => this.Filtered.SetEquals(other);

      bool Iesi.Collections.Generic.ISet<T>.IsEmpty => ((ICollection<T>) this).Count == 0;

      bool Iesi.Collections.Generic.ISet<T>.Add(T item) => ((System.Collections.Generic.ISet<T>) this).Add(item);

      bool Iesi.Collections.Generic.ISet<T>.AddAll(ICollection<T> c) => c.Aggregate<T, bool>(false, (Func<bool, T, bool>) ((a, item) => ((System.Collections.Generic.ISet<T>) this).Add(item) | a));

      bool Iesi.Collections.Generic.ISet<T>.ContainsAll(ICollection<T> c) => c.Aggregate<T, bool>(true, (Func<bool, T, bool>) ((a, item) => ((ICollection<T>) this).Contains(item) & a));

      bool Iesi.Collections.Generic.ISet<T>.RemoveAll(ICollection<T> c) => c.Aggregate<T, bool>(false, (Func<bool, T, bool>) ((a, item) => ((ICollection<T>) this).Remove(item) | a));

      bool Iesi.Collections.Generic.ISet<T>.RetainAll(ICollection<T> c)
      {
        int count = ((ICollection<T>) this).Count;
        this.IntersectWith((IEnumerable<T>) c);
        return ((ICollection<T>) this).Count < count;
      }

      bool ISet.IsEmpty => ((ICollection<T>) this).Count == 0;

      int ISet.Count => ((ICollection<T>) this).Count;

      bool ISet.Add(object o) => ((System.Collections.Generic.ISet<T>) this).Add((T) o);

      bool ISet.AddAll(ICollection c) => ((Iesi.Collections.Generic.ISet<T>) this).AddAll((ICollection<T>) c);

      bool ISet.Contains(object o) => ((ICollection<T>) this).Contains((T) o);

      bool ISet.ContainsAll(ICollection c) => ((Iesi.Collections.Generic.ISet<T>) this).ContainsAll((ICollection<T>) c);

      bool ISet.Remove(object o) => ((ICollection<T>) this).Remove((T) o);

      bool ISet.RemoveAll(ICollection c) => ((Iesi.Collections.Generic.ISet<T>) this).RemoveAll((ICollection<T>) c);

      bool ISet.RetainAll(ICollection c) => ((Iesi.Collections.Generic.ISet<T>) this).RetainAll((ICollection<T>) c);

      IEnumerator<T> IEnumerable<T>.GetEnumerator()
      {
        this.Read();
        return !this.SoftDeletableTurned ? this.WrappedSet.Where<T>(new Func<T, bool>(ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.Filter)).GetEnumerator() : this.WrappedSet.GetEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_4;
            case 2:
              if (this.SoftDeletableTurned)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 3:
              this.Read();
              num = 2;
              continue;
            default:
              goto label_5;
          }
        }
label_4:
        return (IEnumerator) this.WrappedSet.Where<T>(new Func<T, bool>(ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.Filter)).GetEnumerator();
label_5:
        return (IEnumerator) this.WrappedSet.GetEnumerator();
      }

      /// <inheritdoc />
      public override string ToString() => string.Join<T>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210722879), (IEnumerable<T>) this);

      private bool SoftDeletableTurned
      {
        get
        {
          int num1 = 1;
          IDisposable disposable;
          while (true)
          {
            switch (num1)
            {
              case 1:
                disposable = ELMAContext.Create();
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                goto label_4;
            }
          }
label_2:
          bool turned;
          return turned;
label_4:
          try
          {
            turned = ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.RunWithSoftDeletableService.Turned;
            int num2 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
              num2 = 0;
            switch (num2)
            {
              default:
                goto label_2;
            }
          }
          finally
          {
            int num3;
            if (disposable == null)
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
            else
              goto label_11;
label_10:
            switch (num3)
            {
              case 2:
                break;
              default:
            }
label_11:
            disposable.Dispose();
            num3 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
            {
              num3 = 0;
              goto label_10;
            }
            else
              goto label_10;
          }
        }
      }

      static SoftDeletablePersistentGenericSet()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.RunWithSoftDeletableService = Locator.GetServiceNotNull<RunWithSoftDeletableService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 2 : 1;
              continue;
          }
        }
label_2:;
      }

      [SpecialName]
      object ICollection.get_SyncRoot() => this.SyncRoot;

      [SpecialName]
      bool ICollection.get_IsSynchronized() => this.IsSynchronized;

      internal static bool hQJg78QM7OIcXsSgO6pU() => ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.bUViVwQMAtUBpvwuWMP9 == null;

      internal static object IplmXUQMxKYUSHaGs8ld() => ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<T>.bUViVwQMAtUBpvwuWMP9;
    }

    private class SoftDeletablePersistentGenericSet<TSource, TTarget> : 
      ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<TSource>,
      WrappedSetHelper.IWrappedSet<TSource, TTarget>,
      Iesi.Collections.Generic.ISet<TSource>,
      System.Collections.Generic.ISet<TSource>,
      ICollection<TSource>,
      IEnumerable<TSource>,
      IEnumerable
    {
      private Iesi.Collections.Generic.ISet<TTarget> castedSet;
      private static object LuSlqVQM05w83lfs4anT;

      public SoftDeletablePersistentGenericSet()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      public SoftDeletablePersistentGenericSet(ISessionImplementor session)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(session);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      public SoftDeletablePersistentGenericSet(ISessionImplementor session, System.Collections.Generic.ISet<TSource> original)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(session, original);
      }

      Iesi.Collections.Generic.ISet<TTarget> WrappedSetHelper.IWrappedSet<TSource, TTarget>.Cast() => this.castedSet ?? (this.castedSet = this.CreateCastedSet<TSource, TTarget>());

      internal static bool GQBekwQMmD6nChsjVTB9() => ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<TSource, TTarget>.LuSlqVQM05w83lfs4anT == null;

      internal static object fZS0lmQMyb4pjAOFaZi3() => ElmaCollectionTypeFactory.SoftDeletablePersistentGenericSet<TSource, TTarget>.LuSlqVQM05w83lfs4anT;
    }

    [Serializable]
    private class GenericSetType<T> : NHibernate.Type.GenericSetType<T>
    {
      private static readonly ConcurrentDictionary<System.Type, (Func<ISessionImplementor, IPersistentCollection> instantiate, Func<ISessionImplementor, System.Collections.Generic.ISet<T>, IPersistentCollection> wrap)> Instantiators;
      private readonly Func<ISessionImplementor, IPersistentCollection> instantiate;
      private readonly Func<ISessionImplementor, System.Collections.Generic.ISet<T>, IPersistentCollection> wrap;
      internal static object fluElKQMMaRVkGWy1XPB;

      public GenericSetType(string role, string propertyRef)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(role, propertyRef);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
          num = 1;
        (Func<ISessionImplementor, IPersistentCollection> instantiate, Func<ISessionImplementor, System.Collections.Generic.ISet<T>, IPersistentCollection> wrap) orAdd;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              orAdd = ElmaCollectionTypeFactory.GenericSetType<T>.Instantiators.GetOrAdd(typeof (T), new Func<System.Type, (Func<ISessionImplementor, IPersistentCollection>, Func<ISessionImplementor, System.Collections.Generic.ISet<T>, IPersistentCollection>)>(ElmaCollectionTypeFactory.GetInstantiators<T>));
              num = 3;
              continue;
            case 2:
              this.wrap = orAdd.wrap;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            case 3:
              this.instantiate = orAdd.instantiate;
              num = 2;
              continue;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:;
      }

      public override IPersistentCollection Instantiate(
        ISessionImplementor session,
        ICollectionPersister persister,
        object key)
      {
        return this.instantiate(session);
      }

      public override IPersistentCollection Wrap(ISessionImplementor session, object collection)
      {
        int num = 3;
        System.Collections.Generic.ISet<T> objSet;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (objSet == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 3:
              objSet = collection as System.Collections.Generic.ISet<T>;
              num = 2;
              continue;
            default:
              if (collection is ICollection<T> collection1)
              {
                objSet = (System.Collections.Generic.ISet<T>) new System.Collections.Generic.HashSet<T>((IEnumerable<T>) collection1);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
                continue;
              }
              goto label_7;
          }
        }
label_2:
        return this.wrap(session, objSet);
label_7:
        throw new HibernateException(this.Role + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124280690));
      }

      static GenericSetType()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              ElmaCollectionTypeFactory.GenericSetType<T>.Instantiators = new ConcurrentDictionary<System.Type, (Func<ISessionImplementor, IPersistentCollection>, Func<ISessionImplementor, System.Collections.Generic.ISet<T>, IPersistentCollection>)>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static bool HpRK57QMJtWg2UR6gbmn() => ElmaCollectionTypeFactory.GenericSetType<T>.fluElKQMMaRVkGWy1XPB == null;

      internal static object kFtM8QQM9CncHWfVtXFn() => ElmaCollectionTypeFactory.GenericSetType<T>.fluElKQMMaRVkGWy1XPB;
    }

    [Serializable]
    private class GenericSortedSetType<T> : ElmaCollectionTypeFactory.GenericSetType<T>
    {
      internal static object NjZ3L4QMdDhCD8WOG8Bu;

      public GenericSortedSetType(string role, string propertyRef, IComparer<T> comparer)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(role, propertyRef);
        if (comparer is IComparerInternal comparerInternal)
          comparerInternal.SetRole(role);
        this.Comparer = comparer;
      }

      public IComparer<T> Comparer { get; }

      public override object Instantiate(int anticipatedSize) => (object) new IesiSortedSet<T>(this.Comparer);

      internal static bool SoNNX0QMlC6Oo0LAXDDk() => ElmaCollectionTypeFactory.GenericSortedSetType<T>.NjZ3L4QMdDhCD8WOG8Bu == null;

      internal static object hXERvwQMrlvqYsa61AnY() => ElmaCollectionTypeFactory.GenericSortedSetType<T>.NjZ3L4QMdDhCD8WOG8Bu;
    }

    [Serializable]
    private class GenericOrderedSetType<T> : ElmaCollectionTypeFactory.GenericSetType<T>
    {
      internal static object pAEe7dQMgoG6dQ04kakQ;

      public GenericOrderedSetType(string role, string propertyRef)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(role, propertyRef);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
          num = 0;
        switch (num)
        {
        }
      }

      public override object Instantiate(int anticipatedSize) => (object) new Iesi.Collections.Generic.LinkedHashSet<T>();

      internal static bool eVO0d2QM5fLYdg8Cj1Sj() => ElmaCollectionTypeFactory.GenericOrderedSetType<T>.pAEe7dQMgoG6dQ04kakQ == null;

      internal static object tDWbhDQMjuINN2EX7HN8() => ElmaCollectionTypeFactory.GenericOrderedSetType<T>.pAEe7dQMgoG6dQ04kakQ;
    }
  }
}
