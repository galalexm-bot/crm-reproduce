// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.WrappedSetHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Helpers
{
  /// <summary>
  /// Обертывание коллекций интерфейсов/классов в коллекцию, реализующих оба типа
  /// </summary>
  public static class WrappedSetHelper
  {
    /// <summary>
    /// Обернуть <see cref="T:Iesi.Collections.Generic.ISet`1" />
    /// </summary>
    /// <typeparam name="TSource">Тип элементов</typeparam>
    /// <typeparam name="TTarget">Тип элементов</typeparam>
    /// <param name="source">Коллекция <see cref="T:Iesi.Collections.Generic.ISet`1" /></param>
    /// <returns>Коллекция <see cref="T:Iesi.Collections.Generic.ISet`1" /></returns>
    public static Iesi.Collections.Generic.ISet<TSource> Wrap<TSource, TTarget>(Iesi.Collections.Generic.ISet<TTarget> source)
    {
      if (source == null)
        return (Iesi.Collections.Generic.ISet<TSource>) null;
      if (!(source is WrappedSetHelper.IWrappedSet<TTarget, TSource> wrappedSet))
        wrappedSet = WrappedSetHelper.WrappedSet<TTarget, TSource>.Create(source);
      return wrappedSet.Cast();
    }

    /// <summary>
    /// Обернуть <see cref="T:Iesi.Collections.Generic.ISet`1" />
    /// </summary>
    /// <typeparam name="TSource">Тип элементов</typeparam>
    /// <typeparam name="TTarget">Тип элементов</typeparam>
    /// <param name="source">Коллекция <see cref="T:Iesi.Collections.Generic.ISet`1" /></param>
    /// <returns>Коллекция <see cref="T:Iesi.Collections.Generic.ISet`1" /></returns>
    public static Iesi.Collections.Generic.ISet<TSource> Wrap<TSource, TTarget>(Iesi.Collections.Generic.ISet<TSource> source)
    {
      if (source == null)
        return (Iesi.Collections.Generic.ISet<TSource>) null;
      return source is WrappedSetHelper.IWrappedSet<TSource, TTarget> wrappedSet ? (Iesi.Collections.Generic.ISet<TSource>) wrappedSet : (Iesi.Collections.Generic.ISet<TSource>) WrappedSetHelper.WrappedSet<TSource, TTarget>.Create(source);
    }

    /// <summary>
    /// Присвоение значения в свойство <see cref="T:Iesi.Collections.Generic.ISet`1" /> значения <see cref="T:Iesi.Collections.Generic.ISet`1" />
    /// </summary>
    /// <typeparam name="TSource">Тип элементов</typeparam>
    /// <typeparam name="TTarget">Тип элементов</typeparam>
    /// <param name="property">Исходное значение свойства <see cref="T:Iesi.Collections.Generic.ISet`1" /></param>
    /// <param name="value">Новое значение <see cref="T:Iesi.Collections.Generic.ISet`1" /></param>
    /// <param name="resProperty">Измененное значение свойства <see cref="T:Iesi.Collections.Generic.ISet`1" /></param>
    /// <returns><see langword="true" />, если необходимо изенить в свойсте ссылку на колекцию. <see langword="false" />, если ссылка на колекцию осталась прежней.</returns>
    public static bool Assign<TSource, TTarget>(
      Iesi.Collections.Generic.ISet<TSource> property,
      Iesi.Collections.Generic.ISet<TTarget> value,
      out Iesi.Collections.Generic.ISet<TSource> resProperty)
    {
      if (property != null)
      {
        property.Clear();
        if (value != null)
          property.UnionWith(value.Cast<TSource>());
      }
      else if (value != null)
      {
        resProperty = WrappedSetHelper.Wrap<TSource, TTarget>(value);
        return true;
      }
      resProperty = property;
      return false;
    }

    /// <summary>Сформировать CastedSet</summary>
    /// <typeparam name="TSource">Тип элементов</typeparam>
    /// <typeparam name="TTarget">Тип элементов</typeparam>
    /// <param name="wrappedSet">Коллекция</param>
    /// <returns>CastedSet</returns>
    internal static Iesi.Collections.Generic.ISet<TTarget> CreateCastedSet<TSource, TTarget>(
      this WrappedSetHelper.IWrappedSet<TSource, TTarget> wrappedSet)
    {
      return (Iesi.Collections.Generic.ISet<TTarget>) WrappedSetHelper.CastedSet<TSource, TTarget>.Create(wrappedSet);
    }

    /// <summary>
    /// Интерфейс коллекции <see cref="T:Iesi.Collections.Generic.ISet`1" />, позволяющей приведение к колекции <see cref="T:Iesi.Collections.Generic.ISet`1" />
    /// </summary>
    /// <typeparam name="TSource">Тип элементов</typeparam>
    /// <typeparam name="TTarget">Тип элементов</typeparam>
    internal interface IWrappedSet<TSource, TTarget> : 
      Iesi.Collections.Generic.ISet<TSource>,
      System.Collections.Generic.ISet<TSource>,
      ICollection<TSource>,
      IEnumerable<TSource>,
      IEnumerable
    {
      /// <summary>
      /// Привести коллекцию к типу <see cref="T:Iesi.Collections.Generic.ISet`1" />
      /// </summary>
      /// <returns>Приведенная коллекция</returns>
      Iesi.Collections.Generic.ISet<TTarget> Cast();
    }

    private class WrappedSet<TSource, TTarget> : 
      WrappedSetHelper.IWrappedSet<TSource, TTarget>,
      Iesi.Collections.Generic.ISet<TSource>,
      System.Collections.Generic.ISet<TSource>,
      ICollection<TSource>,
      IEnumerable<TSource>,
      IEnumerable
    {
      private readonly Iesi.Collections.Generic.ISet<TSource> source;
      private Iesi.Collections.Generic.ISet<TTarget> castedSet;
      internal static object DBETf1vmPU6i87MAg2cS;

      public static WrappedSetHelper.IWrappedSet<TSource, TTarget> Create(Iesi.Collections.Generic.ISet<TSource> source) => !(source is ISet) ? (WrappedSetHelper.IWrappedSet<TSource, TTarget>) new WrappedSetHelper.WrappedSet<TSource, TTarget>(source) : (WrappedSetHelper.IWrappedSet<TSource, TTarget>) new WrappedSetHelper.WrappedSet<TSource, TTarget>.GeneralSet(source);

      public WrappedSet(Iesi.Collections.Generic.ISet<TSource> source)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.source = source;
      }

      public bool IsEmpty => this.source.IsEmpty;

      public int Count => this.source.Count;

      public bool IsReadOnly => this.source.IsReadOnly;

      public bool Add(TSource item) => this.source.Add(item);

      public bool AddAll(ICollection<TSource> c) => this.source.AddAll(c);

      public void Clear()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.source.Clear();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public bool Contains(TSource item) => this.source.Contains(item);

      public bool ContainsAll(ICollection<TSource> c) => this.source.ContainsAll(c);

      public void CopyTo(TSource[] array, int arrayIndex)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.source.CopyTo(array, arrayIndex);
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

      public void ExceptWith(IEnumerable<TSource> other) => this.source.ExceptWith(other);

      public IEnumerator<TSource> GetEnumerator() => this.source.GetEnumerator();

      public void IntersectWith(IEnumerable<TSource> other) => this.source.IntersectWith(other);

      public bool IsProperSubsetOf(IEnumerable<TSource> other) => this.source.IsProperSubsetOf(other);

      public bool IsProperSupersetOf(IEnumerable<TSource> other) => this.source.IsProperSupersetOf(other);

      public bool IsSubsetOf(IEnumerable<TSource> other) => this.source.IsSubsetOf(other);

      public bool IsSupersetOf(IEnumerable<TSource> other) => this.source.IsSupersetOf(other);

      public bool Overlaps(IEnumerable<TSource> other) => this.source.Overlaps(other);

      public bool Remove(TSource item) => this.source.Remove(item);

      public bool RemoveAll(ICollection<TSource> c) => this.source.RemoveAll(c);

      public bool RetainAll(ICollection<TSource> c) => this.source.RetainAll(c);

      public bool SetEquals(IEnumerable<TSource> other) => this.source.SetEquals(other);

      public void SymmetricExceptWith(IEnumerable<TSource> other) => this.source.SymmetricExceptWith(other);

      public void UnionWith(IEnumerable<TSource> other) => this.source.UnionWith(other);

      void ICollection<TSource>.Add(TSource item) => this.Add(item);

      IEnumerator IEnumerable.GetEnumerator() => this.source.GetEnumerator();

      Iesi.Collections.Generic.ISet<TTarget> WrappedSetHelper.IWrappedSet<TSource, TTarget>.Cast() => this.castedSet ?? (this.castedSet = this.CreateCastedSet<TSource, TTarget>());

      internal static bool SIghthvm1kaXoX1MfRn4() => WrappedSetHelper.WrappedSet<TSource, TTarget>.DBETf1vmPU6i87MAg2cS == null;

      internal static object RE4TdovmNZUUUJvZ8jLE() => WrappedSetHelper.WrappedSet<TSource, TTarget>.DBETf1vmPU6i87MAg2cS;

      private class GeneralSet : 
        WrappedSetHelper.WrappedSet<TSource, TTarget>,
        ISet,
        ICollection,
        IEnumerable
      {
        private readonly ISet source;
        internal static object eAWbdQZk4ScZWYoNcIEZ;

        public GeneralSet(Iesi.Collections.Generic.ISet<TSource> source)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector(source);
          this.source = (ISet) source;
        }

        public object SyncRoot => this.source.SyncRoot;

        public bool IsSynchronized => this.source.IsSynchronized;

        public bool Contains(object o) => this.source.Contains(o);

        public bool Add(object o) => this.source.Add(o);

        public bool Remove(object o) => this.source.Remove(o);

        public bool ContainsAll(ICollection c) => this.source.ContainsAll(c);

        public bool AddAll(ICollection c) => this.source.AddAll(c);

        public bool RemoveAll(ICollection c) => this.source.RemoveAll(c);

        public bool RetainAll(ICollection c) => this.source.RetainAll(c);

        public void CopyTo(Array array, int index)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.source.CopyTo(array, index);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        internal static bool TvJHe7Zk6O5UIYtUbcXy() => WrappedSetHelper.WrappedSet<TSource, TTarget>.GeneralSet.eAWbdQZk4ScZWYoNcIEZ == null;

        internal static object bPoPYkZkHUpr1phVrXBu() => WrappedSetHelper.WrappedSet<TSource, TTarget>.GeneralSet.eAWbdQZk4ScZWYoNcIEZ;
      }
    }

    private class CastedSet<TSource, TTarget> : 
      Iesi.Collections.Generic.ISet<TTarget>,
      System.Collections.Generic.ISet<TTarget>,
      ICollection<TTarget>,
      IEnumerable<TTarget>,
      IEnumerable,
      WrappedSetHelper.IWrappedSet<TTarget, TSource>
    {
      private readonly WrappedSetHelper.IWrappedSet<TSource, TTarget> source;
      private static object RUmOlevm3jodvc8qZdBb;

      public static WrappedSetHelper.IWrappedSet<TTarget, TSource> Create(
        WrappedSetHelper.IWrappedSet<TSource, TTarget> wrappedSet)
      {
        return !(wrappedSet is ISet) ? (WrappedSetHelper.IWrappedSet<TTarget, TSource>) new WrappedSetHelper.CastedSet<TSource, TTarget>(wrappedSet) : (WrappedSetHelper.IWrappedSet<TTarget, TSource>) new WrappedSetHelper.CastedSet<TSource, TTarget>.GeneralSet(wrappedSet);
      }

      public CastedSet(
        WrappedSetHelper.IWrappedSet<TSource, TTarget> source)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.source = source;
      }

      public bool IsEmpty => this.source.IsEmpty;

      public int Count => this.source.Count;

      public bool IsReadOnly => this.source.IsReadOnly;

      public bool Add(TTarget item) => ((Iesi.Collections.Generic.ISet<TSource>) this.source).Add((TSource) (object) item);

      public bool Contains(TTarget item) => this.source.Contains((TSource) (object) item);

      public bool Remove(TTarget item) => this.source.Remove((TSource) (object) item);

      public bool AddAll(ICollection<TTarget> c) => this.source.AddAll((ICollection<TSource>) c.Cast<TSource>().ToArray<TSource>());

      public bool ContainsAll(ICollection<TTarget> c) => this.source.ContainsAll((ICollection<TSource>) c.Cast<TSource>().ToArray<TSource>());

      public bool RemoveAll(ICollection<TTarget> c) => this.source.RemoveAll((ICollection<TSource>) c.Cast<TSource>().ToArray<TSource>());

      public bool RetainAll(ICollection<TTarget> c) => this.source.RetainAll((ICollection<TSource>) c.Cast<TSource>().ToArray<TSource>());

      public void CopyTo(TTarget[] array, int arrayIndex)
      {
        int num = 3;
        TTarget[] array1;
        int arrayIndex1;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              array1 = array;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 2 : 4;
              continue;
            case 3:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 2 : 2;
              continue;
            case 4:
              arrayIndex1 = arrayIndex;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            default:
              this.source.Cast<TTarget>().Select<TTarget, TTarget>((Func<TTarget, int, TTarget>) ((item, i) => array1[i + arrayIndex1] = item)).Count<TTarget>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
              continue;
          }
        }
label_2:;
      }

      public void Clear()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.source.Clear();
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

      public void ExceptWith(IEnumerable<TTarget> other) => this.source.ExceptWith(other.Cast<TSource>());

      public void IntersectWith(IEnumerable<TTarget> other) => this.source.IntersectWith(other.Cast<TSource>());

      public bool IsProperSubsetOf(IEnumerable<TTarget> other) => this.source.IsProperSubsetOf(other.Cast<TSource>());

      public bool IsProperSupersetOf(IEnumerable<TTarget> other) => this.source.IsProperSupersetOf(other.Cast<TSource>());

      public bool IsSubsetOf(IEnumerable<TTarget> other) => this.source.IsSubsetOf(other.Cast<TSource>());

      public bool IsSupersetOf(IEnumerable<TTarget> other) => this.source.IsSupersetOf(other.Cast<TSource>());

      public bool Overlaps(IEnumerable<TTarget> other) => this.source.Overlaps(other.Cast<TSource>());

      public bool SetEquals(IEnumerable<TTarget> other) => this.source.SetEquals(other.Cast<TSource>());

      public void SymmetricExceptWith(IEnumerable<TTarget> other) => this.source.SymmetricExceptWith(other.Cast<TSource>());

      public void UnionWith(IEnumerable<TTarget> other) => this.source.UnionWith(other.Cast<TSource>());

      public IEnumerator<TTarget> GetEnumerator() => (IEnumerator<TTarget>) new WrappedSetHelper.CastedSet<TSource, TTarget>.Enumerator(this.source.GetEnumerator());

      IEnumerator IEnumerable.GetEnumerator() => this.source.GetEnumerator();

      void ICollection<TTarget>.Add(TTarget item) => this.Add(item);

      Iesi.Collections.Generic.ISet<TSource> WrappedSetHelper.IWrappedSet<TTarget, TSource>.Cast() => (Iesi.Collections.Generic.ISet<TSource>) this.source;

      internal static bool CIjiScvmpU5mFl5VCGMA() => WrappedSetHelper.CastedSet<TSource, TTarget>.RUmOlevm3jodvc8qZdBb == null;

      internal static object HWHfQkvmadayWd0YjUNn() => WrappedSetHelper.CastedSet<TSource, TTarget>.RUmOlevm3jodvc8qZdBb;

      private class Enumerator : IEnumerator<TTarget>, IDisposable, IEnumerator
      {
        private readonly IEnumerator<TSource> source;
        private static object tbTmWKZkAK5xAIOe7G1k;

        public Enumerator(IEnumerator<TSource> source)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          this.source = source;
        }

        public TTarget Current => (TTarget) (object) this.source.Current;

        public void Dispose()
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.source.Dispose();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        object IEnumerator.Current => (object) this.source.Current;

        public bool MoveNext() => this.source.MoveNext();

        public void Reset()
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.source.Reset();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        internal static bool TTDKSHZk7g9AO1RaNdhu() => WrappedSetHelper.CastedSet<TSource, TTarget>.Enumerator.tbTmWKZkAK5xAIOe7G1k == null;

        internal static object SRjEanZkxGafyLnK1sK7() => WrappedSetHelper.CastedSet<TSource, TTarget>.Enumerator.tbTmWKZkAK5xAIOe7G1k;
      }

      private class GeneralSet : 
        WrappedSetHelper.CastedSet<TSource, TTarget>,
        ISet,
        ICollection,
        IEnumerable
      {
        private readonly ISet source;
        private static object vlkWNGZk0vZhAFvAvR8j;

        public GeneralSet(
          WrappedSetHelper.IWrappedSet<TSource, TTarget> source)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector(source);
          this.source = (ISet) source;
        }

        public object SyncRoot => this.source.SyncRoot;

        public bool IsSynchronized => this.source.IsSynchronized;

        public bool Contains(object o) => this.source.Contains(o);

        public bool Add(object o) => this.source.Add(o);

        public bool Remove(object o) => this.source.Remove(o);

        public bool ContainsAll(ICollection c) => this.source.ContainsAll(c);

        public bool AddAll(ICollection c) => this.source.AddAll(c);

        public bool RemoveAll(ICollection c) => this.source.RemoveAll(c);

        public bool RetainAll(ICollection c) => this.source.RetainAll(c);

        public void CopyTo(Array array, int index)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.source.CopyTo(array, index);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        internal static bool Dl82OcZkmNX1Zn3VKb0T() => WrappedSetHelper.CastedSet<TSource, TTarget>.GeneralSet.vlkWNGZk0vZhAFvAvR8j == null;

        internal static object goSroUZkyCxdWeVqPCAy() => WrappedSetHelper.CastedSet<TSource, TTarget>.GeneralSet.vlkWNGZk0vZhAFvAvR8j;
      }
    }
  }
}
