// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.EntityLocalizationLoadCustomSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Globalization
{
  [Component]
  public class EntityLocalizationLoadCustomSettings : ILocalizationLoadCustomSettings
  {
    public static readonly Guid ExtensionUid;
    internal static EntityLocalizationLoadCustomSettings Uy082LGosV2PL8mbslTF;

    public Dictionary<Guid, object> GetNewSettingObj() => new Dictionary<Guid, object>()
    {
      {
        EntityLocalizationLoadCustomSettings.ExtensionUid,
        (object) new EntityGlobalizationSettings()
      }
    };

    public EntityLocalizationLoadCustomSettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityLocalizationLoadCustomSettings()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityLocalizationLoadCustomSettings.ExtensionUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978570158));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          case 2:
            EntityLocalizationLoadCustomSettings.omJvi4GbFUJGkt15Rjvp();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool IqVX3nGocFEJYULituTo() => EntityLocalizationLoadCustomSettings.Uy082LGosV2PL8mbslTF == null;

    internal static EntityLocalizationLoadCustomSettings wvZsqcGozdRwpc6DsLHX() => EntityLocalizationLoadCustomSettings.Uy082LGosV2PL8mbslTF;

    internal static void omJvi4GbFUJGkt15Rjvp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
