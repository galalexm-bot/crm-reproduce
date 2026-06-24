// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.UnionComplexCacheService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Cache
{
  [Service(EnableInterceptors = false, Type = ComponentType.Server)]
  public class UnionComplexCacheService : ComplexCacheServiceBase, IUnionComplexCacheService
  {
    private readonly string _timestampKey;
    private readonly string _timestampsKey;
    internal static UnionComplexCacheService clssTdfq6QiHBcYZZ0KN;

    public UnionComplexCacheService(
      ICacheService cacheService,
      IMemoryCacheService memoryCacheService,
      IContextBoundVariableService contextCacheService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this._timestampKey = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283204873);
      this._timestampsKey = (string) UnionComplexCacheService.lNt5ULfq74kyoXdQct0D(333888594 ^ 1075625116 ^ 1409238228);
      // ISSUE: explicit constructor call
      base.\u002Ector(cacheService, memoryCacheService, contextCacheService);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override void RefreshTimestamp(string timestampKey, string timestampRegionKey)
    {
      int num1 = 6;
      UnionComplexCacheService complexCacheService;
      string timestampKey1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_5;
          case 1:
            this.setTimestamps(timestampKey1, DateTime.Now.Ticks);
            num1 = 7;
            continue;
          case 2:
            timestampKey1 = timestampKey;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
            continue;
          case 3:
            this.UnitOfWorkManager.RegisterPostCommitAction((System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    complexCacheService.setTimestamps(timestampKey1, UnionComplexCacheService.\u003C\u003Ec__DisplayClass1_0.wTAjVI8YmQY6lpDkGRqE().Ticks);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_13;
          case 5:
            complexCacheService = this;
            num1 = 2;
            continue;
          case 6:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 5 : 2;
            continue;
          case 7:
            if (this.UnitOfWorkManager != null)
            {
              num1 = 8;
              continue;
            }
            goto label_2;
          case 8:
            if (!this.UnitOfWorkManager.HasActiveTransaction(""))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 4;
              continue;
            }
            goto case 3;
          default:
            goto label_14;
        }
      }
label_5:
      return;
label_13:
      return;
label_14:
      return;
label_2:;
    }

    protected SerializableDictionary<string, long> getTimestamps()
    {
      SerializableDictionary<string, long> timestamps;
      if (this._contextCacheService.TryGetValue<SerializableDictionary<string, long>>(this._timestampsKey, out timestamps))
        return timestamps;
      long num;
      this._cacheService.TryGetValue<long>(this._timestampKey, out num);
      ComplexCacheServiceBase.CacheEntry<SerializableDictionary<string, long>> result;
      if (this._memoryCacheService.TryGetValue<ComplexCacheServiceBase.CacheEntry<SerializableDictionary<string, long>>>(this._timestampsKey, out result) && result.Timestamp == num)
      {
        timestamps = result.Value;
      }
      else
      {
        if (!this._cacheService.TryGetValue<SerializableDictionary<string, long>>(this._timestampsKey, out timestamps))
          timestamps = new SerializableDictionary<string, long>();
        this._memoryCacheService.Insert<ComplexCacheServiceBase.CacheEntry<SerializableDictionary<string, long>>>(this._timestampsKey, new ComplexCacheServiceBase.CacheEntry<SerializableDictionary<string, long>>()
        {
          Timestamp = num,
          Value = timestamps
        });
      }
      this._contextCacheService.Set(this._timestampsKey, (object) timestamps);
      return timestamps;
    }

    private void setTimestamps(string timestampKey, long timestamp)
    {
      int num = 2;
      SerializableDictionary<string, long> serializableDictionary;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            serializableDictionary = new SerializableDictionary<string, long>((IDictionary<string, long>) this.getTimestamps());
            num = 5;
            continue;
          case 2:
            this._contextCacheService.Set<long>(timestampKey, "EleWise.ELMA.Cache.ComplexCacheService", timestamp);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
            continue;
          case 3:
            IMemoryCacheService memoryCacheService = this._memoryCacheService;
            string timestampsKey = this._timestampsKey;
            ComplexCacheServiceBase.CacheEntry<SerializableDictionary<string, long>> cacheEntry = new ComplexCacheServiceBase.CacheEntry<SerializableDictionary<string, long>>();
            UnionComplexCacheService.r8iAyAfq0G1eB2P40wwG((object) cacheEntry, timestamp);
            cacheEntry.Value = serializableDictionary;
            memoryCacheService.Insert<ComplexCacheServiceBase.CacheEntry<SerializableDictionary<string, long>>>(timestampsKey, cacheEntry);
            num = 7;
            continue;
          case 4:
            UnionComplexCacheService.h0HXpYfqxKg49cuBCf1I((object) this._contextCacheService, (object) this._timestampsKey, (object) serializableDictionary);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 6 : 6;
            continue;
          case 5:
            serializableDictionary[timestampKey] = timestamp;
            num = 4;
            continue;
          case 6:
            this._cacheService.Insert<long>(this._timestampKey, timestamp);
            num = 3;
            continue;
          case 7:
            this._cacheService.Insert<SerializableDictionary<string, long>>(this._timestampsKey, serializableDictionary);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
            continue;
          default:
            goto label_10;
        }
      }
label_2:
      return;
label_10:;
    }

    protected override bool TryGetFromGlobalCache<T>(
      string key,
      string timestampKey,
      string timestampRegionKey,
      out T value)
    {
      SerializableDictionary<string, long> timestamps = this.getTimestamps();
      long num1 = 0;
      long num2;
      timestamps.TryGetValue(timestampKey, out num2);
      if (timestampRegionKey != null)
        timestamps.TryGetValue(timestampRegionKey, out num1);
      ComplexCacheServiceBase.CacheEntry<T> result;
      if (this._memoryCacheService.TryGetValue<ComplexCacheServiceBase.CacheEntry<T>>(key, out result) && result.Timestamp == num2 && result.RegionTimestamp == num1)
      {
        value = result.Value;
        return true;
      }
      value = default (T);
      return false;
    }

    protected override void SaveToGlobalCache<T>(
      string key,
      string timestampKey,
      string timestampRegionKey,
      T value,
      TimeSpan? timeout)
    {
      SerializableDictionary<string, long> timestamps = this.getTimestamps();
      long num1 = 0;
      long num2;
      timestamps.TryGetValue(timestampKey, out num2);
      if (timestampRegionKey != null)
        timestamps.TryGetValue(timestampRegionKey, out num1);
      if (timeout.HasValue)
      {
        IMemoryCacheService memoryCacheService = this._memoryCacheService;
        string key1 = key;
        ComplexCacheServiceBase.CacheEntry<T> cacheEntry = new ComplexCacheServiceBase.CacheEntry<T>();
        cacheEntry.Timestamp = num2;
        cacheEntry.RegionTimestamp = num1;
        cacheEntry.Value = value;
        TimeSpan timeout1 = timeout.Value;
        memoryCacheService.Insert<ComplexCacheServiceBase.CacheEntry<T>>(key1, cacheEntry, timeout1);
      }
      else
        this._memoryCacheService.Insert<ComplexCacheServiceBase.CacheEntry<T>>(key, new ComplexCacheServiceBase.CacheEntry<T>()
        {
          Timestamp = num2,
          RegionTimestamp = num1,
          Value = value
        });
    }

    internal static object lNt5ULfq74kyoXdQct0D(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool M0kIT3fqH9IXrr9Qpeya() => UnionComplexCacheService.clssTdfq6QiHBcYZZ0KN == null;

    internal static UnionComplexCacheService qtIXprfqAQvNekq0Zrj5() => UnionComplexCacheService.clssTdfq6QiHBcYZZ0KN;

    internal static void h0HXpYfqxKg49cuBCf1I([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);

    internal static void r8iAyAfq0G1eB2P40wwG([In] object obj0, [In] long obj1) => ((ComplexCacheServiceBase.CacheEntry<SerializableDictionary<string, long>>) obj0).Timestamp = obj1;
  }
}
