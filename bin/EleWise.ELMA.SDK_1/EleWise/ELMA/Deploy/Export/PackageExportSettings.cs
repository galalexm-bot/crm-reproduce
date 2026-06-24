// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.PackageExportSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Настройки экспорта пакетов</summary>
  [Serializable]
  public class PackageExportSettings
  {
    internal static PackageExportSettings stEAtIEYonSYajvTw3V7;

    /// <summary>Ctor</summary>
    public PackageExportSettings()
    {
      PackageExportSettings.wh59ysEYGhe1jwCo7MnA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Packages = new List<PackageDescription>();
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

    /// <summary>Флаг переноса пакетов</summary>
    public bool ExportPackages
    {
      get => this.\u003CExportPackages\u003Ek__BackingField;
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
              this.\u003CExportPackages\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
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

    /// <summary>Экспортируемые пакеты</summary>
    public List<PackageDescription> Packages { get; set; }

    internal static void wh59ysEYGhe1jwCo7MnA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool pISIHvEYbfjBSsdV1yqa() => PackageExportSettings.stEAtIEYonSYajvTw3V7 == null;

    internal static PackageExportSettings WUpEcXEYh6sh8HF1mtRj() => PackageExportSettings.stEAtIEYonSYajvTw3V7;
  }
}
