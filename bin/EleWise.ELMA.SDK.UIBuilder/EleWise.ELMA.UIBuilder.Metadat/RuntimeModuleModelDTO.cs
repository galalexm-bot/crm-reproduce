using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class RuntimeModuleModelDTO
{
	public ModuleMetadataItemDTO MetadataItem { get; set; }

	public ClientScriptModel Script { get; set; }
}
