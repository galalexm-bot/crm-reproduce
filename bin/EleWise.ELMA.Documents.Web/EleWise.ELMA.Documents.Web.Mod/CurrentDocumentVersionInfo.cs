using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class CurrentDocumentVersionInfo
{
	public IDocumentVersion Version { get; set; }

	public IDocument Document { get; set; }
}
