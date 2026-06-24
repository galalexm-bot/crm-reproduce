// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.FullTextSearchSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch
{
  /// <summary>Настройки индексации</summary>
  public class FullTextSearchSettings : GlobalSettingsBase
  {
    internal static FullTextSearchSettings GhmSP6GQb7OHOhTTbL0I;

    /// <summary>Ctor</summary>
    public FullTextSearchSettings()
    {
      FullTextSearchSettings.t04hwGGQEwHC4UiBjd6H();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Uid провайдера индексации</summary>
    [DisplayName(typeof (FullTextSearchSettings_SR), "P_ProviderUid")]
    public Guid ProviderUid
    {
      get => this.\u003CProviderUid\u003Ek__BackingField;
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
              this.\u003CProviderUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    public static Dictionary<Guid, string> GetProviders() => ComponentManager.Current.GetExtensionPoints<IFullTextSearchProvider>().ToDictionary<IFullTextSearchProvider, Guid, string>((Func<IFullTextSearchProvider, Guid>) (provider => FullTextSearchSettings.\u003C\u003Ec.mPOxAGv5LRR2YZvKHCoa((object) provider)), (Func<IFullTextSearchProvider, string>) (provider => (string) FullTextSearchSettings.\u003C\u003Ec.u7ik2dv5UKfTGDCfRm06((object) provider)));

    public static string GetProviderName(Guid providerGuid)
    {
      int num = 1;
      IFullTextSearchProvider textSearchProvider;
      Guid providerGuid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            textSearchProvider = ComponentManager.Current.GetExtensionPoints<IFullTextSearchProvider>().FirstOrDefault<IFullTextSearchProvider>((Func<IFullTextSearchProvider, bool>) (p => FullTextSearchSettings.\u003C\u003Ec__DisplayClass6_0.iMNCdcvjWf6bVIclUppY(FullTextSearchSettings.\u003C\u003Ec__DisplayClass6_0.awBquTvjBV23dQ4kJAWS((object) p), providerGuid1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 3 : 3;
            continue;
          case 3:
            if (textSearchProvider != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 4 : 0;
              continue;
            }
            goto label_6;
          case 4:
            goto label_5;
          default:
            providerGuid1 = providerGuid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 0;
            continue;
        }
      }
label_5:
      return (string) FullTextSearchSettings.Fe2oc6GQf3pKrH0uEhhr((object) textSearchProvider);
label_6:
      return (string) FullTextSearchSettings.fgqj6IGQQqTMHMaMK7y4((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859100187));
    }

    public void BindAndSaveToGlobalSettings()
    {
      int num = 5;
      while (true)
      {
        FullTextSearchSettingsModule serviceNotNull;
        switch (num)
        {
          case 1:
            FullTextSearchSettings.bP6s6wGQCtS9vDB6O2uu((object) serviceNotNull.Settings, this.ProviderUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            if (serviceNotNull.Settings != this)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
              continue;
            }
            break;
          case 4:
            if (serviceNotNull.Settings != null)
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 5:
            serviceNotNull = Locator.GetServiceNotNull<FullTextSearchSettingsModule>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 4 : 3;
            continue;
          case 6:
            goto label_4;
        }
        FullTextSearchSettings.O7tcmZGQv7uupoaixB1V((object) serviceNotNull);
        num = 2;
      }
label_5:
      return;
label_4:
      return;
label_2:;
    }

    internal static void t04hwGGQEwHC4UiBjd6H() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ztINFiGQhgXumMG4MAIx() => FullTextSearchSettings.GhmSP6GQb7OHOhTTbL0I == null;

    internal static FullTextSearchSettings cFtREiGQGxflVoMWuaEM() => FullTextSearchSettings.GhmSP6GQb7OHOhTTbL0I;

    internal static object Fe2oc6GQf3pKrH0uEhhr([In] object obj0) => (object) ((IFullTextSearchProvider) obj0).ProviderName;

    internal static object fgqj6IGQQqTMHMaMK7y4([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void bP6s6wGQCtS9vDB6O2uu([In] object obj0, Guid value) => ((FullTextSearchSettings) obj0).ProviderUid = value;

    internal static void O7tcmZGQv7uupoaixB1V([In] object obj0) => ((GlobalSettingsModuleBase<FullTextSearchSettings>) obj0).SaveSettings();
  }
}
