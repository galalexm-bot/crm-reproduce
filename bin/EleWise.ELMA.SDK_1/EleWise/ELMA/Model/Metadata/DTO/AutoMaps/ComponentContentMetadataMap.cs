// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.AutoMaps.ComponentContentMetadataMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps
{
  /// <summary>Преобразование метаданных содержимого компонента</summary>
  internal class ComponentContentMetadataMap : 
    EntityDTOMap<ComponentContentMetadata, ComponentContentMetadataDTO>
  {
    internal static ComponentContentMetadataMap skGJRNb5DMKLxUbg70j6;

    /// <inheritdoc />
    protected override void InitMap(
      IMappingExpression<ComponentContentMetadata, ComponentContentMetadataDTO> map)
    {
      base.InitMap(map);
      map.ForMember<ComponentContextMetadata>((Expression<Func<ComponentContentMetadataDTO, ComponentContextMetadata>>) (contentMetadataDto => contentMetadataDto.Context), (Action<IMemberConfigurationExpression<ComponentContentMetadata, ComponentContentMetadataDTO, ComponentContextMetadata>>) (a => a.MapFrom<ComponentContextMetadata>((Expression<Func<ComponentContentMetadata, ComponentContextMetadata>>) (componentContentMetadata => this.CopyContextToDTO(componentContentMetadata.Context)))));
    }

    /// <summary>Копировать контекст</summary>
    /// <param name="context">Метаданные контекста компонента</param>
    protected virtual ComponentContextMetadata CopyContextToDTO(ComponentContextMetadata context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (context != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (ComponentContextMetadata) null;
label_5:
      return Mapper.Map<ComponentContextMetadata, ComponentContextMetadata>(context, new ComponentContextMetadata());
    }

    public ComponentContentMetadataMap()
    {
      ComponentContentMetadataMap.t6srCeb54q0cyCsUByUl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool cWAQl4b5tAecxVBCt2TX() => ComponentContentMetadataMap.skGJRNb5DMKLxUbg70j6 == null;

    internal static ComponentContentMetadataMap gaj2WNb5w2g5KcgDq2tK() => ComponentContentMetadataMap.skGJRNb5DMKLxUbg70j6;

    internal static void t6srCeb54q0cyCsUByUl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
