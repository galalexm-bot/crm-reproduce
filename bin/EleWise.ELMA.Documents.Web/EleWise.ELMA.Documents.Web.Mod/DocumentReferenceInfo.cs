using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentReferenceInfo : EntityModel<IReference>
{
	public IDocument Document { get; set; }

	public string PopupId { get; set; }

	public IFolder CurrentFolder { get; set; }
}
