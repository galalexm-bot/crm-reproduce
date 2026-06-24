// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.CacheServiceManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Cache
{
  public class CacheServiceManager : 
    GenericProviderManager<CacheService, ICacheService>,
    INHCacheService
  {
    /// <summary>Строковое представление идентификатора</summary>
    public const string UID_S = "{100485AD-DADC-4095-82F1-58F5B0833C13}";
    /// <summary>Идентификатор провайдера</summary>
    public static readonly Guid UID;
    internal static CacheServiceManager n1J5QBfKbCoBrRCDjhXO;

    /// <summary>Uid провайдера</summary>
    public override Guid Uid => CacheServiceManager.UID;

    /// <summary>Имя СУБД</summary>
    public override string Name => (string) CacheServiceManager.FYAdrafKE5rrQYXwv0gj(-812025778 ^ -812003244);

    public override void Configure(
      ProviderSettingsSection settings,
      RuntimeConfiguration configuration)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CacheServiceManager.tHbPPXfKfGALREtoImx1((object) this, (object) settings, (object) configuration);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.DefaultProvider.Configure(settings, configuration);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    public ICacheService DefaultCacheService => (ICacheService) this.DefaultProvider;

    string INHCacheService.ProviderType
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(this.DefaultProvider is INHCacheService))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return (string) null;
label_3:
        return (string) CacheServiceManager.fdwdcmfKQjRNgL0EtoNw((object) (INHCacheService) this.DefaultProvider);
      }
    }

    public CacheServiceManager()
    {
      CacheServiceManager.IKwDocfKCjXEWrQKIsrp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CacheServiceManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CacheServiceManager.IKwDocfKCjXEWrQKIsrp();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            CacheServiceManager.UID = new Guid((string) CacheServiceManager.FYAdrafKE5rrQYXwv0gj(-70007027 ^ -69827735));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object FYAdrafKE5rrQYXwv0gj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool JCVqe7fKhSxaIk9dBH2T() => CacheServiceManager.n1J5QBfKbCoBrRCDjhXO == null;

    internal static CacheServiceManager gKD93BfKGtnu31kSSgL7() => CacheServiceManager.n1J5QBfKbCoBrRCDjhXO;

    internal static void tHbPPXfKfGALREtoImx1([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((GenericProviderManager<CacheService, ICacheService>) obj0).Configure((ProviderSettingsSection) obj1, (RuntimeConfiguration) obj2));

    internal static object fdwdcmfKQjRNgL0EtoNw([In] object obj0) => (object) ((INHCacheService) obj0).ProviderType;

    internal static void IKwDocfKCjXEWrQKIsrp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
