// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.IesiSortedSet`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// SortedSet, который реализует Iesi.Collections.Generic.ISet&lt;T&gt;&gt;
  /// </summary>
  public class IesiSortedSet<T> : 
    SortedSet<T>,
    Iesi.Collections.Generic.ISet<T>,
    System.Collections.Generic.ISet<T>,
    ICollection<T>,
    IEnumerable<T>,
    IEnumerable,
    ISet,
    ICollection
  {
    internal static object bW9vdCWpNx9iVbI0R7rX;

    /// <summary>Ctor</summary>
    public IesiSortedSet()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public static IesiSortedSet<T> Create<TKey>(
      Func<T, TKey> propertyExpression,
      ListSortDirection order)
    {
      return new IesiSortedSet<T>(IesiSortedSet<T>.GetComparer<TKey>(propertyExpression, order));
    }

    [Obsolete("Use Create<TKey>(Func<T, TKey>, ListSortDirection) instead", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IesiSortedSet<T> Create<TKey>(
      string typeUidProperty,
      string subTypeUidProperty,
      Func<T, TKey> propertyExpression,
      ListSortDirection order)
    {
      return new IesiSortedSet<T>(IesiSortedSet<T>.GetComparer<TKey>(propertyExpression, order));
    }

    private static IComparer<T> GetComparer<TKey>(
      Func<T, TKey> propertyExpression,
      ListSortDirection order)
    {
      return ((ISortedProperty) MetadataServiceContext.Service.GetTypeDescriptor(typeof (TKey))).GetComparer<T, TKey>(propertyExpression, order);
    }

    public IesiSortedSet(IComparer<T> comparer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(comparer);
    }

    public IesiSortedSet(IEnumerable<T> collection)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(collection);
    }

    public IesiSortedSet(IEnumerable<T> collection, IComparer<T> comparer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(collection, comparer);
    }

    /// <inheritdoc cref="T:Iesi.Collections.Generic.ISet`1" />
    public bool ContainsAll(ICollection<T> c)
    {
      foreach (T obj in (IEnumerable) c)
      {
        if (!this.Contains(obj))
          return false;
      }
      return true;
    }

    /// <inheritdoc cref="T:Iesi.Collections.Generic.ISet`1" />
    public bool AddAll(ICollection<T> c)
    {
      bool flag = false;
      foreach (T obj in (IEnumerable) c)
        flag |= this.Add(obj);
      return flag;
    }

    /// <inheritdoc cref="T:Iesi.Collections.Generic.ISet`1" />
    public bool RemoveAll(ICollection<T> c)
    {
      bool flag = false;
      foreach (T obj in (IEnumerable) c)
        flag |= this.Remove(obj);
      return flag;
    }

    /// <inheritdoc cref="T:Iesi.Collections.Generic.ISet`1" />
    public bool RetainAll(ICollection<T> c)
    {
      Iesi.Collections.Generic.HashSet<T> cSet = new Iesi.Collections.Generic.HashSet<T>((IEnumerable<T>) c);
      return this.RemoveWhere((Predicate<T>) (o => !cSet.Contains(o))) > 0;
    }

    /// <inheritdoc cref="T:Iesi.Collections.Generic.ISet`1" />
    public bool IsEmpty => this.Count == 0;

    bool ISet.Contains(object o) => this.Contains((T) o);

    bool ISet.ContainsAll(ICollection c)
    {
      int num1 = 1;
      IEnumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = c.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_19;
          default:
            goto label_2;
        }
      }
label_2:
      bool flag;
      try
      {
label_7:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_8;
label_4:
        T current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              goto label_7;
            case 2:
              goto label_20;
            case 4:
              goto label_19;
            case 5:
              goto label_10;
            case 6:
              if (this.Contains(current))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
                continue;
              }
              break;
          }
          flag = false;
          num2 = 2;
        }
label_8:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 4;
        goto label_4;
label_10:
        current = (T) enumerator.Current;
        num2 = 6;
        goto label_4;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_17;
            case 2:
              disposable.Dispose();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
              continue;
            default:
              if (disposable != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 2 : 1;
                continue;
              }
              goto label_17;
          }
        }
label_17:;
      }
label_20:
      return flag;
label_19:
      return true;
    }

    bool ISet.Add(object o) => this.Add((T) o);

    bool ISet.AddAll(ICollection c)
    {
      int num1 = 3;
      bool flag;
      IEnumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            enumerator = c.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
            continue;
          case 3:
            flag = false;
            num1 = 2;
            continue;
          default:
            goto label_15;
        }
      }
label_2:
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_6;
label_3:
        T current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              flag |= this.Add(current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_15;
            default:
              goto label_7;
          }
        }
label_6:
        num2 = 3;
        goto label_3;
label_7:
        current = (T) enumerator.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        {
          num2 = 2;
          goto label_3;
        }
        else
          goto label_3;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num3 = 2;
        while (true)
        {
          switch (num3)
          {
            case 1:
              disposable.Dispose();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            case 2:
              if (disposable != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
                continue;
              }
              goto label_14;
            default:
              goto label_14;
          }
        }
label_14:;
      }
label_15:
      return flag;
    }

    bool ISet.Remove(object o) => this.Remove((T) o);

    bool ISet.RemoveAll(ICollection c)
    {
      int num1 = 3;
      bool flag;
      IEnumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            enumerator = c.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
            continue;
          case 3:
            flag = false;
            num1 = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return flag;
label_5:
      try
      {
label_10:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_11;
label_6:
        T current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_2;
            case 2:
              flag |= this.Remove(current);
              num2 = 3;
              continue;
            case 3:
              goto label_10;
            default:
              goto label_7;
          }
        }
label_7:
        current = (T) enumerator.Current;
        num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        {
          num2 = 2;
          goto label_6;
        }
        else
          goto label_6;
label_11:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
        goto label_6;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num3 = 2;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_17;
            case 2:
              if (disposable != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                continue;
              }
              goto label_17;
            default:
              disposable.Dispose();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
              continue;
          }
        }
label_17:;
      }
    }

    bool ISet.RetainAll(ICollection c)
    {
      int num = 1;
      Iesi.Collections.Generic.HashSet<T> cSet;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            cSet = new Iesi.Collections.Generic.HashSet<T>((IEnumerable<T>) c);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 2;
            continue;
        }
      }
label_3:
      return this.RemoveWhere((Predicate<T>) (o => !cSet.Contains(o))) > 0;
    }

    internal static bool GGEcZaWp3b6oo8964IoI() => IesiSortedSet<T>.bW9vdCWpNx9iVbI0R7rX == null;

    internal static object zM2si7Wpp83gE0VxlmEF() => IesiSortedSet<T>.bW9vdCWpNx9iVbI0R7rX;
  }
}
