using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class GroupReferenceInfo
{
	public List<IDocument> Documents { get; set; }

	public IFolder Folder { get; set; }

	public string PopupId { get; set; }

	public List<IReference> References { get; set; }

	public IFolder CurrentFolder { get; set; }
}
