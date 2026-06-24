// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.MemoryBLOBStoreProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Providers
{
  [Service(Type = ComponentType.Server)]
  public class MemoryBLOBStoreProvider : BLOBStoreProvider
  {
    private static PoolBasedSettingsService _impl;
    private static readonly Guid NullGuid;
    private IComplexCacheService _complexCacheService;
    internal static MemoryBLOBStoreProvider uOGFjSWEGOKynascqOEJ;

    private PoolBasedSettingsService Impl
    {
      get
      {
        int num = 1;
        PoolBasedSettingsService impl;
        while (true)
        {
          switch (num)
          {
            case 1:
              impl = MemoryBLOBStoreProvider._impl;
              if (impl == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return impl;
label_5:
        return MemoryBLOBStoreProvider._impl = Locator.GetServiceNotNull<PoolBasedSettingsService>();
      }
    }

    public ICacheService CacheService
    {
      get => this.\u003CCacheService\u003Ek__BackingField;
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
              this.\u003CCacheService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

    public IComplexCacheService ComplexCacheService
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._complexCacheService = Locator.GetServiceNotNull<IComplexCacheService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            case 2:
              if (this._complexCacheService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return this._complexCacheService;
      }
    }

    public IContextBoundVariableService ContextCacheService
    {
      get => this.\u003CContextCacheService\u003Ek__BackingField;
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
              this.\u003CContextCacheService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    public override void SetBLOB<T>(Guid uid, string key, T value)
    {
      object obj = this.WrapValue<T>(value);
      this.Impl.SetObject(uid.ToString() + key, obj);
      this.ComplexCacheService.RefreshTimestamp(MemoryBLOBStoreProvider.GetCacheKey(uid, (object) key) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70100627));
    }

    public override T GetBLOB<T>(Guid uid, string key)
    {
      string cacheKey = MemoryBLOBStoreProvider.GetCacheKey(uid, (object) key);
      return this.UnwrapValue<T>(this.ComplexCacheService.GetOrAdd<object>(cacheKey, cacheKey + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951543930), (Func<object>) (() => this.WrapValue<object>(this.Impl.GetObject(uid.ToString() + key)))));
    }

    public override void RemoveBLOB<T>(Guid uid, string key)
    {
      string cacheKey = MemoryBLOBStoreProvider.GetCacheKey(uid, (object) key);
      this.Impl.RemoveObject(uid.ToString() + key);
      this.ComplexCacheService.RefreshTimestamp(cacheKey + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978446190));
    }

    private static string GetCacheKey(Guid uid, object key) => (string) MemoryBLOBStoreProvider.w66CyfWECMnCGBykP7uS((object) new object[4]
    {
      MemoryBLOBStoreProvider.Bemco7WEQ5avycbh5H7g(-53329496 >> 4 ^ -3360158),
      (object) uid,
      MemoryBLOBStoreProvider.Bemco7WEQ5avycbh5H7g(-1858887263 ^ -1858884133),
      key
    });

    private object WrapValue<T>(T value) => (object) value == null ? (object) MemoryBLOBStoreProvider.NullGuid : (object) value;

    private T UnwrapValue<T>(object value) => value is Guid guid && guid == MemoryBLOBStoreProvider.NullGuid ? (T) null : (T) value;

    public MemoryBLOBStoreProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static MemoryBLOBStoreProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            MemoryBLOBStoreProvider.NullGuid = new Guid((string) MemoryBLOBStoreProvider.Bemco7WEQ5avycbh5H7g(-1088304168 ^ -1088400078));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            MemoryBLOBStoreProvider.OHdQnfWEv8IyvnVD7MCB();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool qkoi2vWEEou8kIn6VsS6() => MemoryBLOBStoreProvider.uOGFjSWEGOKynascqOEJ == null;

    internal static MemoryBLOBStoreProvider FoI2WaWEffRv8DdKHOMf() => MemoryBLOBStoreProvider.uOGFjSWEGOKynascqOEJ;

    internal static object Bemco7WEQ5avycbh5H7g(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object w66CyfWECMnCGBykP7uS([In] object obj0) => (object) string.Concat((object[]) obj0);

    internal static void OHdQnfWEv8IyvnVD7MCB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
