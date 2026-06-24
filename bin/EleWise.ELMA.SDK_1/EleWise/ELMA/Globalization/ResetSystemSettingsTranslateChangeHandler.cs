// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.ResetSystemSettingsTranslateChangeHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Globalization
{
  [Component(Order = 100)]
  public class ResetSystemSettingsTranslateChangeHandler : ITranslateChangeHandler
  {
    private static ResetSystemSettingsTranslateChangeHandler nB7QxmGErn1tfeP8WcXG;

    public void Execute()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            IEnumerable<IGlobalSettingsModule> extensionPoints = ((ComponentManager) ResetSystemSettingsTranslateChangeHandler.zpAFgnGEjRmM88dD50tL()).GetExtensionPoints<IGlobalSettingsModule>();
            // ISSUE: reference to a compiler-generated field
            Action<IGlobalSettingsModule> action1 = ResetSystemSettingsTranslateChangeHandler.\u003C\u003Ec.\u003C\u003E9__0_0;
            Action<IGlobalSettingsModule> action2;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              ResetSystemSettingsTranslateChangeHandler.\u003C\u003Ec.\u003C\u003E9__0_0 = action2 = (Action<IGlobalSettingsModule>) (p => ResetSystemSettingsTranslateChangeHandler.\u003C\u003Ec.kMFbSRvgYaVWdfj3PYpv((object) p));
            }
            else
              goto label_7;
label_6:
            extensionPoints.ForEach<IGlobalSettingsModule>(action2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
            continue;
label_7:
            action2 = action1;
            goto label_6;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    public ResetSystemSettingsTranslateChangeHandler()
    {
      ResetSystemSettingsTranslateChangeHandler.DXkY6WGEYQd32CfiFNUZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object zpAFgnGEjRmM88dD50tL() => (object) ComponentManager.Current;

    internal static bool xb1S79GEgJBb0OicKfsc() => ResetSystemSettingsTranslateChangeHandler.nB7QxmGErn1tfeP8WcXG == null;

    internal static ResetSystemSettingsTranslateChangeHandler DdeiXKGE5DRuCPMipf5j() => ResetSystemSettingsTranslateChangeHandler.nB7QxmGErn1tfeP8WcXG;

    internal static void DXkY6WGEYQd32CfiFNUZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
