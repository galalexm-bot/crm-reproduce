using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class VisibleGroupInfoDTO
{
	public Guid Uid { get; set; }

	public Guid ParentUid { get; set; }

	public string DisplayName { get; set; }

	public List<VisibleViewItemInfoDTO> Items { get; }

	public VisibleGroupInfoDTO()
	{
		Items = new List<VisibleViewItemInfoDTO>();
	}
}
