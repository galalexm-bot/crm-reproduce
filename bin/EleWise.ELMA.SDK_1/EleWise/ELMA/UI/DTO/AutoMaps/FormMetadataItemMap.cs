// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.AutoMaps.FormMetadataItemMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.UI.DTO.AutoMaps
{
  public class FormMetadataItemMap : EntityDTOMap<IFormMetadataItem, FormMetadataItemDTO>
  {
    private static FormMetadataItemMap n95dXc9WOeDwiiIp8bJ;

    protected override void InitMap(
      IMappingExpression<IFormMetadataItem, FormMetadataItemDTO> map)
    {
      base.InitMap(map);
    }

    protected override void InitReverseMap(
      IMappingExpression<FormMetadataItemDTO, IFormMetadataItem> map)
    {
      base.InitReverseMap(map);
      map.ForMember<long?>((Expression<Func<IFormMetadataItem, long?>>) (formMetadataItem => formMetadataItem.CreationAuthorId), (Action<IMemberConfigurationExpression<FormMetadataItemDTO, IFormMetadataItem, long?>>) (p => p.Ignore()));
      map.ForMember<DateTime>((Expression<Func<IFormMetadataItem, DateTime>>) (formMetadataItem => formMetadataItem.CreationDate), (Action<IMemberConfigurationExpression<FormMetadataItemDTO, IFormMetadataItem, DateTime>>) (a => a.Ignore()));
    }

    public FormMetadataItemMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool U7PBNS9ojv0WgMcPepA() => FormMetadataItemMap.n95dXc9WOeDwiiIp8bJ == null;

    internal static FormMetadataItemMap SAbJsQ9britqxPQUmK1() => FormMetadataItemMap.n95dXc9WOeDwiiIp8bJ;
  }
}
