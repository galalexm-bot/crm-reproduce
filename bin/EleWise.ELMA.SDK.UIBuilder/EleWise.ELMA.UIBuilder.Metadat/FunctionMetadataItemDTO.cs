using System;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class FunctionMetadataItemDTO
{
	public Guid Uid { get; set; }

	public DateTime CreationDate { get; set; }

	public long? CreationAuthorId { get; set; }

	public FunctionMetadata Metadata { get; set; }

	public Guid Header_Uid { get; set; }

	public ScriptModuleDTO ScriptModule { get; set; }
}
