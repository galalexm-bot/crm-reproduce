using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Web.Models;

public class ReferenceInfo : EntityModel<IReference>
{
	public string PopupId { get; set; }

	public long CurrentFolder { get; set; }
}
