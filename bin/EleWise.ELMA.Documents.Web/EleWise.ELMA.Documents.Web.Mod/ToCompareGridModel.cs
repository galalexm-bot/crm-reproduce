using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Documents.Web.Models;

public class ToCompareGridModel
{
	public GridData<IDocumentVersion> Data { get; set; }

	public IDocumentVersion Version { get; set; }
}
