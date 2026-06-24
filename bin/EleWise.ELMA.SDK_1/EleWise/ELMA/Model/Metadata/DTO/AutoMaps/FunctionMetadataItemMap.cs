// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.AutoMaps.FunctionMetadataItemMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps
{
  /// <summary>
  /// Преобразование элемента метаданных функции и DTO элемента
  /// </summary>
  internal class FunctionMetadataItemMap : 
    EntityDTOMap<FunctionMetadataItem, FunctionMetadataItemDTO>
  {
    private static FunctionMetadataItemMap n8JSRKbjEEyyPGdEtWtV;

    /// <inheritdoc />
    protected override void InitMap(
      IMappingExpression<FunctionMetadataItem, FunctionMetadataItemDTO> map)
    {
      base.InitMap(map);
      map.ForMember<object>((Expression<Func<FunctionMetadataItemDTO, object>>) (functionMetadataItemDto => functionMetadataItemDto.Metadata), (Action<IMemberConfigurationExpression<FunctionMetadataItem, FunctionMetadataItemDTO, object>>) (a => a.MapFrom<object>((Expression<Func<FunctionMetadataItem, object>>) (functionMetadataItem => this.CopyMetadataToDTO(functionMetadataItem.Metadata)))));
    }

    /// <summary>Копировать метаданные</summary>
    private object CopyMetadataToDTO(object metadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (metadata is FunctionMetadata source)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
label_3:
      return (object) Mapper.Map<FunctionMetadata, FunctionMetadataDTO>(source, new FunctionMetadataDTO());
    }

    public FunctionMetadataItemMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool WVjaRQbjfJG60j07b8pk() => FunctionMetadataItemMap.n8JSRKbjEEyyPGdEtWtV == null;

    internal static FunctionMetadataItemMap ittCmXbjQxehfAOPvadd() => FunctionMetadataItemMap.n8JSRKbjEEyyPGdEtWtV;
  }
}
