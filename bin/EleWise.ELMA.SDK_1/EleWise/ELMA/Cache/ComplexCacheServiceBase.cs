// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ComplexCacheServiceBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Cache
{
  public abstract class ComplexCacheServiceBase
  {
    /// <summary>Имя региона контекстного кэша</summary>
    protected const string ContextCacheServiceRegion = "EleWise.ELMA.Cache.ComplexCacheService";
    protected ICacheService _cacheService;
    protected IMemoryCacheService _memoryCacheService;
    protected IContextBoundVariableService _contextCacheService;
    private IUnitOfWorkManager _unitOfWorkManager;
    internal static ComplexCacheServiceBase xDtsITfqfFhfDXK00uAv;

    protected ComplexCacheServiceBase(
      ICacheService cacheService,
      IMemoryCacheService memoryCacheService,
      IContextBoundVariableService contextCacheService)
    {
      ComplexCacheServiceBase.fp6yx4fqv8e6IhPCpNPd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (cacheService != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 2:
            this._memoryCacheService = memoryCacheService;
            num1 = 7;
            continue;
          case 3:
            goto label_4;
          case 4:
            goto label_6;
          case 5:
            goto label_11;
          case 6:
            goto label_14;
          case 7:
            this._contextCacheService = contextCacheService;
            num1 = 3;
            continue;
          default:
            if (memoryCacheService != null)
              goto label_15;
            else
              goto label_13;
label_2:
            int num2;
            num1 = num2;
            continue;
label_13:
            num2 = 6;
            goto label_2;
label_15:
            if (contextCacheService != null)
            {
              this._cacheService = cacheService;
              num2 = 2;
              goto label_2;
            }
            else
            {
              num1 = 4;
              continue;
            }
        }
      }
label_4:
      return;
label_6:
      throw new ArgumentNullException((string) ComplexCacheServiceBase.MosiNWfq8x3WwHKKqRRl(-35995181 ^ -35683657));
label_11:
      throw new ArgumentNullException((string) ComplexCacheServiceBase.MosiNWfq8x3WwHKKqRRl(-16752921 ^ -16441913));
label_14:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -233989076));
    }

    public virtual T GetOrAdd<T>(string key, string timestampKey, Func<T> valueAccessor) => this.GetOrAdd<T>(key, timestampKey, (string) null, valueAccessor, new TimeSpan?());

    public virtual T GetOrAdd<T>(
      string key,
      string timestampKey,
      Func<T> valueAccessor,
      TimeSpan timeout)
    {
      return this.GetOrAdd<T>(key, timestampKey, (string) null, valueAccessor, new TimeSpan?(timeout));
    }

    public virtual T GetOrAdd<T>(
      string key,
      string timestampKey,
      string timestampRegionKey,
      Func<T> valueAccessor)
    {
      return this.GetOrAdd<T>(key, timestampKey, timestampRegionKey, valueAccessor, new TimeSpan?());
    }

    public virtual T GetOrAdd<T>(
      string key,
      string timestampKey,
      string timestampRegionKey,
      Func<T> valueAccessor,
      TimeSpan timeout)
    {
      return this.GetOrAdd<T>(key, timestampKey, timestampRegionKey, valueAccessor, new TimeSpan?(timeout));
    }

    protected virtual T GetOrAdd<T>(
      string key,
      string timestampKey,
      string timestampRegionKey,
      Func<T> valueAccessor,
      TimeSpan? timeout)
    {
      if (string.IsNullOrEmpty(key))
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883402128));
      if (string.IsNullOrEmpty(timestampKey))
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669715557));
      if (valueAccessor == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727014172));
      T orAdd;
      if (this.TryGetFromContextCache<T>(key, timestampKey, timestampRegionKey, out orAdd))
        return orAdd;
      if (!this.TryGetFromGlobalCache<T>(key, timestampKey, timestampRegionKey, out orAdd))
      {
        orAdd = valueAccessor();
        this.SaveToGlobalCache<T>(key, timestampKey, timestampRegionKey, orAdd, timeout);
      }
      this.SaveToContextCache<T>(key, timestampKey, timestampRegionKey, orAdd);
      return orAdd;
    }

    public virtual void RefreshTimestamp(string timestampKey)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComplexCacheServiceBase.PwtUxGfqZDmpBHvlNQh9((object) this, (object) timestampKey, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public virtual void RefreshTimestamp(string timestampKey, string timestampRegionKey)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        DateTime now;
        long ticks1;
        ComplexCacheServiceBase cacheServiceBase;
        string timestampKey1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ticks1 = now.Ticks;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 0;
              continue;
            case 2:
              this._contextCacheService.Set<long>(timestampKey1, "EleWise.ELMA.Cache.ComplexCacheService", ticks1);
              num2 = 3;
              continue;
            case 3:
              this._cacheService.Insert<long>(timestampKey1, ticks1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            case 4:
              now = DateTime.Now;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
              continue;
            case 5:
              timestampKey1 = timestampKey;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 4 : 3;
              continue;
            case 6:
              goto label_12;
            case 7:
              goto label_3;
            case 8:
              cacheServiceBase = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 5;
              continue;
            case 9:
              num2 = 8;
              continue;
            case 10:
              ComplexCacheServiceBase.yTLSpxfqIFu8xCB0nkri((object) this.UnitOfWorkManager, (object) (System.Action) (() =>
              {
                int num3 = 2;
                long ticks2;
                DateTime dateTime;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      ticks2 = dateTime.Ticks;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 2 : 4;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      dateTime = ComplexCacheServiceBase.\u003C\u003Ec__DisplayClass8_0.fn8l498YHx582MY78aXP();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
                      continue;
                    case 3:
                      goto label_2;
                    case 4:
                      cacheServiceBase._contextCacheService.Set<long>(timestampKey1, "EleWise.ELMA.Cache.ComplexCacheService", ticks2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                      continue;
                    default:
                      cacheServiceBase._cacheService.Insert<long>(timestampKey1, ticks2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 3;
                      continue;
                  }
                }
label_2:;
              }));
              num2 = 7;
              continue;
            default:
              if (this.UnitOfWorkManager != null)
              {
                num2 = 6;
                continue;
              }
              goto label_16;
          }
        }
label_12:
        if (ComplexCacheServiceBase.UcOxcrfquSYVrKRZ7kFo((object) this.UnitOfWorkManager, (object) ""))
          num1 = 10;
        else
          goto label_17;
      }
label_3:
      return;
label_16:
      return;
label_17:;
    }

    public virtual void RefreshTimestampRegion(string timestampRegionKey)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComplexCacheServiceBase.PwtUxGfqZDmpBHvlNQh9((object) this, (object) timestampRegionKey, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected IUnitOfWorkManager UnitOfWorkManager
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this._unitOfWorkManager != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              this._unitOfWorkManager = !ComplexCacheServiceBase.FH8UZOfqV3488GES9YYj() ? (IUnitOfWorkManager) null : Locator.GetService<IUnitOfWorkManager>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 3 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return this._unitOfWorkManager;
      }
    }

    protected virtual bool TryGetFromGlobalCache<T>(
      string key,
      string timestampKey,
      string timestampRegionKey,
      out T value)
    {
      long num1 = 0;
      long num2;
      this._cacheService.TryGetValue<long>(timestampKey, out num2);
      if (timestampRegionKey != null)
        this._cacheService.TryGetValue<long>(timestampRegionKey, out num1);
      ComplexCacheServiceBase.CacheEntry<T> result;
      if (this._memoryCacheService.TryGetValue<ComplexCacheServiceBase.CacheEntry<T>>(key, out result) && result.Timestamp == num2 && result.RegionTimestamp == num1)
      {
        value = result.Value;
        return true;
      }
      value = default (T);
      return false;
    }

    protected virtual void SaveToGlobalCache<T>(
      string key,
      string timestampKey,
      string timestampRegionKey,
      T value,
      TimeSpan? timeout)
    {
      long num1 = 0;
      long num2;
      this._cacheService.TryGetValue<long>(timestampKey, out num2);
      if (timestampRegionKey != null)
        this._cacheService.TryGetValue<long>(timestampRegionKey, out num1);
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

    private bool TryGetFromContextCache<T>(
      string key,
      string timestampKey,
      string timestampRegionKey,
      out T value)
    {
      long result1 = 0;
      long result2;
      this._contextCacheService.TryGetValue<long>(timestampKey, "EleWise.ELMA.Cache.ComplexCacheService", out result2);
      if (timestampRegionKey != null)
        this._contextCacheService.TryGetValue<long>(timestampRegionKey, "EleWise.ELMA.Cache.ComplexCacheService", out result1);
      ComplexCacheServiceBase.CacheEntry<T> result3;
      if (this._contextCacheService.TryGetValue<ComplexCacheServiceBase.CacheEntry<T>>(key, "EleWise.ELMA.Cache.ComplexCacheService", out result3) && result3.Timestamp == result2 && result3.RegionTimestamp == result1)
      {
        value = result3.Value;
        return true;
      }
      value = default (T);
      return false;
    }

    private void SaveToContextCache<T>(
      string key,
      string timestampKey,
      string timestampRegionKey,
      T value)
    {
      long result1 = 0;
      long result2;
      this._contextCacheService.TryGetValue<long>(timestampKey, "EleWise.ELMA.Cache.ComplexCacheService", out result2);
      if (timestampRegionKey != null)
        this._contextCacheService.TryGetValue<long>(timestampRegionKey, "EleWise.ELMA.Cache.ComplexCacheService", out result1);
      this._contextCacheService.Set<ComplexCacheServiceBase.CacheEntry<T>>(key, "EleWise.ELMA.Cache.ComplexCacheService", new ComplexCacheServiceBase.CacheEntry<T>()
      {
        Timestamp = result2,
        RegionTimestamp = result1,
        Value = value
      });
    }

    internal static void fp6yx4fqv8e6IhPCpNPd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object MosiNWfq8x3WwHKKqRRl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool ouCrrHfqQ3e8gx71B8RB() => ComplexCacheServiceBase.xDtsITfqfFhfDXK00uAv == null;

    internal static ComplexCacheServiceBase lboc4yfqCPSNE61W08Bt() => ComplexCacheServiceBase.xDtsITfqfFhfDXK00uAv;

    internal static void PwtUxGfqZDmpBHvlNQh9([In] object obj0, [In] object obj1, [In] object obj2) => ((ComplexCacheServiceBase) obj0).RefreshTimestamp((string) obj1, (string) obj2);

    internal static bool UcOxcrfquSYVrKRZ7kFo([In] object obj0, [In] object obj1) => ((IUnitOfWorkManager) obj0).HasActiveTransaction((string) obj1);

    internal static void yTLSpxfqIFu8xCB0nkri([In] object obj0, [In] object obj1) => ((IUnitOfWorkManager) obj0).RegisterPostCommitAction((System.Action) obj1);

    internal static bool FH8UZOfqV3488GES9YYj() => Locator.Initialized;

    protected class CacheEntry<T>
    {
      internal static object u0D6yR8YprvTVxG090Cl;

      public T Value { get; set; }

      public long Timestamp
      {
        get => this.\u003CTimestamp\u003Ek__BackingField;
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
                this.\u003CTimestamp\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
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

      public long RegionTimestamp
      {
        get => this.\u003CRegionTimestamp\u003Ek__BackingField;
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
                this.\u003CRegionTimestamp\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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

      public CacheEntry()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool TONmh58Ya3cGnZwsLKIb() => ComplexCacheServiceBase.CacheEntry<T>.u0D6yR8YprvTVxG090Cl == null;

      internal static object RJiFJd8YD0cR8U97rHkr() => ComplexCacheServiceBase.CacheEntry<T>.u0D6yR8YprvTVxG090Cl;
    }
  }
}
