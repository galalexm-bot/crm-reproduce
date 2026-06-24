// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.ProviderAdministration`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Configuration.Provider;

namespace EleWise.ELMA.Configuration
{
  /// <summary>Класс для работы с провайдерами</summary>
  /// <typeparam name="TProvider">Базовай тип провайдера</typeparam>
  public class ProviderAdministration<TProvider> where TProvider : ProviderBase
  {
    private TProvider _provider;
    private GenericProviderCollection<TProvider> _providers;
    internal static object nVlkrdfWkcQUcjfsaTSw;

    public ProviderAdministration(
      ProviderSettingsFeatureSection personalizationConfig)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            this._provider = this._providers[personalizationConfig.DefaultProvider];
            num = 5;
            continue;
          case 3:
            if (personalizationConfig == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
              continue;
            }
            this._providers = new GenericProviderCollection<TProvider>();
            num = 4;
            continue;
          case 4:
            ProvidersHelper.InstantiateProviders(personalizationConfig.Providers, (ProviderCollection) this._providers, typeof (TProvider));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 2;
            continue;
          case 5:
            if ((object) this._provider == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1322887196), (object) typeof (TProvider)));
label_9:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516636938));
    }

    /// <summary>Провайдер по умолчанию</summary>
    public TProvider Provider => this._provider;

    /// <summary>Список провайдеров</summary>
    public GenericProviderCollection<TProvider> Providers => this._providers;

    internal static bool zoC4VDfWnu4eaYhrmlk4() => ProviderAdministration<TProvider>.nVlkrdfWkcQUcjfsaTSw == null;

    internal static object PjnJbhfWOoLtJRGhWaRP() => ProviderAdministration<TProvider>.nVlkrdfWkcQUcjfsaTSw;
  }
}
