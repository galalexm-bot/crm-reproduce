// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.NHCacheBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Locking;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Cache;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.Caching;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>Базовый класс кэша</summary>
  public abstract class NHCacheBase : CacheBase
  {
    private ILockService lockService;
    private readonly MemoryCache locks;
    private static NHCacheBase Cd45adWpiHd5arcgOfuP;

    /// <summary>Сервис блокировок</summary>
    protected ILockService LockService
    {
      get
      {
        int num = 1;
        ILockService service;
        ILockService lockService;
        while (true)
        {
          switch (num)
          {
            case 1:
              lockService = this.lockService;
              if (lockService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.lockService = service = Locator.GetService<ILockService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return lockService;
label_6:
        return service;
      }
    }

    /// <summary>Получить информацию лока по ключу</summary>
    /// <param name="key">Ключ</param>
    /// <returns>Информация</returns>
    protected virtual NHCacheBase.LockInfo GetLockInfo(object key)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            NHCacheBase.MEJnUcWpXqfdKUWBYkUe(key, NHCacheBase.BZpZBKWpK0lTfZQWYHoa(-1858887263 ^ -1858939391));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      NHCacheBase.LockInfo lockInfo = new NHCacheBase.LockInfo();
      NHCacheBase.cZKEXFWpT4IKAbweprji((object) lockInfo, (object) key.ToString());
      return lockInfo;
    }

    /// <inheritdoc />
    public override object Lock(object key)
    {
      int num = 3;
      NHCacheBase.LockInfo lockInfo;
      ILock @lock;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            @lock = this.LockService.AcquireLock(lockInfo.Key, lockInfo.Ttl, lockInfo.Timeout);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
            continue;
          case 3:
            lockInfo = this.GetLockInfo(key);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 2;
            continue;
          default:
            NHCacheBase.gVWPWTWpnSeBLxvrlfPC((object) this.locks, NHCacheBase.tnujM9Wpk7yBV398w1CV((object) lockInfo), (object) @lock);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
        }
      }
label_2:
      return (object) lockInfo;
    }

    /// <inheritdoc />
    public override void Unlock(object key, object lockValue)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        NHCacheBase.LockInfo lockInfo;
        ILock @lock;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              goto label_3;
            case 2:
              if (@lock != null)
              {
                @lock.Dispose();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            case 3:
              @lock = NHCacheBase.lJC6HXWpO0FhBYcDb0Yy((object) this.locks, NHCacheBase.tnujM9Wpk7yBV398w1CV((object) lockInfo), (object) null) as ILock;
              num2 = 2;
              continue;
            case 4:
              goto label_5;
            default:
              goto label_10;
          }
        }
label_5:
        lockInfo = lockValue as NHCacheBase.LockInfo;
        num1 = 3;
      }
label_4:
      return;
label_3:
      return;
label_10:;
    }

    /// <inheritdoc />
    public virtual void Unlock(object key)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Unlock(key, (Action<NHCacheBase.LockInfo>) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Разблокировать кэш</summary>
    /// <param name="key">Ключ</param>
    /// <param name="lockNotFound">Callback, если разблокируемый ключ не найден</param>
    protected virtual void Unlock(object key, Action<NHCacheBase.LockInfo> lockNotFound)
    {
      NHCacheBase.LockInfo lockInfo = this.GetLockInfo(key);
      if (!(this.locks.Remove(lockInfo.Key, (string) null) is ILock @lock))
      {
        if (lockNotFound == null)
          return;
        lockNotFound(lockInfo);
      }
      else
        @lock.Dispose();
    }

    protected NHCacheBase()
    {
      NHCacheBase.BV4lAxWp2UvaUs5OyF64();
      this.locks = new MemoryCache((string) NHCacheBase.BZpZBKWpK0lTfZQWYHoa(1581325282 << 3 ^ -234174542));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jHW8pWWpR9CopjNIkhlA() => NHCacheBase.Cd45adWpiHd5arcgOfuP == null;

    internal static NHCacheBase vd1fiaWpqn1r8O1dy1Ys() => NHCacheBase.Cd45adWpiHd5arcgOfuP;

    internal static object BZpZBKWpK0lTfZQWYHoa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void MEJnUcWpXqfdKUWBYkUe([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void cZKEXFWpT4IKAbweprji([In] object obj0, [In] object obj1) => ((NHCacheBase.LockInfo) obj0).Key = (string) obj1;

    internal static object tnujM9Wpk7yBV398w1CV([In] object obj0) => (object) ((NHCacheBase.LockInfo) obj0).Key;

    internal static void gVWPWTWpnSeBLxvrlfPC([In] object obj0, [In] object obj1, [In] object obj2) => ((ObjectCache) obj0)[(string) obj1] = obj2;

    internal static object lJC6HXWpO0FhBYcDb0Yy([In] object obj0, [In] object obj1, [In] object obj2) => ((ObjectCache) obj0).Remove((string) obj1, (string) obj2);

    internal static void BV4lAxWp2UvaUs5OyF64() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Информация о блокировке кэша</summary>
    public class LockInfo
    {
      internal static NHCacheBase.LockInfo DwsvGGQJoEhykYSt5kfv;

      /// <summary>Время жизни</summary>
      public TimeSpan? Ttl { get; set; }

      /// <summary>Таймаут</summary>
      public TimeSpan? Timeout { get; set; }

      /// <summary>Ключ</summary>
      public string Key
      {
        get => this.\u003CKey\u003Ek__BackingField;
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
                this.\u003CKey\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
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

      public LockInfo()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool n39Ia5QJb4ROSagMW5PG() => NHCacheBase.LockInfo.DwsvGGQJoEhykYSt5kfv == null;

      internal static NHCacheBase.LockInfo PEckbYQJhi50e3EKRSgk() => NHCacheBase.LockInfo.DwsvGGQJoEhykYSt5kfv;
    }
  }
}
