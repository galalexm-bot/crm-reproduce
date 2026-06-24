// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.RazorViewsExportSetting
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Конфигурация экспорта предствлений Razor</summary>
  [Serializable]
  public class RazorViewsExportSetting
  {
    internal static RazorViewsExportSetting WDb71iEjdfknGcgpeeQj;

    /// <summary>
    /// 
    /// </summary>
    public RazorViewsExportSetting()
    {
      RazorViewsExportSetting.VD074AEjgNAfCgLUNTuj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.ExportViews = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          default:
            this.ViewVirtualPaths = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Флаг переноса представлений</summary>
    public bool ExportViews
    {
      get => this.\u003CExportViews\u003Ek__BackingField;
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
              this.\u003CExportViews\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
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

    /// <summary>Виртуальные пути представлений</summary>
    public List<string> ViewVirtualPaths { get; set; }

    internal static void VD074AEjgNAfCgLUNTuj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Q2VaypEjlXXu0IAXjYut() => RazorViewsExportSetting.WDb71iEjdfknGcgpeeQj == null;

    internal static RazorViewsExportSetting KIxLFeEjrVmyTary5TGx() => RazorViewsExportSetting.WDb71iEjdfknGcgpeeQj;
  }
}
