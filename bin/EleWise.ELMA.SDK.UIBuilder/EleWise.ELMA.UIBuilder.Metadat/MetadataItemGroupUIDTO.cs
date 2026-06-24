using System;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class MetadataItemGroupUIDTO
{
	public Guid Uid { get; set; }

	public string Name { get; set; }

	public string DisplayName { get; set; }

	public Guid? Parent_Uid { get; set; }

	public Guid MetadataTypeUid { get; set; }

	public Guid ModuleUid { get; set; }
}
