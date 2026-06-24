// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.GenericProviderFeatureSection`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Configuration;

namespace EleWise.ELMA.Configuration
{
  /// <summary>Класс секции настроек для провайдера</summary>
  /// <typeparam name="T">Тип провайдера</typeparam>
  public class GenericProviderFeatureSection<T> : ProviderSettingsFeatureSection where T : class, IProvider, new()
  {
    private static object iZwXN3fWKHbe4P2LKCBm;

    [ConfigurationProperty("type", IsRequired = false, IsKey = true)]
    public override Type ProviderType
    {
      get => typeof (T);
      set => throw new NotImplementedException();
    }

    public GenericProviderFeatureSection()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool B1t0ALfWX0qCl20dBHPc() => GenericProviderFeatureSection<T>.iZwXN3fWKHbe4P2LKCBm == null;

    internal static object nS6s7hfWTHtCD82oJU0e() => GenericProviderFeatureSection<T>.iZwXN3fWKHbe4P2LKCBm;
  }
}
