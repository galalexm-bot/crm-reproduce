// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.BpmAppsExportSetting
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Конфигурация экспорта bpmApp'ов</summary>
  [Serializable]
  public class BpmAppsExportSetting
  {
    private static BpmAppsExportSetting XvcSZWEjaX7WdAA3D4R5;

    public BpmAppsExportSetting()
    {
      BpmAppsExportSetting.CQJq6EEjwfTHglArTfMD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Files = new Dictionary<string, ElmaStoreComponentManifest>();
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.Components = new Dictionary<string, BPMAppDTO>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Временное хранилище id выгружаемого Bpm App</summary>
    public string TempId
    {
      get => this.\u003CTempId\u003Ek__BackingField;
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
              this.\u003CTempId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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

    /// <summary>Переносимые Bpm App из файлов</summary>
    public Dictionary<string, ElmaStoreComponentManifest> Files { get; set; }

    /// <summary>Переносимые Bpm App из системы</summary>
    public Dictionary<string, BPMAppDTO> Components { get; set; }

    internal static void CQJq6EEjwfTHglArTfMD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool j9f9tEEjDWv3mLrexZVS() => BpmAppsExportSetting.XvcSZWEjaX7WdAA3D4R5 == null;

    internal static BpmAppsExportSetting P6idIJEjtqoHNYv2W4hs() => BpmAppsExportSetting.XvcSZWEjaX7WdAA3D4R5;
  }
}
