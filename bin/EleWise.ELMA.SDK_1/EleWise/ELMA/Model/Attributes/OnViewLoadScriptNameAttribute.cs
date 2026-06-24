// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.OnViewLoadScriptNameAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут с именем сценария при изменении значения</summary>
  public class OnViewLoadScriptNameAttribute : Attribute
  {
    private string _scriptName;
    private static OnViewLoadScriptNameAttribute qsPRh2oC0FRp8cWbZFVf;

    /// <summary>Конструктор</summary>
    /// <param name="scriptName">Имя сценария</param>
    public OnViewLoadScriptNameAttribute(string scriptName)
    {
      OnViewLoadScriptNameAttribute.NFoOLCoCMr4SwcZfCh1p();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._scriptName = scriptName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Имя сценария</summary>
    public string ScriptName
    {
      get => this._scriptName;
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
              this._scriptName = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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

    internal static void NFoOLCoCMr4SwcZfCh1p() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool foGhSjoCmZarhkGJ3Bgg() => OnViewLoadScriptNameAttribute.qsPRh2oC0FRp8cWbZFVf == null;

    internal static OnViewLoadScriptNameAttribute pZ3dphoCy0kY6Yo42r4u() => OnViewLoadScriptNameAttribute.qsPRh2oC0FRp8cWbZFVf;
  }
}
