// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Deploy.Export.ScriptModuleExportSetting
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts.Deploy.Export
{
  /// <summary>Конфигурация экспорта глобальных модулей</summary>
  [Serializable]
  public class ScriptModuleExportSetting
  {
    internal static ScriptModuleExportSetting DRJlDXbTBaYpFxh0WT6s;

    /// <summary>
    /// 
    /// </summary>
    public ScriptModuleExportSetting()
    {
      ScriptModuleExportSetting.ofPUHKbTbogEYhHY0W6y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ScriptModuleUids = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 2:
            this.ExportScriptModules = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Флаг переноса глобальныъ модулей</summary>
    public bool ExportScriptModules
    {
      get => this.\u003CExportScriptModules\u003Ek__BackingField;
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
              this.\u003CExportScriptModules\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
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

    /// <summary>Uid-ы загловков форм</summary>
    public List<Guid> ScriptModuleUids { get; set; }

    internal static void ofPUHKbTbogEYhHY0W6y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool pMZRVfbTWp3AKBuxsBqr() => ScriptModuleExportSetting.DRJlDXbTBaYpFxh0WT6s == null;

    internal static ScriptModuleExportSetting zSjWbybTo22KdQrxJQ5I() => ScriptModuleExportSetting.DRJlDXbTBaYpFxh0WT6s;
  }
}
