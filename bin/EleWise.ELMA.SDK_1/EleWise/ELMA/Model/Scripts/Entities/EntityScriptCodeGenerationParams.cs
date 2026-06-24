// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Entities.EntityScriptCodeGenerationParams
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts.Entities
{
  /// <summary>
  /// Параметры генерации кода для модуля сценариев сущности
  /// </summary>
  public class EntityScriptCodeGenerationParams
  {
    private static EntityScriptCodeGenerationParams RROeh2bPpM6VJmHpVyc6;

    /// <summary>Метаданные</summary>
    public EntityMetadata Metadata
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
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

    /// <summary>Элемент метаданных</summary>
    public MetadataItemDTO MetadataItem
    {
      get => this.\u003CMetadataItem\u003Ek__BackingField;
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
              this.\u003CMetadataItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    public EntityScriptCodeGenerationParams()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool PMcnyUbPaKem73xri8UI() => EntityScriptCodeGenerationParams.RROeh2bPpM6VJmHpVyc6 == null;

    internal static EntityScriptCodeGenerationParams tMgI0CbPDm9q0iqnmwpE() => EntityScriptCodeGenerationParams.RROeh2bPpM6VJmHpVyc6;
  }
}
