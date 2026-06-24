using System;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO.Mappers;

internal sealed class DataClassMetadataItemDTOMap : BidirectionalMap<DataClassMetadataItem, DataClassMetadataItemDTO>
{
	protected override void InitMap(IMappingExpression<DataClassMetadataItem, DataClassMetadataItemDTO> map)
	{
		base.InitMap(map);
		map.ForMember<DataClassMetadata>((Expression<Func<DataClassMetadataItemDTO, DataClassMetadata>>)((DataClassMetadataItemDTO a) => a.Metadata), (Action<IMemberConfigurationExpression<DataClassMetadataItem, DataClassMetadataItemDTO, DataClassMetadata>>)delegate(IMemberConfigurationExpression<DataClassMetadataItem, DataClassMetadataItemDTO, DataClassMetadata> a)
		{
			a.ResolveUsing<DataClassMetadata>((Func<DataClassMetadataItem, DataClassMetadata>)((DataClassMetadataItem c) => (DataClassMetadata)c.Metadata));
		});
	}

	protected override void InitReverseMap(IMappingExpression<DataClassMetadataItemDTO, DataClassMetadataItem> map)
	{
		base.InitReverseMap(map);
		map.ConstructUsing((Func<DataClassMetadataItemDTO, DataClassMetadataItem>)delegate(DataClassMetadataItemDTO a)
		{
			DataClassMetadataItem dataClassMetadataItem = DataClassMetadataItemManager.Instance.LoadOrNull(a.Uid);
			if (dataClassMetadataItem == null)
			{
				dataClassMetadataItem = DataClassMetadataItemManager.Instance.Create();
			}
			return dataClassMetadataItem;
		});
	}
}
