using System;

namespace EleWise.ELMA.Documents.Web.Models;

public class CreateDocumentActionParameters
{
	public Guid DocumentTypeUid { get; set; }

	public string Parameters { get; set; }
}
