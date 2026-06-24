// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.MemoryCacheService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Cache
{
  /// <summary>Реализация сервиса для кэширования в памяти</summary>
  [Service(EnableInterceptors = false, Type = ComponentType.Server)]
  public class MemoryCacheService : IMemoryCacheService
  {
    private readonly MemoryCache privateCache;
    private static MemoryCacheService F6VVuSfKT7lecTocaah5;

    public bool TryGetValue<T>(string key, out T result)
    {
      if (key == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889545248));
      result = default (T);
      CacheItem cacheItem = this.privateCache.GetCacheItem(key, (string) null);
      if (cacheItem != null)
      {
        object obj = cacheItem.Value;
        result = !(obj is MemoryCacheService.NullValue) ? (T) obj : default (T);
      }
      return cacheItem != null;
    }

    public bool Contains(string key)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (key == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574184944));
label_5:
      return MemoryCacheService.kPrMvVfKO3nn58aVUdOm((object) this.privateCache, (object) key, (object) null);
    }

    public void Insert<T>(string key, T value)
    {
      if (key == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195666251));
      this.Insert<T>(key, value, TimeSpan.Zero);
    }

    public void Insert<T>(string key, T value, TimeSpan timeout)
    {
      if (key == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751229376));
      object obj = (object) value ?? (object) MemoryCacheService.NullValue.Null;
      this.privateCache.Set(key, obj, timeout.Ticks > 0L ? DateTimeOffset.Now.Add(timeout) : ObjectCache.InfiniteAbsoluteExpiration, (string) null);
    }

    public void Remove(string key)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            MemoryCacheService.cxh54BfKeShbHGUxXeBm((object) this.privateCache, (object) key, (object) null);
            num = 3;
            continue;
          case 2:
            if (key != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 3:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new ArgumentNullException((string) MemoryCacheService.Swn6mIfK2X6TU80pMeEd(-606654180 ^ -606714180));
    }

    public void RemoveBySubkey(string subkey)
    {
      int num = 2;
      string subkey1;
      MemoryCacheService memoryCacheService;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            subkey1 = subkey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 4 : 3;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
            continue;
          case 3:
            if (subkey1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 6;
              continue;
            }
            goto label_5;
          case 4:
            memoryCacheService = this;
            num = 3;
            continue;
          case 5:
            goto label_5;
          case 6:
            this.privateCache.Where<KeyValuePair<string, object>>((Func<KeyValuePair<string, object>, bool>) (p => p.Key.Contains(subkey1))).ForEach<KeyValuePair<string, object>>((Action<KeyValuePair<string, object>>) (p => memoryCacheService.privateCache.Remove(p.Key, (string) null)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:
      return;
label_5:
      throw new ArgumentNullException((string) MemoryCacheService.Swn6mIfK2X6TU80pMeEd(654297945 ^ 653955053));
    }

    public MemoryCacheService()
    {
      MemoryCacheService.E0AFbLfKPvuBUA1GH9hM();
      this.privateCache = new MemoryCache("EleWise.ELMA.Cache.MemoryCacheService");
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool kPrMvVfKO3nn58aVUdOm([In] object obj0, [In] object obj1, [In] object obj2) => ((ObjectCache) obj0).Contains((string) obj1, (string) obj2);

    internal static bool zDHsCAfKk6FZGNW3pvQx() => MemoryCacheService.F6VVuSfKT7lecTocaah5 == null;

    internal static MemoryCacheService qSMdxRfKn05Vth7i8Jyb() => MemoryCacheService.F6VVuSfKT7lecTocaah5;

    internal static object Swn6mIfK2X6TU80pMeEd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object cxh54BfKeShbHGUxXeBm([In] object obj0, [In] object obj1, [In] object obj2) => ((ObjectCache) obj0).Remove((string) obj1, (string) obj2);

    internal static void E0AFbLfKPvuBUA1GH9hM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Пустое значение в кеше</summary>
    [Serializable]
    internal struct NullValue
    {
      public static readonly MemoryCacheService.NullValue Null;
      [UsedImplicitly]
      private byte value;
      internal static object aY9shu8LVeL0kR47jtsu;

      private unsafe NullValue(byte value)
      {
        MemoryCacheService.NullValue.JGwCfA8LRxDBGyiCyNrc();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
          goto label_3;
label_1:
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this.value = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 0;
              continue;
            default:
              *(MemoryCacheService.NullValue*) ref this = new MemoryCacheService.NullValue();
              num = 2;
              continue;
          }
        }
label_2:
        return;
label_3:
        num = 0;
        goto label_1;
      }

      static NullValue()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              MemoryCacheService.NullValue.Null = new MemoryCacheService.NullValue((byte) 0);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            case 2:
              MemoryCacheService.NullValue.JGwCfA8LRxDBGyiCyNrc();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static void JGwCfA8LRxDBGyiCyNrc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool l1xuUG8LS6PB13tRU8ig() => MemoryCacheService.NullValue.aY9shu8LVeL0kR47jtsu == null;

      internal static object jfGsLS8LiccWt1el3XpX() => MemoryCacheService.NullValue.aY9shu8LVeL0kR47jtsu;
    }
  }
}
