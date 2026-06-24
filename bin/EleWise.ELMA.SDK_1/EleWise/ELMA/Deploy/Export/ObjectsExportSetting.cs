// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ObjectsExportSetting
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Конфигурация экспорта объектов</summary>
  [Serializable]
  public class ObjectsExportSetting
  {
    private static ObjectsExportSetting q7QYEuEYRb5h5GYAo24V;

    public ObjectsExportSetting()
    {
      ObjectsExportSetting.WKmeyUEYX8ywCqXsnL4M();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Enums = new List<Guid>();
            num = 2;
            continue;
          case 2:
            this.DataClasses = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 4 : 4;
            continue;
          case 3:
            this.ExportCatalogs = true;
            num = 5;
            continue;
          case 4:
            goto label_2;
          case 5:
            this.Catalogs = new SerializableDictionary<Guid, bool>();
            num = 6;
            continue;
          case 6:
            this.SysCatalogs = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          default:
            this.ExportEnums = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Флаг переноса справочников</summary>
    public bool ExportCatalogs
    {
      get => this.\u003CExportCatalogs\u003Ek__BackingField;
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
              this.\u003CExportCatalogs\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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

    /// <summary>
    /// Гуиды метаданных объектов с флагом переноса справочников
    /// </summary>
    public SerializableDictionary<Guid, bool> Catalogs { get; set; }

    /// <summary>
    /// Гуиды метаданных системных справочников (переносятся только данные)
    /// </summary>
    public List<Guid> SysCatalogs { get; set; }

    /// <summary>Флаг переноса перечислений</summary>
    public bool ExportEnums
    {
      get => this.\u003CExportEnums\u003Ek__BackingField;
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
              this.\u003CExportEnums\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

    /// <summary>
    /// Гуиды метаданных объектов с флагом переноса перечислений
    /// </summary>
    public List<Guid> Enums { get; set; }

    /// <summary>Идентификаторы метаданных датаклассов</summary>
    public List<Guid> DataClasses { get; set; }

    internal static void WKmeyUEYX8ywCqXsnL4M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fTh8UpEYqqOhQJ4RH1ko() => ObjectsExportSetting.q7QYEuEYRb5h5GYAo24V == null;

    internal static ObjectsExportSetting hWBcQVEYKW0EfQdxcYdV() => ObjectsExportSetting.q7QYEuEYRb5h5GYAo24V;
  }
}
