// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.AutoMaps.FormMetadataItemHeaderMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.UI.DTO.AutoMaps
{
  public class FormMetadataItemHeaderMap : 
    EntityDTOMap<IFormMetadataItemHeader, FormMetadataItemHeaderDTO>
  {
    internal static FormMetadataItemHeaderMap eMS2G7Jcr9NbVCxwjjv;

    protected override void InitMap(
      IMappingExpression<IFormMetadataItemHeader, FormMetadataItemHeaderDTO> map)
    {
      base.InitMap(map);
    }

    protected override void InitReverseMap(
      IMappingExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader> map)
    {
      base.InitReverseMap(map);
      map.ForMember<long?>((Expression<Func<IFormMetadataItemHeader, long?>>) (metadataItemHeader => metadataItemHeader.CreationAuthorId), (Action<IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, long?>>) (p => p.Ignore()));
      map.ForMember<DateTime>((Expression<Func<IFormMetadataItemHeader, DateTime>>) (metadataItemHeader => metadataItemHeader.CreationDate), (Action<IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, DateTime>>) (p => p.Ignore()));
      map.ForMember<IFormMetadataItem>((Expression<Func<IFormMetadataItemHeader, IFormMetadataItem>>) (metadataItemHeader => metadataItemHeader.Draft), (Action<IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, IFormMetadataItem>>) (p => p.Ignore()));
      map.ForMember<IFormMetadataItem>((Expression<Func<IFormMetadataItemHeader, IFormMetadataItem>>) (metadataItemHeader => metadataItemHeader.Published), (Action<IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, IFormMetadataItem>>) (p => p.Ignore()));
      map.ForMember<IFormMetadataItemGroup>((Expression<Func<IFormMetadataItemHeader, IFormMetadataItemGroup>>) (metadataItemHeader => metadataItemHeader.Group), (Action<IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, IFormMetadataItemGroup>>) (p => p.MapFrom<IFormMetadataItemGroup>((Expression<Func<FormMetadataItemHeaderDTO, IFormMetadataItemGroup>>) (metadataItemHeaderDto => metadataItemHeaderDto.GroupId != new long?() ? EntityManager<IFormMetadataItemGroup>.Instance.LoadOrNull((object) metadataItemHeaderDto.GroupId.Value) : default (IFormMetadataItemGroup)))));
    }

    public FormMetadataItemHeaderMap()
    {
      FormMetadataItemHeaderMap.B07F0g9B2wnGLPBbapA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void B07F0g9B2wnGLPBbapA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool CrIdHeJzLpaAkvx58YR() => FormMetadataItemHeaderMap.eMS2G7Jcr9NbVCxwjjv == null;

    internal static FormMetadataItemHeaderMap zysRGA9FqsOOayxhbvO() => FormMetadataItemHeaderMap.eMS2G7Jcr9NbVCxwjjv;
  }
}
