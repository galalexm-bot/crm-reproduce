using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class MetadataItemGroupDTO
{
	public Guid Uid { get; set; }

	public long Id { get; set; }

	public long ParentId { get; set; }

	public string Name { get; set; }

	public string DisplayName { get; set; }

	public string Namespace { get; set; }

	public bool IsSystem { get; set; }

	public DateTime CreationDate { get; set; }

	public long? CreationAuthorId { get; set; }

	public List<MetadataItemGroupDTO> SubGroups { get; set; }
}
