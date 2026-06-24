using System;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class FunctionMetadataItemHeaderDTO
{
	public Guid Uid { get; set; }

	public string Name { get; set; }

	public string DisplayName { get; set; }

	public DateTime CreationDate { get; set; }

	public long? CreationAuthorId { get; set; }

	public Guid Draft_Uid { get; set; }

	public Guid? Published_Uid { get; set; }

	public Guid ModuleUid { get; set; }

	public bool IsDirtyItem { get; set; }

	public Guid? Group_Uid { get; set; }
}
