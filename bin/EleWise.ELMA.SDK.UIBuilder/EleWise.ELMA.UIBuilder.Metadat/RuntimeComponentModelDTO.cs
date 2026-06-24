using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class RuntimeComponentModelDTO
{
	public ComponentMetadataItemDTO MetadataItem { get; set; }

	public ClientScriptModel Script { get; set; }
}
