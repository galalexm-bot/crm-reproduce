// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.MultiKeyDictionary`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EleWise.ELMA.Collections
{
  /// <summary>Multi-Key Dictionary Class</summary>
  /// <typeparam name="K">Primary Key Type</typeparam>
  /// <typeparam name="L">Sub Key Type</typeparam>
  /// <typeparam name="V">Value Type</typeparam>
  public class MultiKeyDictionary<K, L, V> : 
    IDictionary<K, V>,
    ICollection<KeyValuePair<K, V>>,
    IEnumerable<KeyValuePair<K, V>>,
    IEnumerable
  {
    internal readonly Dictionary<K, V> baseDictionary;
    internal readonly Dictionary<L, K> subDictionary;
    internal readonly Dictionary<K, L> primaryToSubkeyMapping;
    private readonly ReaderWriterLockSlim readerWriterLock;
    private static object en7F07mIOtOoowpqNrH;

    public V this[L subKey]
    {
      get
      {
        V val;
        if (this.TryGetValue(subKey, out val))
          return val;
        throw new KeyNotFoundException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837638465) + subKey.ToString());
      }
    }

    public V this[K primaryKey]
    {
      get
      {
        V val;
        if (this.TryGetValue(primaryKey, out val))
          return val;
        throw new KeyNotFoundException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479475546) + primaryKey.ToString());
      }
    }

    public void Associate(L subKey, K primaryKey)
    {
      this.readerWriterLock.EnterUpgradeableReadLock();
      try
      {
        if (!this.baseDictionary.ContainsKey(primaryKey))
          throw new KeyNotFoundException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218455410), (object) primaryKey));
        if (this.primaryToSubkeyMapping.ContainsKey(primaryKey))
        {
          this.readerWriterLock.EnterWriteLock();
          try
          {
            if (this.subDictionary.ContainsKey(this.primaryToSubkeyMapping[primaryKey]))
              this.subDictionary.Remove(this.primaryToSubkeyMapping[primaryKey]);
            this.primaryToSubkeyMapping.Remove(primaryKey);
          }
          finally
          {
            this.readerWriterLock.ExitWriteLock();
          }
        }
        this.subDictionary[subKey] = primaryKey;
        this.primaryToSubkeyMapping[primaryKey] = subKey;
      }
      finally
      {
        this.readerWriterLock.ExitUpgradeableReadLock();
      }
    }

    public bool TryGetValue(L subKey, out V val)
    {
      val = default (V);
      this.readerWriterLock.EnterReadLock();
      try
      {
        K key;
        if (this.subDictionary.TryGetValue(subKey, out key))
          return this.baseDictionary.TryGetValue(key, out val);
      }
      finally
      {
        this.readerWriterLock.ExitReadLock();
      }
      return false;
    }

    bool IDictionary<K, V>.Remove(K key) => this.baseDictionary.Remove(key);

    public bool TryGetValue(K primaryKey, out V val)
    {
      this.readerWriterLock.EnterReadLock();
      try
      {
        return this.baseDictionary.TryGetValue(primaryKey, out val);
      }
      finally
      {
        this.readerWriterLock.ExitReadLock();
      }
    }

    V IDictionary<K, V>.this[K key]
    {
      get => this.baseDictionary[key];
      set => this.Add(key, value);
    }

    public bool ContainsKey(L subKey) => this.TryGetValue(subKey, out V _);

    public bool ContainsKey(K primaryKey) => this.TryGetValue(primaryKey, out V _);

    public void Remove(K primaryKey)
    {
      this.readerWriterLock.EnterWriteLock();
      try
      {
        if (this.primaryToSubkeyMapping.ContainsKey(primaryKey))
        {
          if (this.subDictionary.ContainsKey(this.primaryToSubkeyMapping[primaryKey]))
            this.subDictionary.Remove(this.primaryToSubkeyMapping[primaryKey]);
          this.primaryToSubkeyMapping.Remove(primaryKey);
        }
        this.baseDictionary.Remove(primaryKey);
      }
      finally
      {
        this.readerWriterLock.ExitWriteLock();
      }
    }

    public void Remove(L subKey)
    {
      this.readerWriterLock.EnterWriteLock();
      try
      {
        this.baseDictionary.Remove(this.subDictionary[subKey]);
        this.primaryToSubkeyMapping.Remove(this.subDictionary[subKey]);
        this.subDictionary.Remove(subKey);
      }
      finally
      {
        this.readerWriterLock.ExitWriteLock();
      }
    }

    public void Add(K primaryKey, V val)
    {
      this.readerWriterLock.EnterWriteLock();
      try
      {
        this.baseDictionary.Add(primaryKey, val);
      }
      finally
      {
        this.readerWriterLock.ExitWriteLock();
      }
    }

    public void Add(K primaryKey, L subKey, V val)
    {
      this.Add(primaryKey, val);
      this.Associate(subKey, primaryKey);
    }

    public V[] CloneValues()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.readerWriterLock.EnterReadLock();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      V[] vArray;
      return vArray;
label_3:
      try
      {
        V[] array = new V[this.baseDictionary.Values.Count];
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.baseDictionary.Values.CopyTo(array, 0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 2;
              continue;
            case 2:
              vArray = array;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
      }
      finally
      {
        this.readerWriterLock.ExitReadLock();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public ICollection<K> Keys => (ICollection<K>) this.baseDictionary.Keys;

    ICollection<V> IDictionary<K, V>.Values => (ICollection<V>) this.baseDictionary.Values;

    public List<V> Values
    {
      get
      {
        this.readerWriterLock.EnterReadLock();
        try
        {
          return this.baseDictionary.Values.ToList<V>();
        }
        finally
        {
          this.readerWriterLock.ExitReadLock();
        }
      }
    }

    public K[] ClonePrimaryKeys()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.readerWriterLock.EnterReadLock();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      K[] kArray;
      return kArray;
label_4:
      try
      {
        K[] array = new K[this.baseDictionary.Keys.Count];
        int num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              kArray = array;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            case 2:
              this.baseDictionary.Keys.CopyTo(array, 0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
              continue;
            default:
              goto label_2;
          }
        }
      }
      finally
      {
        this.readerWriterLock.ExitReadLock();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public L[] CloneSubKeys()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            this.readerWriterLock.EnterReadLock();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      L[] lArray;
      return lArray;
label_4:
      try
      {
        L[] array = new L[this.subDictionary.Keys.Count];
        int num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              this.subDictionary.Keys.CopyTo(array, 0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            default:
              lArray = array;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
              continue;
          }
        }
      }
      finally
      {
        this.readerWriterLock.ExitReadLock();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public void Clear()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            goto label_3;
          case 2:
            this.readerWriterLock.EnterWriteLock();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 1;
            continue;
          default:
            goto label_9;
        }
      }
label_13:
      return;
label_9:
      return;
label_3:
      try
      {
        this.baseDictionary.Clear();
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.subDictionary.Clear();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            default:
              this.primaryToSubkeyMapping.Clear();
              num2 = 2;
              continue;
          }
        }
label_6:;
      }
      finally
      {
        this.readerWriterLock.ExitWriteLock();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public int Count
    {
      get
      {
        int num1 = 2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_4;
            case 2:
              this.readerWriterLock.EnterReadLock();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        int count;
        return count;
label_4:
        try
        {
          count = this.baseDictionary.Count;
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
            num2 = 0;
          switch (num2)
          {
            default:
              goto label_3;
          }
        }
        finally
        {
          this.readerWriterLock.ExitReadLock();
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
            num3 = 0;
          switch (num3)
          {
            default:
          }
        }
      }
    }

    public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
    {
      this.readerWriterLock.EnterReadLock();
      try
      {
        return (IEnumerator<KeyValuePair<K, V>>) this.baseDictionary.GetEnumerator();
      }
      finally
      {
        this.readerWriterLock.ExitReadLock();
      }
    }

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable) this.baseDictionary).GetEnumerator();

    void ICollection<KeyValuePair<K, V>>.Add(KeyValuePair<K, V> item) => this.Add(item.Key, item.Value);

    bool ICollection<KeyValuePair<K, V>>.Contains(KeyValuePair<K, V> item)
    {
      this.readerWriterLock.EnterReadLock();
      try
      {
        return this.baseDictionary.Contains<KeyValuePair<K, V>>(item);
      }
      finally
      {
        this.readerWriterLock.ExitReadLock();
      }
    }

    void ICollection<KeyValuePair<K, V>>.CopyTo(KeyValuePair<K, V>[] array, int arrayIndex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ((ICollection<KeyValuePair<K, V>>) this.baseDictionary).CopyTo(array, arrayIndex);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    bool ICollection<KeyValuePair<K, V>>.Remove(KeyValuePair<K, V> item)
    {
      this.Remove(item.Key);
      return true;
    }

    bool ICollection<KeyValuePair<K, V>>.IsReadOnly => false;

    public MultiKeyDictionary()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.baseDictionary = new Dictionary<K, V>();
      this.subDictionary = new Dictionary<L, K>();
      this.primaryToSubkeyMapping = new Dictionary<K, L>();
      this.readerWriterLock = new ReaderWriterLockSlim();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool c5QGF1mVmoCyqI6ej0O() => MultiKeyDictionary<K, L, V>.en7F07mIOtOoowpqNrH == null;

    internal static object xxs14kmSBk5aete92Ck() => MultiKeyDictionary<K, L, V>.en7F07mIOtOoowpqNrH;
  }
}
