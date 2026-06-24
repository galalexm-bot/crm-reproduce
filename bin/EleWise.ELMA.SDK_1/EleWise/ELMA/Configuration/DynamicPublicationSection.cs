// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.DynamicPublicationSection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Configuration;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Configuration
{
  /// <summary>Секция для конфигурирования динамической публикации</summary>
  internal class DynamicPublicationSection : ConfigurationSection
  {
    internal static DynamicPublicationSection ACeSEZfFwffQq1ZvLYBm;

    /// <summary>Включена ли динамическая публикация</summary>
    [ConfigurationProperty("disable", DefaultValue = false)]
    public bool Enable
    {
      get => !(bool) DynamicPublicationSection.eNH0lrfFAUqauRfKOxpf((object) this, DynamicPublicationSection.vmS9FIfFH0nDNaXgf98f(-2099751081 ^ -2099423015));
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
              DynamicPublicationSection.ykjeCQfF79Zkr23nlRBN((object) this, DynamicPublicationSection.vmS9FIfFH0nDNaXgf98f(~-122002947 ^ 121672076), (object) !value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

    public DynamicPublicationSection()
    {
      DynamicPublicationSection.tUNch2fFxrwvlQGOmo6s();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object vmS9FIfFH0nDNaXgf98f(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object eNH0lrfFAUqauRfKOxpf([In] object obj0, [In] object obj1) => ((ConfigurationElement) obj0)[(string) obj1];

    internal static bool PfLT0ufF4qOPcuQh6Uvh() => DynamicPublicationSection.ACeSEZfFwffQq1ZvLYBm == null;

    internal static DynamicPublicationSection HrbWi3fF6QxU0QClHRl6() => DynamicPublicationSection.ACeSEZfFwffQq1ZvLYBm;

    internal static void ykjeCQfF79Zkr23nlRBN([In] object obj0, [In] object obj1, [In] object obj2) => ((ConfigurationElement) obj0)[(string) obj1] = obj2;

    internal static void tUNch2fFxrwvlQGOmo6s() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
