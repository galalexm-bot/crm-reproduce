using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Managers.Filters;

public class DocumentLinkFilter : Filter
{
	public IDocument Document { get; set; }

	public DocumentLinkTypes LinkType { get; set; }
}
