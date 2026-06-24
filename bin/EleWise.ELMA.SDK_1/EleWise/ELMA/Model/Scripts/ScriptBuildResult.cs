// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ScriptBuildResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Результат построения сценариев</summary>
  [Serializable]
  public class ScriptBuildResult : ScriptCompileResult
  {
    private static ScriptBuildResult toYkYhbixeKZ1VenuiGs;

    /// <summary>Скомпилированный код сборки</summary>
    public byte[] AssemblyRaw
    {
      get => this.\u003CAssemblyRaw\u003Ek__BackingField;
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
              this.\u003CAssemblyRaw\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

    /// <summary>PDB-файл сборки</summary>
    public byte[] DebugRaw
    {
      get => this.\u003CDebugRaw\u003Ek__BackingField;
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
              this.\u003CDebugRaw\u003Ek__BackingField = value;
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

    public ScriptBuildResult()
    {
      ScriptBuildResult.G6dwgFbiyw5SMJLjUyHE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool cAq1v6bi0kd1R8RJ2IEV() => ScriptBuildResult.toYkYhbixeKZ1VenuiGs == null;

    internal static ScriptBuildResult KYTN9nbimkmaOZB13tK8() => ScriptBuildResult.toYkYhbixeKZ1VenuiGs;

    internal static void G6dwgFbiyw5SMJLjUyHE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
