// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.AutoMaps.MetadataItemDTOMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps
{
  public class MetadataItemDTOMap : EntityDTOMap<IMetadataItem, MetadataItemDTO>
  {
    private static MetadataItemDTOMap F2Gd0dbjVgyyCWhfGqKV;

    protected override void InitMap(
      IMappingExpression<IMetadataItem, MetadataItemDTO> map)
    {
      base.InitMap(map);
      map.ForMember<DateTime>((Expression<Func<MetadataItemDTO, DateTime>>) (metadataItemDto => metadataItemDto.CreationDate), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, DateTime>>) (o => o.MapFrom<DateTime>((Expression<Func<IMetadataItem, DateTime>>) (metadataItem => metadataItem.CreationDate))));
      map.ForMember<long>((Expression<Func<MetadataItemDTO, long>>) (metadataItemDto => metadataItemDto.CreationAuthorId), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long>>) (o => o.MapFrom<long>((Expression<Func<IMetadataItem, long>>) (metadataItem => metadataItem.CreationAuthorId != new long?() ? metadataItem.CreationAuthorId.Value : -1L))));
      map.ForMember<bool>((Expression<Func<MetadataItemDTO, bool>>) (metadataItemDto => metadataItemDto.IsDirtyItem), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, bool>>) (o => o.MapFrom<bool>((Expression<Func<IMetadataItem, bool>>) (metadataItem => metadataItem.Header != default (object) && metadataItem.Header.IsDirtyItem))));
      map.ForMember<long>((Expression<Func<MetadataItemDTO, long>>) (metadataItemDto => metadataItemDto.HeaderId), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long>>) (o => o.MapFrom<long>((Expression<Func<IMetadataItem, long>>) (metadataItem => metadataItem.Header != default (object) ? metadataItem.Header.Id : 0L))));
      map.ForMember<long>((Expression<Func<MetadataItemDTO, long>>) (metadataItemDto => metadataItemDto.HeaderGroupId), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long>>) (o => o.MapFrom<long>((Expression<Func<IMetadataItem, long>>) (metadataItem => metadataItem.Header != default (object) && metadataItem.Header.Group != default (object) ? metadataItem.Header.Group.Id : 0L))));
      map.ForMember<DateTime>((Expression<Func<MetadataItemDTO, DateTime>>) (metadataItemDto => metadataItemDto.HeaderCreationDate), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, DateTime>>) (o => o.MapFrom<DateTime>((Expression<Func<IMetadataItem, DateTime>>) (metadataItem => metadataItem.Header != default (object) ? metadataItem.Header.CreationDate : DateTime.MinValue))));
      map.ForMember<long>((Expression<Func<MetadataItemDTO, long>>) (metadataItemDto => metadataItemDto.HeaderCreationAuthorId), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long>>) (o => o.MapFrom<long>((Expression<Func<IMetadataItem, long>>) (metadataItem => metadataItem.Header != default (object) && metadataItem.Header.CreationAuthorId != new long?() ? metadataItem.Header.CreationAuthorId.Value : -1L))));
      map.ForMember<string>((Expression<Func<MetadataItemDTO, string>>) (metadataItemDto => metadataItemDto.HeaderTag), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, string>>) (o => o.MapFrom<string>((Expression<Func<IMetadataItem, string>>) (metadataItem => metadataItem.Header != default (object) ? metadataItem.Header.Tag : default (string)))));
      map.ForMember<long?>((Expression<Func<MetadataItemDTO, long?>>) (metadataItemDto => metadataItemDto.PublishedId), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long?>>) (o => o.MapFrom<long?>((Expression<Func<IMetadataItem, long?>>) (metadataItem => metadataItem.Header != default (object) && metadataItem.Header.Published != default (object) ? (long?) metadataItem.Header.Published.Id : new long?()))));
      map.ForMember<DateTime>((Expression<Func<MetadataItemDTO, DateTime>>) (metadataItemDto => metadataItemDto.PublishedCreationDate), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, DateTime>>) (o => o.MapFrom<DateTime>((Expression<Func<IMetadataItem, DateTime>>) (metadataItem => metadataItem.Header != default (object) && metadataItem.Header.Published != default (object) ? metadataItem.Header.Published.CreationDate : DateTime.MinValue))));
      map.ForMember<long?>((Expression<Func<MetadataItemDTO, long?>>) (metadataItemDto => metadataItemDto.PublishedCreationAuthorId), (Action<IMemberConfigurationExpression<IMetadataItem, MetadataItemDTO, long?>>) (o => o.MapFrom<long>((Expression<Func<IMetadataItem, long>>) (metadataItem => metadataItem.Header != default (object) && metadataItem.Header.Published != default (object) && metadataItem.Header.Published.CreationAuthorId != new long?() ? metadataItem.Header.Published.CreationAuthorId.Value : -1L))));
    }

    protected override void InitReverseMap(
      IMappingExpression<MetadataItemDTO, IMetadataItem> map)
    {
      base.InitReverseMap(map);
      map.ForMember<IMetadataItemHeader>((Expression<Func<IMetadataItem, IMetadataItemHeader>>) (metadataItem => metadataItem.Header), (Action<IMemberConfigurationExpression<MetadataItemDTO, IMetadataItem, IMetadataItemHeader>>) (o => o.Ignore()));
      map.AfterMap((Action<MetadataItemDTO, IMetadataItem>) ((d, e) =>
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_4;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (MetadataItemDTOMap.\u003C\u003Ec.q0uMYCC0kIjKx4gI2fpP((object) e) == null)
              {
                num = 2;
                continue;
              }
              break;
          }
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          MetadataItemDTOMap.\u003C\u003Ec.l1tUsyC0O3xuts0QYsoA(MetadataItemDTOMap.\u003C\u003Ec.q0uMYCC0kIjKx4gI2fpP((object) e), MetadataItemDTOMap.\u003C\u003Ec.RZVHTRC0nD41afYEXMyP((object) d) <= 0L ? (object) (IMetadataItemGroup) null : (object) EntityManager<IMetadataItemGroup>.Instance.LoadOrNull((object) d.HeaderGroupId));
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
        }
label_6:
        return;
label_4:;
      }));
    }

    public MetadataItemDTOMap()
    {
      MetadataItemDTOMap.PJS1y0bjR9YRUJ2QjIkv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void PJS1y0bjR9YRUJ2QjIkv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool R73jPVbjSFpHuL39Y9M6() => MetadataItemDTOMap.F2Gd0dbjVgyyCWhfGqKV == null;

    internal static MetadataItemDTOMap JwbLsAbjiBiwhEHdkuX5() => MetadataItemDTOMap.F2Gd0dbjVgyyCWhfGqKV;
  }
}
