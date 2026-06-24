// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.AutoMaps.DataClassMetadataItemMap
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
  /// Преобразование элемента метаданных датакласса и DTO элемента
  /// </summary>
  internal class DataClassMetadataItemMap : 
    EntityDTOMap<DataClassMetadataItem, DataClassMetadataItemDTO>
  {
    internal static DataClassMetadataItemMap wnxnVqb5jAcXEOLh9yAW;

    /// <inheritdoc />
    protected override void InitMap(
      IMappingExpression<DataClassMetadataItem, DataClassMetadataItemDTO> map)
    {
      base.InitMap(map);
      map.ForMember<object>((Expression<Func<DataClassMetadataItemDTO, object>>) (classMetadataItemDto => classMetadataItemDto.Metadata), (Action<IMemberConfigurationExpression<DataClassMetadataItem, DataClassMetadataItemDTO, object>>) (a => a.MapFrom<object>((Expression<Func<DataClassMetadataItem, object>>) (classMetadataItem => this.CopyMetadataToDTO(classMetadataItem.Metadata)))));
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
            if (!(metadata is DataClassMetadata source))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
label_3:
      return (object) Mapper.Map<DataClassMetadata, DataClassMetadata>(source, new DataClassMetadata());
    }

    public DataClassMetadataItemMap()
    {
      DataClassMetadataItemMap.H68RbTb5Ul0P9BT4rPY5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool hIq2nob5YDJfKexh9d4I() => DataClassMetadataItemMap.wnxnVqb5jAcXEOLh9yAW == null;

    internal static DataClassMetadataItemMap JfltqMb5Lwab492BET2l() => DataClassMetadataItemMap.wnxnVqb5jAcXEOLh9yAW;

    internal static void H68RbTb5Ul0P9BT4rPY5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
