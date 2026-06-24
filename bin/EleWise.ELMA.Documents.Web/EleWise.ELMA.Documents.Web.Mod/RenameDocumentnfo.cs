using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Types.Validation;

namespace EleWise.ELMA.Documents.Web.Models;

public class RenameDocumentnfo
{
	public IDocument Document { get; set; }

	[RequiredField]
	public string Name { get; set; }

	public IDocumentVersion Version { get; set; }

	public int Index { get; set; }
}
