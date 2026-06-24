using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class SystemMetadata
{
	public ModuleInfoMetadata ModuleMetadata { get; }

	public ClientScriptModel Script { get; set; }

	public SystemMetadata(ModuleInfoMetadata moduleMetadata)
	{
		Contract.ArgumentNotNull(moduleMetadata, "ModuleMetadata");
		ModuleMetadata = moduleMetadata;
	}
}
