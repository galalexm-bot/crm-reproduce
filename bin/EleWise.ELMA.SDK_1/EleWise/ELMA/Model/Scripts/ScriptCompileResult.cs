// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ScriptCompileResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Результаты компиляции сценария</summary>
  [Serializable]
  public class ScriptCompileResult
  {
    internal static ScriptCompileResult YDlfokbq8mb2hExrtACA;

    /// <summary>Ctor</summary>
    public ScriptCompileResult()
    {
      ScriptCompileResult.Av4XkCbqItH7JS468lSB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Messages = new List<ScriptCompileMessage>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>True, если компиляция осуществлена успешно</summary>
    public bool Success
    {
      get => this.\u003CSuccess\u003Ek__BackingField;
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
              this.\u003CSuccess\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    /// <summary>Сообщения компиляции</summary>
    public List<ScriptCompileMessage> Messages { get; set; }

    internal static void Av4XkCbqItH7JS468lSB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool B6VaVAbqZAvP7pIsyeoM() => ScriptCompileResult.YDlfokbq8mb2hExrtACA == null;

    internal static ScriptCompileResult pjpJsjbqujvALsUMIAgV() => ScriptCompileResult.YDlfokbq8mb2hExrtACA;
  }
}
