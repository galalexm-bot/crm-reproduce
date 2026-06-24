using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Web.Models;

public class FolderReferenceInfo : EntityModel<IReference>
{
	public IFolder Folder { get; set; }

	public string PopupId { get; set; }
}
