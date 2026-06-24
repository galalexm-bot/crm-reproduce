// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.AutoMaps.ComponentMetadataItemMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps
{
  /// <summary>
  /// Преобразование элемента метаданных компонента и DTO элемента
  /// </summary>
  internal class ComponentMetadataItemMap : 
    EntityDTOMap<ComponentMetadataItem, ComponentMetadataItemDTO>
  {
    internal static ComponentMetadataItemMap OLgHXJbjBF3ed473WDLn;

    /// <inheritdoc />
    protected override void InitMap(
      IMappingExpression<ComponentMetadataItem, ComponentMetadataItemDTO> map)
    {
      base.InitMap(map);
      map.ForMember<object>((Expression<Func<ComponentMetadataItemDTO, object>>) (componentMetadataItemDto => componentMetadataItemDto.Metadata), (Action<IMemberConfigurationExpression<ComponentMetadataItem, ComponentMetadataItemDTO, object>>) (a => a.MapFrom<object>((Expression<Func<ComponentMetadataItem, object>>) (componentMetadataItem => this.CopyMetadataToDTO(componentMetadataItem.Metadata)))));
    }

    /// <summary>Копировать метаданные</summary>
    private object CopyMetadataToDTO(object metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(metadata is ComponentMetadata source))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (object) null;
label_5:
      return (object) Mapper.Map<ComponentMetadata, ComponentMetadataDTO>(source, new ComponentMetadataDTO());
    }

    public ComponentMetadataItemMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool rKg4OEbjWayhbK8lRYWl() => ComponentMetadataItemMap.OLgHXJbjBF3ed473WDLn == null;

    internal static ComponentMetadataItemMap UIspCdbjoQxiyL5Ru3lP() => ComponentMetadataItemMap.OLgHXJbjBF3ed473WDLn;
  }
}
