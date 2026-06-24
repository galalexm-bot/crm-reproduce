using System;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO.Mappers;

internal sealed class FunctionMetadataItemHeaderDTOMap : BidirectionalMap<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>
{
	protected override void InitReverseMap(IMappingExpression<FunctionMetadataItemHeaderDTO, FunctionMetadataItemHeader> map)
	{
		base.InitReverseMap(map);
		map.ConstructUsing((Func<FunctionMetadataItemHeaderDTO, FunctionMetadataItemHeader>)delegate(FunctionMetadataItemHeaderDTO a)
		{
			FunctionMetadataItemHeader functionMetadataItemHeader = FunctionMetadataItemHeaderManager.Instance.LoadOrNull(a.Uid);
			if (functionMetadataItemHeader == null)
			{
				functionMetadataItemHeader = FunctionMetadataItemHeaderManager.Instance.Create();
			}
			return functionMetadataItemHeader;
		});
	}
}
