// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.MetadataCacheService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class MetadataCacheService : IMetadataCacheService
  {
    private readonly Guid runtimeCacheGuid;
    internal static MetadataCacheService TRfsMdBDKtxVhBIaxspv;

    /// <inheritdoc />
    public string GetRuntimeHash()
    {
      int num = 2;
      IBLOBDataManager blobDataManager;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (blobDataManager == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            blobDataManager = (IBLOBDataManager) MetadataCacheService.OhpPW4BDkKAYavpl2JqS();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) null;
label_5:
      return blobDataManager.GetBLOB<string>(this.runtimeCacheGuid, (string) MetadataCacheService.XxFTSEBDnVXdkrr6yuL2(--1418440330 ^ 1418390488));
    }

    /// <inheritdoc />
    public void SetRuntimeHash(string value)
    {
      int num = 4;
      IBLOBDataManager blobDataManager;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            blobDataManager.SetBLOB<string>(this.runtimeCacheGuid, (string) MetadataCacheService.XxFTSEBDnVXdkrr6yuL2(-643786247 ^ -643703637), value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            if (blobDataManager != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 4:
            blobDataManager = (IBLOBDataManager) MetadataCacheService.OhpPW4BDkKAYavpl2JqS();
            num = 3;
            continue;
          default:
            goto label_9;
        }
      }
label_4:
      return;
label_6:
      return;
label_9:
      return;
label_2:;
    }

    public MetadataCacheService()
    {
      MetadataCacheService.tjPxdIBDOuyh18HruD1g();
      this.runtimeCacheGuid = new Guid((string) MetadataCacheService.XxFTSEBDnVXdkrr6yuL2(-630932142 - 1120244082 ^ -1751224690));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object OhpPW4BDkKAYavpl2JqS() => (object) DataAccessManager.BLOBManager;

    internal static object XxFTSEBDnVXdkrr6yuL2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Gum108BDXpZXFHTMuVbe() => MetadataCacheService.TRfsMdBDKtxVhBIaxspv == null;

    internal static MetadataCacheService XZhcuIBDTBDWL0m8q1Y7() => MetadataCacheService.TRfsMdBDKtxVhBIaxspv;

    internal static void tjPxdIBDOuyh18HruD1g() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
