using System;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO.Mappers;

internal sealed class MetadataItemGroupUIDTOMap : BidirectionalMap<MetadataItemGroupUI, MetadataItemGroupUIDTO>
{
	protected override void InitReverseMap(IMappingExpression<MetadataItemGroupUIDTO, MetadataItemGroupUI> map)
	{
		base.InitReverseMap(map);
		map.ConstructUsing((Func<MetadataItemGroupUIDTO, MetadataItemGroupUI>)delegate(MetadataItemGroupUIDTO a)
		{
			MetadataItemGroupUI metadataItemGroupUI = MetadataItemGroupUIManager.Instance.LoadOrNull(a.Uid);
			if (metadataItemGroupUI == null)
			{
				metadataItemGroupUI = MetadataItemGroupUIManager.Instance.Create();
			}
			return metadataItemGroupUI;
		});
	}
}
