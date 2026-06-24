// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.SettingsStoreProviderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Runtime.Providers
{
  /// <summary>
  /// Менеджер провайдеров <see cref="T:EleWise.ELMA.Runtime.Providers.SettingsStoreProvider" />.
  /// Регистрирует провайдер как <see cref="T:EleWise.ELMA.Runtime.Managers.ISettingsManager" />
  /// </summary>
  public class SettingsStoreProviderManager : 
    GenericProviderManager<SettingsStoreProvider, ISettingsManager>
  {
    /// <summary>Строковое представление идентификатора</summary>
    public const string UID_S = "{F525D8E6-AC1D-4162-B9D9-33133EF4D268}";
    /// <summary>Идентификатор провайдера</summary>
    public static readonly Guid UID;
    private static SettingsStoreProviderManager Frny50WEkXrqJ8eYUi6o;

    /// <summary>Uid провайдера</summary>
    public override Guid Uid => SettingsStoreProviderManager.UID;

    /// <summary>Имя СУБД</summary>
    public override string Name => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70062484);

    public SettingsStoreProviderManager()
    {
      SettingsStoreProviderManager.sAowYLWE2tDPd1DaEk8f();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static SettingsStoreProviderManager()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            SettingsStoreProviderManager.UID = new Guid((string) SettingsStoreProviderManager.PlhEJDWEeP1kvfFTjZwo(-1334993905 ^ -1335083931));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool nNhHDyWEnVqf4oNC2669() => SettingsStoreProviderManager.Frny50WEkXrqJ8eYUi6o == null;

    internal static SettingsStoreProviderManager c0EMYTWEONASEL46kId1() => SettingsStoreProviderManager.Frny50WEkXrqJ8eYUi6o;

    internal static void sAowYLWE2tDPd1DaEk8f() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object PlhEJDWEeP1kvfFTjZwo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
