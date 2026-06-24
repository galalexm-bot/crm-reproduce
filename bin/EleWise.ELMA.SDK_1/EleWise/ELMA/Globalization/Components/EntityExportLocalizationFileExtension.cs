// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.Components.EntityExportLocalizationFileExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Globalization.ExtensionPoints;
using EleWise.ELMA.Globalization.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Globalization.Components
{
  /// <summary>
  /// Компонент шага визарда выгрузки файлов локализации конфигурации для справочников и перечислений
  /// </summary>
  [Component(Order = 10)]
  internal class EntityExportLocalizationFileExtension : IExportLocalizationFileExtensionPoint
  {
    private readonly IMetadataEditorService metadataEditorService;
    internal static EntityExportLocalizationFileExtension USbnqQGQF5nAxn31Jghd;

    /// <summary>Ctor</summary>
    /// <param name="metadataEditorService">Сервис редактирования метаданных</param>
    public EntityExportLocalizationFileExtension(IMetadataEditorService metadataEditorService)
    {
      EntityExportLocalizationFileExtension.Yk46EyGQoxZkfTOlMod8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.metadataEditorService = metadataEditorService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public Guid Uid => EntityLocalizationLoadCustomSettings.ExtensionUid;

    /// <inheritdoc />
    public string Header => this.Tabs[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643098884)];

    /// <inheritdoc />
    public IDictionary<string, string> Tabs => (IDictionary<string, string>) new Dictionary<string, string>()
    {
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317559444),
        EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36045257))
      },
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236054991),
        EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979614462))
      }
    };

    /// <inheritdoc />
    public IDictionary<string, IEnumerable<LocalizableData>> GetAllData() => (IDictionary<string, IEnumerable<LocalizableData>>) new Dictionary<string, IEnumerable<LocalizableData>>()
    {
      {
        this.Tabs[z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397308772)],
        this.FillCatalogListGrid()
      },
      {
        this.Tabs[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470554974)],
        this.FillEnumListGrid()
      }
    };

    /// <inheritdoc />
    public object GetSettingObj(IDictionary<string, string> settingsJsonData)
    {
      EntityGlobalizationSettings settingObj = new EntityGlobalizationSettings();
      JsonSerializer jsonSerializer = new JsonSerializer();
      settingObj.EntityUids = jsonSerializer.Deserialize<Guid[]>(settingsJsonData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669174823)]);
      settingObj.EnumUids = jsonSerializer.Deserialize<Guid[]>(settingsJsonData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712267703)]);
      return (object) settingObj;
    }

    /// <summary>Получить список локализуемых перечислений</summary>
    /// <returns>Список локализуемых данных</returns>
    private IEnumerable<LocalizableData> FillEnumListGrid() => (IEnumerable<LocalizableData>) this.metadataEditorService.GetMetadataList(true).OfType<EnumMetadata>().Where<EnumMetadata>((Func<EnumMetadata, bool>) (m => EntityExportLocalizationFileExtension.\u003C\u003Ec.vcK00pv5p4WFrcbkobxW((object) m))).Select<EnumMetadata, LocalizableData>((Func<EnumMetadata, LocalizableData>) (md => new LocalizableData(EntityExportLocalizationFileExtension.\u003C\u003Ec.g2xa7rv5aph5n06l4ysw((object) md), (string) EntityExportLocalizationFileExtension.\u003C\u003Ec.dxAVuOv5DhdifoBVsRx8((object) md)))).OrderBy<LocalizableData, string>((Func<LocalizableData, string>) (o => (string) EntityExportLocalizationFileExtension.\u003C\u003Ec.p075iCv5tLUXSJnobP1t((object) o)));

    /// <summary>Получить список локализуемых справочников</summary>
    /// <returns>Список локализуемых данных</returns>
    private IEnumerable<LocalizableData> FillCatalogListGrid()
    {
      List<EntityMetadata> customObjMd = this.metadataEditorService.GetMetadataList(false).OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (EntityExportLocalizationFileExtension.\u003C\u003Ec.BaFqxvv5wb0ZuCPe1pUC((object) m) != EntityMetadataType.InterfaceImplementation)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return EntityExportLocalizationFileExtension.\u003C\u003Ec.xBtC1ev546vX0cnyEH2L((object) m);
label_3:
        return false;
      })).ToList<EntityMetadata>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (IEnumerable<LocalizableData>) this.metadataEditorService.GetMetadataList(true).OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
      {
        int num1 = 8;
        EntityMetadata m1;
        while (true)
        {
          switch (num1)
          {
            case 1:
            case 3:
              if (!m1.ShowInDesigner)
              {
                num1 = 4;
                continue;
              }
              goto case 6;
            case 2:
              if (m1.Type == EntityMetadataType.Interface)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
                continue;
              }
              goto label_13;
            case 4:
              goto label_13;
            case 5:
              // ISSUE: reference to a compiler-generated method
              if (EntityExportLocalizationFileExtension.\u003C\u003Ec__DisplayClass11_0.qLvDcMv5xRtn39T8sQYQ((object) m1) == EntityMetadataType.Entity)
              {
                num1 = 3;
                continue;
              }
              goto case 2;
            case 6:
              // ISSUE: reference to a compiler-generated method
              if (!EntityExportLocalizationFileExtension.\u003C\u003Ec__DisplayClass11_0.DPFVMbv50RQqmAU3waUr((object) m1))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 9;
                continue;
              }
              goto label_12;
            case 7:
              m1 = m;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 5;
              continue;
            case 8:
              num1 = 7;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated method
              if (!EntityExportLocalizationFileExtension.\u003C\u003Ec__DisplayClass11_0.DPFVMbv50RQqmAU3waUr((object) m1))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                continue;
              }
              goto label_11;
            default:
              goto label_10;
          }
        }
label_10:
        return customObjMd.Exists((Predicate<EntityMetadata>) (cm =>
        {
          int num2 = 2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (EntityExportLocalizationFileExtension.\u003C\u003Ec__DisplayClass11_1.plvIsOv5l7OZ9vJUj3lc((object) cm) == EntityMetadataType.InterfaceExtension)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
                  continue;
                }
                goto label_7;
              case 2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!EntityExportLocalizationFileExtension.\u003C\u003Ec__DisplayClass11_1.Y6FFAYv5d6M0HmDT5lsC(EntityExportLocalizationFileExtension.\u003C\u003Ec__DisplayClass11_1.qtSY51v59G2TMOJIsM8Q((object) cm), EntityExportLocalizationFileExtension.\u003C\u003Ec__DisplayClass11_1.qtSY51v59G2TMOJIsM8Q((object) m1)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
                  continue;
                }
                goto label_8;
              default:
                goto label_6;
            }
          }
label_6:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return EntityExportLocalizationFileExtension.\u003C\u003Ec__DisplayClass11_1.Y6FFAYv5d6M0HmDT5lsC(EntityExportLocalizationFileExtension.\u003C\u003Ec__DisplayClass11_1.ObF154v5rUBwJtCQsNkA((object) cm), EntityExportLocalizationFileExtension.\u003C\u003Ec__DisplayClass11_1.qtSY51v59G2TMOJIsM8Q((object) m1));
label_7:
          return false;
label_8:
          return true;
        }));
label_11:
        return false;
label_12:
        return true;
label_13:
        return false;
      })).Select<EntityMetadata, LocalizableData>((Func<EntityMetadata, LocalizableData>) (md => new LocalizableData(EntityExportLocalizationFileExtension.\u003C\u003Ec.g2xa7rv5aph5n06l4ysw((object) md), (string) EntityExportLocalizationFileExtension.\u003C\u003Ec.dxAVuOv5DhdifoBVsRx8((object) md)))).OrderBy<LocalizableData, string>((Func<LocalizableData, string>) (o => (string) EntityExportLocalizationFileExtension.\u003C\u003Ec.p075iCv5tLUXSJnobP1t((object) o)));
    }

    internal static void Yk46EyGQoxZkfTOlMod8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool PdCY0QGQBSL0jbqnOZ1c() => EntityExportLocalizationFileExtension.USbnqQGQF5nAxn31Jghd == null;

    internal static EntityExportLocalizationFileExtension a2AKeWGQWjRbUqBGE1Ye() => EntityExportLocalizationFileExtension.USbnqQGQF5nAxn31Jghd;
  }
}
