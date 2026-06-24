// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.ProviderFeatureSection
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
  /// <summary>Базовая секция для использования системы провайдеров</summary>
  public abstract class ProviderFeatureSection : ConfigurationSection
  {
    private readonly ConfigurationProperty _defaultProvider;
    private readonly ConfigurationProperty _providers;
    private readonly ConfigurationPropertyCollection _properties;
    internal static ProviderFeatureSection nejYWLfWsUP3xpkZoBtP;

    /// <summary>Конструктор</summary>
    public ProviderFeatureSection()
    {
      ProviderFeatureSection.G6T6fRfoFIepI20GdAFJ();
      // ISSUE: type reference
      this._defaultProvider = new ConfigurationProperty((string) ProviderFeatureSection.d8Cf4QfoBvnuNg7B64NA(-1380439818 << 3 ^ 1841583396), ProviderFeatureSection.dvZfU4foWt8iR8u0rUjs(__typeref (string)), (object) null);
      this._providers = new ConfigurationProperty((string) ProviderFeatureSection.d8Cf4QfoBvnuNg7B64NA(1470998129 - 231418599 ^ 1239620212), typeof (ProviderSettingsCollection), (object) null);
      this._properties = new ConfigurationPropertyCollection();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            ProviderFeatureSection.xZxM87foogSWUwlMwOdM((object) this._properties, (object) this._providers);
            num = 2;
            continue;
          case 2:
            ProviderFeatureSection.xZxM87foogSWUwlMwOdM((object) this._properties, (object) this._defaultProvider);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Имя провайдера по умолчанию</summary>
    [ConfigurationProperty("defaultProvider", IsRequired = true)]
    public string DefaultProvider
    {
      get => (string) ProviderFeatureSection.Bq9lnOfobQf6KGbXwpWE((object) this, (object) this._defaultProvider);
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
              ProviderFeatureSection.owB7VMfohETYs2nQniF8((object) this, (object) this._defaultProvider, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
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
    public ProviderSettingsCollection Providers => (ProviderSettingsCollection) ProviderFeatureSection.Bq9lnOfobQf6KGbXwpWE((object) this, (object) this._providers);

    protected override ConfigurationPropertyCollection Properties => this._properties;

    internal static void G6T6fRfoFIepI20GdAFJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object d8Cf4QfoBvnuNg7B64NA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type dvZfU4foWt8iR8u0rUjs([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void xZxM87foogSWUwlMwOdM([In] object obj0, [In] object obj1) => ((ConfigurationPropertyCollection) obj0).Add((ConfigurationProperty) obj1);

    internal static bool t7pLo9fWcDWTpSHRfBaY() => ProviderFeatureSection.nejYWLfWsUP3xpkZoBtP == null;

    internal static ProviderFeatureSection wlQde1fWzXisARHA7ClF() => ProviderFeatureSection.nejYWLfWsUP3xpkZoBtP;

    internal static object Bq9lnOfobQf6KGbXwpWE([In] object obj0, [In] object obj1) => ((ConfigurationElement) obj0)[(ConfigurationProperty) obj1];

    internal static void owB7VMfohETYs2nQniF8([In] object obj0, [In] object obj1, [In] object obj2) => ((ConfigurationElement) obj0)[(ConfigurationProperty) obj1] = obj2;
  }
}
