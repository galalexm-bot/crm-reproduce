using System;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class ComponentMetadataItemDTO
{
	public Guid Uid { get; set; }

	public DateTime CreationDate { get; set; }

	public long? CreationAuthorId { get; set; }

	public ComponentMetadata Metadata { get; set; }

	public Guid Header_Uid { get; set; }

	public ScriptModuleDTO ScriptModule { get; set; }

	public string Comment { get; set; }

	public ScriptModuleDTO ClientScriptModule { get; set; }

	public ScriptModuleDTO ViewScriptModule { get; set; }

	public ScriptModuleDTO TestScriptModule { get; set; }

	public bool IsWork { get; set; }

	public long? VersionNumber { get; set; }

	public bool IsPublished { get; set; }

	public bool IsEmulation { get; set; }

	public Guid MetadataTypeUid { get; set; }
}
