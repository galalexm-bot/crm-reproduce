using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Documents.Web.Models;

public class ArchiveModel : EntityModel<IDocument>
{
	public bool Archivate { get; set; }

	public long[] DocumentIds { get; set; }

	[StringSettings(MultiLine = true)]
	public string Comment { get; set; }
}
