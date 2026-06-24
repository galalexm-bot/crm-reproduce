using System;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class ModuleMetadataItemDTO
{
	public Guid Uid { get; set; }

	public DateTime CreationDate { get; set; }

	public long? CreationAuthorId { get; set; }

	public ModuleInfoMetadata Metadata { get; set; }

	public Guid Header_Uid { get; set; }

	public string AssemblyName { get; set; }

	public string Version { get; set; }
}
