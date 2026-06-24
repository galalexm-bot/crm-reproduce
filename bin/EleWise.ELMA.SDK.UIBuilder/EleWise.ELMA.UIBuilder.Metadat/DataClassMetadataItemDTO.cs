using System;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class DataClassMetadataItemDTO
{
	public Guid Uid { get; set; }

	public Guid Header_Uid { get; set; }

	public DataClassMetadata Metadata { get; set; }

	public DateTime CreationDate { get; set; }

	public long? CreationAuthorId { get; set; }

	public bool IsPublished { get; set; }
}
