// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.AutoMaps.MetadataItemGroupDTOMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps
{
  public class MetadataItemGroupDTOMap : EntityDTOMap<IMetadataItemGroup, MetadataItemGroupDTO>
  {
    internal static MetadataItemGroupDTOMap c4tQqBbjqtOVjiaeJvwu;

    protected override void InitMap(
      IMappingExpression<IMetadataItemGroup, MetadataItemGroupDTO> map)
    {
      base.InitMap(map);
      map.ForMember<long>((Expression<Func<MetadataItemGroupDTO, long>>) (metadataItemGroupDto => metadataItemGroupDto.CreationAuthorId), (Action<IMemberConfigurationExpression<IMetadataItemGroup, MetadataItemGroupDTO, long>>) (o => o.MapFrom<long>((Expression<Func<IMetadataItemGroup, long>>) (metadataItemGroup => metadataItemGroup.CreationAuthorId != new long?() ? metadataItemGroup.CreationAuthorId.Value : -1L))));
    }

    protected override void InitReverseMap(
      IMappingExpression<MetadataItemGroupDTO, IMetadataItemGroup> map)
    {
      base.InitReverseMap(map);
      map.ForMember<IMetadataItemGroup>((Expression<Func<IMetadataItemGroup, IMetadataItemGroup>>) (metadataItemGroup => metadataItemGroup.Parent), (Action<IMemberConfigurationExpression<MetadataItemGroupDTO, IMetadataItemGroup, IMetadataItemGroup>>) (o => o.MapFrom<IMetadataItemGroup>((Expression<Func<MetadataItemGroupDTO, IMetadataItemGroup>>) (metadataItemGroupDto => metadataItemGroupDto.ParentId > 0L ? EntityManager<IMetadataItemGroup>.Instance.LoadOrNull((object) metadataItemGroupDto.ParentId) : default (IMetadataItemGroup)))));
      map.ForMember<ISet<IMetadataItemGroup>>((Expression<Func<IMetadataItemGroup, ISet<IMetadataItemGroup>>>) (metadataItemGroup => metadataItemGroup.SubGroups), (Action<IMemberConfigurationExpression<MetadataItemGroupDTO, IMetadataItemGroup, ISet<IMetadataItemGroup>>>) (a => a.Ignore()));
    }

    public MetadataItemGroupDTOMap()
    {
      MetadataItemGroupDTOMap.CQM1H6bjTUMheY15978M();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void CQM1H6bjTUMheY15978M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Eyi8SxbjKGAnPfruJbX3() => MetadataItemGroupDTOMap.c4tQqBbjqtOVjiaeJvwu == null;

    internal static MetadataItemGroupDTOMap QaFtxMbjXDwOQa5dg1hO() => MetadataItemGroupDTOMap.c4tQqBbjqtOVjiaeJvwu;
  }
}
