// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.ProviderSettingsFeatureSection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Configuration;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Configuration
{
  /// <summary>Базовая секция для настроек провайдера</summary>
  public abstract class ProviderSettingsFeatureSection : ProviderSettingsSection
  {
    private readonly ConfigurationProperty _defaultProvider;
    private readonly ConfigurationProperty _providers;
    internal static ProviderSettingsFeatureSection w6UJIDfW2B19s8veqFqx;

    /// <summary>Имя провайдера по умолчанию</summary>
    [ConfigurationProperty("defaultProvider", IsRequired = true)]
    public string DefaultProvider
    {
      get => (string) ProviderSettingsFeatureSection.E2yhjifW1EcddxpDerWn((object) this, (object) this._defaultProvider);
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
              ProviderSettingsFeatureSection.UTL6hdfWNCB5YMV2gnpK((object) this, (object) this._defaultProvider, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
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

    /// <summary>Список настроек провайдеров</summary>
    [ConfigurationProperty("providers", IsRequired = true)]
    public ProviderSettingsCollection Providers
    {
      get => (ProviderSettingsCollection) ProviderSettingsFeatureSection.E2yhjifW1EcddxpDerWn((object) this, (object) this._providers);
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
              ProviderSettingsFeatureSection.UTL6hdfWNCB5YMV2gnpK((object) this, (object) this._providers, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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

    protected ProviderSettingsFeatureSection()
    {
      ProviderSettingsFeatureSection.OK3tJtfW3ECyPHM5EK9j();
      // ISSUE: type reference
      this._defaultProvider = new ConfigurationProperty((string) ProviderSettingsFeatureSection.WmK0r4fWpGR2IZ4cuo8S(2008901894 << 3 ^ -1108452700), ProviderSettingsFeatureSection.RMI2dZfWaH0ExbAoRwmn(__typeref (string)), (object) null);
      // ISSUE: type reference
      this._providers = new ConfigurationProperty((string) ProviderSettingsFeatureSection.WmK0r4fWpGR2IZ4cuo8S(-398663332 ^ -398622558), ProviderSettingsFeatureSection.RMI2dZfWaH0ExbAoRwmn(__typeref (ProviderSettingsCollection)), (object) null);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object E2yhjifW1EcddxpDerWn([In] object obj0, [In] object obj1) => ((ConfigurationElement) obj0)[(ConfigurationProperty) obj1];

    internal static bool fbIEABfWenyB5Bp7NhSL() => ProviderSettingsFeatureSection.w6UJIDfW2B19s8veqFqx == null;

    internal static ProviderSettingsFeatureSection InTtIwfWPJcgjFndqypC() => ProviderSettingsFeatureSection.w6UJIDfW2B19s8veqFqx;

    internal static void UTL6hdfWNCB5YMV2gnpK([In] object obj0, [In] object obj1, [In] object obj2) => ((ConfigurationElement) obj0)[(ConfigurationProperty) obj1] = obj2;

    internal static void OK3tJtfW3ECyPHM5EK9j() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object WmK0r4fWpGR2IZ4cuo8S(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type RMI2dZfWaH0ExbAoRwmn([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
