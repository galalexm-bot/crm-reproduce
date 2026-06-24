using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class DmsObjectMoveViewInfo
{
	public List<IDmsObject> DmsObjects { get; set; }

	public string PopupId { get; set; }

	public IFolder OldFolder { get; set; }

	public IFolder NewFolder { get; set; }

	public string RedirectUrl { get; set; }

	public string JsonDmsObjectIds { get; set; }

	public int Count { get; set; }

	public string EditMode { get; set; }
}
