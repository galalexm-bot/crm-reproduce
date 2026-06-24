// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.InheritedSet`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Collections
{
  /// <summary>
  /// Набор на основе исходного набора. Позволяет осуществлять преобразование набора одного типа в набор другого.
  /// Например, для преобразования из ISet&lt;IUser&gt; в ISet&lt;User&gt; и наоборот.
  /// </summary>
  /// <typeparam name="TSource">Тип элемента исходного набора</typeparam>
  /// <typeparam name="TTarget">Тип элемента данного (конечного) набора</typeparam>
  public class InheritedSet<TSource, TTarget> : 
    Iesi.Collections.Generic.ISet<TTarget>,
    System.Collections.Generic.ISet<TTarget>,
    ICollection<TTarget>,
    IEnumerable<TTarget>,
    IEnumerable,
    ISet,
    ICollection,
    IInheritedSet
    where TSource : class
    where TTarget : class
  {
    protected Iesi.Collections.Generic.ISet<TSource> source;
    internal static object zU5lJImKW6SU7fBJ4Tx;

    public InheritedSet(Iesi.Collections.Generic.ISet<TSource> source)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) source, z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712482065));
      this.source = source;
    }

    public bool Add(TTarget o) => this.source.Add((TSource) (object) o);

    public void UnionWith(IEnumerable<TTarget> other) => throw new NotImplementedException();

    public void IntersectWith(IEnumerable<TTarget> other) => throw new NotImplementedException();

    public void ExceptWith(IEnumerable<TTarget> other) => throw new NotImplementedException();

    public void SymmetricExceptWith(IEnumerable<TTarget> other) => throw new NotImplementedException();

    public bool IsSubsetOf(IEnumerable<TTarget> other) => throw new NotImplementedException();

    public bool IsSupersetOf(IEnumerable<TTarget> other) => throw new NotImplementedException();

    public bool IsProperSupersetOf(IEnumerable<TTarget> other) => throw new NotImplementedException();

    public bool IsProperSubsetOf(IEnumerable<TTarget> other) => throw new NotImplementedException();

    public bool Overlaps(IEnumerable<TTarget> other) => throw new NotImplementedException();

    public bool SetEquals(IEnumerable<TTarget> other) => throw new NotImplementedException();

    public bool AddAll(ICollection<TTarget> c) => this.source.AddAll((ICollection<TSource>) c.Cast<TSource>().ToList<TSource>());

    public bool ContainsAll(ICollection<TTarget> c) => this.source.ContainsAll((ICollection<TSource>) c.Cast<TSource>().ToList<TSource>());

    public bool RetainAll(ICollection<TTarget> c) => this.source.RetainAll((ICollection<TSource>) c.Cast<TSource>().ToList<TSource>());

    public Iesi.Collections.Generic.ISet<TTarget> ExclusiveOr(Iesi.Collections.Generic.ISet<TTarget> a) => throw new NotImplementedException();

    public Iesi.Collections.Generic.ISet<TTarget> Intersect(Iesi.Collections.Generic.ISet<TTarget> a) => throw new NotImplementedException();

    public bool IsEmpty => this.source.IsEmpty;

    public Iesi.Collections.Generic.ISet<TTarget> Minus(Iesi.Collections.Generic.ISet<TTarget> a) => throw new NotImplementedException();

    public bool RemoveAll(ICollection<TTarget> c) => this.source.RemoveAll((ICollection<TSource>) c.Cast<TSource>().ToList<TSource>());

    public Iesi.Collections.Generic.ISet<TTarget> Union(Iesi.Collections.Generic.ISet<TTarget> a) => throw new NotImplementedException();

    void ICollection<TTarget>.Add(TTarget item) => this.Add(item);

    public bool RetainAll(ICollection c) => throw new NotImplementedException();

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

    public bool Contains(TTarget item) => this.source.Contains((TSource) (object) item);

    public void CopyTo(TTarget[] array, int arrayIndex)
    {
      int num1 = 2;
      IEnumerator<TTarget> enumerator;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
            continue;
          case 2:
            num2 = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_17;
          default:
            goto label_2;
        }
      }
label_17:
      return;
label_2:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_7;
label_4:
        TTarget current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_12;
            case 1:
              array[num2 + arrayIndex] = current;
              num3 = 3;
              continue;
            case 2:
              goto label_10;
            case 3:
              ++num2;
              num3 = 4;
              continue;
            case 4:
              goto label_6;
            default:
              goto label_5;
          }
        }
label_12:
        return;
label_5:
        return;
label_7:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
        goto label_4;
label_10:
        current = enumerator.Current;
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
        {
          num3 = 1;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                enumerator.Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
    }

    public void CopyTo(Array array, int arrayIndex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.CopyTo((TTarget[]) array, arrayIndex);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public int Count => this.source.Count;

    public object SyncRoot
    {
      get => this.\u003CSyncRoot\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSyncRoot\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
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

    public bool IsSynchronized
    {
      get => this.\u003CIsSynchronized\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CIsSynchronized\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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

    public bool IsReadOnly => this.source.IsReadOnly;

    public bool Remove(TTarget item) => this.source.Remove((TSource) (object) item);

    public virtual IEnumerator<TTarget> GetEnumerator() => (IEnumerator<TTarget>) new InheritedSet<TSource, TTarget>.EnumeratorT(this.source.GetEnumerator());

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.source.GetEnumerator();

    /// <summary>Получить оригинальный набор</summary>
    /// <returns></returns>
    public ISet GetSourceSet() => (ISet) this.source;

    /// <summary>Инициализирована ли коллекция</summary>
    public bool WasInitialized => this.source.IsInitialized<TSource>();

    bool ISet.Add(object o) => this.Add((TTarget) o);

    bool ISet.AddAll(ICollection c) => this.AddAll(c != null ? (ICollection<TTarget>) c.Cast<TTarget>().ToList<TTarget>() : (ICollection<TTarget>) null);

    void ISet.Clear() => this.Clear();

    bool ISet.Contains(object o) => this.Contains((TTarget) o);

    bool ISet.ContainsAll(ICollection c) => this.ContainsAll(c != null ? (ICollection<TTarget>) c.Cast<TTarget>().ToList<TTarget>() : (ICollection<TTarget>) null);

    bool ISet.IsEmpty => this.IsEmpty;

    bool ISet.Remove(object o) => this.Remove((TTarget) o);

    bool ISet.RemoveAll(ICollection c) => this.RemoveAll((ICollection<TTarget>) c.Cast<TTarget>().ToList<TTarget>());

    internal static bool nS69t8mXqpEBUGfoni3() => InheritedSet<TSource, TTarget>.zU5lJImKW6SU7fBJ4Tx == null;

    internal static object mLqfpkmTlnMCuweAj6U() => InheritedSet<TSource, TTarget>.zU5lJImKW6SU7fBJ4Tx;

    protected class EnumeratorT : IEnumerator<TTarget>, IDisposable, IEnumerator
    {
      private IEnumerator<TSource> source;
      private static object JbZ7QKfg1sYg6pFrkqnJ;

      public EnumeratorT(IEnumerator<TSource> source)
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

      internal static bool n2ijldfgNKw6pJpXneSF() => InheritedSet<TSource, TTarget>.EnumeratorT.JbZ7QKfg1sYg6pFrkqnJ == null;

      internal static object FbqZlgfg3OWgOmcsudi0() => InheritedSet<TSource, TTarget>.EnumeratorT.JbZ7QKfg1sYg6pFrkqnJ;
    }
  }
}
