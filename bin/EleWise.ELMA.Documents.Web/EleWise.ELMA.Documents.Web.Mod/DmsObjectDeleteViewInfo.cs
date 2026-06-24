using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class DmsObjectDeleteViewInfo
{
	public List<IDmsObject> DmsObjects { get; set; }

	public string PopupId { get; set; }

	public string RedirectUrl { get; set; }

	public IFolder Folder { get; set; }

	public string JsonDmsObjectIds { get; set; }

	public int Count { get; set; }
}
