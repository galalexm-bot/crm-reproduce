using System.Collections.Generic;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

namespace EleWise.ELMA.IntegrationDevServer.Models;

public class MetadataSourceModel
{
	public IList<ComponentMetadataItemDTO> Components { get; set; }

	public IList<DataClassMetadataItemDTO> DataClasses { get; set; }

	public IList<FunctionMetadataItemDTO> Functions { get; set; }

	public MetadataSourceModel()
	{
		Components = new List<ComponentMetadataItemDTO>();
		DataClasses = new List<DataClassMetadataItemDTO>();
		Functions = new List<FunctionMetadataItemDTO>();
	}
}
