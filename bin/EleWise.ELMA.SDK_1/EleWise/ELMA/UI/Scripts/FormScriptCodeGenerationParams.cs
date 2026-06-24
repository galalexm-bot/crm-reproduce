// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.FormScriptCodeGenerationParams
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Scripts
{
  public class FormScriptCodeGenerationParams
  {
    private static FormScriptCodeGenerationParams Smaw0UjHKPWQxiLvQ9v;

    /// <summary>Метаданные</summary>
    public FormMetadata Metadata
    {
      get => this.\u003CMetadata\u003Ek__BackingField;
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
              this.\u003CMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    /// <summary>Модуль сценариев</summary>
    public ScriptModuleDTO ScriptModule
    {
      get => this.\u003CScriptModule\u003Ek__BackingField;
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
              this.\u003CScriptModule\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    public FormScriptCodeGenerationParams()
    {
      FormScriptCodeGenerationParams.Sj0Rt7jxEr4HxMK6b2a();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool G6mFIsjApXkKP2swMHf() => FormScriptCodeGenerationParams.Smaw0UjHKPWQxiLvQ9v == null;

    internal static FormScriptCodeGenerationParams PDrHUUj7ID6O2tf3uPy() => FormScriptCodeGenerationParams.Smaw0UjHKPWQxiLvQ9v;

    internal static void Sj0Rt7jxEr4HxMK6b2a() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
