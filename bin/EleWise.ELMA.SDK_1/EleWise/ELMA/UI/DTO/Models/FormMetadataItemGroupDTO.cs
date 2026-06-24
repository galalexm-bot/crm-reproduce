// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.Models.FormMetadataItemGroupDTO
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.DTO;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.DTO.Models
{
  [Serializable]
  public class FormMetadataItemGroupDTO : EntityDTO<long>
  {
    internal static FormMetadataItemGroupDTO kybHnEJTjyTgcx5x6wE;

    /// <summary>Конструктор</summary>
    public FormMetadataItemGroupDTO()
    {
      FormMetadataItemGroupDTO.ILYhRKJOtMgjElIFbN2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Headers = new List<FormMetadataItemHeaderDTO>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.Groups = new List<FormMetadataItemGroupDTO>();
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Имя группы</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
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

    /// <summary>Идентификатор родительской группы</summary>
    public long? ParentId { get; set; }

    /// <summary>Тип метаданных</summary>
    public Guid MetadataType
    {
      get => this.\u003CMetadataType\u003Ek__BackingField;
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
              this.\u003CMetadataType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
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

    /// <summary>Заголовки форм</summary>
    public List<FormMetadataItemHeaderDTO> Headers { get; set; }

    /// <summary>Подгруппы</summary>
    public List<FormMetadataItemGroupDTO> Groups { get; set; }

    internal static void ILYhRKJOtMgjElIFbN2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool EYIXVUJk9fhystUnEXj() => FormMetadataItemGroupDTO.kybHnEJTjyTgcx5x6wE == null;

    internal static FormMetadataItemGroupDTO g4uKwlJnyHRdLcHtEUL() => FormMetadataItemGroupDTO.kybHnEJTjyTgcx5x6wE;
  }
}
