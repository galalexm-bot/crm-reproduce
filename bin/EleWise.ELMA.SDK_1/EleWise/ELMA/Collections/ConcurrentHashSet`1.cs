// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.ConcurrentHashSet`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Collections
{
  /// <summary>Represent a thread-safe set of values</summary>
  /// <typeparam name="T"></typeparam>
  internal class ConcurrentHashSet<T> : 
    ISet<T>,
    ICollection<T>,
    IEnumerable<T>,
    IEnumerable,
    IReadOnlyCollection<T>
  {
    private readonly ConcurrentDictionary<T, byte> hashSet;
    private static object ufR1es0xPfwsk844TAK;

    /// <summary>ctor</summary>
    public ConcurrentHashSet()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.hashSet = new ConcurrentDictionary<T, byte>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>ctor</summary>
    /// <param name="collection">collection</param>
    public ConcurrentHashSet(IEnumerable<T> collection)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.NotNull((object) collection, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812001002));
      this.hashSet = new ConcurrentDictionary<T, byte>(collection.Select<T, KeyValuePair<T, byte>>((Func<T, KeyValuePair<T, byte>>) (i => new KeyValuePair<T, byte>(i, (byte) 0))));
    }

    /// <summary>ctor</summary>
    /// <param name="comparer">comparer</param>
    public ConcurrentHashSet(IEqualityComparer<T> comparer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.hashSet = new ConcurrentDictionary<T, byte>(comparer);
    }

    /// <summary>ctor</summary>
    /// <param name="collection">collection</param>
    /// 
    ///             /// <param name="comparer">comparer</param>
    public ConcurrentHashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.NotNull((object) collection, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633538803));
      this.hashSet = new ConcurrentDictionary<T, byte>(collection.Select<T, KeyValuePair<T, byte>>((Func<T, KeyValuePair<T, byte>>) (i => new KeyValuePair<T, byte>(i, (byte) 0))), comparer);
    }

    /// <summary>
    /// Adds an element to the current set and returns a value to indicate if the element was successfully added
    /// </summary>
    /// <param name="item">The element to add to the set</param>
    /// <returns>true if the element is added to the set</returns>
    public bool Add(T item) => this.hashSet.TryAdd(item, (byte) 0);

    /// <summary>Removes all elements a ConcurrentHashSet object</summary>
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
            this.hashSet.Clear();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
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
    /// Determines whether a object contains the specified element
    /// </summary>
    /// <param name="item">object</param>
    /// <returns>true if the object contains the specified element; otherwise, false</returns>
    public bool Contains(T item) => this.hashSet.ContainsKey(item);

    /// <summary>Removes the specified element from a object.</summary>
    /// <param name="item">object</param>
    /// <returns>true if the element is successfully found and removed; otherwise, false</returns>
    public bool Remove(T item) => this.hashSet.TryRemove(item, out byte _);

    /// <summary>Gets the number of elements contained</summary>
    public int Count => this.hashSet.Count;

    /// <summary>Gets a value indicating whether the is read-only</summary>
    public bool IsReadOnly => false;

    /// <summary>Adds an item</summary>
    /// <param name="item">The object to add</param>
    void ICollection<T>.Add(T item) => this.Add(item);

    /// <summary>Copies the elements</summary>
    /// <param name="array">The one-dimensional that is the destination of the elements copied</param>
    /// <param name="arrayIndex">The zero-based index in array at which copying begins</param>
    public void CopyTo(T[] array, int arrayIndex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.hashSet.Keys.CopyTo(array, arrayIndex);
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

    /// <summary>
    /// Modifies the current set so that it contains all elements that are present in the current set, in the specified collection, or in both
    /// </summary>
    /// <param name="other">The collection to compare to the current set</param>
    public void UnionWith(IEnumerable<T> other) => throw new NotImplementedException();

    /// <summary>
    /// Modifies the current set so that it contains only elements that are also in a specified collection
    /// </summary>
    /// <param name="other">The collection to compare to the current set</param>
    public void IntersectWith(IEnumerable<T> other) => throw new NotImplementedException();

    /// <summary>
    /// Removes all elements in the specified collection from the current set
    /// </summary>
    /// <param name="other">The collection of items to remove from the set</param>
    public void ExceptWith(IEnumerable<T> other) => throw new NotImplementedException();

    /// <summary>
    /// Modifies the current set so that it contains only elements that are present either in the current set or in the specified collection, but not both
    /// </summary>
    /// <param name="other">The collection to compare to the current set</param>
    public void SymmetricExceptWith(IEnumerable<T> other) => throw new NotImplementedException();

    /// <summary>
    /// Determines whether a set is a subset of a specified collection
    /// </summary>
    /// <param name="other">The collection to compare to the current set</param>
    /// <returns></returns>
    public bool IsSubsetOf(IEnumerable<T> other) => throw new NotImplementedException();

    /// <summary>
    /// Determines whether the current set is a superset of a specified collection
    /// </summary>
    /// <param name="other">The collection to compare to the current set</param>
    /// <returns>true if the current set is a superset of <paramref name="other">other</paramref>; otherwise, false</returns>
    public bool IsSupersetOf(IEnumerable<T> other) => throw new NotImplementedException();

    /// <summary>
    /// Determines whether the current set is a proper (strict) superset of a specified collection
    /// </summary>
    /// <param name="other">The collection to compare to the current set</param>
    /// <returns>true if the current set is a proper superset of <paramref name="other">other</paramref>; otherwise, false</returns>
    public bool IsProperSupersetOf(IEnumerable<T> other) => throw new NotImplementedException();

    /// <summary>
    /// Determines whether the current set is a proper (strict) subset of a specified collection
    /// </summary>
    /// <param name="other">The collection to compare to the current set</param>
    /// <returns>true if the current set is a proper subset of <paramref name="other">other</paramref>; otherwise, false</returns>
    public bool IsProperSubsetOf(IEnumerable<T> other) => throw new NotImplementedException();

    /// <summary>
    /// Determines whether the current set overlaps with the specified collection
    /// </summary>
    /// <param name="other">The collection to compare to the current set</param>
    /// <returns>true if the current set and <paramref name="other">other</paramref> share at least one common element; otherwise, false</returns>
    public bool Overlaps(IEnumerable<T> other) => throw new NotImplementedException();

    /// <summary>
    /// Determines whether the current set and the specified collection contain the same elements
    /// </summary>
    /// <param name="other">The collection to compare to the current set</param>
    /// <returns>true if the current set is equal to <paramref name="other">other</paramref>; otherwise, false</returns>
    public bool SetEquals(IEnumerable<T> other) => throw new NotImplementedException();

    /// <summary>
    /// Returns an enumerator that iterates through a collection
    /// </summary>
    /// <returns>An object that can be used to iterate through the collection</returns>
    public IEnumerator<T> GetEnumerator() => this.hashSet.Select<KeyValuePair<T, byte>, T>((Func<KeyValuePair<T, byte>, T>) (x => x.Key)).GetEnumerator();

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    internal static bool NiXWCS00vWrLdWaEP6k() => ConcurrentHashSet<T>.ufR1es0xPfwsk844TAK == null;

    internal static object JXBH5Y0m8Ey2dhLwbNL() => ConcurrentHashSet<T>.ufR1es0xPfwsk844TAK;
  }
}
