using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentLinkModel
{
	private List<IDocument> linkedDocuments = new List<IDocument>();

	public IDocument Document { get; set; }

	[RequiredField]
	public IDocumentLink Link { get; set; }

	[RequiredField]
	[DisplayName(typeof(__Resources_DocumentLinkModel), "P_LinkedDocuments_DisplayName")]
	public List<IDocument> LinkedDocuments
	{
		get
		{
			return linkedDocuments;
		}
		set
		{
			linkedDocuments = value;
		}
	}

	public bool CheckPermissionForLinks { get; set; }
}
