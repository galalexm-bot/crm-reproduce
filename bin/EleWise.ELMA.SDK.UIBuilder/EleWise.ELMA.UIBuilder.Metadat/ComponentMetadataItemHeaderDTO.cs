using System;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO
{
	public sealed class ComponentMetadataItemHeaderDTO
	{
		public Guid Uid { get; set; }

		public string Name { get; set; }

		public string DisplayName { get; set; }

		public DateTime CreationDate { get; set; }

		public long? CreationAuthorId { get; set; }

		public bool IsDirtyItem { get; set; }

		public Guid Draft_Uid { get; set; }

		public DateTime? Draft_CreationDate { get; set; }

		public Guid? Published_Uid { get; set; }

		public Guid? Emulation_Uid { get; set; }

		public Guid ModuleUid { get; set; }

		public Guid MetadataTypeUid { get; set; }

		public Guid? Group_Uid { get; set; }

		public bool Internal { get; set; }
	}
}
namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO.Mappers
{
	internal sealed class ComponentMetadataItemHeaderDTOMap : BidirectionalMap<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>
	{
		protected override void InitReverseMap(IMappingExpression<ComponentMetadataItemHeaderDTO, ComponentMetadataItemHeader> map)
		{
			base.InitReverseMap(map);
			map.ConstructUsing((Func<ComponentMetadataItemHeaderDTO, ComponentMetadataItemHeader>)delegate(ComponentMetadataItemHeaderDTO a)
			{
				ComponentMetadataItemHeader componentMetadataItemHeader = ComponentMetadataItemHeaderManager.Instance.LoadOrNull(a.Uid);
				if (componentMetadataItemHeader == null)
				{
					componentMetadataItemHeader = ComponentMetadataItemHeaderManager.Instance.Create();
				}
				return componentMetadataItemHeader;
			});
		}
	}
}
