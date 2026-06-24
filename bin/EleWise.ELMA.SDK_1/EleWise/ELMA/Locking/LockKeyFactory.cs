// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.LockKeyFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Locking
{
  /// <inheritdoc />
  [Service(EnableInterceptors = false, InjectProperties = false)]
  internal sealed class LockKeyFactory : ILockKeyFactory
  {
    private readonly IDictionary<string, LockKeyFactory.KeyObject> pool;
    private readonly SemaphoreSlim poolLock;
    internal static LockKeyFactory pO5Ytfhrkgnce4XoW9PB;

    /// <inheritdoc />
    public IDisposable Get(string keyName)
    {
      IDisposable disposable;
      switch (1)
      {
        case 1:
          try
          {
            LockKeyFactory.LKDsMPhr2Tl4IbjMZqK6((object) this.poolLock);
            int num = 3;
            LockKeyFactory.KeyObject keyObject;
            while (true)
            {
              switch (num)
              {
                case 1:
                case 5:
                  this.pool.Add(keyName, keyObject = new LockKeyFactory.KeyObject(keyName, this));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 4 : 4;
                  continue;
                case 2:
                  goto label_1;
                case 3:
                  if (!this.pool.TryGetValue(keyName, out keyObject))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
                    continue;
                  }
                  goto case 6;
                case 6:
                  LockKeyFactory.XhRqguhrel9TNWeloduX((object) keyObject);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                  continue;
                default:
                  disposable = (IDisposable) keyObject;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 2;
                  continue;
              }
            }
          }
          finally
          {
            LockKeyFactory.aBiQ6IhrPPV9PxQcsd7R((object) this.poolLock);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
      }
label_1:
      return disposable;
    }

    public LockKeyFactory()
    {
      LockKeyFactory.hqhiXIhr1kDpdQ0lH7LC();
      this.pool = (IDictionary<string, LockKeyFactory.KeyObject>) new Dictionary<string, LockKeyFactory.KeyObject>();
      this.poolLock = new SemaphoreSlim(1, 1);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void LKDsMPhr2Tl4IbjMZqK6([In] object obj0) => ((SemaphoreSlim) obj0).Wait();

    internal static void XhRqguhrel9TNWeloduX([In] object obj0) => ((LockKeyFactory.KeyObject) obj0).AddRef();

    internal static int aBiQ6IhrPPV9PxQcsd7R([In] object obj0) => ((SemaphoreSlim) obj0).Release();

    internal static bool WpiFpMhrncHPYwH6QD97() => LockKeyFactory.pO5Ytfhrkgnce4XoW9PB == null;

    internal static LockKeyFactory TOMesBhrO4PCVsSiGI9d() => LockKeyFactory.pO5Ytfhrkgnce4XoW9PB;

    internal static void hqhiXIhr1kDpdQ0lH7LC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Ключ блокировки</summary>
    private sealed class KeyObject : IDisposable
    {
      private readonly object keyName;
      private readonly object lockKeyFactory;
      private long keyCount;
      private static object hSHgHXv7qbHKaIhI2ux3;

      /// <summary>Ctor</summary>
      /// <param name="keyName">Название ключа</param>
      /// <param name="lockKeyFactory">Фабрика ключей блокировок</param>
      public KeyObject(string keyName, LockKeyFactory lockKeyFactory)
      {
        LockKeyFactory.KeyObject.S6Sy5ev7Tkp6CiMAmCxc();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.keyName = (object) keyName;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            case 2:
              this.keyCount = 1L;
              num = 3;
              continue;
            case 3:
              goto label_3;
            default:
              this.lockKeyFactory = (object) lockKeyFactory;
              num = 2;
              continue;
          }
        }
label_3:;
      }

      /// <summary>Добавить ссылку</summary>
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void AddRef()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              Interlocked.Increment(ref this.keyCount);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public void Dispose()
      {
        switch (1)
        {
          case 1:
            try
            {
              ((LockKeyFactory) this.lockKeyFactory).poolLock.Wait();
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
                num = 0;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    ((LockKeyFactory) this.lockKeyFactory).pool.Remove((string) this.keyName);
                    num = 2;
                    continue;
                  case 2:
                    goto label_7;
                  case 3:
                    goto label_4;
                  default:
                    if (Interlocked.Decrement(ref this.keyCount) != 0L)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 3 : 0;
                      continue;
                    }
                    goto case 1;
                }
              }
label_7:
              break;
label_4:
              break;
            }
            finally
            {
              LockKeyFactory.KeyObject.qG6p6Kv7kjQkw6yJbmw8((object) ((LockKeyFactory) this.lockKeyFactory).poolLock);
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                num = 0;
              switch (num)
              {
                default:
              }
            }
        }
      }

      /// <summary>Equals</summary>
      public override bool Equals(object obj)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(obj is LockKeyFactory.KeyObject keyObject))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return false;
label_5:
        return LockKeyFactory.KeyObject.RqJJfvv7nabeo5C0N01e(keyObject.keyName, this.keyName);
      }

      /// <summary>HashCode</summary>
      public override int GetHashCode() => this.keyName.GetHashCode();

      internal static void S6Sy5ev7Tkp6CiMAmCxc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool HB0dBxv7Kl3ot4Z5meUb() => LockKeyFactory.KeyObject.hSHgHXv7qbHKaIhI2ux3 == null;

      internal static LockKeyFactory.KeyObject eJRl7vv7XTOSikr5m5Gb() => (LockKeyFactory.KeyObject) LockKeyFactory.KeyObject.hSHgHXv7qbHKaIhI2ux3;

      internal static int qG6p6Kv7kjQkw6yJbmw8([In] object obj0) => ((SemaphoreSlim) obj0).Release();

      internal static bool RqJJfvv7nabeo5C0N01e([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;
    }
  }
}
