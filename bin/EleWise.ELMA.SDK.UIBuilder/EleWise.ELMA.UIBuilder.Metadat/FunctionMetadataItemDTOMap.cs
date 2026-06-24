using System;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO.Mappers;

internal sealed class FunctionMetadataItemDTOMap : BidirectionalMap<FunctionMetadataItem, FunctionMetadataItemDTO>
{
	protected override void InitMap(IMappingExpression<FunctionMetadataItem, FunctionMetadataItemDTO> map)
	{
		base.InitMap(map);
		map.ForMember<FunctionMetadata>((Expression<Func<FunctionMetadataItemDTO, FunctionMetadata>>)((FunctionMetadataItemDTO a) => a.Metadata), (Action<IMemberConfigurationExpression<FunctionMetadataItem, FunctionMetadataItemDTO, FunctionMetadata>>)delegate(IMemberConfigurationExpression<FunctionMetadataItem, FunctionMetadataItemDTO, FunctionMetadata> a)
		{
			a.ResolveUsing<FunctionMetadata>((Func<FunctionMetadataItem, FunctionMetadata>)((FunctionMetadataItem c) => (FunctionMetadata)c.Metadata));
		});
	}

	protected override void InitReverseMap(IMappingExpression<FunctionMetadataItemDTO, FunctionMetadataItem> map)
	{
		base.InitReverseMap(map);
		map.ConstructUsing((Func<FunctionMetadataItemDTO, FunctionMetadataItem>)delegate(FunctionMetadataItemDTO a)
		{
			FunctionMetadataItem functionMetadataItem = FunctionMetadataItemManager.Instance.LoadOrNull(a.Uid);
			if (functionMetadataItem == null)
			{
				functionMetadataItem = FunctionMetadataItemManager.Instance.Create();
			}
			return functionMetadataItem;
		});
	}
}
