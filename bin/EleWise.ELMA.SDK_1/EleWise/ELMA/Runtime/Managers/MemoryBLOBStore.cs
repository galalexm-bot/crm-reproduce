// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.MemoryBLOBStore
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Concurrent;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Хранение блобов в памяти</summary>
  public class MemoryBLOBStore : IBLOBStore
  {
    private readonly ConcurrentDictionary<string, byte[]> dictionary;
    internal static MemoryBLOBStore AuBpoyWJfmnuOnnYW5yC;

    public void Save(string key, byte[] value)
    {
      int num = 3;
      byte[] value1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.dictionary.AddOrUpdate(key, value1, (Func<string, byte[], byte[]>) ((s, bytes) => value1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          case 2:
            value1 = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
            continue;
          case 3:
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    public byte[] LoadOrNull(string key)
    {
      int num = 1;
      byte[] numArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.dictionary.TryGetValue(key, out numArray);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return numArray;
    }

    public void Remove(string key)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.dictionary.TryRemove(key, out byte[] _);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public MemoryBLOBStore()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.dictionary = new ConcurrentDictionary<string, byte[]>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DVMbE8WJQB1Pf1pXKlC9() => MemoryBLOBStore.AuBpoyWJfmnuOnnYW5yC == null;

    internal static MemoryBLOBStore g1YVBoWJCRw6He4TMRfN() => MemoryBLOBStore.AuBpoyWJfmnuOnnYW5yC;
  }
}
