using System.Collections.Generic;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class RuntimeResponse
{
	public List<RuntimeModuleModelDTO> Modules { get; set; }

	public List<RuntimeDataClassModelDTO> DataClasses { get; set; }

	public List<RuntimeComponentModelDTO> Components { get; set; }
}
