using System;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO
{
	public sealed class DataClassMetadataItemHeaderDTO
	{
		public Guid Uid { get; set; }

		public string Name { get; set; }

		public string DisplayName { get; set; }

		public DateTime CreationDate { get; set; }

		public long? CreationAuthorId { get; set; }

		public Guid Draft_Uid { get; set; }

		public Guid? Published_Uid { get; set; }

		public Guid ModuleUid { get; set; }

		public bool Internal { get; set; }

		public bool IsDirtyItem { get; set; }

		public Guid? Group_Uid { get; set; }
	}
}
namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO.Mappers
{
	internal sealed class DataClassMetadataItemHeaderDTOMap : BidirectionalMap<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>
	{
		protected override void InitReverseMap(IMappingExpression<DataClassMetadataItemHeaderDTO, DataClassMetadataItemHeader> map)
		{
			base.InitReverseMap(map);
			map.ConstructUsing((Func<DataClassMetadataItemHeaderDTO, DataClassMetadataItemHeader>)delegate(DataClassMetadataItemHeaderDTO a)
			{
				DataClassMetadataItemHeader dataClassMetadataItemHeader = DataClassMetadataItemHeaderManager.Instance.LoadOrNull(a.Uid);
				if (dataClassMetadataItemHeader == null)
				{
					dataClassMetadataItemHeader = DataClassMetadataItemHeaderManager.Instance.Create();
				}
				return dataClassMetadataItemHeader;
			});
		}
	}
}
