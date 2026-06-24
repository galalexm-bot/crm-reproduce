// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.OnChangeScriptNameAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут с именем сценария при изменении значения</summary>
  public class OnChangeScriptNameAttribute : Attribute
  {
    private string _scriptName;
    private static OnChangeScriptNameAttribute u3H9fuoCYQqGck5D4I4C;

    /// <summary>Конструктор</summary>
    /// <param name="scriptName">Имя сценария</param>
    public OnChangeScriptNameAttribute(string scriptName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._scriptName = scriptName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    internal static bool vGyEDHoCLlgk9JHymPpN() => OnChangeScriptNameAttribute.u3H9fuoCYQqGck5D4I4C == null;

    internal static OnChangeScriptNameAttribute bZQbjhoCUKy9NidcPf6V() => OnChangeScriptNameAttribute.u3H9fuoCYQqGck5D4I4C;
  }
}
