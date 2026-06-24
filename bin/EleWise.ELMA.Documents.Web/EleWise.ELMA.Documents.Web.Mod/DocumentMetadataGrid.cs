using System.Collections.Generic;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentMetadataGrid
{
	public List<DocumentMetadataInfo> Data { get; set; }

	public DocumentMetadataGrid()
	{
		Data = new List<DocumentMetadataInfo>();
	}
}
