// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.GenericProviderManager`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Configuration.Provider;

namespace EleWise.ELMA.Runtime.Providers
{
  /// <summary>
  /// Базовый класс для провайдеров, использующих конфигурацию системы
  /// </summary>
  /// <typeparam name="TProvider">Тип базового провайдера</typeparam>
  /// <typeparam name="TIRegister">Тип с которым необходимо зарегистрировать провайдер по умолчанию</typeparam>
  public abstract class GenericProviderManager<TProvider, TIRegister> : AbstractProvider where TProvider : ProviderBase
  {
    protected TProvider DefaultProvider;
    internal static object kxsuugWEK2VaLabZPdGR;

    /// <summary>Создать объект настроек</summary>
    /// <returns>Объект настроек</returns>
    public override ProviderSettingsSection CreateSettings() => Activator.CreateInstance(typeof (GenericProviderFeatureSection<>).MakeGenericType(this.GetType())) as ProviderSettingsSection;

    /// <summary>
    /// Сконфигурировать провайдер (вызывается после загрузки конфиграции)
    /// </summary>
    public override void Configure(
      ProviderSettingsSection settings,
      RuntimeConfiguration configuration)
    {
      int num = 8;
      Type c;
      ProviderAdministration<TProvider> providerAdministration;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            if ((object) this.DefaultProvider == null)
            {
              num = 2;
              continue;
            }
            if (!this.DefaultProvider.GetType().IsAssignableFrom(typeof (TIRegister)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            }
            goto label_13;
          case 2:
            goto label_8;
          case 3:
            goto label_13;
          case 4:
            if (this.SettingsSection.GetType().IsAssignableFrom(c))
            {
              providerAdministration = new ProviderAdministration<TProvider>((ProviderSettingsFeatureSection) settings);
              num = 5;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 4 : 6;
            continue;
          case 5:
            this.DefaultProvider = providerAdministration.Provider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
            continue;
          case 6:
            goto label_11;
          case 7:
            c = typeof (GenericProviderFeatureSection<>).MakeGenericType(this.GetType());
            num = 4;
            continue;
          case 8:
            base.Configure(settings, configuration);
            num = 7;
            continue;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_2:
      return;
label_8:
      throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710543060) + (object) typeof (TProvider));
label_11:
      throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767692709) + (object) c);
label_13:
      throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751217170) + (object) typeof (TIRegister));
    }

    /// <summary>
    /// Начать инициализацию.
    /// Доступен <see cref="P:EleWise.ELMA.ComponentModel.ComponentManager.Current" /> и <see cref="P:EleWise.ELMA.ComponentModel.ComponentManager.Builder" />
    /// </summary>
    public override void Init()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_7;
          case 2:
            ComponentManager.Builder.RegisterInstance<TProvider>(this.DefaultProvider).As<TIRegister>().PropertiesAutowired<TProvider, SimpleActivatorData, SingleRegistrationStyle>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 3:
            if ((object) this.DefaultProvider != null)
            {
              num = 2;
              continue;
            }
            goto label_2;
          default:
            goto label_8;
        }
      }
label_5:
      return;
label_7:
      return;
label_8:
      return;
label_2:;
    }

    public override void InitComplete()
    {
    }

    protected GenericProviderManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool snABvvWEXjqVI4AGJ2Z9() => GenericProviderManager<TProvider, TIRegister>.kxsuugWEK2VaLabZPdGR == null;

    internal static object dEcOmYWETlpZjACr1JFJ() => GenericProviderManager<TProvider, TIRegister>.kxsuugWEK2VaLabZPdGR;
  }
}
