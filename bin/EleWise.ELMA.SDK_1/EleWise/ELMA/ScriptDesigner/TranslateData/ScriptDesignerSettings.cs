// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.TranslateData.ScriptDesignerSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ScriptDesigner.TranslateData
{
  /// <summary>Настройки для конструктора сценариев</summary>
  [Serializable]
  public class ScriptDesignerSettings
  {
    private static ScriptDesignerSettings G9LoZI8jio7hMmDkj4S;

    public bool DontShowAgain
    {
      get => this.\u003CDontShowAgain\u003Ek__BackingField;
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
              this.\u003CDontShowAgain\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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

    public ScriptDesignerSettings()
    {
      ScriptDesignerSettings.YLqSCv8Uh5Jnu3iCkKx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool AP38258Y8xXNLx7TsbW() => ScriptDesignerSettings.G9LoZI8jio7hMmDkj4S == null;

    internal static ScriptDesignerSettings QupCEx8LX2sMKJ6P0Gj() => ScriptDesignerSettings.G9LoZI8jio7hMmDkj4S;

    internal static void YLqSCv8Uh5Jnu3iCkKx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
