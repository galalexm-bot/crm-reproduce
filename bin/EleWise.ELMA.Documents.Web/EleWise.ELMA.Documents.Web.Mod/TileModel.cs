using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Web.Models;

public class TileModel : EntityModel<IDocumentVersion>
{
	public string Name { get; set; }

	public long VersionId { get; set; }

	public string ButtonCallback { get; set; }
}
