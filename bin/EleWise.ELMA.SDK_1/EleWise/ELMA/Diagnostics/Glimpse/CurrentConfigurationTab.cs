// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.CurrentConfigurationTab
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using Glimpse.AspNet.Extensibility;
using Glimpse.Core.Extensibility;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Glimpse
{
  public class CurrentConfigurationTab : AspNetTab
  {
    private static CurrentConfigurationTab tYH6qiEikWpPS3807O9r;

    public override string Name => (string) CurrentConfigurationTab.oB3bYdEi22SRS8SVAKhu(381945751 ^ 1158627804 ^ 1406080269);

    public override object GetData(ITabContext context)
    {
      int num = 3;
      IRuntimeApplication service;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            goto label_8;
          case 3:
            if (!Locator.Initialized)
            {
              num = 2;
              continue;
            }
            service = Locator.GetService<IRuntimeApplication>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          default:
            if (service == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return (object) null;
label_5:
      return CurrentConfigurationTab.VRiSLPEiPIN3Tyd2oWfo((object) ((RuntimeConfiguration) CurrentConfigurationTab.NA22TjEieiBblepcD30T((object) service)).MainDB);
label_8:
      return (object) null;
    }

    public CurrentConfigurationTab()
    {
      CurrentConfigurationTab.bYdpi2Ei1rcOfeufUxtm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object oB3bYdEi22SRS8SVAKhu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool fWVxbDEin2O0gIAWijkK() => CurrentConfigurationTab.tYH6qiEikWpPS3807O9r == null;

    internal static CurrentConfigurationTab Ng1B37EiOZufVgQxl5Hv() => CurrentConfigurationTab.tYH6qiEikWpPS3807O9r;

    internal static object NA22TjEieiBblepcD30T([In] object obj0) => (object) ((IRuntimeApplication) obj0).Configuration;

    internal static object VRiSLPEiPIN3Tyd2oWfo([In] object obj0) => (object) ((IDataBaseSettingsSection) obj0).ConnectionString;

    internal static void bYdpi2Ei1rcOfeufUxtm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
