// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.MainBaseSettingsSection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Configuration
{
  public class MainBaseSettingsSection : 
    DataBaseSettingsSection,
    IMainBaseSettingsSection,
    IDataBaseSettingsSection
  {
    public const string SECTION = "main.db";
    private static MainBaseSettingsSection gIGhsxfBeS00e3R5A03E;

    public MainBaseSettingsSection()
    {
      MainBaseSettingsSection.q1MefqfBNTtZxj9EJcJ5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void q1MefqfBNTtZxj9EJcJ5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool SfqXdbfBPMUdUBfg7evi() => MainBaseSettingsSection.gIGhsxfBeS00e3R5A03E == null;

    internal static MainBaseSettingsSection npIlDefB1PLcepyUxFWm() => MainBaseSettingsSection.gIGhsxfBeS00e3R5A03E;
  }
}
