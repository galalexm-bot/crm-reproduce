using System;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO.Mappers;

internal sealed class ModuleMetadataItemDTOMap : BidirectionalMap<ModuleMetadataItem, ModuleMetadataItemDTO>
{
	protected override void InitMap(IMappingExpression<ModuleMetadataItem, ModuleMetadataItemDTO> map)
	{
		base.InitMap(map);
		map.ForMember<ModuleInfoMetadata>((Expression<Func<ModuleMetadataItemDTO, ModuleInfoMetadata>>)((ModuleMetadataItemDTO a) => a.Metadata), (Action<IMemberConfigurationExpression<ModuleMetadataItem, ModuleMetadataItemDTO, ModuleInfoMetadata>>)delegate(IMemberConfigurationExpression<ModuleMetadataItem, ModuleMetadataItemDTO, ModuleInfoMetadata> a)
		{
			a.ResolveUsing<ModuleInfoMetadata>((Func<ModuleMetadataItem, ModuleInfoMetadata>)((ModuleMetadataItem c) => (ModuleInfoMetadata)c.Metadata));
		});
	}

	protected override void InitReverseMap(IMappingExpression<ModuleMetadataItemDTO, ModuleMetadataItem> map)
	{
		base.InitReverseMap(map);
		map.ConstructUsing((Func<ModuleMetadataItemDTO, ModuleMetadataItem>)delegate(ModuleMetadataItemDTO a)
		{
			ModuleMetadataItem moduleMetadataItem = ModuleMetadataItemManager.Instance.LoadOrNull(a.Uid);
			if (moduleMetadataItem == null)
			{
				moduleMetadataItem = ModuleMetadataItemManager.Instance.Create();
			}
			return moduleMetadataItem;
		});
	}
}
