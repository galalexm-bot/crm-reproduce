using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentVersionGridWindow : FormViewModel
{
	public long DocumentId { get; set; }

	public string GridId { get; set; }

	public string PopupId { get; set; }

	public string Target { get; set; }

	public string OnSave { get; set; }
}
