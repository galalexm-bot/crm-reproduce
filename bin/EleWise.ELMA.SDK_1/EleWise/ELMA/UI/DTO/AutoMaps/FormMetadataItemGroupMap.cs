// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.AutoMaps.FormMetadataItemGroupMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.UI.DTO.AutoMaps
{
  public class FormMetadataItemGroupMap : 
    EntityDTOMap<IFormMetadataItemGroup, FormMetadataItemGroupDTO>
  {
    private static FormMetadataItemGroupMap Fo16XkJYGrpPN2GscYq;

    protected override void InitMap(
      IMappingExpression<IFormMetadataItemGroup, FormMetadataItemGroupDTO> map)
    {
      base.InitMap(map);
    }

    protected override void InitReverseMap(
      IMappingExpression<FormMetadataItemGroupDTO, IFormMetadataItemGroup> map)
    {
      base.InitReverseMap(map);
      map.ForMember<ISet<IFormMetadataItemHeader>>((Expression<Func<IFormMetadataItemGroup, ISet<IFormMetadataItemHeader>>>) (metadataItemGroup => metadataItemGroup.Headers), (Action<IMemberConfigurationExpression<FormMetadataItemGroupDTO, IFormMetadataItemGroup, ISet<IFormMetadataItemHeader>>>) (a => a.Ignore()));
      map.ForMember<ISet<IFormMetadataItemGroup>>((Expression<Func<IFormMetadataItemGroup, ISet<IFormMetadataItemGroup>>>) (metadataItemGroup => metadataItemGroup.Groups), (Action<IMemberConfigurationExpression<FormMetadataItemGroupDTO, IFormMetadataItemGroup, ISet<IFormMetadataItemGroup>>>) (a => a.Ignore()));
      map.ForMember<IFormMetadataItemGroup>((Expression<Func<IFormMetadataItemGroup, IFormMetadataItemGroup>>) (metadataItemGroup => metadataItemGroup.Parent), (Action<IMemberConfigurationExpression<FormMetadataItemGroupDTO, IFormMetadataItemGroup, IFormMetadataItemGroup>>) (a => a.MapFrom<IFormMetadataItemGroup>((Expression<Func<FormMetadataItemGroupDTO, IFormMetadataItemGroup>>) (metadataItemGroupDto => EntityManager<IFormMetadataItemGroup>.Instance.LoadOrNull((object) metadataItemGroupDto.ParentId)))));
    }

    public FormMetadataItemGroupMap()
    {
      FormMetadataItemGroupMap.xZSssBJsFae5A11BE59();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void xZSssBJsFae5A11BE59() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool KT7gj1JLVARXA72goFm() => FormMetadataItemGroupMap.Fo16XkJYGrpPN2GscYq == null;

    internal static FormMetadataItemGroupMap yW0A48JUBf0Cyh7Oyia() => FormMetadataItemGroupMap.Fo16XkJYGrpPN2GscYq;
  }
}
