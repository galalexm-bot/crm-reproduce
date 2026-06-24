// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Models.ComponentContentMetadataDTO
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Metadata.DTO.Models
{
  /// <summary>DTO метаданных компонента</summary>
  [Serializable]
  public sealed class ComponentContentMetadataDTO : EntityDTO<long>
  {
    private static ComponentContentMetadataDTO VCn7d1brpX4lodlkySM6;

    /// <summary>Метаданные контекста компонента</summary>
    public ComponentContextMetadata Context
    {
      get => this.\u003CContext\u003Ek__BackingField;
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
              this.\u003CContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
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

    public ComponentContentMetadataDTO()
    {
      ComponentContentMetadataDTO.EIIDxibrt2NChdFMpMId();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool AuEG4Ebra4aaeoYJNhiZ() => ComponentContentMetadataDTO.VCn7d1brpX4lodlkySM6 == null;

    internal static ComponentContentMetadataDTO AF9kFcbrDXfWMWT6nDRj() => ComponentContentMetadataDTO.VCn7d1brpX4lodlkySM6;

    internal static void EIIDxibrt2NChdFMpMId() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
