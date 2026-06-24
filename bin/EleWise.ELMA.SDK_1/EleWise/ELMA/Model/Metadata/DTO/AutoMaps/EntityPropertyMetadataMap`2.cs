// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.AutoMaps.EntityPropertyMetadataMap`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps
{
  public class EntityPropertyMetadataMap<TSource, TTarget> : SimpleMap<TSource, TTarget>
    where TSource : EntityPropertyMetadata
    where TTarget : EntityPropertyMetadata
  {
    private static object zgG4BhbjZl50oSOtFmKp;

    protected override void InitMap(IMappingExpression<TSource, TTarget> map)
    {
      base.InitMap(map);
      map.ForMember<long>((Expression<Func<TTarget, long>>) (target => target.Id), (Action<IMemberConfigurationExpression<TSource, TTarget, long>>) (opt => opt.Ignore()));
      map.ForMember<EntityMetadata>((Expression<Func<TTarget, EntityMetadata>>) (target => target.Owner), (Action<IMemberConfigurationExpression<TSource, TTarget, EntityMetadata>>) (opt => opt.Ignore()));
    }

    public EntityPropertyMetadataMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool vhP905bju8437sRmenPo() => EntityPropertyMetadataMap<TSource, TTarget>.zgG4BhbjZl50oSOtFmKp == null;

    internal static object BWyOUfbjIaLHeCaLnVt2() => EntityPropertyMetadataMap<TSource, TTarget>.zgG4BhbjZl50oSOtFmKp;
  }
}
