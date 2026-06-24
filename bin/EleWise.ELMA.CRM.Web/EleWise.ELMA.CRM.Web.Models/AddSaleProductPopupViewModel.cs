using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.CRM.Web.Models;

public class AddSaleProductPopupViewModel : FormViewModel
{
	public ISaleProduct Entity { get; set; }

	public string PopupId { get; set; }

	public string GridId { get; set; }

	public string PopupPrefix { get; set; }

	public string JsonDataId { get; set; }

	public string IdAttributeName { get; set; }
}
