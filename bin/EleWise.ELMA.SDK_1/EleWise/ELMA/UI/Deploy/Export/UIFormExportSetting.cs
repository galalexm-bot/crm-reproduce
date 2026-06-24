// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Deploy.Export.UIFormExportSetting
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Deploy.Export
{
  /// <summary>Конфигурация экспорта страниц и портлетов</summary>
  [Serializable]
  public class UIFormExportSetting
  {
    internal static UIFormExportSetting Esb87dd3pwKPYMyYFiP;

    /// <summary>
    /// 
    /// </summary>
    public UIFormExportSetting()
    {
      UIFormExportSetting.CwQyAKdDCOBQns6mpnB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.FormHeaderUids = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 2:
            this.ExportForms = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Флаг переноса форм</summary>
    public bool ExportForms
    {
      get => this.\u003CExportForms\u003Ek__BackingField;
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
              this.\u003CExportForms\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
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
    public List<Guid> FormHeaderUids { get; set; }

    internal static void CwQyAKdDCOBQns6mpnB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool TdvgTAdppYmS863Ktgy() => UIFormExportSetting.Esb87dd3pwKPYMyYFiP == null;

    internal static UIFormExportSetting AFRLfqdaicx33il3knm() => UIFormExportSetting.Esb87dd3pwKPYMyYFiP;
  }
}
