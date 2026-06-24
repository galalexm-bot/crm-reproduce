using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class ModuleMetadataItemHeaderDTO
{
	public Guid Uid { get; set; }

	public string Name { get; set; }

	public string DisplayName { get; set; }

	public string Description { get; set; }

	public DateTime CreationDate { get; set; }

	public long? CreationAuthorId { get; set; }

	public Guid Draft_Uid { get; set; }

	public Guid Published_Uid { get; set; }

	public List<string> Editions { get; set; }

	public ModuleMetadataItemHeaderDTO()
	{
		Editions = new List<string>();
	}
}
